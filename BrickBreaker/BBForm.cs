using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class BrickBreaker : Form
    {
        int gameState; // 0: Intro, 1: CountDown, 2: Game play, 3: Result.

        public BrickBreaker()
        {
            InitializeComponent();
        }

        private void BrickBreaker_Load(object sender, EventArgs e)
        {
            ChangeGameState(0);
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
                timerGamePlay.Start();
            }

            panelCountDown_countdown--;
            lblCountdown.Text = panelCountDown_countdown.ToString();
        }

        // == GamePlay Panel ==
        // 패들 관련
        private int paddleSpeed = 4;
        bool p1LeftPressed, p1RightPressed, p2LeftPressed, p2RightPressed;
        // 볼 관련
        private int ballSpeedX = 3;
        private int ballSpeedY = 3;

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

            // -------------- 공 움직임 -------------- //

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
                    GameOver();
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
                    GameOver();
                    return;
                }

                ballSpeedY = -ballSpeedY;
                paddle2.Width -= 50;
            }
        }

        //-- 게임오버 --
        private void GameOver()
        {
            timerGamePlay.Stop();
            MessageBox.Show("게임 오버");
            ChangeGameState(3);
        }

        // Result Panel

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
