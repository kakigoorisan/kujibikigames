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
    public partial class kujishop : Form
    {
        private int kujipo;
        private int kakuappu;
        private int appukaku;

        public kujishop()
        {
            InitializeComponent();
        }

        private void kujishop_Load(object sender, EventArgs e)
        {
            kakuappu = Properties.Settings.Default.kakuappu;
            kujipo = Properties.Settings.Default.kujipo;
            appukaku = Properties.Settings.Default.appukaku;
            this.label6.Text = appukaku.ToString();
            this.label1.Text = kujipo.ToString();
            this.label5.Text = kakuappu.ToString();
        }

        private void kujishop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.kakuappu = int.Parse(this.label5.Text);
            Properties.Settings.Default.kujipo = int.Parse(this.label1.Text);
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kujipo >= 100)
            {


                kujipo = kujipo - 100;
                kakuappu = kakuappu + 1;
                this.label5.Text = kakuappu.ToString();
                this.label1.Text = kujipo.ToString();
                Properties.Settings.Default.kakuappu = int.Parse(this.label5.Text);
                Properties.Settings.Default.kujipo = int.Parse(this.label1.Text);
                Properties.Settings.Default.Save();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainmenu form1 = new mainmenu();
            form1.Show();
            Properties.Settings.Default.kakuappu = int.Parse(this.label5.Text);
            Properties.Settings.Default.kujipo = int.Parse(this.label1.Text);
            Properties.Settings.Default.Save();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kujipo >= 2000)
            {
                kujipo = kujipo - 2000;
                appukaku = appukaku + 1;
                this.label1.Text = kujipo.ToString();
                this.label6.Text = appukaku.ToString();
                Properties.Settings.Default.kujipo = int.Parse(this.label1.Text);
                Properties.Settings.Default.appukaku = int.Parse(this.label6.Text);
                Properties.Settings.Default.Save();
            }
        }
    }
}
