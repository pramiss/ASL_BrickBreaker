using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace BrickBreaker
{
    public partial class BrickBreaker : Form
    {
        int gameState; // 0: Intro, 1: CountDown, 2: Game play, 3: Result.
        Random rand = new Random();

        public BrickBreaker()
        {
            InitializeComponent();
        }

        private void BrickBreaker_Load(object sender, EventArgs e)
        {
            ChangeGameState(0);
            paddle1.Width = 220;
            paddle2.Width = 220;
        }

        // Introduction Panel
        private void btnGameStart_Click(object sender, EventArgs e)
        {
            countdownStart();
        }

        // CountDown Panel
        int panelCountDown_countdown = 3;
        private void countdownStart()
        {
            ChangeGameState(1);
            timerCountdown.Start();

        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            if (panelCountDown_countdown == 1)
            {
                timerCountdown.Stop();
                ChangeGameState(2);
                timerGamePlay.Start(); // Gameplay 시작
                timerBrickGeneration.Start(); // 벽돌 생성 시작
            }

            panelCountDown_countdown--;
            lblCountdown.Text = panelCountDown_countdown.ToString();
        }

        // ====== GamePlay Panel ======
        // 패들 관련
        private int paddleSpeed = 6;
        bool p1LeftPressed, p1RightPressed, p2LeftPressed, p2RightPressed;
        // 볼 관련
        private int ballSpeedX = 4;
        private int ballSpeedY = 4;
        // 벽돌 관련
        List<PictureBox> bricks = new List<PictureBox>(); // 모든 벽돌 컨트롤을 담을 리스트
        private int maxBallSpeed = 7; // 공의 최대 속도 제한
        private int minBallSpeed = 4; // 공의 최대 속도 제한
        // 아이템 관련
        List<PictureBox> items_red = new List<PictureBox>(); // player2 방향(Y > 0)으로 떨어질 아이템
        List<PictureBox> items_blue = new List<PictureBox>(); // player1 방향(Y < 0)으로 떨어질 아이템
        private int itemSpeed = 4;

        // -- 플레이어 키 입력 --
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // 눌린 키에 따라 상태 플래그를 true로 변경합니다.
            if (keyData == Keys.A) p1LeftPressed = true;
            if (keyData == Keys.D) p1RightPressed = true;
            if (keyData == Keys.Left) p2LeftPressed = true;
            if (keyData == Keys.Right) p2RightPressed = true;

            // 이벤트를 여기서 끝내지 않고, 다른 기본적인 키 처리도 가능하도록
            // base 메서드를 호출해주는 것이 좋습니다.
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void BrickBreaker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) p1LeftPressed = true;
            if (e.KeyCode == Keys.D) p1RightPressed = true;
            if (e.KeyCode == Keys.Left) p2LeftPressed = true;
            if (e.KeyCode == Keys.Right) p2RightPressed = true;
        }
        private void BrickBreaker_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) p1LeftPressed = false;
            if (e.KeyCode == Keys.D) p1RightPressed = false;
            if (e.KeyCode == Keys.Left) p2LeftPressed = false;
            if (e.KeyCode == Keys.Right) p2RightPressed = false;
        }

        // -- 실제 모든 게임 구현 --
        private void timerGamePlay_Tick(object sender, EventArgs e)
        {
            // 0. 게임 상태 확인
            if (gameState != 2) return;

            // -------------- 키 입력 -------------- //
            // 1. 현재 키 상태에 따라 패들을 움직인다 (독립적인 if문)
            if (p1LeftPressed) paddle1.Left -= paddleSpeed;
            if (p1RightPressed) paddle1.Left += paddleSpeed;
            if (p2LeftPressed) paddle2.Left -= paddleSpeed;
            if (p2RightPressed) paddle2.Left += paddleSpeed;

            // 2. 화면 경계 체크
            if (paddle1.Left < 0) paddle1.Left = 0;
            if (paddle1.Right > this.ClientSize.Width) paddle1.Left = this.ClientSize.Width - paddle1.Width;

            if (paddle2.Left < 0) paddle2.Left = 0;
            if (paddle2.Right > this.ClientSize.Width) paddle2.Left = this.ClientSize.Width - paddle2.Width;
            // -------------- 키 입력 -------------- //

            // -------------- A. 공 움직임 -------------- //

            // a. 속도만큼 공 위치를 업데이트
            green_ball.Left += ballSpeedX;
            green_ball.Top += ballSpeedY;

            // b. 벽 충돌 감지 및 방향 전환
            //    좌우 벽에 부딪혔을 때
            if (green_ball.Left <= 0 || green_ball.Right >= this.ClientSize.Width)
            {
                ballSpeedX = -ballSpeedX;
            }
            //    위쪽 벽에 부딪혔을 때
            if (green_ball.Top <= 0)
            {
                if (paddle1.Width <= 120)
                {
                    GameOver(2); // player2 승리
                    return;
                }

                ballSpeedY = -ballSpeedY;
                paddle1.Width -= 50;
            }
            //    아래쪽 벽에 부딪혔을 때
            if (green_ball.Bottom >= this.ClientSize.Height)
            {
                if (paddle2.Width <= 120)
                {
                    GameOver(1); // player1 승리
                    return;
                }

                ballSpeedY = -ballSpeedY;
                paddle2.Width -= 50;
            }

            // -------------- B. 아이템 움직임 -------------- //
            // --- Player2(아래)로 향하는 아이템들 (items_red) 처리 ---
            for (int i = items_red.Count - 1; i >= 0; i--)
            {
                PictureBox item = items_red[i];

                // 1. 아이템을 아래로 이동
                item.Top += itemSpeed;

                // 2. Player2 패들과의 충돌 감지
                if (item.Bounds.IntersectsWith(paddle2.Bounds))
                {
                    // 충돌 발생. 아이템 효과 적용
                    string itemType = Convert.ToString(item.Tag);

                    if (itemType == "SpeedDown")
                    {
                        // 공 속도 감소 (최소 속도 제한)
                        if (Math.Abs(ballSpeedX) > minBallSpeed)
                        {
                            ballSpeedX -= (ballSpeedX > 0 ? 1 : -1);
                        }
                        if (Math.Abs(ballSpeedY) > minBallSpeed)
                        {
                            ballSpeedY -= (ballSpeedY > 0 ? 1 : -1);
                        }
                    }
                    else if (itemType == "PaddleUp")
                    {
                        // Player2 패들 너비 증가 (최대 너비 제한)
                        if (paddle2.Width < 220)
                        {
                            paddle2.Width += 50;
                        }
                    }

                    // 획득한 아이템 제거
                    items_red.RemoveAt(i);
                    panelGameplay.Controls.Remove(item);
                    item.Dispose();
                    continue; // 다음 아이템으로 넘어감 (아래의 화면 이탈 코드 실행 방지)
                }

                // 3. 화면 하단 경계를 벗어났는지 확인
                if (item.Top > panelGameplay.ClientSize.Height)
                {
                    // 화면을 벗어났으므로 아이템 제거
                    items_red.RemoveAt(i);
                    panelGameplay.Controls.Remove(item);
                    item.Dispose();
                }
            }

            // --- Player1(위)로 향하는 아이템들 (items_blue) 처리 ---
            for (int i = items_blue.Count - 1; i >= 0; i--)
            {
                PictureBox item = items_blue[i];

                // 1. 아이템을 위로 이동
                item.Top -= itemSpeed;

                // 2. Player1 패들과의 충돌 감지
                if (item.Bounds.IntersectsWith(paddle1.Bounds))
                {
                    // 충돌 발생. 아이템 효과 적용
                    string itemType = Convert.ToString(item.Tag);

                    if (itemType == "SpeedDown")
                    {
                        // 공 속도 감소 (최소 속도 제한)
                        if (Math.Abs(ballSpeedX) > minBallSpeed)
                        {
                            ballSpeedX -= (ballSpeedX > 0 ? 1 : -1);
                        }
                        if (Math.Abs(ballSpeedY) > minBallSpeed)
                        {
                            ballSpeedY -= (ballSpeedY > 0 ? 1 : -1);
                        }
                    }
                    else if (itemType == "PaddleUp")
                    {
                        // Player1 패들 너비 증가 (최대 너비 제한)
                        if (paddle1.Width < 220)
                        {
                            paddle1.Width += 50;
                        }
                    }

                    // 획득한 아이템 제거
                    items_blue.RemoveAt(i);
                    panelGameplay.Controls.Remove(item);
                    item.Dispose();
                    continue; // 다음 아이템으로 넘어감 (아래의 화면 이탈 코드 실행 방지)
                }

                // 3. 화면 상단 경계를 벗어났는지 확인
                if (item.Bottom < 0)
                {
                    // 화면을 벗어났으므로 아이템 제거
                    items_blue.RemoveAt(i);
                    panelGameplay.Controls.Remove(item);
                    item.Dispose();
                }
            }



            // -------------- 공과 패들 충돌 감지 -------------- //
            // 1. 공이 player1의 패들과 충돌했는지 확인
            if (green_ball.Bounds.IntersectsWith(paddle1.Bounds))
            {
                // 공이 패들 아래에서 위로 올라가던 중이어야 함 (ballSpeedY < 0)
                if (ballSpeedY < 0)
                {
                    ballSpeedY = -ballSpeedY; // Y방향을 반대로 전환
                }
            }

            // 2. 공이 player2의 패들과 충돌했는지 확인
            if (green_ball.Bounds.IntersectsWith(paddle2.Bounds))
            {
                // 공이 패들 위에서 아래로 내려오던 중이어야 함 (ballSpeedY > 0)
                if (ballSpeedY > 0)
                {
                    ballSpeedY = -ballSpeedY; // Y방향을 반대로 전환
                }
            }


            // 3. 공과 벽돌 충돌 감지
            for (int i = bricks.Count - 1; i >= 0; i--)
            {
                var brick = bricks[i];

                // 벽돌이 화면에 보이고(항상 보임), 공과 충돌했다면
                if (green_ball.Bounds.IntersectsWith(brick.Bounds))
                {

                    // 2. 공의 속도 증가 (최대 속도 제한)
                    // X, Y 속도의 절대값을 1씩 증가시킨다.
                    if (Math.Abs(ballSpeedX) < maxBallSpeed)
                    {
                        ballSpeedX += (ballSpeedX > 0 ? 1 : -1);
                    }
                    if (Math.Abs(ballSpeedY) < maxBallSpeed)
                    {
                        ballSpeedY += (ballSpeedY > 0 ? 1 : -1);
                    }

                    // 3. 공의 방향 반전
                    int overlapX = Math.Min(green_ball.Right, brick.Right) - Math.Max(green_ball.Left, brick.Left);
                    int overlapY = Math.Min(green_ball.Bottom, brick.Bottom) - Math.Max(green_ball.Top, brick.Top);

                    if (overlapX >= overlapY)
                    {
                        // 수직 충돌 (공이 벽돌의 위 또는 아래에 부딪힘)
                        ballSpeedY = -ballSpeedY;
                    }
                    else
                    {
                        // 수평 충돌 (공이 벽돌의 왼쪽 또는 오른쪽에 부딪힘)
                        ballSpeedX = -ballSpeedX;
                    }

                    // 충돌한 벽돌에 따라 아이템 생성
                    // 1. 아이템 드롭 확률 결정 (현재: 50%)
                    int dropChance = rand.Next(1, 101); // 1부터 100까지의 난수 생성
                    if (dropChance <= 50)
                    {
                        // 2. 아이템 종류 결정 (50% 확률로 "SpeedDown" 또는 "PaddleUp")
                        string itemType = (rand.Next(0, 2) == 0) ? "SpeedDown" : "PaddleUp";

                        // 3. 아이템 PictureBox 생성 및 설정
                        PictureBox newItem = new PictureBox();
                        newItem.SizeMode = PictureBoxSizeMode.StretchImage; // 이미지가 상자에 맞게 조절됨

                        // 아이템 종류에 따라 다른 이미지와 Tag 설정
                        if (itemType == "SpeedDown")
                        {
                            newItem.Image = Properties.Resources.speed_down_icon; // 볼 speed down 아이템 생성
                            newItem.Tag = "SpeedDown";
                            newItem.Size = new Size(25, 25); // 아이템 크기
                        }
                        else // "PaddleUp"
                        {
                            newItem.Image = Properties.Resources.paddle_up_icon; // 패들 크기 늘리는 아이템 생성
                            newItem.Tag = "PaddleUp";
                            newItem.Size = new Size(35, 35); // 아이템 크기
                        }

                        // 아이템 생성 위치는 깨진 벽돌의 중앙
                        newItem.Location = new Point(
                            brick.Location.X + (brick.Width / 2) - (newItem.Width / 2),
                            brick.Location.Y + (brick.Height / 2) - (newItem.Height / 2)
                        );

                        // 4. 깨진 벽돌의 Tag에 따라 어느 리스트에 추가할지 결정
                        if (Convert.ToString(brick.Tag) == "brick-red")
                        {
                            // Player2(아래) 방향으로 떨어질 아이템
                            items_red.Add(newItem);
                        }
                        else // "brick-blue"
                        {
                            // Player1(위) 방향으로 떨어질 아이템
                            items_blue.Add(newItem);
                        }

                        // 5. 생성된 아이템을 게임 패널에 추가
                        panelGameplay.Controls.Add(newItem);
                        newItem.BringToFront(); // 아이템이 다른 컨트롤에 가려지지 않게 함
                    }


                    // 벽돌을 화면(패널)과 리스트에서 모두 제거
                    panelGameplay.Controls.Remove(brick);
                    bricks.RemoveAt(i);
                    brick.Dispose(); // 메모리에서 완전히 해제

                    // 여러 벽돌을 한번에 깨는 것을 방지하기 위해 루프 탈출
                    break;
                }
            }


        } //-- timerGamePlay_Tick

        

        //---------- 벽돌 생성 타이머 ----------//
        private void timerBrickGeneration_Tick(object sender, EventArgs e)
        {
            // 한 번에 2개의 벽돌 생성
            for (int i = 0; i < 2; i++)
            {
                // 1. 새로운 PictureBox 인스턴스 생성
                PictureBox newBrick = new PictureBox();

                // 2. 속성 설정
                newBrick.Size = new Size(70, 35); // 벽돌 크기
                if (i == 1)
                {   // 벽돌 이미지 할당
                    newBrick.Image = Properties.Resources.brick_icon_basic;
                    newBrick.Tag = "brick-red";
                } else
                {
                    newBrick.Image = Properties.Resources.brick_icon_blue;
                    newBrick.Tag = "brick-blue";
                }
                newBrick.SizeMode = PictureBoxSizeMode.StretchImage;
                newBrick.Visible = true;

                // 3. 랜덤 위치 계산
                // X 좌표: 게임 패널 너비 안에서 랜덤
                int locationX = rand.Next(0, panelGameplay.ClientSize.Width - newBrick.Width);
                // Y 좌표: 위아래 패들 영역을 피해 중앙 영역에서만 랜덤 (화면 높이의 25% ~ 65% 사이)
                int minY = (int)(panelGameplay.ClientSize.Height * 0.25);
                int maxY = (int)(panelGameplay.ClientSize.Height * 0.65);
                int locationY = rand.Next(minY, maxY - newBrick.Height);

                newBrick.Location = new Point(locationX, locationY);

                // 4. 생성된 벽돌을 컨트롤과 리스트에 추가
                bricks.Add(newBrick);
                panelGameplay.Controls.Add(newBrick);
                newBrick.BringToFront(); // 다른 컨트롤에 가려지지 않게 맨 앞으로 가져옴
                green_ball.BringToFront(); // 공이 항상 가장 위에 있도록 다시 설정
            }
        }


        //-- 게임오버 --
        private void GameOver(int player)
        {
            // 남아있는 모든 벽돌을 제거
            foreach (var brick in bricks.ToList())
            {
                panelGameplay.Controls.Remove(brick);
                brick.Dispose();
            }
            bricks.Clear(); // 리스트 비우기

            timerGamePlay.Stop();
            MessageBox.Show("게임 오버");
            ChangeGameState(3);
            ShowResultPanel(player); //
        }

        // Result Panel
        private void ShowResultPanel(int player)
        {
            // 승자에 따라 다른 이미지 표시
            if (player == 1)
            {
                // Player 1이 승리했을 때의 이미지
                pbResultImage.Image = Properties.Resources.player1_wins; // 리소스에 이미지 추가 필요
            }
            else // player가 2일 때
            {
                // Player 2가 승리했을 때의 이미지
                pbResultImage.Image = Properties.Resources.player2_wins; // 리소스에 이미지 추가 필요
            }

            // 3. PictureBox의 크기와 위치 설정
            pbResultImage.Size = new Size(510, 340);
            pbResultImage.Location = new Point(93, 23);

            // 4. 이미지가 PictureBox 크기에 맞게 조절되도록 설정
            pbResultImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-- setting
        private void ChangeGameState(int gameState)
        {
            this.gameState = gameState;

            switch (this.gameState)
            {
                case 0:
                    panelIntro.Visible = true;
                    panelCountDown.Visible = false;
                    panelGameplay.Visible = false;
                    panelResult.Visible = false;
                    break;
                case 1:
                    panelIntro.Visible = false;
                    panelCountDown.Visible = true;
                    panelGameplay.Visible = false;
                    panelResult.Visible = false;
                    break;
                case 2:
                    panelIntro.Visible = false;
                    panelCountDown.Visible = false;
                    panelGameplay.Visible = true;
                    panelResult.Visible = false;
                    break;
                case 3:
                    panelIntro.Visible = false;
                    panelCountDown.Visible = false;
                    panelGameplay.Visible = false;
                    panelResult.Visible = true;
                    break;
            }
        } //-- ChangeGameState
    }
}
