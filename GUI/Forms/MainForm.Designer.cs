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
            
            

            picturebox_edit.Image = Image.FromFile($@"{path}\Images\edit_icon.png");
            picturebox_edit.Size = new Size(15,15);
            picturebox_edit.Location = new Point(60, 50);
            picturebox_edit.SizeMode = PictureBoxSizeMode.StretchImage;
            
            
            
            //https://stackoverflow.com/questions/7731855/rounded-edges-in-picturebox-c-sharp
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, picturebox_twitterbot_image_tweet.Width - 3, picturebox_icon_twitterbox.Height - 3);
            Region rg = new Region(gp);
            picturebox_icon_twitterbox.Region = rg;
            
            picturebox_icon_twitterbox.Image = Image.FromFile($@"{path}\Images\twitterbot.png");
            picturebox_icon_twitterbox.Size = new Size(25,22);
            picturebox_icon_twitterbox.SizeMode = PictureBoxSizeMode.StretchImage;
            
            var size = new Size(14,14);
            var sizemode = PictureBoxSizeMode.StretchImage;
            
            first_tweet_quote_icon.Image = Image.FromFile($@"{path}\Images\queote.png");
            first_tweet_quote_icon.Size = size;
            first_tweet_quote_icon.SizeMode = sizemode;
            
            second_tweet_quote_icon.Image = Image.FromFile($@"{path}\Images\queote.png");
            second_tweet_quote_icon.Size = size;
            second_tweet_quote_icon.SizeMode = sizemode;
            
            third_tweet_quote_icon.Image = Image.FromFile($@"{path}\Images\queote.png");
            third_tweet_quote_icon.Size = size;
            third_tweet_quote_icon.SizeMode = sizemode;
            
            picturebox_quote_bot.Image = Image.FromFile($@"{path}\Images\queote.png");
            picturebox_quote_bot.Size = size;
            picturebox_quote_bot.SizeMode = sizemode;
            
            creator_retweet_icon_first.Image = Image.FromFile($@"{path}\Images\retweet.png");
            creator_retweet_icon_first.Size = new Size(22,22);
            creator_retweet_icon_first.SizeMode = sizemode;
            
            second_tweet_retweet_icon.Image = Image.FromFile($@"{path}\Images\retweet.png");
            second_tweet_retweet_icon.Size = new Size(22,22);
            second_tweet_retweet_icon.SizeMode = sizemode;
            
            creator_retweet_third_icon.Image = Image.FromFile($@"{path}\Images\retweet.png");
            creator_retweet_third_icon.Size = new Size(22,22);
            creator_retweet_third_icon.SizeMode = sizemode;
            
            picturebox_retweet_bot.Image = Image.FromFile($@"{path}\Images\retweet.png");
            picturebox_retweet_bot.Size = new Size(22,22);
            picturebox_retweet_bot.SizeMode = sizemode;
            
            first_tweet_likes_icon.Image = Image.FromFile($@"{path}\Images\like.png");
            first_tweet_likes_icon.Size = size;
            first_tweet_likes_icon.SizeMode = sizemode;
            
            second_tweet_likes_icon.Image = Image.FromFile($@"{path}\Images\like.png");
            second_tweet_likes_icon.Size = size;
            second_tweet_likes_icon.SizeMode = sizemode;
            
            third_tweet_likes_icon.Image = Image.FromFile($@"{path}\Images\like.png");
            third_tweet_likes_icon.Size = size;
            third_tweet_likes_icon.SizeMode = sizemode;
            
            picturebox_likes_bot.Image = Image.FromFile($@"{path}\Images\like.png");
            picturebox_likes_bot.Size = size;
            picturebox_likes_bot.SizeMode = sizemode;
            
            picturebox_twitterbot_image_tweet.Image = Image.FromFile($@"{path}\Images\twitterbot_twitter.jpg");
            System.Drawing.Drawing2D.GraphicsPath gp1 = new System.Drawing.Drawing2D.GraphicsPath();
            gp1.AddEllipse(0, 0, picturebox_twitterbot_image_tweet.Width - 3, picturebox_twitterbot_image_tweet.Height - 3);
            Region r1 = new Region(gp1);
            picturebox_twitterbot_image_tweet.Region = r1;
            picturebox_twitterbot_image_tweet.SizeMode = PictureBoxSizeMode.StretchImage;

            label_yt.Text = "YOUTUBE";
            label_twitter.Text = "TWITTER";
            label_twitch.Text = "TWITCH";

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
            this.allCreatorStatistics_Panel = new System.Windows.Forms.Panel();
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
            this.panel_area_twitterbot = new System.Windows.Forms.Panel();
            this.twitterbot_tweet = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.picturebox_likes_bot = new System.Windows.Forms.PictureBox();
            this.label_likes_amount_bot = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.picturebox_retweet_bot = new System.Windows.Forms.PictureBox();
            this.label_retweet_amount_bot = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.picturebox_quote_bot = new System.Windows.Forms.PictureBox();
            this.panel27 = new System.Windows.Forms.Panel();
            this.picturebox_twitterbot_image_tweet = new System.Windows.Forms.PictureBox();
            this.label_tweet_text_twitterbot = new System.Windows.Forms.Label();
            this.label_quote_amount_bot = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel_twitterbot = new System.Windows.Forms.Panel();
            this.picturebox_icon_twitterbox = new System.Windows.Forms.PictureBox();
            this.label_twitterbot = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel_twitter = new System.Windows.Forms.Panel();
            this.pictureBox_twitter_icon = new System.Windows.Forms.PictureBox();
            this.label_twitter = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.creator_two_retweet_amount = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.second_tweet_likes_icon = new System.Windows.Forms.PictureBox();
            this.second_tweet_likes_amount = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.second_tweet_retweet_icon = new System.Windows.Forms.PictureBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.second_tweet_quote_icon = new System.Windows.Forms.PictureBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.picturebox_creator_twitter_image_2 = new System.Windows.Forms.PictureBox();
            this.second_newest_tweet = new System.Windows.Forms.Label();
            this.second_tweet_quote_amount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.third_tweet_likes_icon = new System.Windows.Forms.PictureBox();
            this.third_tweet_likes_amount = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.creator_retweet_third_icon = new System.Windows.Forms.PictureBox();
            this.third_tweet_retweet_amount = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.third_tweet_quote_icon = new System.Windows.Forms.PictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.picturebox_creator_twitter_image_3 = new System.Windows.Forms.PictureBox();
            this.third_newest_tweet = new System.Windows.Forms.Label();
            this.third_tweet_quote_amount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_twitter_tweet = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.first_quote_creator_amount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.creator_retweet_icon_first = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.first_tweet_likes_icon = new System.Windows.Forms.PictureBox();
            this.first_tweet_retweet_amount = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.first_tweet_quote_icon = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.picturebox_creator_twitter_image_1 = new System.Windows.Forms.PictureBox();
            this.newest_tweet = new System.Windows.Forms.Label();
            this.first_tweet_likes_amount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.creatorTemplate_panel = new System.Windows.Forms.Panel();
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
            this.panel_area_twitterbot.SuspendLayout();
            this.twitterbot_tweet.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_likes_bot)).BeginInit();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_retweet_bot)).BeginInit();
            this.panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_quote_bot)).BeginInit();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_twitterbot_image_tweet)).BeginInit();
            this.panel_twitterbot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_icon_twitterbox)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel_twitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_twitter_icon)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.second_tweet_likes_icon)).BeginInit();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.second_tweet_retweet_icon)).BeginInit();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.second_tweet_quote_icon)).BeginInit();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_creator_twitter_image_2)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.third_tweet_likes_icon)).BeginInit();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.creator_retweet_third_icon)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.third_tweet_quote_icon)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_creator_twitter_image_3)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.creator_retweet_icon_first)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.first_tweet_likes_icon)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.first_tweet_quote_icon)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_creator_twitter_image_1)).BeginInit();
            this.creatorTemplate_panel.SuspendLayout();
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
            // allCreatorStatistics_Panel
            // 
            this.allCreatorStatistics_Panel.Location = new System.Drawing.Point(11, 0);
            this.allCreatorStatistics_Panel.Name = "allCreatorStatistics_Panel";
            this.allCreatorStatistics_Panel.Size = new System.Drawing.Size(704, 519);
            this.allCreatorStatistics_Panel.TabIndex = 20;
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
            // panel_area_twitterbot
            // 
            this.panel_area_twitterbot.BackColor = System.Drawing.Color.Transparent;
            this.panel_area_twitterbot.Controls.Add(this.twitterbot_tweet);
            this.panel_area_twitterbot.Controls.Add(this.panel_twitterbot);
            this.panel_area_twitterbot.Controls.Add(this.label_twitterbot);
            this.panel_area_twitterbot.Location = new System.Drawing.Point(30, 381);
            this.panel_area_twitterbot.Name = "panel_area_twitterbot";
            this.panel_area_twitterbot.Size = new System.Drawing.Size(300, 112);
            this.panel_area_twitterbot.TabIndex = 10;
            // 
            // twitterbot_tweet
            // 
            this.twitterbot_tweet.BackColor = System.Drawing.Color.Transparent;
            this.twitterbot_tweet.Controls.Add(this.panel24);
            this.twitterbot_tweet.Controls.Add(this.label_likes_amount_bot);
            this.twitterbot_tweet.Controls.Add(this.panel25);
            this.twitterbot_tweet.Controls.Add(this.label_retweet_amount_bot);
            this.twitterbot_tweet.Controls.Add(this.panel26);
            this.twitterbot_tweet.Controls.Add(this.panel27);
            this.twitterbot_tweet.Controls.Add(this.label_tweet_text_twitterbot);
            this.twitterbot_tweet.Controls.Add(this.label_quote_amount_bot);
            this.twitterbot_tweet.Controls.Add(this.label20);
            this.twitterbot_tweet.Location = new System.Drawing.Point(3, 43);
            this.twitterbot_tweet.Name = "twitterbot_tweet";
            this.twitterbot_tweet.Size = new System.Drawing.Size(291, 57);
            this.twitterbot_tweet.TabIndex = 22;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.picturebox_likes_bot);
            this.panel24.Location = new System.Drawing.Point(188, 36);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(24, 24);
            this.panel24.TabIndex = 28;
            // 
            // picturebox_likes_bot
            // 
            this.picturebox_likes_bot.Location = new System.Drawing.Point(3, 4);
            this.picturebox_likes_bot.Name = "picturebox_likes_bot";
            this.picturebox_likes_bot.Size = new System.Drawing.Size(18, 18);
            this.picturebox_likes_bot.TabIndex = 0;
            this.picturebox_likes_bot.TabStop = false;
            // 
            // label_likes_amount_bot
            // 
            this.label_likes_amount_bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_likes_amount_bot.ForeColor = System.Drawing.Color.White;
            this.label_likes_amount_bot.Location = new System.Drawing.Point(218, 38);
            this.label_likes_amount_bot.Name = "label_likes_amount_bot";
            this.label_likes_amount_bot.Size = new System.Drawing.Size(42, 18);
            this.label_likes_amount_bot.TabIndex = 27;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.picturebox_retweet_bot);
            this.panel25.Location = new System.Drawing.Point(116, 32);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(24, 24);
            this.panel25.TabIndex = 26;
            // 
            // picturebox_retweet_bot
            // 
            this.picturebox_retweet_bot.Location = new System.Drawing.Point(3, 4);
            this.picturebox_retweet_bot.Name = "picturebox_retweet_bot";
            this.picturebox_retweet_bot.Size = new System.Drawing.Size(18, 18);
            this.picturebox_retweet_bot.TabIndex = 0;
            this.picturebox_retweet_bot.TabStop = false;
            // 
            // label_retweet_amount_bot
            // 
            this.label_retweet_amount_bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_retweet_amount_bot.ForeColor = System.Drawing.Color.White;
            this.label_retweet_amount_bot.Location = new System.Drawing.Point(143, 38);
            this.label_retweet_amount_bot.Name = "label_retweet_amount_bot";
            this.label_retweet_amount_bot.Size = new System.Drawing.Size(42, 18);
            this.label_retweet_amount_bot.TabIndex = 25;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.picturebox_quote_bot);
            this.panel26.Location = new System.Drawing.Point(41, 36);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(24, 24);
            this.panel26.TabIndex = 24;
            // 
            // picturebox_quote_bot
            // 
            this.picturebox_quote_bot.Location = new System.Drawing.Point(3, 4);
            this.picturebox_quote_bot.Name = "picturebox_quote_bot";
            this.picturebox_quote_bot.Size = new System.Drawing.Size(18, 18);
            this.picturebox_quote_bot.TabIndex = 0;
            this.picturebox_quote_bot.TabStop = false;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.picturebox_twitterbot_image_tweet);
            this.panel27.Location = new System.Drawing.Point(3, 0);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(32, 33);
            this.panel27.TabIndex = 23;
            // 
            // picturebox_twitterbot_image_tweet
            // 
            this.picturebox_twitterbot_image_tweet.Location = new System.Drawing.Point(3, 4);
            this.picturebox_twitterbot_image_tweet.Name = "picturebox_twitterbot_image_tweet";
            this.picturebox_twitterbot_image_tweet.Size = new System.Drawing.Size(26, 26);
            this.picturebox_twitterbot_image_tweet.TabIndex = 0;
            this.picturebox_twitterbot_image_tweet.TabStop = false;
            // 
            // label_tweet_text_twitterbot
            // 
            this.label_tweet_text_twitterbot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_tweet_text_twitterbot.ForeColor = System.Drawing.Color.White;
            this.label_tweet_text_twitterbot.Location = new System.Drawing.Point(41, 0);
            this.label_tweet_text_twitterbot.Name = "label_tweet_text_twitterbot";
            this.label_tweet_text_twitterbot.Size = new System.Drawing.Size(236, 36);
            this.label_tweet_text_twitterbot.TabIndex = 24;
            this.label_tweet_text_twitterbot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_quote_amount_bot
            // 
            this.label_quote_amount_bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_quote_amount_bot.ForeColor = System.Drawing.Color.White;
            this.label_quote_amount_bot.Location = new System.Drawing.Point(68, 37);
            this.label_quote_amount_bot.Name = "label_quote_amount_bot";
            this.label_quote_amount_bot.Size = new System.Drawing.Size(42, 18);
            this.label_quote_amount_bot.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(274, 43);
            this.label20.TabIndex = 22;
            // 
            // panel_twitterbot
            // 
            this.panel_twitterbot.Controls.Add(this.picturebox_icon_twitterbox);
            this.panel_twitterbot.Location = new System.Drawing.Point(265, 5);
            this.panel_twitterbot.Name = "panel_twitterbot";
            this.panel_twitterbot.Size = new System.Drawing.Size(32, 33);
            this.panel_twitterbot.TabIndex = 22;
            // 
            // picturebox_icon_twitterbox
            // 
            this.picturebox_icon_twitterbox.Location = new System.Drawing.Point(3, 4);
            this.picturebox_icon_twitterbox.Name = "picturebox_icon_twitterbox";
            this.picturebox_icon_twitterbox.Size = new System.Drawing.Size(26, 26);
            this.picturebox_icon_twitterbox.TabIndex = 0;
            this.picturebox_icon_twitterbox.TabStop = false;
            // 
            // label_twitterbot
            // 
            this.label_twitterbot.BackColor = System.Drawing.Color.Transparent;
            this.label_twitterbot.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_twitterbot.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (21)))), ((int) (((byte) (30)))), ((int) (((byte) (43)))));
            this.label_twitterbot.Location = new System.Drawing.Point(3, 5);
            this.label_twitterbot.Name = "label_twitterbot";
            this.label_twitterbot.Size = new System.Drawing.Size(154, 26);
            this.label_twitterbot.TabIndex = 22;
            this.label_twitterbot.Text = "TWITTERBOT";
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
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (21)))), ((int) (((byte) (30)))), ((int) (((byte) (43)))));
            this.panel7.Controls.Add(this.panel18);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.label_twitter_tweet);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(391, 237);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 256);
            this.panel7.TabIndex = 18;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Transparent;
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.creator_two_retweet_amount);
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Controls.Add(this.second_tweet_likes_amount);
            this.panel18.Controls.Add(this.panel20);
            this.panel18.Controls.Add(this.panel21);
            this.panel18.Controls.Add(this.panel22);
            this.panel18.Controls.Add(this.second_newest_tweet);
            this.panel18.Controls.Add(this.second_tweet_quote_amount);
            this.panel18.Controls.Add(this.label15);
            this.panel18.Location = new System.Drawing.Point(10, 116);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(280, 61);
            this.panel18.TabIndex = 30;
            // 
            // creator_two_retweet_amount
            // 
            this.creator_two_retweet_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.creator_two_retweet_amount.ForeColor = System.Drawing.Color.White;
            this.creator_two_retweet_amount.Location = new System.Drawing.Point(143, 40);
            this.creator_two_retweet_amount.Name = "creator_two_retweet_amount";
            this.creator_two_retweet_amount.Size = new System.Drawing.Size(42, 18);
            this.creator_two_retweet_amount.TabIndex = 29;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.second_tweet_likes_icon);
            this.panel19.Location = new System.Drawing.Point(191, 36);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(24, 24);
            this.panel19.TabIndex = 28;
            // 
            // second_tweet_likes_icon
            // 
            this.second_tweet_likes_icon.Location = new System.Drawing.Point(3, 4);
            this.second_tweet_likes_icon.Name = "second_tweet_likes_icon";
            this.second_tweet_likes_icon.Size = new System.Drawing.Size(18, 18);
            this.second_tweet_likes_icon.TabIndex = 0;
            this.second_tweet_likes_icon.TabStop = false;
            // 
            // second_tweet_likes_amount
            // 
            this.second_tweet_likes_amount.ForeColor = System.Drawing.Color.White;
            this.second_tweet_likes_amount.Location = new System.Drawing.Point(218, 37);
            this.second_tweet_likes_amount.Name = "second_tweet_likes_amount";
            this.second_tweet_likes_amount.Size = new System.Drawing.Size(42, 20);
            this.second_tweet_likes_amount.TabIndex = 29;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.second_tweet_retweet_icon);
            this.panel20.Location = new System.Drawing.Point(116, 36);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(24, 24);
            this.panel20.TabIndex = 26;
            // 
            // second_tweet_retweet_icon
            // 
            this.second_tweet_retweet_icon.Location = new System.Drawing.Point(3, 3);
            this.second_tweet_retweet_icon.Name = "second_tweet_retweet_icon";
            this.second_tweet_retweet_icon.Size = new System.Drawing.Size(18, 18);
            this.second_tweet_retweet_icon.TabIndex = 0;
            this.second_tweet_retweet_icon.TabStop = false;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.second_tweet_quote_icon);
            this.panel21.Location = new System.Drawing.Point(41, 36);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(24, 24);
            this.panel21.TabIndex = 24;
            // 
            // second_tweet_quote_icon
            // 
            this.second_tweet_quote_icon.Location = new System.Drawing.Point(3, 3);
            this.second_tweet_quote_icon.Name = "second_tweet_quote_icon";
            this.second_tweet_quote_icon.Size = new System.Drawing.Size(18, 18);
            this.second_tweet_quote_icon.TabIndex = 1;
            this.second_tweet_quote_icon.TabStop = false;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.picturebox_creator_twitter_image_2);
            this.panel22.Location = new System.Drawing.Point(3, 3);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(32, 33);
            this.panel22.TabIndex = 23;
            // 
            // picturebox_creator_twitter_image_2
            // 
            this.picturebox_creator_twitter_image_2.Location = new System.Drawing.Point(3, 4);
            this.picturebox_creator_twitter_image_2.Name = "picturebox_creator_twitter_image_2";
            this.picturebox_creator_twitter_image_2.Size = new System.Drawing.Size(26, 26);
            this.picturebox_creator_twitter_image_2.TabIndex = 0;
            this.picturebox_creator_twitter_image_2.TabStop = false;
            // 
            // second_newest_tweet
            // 
            this.second_newest_tweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.second_newest_tweet.ForeColor = System.Drawing.Color.White;
            this.second_newest_tweet.Location = new System.Drawing.Point(41, 0);
            this.second_newest_tweet.Name = "second_newest_tweet";
            this.second_newest_tweet.Size = new System.Drawing.Size(236, 36);
            this.second_newest_tweet.TabIndex = 24;
            this.second_newest_tweet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // second_tweet_quote_amount
            // 
            this.second_tweet_quote_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.second_tweet_quote_amount.ForeColor = System.Drawing.Color.White;
            this.second_tweet_quote_amount.Location = new System.Drawing.Point(68, 39);
            this.second_tweet_quote_amount.Name = "second_tweet_quote_amount";
            this.second_tweet_quote_amount.Size = new System.Drawing.Size(42, 18);
            this.second_tweet_quote_amount.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(274, 43);
            this.label15.TabIndex = 22;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.third_tweet_likes_amount);
            this.panel9.Controls.Add(this.panel15);
            this.panel9.Controls.Add(this.third_tweet_retweet_amount);
            this.panel9.Controls.Add(this.panel16);
            this.panel9.Controls.Add(this.panel17);
            this.panel9.Controls.Add(this.third_newest_tweet);
            this.panel9.Controls.Add(this.third_tweet_quote_amount);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(10, 183);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(280, 61);
            this.panel9.TabIndex = 29;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.third_tweet_likes_icon);
            this.panel10.Location = new System.Drawing.Point(191, 36);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(24, 24);
            this.panel10.TabIndex = 28;
            // 
            // third_tweet_likes_icon
            // 
            this.third_tweet_likes_icon.Location = new System.Drawing.Point(3, 4);
            this.third_tweet_likes_icon.Name = "third_tweet_likes_icon";
            this.third_tweet_likes_icon.Size = new System.Drawing.Size(18, 18);
            this.third_tweet_likes_icon.TabIndex = 0;
            this.third_tweet_likes_icon.TabStop = false;
            // 
            // third_tweet_likes_amount
            // 
            this.third_tweet_likes_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.third_tweet_likes_amount.ForeColor = System.Drawing.Color.White;
            this.third_tweet_likes_amount.Location = new System.Drawing.Point(218, 40);
            this.third_tweet_likes_amount.Name = "third_tweet_likes_amount";
            this.third_tweet_likes_amount.Size = new System.Drawing.Size(42, 18);
            this.third_tweet_likes_amount.TabIndex = 27;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.creator_retweet_third_icon);
            this.panel15.Location = new System.Drawing.Point(116, 36);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(24, 24);
            this.panel15.TabIndex = 26;
            // 
            // creator_retweet_third_icon
            // 
            this.creator_retweet_third_icon.Location = new System.Drawing.Point(3, 3);
            this.creator_retweet_third_icon.Name = "creator_retweet_third_icon";
            this.creator_retweet_third_icon.Size = new System.Drawing.Size(18, 18);
            this.creator_retweet_third_icon.TabIndex = 1;
            this.creator_retweet_third_icon.TabStop = false;
            // 
            // third_tweet_retweet_amount
            // 
            this.third_tweet_retweet_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.third_tweet_retweet_amount.ForeColor = System.Drawing.Color.White;
            this.third_tweet_retweet_amount.Location = new System.Drawing.Point(143, 40);
            this.third_tweet_retweet_amount.Name = "third_tweet_retweet_amount";
            this.third_tweet_retweet_amount.Size = new System.Drawing.Size(42, 18);
            this.third_tweet_retweet_amount.TabIndex = 25;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.third_tweet_quote_icon);
            this.panel16.Location = new System.Drawing.Point(41, 35);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(24, 24);
            this.panel16.TabIndex = 24;
            // 
            // third_tweet_quote_icon
            // 
            this.third_tweet_quote_icon.Location = new System.Drawing.Point(3, 4);
            this.third_tweet_quote_icon.Name = "third_tweet_quote_icon";
            this.third_tweet_quote_icon.Size = new System.Drawing.Size(18, 18);
            this.third_tweet_quote_icon.TabIndex = 0;
            this.third_tweet_quote_icon.TabStop = false;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.picturebox_creator_twitter_image_3);
            this.panel17.Location = new System.Drawing.Point(3, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(32, 33);
            this.panel17.TabIndex = 23;
            // 
            // picturebox_creator_twitter_image_3
            // 
            this.picturebox_creator_twitter_image_3.Location = new System.Drawing.Point(3, 4);
            this.picturebox_creator_twitter_image_3.Name = "picturebox_creator_twitter_image_3";
            this.picturebox_creator_twitter_image_3.Size = new System.Drawing.Size(26, 26);
            this.picturebox_creator_twitter_image_3.TabIndex = 0;
            this.picturebox_creator_twitter_image_3.TabStop = false;
            // 
            // third_newest_tweet
            // 
            this.third_newest_tweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.third_newest_tweet.ForeColor = System.Drawing.Color.White;
            this.third_newest_tweet.Location = new System.Drawing.Point(41, 0);
            this.third_newest_tweet.Name = "third_newest_tweet";
            this.third_newest_tweet.Size = new System.Drawing.Size(236, 36);
            this.third_newest_tweet.TabIndex = 24;
            this.third_newest_tweet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // third_tweet_quote_amount
            // 
            this.third_tweet_quote_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.third_tweet_quote_amount.ForeColor = System.Drawing.Color.White;
            this.third_tweet_quote_amount.Location = new System.Drawing.Point(68, 39);
            this.third_tweet_quote_amount.Name = "third_tweet_quote_amount";
            this.third_tweet_quote_amount.Size = new System.Drawing.Size(42, 18);
            this.third_tweet_quote_amount.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 43);
            this.label8.TabIndex = 22;
            // 
            // label_twitter_tweet
            // 
            this.label_twitter_tweet.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_twitter_tweet.ForeColor = System.Drawing.Color.White;
            this.label_twitter_tweet.Location = new System.Drawing.Point(10, 13);
            this.label_twitter_tweet.Name = "label_twitter_tweet";
            this.label_twitter_tweet.Size = new System.Drawing.Size(280, 25);
            this.label_twitter_tweet.TabIndex = 20;
            this.label_twitter_tweet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.first_quote_creator_amount);
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Controls.Add(this.panel14);
            this.panel8.Controls.Add(this.first_tweet_retweet_amount);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.newest_tweet);
            this.panel8.Controls.Add(this.first_tweet_likes_amount);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Location = new System.Drawing.Point(10, 49);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(280, 61);
            this.panel8.TabIndex = 19;
            // 
            // first_quote_creator_amount
            // 
            this.first_quote_creator_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.first_quote_creator_amount.ForeColor = System.Drawing.Color.White;
            this.first_quote_creator_amount.Location = new System.Drawing.Point(68, 39);
            this.first_quote_creator_amount.Name = "first_quote_creator_amount";
            this.first_quote_creator_amount.Size = new System.Drawing.Size(42, 18);
            this.first_quote_creator_amount.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.creator_retweet_icon_first);
            this.panel5.Location = new System.Drawing.Point(116, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 24);
            this.panel5.TabIndex = 27;
            // 
            // creator_retweet_icon_first
            // 
            this.creator_retweet_icon_first.Location = new System.Drawing.Point(3, 3);
            this.creator_retweet_icon_first.Name = "creator_retweet_icon_first";
            this.creator_retweet_icon_first.Size = new System.Drawing.Size(18, 18);
            this.creator_retweet_icon_first.TabIndex = 0;
            this.creator_retweet_icon_first.TabStop = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.first_tweet_likes_icon);
            this.panel14.Location = new System.Drawing.Point(191, 36);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(24, 24);
            this.panel14.TabIndex = 28;
            // 
            // first_tweet_likes_icon
            // 
            this.first_tweet_likes_icon.Location = new System.Drawing.Point(3, 4);
            this.first_tweet_likes_icon.Name = "first_tweet_likes_icon";
            this.first_tweet_likes_icon.Size = new System.Drawing.Size(18, 18);
            this.first_tweet_likes_icon.TabIndex = 0;
            this.first_tweet_likes_icon.TabStop = false;
            // 
            // first_tweet_retweet_amount
            // 
            this.first_tweet_retweet_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.first_tweet_retweet_amount.ForeColor = System.Drawing.Color.White;
            this.first_tweet_retweet_amount.Location = new System.Drawing.Point(143, 40);
            this.first_tweet_retweet_amount.Name = "first_tweet_retweet_amount";
            this.first_tweet_retweet_amount.Size = new System.Drawing.Size(42, 18);
            this.first_tweet_retweet_amount.TabIndex = 25;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.first_tweet_quote_icon);
            this.panel12.Location = new System.Drawing.Point(41, 36);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(24, 24);
            this.panel12.TabIndex = 24;
            // 
            // first_tweet_quote_icon
            // 
            this.first_tweet_quote_icon.Location = new System.Drawing.Point(3, 4);
            this.first_tweet_quote_icon.Name = "first_tweet_quote_icon";
            this.first_tweet_quote_icon.Size = new System.Drawing.Size(18, 18);
            this.first_tweet_quote_icon.TabIndex = 0;
            this.first_tweet_quote_icon.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.picturebox_creator_twitter_image_1);
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(32, 33);
            this.panel11.TabIndex = 23;
            // 
            // picturebox_creator_twitter_image_1
            // 
            this.picturebox_creator_twitter_image_1.Location = new System.Drawing.Point(3, 4);
            this.picturebox_creator_twitter_image_1.Name = "picturebox_creator_twitter_image_1";
            this.picturebox_creator_twitter_image_1.Size = new System.Drawing.Size(26, 26);
            this.picturebox_creator_twitter_image_1.TabIndex = 0;
            this.picturebox_creator_twitter_image_1.TabStop = false;
            // 
            // newest_tweet
            // 
            this.newest_tweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.newest_tweet.ForeColor = System.Drawing.Color.White;
            this.newest_tweet.Location = new System.Drawing.Point(41, 0);
            this.newest_tweet.Name = "newest_tweet";
            this.newest_tweet.Size = new System.Drawing.Size(236, 36);
            this.newest_tweet.TabIndex = 24;
            this.newest_tweet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // first_tweet_likes_amount
            // 
            this.first_tweet_likes_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.first_tweet_likes_amount.ForeColor = System.Drawing.Color.White;
            this.first_tweet_likes_amount.Location = new System.Drawing.Point(218, 39);
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
            // creatorTemplate_panel
            // 
            this.creatorTemplate_panel.BackColor = System.Drawing.Color.Transparent;
            this.creatorTemplate_panel.Controls.Add(this.panel_edit);
            this.creatorTemplate_panel.Controls.Add(this.panel_main_creator_image);
            this.creatorTemplate_panel.Controls.Add(this.allCreatorStatistics_Panel);
            this.creatorTemplate_panel.Controls.Add(this.panel6);
            this.creatorTemplate_panel.Controls.Add(this.label_main_creator_name);
            this.creatorTemplate_panel.Controls.Add(this.panel_area_twitterbot);
            this.creatorTemplate_panel.Controls.Add(this.panel7);
            this.creatorTemplate_panel.Controls.Add(this.panel4);
            this.creatorTemplate_panel.Controls.Add(this.panel3);
            this.creatorTemplate_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.creatorTemplate_panel.Location = new System.Drawing.Point(195, 40);
            this.creatorTemplate_panel.Name = "creatorTemplate_panel";
            this.creatorTemplate_panel.Size = new System.Drawing.Size(718, 522);
            this.creatorTemplate_panel.TabIndex = 19;
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
            this.Controls.Add(this.creatorTemplate_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.yt_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_yt_icon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel_twitch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_twitch_icon)).EndInit();
            this.panel_area_twitterbot.ResumeLayout(false);
            this.twitterbot_tweet.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_likes_bot)).EndInit();
            this.panel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_retweet_bot)).EndInit();
            this.panel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_quote_bot)).EndInit();
            this.panel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_twitterbot_image_tweet)).EndInit();
            this.panel_twitterbot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_icon_twitterbox)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel_twitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_twitter_icon)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.second_tweet_likes_icon)).EndInit();
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.second_tweet_retweet_icon)).EndInit();
            this.panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.second_tweet_quote_icon)).EndInit();
            this.panel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_creator_twitter_image_2)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.third_tweet_likes_icon)).EndInit();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.creator_retweet_third_icon)).EndInit();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.third_tweet_quote_icon)).EndInit();
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_creator_twitter_image_3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.creator_retweet_icon_first)).EndInit();
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.first_tweet_likes_icon)).EndInit();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.first_tweet_quote_icon)).EndInit();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_creator_twitter_image_1)).EndInit();
            this.creatorTemplate_panel.ResumeLayout(false);
            this.panel_edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_edit)).EndInit();
            this.panel_main_creator_image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_main_creator_image)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label creator_two_retweet_amount;

        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
        // private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label first_quote_creator_amount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox second_tweet_quote_icon;
        private System.Windows.Forms.PictureBox creator_retweet_icon_first;
        private System.Windows.Forms.PictureBox creator_retweet_third_icon;

        private System.Windows.Forms.Label label_likes_amount_bot;
        private System.Windows.Forms.Label label_quote_amount_bot;
        private System.Windows.Forms.Label label_retweet_amount_bot;
        private System.Windows.Forms.Label label_tweet_text_twitterbot;
        //private System.Windows.Forms.Label second_tweet_retweet_amount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label second_tweet_quote_amount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label first_tweet_retweet_amount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label third_tweet_likes_amount;
        private System.Windows.Forms.Label third_tweet_retweet_amount;
        private System.Windows.Forms.Label third_tweet_quote_amount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label second_tweet_likes_amount;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox picturebox_creator_twitter_image_2;
        private System.Windows.Forms.PictureBox picturebox_creator_twitter_image_3;
        private System.Windows.Forms.PictureBox picturebox_likes_bot;
        private System.Windows.Forms.PictureBox picturebox_quote_bot;
        private System.Windows.Forms.PictureBox picturebox_retweet_bot;
        private System.Windows.Forms.PictureBox picturebox_twitterbot_image_tweet;
        private System.Windows.Forms.PictureBox second_tweet_retweet_icon;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox b;
        private System.Windows.Forms.PictureBox first_tweet_likes_icon;
        private System.Windows.Forms.PictureBox third_tweet_likes_icon;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox third_tweet_quote_icon;
        private System.Windows.Forms.PictureBox second_tweet_likes_icon;
        private System.Windows.Forms.Label second_newest_tweet;
        private System.Windows.Forms.Label third_newest_tweet;
        private System.Windows.Forms.Panel twitterbot_tweet;

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox picturebox_creator_twitter_image_1;
        private System.Windows.Forms.PictureBox first_tweet_quote_icon;

        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.PictureBox picturebox_edit;

        private System.Windows.Forms.Label label_twitter_tweet;

        //private System.Windows.Forms.Label label10;
        //private System.Windows.Forms.Label second_tweet_retweet_amount;
        private System.Windows.Forms.Label newest_tweet;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label9;
        //private System.Windows.Forms.Label second_tweet_likes_amount;

        private System.Windows.Forms.Panel panel_twitterbot;
        private System.Windows.Forms.PictureBox picturebox_icon_twitterbox;

        private System.Windows.Forms.Panel panel_twitch;
        private System.Windows.Forms.Panel panel_twitter;
        private System.Windows.Forms.PictureBox pictureBox_twitch_icon;
        private System.Windows.Forms.PictureBox pictureBox_twitter_icon;
        private System.Windows.Forms.PictureBox pictureBox_yt_icon;
        private System.Windows.Forms.Panel yt_panel;

        private System.Windows.Forms.Panel allCreatorStatistics_Panel;

        private System.Windows.Forms.Panel panel_main_creator_image;
        private System.Windows.Forms.PictureBox picturebox_main_creator_image;

        private System.Windows.Forms.Label label_twitterbot;

        private System.Windows.Forms.Label label_twitch;

        private System.Windows.Forms.Label label_twitter;

        private System.Windows.Forms.Label first_tweet_likes_amount;

        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Panel panel8;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Panel creatorTemplate_panel;

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
        private System.Windows.Forms.Panel panel_area_twitterbot;
        private System.Windows.Forms.Panel panel6;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Label label_main_creator_name;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}