using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class wukong_fix01 : Form
    {
        // 跨窗口传值
        public class app
        {
            public static int game_style;
        }



        public wukong_fix01()
        {
            InitializeComponent();
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.FunkyStars);
            simpleSound.Play();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string target = "https://space.bilibili.com/183450641";
            System.Diagnostics.Process.Start(target);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //string target="https://ys.mihoyo.com";
            //System.Diagnostics.Process.Start(target);
            timer1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            new Form2(1).Show();
            //string target = "https://ys.mihoyo.com/cloud/#/";
            //System.Diagnostics.Process.Start(target);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            new Form2(2).Show();
            //string target = "https://sr.mihoyo.com/cloud/";
            //System.Diagnostics.Process.Start(target);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            new Form2(3).Show();
            //string target = "https://autopatchcn.juequling.com/package_download/op/client_app/download/20240618183950_ehxltROsR67s5q43/gwpc/ZenlessZoneZero_setup_202406181742.exe";
            //System.Diagnostics.Process.Start(target);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            new Form2(4).Show();
            //string target = "https://mirrors-package-mc.aki-game.com/client/download/20240530102452_oJTAhgbS8ZyqpyQK3J/WutheringWaves-official-setup-1.5.3.0.exe";
            //System.Diagnostics.Process.Start(target);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            new Form2(5).Show();
            //string target = "https://www.sanguosha.com/";
            //System.Diagnostics.Process.Start(target);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            new Form2(6).Show();
            //string target = "https://warthunder.com/zh/game/about/";
            //System.Diagnostics.Process.Start(target);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
