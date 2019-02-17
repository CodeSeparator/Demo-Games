using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastclick
{
    public partial class Form1 : Form
    {
        long timeStart;
        long timeFinish;
        int maxCounter = 10;
        int counter;
        string mode = "stop";
        public Form1()
        {
            InitializeComponent();
            
        }

        void startGame()
        {
            if(mode == "play") return;
            mode = "play";
            
            counter = maxCounter;
            labelCounter.Text = counter.ToString();
            labelResult.Text = "";
            buttonStart.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            startGame();
        }

        

        void playGame()
        {
            if (mode == "stop") return;
            if (counter == maxCounter)
                timeStart = DateTime.Now.Ticks;
            if (counter > 0)
                counter--;
            labelCounter.Text = counter.ToString();
            if (counter == 0)
                stopGame();
        }

        void stopGame()
        {
            mode = "stop";
            timeFinish = DateTime.Now.Ticks;
            double seconds = TimeSpan.FromTicks(timeFinish - timeStart).TotalSeconds;
            double clPS = maxCounter / seconds;
            labelResult.Text = clPS.ToString("#.#") + "clics per sec";
            buttonStart.Enabled = true;
        }

        private void labelCounter_MouseDown(object sender, MouseEventArgs e)
        {
            playGame();
        }

        

        private void buttonAbout_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("© Dmitry Mikhailov.\nAll rigthts reserved");
        }
    }
}
