using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int[,] mass;
        static int[] deletedRows,deletedColomns;
        static int length;
        private void button1_Click(object sender, EventArgs e)
        {
            
            bool ok;
            ok = int.TryParse(textBox1.Text,out length);
            if (ok)
            {
                mass = new int[length, length];
                deletedColomns = new int[length];
                deletedRows = new int[length];
                for (int i = 0; i < dataGridView1.Rows.Count; )
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
                for (int i = 0; i < dataGridView1.Columns.Count;)
                {
                    dataGridView1.Columns.RemoveAt(0);
                }
                for (int i = 0; i < length; i++)
                {
                    dataGridView1.Columns.Add((i + 1).ToString(), (i + 1).ToString());
                    dataGridView1.Rows.Add();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool kk = true;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    bool ok;
                    ok = int.TryParse(textBox1.Text, out mass[i,j]);
                    if (!ok) { kk = false; break; }
                }
            }
            if (kk)
            {
                
            }
            else
            {
                MessageBox.Show("Неверно введены данные в таблицу");
            }
        }
        void toZero(ref int[] rows, ref int[] columns)
        {
            for (int i = 0; i < length; ++i)
            {
                int min = mass[i, 0];
                for (int j = 1; j < length; ++j)
                {
                    if(j!=i&& mass[i, j]<min) min = mass[i, j];
                    if (min == 0) break;
                }
                if (min != 0)
                {
                    for (int j = 0; j < length; j++)
                    {
                        mass[i, j] -= min;
                    }
                    rows[i] = min;
                }
            }
            for (int i = 0; i < length; i++)
            {
                int min = mass[0, i];
                for (int j = 1; j < length; ++j)
                {
                    if (j != i && mass[j, i] < min) min = mass[j, i];
                    if (min == 0) break;
                }
                if (min != 0)
                {
                    for (int j = 0; j < length; j++)
                    {
                        mass[j, i] -= min;
                    }
                    columns[i] = min;
                }
            }
        }
    }
}
