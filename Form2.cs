using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public int game_valeue;
        public Form2(int game_valeue )
        {
            InitializeComponent();
            this.game_valeue = game_valeue;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            switch (game_valeue)
            {
                case 1:
                    label2.Text = "原神";
                    break;
                case 2:
                    label2.Text = "崩坏：星穹铁道";
                    break;
                case 3:
                    label2.Text = "绝区零";
                    break;
                case 4:
                    label2.Text = "鸣潮";
                    break;
                case 5:
                    label2.Text = "三国杀";
                    break;
                case 6:
                    label2.Text = "战争雷霆";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (game_valeue)
            {
                case 1:
                    string target1 = "https://ys.mihoyo.com/cloud/#/";
                    System.Diagnostics.Process.Start(target1);
                    break;
                case 2:
                    string target2 = "https://sr.mihoyo.com/cloud/";
                    System.Diagnostics.Process.Start(target2);
                    break;
                case 3:
                    string target3 = "https://autopatchcn.juequling.com/package_download/op/client_app/download/20240618183950_ehxltROsR67s5q43/gwpc/ZenlessZoneZero_setup_202406181742.exe";
                    System.Diagnostics.Process.Start(target3);
                    break;
                case 4:
                    string target4 = "https://mirrors-package-mc.aki-game.com/client/download/20240530102452_oJTAhgbS8ZyqpyQK3J/WutheringWaves-official-setup-1.5.3.0.exe";
                    System.Diagnostics.Process.Start(target4);
                    break;
                case 5:
                    string target5 = "https://www.sanguosha.com/";
                    System.Diagnostics.Process.Start(target5);
                    break;
                case 6:
                    string target6 = "https://warthunder.com/zh/game/about/";
                    System.Diagnostics.Process.Start(target6);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string target7 = "steam://uninstall/2358720";
            System.Diagnostics.Process.Start(target7);
        }
    }
}
