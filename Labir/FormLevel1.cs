using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labir
{
    public partial class FormLevel1 : Form
    {
        public FormLevel1()
        {
            InitializeComponent();
            
        }
        private void startGame()
        {
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            bat1.Visible = true;
            bat2.Visible = false;
        }

        private void finishGame()
        {
            Sound.playWin();
            DialogResult = DialogResult.OK;
        }

        private void restartGame()
        {
            Sound.playFail();
            DialogResult dr = MessageBox.Show("You lost..\nRepeat?", "You lost", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                startGame();
            else DialogResult = DialogResult.Abort;
        }

        private void FormLevel1_Shown(object sender, EventArgs e)
        {
            startGame();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            finishGame();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            restartGame();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bat1.Visible = !bat1.Visible;
            bat2.Visible = !bat2.Visible;
        }
    }
}
