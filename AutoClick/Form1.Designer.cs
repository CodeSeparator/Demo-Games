namespace AutoClick
{
    partial class AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            this.trackCount = new System.Windows.Forms.TrackBar();
            this.trackTime = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNumClicks = new System.Windows.Forms.Label();
            this.labelPause = new System.Windows.Forms.Label();
            this.labelShowCount = new System.Windows.Forms.Label();
            this.labelShowPause = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTime)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackCount
            // 
            this.trackCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackCount.LargeChange = 10;
            this.trackCount.Location = new System.Drawing.Point(158, 3);
            this.trackCount.Maximum = 100;
            this.trackCount.Minimum = 1;
            this.trackCount.Name = "trackCount";
            this.trackCount.Size = new System.Drawing.Size(149, 32);
            this.trackCount.TabIndex = 0;
            this.trackCount.TickFrequency = 10;
            this.trackCount.Value = 1;
            this.trackCount.Scroll += new System.EventHandler(this.trackCount_Scroll);
            // 
            // trackTime
            // 
            this.trackTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackTime.LargeChange = 100;
            this.trackTime.Location = new System.Drawing.Point(158, 41);
            this.trackTime.Maximum = 1000;
            this.trackTime.Minimum = 1;
            this.trackTime.Name = "trackTime";
            this.trackTime.Size = new System.Drawing.Size(149, 32);
            this.trackTime.TabIndex = 1;
            this.trackTime.TickFrequency = 100;
            this.trackTime.Value = 10;
            this.trackTime.Scroll += new System.EventHandler(this.trackTime_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.labelShowPause, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNumClicks, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPause, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelShowCount, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonStart, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 117);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelNumClicks
            // 
            this.labelNumClicks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNumClicks.Location = new System.Drawing.Point(3, 0);
            this.labelNumClicks.Name = "labelNumClicks";
            this.labelNumClicks.Size = new System.Drawing.Size(149, 38);
            this.labelNumClicks.TabIndex = 2;
            this.labelNumClicks.Text = "NumClicks";
            this.labelNumClicks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPause
            // 
            this.labelPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPause.Location = new System.Drawing.Point(3, 38);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(149, 38);
            this.labelPause.TabIndex = 3;
            this.labelPause.Text = "PauseClicks";
            this.labelPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShowCount
            // 
            this.labelShowCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelShowCount.Location = new System.Drawing.Point(313, 0);
            this.labelShowCount.Name = "labelShowCount";
            this.labelShowCount.Size = new System.Drawing.Size(150, 38);
            this.labelShowCount.TabIndex = 4;
            this.labelShowCount.Text = "-";
            this.labelShowCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShowPause
            // 
            this.labelShowPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelShowPause.Location = new System.Drawing.Point(313, 38);
            this.labelShowPause.Name = "labelShowPause";
            this.labelShowPause.Size = new System.Drawing.Size(150, 38);
            this.labelShowPause.TabIndex = 5;
            this.labelShowPause.Text = "-";
            this.labelShowPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(158, 79);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(149, 35);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 117);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClick";
            ((System.ComponentModel.ISupportInitialize)(this.trackCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTime)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackCount;
        private System.Windows.Forms.TrackBar trackTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelShowPause;
        private System.Windows.Forms.Label labelNumClicks;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Label labelShowCount;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer;
    }
}

