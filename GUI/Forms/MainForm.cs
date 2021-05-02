using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GUI.DataFromWeb;
using Owlbear.Dto.Creator;

namespace GUI
{
    /*
    public class Creator
    {
        public Button OkayButton { get; set; }
        public string Name { get; set; }
        public string YoutubeFollowing { get; set; }
        public string TwitterFollowing { get; set; }
        public string TwitchFollowing { get; set; }
        public string InstagramFollowing { get; set; }
    }
    */
    
    public partial class MainForm : Form
    {
        // private readonly List<Creator> _creators = new();
        private CreatorDto activeDTO;
        
        public MainForm()
        {
            InitializeComponent();
            LoadResources();
            staySameTemplate.Visible = true;
            test_panel.Visible = false;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var creatorList = await new CreatorWebServiceThing().GetCreators();
            foreach (var creator in creatorList)
            {
                var btn = new Button()
                {
                    Text = creator.Name,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = {BorderColor = Color.FromArgb(41, 41, 41)},
                    Width = flowLayoutPanel1.Width - 25,
                };
                // Anonymous function
                btn.Click += (o, args) =>
                {
                    label_main_creator_name.Text = creator.Name;

                    test_panel.Visible = false;
                    
                    var na = "Not available";
                    label_yt_follower_count.Text = creator.Youtube?.Subscribers != null
                        ? creator.Youtube.Subscribers.ToString()
                        : na;
                    label_twitch_follower_count.Text = creator.Twitch?.Followers != null
                        ? creator.Twitch.Followers.ToString()
                        : na;
                    label_twitter_follower_count.Text = creator.Twitter?.Followers != null
                        ? creator.Twitter.Followers.ToString()
                        : na;

                    activeDTO = creator;
                };
                flowLayoutPanel1.Controls.Add(btn);
            }
            
            /*
            var twitterStats = await Program.TwitterStats();
            var better = await new CreatorWebServiceThing().GetCreator(2);
            // label_twitter_follower_count.Text = better.Twitter.Followers.ToString();
            label_yt_follower_count.Text = better.Youtube.Subscribers.ToString();
            label_twitch_follower_count.Text = better.Twitch.Followers.ToString();
            */
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            button_create_new_creator.FlatAppearance.BorderColor = Color.DimGray;

            new Popup(null) {StartPosition = FormStartPosition.CenterScreen}.ShowDialog();
            
            // var creator = new Creator();
            // _creators.Add(creator);
            // var popup = new Popup(creator);
            // popup.StartPosition = FormStartPosition.CenterScreen;
            // popup.ShowDialog();
            // creator.OkayButton.Width = flowLayoutPanel1.Width - 10;
            // flowLayoutPanel1.Controls.Add(creator.OkayButton);
            // creator.OkayButton.Click += OnOkayClick;
        }

        // private void OnOkayClick(object sender, EventArgs e)
        // {
        //     var caller = sender as Button;
        //     var creator = _creators.Find(c => c.Name == caller?.Text);
        //     label_main_creator_name.Text = creator?.Name;
        //     test_panel.Visible = false;
        //     label_yt_follower_count.Text = creator?.YoutubeFollowing;
        // }
        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private Form _activeForm = new TemplateForm();

        private void openForm(Form form)
        {
            if (_activeForm == null) return;
            _activeForm.Close();
            _activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            staySameTemplate.Controls.Add(form);
            staySameTemplate.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //staySameTemplate.Visible = false;
            MainStartPage mainStartPage = new MainStartPage() {Dock = DockStyle.Fill};
            if (test_panel.Visible)
            {
                staySameTemplate.Visible = true;
                test_panel.Visible = false;
            }
            else
            {
                //staySameTemplate.Visible = false;
                test_panel.Visible = true;
                test_panel.Controls.Add(mainStartPage);
                mainStartPage.Show();
                test_panel.BringToFront();
            }
        }

        private void picturebox_edit_Click(object sender, EventArgs e)
        {

            // var creatorFromDB = new CreatorDto();
            // creatorFromDB.Name = "PewDiePie";
            var popup = new Popup(activeDTO) {StartPosition = FormStartPosition.CenterScreen};
            popup.Activate();
            popup.Show();
            
            /*
            var form2 = new Popup {StartPosition = FormStartPosition.CenterScreen};
            form2.Activate();
            form2.Show();
            */
        }

    }
}