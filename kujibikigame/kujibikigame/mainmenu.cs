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
    public partial class mainmenu : Form
    {
        private int kujipo;

        public mainmenu()
        {
            InitializeComponent();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            kujipo = Properties.Settings.Default.kujipo;
            this.label1.Text = kujipo.ToString();
            this.label1.Text = kujipo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kujibiki form2 = new kujibiki();
            form2.Show();
            this.Hide();
        }

        private void mainmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kujishop form3 = new kujishop();
            form3.Show();
            this.Hide();
        }
    }
}
