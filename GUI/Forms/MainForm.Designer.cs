using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace GUI
{
    partial class MainForm
    {
        /// <summary>i
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        public void LoadResources()
        {
            var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            picturebox_main_creator_image.Image = Image.FromFile($@"{path}\Images\pdp.png");
            picturebox_main_creator_image.Size = new Size(92,96);
            picturebox_main_creator_image.SizeMode = PictureBoxSizeMode.StretchImage;
            
            pictureBox_twitch_icon.Image = Image.FromFile($@"{path}\Images\twitch_icon.png");
            pictureBox_twitch_icon.Size = new Size(32,22);
            pictureBox_twitch_icon.SizeMode = PictureBoxSizeMode.StretchImage;
            
            pictureBox_twitter_icon.Image = Image.FromFile($@"{path}\Images\twitter_icon.png");
            pictureBox_twitter_icon.Size = new Size(32,33);
            pictureBox_twitter_icon.SizeMode = PictureBoxSizeMode.StretchImage;

            
            pictureBox_yt_icon.Image = Image.FromFile($@"{path}\Images\yt_icon.png");
            pictureBox_yt_icon.Size = new Size(32,28);
            pictureBox_yt_icon.SizeMode = PictureBoxSizeMode.StretchImage;
            
            pictureBox_insta_icon.Image = Image.FromFile($@"{path}\Images\insta_icon.png");
            pictureBox_insta_icon.Size = new Size(28,28);
            pictureBox_insta_icon.SizeMode = PictureBoxSizeMode.StretchImage;

            picturebox_edit.Image = Image.FromFile($@"{path}\Images\edit_icon.png");
            picturebox_edit.Size = new Size(15,15);
            picturebox_edit.Location = new Point(60, 50);
            picturebox_edit.SizeMode = PictureBoxSizeMode.StretchImage;

            label_yt.Text = "YOUTUBE";
            label_twitter.Text = "TWITTER";
            label_twitch.Text = "TWITCH";
            
            first_tweet_text_likes.Text = "Likes";
            second_tweet_text_likes.Text = "Likes";
            third_tweet_text_like.Text = "Likes";
            label_twitter_tweet.Text = "Newest tweets";
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_create_new_creator = new System.Windows.Forms.Button();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.test_panel = new System.Windows.Forms.Panel();
            this.label_main_creator_name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.yt_panel = new System.Windows.Forms.Panel();
            this.pictureBox_yt_icon = new System.Windows.Forms.PictureBox();
            this.label_yt_follower_count = new System.Windows.Forms.Label();
            this.label_yt = new System.Windows.Forms.Label();
            this.label_twitter_follower_count = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_twitch = new System.Windows.Forms.Panel();
            this.pictureBox_twitch_icon = new System.Windows.Forms.PictureBox();
            this.label_twitch = new System.Windows.Forms.Label();
            this.label_twitch_follower_count = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_insta = new System.Windows.Forms.Panel();
            this.pictureBox_insta_icon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel_twitter = new System.Windows.Forms.Panel();
            this.pictureBox_twitter_icon = new System.Windows.Forms.PictureBox();
            this.label_twitter = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_twitter_tweet = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.third_newest_tweet = new System.Windows.Forms.Label();
            this.third_tweet_text_like = new System.Windows.Forms.Label();
            this.third_tweet_likes_amount = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.second_newest_tweet = new System.Windows.Forms.Label();
            this.second_tweet_text_likes = new System.Windows.Forms.Label();
            this.second_tweet_likes_amount = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.newest_tweet = new System.Windows.Forms.Label();
            this.first_tweet_text_likes = new System.Windows.Forms.Label();
            this.first_tweet_likes_amount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.staySameTemplate = new System.Windows.Forms.Panel();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.picturebox_edit = new System.Windows.Forms.PictureBox();
            this.panel_main_creator_image = new System.Windows.Forms.Panel();
            this.picturebox_main_creator_image = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.yt_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_yt_icon)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel_twitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_twitch_icon)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel_insta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_insta_icon)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel_twitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_twitter_icon)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.staySameTemplate.SuspendLayout();
            this.panel_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_edit)).BeginInit();
            this.panel_main_creator_image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_main_creator_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (41)))), ((int) (((byte) (41)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.button_create_new_creator);
            this.panel1.Controls.Add(this.textbox_search);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 522);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(163, 448);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // button_create_new_creator
            // 
            this.button_create_new_creator.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (88)))), ((int) (((byte) (73)))), ((int) (((byte) (96)))));
            this.button_create_new_creator.FlatAppearance.BorderSize = 0;
            this.button_create_new_creator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create_new_creator.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_create_new_creator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_create_new_creator.Location = new System.Drawing.Point(12, 34);
            this.button_create_new_creator.Name = "button_create_new_creator";
            this.button_create_new_creator.Size = new System.Drawing.Size(163, 23);
            this.button_create_new_creator.TabIndex = 6;
            this.button_create_new_creator.Text = "New Creator";
            this.button_create_new_creator.UseVisualStyleBackColor = false;
            this.button_create_new_creator.Click += new System.EventHandler(this.button2_Click);
            // 
            // textbox_search
            // 
            this.textbox_search.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textbox_search.Location = new System.Drawing.Point(12, 6);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(163, 20);
            this.textbox_search.TabIndex = 5;
            this.textbox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 19);
            this.label13.TabIndex = 19;
            this.label13.Text = "SOCIALSTATS";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (94)))), ((int) (((byte) (40)))), ((int) (((byte) (119)))));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 40);
            this.panel2.TabIndex = 3;
            // 
            // test_panel
            // 
            this.test_panel.Location = new System.Drawing.Point(3, 3);
            this.test_panel.Name = "test_panel";
            this.test_panel.Size = new System.Drawing.Size(704, 519);
            this.test_panel.TabIndex = 20;
            // 
            // label_main_creator_name
            // 
            this.label_main_creator_name.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_main_creator_name.ForeColor = System.Drawing.Color.White;
            this.label_main_creator_name.Location = new System.Drawing.Point(114, 47);
            this.label_main_creator_name.Name = "label_main_creator_name";
            this.label_main_creator_name.Size = new System.Drawing.Size(577, 42);
            this.label_main_creator_name.TabIndex = 7;
            this.label_main_creator_name.Text = "Toast";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.yt_panel);
            this.panel3.Controls.Add(this.label_yt_follower_count);
            this.panel3.Controls.Add(this.label_yt);
            this.panel3.Location = new System.Drawing.Point(30, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 112);
            this.panel3.TabIndex = 8;
            // 
            // yt_panel
            // 
            this.yt_panel.Controls.Add(this.pictureBox_yt_icon);
            this.yt_panel.Location = new System.Drawing.Point(266, 8);
            this.yt_panel.Name = "yt_panel";
            this.yt_panel.Size = new System.Drawing.Size(34, 33);
            this.yt_panel.TabIndex = 20;
            // 
            // pictureBox_yt_icon
            // 
            this.pictureBox_yt_icon.Location = new System.Drawing.Point(3, 4);
            this.pictureBox_yt_icon.Name = "pictureBox_yt_icon";
            this.pictureBox_yt_icon.Size = new System.Drawing.Size(28, 26);
            this.pictureBox_yt_icon.TabIndex = 0;
            this.pictureBox_yt_icon.TabStop = false;
            // 
            // label_yt_follower_count
            // 
            this.label_yt_follower_count.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_yt_follower_count.ForeColor = System.Drawing.Color.White;
            this.label_yt_follower_count.Location = new System.Drawing.Point(3, 53);
            this.label_yt_follower_count.Name = "label_yt_follower_count";
            this.label_yt_follower_count.Size = new System.Drawing.Size(294, 59);
            this.label_yt_follower_count.TabIndex = 16;
            // 
            // label_yt
            // 
            this.label_yt.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_yt.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (167)))), ((int) (((byte) (67)))), ((int) (((byte) (85)))));
            this.label_yt.Location = new System.Drawing.Point(3, 9);
            this.label_yt.Name = "label_yt";
            this.label_yt.Size = new System.Drawing.Size(154, 44);
            this.label_yt.TabIndex = 12;
            // 
            // label_twitter_follower_count
            // 
            this.label_twitter_follower_count.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_twitter_follower_count.ForeColor = System.Drawing.Color.White;
            this.label_twitter_follower_count.Location = new System.Drawing.Point(13, 53);
            this.label_twitter_follower_count.Name = "label_twitter_follower_count";
            this.label_twitter_follower_count.Size = new System.Drawing.Size(284, 59);
            this.label_twitter_follower_count.TabIndex = 18;
            this.label_twitter_follower_count.Text = "1.000.000";
            this.label_twitter_follower_count.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel_twitch);
            this.panel4.Controls.Add(this.label_twitch);
            this.panel4.Controls.Add(this.label_twitch_follower_count);
            this.panel4.Location = new System.Drawing.Point(30, 237);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 112);
            this.panel4.TabIndex = 9;
            // 
            // panel_twitch
            // 
            this.panel_twitch.Controls.Add(this.pictureBox_twitch_icon);
            this.panel_twitch.Location = new System.Drawing.Point(268, 9);
            this.panel_twitch.Name = "panel_twitch";
            this.panel_twitch.Size = new System.Drawing.Size(32, 33);
            this.panel_twitch.TabIndex = 21;
            // 
            // pictureBox_twitch_icon
            // 
            this.pictureBox_twitch_icon.Location = new System.Drawing.Point(3, 4);
            this.pictureBox_twitch_icon.Name = "pictureBox_twitch_icon";
            this.pictureBox_twitch_icon.Size = new System.Drawing.Size(26, 26);
            this.pictureBox_twitch_icon.TabIndex = 0;
            this.pictureBox_twitch_icon.TabStop = false;
            // 
            // label_twitch
            // 
            this.label_twitch.BackColor = System.Drawing.Color.Transparent;
            this.label_twitch.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_twitch.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (124)))), ((int) (((byte) (94)))), ((int) (((byte) (174)))));
            this.label_twitch.Location = new System.Drawing.Point(0, 9);
            this.label_twitch.Name = "label_twitch";
            this.label_twitch.Size = new System.Drawing.Size(139, 26);
            this.label_twitch.TabIndex = 21;
            // 
            // label_twitch_follower_count
            // 
            this.label_twitch_follower_count.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_twitch_follower_count.ForeColor = System.Drawing.Color.White;
            this.label_twitch_follower_count.Location = new System.Drawing.Point(3, 50);
            this.label_twitch_follower_count.Name = "label_twitch_follower_count";
            this.label_twitch_follower_count.Size = new System.Drawing.Size(297, 62);
            this.label_twitch_follower_count.TabIndex = 19;
            this.label_twitch_follower_count.Text = "1.000.000";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.panel_insta);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(30, 381);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 112);
            this.panel5.TabIndex = 10;
            // 
            // panel_insta
            // 
            this.panel_insta.Controls.Add(this.pictureBox_insta_icon);
            this.panel_insta.Location = new System.Drawing.Point(268, 8);
            this.panel_insta.Name = "panel_insta";
            this.panel_insta.Size = new System.Drawing.Size(32, 33);
            this.panel_insta.TabIndex = 22;
            // 
            // pictureBox_insta_icon
            // 
            this.pictureBox_insta_icon.Location = new System.Drawing.Point(3, 4);
            this.pictureBox_insta_icon.Name = "pictureBox_insta_icon";
            this.pictureBox_insta_icon.Size = new System.Drawing.Size(26, 26);
            this.pictureBox_insta_icon.TabIndex = 0;
            this.pictureBox_insta_icon.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (165)))), ((int) (((byte) (67)))), ((int) (((byte) (167)))));
            this.label4.Location = new System.Drawing.Point(0, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 26);
            this.label4.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.panel_twitter);
            this.panel6.Controls.Add(this.label_twitter);
            this.panel6.Controls.Add(this.label_twitter_follower_count);
            this.panel6.Location = new System.Drawing.Point(391, 92);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 112);
            this.panel6.TabIndex = 9;
            // 
            // panel_twitter
            // 
            this.panel_twitter.Controls.Add(this.pictureBox_twitter_icon);
            this.panel_twitter.Location = new System.Drawing.Point(268, 8);
            this.panel_twitter.Name = "panel_twitter";
            this.panel_twitter.Size = new System.Drawing.Size(32, 33);
            this.panel_twitter.TabIndex = 21;
            // 
            // pictureBox_twitter_icon
            // 
            this.pictureBox_twitter_icon.Location = new System.Drawing.Point(3, 4);
            this.pictureBox_twitter_icon.Name = "pictureBox_twitter_icon";
            this.pictureBox_twitter_icon.Size = new System.Drawing.Size(26, 26);
            this.pictureBox_twitter_icon.TabIndex = 0;
            this.pictureBox_twitter_icon.TabStop = false;
            // 
            // label_twitter
            // 
            this.label_twitter.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_twitter.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (67)))), ((int) (((byte) (125)))), ((int) (((byte) (167)))));
            this.label_twitter.Location = new System.Drawing.Point(10, 9);
            this.label_twitter.Name = "label_twitter";
            this.label_twitter.Size = new System.Drawing.Size(154, 44);
            this.label_twitter.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (71)))), ((int) (((byte) (71)))), ((int) (((byte) (71)))));
            this.panel7.Controls.Add(this.label_twitter_tweet);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(391, 237);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 256);
            this.panel7.TabIndex = 18;
            // 
            // label_twitter_tweet
            // 
            this.label_twitter_tweet.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_twitter_tweet.ForeColor = System.Drawing.Color.White;
            this.label_twitter_tweet.Location = new System.Drawing.Point(10, 14);
            this.label_twitter_tweet.Name = "label_twitter_tweet";
            this.label_twitter_tweet.Size = new System.Drawing.Size(280, 25);
            this.label_twitter_tweet.TabIndex = 20;
            this.label_twitter_tweet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (47)))), ((int) (((byte) (47)))), ((int) (((byte) (47)))));
            this.panel10.Controls.Add(this.third_newest_tweet);
            this.panel10.Controls.Add(this.third_tweet_text_like);
            this.panel10.Controls.Add(this.third_tweet_likes_amount);
            this.panel10.Controls.Add(this.label22);
            this.panel10.Location = new System.Drawing.Point(10, 185);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(280, 61);
            this.panel10.TabIndex = 26;
            // 
            // third_newest_tweet
            // 
            this.third_newest_tweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.third_newest_tweet.ForeColor = System.Drawing.Color.White;
            this.third_newest_tweet.Location = new System.Drawing.Point(3, 0);
            this.third_newest_tweet.Name = "third_newest_tweet";
            this.third_newest_tweet.Size = new System.Drawing.Size(274, 43);
            this.third_newest_tweet.TabIndex = 26;
            // 
            // third_tweet_text_like
            // 
            this.third_tweet_text_like.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.third_tweet_text_like.ForeColor = System.Drawing.Color.White;
            this.third_tweet_text_like.Location = new System.Drawing.Point(34, 43);
            this.third_tweet_text_like.Name = "third_tweet_text_like";
            this.third_tweet_text_like.Size = new System.Drawing.Size(42, 18);
            this.third_tweet_text_like.TabIndex = 25;
            // 
            // third_tweet_likes_amount
            // 
            this.third_tweet_likes_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.third_tweet_likes_amount.ForeColor = System.Drawing.Color.White;
            this.third_tweet_likes_amount.Location = new System.Drawing.Point(3, 43);
            this.third_tweet_likes_amount.Name = "third_tweet_likes_amount";
            this.third_tweet_likes_amount.Size = new System.Drawing.Size(42, 18);
            this.third_tweet_likes_amount.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(3, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(274, 43);
            this.label22.TabIndex = 22;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (47)))), ((int) (((byte) (47)))), ((int) (((byte) (47)))));
            this.panel9.Controls.Add(this.second_newest_tweet);
            this.panel9.Controls.Add(this.second_tweet_text_likes);
            this.panel9.Controls.Add(this.second_tweet_likes_amount);
            this.panel9.Controls.Add(this.label19);
            this.panel9.Location = new System.Drawing.Point(10, 118);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(280, 61);
            this.panel9.TabIndex = 25;
            // 
            // second_newest_tweet
            // 
            this.second_newest_tweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.second_newest_tweet.ForeColor = System.Drawing.Color.White;
            this.second_newest_tweet.Location = new System.Drawing.Point(3, 0);
            this.second_newest_tweet.Name = "second_newest_tweet";
            this.second_newest_tweet.Size = new System.Drawing.Size(274, 43);
            this.second_newest_tweet.TabIndex = 25;
            // 
            // second_tweet_text_likes
            // 
            this.second_tweet_text_likes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.second_tweet_text_likes.ForeColor = System.Drawing.Color.White;
            this.second_tweet_text_likes.Location = new System.Drawing.Point(34, 43);
            this.second_tweet_text_likes.Name = "second_tweet_text_likes";
            this.second_tweet_text_likes.Size = new System.Drawing.Size(42, 18);
            this.second_tweet_text_likes.TabIndex = 24;
            // 
            // second_tweet_likes_amount
            // 
            this.second_tweet_likes_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.second_tweet_likes_amount.ForeColor = System.Drawing.Color.White;
            this.second_tweet_likes_amount.Location = new System.Drawing.Point(3, 43);
            this.second_tweet_likes_amount.Name = "second_tweet_likes_amount";
            this.second_tweet_likes_amount.Size = new System.Drawing.Size(42, 18);
            this.second_tweet_likes_amount.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(274, 43);
            this.label19.TabIndex = 22;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (47)))), ((int) (((byte) (47)))), ((int) (((byte) (47)))));
            this.panel8.Controls.Add(this.newest_tweet);
            this.panel8.Controls.Add(this.first_tweet_text_likes);
            this.panel8.Controls.Add(this.first_tweet_likes_amount);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Location = new System.Drawing.Point(10, 51);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(280, 61);
            this.panel8.TabIndex = 19;
            // 
            // newest_tweet
            // 
            this.newest_tweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.newest_tweet.ForeColor = System.Drawing.Color.White;
            this.newest_tweet.Location = new System.Drawing.Point(3, 0);
            this.newest_tweet.Name = "newest_tweet";
            this.newest_tweet.Size = new System.Drawing.Size(274, 43);
            this.newest_tweet.TabIndex = 24;
            // 
            // first_tweet_text_likes
            // 
            this.first_tweet_text_likes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.first_tweet_text_likes.ForeColor = System.Drawing.Color.White;
            this.first_tweet_text_likes.Location = new System.Drawing.Point(34, 43);
            this.first_tweet_text_likes.Name = "first_tweet_text_likes";
            this.first_tweet_text_likes.Size = new System.Drawing.Size(42, 18);
            this.first_tweet_text_likes.TabIndex = 24;
            // 
            // first_tweet_likes_amount
            // 
            this.first_tweet_likes_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.first_tweet_likes_amount.ForeColor = System.Drawing.Color.White;
            this.first_tweet_likes_amount.Location = new System.Drawing.Point(3, 43);
            this.first_tweet_likes_amount.Name = "first_tweet_likes_amount";
            this.first_tweet_likes_amount.Size = new System.Drawing.Size(42, 18);
            this.first_tweet_likes_amount.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(274, 43);
            this.label14.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(80, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 19;
            // 
            // staySameTemplate
            // 
            this.staySameTemplate.BackColor = System.Drawing.Color.Transparent;
            this.staySameTemplate.Controls.Add(this.panel_edit);
            this.staySameTemplate.Controls.Add(this.panel_main_creator_image);
            this.staySameTemplate.Controls.Add(this.test_panel);
            this.staySameTemplate.Controls.Add(this.panel6);
            this.staySameTemplate.Controls.Add(this.label_main_creator_name);
            this.staySameTemplate.Controls.Add(this.panel5);
            this.staySameTemplate.Controls.Add(this.panel7);
            this.staySameTemplate.Controls.Add(this.panel4);
            this.staySameTemplate.Controls.Add(this.panel3);
            this.staySameTemplate.Dock = System.Windows.Forms.DockStyle.Right;
            this.staySameTemplate.Location = new System.Drawing.Point(195, 40);
            this.staySameTemplate.Name = "staySameTemplate";
            this.staySameTemplate.Size = new System.Drawing.Size(718, 522);
            this.staySameTemplate.TabIndex = 19;
            // 
            // panel_edit
            // 
            this.panel_edit.Controls.Add(this.picturebox_edit);
            this.panel_edit.Location = new System.Drawing.Point(613, 6);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(78, 80);
            this.panel_edit.TabIndex = 21;
            // 
            // picturebox_edit
            // 
            this.picturebox_edit.Location = new System.Drawing.Point(3, 4);
            this.picturebox_edit.Name = "picturebox_edit";
            this.picturebox_edit.Size = new System.Drawing.Size(72, 76);
            this.picturebox_edit.TabIndex = 0;
            this.picturebox_edit.TabStop = false;
            this.picturebox_edit.Click += new System.EventHandler(this.picturebox_edit_Click);
            // 
            // panel_main_creator_image
            // 
            this.panel_main_creator_image.Controls.Add(this.picturebox_main_creator_image);
            this.panel_main_creator_image.Location = new System.Drawing.Point(30, 10);
            this.panel_main_creator_image.Name = "panel_main_creator_image";
            this.panel_main_creator_image.Size = new System.Drawing.Size(78, 80);
            this.panel_main_creator_image.TabIndex = 19;
            // 
            // picturebox_main_creator_image
            // 
            this.picturebox_main_creator_image.Location = new System.Drawing.Point(3, 4);
            this.picturebox_main_creator_image.Name = "picturebox_main_creator_image";
            this.picturebox_main_creator_image.Size = new System.Drawing.Size(72, 76);
            this.picturebox_main_creator_image.TabIndex = 0;
            this.picturebox_main_creator_image.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (51)))), ((int) (((byte) (51)))));
            this.ClientSize = new System.Drawing.Size(913, 562);
            this.Controls.Add(this.staySameTemplate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.yt_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_yt_icon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel_twitch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_twitch_icon)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel_insta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_insta_icon)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel_twitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_twitter_icon)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.staySameTemplate.ResumeLayout(false);
            this.panel_edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_edit)).EndInit();
            this.panel_main_creator_image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_main_creator_image)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.PictureBox picturebox_edit;

        private System.Windows.Forms.Label label_twitter_tweet;

        private System.Windows.Forms.Label third_newest_tweet;
        //private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label newest_tweet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label second_newest_tweet;
        //private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Panel panel_insta;
        private System.Windows.Forms.PictureBox pictureBox_insta_icon;

        private System.Windows.Forms.Panel panel_twitch;
        private System.Windows.Forms.Panel panel_twitter;
        private System.Windows.Forms.PictureBox pictureBox_twitch_icon;
        private System.Windows.Forms.PictureBox pictureBox_twitter_icon;
        private System.Windows.Forms.PictureBox pictureBox_yt_icon;
        private System.Windows.Forms.Panel yt_panel;

        private System.Windows.Forms.Panel test_panel;

        private System.Windows.Forms.Panel panel_main_creator_image;
        private System.Windows.Forms.PictureBox picturebox_main_creator_image;

        private System.Windows.Forms.Label third_tweet_text_like;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label_twitch;

        private System.Windows.Forms.Label label_twitter;

        private System.Windows.Forms.Label second_tweet_text_likes;
        private System.Windows.Forms.Label second_tweet_likes_amount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label third_tweet_likes_amount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;

        private System.Windows.Forms.Label first_tweet_likes_amount;
        private System.Windows.Forms.Label first_tweet_text_likes;

        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Panel panel8;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Panel staySameTemplate;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private System.Windows.Forms.Button button_create_new_creator;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textbox_search;

        private System.Windows.Forms.Label label_twitter_follower_count;
        private System.Windows.Forms.Label label_twitch_follower_count;
        private System.Windows.Forms.Panel panel7;

        private System.Windows.Forms.Label label_yt_follower_count;


        private System.Windows.Forms.Label label_yt;

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Label label_main_creator_name;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}