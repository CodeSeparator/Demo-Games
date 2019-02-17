namespace Labir
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btStart = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.cbSound = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.Transparent;
            this.btStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStart.FlatAppearance.BorderSize = 0;
            this.btStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.Location = new System.Drawing.Point(413, 247);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(37, 73);
            this.btStart.TabIndex = 0;
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Centaur", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btExit.Location = new System.Drawing.Point(12, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // cbSound
            // 
            this.cbSound.AutoSize = true;
            this.cbSound.BackColor = System.Drawing.Color.Transparent;
            this.cbSound.Checked = true;
            this.cbSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSound.FlatAppearance.BorderSize = 0;
            this.cbSound.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cbSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cbSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cbSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSound.Font = new System.Drawing.Font("Centaur", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbSound.Location = new System.Drawing.Point(12, 433);
            this.cbSound.Name = "cbSound";
            this.cbSound.Size = new System.Drawing.Size(69, 20);
            this.cbSound.TabIndex = 2;
            this.cbSound.Text = "Sound on";
            this.cbSound.UseVisualStyleBackColor = true;
            this.cbSound.CheckedChanged += new System.EventHandler(this.cbSound_CheckedChanged);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labir.Properties.Resources.StartImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 462);
            this.Controls.Add(this.cbSound);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabirinT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.CheckBox cbSound;
    }
}

