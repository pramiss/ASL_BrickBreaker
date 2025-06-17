namespace BrickBreaker
{
    partial class BrickBreaker
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelIntro = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGameStart = new Guna.UI2.WinForms.Guna2Button();
            this._LblDesc2 = new System.Windows.Forms.Label();
            this._LblDesc1 = new System.Windows.Forms.Label();
            this._rightArrow2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._leftArrow2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._BtnVkRight = new Guna.UI2.WinForms.Guna2Panel();
            this._LblBtnVkRight = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._BtnVkLeft = new Guna.UI2.WinForms.Guna2Panel();
            this._LblBtnVkLeft = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._rightArrow1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._leftArrow1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._BtnD = new Guna.UI2.WinForms.Guna2Panel();
            this._LblBtnD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._BtnA = new Guna.UI2.WinForms.Guna2Panel();
            this._LblBtnA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._paddle2 = new Guna.UI2.WinForms.Guna2Panel();
            this._paddle1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelGameplay = new Guna.UI2.WinForms.Guna2Panel();
            this.green_ball = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.paddle1 = new Guna.UI2.WinForms.Guna2Panel();
            this.paddle2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelResult = new Guna.UI2.WinForms.Guna2Panel();
            this.panelCountDown = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.@__paddle1 = new Guna.UI2.WinForms.Guna2Panel();
            this.@__paddle2 = new Guna.UI2.WinForms.Guna2Panel();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.timerGamePlay = new System.Windows.Forms.Timer(this.components);
            this.timerBrickGeneration = new System.Windows.Forms.Timer(this.components);
            this.btnQuit = new Guna.UI2.WinForms.Guna2Button();
            this.PB_GameLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbResultImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelIntro.SuspendLayout();
            this._BtnVkRight.SuspendLayout();
            this._BtnVkLeft.SuspendLayout();
            this._BtnD.SuspendLayout();
            this._BtnA.SuspendLayout();
            this.panelGameplay.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelCountDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_GameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIntro
            // 
            this.panelIntro.BackColor = System.Drawing.Color.Black;
            this.panelIntro.Controls.Add(this.btnGameStart);
            this.panelIntro.Controls.Add(this._LblDesc2);
            this.panelIntro.Controls.Add(this._LblDesc1);
            this.panelIntro.Controls.Add(this.PB_GameLogo);
            this.panelIntro.Controls.Add(this._rightArrow2);
            this.panelIntro.Controls.Add(this._leftArrow2);
            this.panelIntro.Controls.Add(this._BtnVkRight);
            this.panelIntro.Controls.Add(this._BtnVkLeft);
            this.panelIntro.Controls.Add(this._rightArrow1);
            this.panelIntro.Controls.Add(this._leftArrow1);
            this.panelIntro.Controls.Add(this._BtnD);
            this.panelIntro.Controls.Add(this._BtnA);
            this.panelIntro.Controls.Add(this._paddle2);
            this.panelIntro.Controls.Add(this._paddle1);
            this.panelIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIntro.Location = new System.Drawing.Point(0, 0);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(682, 753);
            this.panelIntro.TabIndex = 0;
            this.panelIntro.Visible = false;
            // 
            // btnGameStart
            // 
            this.btnGameStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGameStart.BorderRadius = 15;
            this.btnGameStart.BorderThickness = 2;
            this.btnGameStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGameStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGameStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGameStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGameStart.FillColor = System.Drawing.Color.Black;
            this.btnGameStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameStart.ForeColor = System.Drawing.Color.Yellow;
            this.btnGameStart.Location = new System.Drawing.Point(240, 496);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(192, 60);
            this.btnGameStart.TabIndex = 16;
            this.btnGameStart.Text = "Press To Start";
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // _LblDesc2
            // 
            this._LblDesc2.AutoSize = true;
            this._LblDesc2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LblDesc2.ForeColor = System.Drawing.Color.White;
            this._LblDesc2.Location = new System.Drawing.Point(168, 592);
            this._LblDesc2.Name = "_LblDesc2";
            this._LblDesc2.Size = new System.Drawing.Size(349, 18);
            this._LblDesc2.TabIndex = 15;
            this._LblDesc2.Text = "플레이어1은 A/D 키로 패들을 조작합니다.";
            // 
            // _LblDesc1
            // 
            this._LblDesc1.AutoSize = true;
            this._LblDesc1.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LblDesc1.ForeColor = System.Drawing.Color.White;
            this._LblDesc1.Location = new System.Drawing.Point(172, 127);
            this._LblDesc1.Name = "_LblDesc1";
            this._LblDesc1.Size = new System.Drawing.Size(349, 18);
            this._LblDesc1.TabIndex = 14;
            this._LblDesc1.Text = "플레이어1은 A/D 키로 패들을 조작합니다.";
            // 
            // _rightArrow2
            // 
            this._rightArrow2.BackColor = System.Drawing.Color.Transparent;
            this._rightArrow2.Font = new System.Drawing.Font("LG Smart UI Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._rightArrow2.ForeColor = System.Drawing.Color.White;
            this._rightArrow2.Location = new System.Drawing.Point(450, 656);
            this._rightArrow2.Name = "_rightArrow2";
            this._rightArrow2.Size = new System.Drawing.Size(28, 37);
            this._rightArrow2.TabIndex = 9;
            this._rightArrow2.Text = "▷";
            // 
            // _leftArrow2
            // 
            this._leftArrow2.BackColor = System.Drawing.Color.Transparent;
            this._leftArrow2.Font = new System.Drawing.Font("LG Smart UI Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._leftArrow2.ForeColor = System.Drawing.Color.White;
            this._leftArrow2.Location = new System.Drawing.Point(190, 656);
            this._leftArrow2.Name = "_leftArrow2";
            this._leftArrow2.Size = new System.Drawing.Size(28, 37);
            this._leftArrow2.TabIndex = 6;
            this._leftArrow2.Text = "◁";
            // 
            // _BtnVkRight
            // 
            this._BtnVkRight.BorderColor = System.Drawing.Color.Silver;
            this._BtnVkRight.BorderRadius = 5;
            this._BtnVkRight.BorderThickness = 2;
            this._BtnVkRight.Controls.Add(this._LblBtnVkRight);
            this._BtnVkRight.FillColor = System.Drawing.Color.White;
            this._BtnVkRight.Location = new System.Drawing.Point(394, 648);
            this._BtnVkRight.Name = "_BtnVkRight";
            this._BtnVkRight.Size = new System.Drawing.Size(50, 50);
            this._BtnVkRight.TabIndex = 8;
            // 
            // _LblBtnVkRight
            // 
            this._LblBtnVkRight.BackColor = System.Drawing.Color.Transparent;
            this._LblBtnVkRight.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LblBtnVkRight.Location = new System.Drawing.Point(10, 8);
            this._LblBtnVkRight.Name = "_LblBtnVkRight";
            this._LblBtnVkRight.Size = new System.Drawing.Size(32, 37);
            this._LblBtnVkRight.TabIndex = 0;
            this._LblBtnVkRight.Text = "→";
            // 
            // _BtnVkLeft
            // 
            this._BtnVkLeft.BorderColor = System.Drawing.Color.Silver;
            this._BtnVkLeft.BorderRadius = 5;
            this._BtnVkLeft.BorderThickness = 2;
            this._BtnVkLeft.Controls.Add(this._LblBtnVkLeft);
            this._BtnVkLeft.FillColor = System.Drawing.Color.White;
            this._BtnVkLeft.Location = new System.Drawing.Point(224, 648);
            this._BtnVkLeft.Name = "_BtnVkLeft";
            this._BtnVkLeft.Size = new System.Drawing.Size(50, 50);
            this._BtnVkLeft.TabIndex = 7;
            // 
            // _LblBtnVkLeft
            // 
            this._LblBtnVkLeft.BackColor = System.Drawing.Color.Transparent;
            this._LblBtnVkLeft.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LblBtnVkLeft.Location = new System.Drawing.Point(10, 8);
            this._LblBtnVkLeft.Name = "_LblBtnVkLeft";
            this._LblBtnVkLeft.Size = new System.Drawing.Size(32, 37);
            this._LblBtnVkLeft.TabIndex = 0;
            this._LblBtnVkLeft.Text = "←";
            // 
            // _rightArrow1
            // 
            this._rightArrow1.BackColor = System.Drawing.Color.Transparent;
            this._rightArrow1.Font = new System.Drawing.Font("LG Smart UI Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._rightArrow1.ForeColor = System.Drawing.Color.White;
            this._rightArrow1.Location = new System.Drawing.Point(450, 68);
            this._rightArrow1.Name = "_rightArrow1";
            this._rightArrow1.Size = new System.Drawing.Size(28, 37);
            this._rightArrow1.TabIndex = 5;
            this._rightArrow1.Text = "▷";
            // 
            // _leftArrow1
            // 
            this._leftArrow1.BackColor = System.Drawing.Color.Transparent;
            this._leftArrow1.Font = new System.Drawing.Font("LG Smart UI Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._leftArrow1.ForeColor = System.Drawing.Color.White;
            this._leftArrow1.Location = new System.Drawing.Point(190, 68);
            this._leftArrow1.Name = "_leftArrow1";
            this._leftArrow1.Size = new System.Drawing.Size(28, 37);
            this._leftArrow1.TabIndex = 1;
            this._leftArrow1.Text = "◁";
            // 
            // _BtnD
            // 
            this._BtnD.BorderColor = System.Drawing.Color.Silver;
            this._BtnD.BorderRadius = 5;
            this._BtnD.BorderThickness = 2;
            this._BtnD.Controls.Add(this._LblBtnD);
            this._BtnD.FillColor = System.Drawing.Color.White;
            this._BtnD.Location = new System.Drawing.Point(394, 60);
            this._BtnD.Name = "_BtnD";
            this._BtnD.Size = new System.Drawing.Size(50, 50);
            this._BtnD.TabIndex = 4;
            // 
            // _LblBtnD
            // 
            this._LblBtnD.BackColor = System.Drawing.Color.Transparent;
            this._LblBtnD.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LblBtnD.Location = new System.Drawing.Point(13, 7);
            this._LblBtnD.Name = "_LblBtnD";
            this._LblBtnD.Size = new System.Drawing.Size(25, 37);
            this._LblBtnD.TabIndex = 0;
            this._LblBtnD.Text = "D";
            // 
            // _BtnA
            // 
            this._BtnA.BorderColor = System.Drawing.Color.Silver;
            this._BtnA.BorderRadius = 5;
            this._BtnA.BorderThickness = 2;
            this._BtnA.Controls.Add(this._LblBtnA);
            this._BtnA.FillColor = System.Drawing.Color.White;
            this._BtnA.Location = new System.Drawing.Point(224, 60);
            this._BtnA.Name = "_BtnA";
            this._BtnA.Size = new System.Drawing.Size(50, 50);
            this._BtnA.TabIndex = 3;
            // 
            // _LblBtnA
            // 
            this._LblBtnA.BackColor = System.Drawing.Color.Transparent;
            this._LblBtnA.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LblBtnA.Location = new System.Drawing.Point(13, 7);
            this._LblBtnA.Name = "_LblBtnA";
            this._LblBtnA.Size = new System.Drawing.Size(25, 37);
            this._LblBtnA.TabIndex = 0;
            this._LblBtnA.Text = "A";
            // 
            // _paddle2
            // 
            this._paddle2.AutoRoundedCorners = true;
            this._paddle2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._paddle2.BorderRadius = 11;
            this._paddle2.BorderThickness = 1;
            this._paddle2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this._paddle2.Location = new System.Drawing.Point(224, 716);
            this._paddle2.Name = "_paddle2";
            this._paddle2.Size = new System.Drawing.Size(220, 25);
            this._paddle2.TabIndex = 2;
            // 
            // _paddle1
            // 
            this._paddle1.AutoRoundedCorners = true;
            this._paddle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._paddle1.BorderRadius = 11;
            this._paddle1.BorderThickness = 1;
            this._paddle1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this._paddle1.Location = new System.Drawing.Point(224, 12);
            this._paddle1.Name = "_paddle1";
            this._paddle1.Size = new System.Drawing.Size(220, 25);
            this._paddle1.TabIndex = 1;
            // 
            // panelGameplay
            // 
            this.panelGameplay.BackColor = System.Drawing.Color.Black;
            this.panelGameplay.Controls.Add(this.green_ball);
            this.panelGameplay.Controls.Add(this.paddle1);
            this.panelGameplay.Controls.Add(this.paddle2);
            this.panelGameplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGameplay.Location = new System.Drawing.Point(0, 0);
            this.panelGameplay.Name = "panelGameplay";
            this.panelGameplay.Size = new System.Drawing.Size(682, 753);
            this.panelGameplay.TabIndex = 0;
            this.panelGameplay.Visible = false;
            // 
            // green_ball
            // 
            this.green_ball.BackColor = System.Drawing.Color.Transparent;
            this.green_ball.BorderRadius = 15;
            this.green_ball.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.green_ball.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.green_ball.Location = new System.Drawing.Point(308, 304);
            this.green_ball.Name = "green_ball";
            this.green_ball.Size = new System.Drawing.Size(30, 30);
            this.green_ball.TabIndex = 18;
            // 
            // paddle1
            // 
            this.paddle1.AutoRoundedCorners = true;
            this.paddle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.paddle1.BorderRadius = 11;
            this.paddle1.BorderThickness = 1;
            this.paddle1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.paddle1.Location = new System.Drawing.Point(224, 12);
            this.paddle1.Name = "paddle1";
            this.paddle1.Size = new System.Drawing.Size(220, 25);
            this.paddle1.TabIndex = 5;
            // 
            // paddle2
            // 
            this.paddle2.AutoRoundedCorners = true;
            this.paddle2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.paddle2.BorderRadius = 11;
            this.paddle2.BorderThickness = 1;
            this.paddle2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.paddle2.Location = new System.Drawing.Point(224, 716);
            this.paddle2.Name = "paddle2";
            this.paddle2.Size = new System.Drawing.Size(220, 25);
            this.paddle2.TabIndex = 4;
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.Black;
            this.panelResult.Controls.Add(this.pbResultImage);
            this.panelResult.Controls.Add(this.btnQuit);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult.Location = new System.Drawing.Point(0, 0);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(682, 753);
            this.panelResult.TabIndex = 0;
            this.panelResult.Visible = false;
            // 
            // panelCountDown
            // 
            this.panelCountDown.BackColor = System.Drawing.Color.Black;
            this.panelCountDown.Controls.Add(this.lblCountdown);
            this.panelCountDown.Controls.Add(this.@__paddle1);
            this.panelCountDown.Controls.Add(this.@__paddle2);
            this.panelCountDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCountDown.Location = new System.Drawing.Point(0, 0);
            this.panelCountDown.Name = "panelCountDown";
            this.panelCountDown.Size = new System.Drawing.Size(682, 753);
            this.panelCountDown.TabIndex = 1;
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("굴림", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCountdown.ForeColor = System.Drawing.Color.White;
            this.lblCountdown.Location = new System.Drawing.Point(288, 279);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(119, 120);
            this.lblCountdown.TabIndex = 5;
            this.lblCountdown.Text = "3";
            // 
            // __paddle1
            // 
            this.@__paddle1.AutoRoundedCorners = true;
            this.@__paddle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.@__paddle1.BorderRadius = 11;
            this.@__paddle1.BorderThickness = 1;
            this.@__paddle1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.@__paddle1.Location = new System.Drawing.Point(224, 12);
            this.@__paddle1.Name = "__paddle1";
            this.@__paddle1.Size = new System.Drawing.Size(220, 25);
            this.@__paddle1.TabIndex = 4;
            // 
            // __paddle2
            // 
            this.@__paddle2.AutoRoundedCorners = true;
            this.@__paddle2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.@__paddle2.BorderRadius = 11;
            this.@__paddle2.BorderThickness = 1;
            this.@__paddle2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.@__paddle2.Location = new System.Drawing.Point(224, 716);
            this.@__paddle2.Name = "__paddle2";
            this.@__paddle2.Size = new System.Drawing.Size(220, 25);
            this.@__paddle2.TabIndex = 3;
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1010;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // timerGamePlay
            // 
            this.timerGamePlay.Interval = 16;
            this.timerGamePlay.Tick += new System.EventHandler(this.timerGamePlay_Tick);
            // 
            // timerBrickGeneration
            // 
            this.timerBrickGeneration.Interval = 5000;
            this.timerBrickGeneration.Tick += new System.EventHandler(this.timerBrickGeneration_Tick);
            // 
            // btnQuit
            // 
            this.btnQuit.BorderColor = System.Drawing.Color.Silver;
            this.btnQuit.BorderRadius = 8;
            this.btnQuit.BorderThickness = 3;
            this.btnQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuit.FillColor = System.Drawing.Color.Black;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Yellow;
            this.btnQuit.Location = new System.Drawing.Point(234, 551);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(196, 59);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "게임 종료";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // PB_GameLogo
            // 
            this.PB_GameLogo.Image = global::BrickBreaker.Properties.Resources.brick_breaker_logo;
            this.PB_GameLogo.ImageRotate = 0F;
            this.PB_GameLogo.Location = new System.Drawing.Point(171, 157);
            this.PB_GameLogo.Name = "PB_GameLogo";
            this.PB_GameLogo.Size = new System.Drawing.Size(350, 350);
            this.PB_GameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_GameLogo.TabIndex = 12;
            this.PB_GameLogo.TabStop = false;
            // 
            // pbResultImage
            // 
            this.pbResultImage.Image = global::BrickBreaker.Properties.Resources.player2_wins;
            this.pbResultImage.ImageRotate = 0F;
            this.pbResultImage.Location = new System.Drawing.Point(133, 63);
            this.pbResultImage.Name = "pbResultImage";
            this.pbResultImage.Size = new System.Drawing.Size(510, 340);
            this.pbResultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResultImage.TabIndex = 18;
            this.pbResultImage.TabStop = false;
            // 
            // BrickBreaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 753);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelGameplay);
            this.Controls.Add(this.panelCountDown);
            this.Controls.Add(this.panelIntro);
            this.KeyPreview = true;
            this.Name = "BrickBreaker";
            this.Text = "BrickBreaker";
            this.Load += new System.EventHandler(this.BrickBreaker_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrickBreaker_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BrickBreaker_KeyUp);
            this.panelIntro.ResumeLayout(false);
            this.panelIntro.PerformLayout();
            this._BtnVkRight.ResumeLayout(false);
            this._BtnVkRight.PerformLayout();
            this._BtnVkLeft.ResumeLayout(false);
            this._BtnVkLeft.PerformLayout();
            this._BtnD.ResumeLayout(false);
            this._BtnD.PerformLayout();
            this._BtnA.ResumeLayout(false);
            this._BtnA.PerformLayout();
            this.panelGameplay.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelCountDown.ResumeLayout(false);
            this.panelCountDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_GameLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelIntro;
        private Guna.UI2.WinForms.Guna2Panel _paddle1;
        private Guna.UI2.WinForms.Guna2Panel _paddle2;
        private Guna.UI2.WinForms.Guna2Panel _BtnA;
        private Guna.UI2.WinForms.Guna2HtmlLabel _LblBtnA;
        private Guna.UI2.WinForms.Guna2Panel _BtnD;
        private Guna.UI2.WinForms.Guna2HtmlLabel _LblBtnD;
        private Guna.UI2.WinForms.Guna2HtmlLabel _leftArrow1;
        private Guna.UI2.WinForms.Guna2HtmlLabel _rightArrow1;
        private Guna.UI2.WinForms.Guna2HtmlLabel _rightArrow2;
        private Guna.UI2.WinForms.Guna2HtmlLabel _leftArrow2;
        private Guna.UI2.WinForms.Guna2Panel _BtnVkRight;
        private Guna.UI2.WinForms.Guna2HtmlLabel _LblBtnVkRight;
        private Guna.UI2.WinForms.Guna2Panel _BtnVkLeft;
        private Guna.UI2.WinForms.Guna2HtmlLabel _LblBtnVkLeft;
        private Guna.UI2.WinForms.Guna2PictureBox PB_GameLogo;
        private System.Windows.Forms.Label _LblDesc2;
        private System.Windows.Forms.Label _LblDesc1;
        private Guna.UI2.WinForms.Guna2Panel panelGameplay;
        private Guna.UI2.WinForms.Guna2Panel panelResult;
        private Guna.UI2.WinForms.Guna2Panel panelCountDown;
        private Guna.UI2.WinForms.Guna2Button btnGameStart;
        private Guna.UI2.WinForms.Guna2Panel __paddle1;
        private Guna.UI2.WinForms.Guna2Panel __paddle2;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Timer timerCountdown;
        private Guna.UI2.WinForms.Guna2Panel paddle1;
        private Guna.UI2.WinForms.Guna2Panel paddle2;
        private System.Windows.Forms.Timer timerGamePlay;
        private Guna.UI2.WinForms.Guna2GradientPanel green_ball;
        private System.Windows.Forms.Timer timerBrickGeneration;
        private Guna.UI2.WinForms.Guna2Button btnQuit;
        private Guna.UI2.WinForms.Guna2PictureBox pbResultImage;
    }
}

