namespace Roulette
{
    partial class Roulette
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
            this.panelRoulette = new System.Windows.Forms.Panel();
            this.btnRever = new System.Windows.Forms.Button();
            this.timerSpin = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.rouletteResult = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblResult1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblResult2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnReroll = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuit = new Guna.UI2.WinForms.Guna2Button();
            this.panelRoulette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.rouletteResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRoulette
            // 
            this.panelRoulette.BackColor = System.Drawing.Color.Transparent;
            this.panelRoulette.Controls.Add(this.rouletteResult);
            this.panelRoulette.Location = new System.Drawing.Point(24, 72);
            this.panelRoulette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRoulette.Name = "panelRoulette";
            this.panelRoulette.Size = new System.Drawing.Size(492, 360);
            this.panelRoulette.TabIndex = 0;
            // 
            // btnRever
            // 
            this.btnRever.Location = new System.Drawing.Point(533, 207);
            this.btnRever.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRever.Name = "btnRever";
            this.btnRever.Size = new System.Drawing.Size(86, 43);
            this.btnRever.TabIndex = 0;
            this.btnRever.Text = "돌리기";
            this.btnRever.UseVisualStyleBackColor = true;
            this.btnRever.Click += new System.EventHandler(this.btnRever_Click);
            // 
            // timerSpin
            // 
            this.timerSpin.Interval = 20;
            this.timerSpin.Tick += new System.EventHandler(this.timerSpin_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Roulette.Properties.Resources.arrow_down;
            this.pictureBox1.Location = new System.Drawing.Point(180, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // rouletteResult
            // 
            this.rouletteResult.BackColor = System.Drawing.Color.Transparent;
            this.rouletteResult.Controls.Add(this.btnQuit);
            this.rouletteResult.Controls.Add(this.btnReroll);
            this.rouletteResult.Controls.Add(this.lblResult2);
            this.rouletteResult.Controls.Add(this.lblResult1);
            this.rouletteResult.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rouletteResult.Location = new System.Drawing.Point(140, 64);
            this.rouletteResult.Name = "rouletteResult";
            this.rouletteResult.Radius = 12;
            this.rouletteResult.ShadowColor = System.Drawing.Color.Black;
            this.rouletteResult.Size = new System.Drawing.Size(349, 184);
            this.rouletteResult.TabIndex = 6;
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = false;
            this.lblResult1.BackColor = System.Drawing.Color.Transparent;
            this.lblResult1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult1.ForeColor = System.Drawing.Color.White;
            this.lblResult1.Location = new System.Drawing.Point(3, 42);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(343, 23);
            this.lblResult1.TabIndex = 7;
            this.lblResult1.Text = "결과";
            this.lblResult1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = false;
            this.lblResult2.BackColor = System.Drawing.Color.Transparent;
            this.lblResult2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult2.ForeColor = System.Drawing.Color.White;
            this.lblResult2.Location = new System.Drawing.Point(3, 71);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(346, 19);
            this.lblResult2.TabIndex = 8;
            this.lblResult2.Text = "결과";
            this.lblResult2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReroll
            // 
            this.btnReroll.BorderColor = System.Drawing.Color.White;
            this.btnReroll.BorderRadius = 8;
            this.btnReroll.BorderThickness = 2;
            this.btnReroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReroll.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReroll.ForeColor = System.Drawing.Color.White;
            this.btnReroll.Location = new System.Drawing.Point(33, 111);
            this.btnReroll.Name = "btnReroll";
            this.btnReroll.Size = new System.Drawing.Size(140, 45);
            this.btnReroll.TabIndex = 9;
            this.btnReroll.Text = "다시 돌리기";
            this.btnReroll.Click += new System.EventHandler(this.btnReroll_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BorderColor = System.Drawing.Color.White;
            this.btnQuit.BorderRadius = 8;
            this.btnQuit.BorderThickness = 2;
            this.btnQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuit.FillColor = System.Drawing.Color.Black;
            this.btnQuit.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(179, 111);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(140, 45);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "나가기";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Roulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.btnRever);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelRoulette);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Roulette";
            this.Text = "Roulette";
            this.Load += new System.EventHandler(this.Roulette_Load);
            this.panelRoulette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.rouletteResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRoulette;
        private System.Windows.Forms.Button btnRever;
        private System.Windows.Forms.Timer timerSpin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2ShadowPanel rouletteResult;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResult1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResult2;
        private Guna.UI2.WinForms.Guna2Button btnReroll;
        private Guna.UI2.WinForms.Guna2Button btnQuit;
    }
}

