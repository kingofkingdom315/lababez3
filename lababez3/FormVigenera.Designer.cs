﻿namespace lababez3
{
    partial class FormVigenera
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ANSWER = new System.Windows.Forms.TextBox();
            this.WORDKEY = new System.Windows.Forms.TextBox();
            this.MASSAGE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(472, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 41);
            this.button3.TabIndex = 11;
            this.button3.Text = "Зашифровать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Расшифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ANSWER
            // 
            this.ANSWER.Location = new System.Drawing.Point(12, 241);
            this.ANSWER.Multiline = true;
            this.ANSWER.Name = "ANSWER";
            this.ANSWER.Size = new System.Drawing.Size(776, 197);
            this.ANSWER.TabIndex = 8;
            // 
            // WORDKEY
            // 
            this.WORDKEY.Location = new System.Drawing.Point(12, 176);
            this.WORDKEY.Name = "WORDKEY";
            this.WORDKEY.Size = new System.Drawing.Size(100, 22);
            this.WORDKEY.TabIndex = 7;
            this.WORDKEY.Text = "сон";
            // 
            // MASSAGE
            // 
            this.MASSAGE.Location = new System.Drawing.Point(12, 12);
            this.MASSAGE.Multiline = true;
            this.MASSAGE.Name = "MASSAGE";
            this.MASSAGE.Size = new System.Drawing.Size(776, 158);
            this.MASSAGE.TabIndex = 6;
            // 
            // FormVigenera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ANSWER);
            this.Controls.Add(this.WORDKEY);
            this.Controls.Add(this.MASSAGE);
            this.Name = "FormVigenera";
            this.Text = "FormVigenera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ANSWER;
        private System.Windows.Forms.TextBox WORDKEY;
        private System.Windows.Forms.TextBox MASSAGE;
    }
}