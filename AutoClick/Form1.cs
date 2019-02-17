using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoClick
{
    public partial class AutoClicker : Form
    {
        int clics = 0;
        public AutoClicker()
        {
            InitializeComponent();
            trackCount_Scroll(null, null);
            trackTime_Scroll(null, null);
        }

        private void trackCount_Scroll(object sender, EventArgs e)
        {
            labelShowCount.Text = trackCount.Value.ToString() + " clicks";
        }

        private void trackTime_Scroll(object sender, EventArgs e)
        {
            labelShowPause.Text = trackTime.Value.ToString() + " ms";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            makeClick();
        }

        private void makeClick()
        {
            clics--;
            DoMouseClick();
            if (clics == 0)
                stopClicker();
        }

        private void stopClicker()
        {
            timer.Enabled = false;
            buttonStart.Enabled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            startClicker();
        }

        void startClicker()
        {
            clics = trackCount.Value;
            buttonStart.Enabled = false;
            timer.Interval = trackTime.Value;
            timer.Enabled = true;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public void DoMouseClick()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
    }
}
