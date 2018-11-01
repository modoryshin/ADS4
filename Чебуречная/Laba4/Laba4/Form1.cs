using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<List<int>> mas = new List<List<int>>();
            int[][] mas2 = new int[Mas.Rows.Count-1][];
            int c = 0;
            foreach (DataGridViewRow row in Mas.Rows)
            {
                if(c!= Mas.Rows.Count - 1)
                {
                    mas2[c] = new int[3];
                    mas.Add(new List<int>());
                    mas[c].Add(Convert.ToInt32(row.Cells[0].Value));
                    mas[c].Add(Convert.ToInt32(row.Cells[1].Value));
                    mas[c].Add(c++);
                }
            }
            c = 0;
            int min,right=mas2.Length-1;
            for (int i = 0; i < mas.Count; )
            {
                int s = 0,g=0;
                min = mas[i][0];
                if (mas[i][1] < min) { min = mas[i][1];g = 1; }
                for (int j = 1; j < mas.Count; j++)
                {
                    if (mas[j][0] < min) { min = mas[j][0]; s = j; g = 0; }
                    if (mas[j][1] < min) { min = mas[j][1]; s = j; g = 1; }
                }
                if (g == 0)
                {
                    mas2[c][0] = mas[s][0];
                    mas2[c][1] = mas[s][1];
                    mas2[c++][2] = mas[s][2];
                }
                else
                {
                    mas2[right][0] = mas[s][0];
                    mas2[right][1] = mas[s][1];
                    mas2[right--][2] = mas[s][2];
                }
                min = mas[i][1];
                mas.RemoveAt(s);
            }
            MessageBox.Show("Kek");
        }
    }
}
