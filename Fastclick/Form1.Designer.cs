namespace Fastclick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCounter = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCounter
            // 
            this.labelCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCounter.Font = new System.Drawing.Font("Constantia", 98.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounter.Location = new System.Drawing.Point(0, 0);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(308, 162);
            this.labelCounter.TabIndex = 0;
            this.labelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCounter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCounter_MouseDown);
            // 
            // buttonStart
            // 
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(221, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 30);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(13, 12);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(75, 30);
            this.labelResult.TabIndex = 2;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAbout
            // 
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(266, 120);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(30, 30);
            this.buttonAbout.TabIndex = 1;
            this.buttonAbout.Text = "?";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonAbout_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 162);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelCounter);
            this.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Click";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonAbout;
    }
}

