using System.ComponentModel;

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
            this.yt_name_write = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.twitter_name_write = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.twitch_write_name = new System.Windows.Forms.TextBox();
            this.panel_switch_buttons = new System.Windows.Forms.Panel();
            this.button_create_creator = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.creator_name_write = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_switch_buttons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yt_name_write
            // 
            this.yt_name_write.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (167)))), ((int) (((byte) (67)))), ((int) (((byte) (85)))));
            this.yt_name_write.Location = new System.Drawing.Point(47, 173);
            this.yt_name_write.Name = "yt_name_write";
            this.yt_name_write.Size = new System.Drawing.Size(270, 20);
            this.yt_name_write.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (94)))), ((int) (((byte) (40)))), ((int) (((byte) (119)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "CREATOR EDIT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (167)))), ((int) (((byte) (67)))), ((int) (((byte) (85)))));
            this.label2.Location = new System.Drawing.Point(47, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "YOUTUBE";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (67)))), ((int) (((byte) (125)))), ((int) (((byte) (167)))));
            this.label3.Location = new System.Drawing.Point(47, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "TWITTER";
            // 
            // twitter_name_write
            // 
            this.twitter_name_write.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (67)))), ((int) (((byte) (125)))), ((int) (((byte) (167)))));
            this.twitter_name_write.Location = new System.Drawing.Point(47, 239);
            this.twitter_name_write.Name = "twitter_name_write";
            this.twitter_name_write.Size = new System.Drawing.Size(269, 20);
            this.twitter_name_write.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (124)))), ((int) (((byte) (94)))), ((int) (((byte) (174)))));
            this.label4.Location = new System.Drawing.Point(47, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "TWITCH";
            // 
            // twitch_write_name
            // 
            this.twitch_write_name.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (124)))), ((int) (((byte) (94)))), ((int) (((byte) (174)))));
            this.twitch_write_name.Location = new System.Drawing.Point(47, 309);
            this.twitch_write_name.Name = "twitch_write_name";
            this.twitch_write_name.Size = new System.Drawing.Size(269, 20);
            this.twitch_write_name.TabIndex = 11;
            // 
            // panel_switch_buttons
            // 
            this.panel_switch_buttons.Controls.Add(this.button_create_creator);
            this.panel_switch_buttons.Location = new System.Drawing.Point(47, 357);
            this.panel_switch_buttons.Name = "panel_switch_buttons";
            this.panel_switch_buttons.Size = new System.Drawing.Size(270, 51);
            this.panel_switch_buttons.TabIndex = 14;
            // 
            // button_create_creator
            // 
            this.button_create_creator.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (94)))), ((int) (((byte) (40)))), ((int) (((byte) (119)))));
            this.button_create_creator.FlatAppearance.BorderSize = 0;
            this.button_create_creator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create_creator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_create_creator.ForeColor = System.Drawing.Color.White;
            this.button_create_creator.Location = new System.Drawing.Point(-1, 12);
            this.button_create_creator.Name = "button_create_creator";
            this.button_create_creator.Size = new System.Drawing.Size(270, 25);
            this.button_create_creator.TabIndex = 15;
            this.button_create_creator.Text = "Create";
            this.button_create_creator.UseVisualStyleBackColor = false;
            this.button_create_creator.Click += new System.EventHandler(this.button_create_creator_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(46, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "CREATOR NAME";
            // 
            // creator_name_write
            // 
            this.creator_name_write.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (167)))), ((int) (((byte) (67)))), ((int) (((byte) (85)))));
            this.creator_name_write.Location = new System.Drawing.Point(46, 110);
            this.creator_name_write.Name = "creator_name_write";
            this.creator_name_write.Size = new System.Drawing.Size(271, 20);
            this.creator_name_write.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(46, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 28);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (167)))), ((int) (((byte) (67)))), ((int) (((byte) (85)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (71)))), ((int) (((byte) (71)))), ((int) (((byte) (71)))));
            this.ClientSize = new System.Drawing.Size(360, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.creator_name_write);
            this.Controls.Add(this.panel_switch_buttons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.twitch_write_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.twitter_name_write);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yt_name_write);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Popup";
            this.Text = "Popup";
            this.panel_switch_buttons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox creator_name_write;

        private System.Windows.Forms.Button button_create_creator;

        private System.Windows.Forms.Panel panel_switch_buttons;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox twitter_name_write;
        private System.Windows.Forms.TextBox twitch_write_name;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yt_name_write;

        #endregion
    }
}