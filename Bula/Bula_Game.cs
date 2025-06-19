using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bula
{
    public partial class Bula_Game : Form
    {
        private const int GridSize = 15;
        private const int CellSize = 30;
        private const int MaxBlockArea = 9;

        private Point player1Pos = new Point(3, 3);
        private Point player2Pos = new Point(11, 11);

        // 0=빈칸, 1=player1, 2=player2
        private int[,] trailOwner = new int[GridSize, GridSize];

        private List<Rectangle> blocks = new List<Rectangle>();
        private List<Brush> blockBrushes = new List<Brush>();

        private Image player1Img;
        private Image player2Img;

        private int score1 = 0;
        private int score2 = 0;
        private int timeLeft = 60; // 초 단위

        public Bula_Game()
        {
            InitializeComponent();

            // 이미지 로드
            var basePath = Application.StartupPath;
            player1Img = Image.FromFile(Path.Combine(basePath, "banana_cat.jpg"));
            player2Img = Image.FromFile(Path.Combine(basePath, "sad-apple.gif"));

            // 폼 설정
            this.ClientSize = new Size(GridSize * CellSize, GridSize * CellSize);
            this.DoubleBuffered = true;
            this.KeyPreview = true;

            // 이벤트 바인딩
            this.Load += Bula_Game_Load;
            this.KeyDown += Bula_Game_KeyDown;
            this.Paint += Bula_Game_Paint;

            // 타이머 설정
            GameTimer.Interval = 1000;
            GameTimer.Tick += GameTimer_Tick;
        }

        private void Bula_Game_Load(object sender, EventArgs e)
        {
            // 시작 위치에 자취 표시
            trailOwner[player1Pos.Y, player1Pos.X] = 1;
            trailOwner[player2Pos.Y, player2Pos.X] = 2;

            // 랜덤 블럭 생성
            GenerateBlocks();

            // 점수판·타이머 초기화
            lblScore1.Text = "0";
            lblScore2.Text = "0";
            lblTime.Text = timeLeft.ToString();

            GameTimer.Start();

            this.Focus();
            this.Invalidate();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTime.Text = timeLeft.ToString();
            if (timeLeft <= 0)
            {
                GameTimer.Stop();
                MessageBox.Show(
                    $"Time’s up!\nPlayer1: {score1}점\nPlayer2: {score2}점"
                );
            }
        }

        private void GenerateBlocks()
        {
            var rnd = new Random();
            blocks.Clear();
            blockBrushes.Clear();

            // 가능한 블럭 크기 리스트 (면적 ≤ MaxBlockArea)
            var shapes = new List<Size>
            {
                new Size(6,1), new Size(1,6),
                new Size(5,1), new Size(1,5),
                new Size(4,1), new Size(1,4),
                new Size(3,2), new Size(2,3),
                new Size(3,1), new Size(1,3),
                new Size(2,2),
                new Size(2,1), new Size(1,2),
                new Size(1,1)
            }
            // 면적 내림차순, 동일 면적군 랜덤 섞기
            .OrderByDescending(s => s.Width * s.Height)
            .ThenBy(_ => rnd.Next())
            .ToList();

            var forbidden = new HashSet<Point> { player1Pos, player2Pos };

            foreach (var sz in shapes)
            {
                // 배치 후보 좌표 생성 후 랜덤 섞기
                var candidates = new List<Point>();
                for (int y = 1; y <= GridSize - sz.Height - 1; y++)
                    for (int x = 1; x <= GridSize - sz.Width - 1; x++)
                        candidates.Add(new Point(x, y));
                candidates = candidates.OrderBy(_ => rnd.Next()).ToList();

                foreach (var p in candidates)
                {
                    var rect = new Rectangle(p, sz);

                    // 1) 테두리 & 시작 위치 배제
                    if (forbidden.Any(pt => rect.Contains(pt)))
                        continue;

                    // 2) 블럭 간 최소 1칸 간격 확보 (Chebyshev distance 1)
                    bool tooClose = blocks.Any(b =>
                        new Rectangle(b.X - 1, b.Y - 1, b.Width + 2, b.Height + 2)
                        .IntersectsWith(rect)
                    );
                    if (tooClose)
                        continue;

                    // 3) 경로 연결성 검사
                    blocks.Add(rect);
                    if (FreeSpaceIsConnected())
                        blockBrushes.Add(Brushes.DarkGray);
                    else
                        blocks.RemoveAt(blocks.Count - 1);
                }
            }
        }

        private bool FreeSpaceIsConnected()
        {
            int totalFree = 0;
            for (int r = 0; r < GridSize; r++)
                for (int c = 0; c < GridSize; c++)
                    if (!blocks.Any(b => b.Contains(new Point(c, r))))
                        totalFree++;
            if (totalFree == 0) return true;

            var visited = new bool[GridSize, GridSize];
            var q = new Queue<Point>();

            // 첫 빈칸 찾아 BFS 시작
            bool started = false;
            for (int r = 0; r < GridSize && !started; r++)
                for (int c = 0; c < GridSize; c++)
                    if (!blocks.Any(b => b.Contains(new Point(c, r))))
                    {
                        visited[r, c] = true;
                        q.Enqueue(new Point(c, r));
                        started = true;
                        break;
                    }

            int count = 0;
            Point[] dirs = { new Point(1, 0), new Point(-1, 0), new Point(0, 1), new Point(0, -1) };
            while (q.Count > 0)
            {
                var p = q.Dequeue();
                count++;
                foreach (var d in dirs)
                {
                    var np = new Point(p.X + d.X, p.Y + d.Y);
                    if (np.X < 0 || np.X >= GridSize || np.Y < 0 || np.Y >= GridSize) continue;
                    if (visited[np.Y, np.X]) continue;
                    if (blocks.Any(b => b.Contains(np))) continue;
                    visited[np.Y, np.X] = true;
                    q.Enqueue(np);
                }
            }

            return count == totalFree;
        }

        private void Bula_Game_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            int dotSize = CellSize / 4;
            int off = (CellSize - dotSize) / 2;

            // 1) 그리드 + 자취
            for (int r = 0; r < GridSize; r++)
                for (int c = 0; c < GridSize; c++)
                {
                    var cell = new Rectangle(c * CellSize, r * CellSize, CellSize, CellSize);
                    g.FillRectangle(Brushes.White, cell);
                    g.DrawRectangle(Pens.Black, cell);

                    int owner = trailOwner[r, c];
                    if (owner == 1)
                        g.FillEllipse(Brushes.LightBlue,
                            c * CellSize + off, r * CellSize + off, dotSize, dotSize);
                    else if (owner == 2)
                        g.FillEllipse(Brushes.LightCoral,
                            c * CellSize + off, r * CellSize + off, dotSize, dotSize);
                }

            // 2) 블럭
            for (int i = 0; i < blocks.Count; i++)
            {
                var b = blocks[i];
                var br = blockBrushes[i];
                var rect = new Rectangle(
                    b.X * CellSize, b.Y * CellSize,
                    b.Width * CellSize, b.Height * CellSize);
                g.FillRectangle(br, rect);
                g.DrawRectangle(Pens.Black, rect);
            }

            // 3) 플레이어1
            g.DrawImage(player1Img,
                new Rectangle(
                    player1Pos.X * CellSize,
                    player1Pos.Y * CellSize,
                    CellSize, CellSize));

            // 4) 플레이어2
            g.DrawImage(player2Img,
                new Rectangle(
                    player2Pos.X * CellSize,
                    player2Pos.Y * CellSize,
                    CellSize, CellSize));
        }

        private void Bula_Game_KeyDown(object sender, KeyEventArgs e)
        {
            var new1 = player1Pos;
            var new2 = player2Pos;

            switch (e.KeyCode)
            {
                case Keys.W when new1.Y > 0: new1.Y--; break;
                case Keys.S when new1.Y < GridSize - 1: new1.Y++; break;
                case Keys.A when new1.X > 0: new1.X--; break;
                case Keys.D when new1.X < GridSize - 1: new1.X++; break;
                case Keys.Up when new2.Y > 0: new2.Y--; break;
                case Keys.Down when new2.Y < GridSize - 1: new2.Y++; break;
                case Keys.Left when new2.X > 0: new2.X--; break;
                case Keys.Right when new2.X < GridSize - 1: new2.X++; break;
                default: return;
            }

            bool moved = false;
            if (!blocks.Any(b => b.Contains(new1)))
            {
                player1Pos = new1;
                trailOwner[new1.Y, new1.X] = 1;
                moved = true;
            }
            if (!blocks.Any(b => b.Contains(new2)))
            {
                player2Pos = new2;
                trailOwner[new2.Y, new2.X] = 2;
                moved = true;
            }

            if (moved)
            {
                CheckCapture();
                this.Invalidate();
            }
        }

        private void CheckCapture()
        {
            for (int i = 0; i < blocks.Count; i++)
            {
                if (blockBrushes[i] == Brushes.DarkGray)
                {
                    var b = blocks[i];
                    if (IsSurroundedBy(b, 1))
                    {
                        blockBrushes[i] = Brushes.LightBlue;
                        int pts = b.Width * b.Height;
                        score1 += pts;
                        lblScore1.Text = score1.ToString();
                    }
                    else if (IsSurroundedBy(b, 2))
                    {
                        blockBrushes[i] = Brushes.LightCoral;
                        int pts = b.Width * b.Height;
                        score2 += pts;
                        lblScore2.Text = score2.ToString();
                    }
                }
            }
        }

        private bool IsSurroundedBy(Rectangle rect, int playerId)
        {
            int x0 = rect.X, y0 = rect.Y, w = rect.Width, h = rect.Height;
            for (int r = y0 - 1; r <= y0 + h; r++)
                for (int c = x0 - 1; c <= x0 + w; c++)
                {
                    bool onEdge = r == y0 - 1 || r == y0 + h || c == x0 - 1 || c == x0 + w;
                    if (onEdge)
                    {
                        if (r < 0 || r >= GridSize || c < 0 || c >= GridSize) return false;
                        if (trailOwner[r, c] != playerId) return false;
                    }
                }
            return true;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            player1Img.Dispose();
            player2Img.Dispose();
            base.OnFormClosed(e);
        }
    }
}
