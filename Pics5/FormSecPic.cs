using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pics5
{
    public partial class FormSecPic : Form
    {
        int secretNr = 0;
        public FormSecPic()
        {
            InitializeComponent();
        }

        private void btShow1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Fox;
            secretNr = 0;
        }

        private void btShow2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Jolie;
            secretNr = 0;
        }

        private void btShow3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Limu;
            secretNr = 0;
        }

        private void btShow4_Click(object sender, EventArgs e)
        {
            if (secretNr == 1)
            {
                this.BackgroundImage = Properties.Resources.Yovovich;
            } else
            {
                this.BackgroundImage = Properties.Resources.Watson;
                secretNr = 0;
            }
        }

        private void FormSecPic_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                
                secretNr = 1;
            }
        }

        private void FormSecPic_MouseMove(object sender, MouseEventArgs e)
        {
            if(secretNr == 1 && e.X < btShow1.Location.X && e.Y < btShow1.Location.Y)
            {
                secretNr = 2;
            }
        }
    }
}
