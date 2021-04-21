using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Visible = true;
            ProgressBar(null, null);
        }

        private void ProgressBar(object sender, ProgressChangedEventArgs e)
        {
            Thread.Sleep(50);
            progressBar1.Value = e.ProgressPercentage;
            if (progressBar1.Value != 100) return;
            var mainForm = new MainForm();
            mainForm.Activate();
            mainForm.Show();
        }
    }
}