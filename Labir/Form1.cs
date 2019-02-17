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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbSound_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSound.Checked)
            {
                Sound.soundOn();
                cbSound.Text = "Sound on";
            }
            else
            {
                Sound.soundOff();
                cbSound.Text = "Sound off";
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            startLevel1();
        }
        private void startLevel1()
            {
                Sound.playStart();
                FormLevel1 level1 = new FormLevel1();
                DialogResult dr = level1.ShowDialog();
                if(dr == DialogResult.OK)
                    startLevel2();
            }
        private void startLevel2()
        {
            Sound.playStart();
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == DialogResult.OK)
            {
                startLevel3();
            }
        }
        private void startLevel3()
        {
            Sound.playStart();
            FormLevel3 level3 = new FormLevel3();
            DialogResult dr = level3.ShowDialog();
            if (dr == DialogResult.OK)
                Sound.playWin();
                //MessageBox.Show("You win!");
        }
    }
}
