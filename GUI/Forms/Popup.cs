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
        
        public Popup(CreatorDto creator)
        {
            CreatingNew = creator == null;
            Creator = creator ?? new CreatorDto();
            
            InitializeComponent();

            creator_name_write.Text = Creator.Name;

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
                    //youtube
                    //Twitter
                    //Twitch
                    new CreatorWebServiceThing().UpdateCreator(dto);
                }
                
                throw new System.NotImplementedException();
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