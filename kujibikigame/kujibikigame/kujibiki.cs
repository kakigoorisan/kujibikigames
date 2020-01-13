using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kujibikigame
{
    public partial class kujibiki : Form
    {
        private int kujipo;

        public kujibiki()
        {
            InitializeComponent();
        }

        private void kujibiki_Load(object sender, EventArgs e)
        {
            kujipo = Properties.Settings.Default.kujipo;
            this.label1.Text = kujipo.ToString();
        }

        private void kujibiki_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kujibiki_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Properties.Settings.Default.kujipo = int.Parse(this.label1.Text);
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random kekka = new System.Random();
            int kkake = kekka.Next(0, 6);
            if (kkake == 0)
            {
                this.label2.Text = "大当たり！100ポイント！";
                kujipo = kujipo + 100;
                this.label1.Text = (kujipo).ToString();
                kkake = 6;

            } 
            if (kkake == 1)
            {
                this.label2.Text = "中当たり！70ポイント!";
                kujipo = kujipo + 70;
                this.label1.Text = (kujipo).ToString();
                kkake = 6;
            }
            if (kkake == 2)
            {
                this.label2.Text = "小当たり！50ポイント！";
                kujipo = kujipo + 50;
                this.label1.Text = (kujipo).ToString();
                kkake = 6;
            }
            if (kkake == 3)
            {
                this.label2.Text = "当たり！30ポイント！";
                kujipo = kujipo + 30;
                this.label1.Text = (kujipo).ToString();
                kkake = 6;
            }
            if (kkake == 4)
            {
                this.label2.Text = "はずれ...0ポイント...";
                kujipo = kujipo + 0;
                this.label1.Text = (kujipo).ToString();
                kkake = 6;
            }
            if (kkake == 5)
            {
                this.label2.Text = "はずれ...0ポイント...";
                kujipo = kujipo + 0;
                this.label1.Text = (kujipo).ToString();
                kkake = 6;
                
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainmenu formmm = new mainmenu();
            formmm.Show();
            Properties.Settings.Default.kujipo = int.Parse(this.label1.Text);
            Properties.Settings.Default.Save();
            this.Hide();

        }
    }
}
