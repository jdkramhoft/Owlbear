using System;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Threading;
using System.Windows.Forms;
using GUI.DataFromWeb;
using Owlbear.Dto.Creator;

namespace GUI
{
    public partial class Popup : Form
    {
        private bool CreatingNew;
        private CreatorDto Creator;
        
        public Popup(CreatorDto creator = null)
        {
            CreatingNew = creator == null;
            Creator = creator ?? new CreatorDto();
            
            InitializeComponent();

            // if else ish
            // creator_name_write.Text = Creator.Name;
            //yt handle
            //twitter handle

            var na = "";
            creator_name_write.Text = Creator.Name != null
                ? Creator.Name
                : na;
            yt_name_write.Text = Creator.Youtube?.RemoteId != null
                ? Creator.Youtube.RemoteId
                : na;
            twitter_name_write.Text = Creator.Twitter?.Handle != null
                ? Creator.Twitter.Handle
                : na;
            twitch_write_name.Text = Creator.Twitch?.Handle != null
                ? Creator.Twitch.Handle
                : na;

            // SetButton();
        }
        
        private void button_create_creator_Click(object sender, EventArgs e)
            {
                if (CreatingNew)
                {
                    CreateCreatorDto dto = new CreateCreatorDto();
                    dto.Name = creator_name_write.Text;
                    dto.YoutubeHandle = yt_name_write.Text;
                    dto.TwitterHandle = twitter_name_write.Text;
                    dto.TwitchHandle = twitch_write_name.Text;
                    //youtube
                    //Twitter
                    //Twitch
                    new CreatorWebServiceThing().CreateCreator(dto);
                }
                else if (!CreatingNew)
                {
                    UpdateCreatorDto dto = new UpdateCreatorDto();
                    dto.Name = creator_name_write.Text;
                    dto.YoutubeHandle = yt_name_write.Text;
                    dto.TwitterHandle = twitter_name_write.Text;
                    dto.TwitchHandle = twitch_write_name.Text;
                    //youtube
                    //Twitter
                    //Twitch
                    new CreatorWebServiceThing().UpdateCreator(dto);
                }
                
                DialogResult = DialogResult.OK;
            }
        
        public void SetButton()
        {
            ButtonTemplate buttonTemplate = new ButtonTemplate() {Dock = DockStyle.Fill};
            
            /*
            if (!creatingNew)
            {
                button_create_creator.Visible = false;
                panel_switch_buttons.Controls.Add(buttonTemplate);
                buttonTemplate.Show();
                buttonTemplate.BringToFront();
            }
            */
        }

        
    }
}