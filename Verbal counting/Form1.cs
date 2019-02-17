using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verbal_counting
{
    public partial class Verbal : Form
    {
        int count;
        int countMax = 10;
        int min = 1;
        int max = 15;
        Random rnd = new Random();
        string answer;
        string mode = "";
        long timeStart;
        long timeFinish;

        public Verbal()
        {
            InitializeComponent();
            textBoxLevel.Text = max.ToString();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            start("plus");
        }
        private void start(string myMode)
        {
            mode = myMode;
            buttonSum.Enabled = false;
            buttonDiv.Enabled = false;
            buttonMul.Enabled = false;
            buttonSub.Enabled = false;
            textBoxLevel.Enabled = false;
            textBoxAnswer.Focus();
            progressBar.Minimum = 0;
            progressBar.Maximum = countMax;
            progressBar.Value = 0;
            count = 0;
            try
            {
                max = Convert.ToInt32(textBoxLevel.Text);
            }
            catch
            {
                max = 10;
                textBoxLevel.Text = max.ToString();
            }
            think();
            timeStart = DateTime.Now.Ticks;
        }

        private void think()
        {
            if (count == countMax)
            {
                gameWin();
                return;
            }
            int a, b;
            a = rnd.Next(min, max + 1);
            b = rnd.Next(min, max + 1);
            if(mode == "plus")
            {
                labelThink.Text = a.ToString() + " + " + b.ToString();
                answer = (a + b).ToString();
            }
            if (mode == "minus")
            {
                if(a < b)
                {
                    a ^= b;
                    b ^= a;
                    a ^= b;
                }
                labelThink.Text = a.ToString() + " – " + b.ToString();
                answer = (a - b).ToString();
            }
            if (mode == "mult")
            {
                labelThink.Text = a.ToString() + " × " + b.ToString();
                answer = (a * b).ToString();
            }
            if (mode == "divs")
            {
                labelThink.Text = (a * b).ToString() + " : " + b.ToString();
                answer = (a).ToString();
            }
            count++;
        }

        private void gameWin()
        {
            timeFinish = DateTime.Now.Ticks;
            double seconds = TimeSpan.FromTicks(timeFinish - timeStart).TotalSeconds;
            

            MessageBox.Show("Win! " + seconds.ToString("#.#") + " sec.");
            buttonSum.Enabled = true;
            buttonDiv.Enabled = true;
            buttonMul.Enabled = true;
            buttonSub.Enabled = true;
            textBoxLevel.Enabled = true;
            progressBar.Visible = false;
            labelThink.Text = "";
            textBoxAnswer.Text = "";
        }

        private void textBoxAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (textBoxAnswer.Text == answer)
                {
                    textBoxAnswer.Text = "";
                    progressBar.Value = count;
                    think();
                }
                else
                {
                    gameover();
                }
            }
        }

        private void gameover()
        {
            textBoxAnswer.Text = answer;
            buttonSum.Enabled = true;
            buttonDiv.Enabled = true;
            buttonMul.Enabled = true;
            buttonSub.Enabled = true;
            textBoxLevel.Enabled = true;
            labelThink.Enabled = true;
            count = 0;
            progressBar.Value = 0;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            start("minus");
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            start("mult");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            start("divs");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
