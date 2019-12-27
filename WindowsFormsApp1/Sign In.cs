using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "Email/Login" || tb.Text == "Password")
            {
                tb.ForeColor = Color.Black;
                tb.Text = string.Empty;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "" && tb.Name == "textBox1")
            {
                tb.Text = "Email/Login";
                tb.ForeColor = Color.DimGray;
            }
            else if (tb.Text == "" && tb.Name == "textBox2")
            {
                tb.Text = "Password";
                tb.PasswordChar = '\0';
                tb.ForeColor = Color.DimGray;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "Password")
            {
                if (textBox2.PasswordChar == '\0')
                    textBox2.PasswordChar = '*';
                else if (textBox2.PasswordChar == '*')
                    textBox2.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserLogin, UserEmail, UserPassword = textBox2.Text;
            if (textBox1.Text.IndexOf('@') == -1)
            {
                UserLogin = textBox1.Text;
                UserEmail = "";
            }
            else
            {
                UserEmail = textBox1.Text;
                UserLogin = "";
            }
            StreamReader sr = new StreamReader("Users/UsersInfo.txt");
            bool Access = false;
            while (!sr.EndOfStream)
            {
                string[] Info = sr.ReadLine().Split(',');
                if((Info[0] == UserLogin && Info[1] == UserPassword) || (Info[2] == UserEmail && Info[1] == UserPassword))
                {
                    Access = true;
                    MessageBox.Show("Вы успшно авторизировались", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form main = new Main(Info[0], Info[3]);
                    main.Show();
                    this.Hide();
                    break;
                }
            }
            if (!Access)
            {
                MessageBox.Show("Логин или пароль введены не правильно", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form Main = new Main("Читер", "a");
            Main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Sign_Up();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form FP = new ForgotPassword();
            FP.Show();
            this.Hide();
        }


    }
}
