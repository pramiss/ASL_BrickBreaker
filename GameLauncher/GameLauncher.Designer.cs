namespace GameLauncher
{
    partial class GameLauncher
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
            this.btnBrickBreaker = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnBrickBreaker
            // 
            this.btnBrickBreaker.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrickBreaker.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrickBreaker.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrickBreaker.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrickBreaker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrickBreaker.ForeColor = System.Drawing.Color.White;
            this.btnBrickBreaker.Location = new System.Drawing.Point(85, 202);
            this.btnBrickBreaker.Name = "btnBrickBreaker";
            this.btnBrickBreaker.Size = new System.Drawing.Size(180, 45);
            this.btnBrickBreaker.TabIndex = 0;
            this.btnBrickBreaker.Text = "핑퐁 벽돌깨기";
            this.btnBrickBreaker.Click += new System.EventHandler(this.btnBrickBreaker_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(485, 212);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "땅따먹기";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // GameLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnBrickBreaker);
            this.Name = "GameLauncher";
            this.Text = "GameLauncher";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBrickBreaker;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

