﻿using System;
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
            
            button_create_creator.Enabled = false;
            
            button_create_creator.Text = CreatingNew ? "Create" : "Update";
            delete_button.Visible = !CreatingNew;

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
        
        private async void button_create_creator_Click(object sender, EventArgs e)
        {
            CreatorDto resultDTO = null;
            
            if (CreatingNew)
            {
                CreateCreatorDto dto = new CreateCreatorDto();
                dto.Name = creator_name_write.Text;
                if (yt_name_write.Text.Length > 0) dto.YoutubeHandle = yt_name_write.Text;
                if (twitter_name_write.Text.Length > 0) dto.TwitterHandle = twitter_name_write.Text;
                if (twitch_write_name.Text.Length > 0) dto.TwitchHandle = twitch_write_name.Text;
                resultDTO = await new CreatorWebServiceThing().CreateCreator(dto);
            }
            else if (!CreatingNew)
            {
                UpdateCreatorDto dto = new UpdateCreatorDto();
                dto.Name = creator_name_write.Text;
                if (yt_name_write.Text.Length > 0) dto.YoutubeHandle = yt_name_write.Text;
                if (twitter_name_write.Text.Length > 0) dto.TwitterHandle = twitter_name_write.Text;
                if (twitch_write_name.Text.Length > 0) dto.TwitchHandle = twitch_write_name.Text;
                resultDTO = await new CreatorWebServiceThing().UpdateCreator(Creator.Id, dto);
            }
            
            if (resultDTO != null) DialogResult = DialogResult.OK;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = await new CreatorWebServiceThing().DeleteCreator(Creator.Id);
            if (result != null) DialogResult = DialogResult.OK;
        }

        private void creator_name_write_TextChanged(object sender, EventArgs e)
        {
            if (creator_name_write.Text.Length > 0)
            {
                button_create_creator.Enabled = true;
            }
        }
    }
}