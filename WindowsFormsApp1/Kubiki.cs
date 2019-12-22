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
    public partial class Kubiki : Form
    {
        public Kubiki()
        {
            InitializeComponent();
        }
        int Count = 5, UserScore = 0, AIScore = 0;
        public void FillPB(int Cube, PictureBox pb)
        {
            switch(Cube)
            {
                case 1:
                    pb.Image = Image.FromFile("Images/1.png");
                    break;
                case 2:
                    pb.Image = Image.FromFile("Images/2.png");
                    break;
                case 3:
                    pb.Image = Image.FromFile("Images/3.png");
                    break;
                case 4:
                    pb.Image = Image.FromFile("Images/4.png");
                    break;
                case 5:
                    pb.Image = Image.FromFile("Images/5.png");
                    break;
                case 6:
                    pb.Image = Image.FromFile("Images/6.png");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Count = 5;
            label7.Text = "Осталось попыток: 5";
            label3.Text = "Игрок: 0";
            label5.Text = "Компьютер: 0";
            AIScore = 0; UserScore = 0;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pbUser1.Image = null;
            pbUser2.Image = null;
            pbUser3.Image = null;
            pbUser4.Image = null;
            pbUser5.Image = null;
            pbAI1.Image = null;
            pbAI2.Image = null;
            pbAI3.Image = null;
            pbAI4.Image = null;
            pbAI5.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Count > 0)
            {
                Random r = new Random();
                int UserCube = r.Next(1, 7),
                    AICube = r.Next(1, 7);
                UserScore += UserCube;
                AIScore += AICube;
                label3.Text = "Игрок: " + UserScore;
                label5.Text = "Компютер" + AIScore;
                FillPB(UserCube, pictureBox1);
                FillPB(UserCube, groupBox1.Controls["pbUser" + Count] as PictureBox);
                FillPB(AICube, groupBox1.Controls["pbAI" + Count] as PictureBox); 
                FillPB(AICube, pictureBox2);
                Count--;
                label7.Text = "Осталось попыток: " + Count;
                if(Count == 0)
                {
                    if (UserScore > AIScore)
                    {
                        MessageBox.Show("Вы победили\n" + "Ваш счёт: " + UserScore + "\n" + "Счёт компьютера: " + AIScore,
                            "Победа",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (AIScore > UserScore)
                        MessageBox.Show("Вы проиграли\n" + "Ваш счёт: " + UserScore + "\n" + "Счёт компьютера: " + AIScore,
                            "Поражение",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (UserScore == AIScore)
                        MessageBox.Show("Ничья\n" + "Ваш счёт: " + UserScore + "\n" + "Счёт компьютера: " + AIScore,
                            "Ничья",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Количетсво попыток закончилось\n" + 
                    "Хотите начать новую игру?", "Попыток не осталось", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    button2.PerformClick();
                }
            }
        }

        private void Kubiki_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms[1];
            frm.Show();
        }
    }
}
