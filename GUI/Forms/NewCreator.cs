using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class NewCreator : Form
    {
        
        private readonly Creator _creator;
        
        public NewCreator(Creator creator)
        {
            _creator = creator;
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            // _flowLayoutPanel.Controls.Add(b);
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.BackColor = Color.Transparent;
            b.ForeColor = Color.White;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderColor = Color.FromArgb(41, 41, 41);
            // b.Width = _flowLayoutPanel.Width - 25;
            b.Text = textBox1.Text;
            _creator.Name = textBox1.Text;
            _creator.OkayButton = b;
            _creator.YoutubeFollowing = DataSend();
            
            // dataSend();

            // b.Click += new System.EventHandler(this.bButton_Click);

            DialogResult = DialogResult.OK;
        }

        private static string DataSend()
        {
            var rnd = new Random();
            var randomNumber = rnd.Next(100000, 2000000);
            var convert = Convert.ToString(randomNumber);

            // _youtubeLabel.Text = convert;

            return convert;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}