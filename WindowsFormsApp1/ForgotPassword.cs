using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        int time, da = 0, kod;
        string UserPassword = "";

        private void ForgotPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (da == 0)
            {
                Form frm = Application.OpenForms[0];
                frm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsExist = false;
            using (StreamReader sr = new StreamReader("Users/UsersInfo.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] tmp = sr.ReadLine().Split(',');
                    if (tmp[2] == textBox1.Text)
                    {
                        UserPassword = tmp[1];
                        try
                        {
                            MailAddress from = new MailAddress("SigmaGroup3Reports@mail.ru", "Дима");
                            MailAddress to = new MailAddress(textBox1.Text);
                            MailMessage m = new MailMessage(from, to);
                            m.Subject = "Восстановление пароля";
                            Random r = new Random();
                            kod = r.Next();
                            m.Body = "Код для восстановления пароля:<br>" + "<p style = \"font-size: 20px;\"><b>" + kod + "</b></p>";
                            m.IsBodyHtml = true;
                            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                            smtp.Credentials = new NetworkCredential("SigmaGroup3Reports@mail.ru", "Komsomolskiy");
                            smtp.EnableSsl = true;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Send(m);
                            time = 60;
                            button1.Enabled = false;
                            timer1.Enabled = true;
                            label1.Visible = true;
                        }
                        catch
                        {
                                 MessageBox.Show("Введённый адрес электронной почты не вреен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        IsExist = true;
                        break;
                    }
                }
            }
            if (!IsExist)
            {
                DialogResult result = MessageBox.Show("Данный электронный адрес не суцествует.\n Хотите зарегестрироваться?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if(result == DialogResult.Yes)
                {
                    da = 1;
                    Form SU = new Sign_Up();
                    SU.Show();
                    this.Close();
                }
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text == kod.ToString())
            {
                MessageBox.Show("Ваш пароль\n" + UserPassword, "Пароль", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label1.Text = "Следующий код можно выслать через: " + time + " сек.";
            if(time == 0)
            {
                button1.Enabled = true;
                timer1.Enabled = false;
                label1.Text = "Код можно выслать повторно.";

            }
        }
    }
}
