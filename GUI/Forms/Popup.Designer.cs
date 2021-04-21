﻿using System.ComponentModel;

namespace GUI
{
    partial class Popup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Timers.Timer();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (167)))), ((int) (((byte) (67)))), ((int) (((byte) (85)))));
            this.textBox1.Location = new System.Drawing.Point(45, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (167)))), ((int) (((byte) (67)))), ((int) (((byte) (85)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(234, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "CREATOR EDIT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (167)))), ((int) (((byte) (67)))), ((int) (((byte) (85)))));
            this.label2.Location = new System.Drawing.Point(45, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "YOUTUBE";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (67)))), ((int) (((byte) (125)))), ((int) (((byte) (167)))));
            this.label3.Location = new System.Drawing.Point(45, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "TWITTER";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (67)))), ((int) (((byte) (125)))), ((int) (((byte) (167)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(234, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 20);
            this.button4.TabIndex = 9;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (67)))), ((int) (((byte) (125)))), ((int) (((byte) (167)))));
            this.textBox4.Location = new System.Drawing.Point(45, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (124)))), ((int) (((byte) (94)))), ((int) (((byte) (174)))));
            this.label4.Location = new System.Drawing.Point(45, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "TWITCH";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (124)))), ((int) (((byte) (94)))), ((int) (((byte) (174)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(234, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 20);
            this.button5.TabIndex = 12;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (124)))), ((int) (((byte) (94)))), ((int) (((byte) (174)))));
            this.textBox5.Location = new System.Drawing.Point(45, 244);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(171, 20);
            this.textBox5.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.SynchronizingObject = this;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.progressBar1.Location = new System.Drawing.Point(45, 299);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (71)))), ((int) (((byte) (71)))), ((int) (((byte) (71)))));
            this.ClientSize = new System.Drawing.Size(360, 359);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Popup";
            this.Text = "Popup";
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Timers.Timer timer1;

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}