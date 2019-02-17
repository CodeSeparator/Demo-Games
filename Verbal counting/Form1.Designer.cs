namespace Verbal_counting
{
    partial class Verbal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verbal));
            this.labelThink = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonSum = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelThink
            // 
            this.labelThink.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThink.Location = new System.Drawing.Point(17, 37);
            this.labelThink.Name = "labelThink";
            this.labelThink.Size = new System.Drawing.Size(464, 65);
            this.labelThink.TabIndex = 0;
            this.labelThink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAnswer.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(17, 106);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(464, 37);
            this.textBoxAnswer.TabIndex = 1;
            this.textBoxAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAnswer_KeyDown);
            // 
            // buttonSum
            // 
            this.buttonSum.FlatAppearance.BorderSize = 0;
            this.buttonSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSum.Font = new System.Drawing.Font("Centaur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSum.Location = new System.Drawing.Point(17, 150);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(232, 30);
            this.buttonSum.TabIndex = 2;
            this.buttonSum.Text = "Sum";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progressBar.Enabled = false;
            this.progressBar.ForeColor = System.Drawing.Color.Fuchsia;
            this.progressBar.Location = new System.Drawing.Point(17, 11);
            this.progressBar.MarqueeAnimationSpeed = 1000;
            this.progressBar.Maximum = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(464, 23);
            this.progressBar.TabIndex = 3;
            // 
            // buttonSub
            // 
            this.buttonSub.FlatAppearance.BorderSize = 0;
            this.buttonSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSub.Font = new System.Drawing.Font("Centaur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub.Location = new System.Drawing.Point(249, 150);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(232, 30);
            this.buttonSub.TabIndex = 2;
            this.buttonSub.Text = "Sub";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.FlatAppearance.BorderSize = 0;
            this.buttonMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMul.Font = new System.Drawing.Font("Centaur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMul.Location = new System.Drawing.Point(17, 186);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(232, 30);
            this.buttonMul.TabIndex = 2;
            this.buttonMul.Text = "Mul";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.FlatAppearance.BorderSize = 0;
            this.buttonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiv.Font = new System.Drawing.Font("Centaur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.Location = new System.Drawing.Point(249, 186);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(232, 30);
            this.buttonDiv.TabIndex = 2;
            this.buttonDiv.Text = "Div";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLevel.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLevel.Location = new System.Drawing.Point(17, 222);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(464, 37);
            this.textBoxLevel.TabIndex = 1;
            this.textBoxLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAnswer_KeyDown);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Verbal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 301);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.labelThink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Verbal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verbal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelThink;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.Timer timer;
    }
}

