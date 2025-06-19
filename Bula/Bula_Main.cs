using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bula
{
    public partial class Bula_Main : Form
    {
        public Bula_Main()
        {
            InitializeComponent();
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Bula_Game gameForm = new Bula_Game(); // Bula 네임스페이스 안에 있어야 함
            this.Hide();       // 메인 폼 숨기기
            gameForm.ShowDialog();   // 게임 폼 띄우기
            this.Show();
        }
    }
  
}
