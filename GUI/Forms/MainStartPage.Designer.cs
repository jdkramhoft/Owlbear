using System.ComponentModel;
using System.Drawing;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace GUI
{
    partial class MainStartPage
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

        public void LoadResources()
        {
            var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            
            var size = new Size(14,14);
             var sizemode = PictureBoxSizeMode.StretchImage;
             
             picturebox_icon_twitterbox.Image = Image.FromFile($@"{path}\Images\twitterbot.png");
             picturebox_icon_twitterbox.Size = new Size(25,22);
             picturebox_icon_twitterbox.SizeMode = PictureBoxSizeMode.StretchImage;
            
             picturebox_quote_bot.Image = Image.FromFile($@"{path}\Images\queote.png");
             picturebox_quote_bot.Size = size;
             picturebox_quote_bot.SizeMode = sizemode;
            
             picturebox_retweet_bot.Image = Image.FromFile($@"{path}\Images\retweet.png");
             picturebox_retweet_bot.Size = new Size(22,22);
             picturebox_retweet_bot.SizeMode = sizemode;
            
             picturebox_likes_bot.Image = Image.FromFile($@"{path}\Images\like.png");
             picturebox_likes_bot.Size = size;
             picturebox_likes_bot.SizeMode = sizemode;
            
             twitterbot_image.Image = Image.FromFile($@"{path}\Images\twitterbot.png");
             picturebox_retweet_bot.Size = new Size(22,22);
             picturebox_retweet_bot.SizeMode = sizemode;
             
             picturebox_twitterbot_image_tweet_1.Image = Image.FromFile($@"{path}\Images\twitterbot_twitter.jpg");
             //https://stackoverflow.com/questions/7731855/rounded-edges-in-picturebox-c-sharp
             System.Drawing.Drawing2D.GraphicsPath gp1 = new System.Drawing.Drawing2D.GraphicsPath();
             gp1.AddEllipse(0, 0, picturebox_twitterbot_image_tweet_1.Width - 3, picturebox_twitterbot_image_tweet_1.Height - 3);
             Region r1 = new Region(gp1);
             picturebox_twitterbot_image_tweet_1.Region = r1;
             picturebox_twitterbot_image_tweet_1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.twitter_panel = new System.Windows.Forms.Panel();
            this.twitter_third_name = new System.Windows.Forms.Label();
            this.twitter_first_name = new System.Windows.Forms.Label();
            this.twitter_second_name = new System.Windows.Forms.Label();
            this.twitter_label = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.twitter_second_num = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.twitter_third_num = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.twitter_first_num = new System.Windows.Forms.Label();
            this.yt_panel = new System.Windows.Forms.Panel();
            this.yt_third_name = new System.Windows.Forms.Label();
            this.yt_first_name = new System.Windows.Forms.Label();
            this.yt_second_name = new System.Windows.Forms.Label();
            this.yt_label = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.yt_second_num = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.yt_third_num = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.yt_first_num = new System.Windows.Forms.Label();
            this.top_creators_label = new System.Windows.Forms.Label();
            this.twitch_panel = new System.Windows.Forms.Panel();
            this.twitch_third_name = new System.Windows.Forms.Label();
            this.twitch_first_name = new System.Windows.Forms.Label();
            this.twitch_second_name = new System.Windows.Forms.Label();
            this.twitch_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.twitch_second_num = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.twitch_third_num = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.twitch_first_num = new System.Windows.Forms.Label();
            this.panel_area_twitterbot = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.twitterbot_image = new System.Windows.Forms.PictureBox();
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
            this.picturebox_twitterbot_image_tweet_1 = new System.Windows.Forms.PictureBox();
            this.label_tweet_text_twitterbot_1 = new System.Windows.Forms.Label();
            this.label_quote_amount_bot = new System.Windows.Forms.Label();
            this.panel_twitterbot = new System.Windows.Forms.Panel();
            this.picturebox_icon_twitterbox = new System.Windows.Forms.PictureBox();
            this.label_twitterbot = new System.Windows.Forms.Label();
            this.twitter_panel.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.yt_panel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.twitch_panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel_area_twitterbot.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.twitterbot_image)).BeginInit();
            this.twitterbot_tweet.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_likes_bot)).BeginInit();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_retweet_bot)).BeginInit();
            this.panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_quote_bot)).BeginInit();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_twitterbot_image_tweet_1)).BeginInit();
            this.panel_twitterbot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_icon_twitterbox)).BeginInit();
            this.SuspendLayout();
            // 
            // twitter_panel
            // 
            this.twitter_panel.Controls.Add(this.twitter_third_name);
            this.twitter_panel.Controls.Add(this.twitter_first_name);
            this.twitter_panel.Controls.Add(this.twitter_second_name);
            this.twitter_panel.Controls.Add(this.twitter_label);
            this.twitter_panel.Controls.Add(this.panel14);
            this.twitter_panel.Controls.Add(this.panel15);
            this.twitter_panel.Controls.Add(this.panel16);
            this.twitter_panel.Location = new System.Drawing.Point(402, 75);
            this.twitter_panel.Name = "twitter_panel";
            this.twitter_panel.Size = new System.Drawing.Size(248, 185);
            this.twitter_panel.TabIndex = 19;
            // 
            // twitter_third_name
            // 
            this.twitter_third_name.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitter_third_name.ForeColor = System.Drawing.Color.White;
            this.twitter_third_name.Location = new System.Drawing.Point(175, 111);
            this.twitter_third_name.Name = "twitter_third_name";
            this.twitter_third_name.Size = new System.Drawing.Size(70, 15);
            this.twitter_third_name.TabIndex = 14;
            this.twitter_third_name.Text = "Name";
            this.twitter_third_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twitter_first_name
            // 
            this.twitter_first_name.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitter_first_name.ForeColor = System.Drawing.Color.White;
            this.twitter_first_name.Location = new System.Drawing.Point(90, 66);
            this.twitter_first_name.Name = "twitter_first_name";
            this.twitter_first_name.Size = new System.Drawing.Size(73, 18);
            this.twitter_first_name.TabIndex = 13;
            this.twitter_first_name.Text = "Name";
            this.twitter_first_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twitter_second_name
            // 
            this.twitter_second_name.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitter_second_name.ForeColor = System.Drawing.Color.White;
            this.twitter_second_name.Location = new System.Drawing.Point(3, 95);
            this.twitter_second_name.Name = "twitter_second_name";
            this.twitter_second_name.Size = new System.Drawing.Size(73, 13);
            this.twitter_second_name.TabIndex = 1;
            this.twitter_second_name.Text = "Name";
            this.twitter_second_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twitter_label
            // 
            this.twitter_label.BackColor = System.Drawing.Color.Transparent;
            this.twitter_label.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitter_label.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (67)))), ((int) (((byte) (125)))), ((int) (((byte) (167)))));
            this.twitter_label.Location = new System.Drawing.Point(3, 11);
            this.twitter_label.Name = "twitter_label";
            this.twitter_label.Size = new System.Drawing.Size(162, 45);
            this.twitter_label.TabIndex = 12;
            this.twitter_label.Text = "TWITTER";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (67)))), ((int) (((byte) (125)))), ((int) (((byte) (167)))));
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel14.Controls.Add(this.twitter_second_num);
            this.panel14.Location = new System.Drawing.Point(3, 111);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(73, 71);
            this.panel14.TabIndex = 2;
            // 
            // twitter_second_num
            // 
            this.twitter_second_num.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitter_second_num.ForeColor = System.Drawing.Color.White;
            this.twitter_second_num.Location = new System.Drawing.Point(3, 18);
            this.twitter_second_num.Name = "twitter_second_num";
            this.twitter_second_num.Size = new System.Drawing.Size(67, 15);
            this.twitter_second_num.TabIndex = 0;
            this.twitter_second_num.Text = "1.000.000";
            this.twitter_second_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (67)))), ((int) (((byte) (125)))), ((int) (((byte) (167)))));
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel15.Controls.Add(this.twitter_third_num);
            this.panel15.Location = new System.Drawing.Point(175, 129);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(73, 53);
            this.panel15.TabIndex = 3;
            // 
            // twitter_third_num
            // 
            this.twitter_third_num.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitter_third_num.ForeColor = System.Drawing.Color.White;
            this.twitter_third_num.Location = new System.Drawing.Point(3, 12);
            this.twitter_third_num.Name = "twitter_third_num";
            this.twitter_third_num.Size = new System.Drawing.Size(67, 16);
            this.twitter_third_num.TabIndex = 1;
            this.twitter_third_num.Text = "1.000.000";
            this.twitter_third_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (67)))), ((int) (((byte) (125)))), ((int) (((byte) (167)))));
            this.panel16.Controls.Add(this.twitter_first_num);
            this.panel16.Location = new System.Drawing.Point(90, 87);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(73, 95);
            this.panel16.TabIndex = 4;
            // 
            // twitter_first_num
            // 
            this.twitter_first_num.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitter_first_num.ForeColor = System.Drawing.Color.White;
            this.twitter_first_num.Location = new System.Drawing.Point(3, 24);
            this.twitter_first_num.Name = "twitter_first_num";
            this.twitter_first_num.Size = new System.Drawing.Size(67, 15);
            this.twitter_first_num.TabIndex = 1;
            this.twitter_first_num.Text = "1.000.000";
            this.twitter_first_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yt_panel
            // 
            this.yt_panel.Controls.Add(this.yt_third_name);
            this.yt_panel.Controls.Add(this.yt_first_name);
            this.yt_panel.Controls.Add(this.yt_second_name);
            this.yt_panel.Controls.Add(this.yt_label);
            this.yt_panel.Controls.Add(this.panel9);
            this.yt_panel.Controls.Add(this.panel10);
            this.yt_panel.Controls.Add(this.panel11);
            this.yt_panel.Location = new System.Drawing.Point(59, 75);
            this.yt_panel.Name = "yt_panel";
            this.yt_panel.Size = new System.Drawing.Size(248, 185);
            this.yt_panel.TabIndex = 20;
            // 
            // yt_third_name
            // 
            this.yt_third_name.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.yt_third_name.ForeColor = System.Drawing.Color.White;
            this.yt_third_name.Location = new System.Drawing.Point(175, 111);
            this.yt_third_name.Name = "yt_third_name";
            this.yt_third_name.Size = new System.Drawing.Size(70, 15);
            this.yt_third_name.TabIndex = 14;
            this.yt_third_name.Text = "Name";
            this.yt_third_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yt_first_name
            // 
            this.yt_first_name.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.yt_first_name.ForeColor = System.Drawing.Color.White;
            this.yt_first_name.Location = new System.Drawing.Point(90, 66);
            this.yt_first_name.Name = "yt_first_name";
            this.yt_first_name.Size = new System.Drawing.Size(73, 18);
            this.yt_first_name.TabIndex = 13;
            this.yt_first_name.Text = "Name";
            this.yt_first_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yt_second_name
            // 
            this.yt_second_name.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.yt_second_name.ForeColor = System.Drawing.Color.White;
            this.yt_second_name.Location = new System.Drawing.Point(3, 95);
            this.yt_second_name.Name = "yt_second_name";
            this.yt_second_name.Size = new System.Drawing.Size(73, 13);
            this.yt_second_name.TabIndex = 1;
            this.yt_second_name.Text = "Name";
            this.yt_second_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yt_label
            // 
            this.yt_label.BackColor = System.Drawing.Color.Transparent;
            this.yt_label.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.yt_label.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (167)))), ((int) (((byte) (67)))), ((int) (((byte) (85)))));
            this.yt_label.Location = new System.Drawing.Point(3, 11);
            this.yt_label.Name = "yt_label";
            this.yt_label.Size = new System.Drawing.Size(162, 45);
            this.yt_label.TabIndex = 12;
            this.yt_label.Text = "YOUTUBE";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (167)))), ((int) (((byte) (67)))), ((int) (((byte) (85)))));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel9.Controls.Add(this.yt_second_num);
            this.panel9.Location = new System.Drawing.Point(3, 111);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(73, 71);
            this.panel9.TabIndex = 2;
            // 
            // yt_second_num
            // 
            this.yt_second_num.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.yt_second_num.ForeColor = System.Drawing.Color.White;
            this.yt_second_num.Location = new System.Drawing.Point(3, 18);
            this.yt_second_num.Name = "yt_second_num";
            this.yt_second_num.Size = new System.Drawing.Size(67, 15);
            this.yt_second_num.TabIndex = 0;
            this.yt_second_num.Text = "1.000.000";
            this.yt_second_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (167)))), ((int) (((byte) (67)))), ((int) (((byte) (85)))));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel10.Controls.Add(this.yt_third_num);
            this.panel10.Location = new System.Drawing.Point(175, 129);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(73, 53);
            this.panel10.TabIndex = 3;
            // 
            // yt_third_num
            // 
            this.yt_third_num.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.yt_third_num.ForeColor = System.Drawing.Color.White;
            this.yt_third_num.Location = new System.Drawing.Point(3, 12);
            this.yt_third_num.Name = "yt_third_num";
            this.yt_third_num.Size = new System.Drawing.Size(67, 16);
            this.yt_third_num.TabIndex = 1;
            this.yt_third_num.Text = "1.000.000";
            this.yt_third_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (167)))), ((int) (((byte) (67)))), ((int) (((byte) (85)))));
            this.panel11.Controls.Add(this.yt_first_num);
            this.panel11.Location = new System.Drawing.Point(90, 87);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(73, 95);
            this.panel11.TabIndex = 4;
            // 
            // yt_first_num
            // 
            this.yt_first_num.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.yt_first_num.ForeColor = System.Drawing.Color.White;
            this.yt_first_num.Location = new System.Drawing.Point(3, 24);
            this.yt_first_num.Name = "yt_first_num";
            this.yt_first_num.Size = new System.Drawing.Size(67, 15);
            this.yt_first_num.TabIndex = 1;
            this.yt_first_num.Text = "1.000.000";
            this.yt_first_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // top_creators_label
            // 
            this.top_creators_label.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.top_creators_label.ForeColor = System.Drawing.Color.White;
            this.top_creators_label.Location = new System.Drawing.Point(185, 22);
            this.top_creators_label.Name = "top_creators_label";
            this.top_creators_label.Size = new System.Drawing.Size(353, 39);
            this.top_creators_label.TabIndex = 22;
            this.top_creators_label.Text = "Top creators on each platform";
            // 
            // twitch_panel
            // 
            this.twitch_panel.Controls.Add(this.twitch_third_name);
            this.twitch_panel.Controls.Add(this.twitch_first_name);
            this.twitch_panel.Controls.Add(this.twitch_second_name);
            this.twitch_panel.Controls.Add(this.twitch_label);
            this.twitch_panel.Controls.Add(this.panel4);
            this.twitch_panel.Controls.Add(this.panel5);
            this.twitch_panel.Controls.Add(this.panel6);
            this.twitch_panel.Location = new System.Drawing.Point(59, 276);
            this.twitch_panel.Name = "twitch_panel";
            this.twitch_panel.Size = new System.Drawing.Size(248, 185);
            this.twitch_panel.TabIndex = 18;
            // 
            // twitch_third_name
            // 
            this.twitch_third_name.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitch_third_name.ForeColor = System.Drawing.Color.White;
            this.twitch_third_name.Location = new System.Drawing.Point(175, 111);
            this.twitch_third_name.Name = "twitch_third_name";
            this.twitch_third_name.Size = new System.Drawing.Size(70, 15);
            this.twitch_third_name.TabIndex = 14;
            this.twitch_third_name.Text = "Name";
            this.twitch_third_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twitch_first_name
            // 
            this.twitch_first_name.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitch_first_name.ForeColor = System.Drawing.Color.White;
            this.twitch_first_name.Location = new System.Drawing.Point(90, 66);
            this.twitch_first_name.Name = "twitch_first_name";
            this.twitch_first_name.Size = new System.Drawing.Size(73, 18);
            this.twitch_first_name.TabIndex = 13;
            this.twitch_first_name.Text = "Name";
            this.twitch_first_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twitch_second_name
            // 
            this.twitch_second_name.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitch_second_name.ForeColor = System.Drawing.Color.White;
            this.twitch_second_name.Location = new System.Drawing.Point(3, 95);
            this.twitch_second_name.Name = "twitch_second_name";
            this.twitch_second_name.Size = new System.Drawing.Size(73, 13);
            this.twitch_second_name.TabIndex = 1;
            this.twitch_second_name.Text = "Name";
            this.twitch_second_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twitch_label
            // 
            this.twitch_label.BackColor = System.Drawing.Color.Transparent;
            this.twitch_label.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitch_label.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (124)))), ((int) (((byte) (74)))), ((int) (((byte) (194)))));
            this.twitch_label.Location = new System.Drawing.Point(3, 11);
            this.twitch_label.Name = "twitch_label";
            this.twitch_label.Size = new System.Drawing.Size(162, 45);
            this.twitch_label.TabIndex = 12;
            this.twitch_label.Text = "TWITCH";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (124)))), ((int) (((byte) (74)))), ((int) (((byte) (194)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.twitch_second_num);
            this.panel4.Location = new System.Drawing.Point(3, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(73, 71);
            this.panel4.TabIndex = 2;
            // 
            // twitch_second_num
            // 
            this.twitch_second_num.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitch_second_num.ForeColor = System.Drawing.Color.White;
            this.twitch_second_num.Location = new System.Drawing.Point(3, 18);
            this.twitch_second_num.Name = "twitch_second_num";
            this.twitch_second_num.Size = new System.Drawing.Size(67, 15);
            this.twitch_second_num.TabIndex = 0;
            this.twitch_second_num.Text = "1.000.000";
            this.twitch_second_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (124)))), ((int) (((byte) (74)))), ((int) (((byte) (194)))));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.Controls.Add(this.twitch_third_num);
            this.panel5.Location = new System.Drawing.Point(175, 129);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(73, 53);
            this.panel5.TabIndex = 3;
            // 
            // twitch_third_num
            // 
            this.twitch_third_num.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitch_third_num.ForeColor = System.Drawing.Color.White;
            this.twitch_third_num.Location = new System.Drawing.Point(3, 12);
            this.twitch_third_num.Name = "twitch_third_num";
            this.twitch_third_num.Size = new System.Drawing.Size(67, 16);
            this.twitch_third_num.TabIndex = 1;
            this.twitch_third_num.Text = "1.000.000";
            this.twitch_third_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (124)))), ((int) (((byte) (74)))), ((int) (((byte) (194)))));
            this.panel6.Controls.Add(this.twitch_first_num);
            this.panel6.Location = new System.Drawing.Point(90, 87);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(73, 95);
            this.panel6.TabIndex = 4;
            // 
            // twitch_first_num
            // 
            this.twitch_first_num.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.twitch_first_num.ForeColor = System.Drawing.Color.White;
            this.twitch_first_num.Location = new System.Drawing.Point(3, 24);
            this.twitch_first_num.Name = "twitch_first_num";
            this.twitch_first_num.Size = new System.Drawing.Size(67, 15);
            this.twitch_first_num.TabIndex = 1;
            this.twitch_first_num.Text = "1.000.000";
            this.twitch_first_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_area_twitterbot
            // 
            this.panel_area_twitterbot.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (21)))), ((int) (((byte) (30)))), ((int) (((byte) (43)))));
            this.panel_area_twitterbot.Controls.Add(this.panel12);
            this.panel_area_twitterbot.Controls.Add(this.twitterbot_tweet);
            this.panel_area_twitterbot.Controls.Add(this.panel_twitterbot);
            this.panel_area_twitterbot.Controls.Add(this.label_twitterbot);
            this.panel_area_twitterbot.Location = new System.Drawing.Point(402, 276);
            this.panel_area_twitterbot.Name = "panel_area_twitterbot";
            this.panel_area_twitterbot.Size = new System.Drawing.Size(248, 182);
            this.panel_area_twitterbot.TabIndex = 23;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.twitterbot_image);
            this.panel12.Location = new System.Drawing.Point(213, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(32, 33);
            this.panel12.TabIndex = 24;
            // 
            // twitterbot_image
            // 
            this.twitterbot_image.Location = new System.Drawing.Point(3, 4);
            this.twitterbot_image.Name = "twitterbot_image";
            this.twitterbot_image.Size = new System.Drawing.Size(26, 26);
            this.twitterbot_image.TabIndex = 0;
            this.twitterbot_image.TabStop = false;
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
            this.twitterbot_tweet.Controls.Add(this.label_tweet_text_twitterbot_1);
            this.twitterbot_tweet.Controls.Add(this.label_quote_amount_bot);
            this.twitterbot_tweet.Location = new System.Drawing.Point(3, 43);
            this.twitterbot_tweet.Name = "twitterbot_tweet";
            this.twitterbot_tweet.Size = new System.Drawing.Size(242, 65);
            this.twitterbot_tweet.TabIndex = 22;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.picturebox_likes_bot);
            this.panel24.Location = new System.Drawing.Point(168, 39);
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
            this.label_likes_amount_bot.Location = new System.Drawing.Point(195, 42);
            this.label_likes_amount_bot.Name = "label_likes_amount_bot";
            this.label_likes_amount_bot.Size = new System.Drawing.Size(33, 18);
            this.label_likes_amount_bot.TabIndex = 27;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.picturebox_retweet_bot);
            this.panel25.Location = new System.Drawing.Point(104, 36);
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
            this.label_retweet_amount_bot.Location = new System.Drawing.Point(131, 41);
            this.label_retweet_amount_bot.Name = "label_retweet_amount_bot";
            this.label_retweet_amount_bot.Size = new System.Drawing.Size(31, 18);
            this.label_retweet_amount_bot.TabIndex = 25;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.picturebox_quote_bot);
            this.panel26.Location = new System.Drawing.Point(41, 39);
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
            this.panel27.Controls.Add(this.picturebox_twitterbot_image_tweet_1);
            this.panel27.Location = new System.Drawing.Point(3, 3);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(32, 33);
            this.panel27.TabIndex = 23;
            // 
            // picturebox_twitterbot_image_tweet_1
            // 
            this.picturebox_twitterbot_image_tweet_1.Location = new System.Drawing.Point(3, 4);
            this.picturebox_twitterbot_image_tweet_1.Name = "picturebox_twitterbot_image_tweet_1";
            this.picturebox_twitterbot_image_tweet_1.Size = new System.Drawing.Size(26, 26);
            this.picturebox_twitterbot_image_tweet_1.TabIndex = 0;
            this.picturebox_twitterbot_image_tweet_1.TabStop = false;
            // 
            // label_tweet_text_twitterbot_1
            // 
            this.label_tweet_text_twitterbot_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_tweet_text_twitterbot_1.ForeColor = System.Drawing.Color.White;
            this.label_tweet_text_twitterbot_1.Location = new System.Drawing.Point(41, 3);
            this.label_tweet_text_twitterbot_1.Name = "label_tweet_text_twitterbot_1";
            this.label_tweet_text_twitterbot_1.Size = new System.Drawing.Size(201, 36);
            this.label_tweet_text_twitterbot_1.TabIndex = 24;
            this.label_tweet_text_twitterbot_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_quote_amount_bot
            // 
            this.label_quote_amount_bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_quote_amount_bot.ForeColor = System.Drawing.Color.White;
            this.label_quote_amount_bot.Location = new System.Drawing.Point(68, 40);
            this.label_quote_amount_bot.Name = "label_quote_amount_bot";
            this.label_quote_amount_bot.Size = new System.Drawing.Size(30, 18);
            this.label_quote_amount_bot.TabIndex = 23;
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
            this.label_twitterbot.ForeColor = System.Drawing.Color.White;
            this.label_twitterbot.Location = new System.Drawing.Point(6, 11);
            this.label_twitterbot.Name = "label_twitterbot";
            this.label_twitterbot.Size = new System.Drawing.Size(154, 26);
            this.label_twitterbot.TabIndex = 22;
            this.label_twitterbot.Text = "TWITTERBOT";
            // 
            // MainStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (51)))), ((int) (((byte) (51)))));
            this.Controls.Add(this.panel_area_twitterbot);
            this.Controls.Add(this.twitter_panel);
            this.Controls.Add(this.yt_panel);
            this.Controls.Add(this.top_creators_label);
            this.Controls.Add(this.twitch_panel);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainStartPage";
            this.Size = new System.Drawing.Size(708, 483);
            this.twitter_panel.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.yt_panel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.twitch_panel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel_area_twitterbot.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.twitterbot_image)).EndInit();
            this.twitterbot_tweet.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_likes_bot)).EndInit();
            this.panel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_retweet_bot)).EndInit();
            this.panel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_quote_bot)).EndInit();
            this.panel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_twitterbot_image_tweet_1)).EndInit();
            this.panel_twitterbot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picturebox_icon_twitterbox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox twitterbot_image;

        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        // private System.Windows.Forms.Label label2;
        // private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_tweet_text_twitterbot_2;
        private System.Windows.Forms.Label label3;
        // private System.Windows.Forms.Label label_tweet_text_twitterbot_2;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label4;
        // private System.Windows.Forms.Panel panel1;
        // private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel1;
        // private System.Windows.Forms.Panel panel2;
        // private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel2;
        // private System.Windows.Forms.Panel panel3;
        // private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        // private System.Windows.Forms.Panel panel7;
        // private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        // private System.Windows.Forms.Panel panel8;
        // private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        // private System.Windows.Forms.PictureBox pictureBox1;
        // private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        // private System.Windows.Forms.PictureBox pictureBox2;
        // private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        // private System.Windows.Forms.PictureBox pictureBox3;
        // private System.Windows.Forms.PictureBox pictureBox3;
        //private System.Windows.Forms.PictureBox picturebox_twitterbot_image_tweet_2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picturebox_twitterbot_image_tweet_2;

        private System.Windows.Forms.Label label_likes_amount_bot;
        private System.Windows.Forms.Label label_quote_amount_bot;
        private System.Windows.Forms.Label label_retweet_amount_bot;
        private System.Windows.Forms.Label label_tweet_text_twitterbot_1;
        private System.Windows.Forms.Label label_twitterbot;
        private System.Windows.Forms.Panel panel_area_twitterbot;
        private System.Windows.Forms.Panel panel_twitterbot;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.PictureBox picturebox_icon_twitterbox;
        private System.Windows.Forms.PictureBox picturebox_likes_bot;
        private System.Windows.Forms.PictureBox picturebox_quote_bot;
        private System.Windows.Forms.PictureBox picturebox_retweet_bot;
        private System.Windows.Forms.PictureBox picturebox_twitterbot_image_tweet_1;
        private System.Windows.Forms.Panel twitterbot_tweet;

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label top_creators_label;
        private System.Windows.Forms.Label twitch_first_name;
        private System.Windows.Forms.Label twitch_first_num;
        private System.Windows.Forms.Label twitch_label;
        private System.Windows.Forms.Panel twitch_panel;
        private System.Windows.Forms.Label twitch_second_name;
        private System.Windows.Forms.Label twitch_second_num;
        private System.Windows.Forms.Label twitch_third_name;
        private System.Windows.Forms.Label twitch_third_num;
        private System.Windows.Forms.Label twitter_first_name;
        private System.Windows.Forms.Label twitter_first_num;
        private System.Windows.Forms.Label twitter_label;
        private System.Windows.Forms.Panel twitter_panel;
        private System.Windows.Forms.Label twitter_second_name;
        private System.Windows.Forms.Label twitter_second_num;
        private System.Windows.Forms.Label twitter_third_name;
        private System.Windows.Forms.Label twitter_third_num;
        private System.Windows.Forms.Label yt_first_name;
        private System.Windows.Forms.Label yt_first_num;
        private System.Windows.Forms.Label yt_label;
        private System.Windows.Forms.Panel yt_panel;
        private System.Windows.Forms.Label yt_second_name;
        private System.Windows.Forms.Label yt_second_num;
        private System.Windows.Forms.Label yt_third_name;
        private System.Windows.Forms.Label yt_third_num;

        #endregion
    }
}