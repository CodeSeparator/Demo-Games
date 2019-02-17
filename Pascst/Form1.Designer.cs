namespace Pascst
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userPanelStone = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userPanelScissors = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userPanelPaper = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelMes = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.userPanelStone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.userPanelScissors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.userPanelPaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // userPanelStone
            // 
            this.userPanelStone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanelStone.Controls.Add(this.pictureBox1);
            this.userPanelStone.Location = new System.Drawing.Point(12, 76);
            this.userPanelStone.Name = "userPanelStone";
            this.userPanelStone.Size = new System.Drawing.Size(90, 90);
            this.userPanelStone.TabIndex = 0;
            this.userPanelStone.Tag = "stone";
            this.userPanelStone.MouseEnter += new System.EventHandler(this.userPanelStone_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pascst.Properties.Resources.Stone;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "stone";
            this.pictureBox1.Visible = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // userPanelScissors
            // 
            this.userPanelScissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanelScissors.Controls.Add(this.pictureBox2);
            this.userPanelScissors.Location = new System.Drawing.Point(108, 76);
            this.userPanelScissors.Name = "userPanelScissors";
            this.userPanelScissors.Size = new System.Drawing.Size(90, 90);
            this.userPanelScissors.TabIndex = 0;
            this.userPanelScissors.Tag = "scissors";
            this.userPanelScissors.MouseEnter += new System.EventHandler(this.userPanelStone_MouseEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pascst.Properties.Resources.Scissors;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "scissors";
            this.pictureBox2.Visible = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // userPanelPaper
            // 
            this.userPanelPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanelPaper.Controls.Add(this.pictureBox3);
            this.userPanelPaper.Location = new System.Drawing.Point(204, 76);
            this.userPanelPaper.Name = "userPanelPaper";
            this.userPanelPaper.Size = new System.Drawing.Size(90, 90);
            this.userPanelPaper.TabIndex = 0;
            this.userPanelPaper.Tag = "paper";
            this.userPanelPaper.MouseEnter += new System.EventHandler(this.userPanelStone_MouseEnter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = global::Pascst.Properties.Resources.Paper;
            this.pictureBox3.Image = global::Pascst.Properties.Resources.Paper;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "paper";
            this.pictureBox3.Visible = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Location = new System.Drawing.Point(424, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 90);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Pascst.Properties.Resources.Stone;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Pascst.Properties.Resources.Scissors;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(90, 90);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.ErrorImage = global::Pascst.Properties.Resources.Paper;
            this.pictureBox6.Image = global::Pascst.Properties.Resources.Paper;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(90, 90);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelMes
            // 
            this.labelMes.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMes.Location = new System.Drawing.Point(10, 20);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(285, 31);
            this.labelMes.TabIndex = 1;
            this.labelMes.Text = "label1";
            this.labelMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRes
            // 
            this.labelRes.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRes.Location = new System.Drawing.Point(10, 199);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(505, 31);
            this.labelRes.TabIndex = 1;
            this.labelRes.Text = "label1";
            this.labelRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPU
            // 
            this.labelCPU.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.Location = new System.Drawing.Point(424, 20);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(90, 31);
            this.labelCPU.TabIndex = 1;
            this.labelCPU.Text = "label1";
            this.labelCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(373, 76);
            this.trackBar.Maximum = 5;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(45, 90);
            this.trackBar.TabIndex = 2;
            this.trackBar.Value = 1;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 259);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.userPanelPaper);
            this.Controls.Add(this.userPanelScissors);
            this.Controls.Add(this.userPanelStone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stone scissors paper";
            this.userPanelStone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.userPanelScissors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.userPanelPaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel userPanelStone;
        private System.Windows.Forms.Panel userPanelScissors;
        private System.Windows.Forms.Panel userPanelPaper;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.TrackBar trackBar;
    }
}

