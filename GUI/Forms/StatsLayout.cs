using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class StatsLayout : UserControl
    {
        private List<Creator> _creators = new List<Creator>();
        
        public class Creator
        {
            public Button Button { get; set; }
            public string Name { get; set; }
            public string YoutubeFollowing { get; set; }
            public string TwitterFollowing { get; set; }
            public string TwitchFollowing { get; set; }
            public string InstagramFollowing { get; set; }
        }
        
        public StatsLayout()
        {
            InitializeComponent();
        }
        
        private async void statsLayout_Load(object sender, EventArgs e)
        {
            var twitterStats = await Program.TwitterStats();
            label11.Text = twitterStats.ToString();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Popup();
            form2.Activate();
            form2.Show();
        }
    }
}