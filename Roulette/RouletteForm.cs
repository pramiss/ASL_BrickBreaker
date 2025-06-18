using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette
{
    public partial class Roulette : Form
    {
        // 룰렛의 구성 항목 리스트
        private List<string> items = new List<string>();
        // 각 항목에 칠할 색상 리스트
        private List<Color> colors = new List<Color>();
        // 룰렛이 돌아갔는지 확인
        private bool isSpinned = false;

        Random rand = new Random();

        private float currentAngle = 0f;    // 룰렛의 현재 회전 각도
        private float spinSpeed = 0f;       // 현재 회전 속도 (매 틱마다 얼마나 돌지)
        private float targetAngle = 0f; // 당첨 항목의 각도 (목표각도)
        private int winnerIndex; // 당첨 항목 인덱스를 저장해 둘 변수

        public Roulette()
        {
            InitializeComponent();
        }

        private void Roulette_Load(object sender, EventArgs e)
        {
            restartGame();
        }

        // Roulette 그리기
        private void panelRoulette_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Panel의 반지름 크기 설정 및 원 그리기.
            int panelSize = Math.Min(panelRoulette.Width, panelRoulette.Height);
            Rectangle rect = new Rectangle(5, 5, panelSize - 10, panelSize - 10);

            // 각 벌칙이 차지할 각도(부채꼴)를 계산. (360도 / 항목 수)
            float sweepAngle = 360f / items.Count;

            // 각 항목을 부채꼴(Pie) 형태로 그리기
            for (int i = 0; i < items.Count; i++)
            {
                // 루프마다 i값을 이용해 시작 각도를 새로 계산
                float startAngle = currentAngle + (i * sweepAngle);

                // 1. Brush를 이용해 각 부채꼴 색칠
                using (SolidBrush brush = new SolidBrush(colors[i]))
                {
                    g.FillPie(brush, rect, startAngle, sweepAngle);
                }

                // 2. Pen을 이용해 같은 위치에 검정색 테두리 그려줌.
                using (Pen borderPen = new Pen(Color.Black, 1f))
                {
                    g.DrawPie(borderPen, rect, startAngle, sweepAngle);
                }
            }

            // 각 항목의 텍스트 추가하기
            for (int i = 0; i < items.Count; i++)
            {
                // 텍스트를 그릴 중심 각도를 계산
                float textCenterAngle = currentAngle + (i * sweepAngle) + (sweepAngle / 2);
                float textAngleRad = (float)(textCenterAngle * Math.PI / 180f);

                // 원의 중심과 텍스트가 위치할 반지름을 설정
                PointF center = new PointF(rect.X + rect.Width / 2f, rect.Y + rect.Height / 2f);
                float radius = panelSize / 3f;

                // 텍스트 위치(x, y)를 계산
                float x = center.X + (float)(radius * Math.Cos(textAngleRad));
                float y = center.Y + (float)(radius * Math.Sin(textAngleRad));

                // 텍스트 폰트 설정 및 정렬
                using (Font textFont = new Font("맑은 고딕", 10f, FontStyle.Regular))
                {
                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;

                        g.DrawString(items[i], textFont, Brushes.Black, x, y, sf);
                    }
                }
            }

        }

        // ============= 룰렛 돌리기 로직 ============= //

        // 레버 돌리기
        private void btnRever_Click(object sender, EventArgs e)
        {
            if (isSpinned) return;

            btnRever.Enabled = false;


            // 실제 벌칙은 미리 뽑아 놓는다.
            winnerIndex = rand.Next(0, items.Count);
            float sweepAngle = 360f / items.Count;
            float winnerAngle = (360 - (winnerIndex * sweepAngle)) - (sweepAngle / 2) + 270;

            targetAngle = winnerAngle + (360 * rand.Next(15, 20));

            spinSpeed = 50.0f;

            // 룰렛 timer on
            timerSpin.Start();
            isSpinned = true;
        }

        // 실제 룰렛 돌리기
        private void timerSpin_Tick(object sender, EventArgs e)
        {
            // 목표각도까지 남은 각도 계산
            float remainingAngle = targetAngle - currentAngle;

            // 1. 정지 조건 확인: 속도가 매우 느려졌다면 타이머를 멈추기
            if (remainingAngle < 1f)
            {
                currentAngle = targetAngle; // 오차 보정: 목표 지점에 정확히 맞춤
                timerSpin.Stop();
                btnReroll.Enabled = true;
                MessageBox.Show($"결과: {items[winnerIndex]}");
                return;
            }

            // 2. 각도 업데이트: 현재 각도에 속도를 더해 룰렛을 회전.
            currentAngle += spinSpeed;

            // 3. 감속: 남은 각도에 따라 속도 스핀 속도를 조절
            spinSpeed = remainingAngle * 0.03f;

            // 4. 룰렛 업데이트
            panelRoulette.Invalidate();
        }


        // 룰렛 다시 돌리기.
        private void btnReroll_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        // 게임 초기화
        private void restartGame()
        {
            // 버튼 초기화
            btnRever.Enabled = true;
            btnReroll.Enabled = false;
            isSpinned = false;

            // 변수 초기화
            currentAngle = 0f;
            spinSpeed = 0f;
            targetAngle = 0f;

            // 1. 룰렛에 표시할 항목들 추가
            items.Clear();
            items.Add("원샷!");
            items.Add("투샷!!");
            items.Add("모두 건배!!");
            items.Add("상대방에게 한잔!");
            items.Add("같이 한잔!");
            items.Add("꽝");

            // 2. 항목에 칠할 색상 생성
            colors.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                if (i % 3 == 0)
                    colors.Add(Color.FromArgb(0, 202, 255));
                else if (i % 3 == 1)
                    colors.Add(Color.FromArgb(255, 0, 0));
                else
                    colors.Add(Color.FromArgb(255, 235, 0));
            }

            // 3. Panel 컨트롤의 Paint 이벤트를 연결
            panelRoulette.Paint += panelRoulette_Paint;

            // (더블 버퍼링 활성화)
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, panelRoulette, new object[] { true });
        }
    }
}
