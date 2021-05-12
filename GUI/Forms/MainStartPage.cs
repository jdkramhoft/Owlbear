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
        private readonly Label[] _youtubeNames;
        private readonly Label[] _youtubeNumbers;
        private readonly Label[] _twitterNames;
        private readonly Label[] _twitterNumbers;
        private readonly Label[] _twitchNames;
        private readonly Label[] _twitchNumbers;
        
        public MainStartPage()
        {
            InitializeComponent();
            LoadResources();
            _youtubeNames = new[] {yt_first_name, yt_second_name, yt_third_name};
            _youtubeNumbers = new[] {yt_first_num, yt_second_num, yt_third_num};
            _twitterNames = new[] {twitter_first_name, twitter_second_name, twitter_third_name};
            _twitterNumbers = new[] {twitter_first_num, twitter_second_num, twitter_third_num};
            _twitchNames = new[] {twitch_first_name, twitch_second_name, twitch_third_name};
            _twitchNumbers = new[] {twitch_first_num, twitch_second_num, twitch_third_num};
        }

        public async void LoadData(List<CreatorDto> creatorDtos)
        {
            List<CreatorDto> creators = creatorDtos;
            var twitterCreators = SortedTwitterCreators(creators);
            var youtubeCreators = SortedYoutubeCreators(creators);
            var twitchCreators = SortedTwitchCreators(creators);
            for (int i = 0; i < _youtubeNames.Length; i++)
            {
                bool noMoreYoutubeCreators = youtubeCreators.Count <= i;
                if (noMoreYoutubeCreators)
                {
                    _youtubeNames[i].Text = "N/A";
                    _youtubeNumbers[i].Text = "N/A";
                }
                else
                {
                    _youtubeNames[i].Text = youtubeCreators[i].Name;
                    _youtubeNumbers[i].Text = youtubeCreators[i].Youtube.Subscribers.ToString();
                }
            }
            for (int i = 0; i < _twitterNames.Length; i++)
            {
                bool noMoreTwitterCreators = twitterCreators.Count <= i;
                if (noMoreTwitterCreators)
                {
                    _twitterNames[i].Text = "N/A";
                    _twitterNumbers[i].Text = "N/A";
                }
                else
                {
                    _twitterNames[i].Text = twitterCreators[i].Name;
                    _twitterNumbers[i].Text = twitterCreators[i].Twitter.Followers.ToString();
                }
            }
            for (int i = 0; i < _twitchNames.Length; i++)
            {
                bool noMoreTwitchCreators = twitchCreators.Count <= i;
                if (noMoreTwitchCreators)
                {
                    _twitchNames[i].Text = "N/A";
                    _twitchNumbers[i].Text = "N/A";
                }
                else
                {
                    _twitchNames[i].Text = twitchCreators[i].Name;
                    _twitchNumbers[i].Text = twitchCreators[i].Twitch.Followers.ToString();
                }
            }
            ShowMilestoneTweets();
        }

        private List<CreatorDto> SortedTwitchCreators(List<CreatorDto> creators)
        {
            List<CreatorDto> creatorsWithTwitch = new List<CreatorDto>();
            foreach (var creator in creators)
            {
                if(creator.Twitch != null)
                    creatorsWithTwitch.Add(creator);
            }
            creatorsWithTwitch.Sort((c1, c2) => c1.Twitch.Followers.CompareTo(c2.Twitch.Followers));
            return creatorsWithTwitch;
        }

        private List<CreatorDto> SortedYoutubeCreators(List<CreatorDto> creators)
        {
            List<CreatorDto> creatorsWithYoutube = new List<CreatorDto>();
            foreach (var creator in creators)
            {
                if(creator.Youtube != null)
                    creatorsWithYoutube.Add(creator);
            }
            creatorsWithYoutube.Sort((c1, c2) => c1.Youtube.Subscribers.CompareTo(c2.Youtube.Subscribers));
            return creatorsWithYoutube;
        }

        private List<CreatorDto> SortedTwitterCreators(List<CreatorDto> creators)
        {
            List<CreatorDto> creatorsWithTwitter = new List<CreatorDto>();
            foreach (var creator in creators)
            {
                if(creator.Twitter != null)
                    creatorsWithTwitter.Add(creator);
            }
            creatorsWithTwitter.Sort((c1, c2) => c1.Twitter.Followers.CompareTo(c2.Twitter.Followers));
            return creatorsWithTwitter;
        }

        private void ShowMilestoneTweets()
        {
            // TODO: Read from API
            label_quote_amount_bot.Text = "0";
            label_retweet_amount_bot.Text = "0";
            label_likes_amount_bot.Text = "0";
                
            quote_text.Text = "1000";
            retweet_text.Text = "0";
            likes_text.Text = "0";

            label_tweet_text_twitterbot_1.Text = "No Tweet available";
            tweet_2.Text = "No Tweet available";
        }
    }
}