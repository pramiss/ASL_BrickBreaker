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
            this.btnReroll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelRoulette
            // 
            this.panelRoulette.BackColor = System.Drawing.Color.Transparent;
            this.panelRoulette.Location = new System.Drawing.Point(28, 90);
            this.panelRoulette.Name = "panelRoulette";
            this.panelRoulette.Size = new System.Drawing.Size(450, 450);
            this.panelRoulette.TabIndex = 0;
            // 
            // btnRever
            // 
            this.btnRever.Location = new System.Drawing.Point(626, 262);
            this.btnRever.Name = "btnRever";
            this.btnRever.Size = new System.Drawing.Size(98, 54);
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
            // btnReroll
            // 
            this.btnReroll.Enabled = false;
            this.btnReroll.Location = new System.Drawing.Point(600, 482);
            this.btnReroll.Name = "btnReroll";
            this.btnReroll.Size = new System.Drawing.Size(151, 54);
            this.btnReroll.TabIndex = 1;
            this.btnReroll.Text = "다시 돌리기";
            this.btnReroll.UseVisualStyleBackColor = true;
            this.btnReroll.Click += new System.EventHandler(this.btnReroll_Click);
            // 
            // Roulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 614);
            this.Controls.Add(this.btnReroll);
            this.Controls.Add(this.btnRever);
            this.Controls.Add(this.panelRoulette);
            this.Name = "Roulette";
            this.Text = "Roulette";
            this.Load += new System.EventHandler(this.Roulette_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRoulette;
        private System.Windows.Forms.Button btnRever;
        private System.Windows.Forms.Timer timerSpin;
        private System.Windows.Forms.Button btnReroll;
    }
}

