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
    public partial class KrestikiNoliki : Form
    {
        public KrestikiNoliki()
        {
            InitializeComponent();
        }
        int Hod = 1, EndOfGame = 0, Clicks = 0;
        //128; 255; 128
        //255; 128; 128
        private void KrestikiNoliki_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms[1];
            frm.Show();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                Controls["lb" + i].Text = "";
            }
            Hod = 1;
            EndOfGame = 0;
            Clicks = 0;
            label1.Text = "Ходит игрок 1 (    )";
            label2.Text = "O";
            label2.ForeColor = Color.FromArgb(128, 255, 128);
        }


        private void lb_Click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            if (lb.Text == "" && EndOfGame == 0)
            {
                if (Hod == 1)
                {
                    lb.Text = "O";
                    lb.ForeColor = Color.FromArgb(128, 255, 128);
                    EndOfGame = Proverka("O");
                    Hod = 2;
                    label1.Text = "Ходит игрок 2 (    )";
                    label2.Text = "X";
                    label2.ForeColor = Color.FromArgb(255, 128, 128);
                    if (PVE.Checked && Clicks != 8)
                    {
                        Random r = new Random();
                        while (true)
                        {
                            lb = Controls["lb" + r.Next(1, 10)] as Label;
                            if (lb.Text == "")
                            {
                                lb_Click(lb, e);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    lb.Text = "X";
                    lb.ForeColor = Color.FromArgb(255, 128, 128);
                    EndOfGame = Proverka("X");
                    Hod = 1;
                    label1.Text = "Ходит игрок 1 (    )";
                    label2.Text = "O";
                    label2.ForeColor = Color.FromArgb(128, 255, 128);
                }
                Clicks++;
            }
            if (Clicks == 9 && EndOfGame == 0)
            {
                label1.Text = "Игра окончена";
                label2.Text = "";
                MessageBox.Show("Победителя нет", "Ничья", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(EndOfGame == 1)
            {
                label1.Text = "Игра окончена";
                label2.Text = "";
            }
        }
        public int Proverka(string znak)
        {
            int end = 0;
            if(lb1.Text == znak && lb2.Text == znak && lb3.Text == znak)
            {
                end = 1;
            }
            else if(lb4.Text == znak && lb5.Text == znak && lb6.Text == znak)
            {
                end = 1;
            }
            else if (lb7.Text == znak && lb8.Text == znak && lb9.Text == znak)
            {
                end = 1;
            }
            else if (lb1.Text == znak && lb4.Text == znak && lb7.Text == znak)
            {
                end = 1;
            }
            else if (lb2.Text == znak && lb5.Text == znak && lb8.Text == znak)
            {
                end = 1;
            }
            else if (lb3.Text == znak && lb6.Text == znak && lb9.Text == znak)
            {
                end = 1;
            }
            else if (lb1.Text == znak && lb5.Text == znak && lb9.Text == znak)
            {
                end = 1;
            }
            else if (lb3.Text == znak && lb5.Text == znak && lb7.Text == znak)
            {
                end = 1;
            }
            if (znak == "O" && end == 1) MessageBox.Show("Победил первый игрок", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(znak == "X" && end == 1) MessageBox.Show("Победил второй игрок", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return end;
        }
    }
}
