using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Sign_Up_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            Form form1 = Application.OpenForms[0];
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsFounded = true;
            string UserLogin = textBox1.Text, UserPassword = textBox2.Text, UserEmail = textBox3.Text;
            StreamReader sr = new StreamReader("Users/UsersInfo.txt");
            while (!sr.EndOfStream)
            {
                string[] info = sr.ReadLine().Split(',');
                if (info[0] == UserLogin || info[2] == UserEmail)
                {
                    IsFounded = false;
                    MessageBox.Show("Логин или Email уже существует", "Ошибка регитрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            sr.Close();
            if (IsFounded)
            {
                StreamWriter swInfo = new StreamWriter("Users/UsersInfo.txt", true);
                swInfo.WriteLine(UserLogin + "," + UserPassword + "," + UserEmail + ",u");
                swInfo.Close();
                MessageBox.Show("Регистрация прошла успешно", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(1000);
                this.Close();
            }
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "Login" || tb.Text == "Password" || tb.Text == "Email")
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
                tb.Text = "Login";
                tb.ForeColor = Color.DimGray;
            }
            else if (tb.Text == "" && tb.Name == "textBox2")
            {
                tb.Text = "Password";
                tb.PasswordChar = '\0';
                tb.ForeColor = Color.DimGray;
            }
            else if(tb.Text == "" && tb.Name == "textBox3")
            {
                tb.Text = "Email";
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

    }
}
