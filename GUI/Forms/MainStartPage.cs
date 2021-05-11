using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GUI.DataFromWeb;
using Owlbear.Dto.Creator;

namespace GUI
{
    public partial class MainStartPage : UserControl
    {
        private CreatorDto _activeProfileDto;
        private List<CreatorDto> _creatorsFromService;
        
        public MainStartPage()
        {
            InitializeComponent();
            LoadResources();
        }

        private async void loadData(CreatorDto creator, bool forceProfileView)
        {
            var creatorIndex = _creatorsFromService.FindIndex(c => c.Id == creator.Id);
            _creatorsFromService[creatorIndex] = await new CreatorWebServiceThing().GetCreator(creator.Id);
                
            if (creator.Twitter?.ImageUrl != null)
            {
                
            }
            else
            {
                label_quote_amount_bot.Text = "0";
                label_retweet_amount_bot.Text = "0";
                label_likes_amount_bot.Text = "0";
                
                quote_text.Text = "0";
                retweet_text.Text = "0";
                likes_text.Text = "0";

                label_tweet_text_twitterbot_1.Text = "No Tweet available";
                tweet_2.Text = "No Tweet available";
            }
    
        }
    }
}