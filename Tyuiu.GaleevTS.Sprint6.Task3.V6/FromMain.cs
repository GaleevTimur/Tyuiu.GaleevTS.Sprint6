using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GaleevTS.Sprint6.Task3.V6.Lib;

namespace Tyuiu.GaleevTS.Sprint6.Task3.V6
{
    public partial class FromMain : Form
    {
        public FromMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { {-2, -10, -8, 11, 1 },
                                      {-15, -9, -4, -15, 18},
                                      {-15, 12, 7, 6, 9},
                                      {-14, -10, 10, 18, -5},
                                      {-1, 7, -19, -19, -4 } };
        private void FormMain_Load(object sender,EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            dataGridViewInPutArray_GTS.ColumnCount = columns;
            dataGridViewInPutArray_GTS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutArray_GTS.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns;j++)
                {
                    dataGridViewInPutArray_GTS.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }

        private void buttonDone_GTS_Click(object sender, EventArgs e)
        {
            int[,] matrix = ds.Calculate(mtrx);
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            dataGridViewOutPutArray_GTS.ColumnCount = columns;
            dataGridViewOutPutArray_GTS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutPutArray_GTS.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPutArray_GTS.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            } 

        }
        private void buttonFAQ_GTS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент ИИПб-23-3 Галеев Тимур Серикович", "Сообщение");
        }

        private void buttonFAQ_GTS_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент ИИПб-23-3 Галеев Тимур Серикович", "Сообщение");
        }
    }
       
}
