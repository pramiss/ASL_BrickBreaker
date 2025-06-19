using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class GameLauncher : Form
    {
        public GameLauncher()
        {
            InitializeComponent();
        }

        private void btnBrickBreaker_Click(object sender, EventArgs e)
        {
            BrickBreaker.BrickBreaker bb = new BrickBreaker.BrickBreaker();
            bb.ShowDialog();
            Roulette.Roulette rr = new Roulette.Roulette();
            rr.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Bula.Bula_Main bula = new Bula.Bula_Main();
            bula.ShowDialog();
            Roulette.Roulette rr = new Roulette.Roulette();
            rr.ShowDialog();
        }
    }
}
