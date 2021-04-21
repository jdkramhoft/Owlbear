using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GUI.DataFromWeb;

namespace GUI
{
    
    public class Creator
    {
        public Button OkayButton { get; set; }
        public string Name { get; set; }
        public string YoutubeFollowing { get; set; }
        public string TwitterFollowing { get; set; }
        public string TwitchFollowing { get; set; }
        public string InstagramFollowing { get; set; }
    }
    
    
    public partial class MainForm : Form
    {
        private readonly List<Creator> _creators = new();
        
        public MainForm()
        {
            InitializeComponent();
            LoadResources();
            staySameTemplate.Visible = true;
            test_panel.Visible = false;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var twitterStats = await Program.TwitterStats();
            var better = await new CreatorWebServiceThing().GetCreator(1);
            label11.Text = better.Twitter.Followers.ToString();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderColor = Color.DimGray;

            var creator = new Creator();
            _creators.Add(creator);
            var newCreator = new NewCreator(creator);
            newCreator.StartPosition = FormStartPosition.CenterScreen;
            newCreator.ShowDialog();
            creator.OkayButton.Width = flowLayoutPanel1.Width - 25;
            flowLayoutPanel1.Controls.Add(creator.OkayButton);
            creator.OkayButton.Click += OnOkayClick;
        }

        private void OnOkayClick(object sender, EventArgs e)
        {
            var caller = sender as Button;
            var creator = _creators.Find(c => c.Name == caller?.Text);
            label1.Text = creator?.Name;
            test_panel.Visible = false;
            youtubeLabel.Text = creator?.YoutubeFollowing;
        }
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
            var form2 = new Popup {StartPosition = FormStartPosition.CenterScreen};
            form2.Activate();
            form2.Show();
        }

    }
}