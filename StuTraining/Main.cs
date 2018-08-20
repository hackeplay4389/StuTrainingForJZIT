using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StuTraining
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_exti_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Process_Click(object sender, EventArgs e)
        {
            this.Main_Panle.Controls.Clear();
            Liver liver = new Liver();
            liver.TopLevel = false;
            liver.Dock = DockStyle.Fill;
            this.Main_Panle.Controls.Add(liver);
            liver.Show();
        }

        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        private bool isPlay = true;
        private void Main_Load(object sender, EventArgs e)
        {
            music.SoundLocation = System.IO.Directory.GetCurrentDirectory() + "\\Skin\\music.wav";
            music.PlayLooping();
        }

        private void btn_music_Click(object sender, EventArgs e)
        {
            if (isPlay)
            {
                music.Stop();
                isPlay = !isPlay;
                btn_music.Text = "播放音乐";
            }
            else
            {
                music.PlayLooping();
                isPlay = !isPlay;
                btn_music.Text = "暂停音乐";
            }
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            this.Main_Panle.Controls.Clear();
            About about = new About();
            about.TopLevel = false;
            about.Dock = DockStyle.Fill;
            this.Main_Panle.Controls.Add(about);
            about.Show();
        }

        private void btn_Jigsaw_Click(object sender, EventArgs e)
        {
            this.Main_Panle.Controls.Clear();
            Nine nine = new Nine();
            nine.TopLevel = false;
            nine.Dock = DockStyle.Fill;
            this.Main_Panle.Controls.Add(nine);
            nine.Show();
        }

        
    }
}
