using System;
using System.Windows.Forms;

namespace lr2_niehin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PrintMatrix(int[,] a, int m, DataGridView dgv)
        {
            dgv.RowCount = m;
            dgv.ColumnCount = m;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dgv.Rows[i].Cells[j].Value = a[i, j];
                }
            }
            for (int j = 0; j < m; j++)
            {
                dgv.Columns[j].Width = 50;
            }
        }

        private void ProcessMatrix(int[,] a, int m, out int minVal, out int maxVal, out int minCol, out int maxCol)
        {
            minVal = a[0, 0];
            maxVal = a[0, 0];
            minCol = 0;
            maxCol = 0;

            for (int i = 0; i < m; i++)
            {
                if (a[i, i] < minVal)
                {
                    minVal = a[i, i];
                    minCol = i;
                }
                if (a[i, i] > maxVal)
                {
                    maxVal = a[i, i];
                    maxCol = i;
                }
            }

            for (int i = 0; i < m; i++)
            {
                int temp = a[i, minCol];
                a[i, minCol] = a[i, maxCol];
                a[i, maxCol] = temp;
            }
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            try
            {
                int m = Int32.Parse(txtn.Text);
                int[,] a = new int[m, m];
                Random rnd = new Random();

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        a[i, j] = rnd.Next(-50, 51);
                    }
                }

                int minV, maxV, minC, maxC;
                ProcessMatrix(a, m, out minV, out maxV, out minC, out maxC);

                PrintMatrix(a, m, dgvMass);

                txtRez.Text = "Мін. на діагоналі: " + minV + " (стовп. " + (minC + 1) + ")" + Environment.NewLine +
                              "Макс. на діагоналі: " + maxV + " (стовп. " + (maxC + 1) + ")" + Environment.NewLine +
                              "Стовпці поміняно місцями!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtn.Text = "";
            txtRez.Text = "";
            dgvMass.Rows.Clear();
            dgvMass.Columns.Clear();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}