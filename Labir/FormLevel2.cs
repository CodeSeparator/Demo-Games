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
    public partial class FormLevel2 : Form
    {
        int numCoin = 0;
        public FormLevel2()
        {
            InitializeComponent();
        }

        private void startGame()
        {
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            door.Visible = true;
            key.Visible = true;
            coin1.Visible = true;
            coin2.Visible = true;
            coin3.Visible = true;
            coin4.Visible = true;
            coin5.Visible = true;
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

        private void FormLevel2_Shown(object sender, EventArgs e)
        {
            startGame();
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            if (door.Image == Properties.Resources.dooropened)
            {
                //MessageBox.Show("111");
            }else
                restartGame();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            key.Visible = false;
            door.Visible = false;
            //door.Image = Properties.Resources.dooropened;
            Sound.playKey();
        }

        private void labelFinish_MouseEnter(object sender, EventArgs e)
        {
            if(numCoin == 0)
                finishGame();
        }

        private void coin2_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Visible = false;
            Sound.playKey();
        }
    }
}
