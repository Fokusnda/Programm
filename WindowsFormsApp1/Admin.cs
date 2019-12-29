using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms[1];
            frm.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("Users/UsersInfo.txt"))
            {
                while (!sr.EndOfStream)
                {
                    sr.ReadLine();
                    dataGridView1.Rows.Add();
                }
            }
            using (StreamReader sr = new StreamReader("Users/UsersInfo.txt"))
            {
                int CurrentRow = 0;
                while (!sr.EndOfStream)
                {
                    string[] tmp = sr.ReadLine().Split(',');
                    for (int i = 0; i < 5; i++)
                    {
                        if (i < 4)
                            dataGridView1[i, CurrentRow].Value = tmp[i];
                        else
                        {
                            if (tmp[4] == "b")
                                dataGridView1[i, CurrentRow].Value = true;
                            else
                                dataGridView1[i, CurrentRow].Value = false;
                        }
                    }
                    CurrentRow++;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ToFile = "";
            int RowsCount = dataGridView1.Rows.Count;
            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(j != 4)
                        ToFile += dataGridView1[j, i].Value + ",";
                    else
                    {
                        ToFile += dataGridView1[j, i].Value + "\n";
                    }
                }
            }
            dataGridView1.Refresh();
            MessageBox.Show("Test");
            using (StreamWriter sw = new StreamWriter("Users/UsersInfo.txt", false))
            {
                string[] tmp = ToFile.Split('\n');
                for (int i = 0; i < tmp.Length - 1; i++)
                {
                    sw.WriteLine(i);
                }
            }
        }
    }
}
