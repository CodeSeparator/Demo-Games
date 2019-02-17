namespace Pics5
{
    partial class FormSecPic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecPic));
            this.btShow1 = new System.Windows.Forms.Button();
            this.btShow2 = new System.Windows.Forms.Button();
            this.btShow3 = new System.Windows.Forms.Button();
            this.btShow4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btShow1
            // 
            this.btShow1.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow1.Location = new System.Drawing.Point(12, 12);
            this.btShow1.Name = "btShow1";
            this.btShow1.Size = new System.Drawing.Size(85, 35);
            this.btShow1.TabIndex = 0;
            this.btShow1.Text = "Fox";
            this.btShow1.UseVisualStyleBackColor = true;
            this.btShow1.Click += new System.EventHandler(this.btShow1_Click);
            // 
            // btShow2
            // 
            this.btShow2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btShow2.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow2.Location = new System.Drawing.Point(287, 12);
            this.btShow2.Name = "btShow2";
            this.btShow2.Size = new System.Drawing.Size(85, 35);
            this.btShow2.TabIndex = 0;
            this.btShow2.Text = "Jolie";
            this.btShow2.UseVisualStyleBackColor = true;
            this.btShow2.Click += new System.EventHandler(this.btShow2_Click);
            // 
            // btShow3
            // 
            this.btShow3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btShow3.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow3.Location = new System.Drawing.Point(12, 215);
            this.btShow3.Name = "btShow3";
            this.btShow3.Size = new System.Drawing.Size(85, 35);
            this.btShow3.TabIndex = 0;
            this.btShow3.Text = "Limu";
            this.btShow3.UseVisualStyleBackColor = true;
            this.btShow3.Click += new System.EventHandler(this.btShow3_Click);
            // 
            // btShow4
            // 
            this.btShow4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btShow4.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow4.Location = new System.Drawing.Point(287, 215);
            this.btShow4.Name = "btShow4";
            this.btShow4.Size = new System.Drawing.Size(85, 35);
            this.btShow4.TabIndex = 0;
            this.btShow4.Text = "Watson";
            this.btShow4.UseVisualStyleBackColor = true;
            this.btShow4.Click += new System.EventHandler(this.btShow4_Click);
            // 
            // FormSecPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.btShow4);
            this.Controls.Add(this.btShow3);
            this.Controls.Add(this.btShow2);
            this.Controls.Add(this.btShow1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormSecPic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret picture";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormSecPic_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormSecPic_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btShow1;
        private System.Windows.Forms.Button btShow2;
        private System.Windows.Forms.Button btShow3;
        private System.Windows.Forms.Button btShow4;
    }
}

