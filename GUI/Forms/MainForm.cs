﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using GUI.DataFromWeb;
using Owlbear.Dto.Creator;
using Owlbear.Model;

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
        private MainStartPage mainStartPage = new MainStartPage() {Dock = DockStyle.Fill};
        private CreatorDto _activeProfileDto;
        private List<CreatorDto> _creatorsFromService;
        
        public MainForm()
        {
            InitializeComponent();
            LoadResources();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            creatorTemplate_panel.Visible = true;
            allCreatorStatistics_Panel.Visible = true;
            allCreatorStatistics_Panel.Controls.Add(mainStartPage);
            mainStartPage.Show();
            allCreatorStatistics_Panel.BringToFront();
            loadCreatorsAndPanels();
        }

        public async void loadCreatorsAndPanels()
        {
            _creatorsFromService = (await new CreatorWebServiceThing().GetCreators()).OrderBy(c => c.Name).ToList();
            listCreators();
            var match = _creatorsFromService.FirstOrDefault(c => c.Id == _activeProfileDto?.Id);
            if (_activeProfileDto != null)
            {
                loadActiveasd(match ?? _activeProfileDto, false);
            }
            else
            {
                loadActiveasd(_creatorsFromService.FirstOrDefault() ?? new CreatorDto(), false);
            }
        }

        public void listCreators(string searchTerm = "")
        {
            flowLayoutPanel1.Controls.Clear();
            
            foreach (var creator in _creatorsFromService.Where(c => c.Name.Contains(searchTerm)))
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
                btn.Click += (o, args) => loadActiveasd(creator, true);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private async void loadActiveasd(CreatorDto creator, bool forceProfileView)
        {
            var creatorIndex = _creatorsFromService.FindIndex(c => c.Id == creator.Id);
            _creatorsFromService[creatorIndex] = await new CreatorWebServiceThing().GetCreator(creator.Id);
            
            allCreatorStatistics_Panel.Visible = !forceProfileView;
            
            label_main_creator_name.Text = creator.Name;

            if (creator.Twitter?.ImageUrl != null)
            { 
                picturebox_main_creator_image.Load(creator.Twitter?.ImageUrl);
            }
            else if (creator.Twitch?.ProfileImageUrl != null)
            {
                picturebox_main_creator_image.Load(creator.Twitch?.ProfileImageUrl);
            }
            else
            {
                var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                picturebox_main_creator_image.Image = Image.FromFile($@"{path}\Images\unknown_image.png");
            }
            
            var na = "Not available";
            // Hvorfor der skal/kan være ? efter eks. Youtube;
            // https://stackoverflow.com/questions/28352072/what-does-question-mark-and-dot-operator-mean-in-c-sharp-6-0
            label_yt_follower_count.Text = creator.Youtube?.Subscribers != null
                ? creator.Youtube.Subscribers.ToString()
                : na;
            label_twitch_follower_count.Text = creator.Twitch?.Followers != null
                ? creator.Twitch.Followers.ToString()
                : na;
            label_twitter_follower_count.Text = creator.Twitter?.Followers != null
                ? creator.Twitter.Followers.ToString()
                : na;

            loadTweets(creator);
            
            _activeProfileDto = creator;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            button_create_new_creator.FlatAppearance.BorderColor = Color.DimGray;

            var result = new Popup() {StartPosition = FormStartPosition.CenterScreen}.ShowDialog();
            if (result == DialogResult.OK) loadCreatorsAndPanels();
        }

        // private Form _activeForm = new TemplateForm();

        // private void openForm(Form form)
        // {
        //     if (_activeForm == null) return;
        //     _activeForm.Close();
        //     _activeForm = form;
        //     form.TopLevel = false;
        //     form.FormBorderStyle = FormBorderStyle.None;
        //     form.Dock = DockStyle.Fill;
        //     creatorTemplate_panel.Controls.Add(form);
        //     creatorTemplate_panel.Tag = form;
        //     form.BringToFront();
        //     form.Show();
        // }

        private void label13_Click(object sender, EventArgs e)
        {
            if (allCreatorStatistics_Panel.Visible)
            {
                creatorTemplate_panel.Visible = true;
                
                allCreatorStatistics_Panel.Visible = false;
            }
            else
            {
                allCreatorStatistics_Panel.Visible = true;
                allCreatorStatistics_Panel.Controls.Add(mainStartPage);
                mainStartPage.Show();
                allCreatorStatistics_Panel.BringToFront();
            }
        }

        private void picturebox_edit_Click(object sender, EventArgs e)
        {
            var result = new Popup(_activeProfileDto) {StartPosition = FormStartPosition.CenterScreen}.ShowDialog();
            if (result == DialogResult.OK) loadCreatorsAndPanels();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            // Look at dealying this, so a second without a keypress does the search
            // Maybe use Dispacther?
            var searchBox = (TextBox) sender;
            listCreators(searchBox.Text);
        }

        private void loadTweets(CreatorDto creator)
        {
            // Console.WriteLine(creator.Twitter != null);
            // Console.WriteLine(creator.Twitter?.Tweets[0] != null);
            // Console.WriteLine(creator.Twitter.Tweets.First().Text);
            // newest_tweet.Text = creator.Twitter.Tweets.First().Text;
        }
    }
}