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
    public partial class FormLevel3 : Form
    {
        public FormLevel3()
        {
            InitializeComponent();
        }
        private void startGame()
        {
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
        }

        private void finishGame()
        {
            Sound.playWin();
            MessageBox.Show("You win!");
            DialogResult = DialogResult.Abort;
        }

        private void restartGame()
        {
            Sound.playFail();
            DialogResult dr = MessageBox.Show("You lost..\nRepeat?", "You lost", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                startGame();
            else DialogResult = DialogResult.Abort;
        }
       

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            restartGame();
        }

        private void FormLevel3_Shown(object sender, EventArgs e)
        {
            startGame();
        }
        private void moveGhost(Label enemy)
        {
            
            Random rnd = new Random();
            Point en1 = new Point(enemy.Location.X, enemy.Location.Y);
            /*
            Point curP = Cursor.Position;
            int dx = (curP.X - en1.X) / Math.Abs(curP.X - en1.X);
            int dy = (curP.Y - en1.Y) / Math.Abs(curP.Y - en1.Y);
            */
            en1.X += rnd.Next(-2, 3);
            en1.Y += rnd.Next(-2, 3);
            enemy.Location = en1;
           
        }
        private void moveDeath(Label enemy)
        {

            Random rnd = new Random();
            Point en1 = new Point(enemy.Location.X, enemy.Location.Y);

            
            Point curP = Cursor.Position;
            //int dx = (curP.X - en1.X) / Math.Abs(curP.X - en1.X);
            //int dy = (curP.Y - en1.Y) / Math.Abs(curP.Y - en1.Y);
            //int dx = (curP.X - 793/2);
            //int dy = (curP.Y - 462/2);
            en1.X += rnd.Next(-5, 6);
            en1.Y += rnd.Next(-5, 6);
            enemy.Location = en1;

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            /*
            Random rnd = new Random();
            Point en1 = new Point(enemy1.Location.X, enemy1.Location.Y);
            en1.X += rnd.Next(-2, 3);
            en1.Y += rnd.Next(-2, 3);
            enemy1.Location = en1;
            */
            moveGhost(enemy1);
            moveGhost(enemy2);
            moveGhost(enemy3);
            moveGhost(enemy4);
            moveGhost(enemy5);
            moveGhost(enemy6);
            moveGhost(enemy7);
            moveGhost(enemy8);
            
        }

        private void enemy8_MouseEnter(object sender, EventArgs e)
        {
            restartGame();
        }

        private void timerd_Tick(object sender, EventArgs e)
        {
            moveDeath(death);
        }

        private void labelFinish_MouseEnter(object sender, EventArgs e)
        {
            finishGame();
        }
    }
}
