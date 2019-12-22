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
    public partial class Main : Form
    {
        public Main(string UserName, string Priveleges)
        {
            InitializeComponent();
            this.name = UserName;
            this.priveleges = Priveleges;
        }
        string name, priveleges;

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form kosti = new Kubiki();
            kosti.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form KN = new KrestikiNoliki();
            KN.Show();
            this.Hide();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            Form admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (priveleges == "a")
                admin.Visible = true;
            label1.Text = "Приветствую, " + name;
        }
    }
}
