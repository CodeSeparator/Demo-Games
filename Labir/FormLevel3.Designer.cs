namespace Labir
{
    partial class FormLevel3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLevel3));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.enemy1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFinish = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.enemy3 = new System.Windows.Forms.Label();
            this.enemy2 = new System.Windows.Forms.Label();
            this.enemy4 = new System.Windows.Forms.Label();
            this.enemy5 = new System.Windows.Forms.Label();
            this.enemy6 = new System.Windows.Forms.Label();
            this.enemy7 = new System.Windows.Forms.Label();
            this.enemy8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.death = new System.Windows.Forms.Label();
            this.timerd = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(716, 50);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(30, 30);
            this.enemy1.TabIndex = 10;
            this.enemy1.MouseEnter += new System.EventHandler(this.enemy8_MouseEnter);
            // 
            // label5
            // 
            this.label5.Image = global::Labir.Properties.Resources.brick;
            this.label5.Location = new System.Drawing.Point(778, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 432);
            this.label5.TabIndex = 10;
            this.label5.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label4
            // 
            this.label4.Image = global::Labir.Properties.Resources.brick;
            this.label4.Location = new System.Drawing.Point(0, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 432);
            this.label4.TabIndex = 11;
            this.label4.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label3
            // 
            this.label3.Image = global::Labir.Properties.Resources.brick;
            this.label3.Location = new System.Drawing.Point(0, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(793, 15);
            this.label3.TabIndex = 12;
            this.label3.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label1
            // 
            this.label1.Image = global::Labir.Properties.Resources.brick;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 15);
            this.label1.TabIndex = 13;
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // labelFinish
            // 
            this.labelFinish.BackColor = System.Drawing.Color.Transparent;
            this.labelFinish.Font = new System.Drawing.Font("Centaur", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinish.ForeColor = System.Drawing.Color.Red;
            this.labelFinish.Image = global::Labir.Properties.Resources.Portal;
            this.labelFinish.Location = new System.Drawing.Point(708, 15);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(38, 38);
            this.labelFinish.TabIndex = 8;
            this.labelFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFinish.MouseEnter += new System.EventHandler(this.labelFinish_MouseEnter);
            // 
            // labelStart
            // 
            this.labelStart.BackColor = System.Drawing.Color.Transparent;
            this.labelStart.Font = new System.Drawing.Font("Centaur", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.ForeColor = System.Drawing.Color.Red;
            this.labelStart.Image = global::Labir.Properties.Resources.hatch;
            this.labelStart.Location = new System.Drawing.Point(378, 296);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(38, 38);
            this.labelStart.TabIndex = 9;
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(716, 100);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(30, 30);
            this.enemy3.TabIndex = 10;
            this.enemy3.MouseEnter += new System.EventHandler(this.enemy8_MouseEnter);
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(716, 200);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(30, 30);
            this.enemy2.TabIndex = 10;
            this.enemy2.MouseEnter += new System.EventHandler(this.enemy8_MouseEnter);
            // 
            // enemy4
            // 
            this.enemy4.BackColor = System.Drawing.Color.Transparent;
            this.enemy4.Image = ((System.Drawing.Image)(resources.GetObject("enemy4.Image")));
            this.enemy4.Location = new System.Drawing.Point(716, 150);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(30, 30);
            this.enemy4.TabIndex = 10;
            this.enemy4.MouseEnter += new System.EventHandler(this.enemy8_MouseEnter);
            // 
            // enemy5
            // 
            this.enemy5.BackColor = System.Drawing.Color.Transparent;
            this.enemy5.Image = ((System.Drawing.Image)(resources.GetObject("enemy5.Image")));
            this.enemy5.Location = new System.Drawing.Point(716, 250);
            this.enemy5.Name = "enemy5";
            this.enemy5.Size = new System.Drawing.Size(30, 30);
            this.enemy5.TabIndex = 10;
            this.enemy5.MouseEnter += new System.EventHandler(this.enemy8_MouseEnter);
            // 
            // enemy6
            // 
            this.enemy6.BackColor = System.Drawing.Color.Transparent;
            this.enemy6.Image = ((System.Drawing.Image)(resources.GetObject("enemy6.Image")));
            this.enemy6.Location = new System.Drawing.Point(716, 300);
            this.enemy6.Name = "enemy6";
            this.enemy6.Size = new System.Drawing.Size(30, 30);
            this.enemy6.TabIndex = 10;
            this.enemy6.MouseEnter += new System.EventHandler(this.enemy8_MouseEnter);
            // 
            // enemy7
            // 
            this.enemy7.BackColor = System.Drawing.Color.Transparent;
            this.enemy7.Image = ((System.Drawing.Image)(resources.GetObject("enemy7.Image")));
            this.enemy7.Location = new System.Drawing.Point(716, 350);
            this.enemy7.Name = "enemy7";
            this.enemy7.Size = new System.Drawing.Size(30, 30);
            this.enemy7.TabIndex = 10;
            this.enemy7.MouseEnter += new System.EventHandler(this.enemy8_MouseEnter);
            // 
            // enemy8
            // 
            this.enemy8.BackColor = System.Drawing.Color.Transparent;
            this.enemy8.Image = ((System.Drawing.Image)(resources.GetObject("enemy8.Image")));
            this.enemy8.Location = new System.Drawing.Point(716, 400);
            this.enemy8.Name = "enemy8";
            this.enemy8.Size = new System.Drawing.Size(30, 30);
            this.enemy8.TabIndex = 10;
            this.enemy8.MouseEnter += new System.EventHandler(this.enemy8_MouseEnter);
            // 
            // label2
            // 
            this.label2.Image = global::Labir.Properties.Resources.brick;
            this.label2.Location = new System.Drawing.Point(661, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 410);
            this.label2.TabIndex = 10;
            this.label2.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label6
            // 
            this.label6.Image = global::Labir.Properties.Resources.brick;
            this.label6.Location = new System.Drawing.Point(521, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 410);
            this.label6.TabIndex = 10;
            this.label6.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label7
            // 
            this.label7.Image = global::Labir.Properties.Resources.brick;
            this.label7.Location = new System.Drawing.Point(456, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 410);
            this.label7.TabIndex = 10;
            this.label7.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label8
            // 
            this.label8.Image = global::Labir.Properties.Resources.brick;
            this.label8.Location = new System.Drawing.Point(46, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(351, 15);
            this.label8.TabIndex = 12;
            this.label8.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label9
            // 
            this.label9.Image = global::Labir.Properties.Resources.brick;
            this.label9.Location = new System.Drawing.Point(120, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(351, 15);
            this.label9.TabIndex = 12;
            this.label9.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label10
            // 
            this.label10.Image = global::Labir.Properties.Resources.brick;
            this.label10.Location = new System.Drawing.Point(340, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 100);
            this.label10.TabIndex = 10;
            this.label10.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label11
            // 
            this.label11.Image = global::Labir.Properties.Resources.brick;
            this.label11.Location = new System.Drawing.Point(586, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 397);
            this.label11.TabIndex = 10;
            this.label11.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label12
            // 
            this.label12.Image = global::Labir.Properties.Resources.brick;
            this.label12.Location = new System.Drawing.Point(117, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(559, 15);
            this.label12.TabIndex = 13;
            this.label12.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label13
            // 
            this.label13.Image = global::Labir.Properties.Resources.brick;
            this.label13.Location = new System.Drawing.Point(4, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(351, 15);
            this.label13.TabIndex = 12;
            this.label13.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label14
            // 
            this.label14.Image = global::Labir.Properties.Resources.brick;
            this.label14.Location = new System.Drawing.Point(120, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(351, 15);
            this.label14.TabIndex = 12;
            this.label14.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // death
            // 
            this.death.BackColor = System.Drawing.Color.Transparent;
            this.death.Image = global::Labir.Properties.Resources.death;
            this.death.Location = new System.Drawing.Point(378, 170);
            this.death.Name = "death";
            this.death.Size = new System.Drawing.Size(60, 60);
            this.death.TabIndex = 10;
            this.death.MouseEnter += new System.EventHandler(this.enemy8_MouseEnter);
            // 
            // timerd
            // 
            this.timerd.Enabled = true;
            this.timerd.Interval = 20;
            this.timerd.Tick += new System.EventHandler(this.timerd_Tick);
            // 
            // FormLevel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Labir.Properties.Resources.grass;
            this.ClientSize = new System.Drawing.Size(793, 462);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy8);
            this.Controls.Add(this.enemy7);
            this.Controls.Add(this.enemy6);
            this.Controls.Add(this.death);
            this.Controls.Add(this.enemy5);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFinish);
            this.Controls.Add(this.labelStart);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLevel3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLevel3";
            this.Shown += new System.EventHandler(this.FormLevel3_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label enemy1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label enemy3;
        private System.Windows.Forms.Label enemy2;
        private System.Windows.Forms.Label enemy4;
        private System.Windows.Forms.Label enemy5;
        private System.Windows.Forms.Label enemy6;
        private System.Windows.Forms.Label enemy7;
        private System.Windows.Forms.Label enemy8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label death;
        private System.Windows.Forms.Timer timerd;
    }
}