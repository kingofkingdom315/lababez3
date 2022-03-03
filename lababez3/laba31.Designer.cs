namespace lababez3
{
    partial class laba3
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
            this.MASSAGE = new System.Windows.Forms.TextBox();
            this.KEY = new System.Windows.Forms.TextBox();
            this.ANSWER = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MASSAGE
            // 
            this.MASSAGE.Location = new System.Drawing.Point(12, 12);
            this.MASSAGE.Multiline = true;
            this.MASSAGE.Name = "MASSAGE";
            this.MASSAGE.Size = new System.Drawing.Size(776, 158);
            this.MASSAGE.TabIndex = 0;
            // 
            // KEY
            // 
            this.KEY.Location = new System.Drawing.Point(12, 176);
            this.KEY.Name = "KEY";
            this.KEY.Size = new System.Drawing.Size(100, 22);
            this.KEY.TabIndex = 1;
            this.KEY.Text = "1";
            // 
            // ANSWER
            // 
            this.ANSWER.Location = new System.Drawing.Point(12, 241);
            this.ANSWER.Multiline = true;
            this.ANSWER.Name = "ANSWER";
            this.ANSWER.Size = new System.Drawing.Size(776, 197);
            this.ANSWER.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Расшифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(472, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Зашифровать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // laba3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ANSWER);
            this.Controls.Add(this.KEY);
            this.Controls.Add(this.MASSAGE);
            this.Name = "laba3";
            this.Text = "laba3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MASSAGE;
        private System.Windows.Forms.TextBox KEY;
        private System.Windows.Forms.TextBox ANSWER;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}