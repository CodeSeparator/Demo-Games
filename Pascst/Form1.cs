using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pascst
{
    public partial class Form1 : Form
    {
        string userFigure = "";
        string CPUFigure = "";
        int scoreWin = 0;
        int scoreLose = 0;
        int scoreDraw = 0;
        string modeGame = "show";

        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            showScore();
            setCPUSpeed();
        }

        private void userPanelStone_MouseEnter(object sender, EventArgs e)
        {
            showUserFigure((((Panel)sender).Tag).ToString());
        }
        private void startGame()
        {
            modeGame = "game";
        }

        private void showUserFigure(string figure)
        {
            startGame();
            pictureBox1.Visible = figure == "stone";
            pictureBox2.Visible = figure == "scissors";
            pictureBox3.Visible = figure == "paper";
            userFigure = figure;
        }

        private void showCPUFigure(string figure)
        {
            pictureBox4.Visible = figure == "stone";
            pictureBox5.Visible = figure == "scissors";
            pictureBox6.Visible = figure == "paper";
            CPUFigure = figure;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(modeGame == "game")
                useCPURand();
        }

        private void useCPURand()
        {
            int f = rnd.Next(1, 4);
            if (f == 1) showCPUFigure("stone");
            if (f == 2) showCPUFigure("scissors");
            if (f == 3) showCPUFigure("paper");
        }

        void showScore()
        {
            labelRes.Text = "Win " + scoreWin.ToString() + "  Loss " + scoreLose.ToString() + "  Draw " + scoreDraw.ToString();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            checkRes();
        }

        private void checkRes()
        {
            modeGame = "show";
            int w = 0;
            int l = 0;
            int d = 0;
            if(userFigure == CPUFigure)
            {
                d = 1;
            }
            else
            {
                if (userFigure == "stone")
                    if (CPUFigure == "scissors")
                        w = 1;
                    else l = 1;
                if (userFigure == "scissors")
                    if (CPUFigure == "paper")
                        w = 1;
                    else l = 1;
                if (userFigure == "paper")
                    if (CPUFigure == "stone")
                        w = 1;
                    else l = 1;
            }
            scoreWin += w;
            scoreLose += l;
            scoreDraw += d;
            if (w > 0)
                labelMes.Text = "Win";
            if (l > 0)
                labelMes.Text = "Lose";
            if (d > 0)
                labelMes.Text = "Draw";
            showScore();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            setCPUSpeed();
        }

        private void setCPUSpeed()
        {
            if (trackBar.Value == 1) timer.Interval = 400;
            if (trackBar.Value == 2) timer.Interval = 200;
            if (trackBar.Value == 3) timer.Interval = 100;
            if (trackBar.Value == 4) timer.Interval = 50;
            if (trackBar.Value == 5) timer.Interval = 25;
        }
    }
}
