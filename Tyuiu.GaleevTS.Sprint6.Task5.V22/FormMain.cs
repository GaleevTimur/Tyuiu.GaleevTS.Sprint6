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
using Tyuiu.GaleevTS.Sprint6.Task5.V22.Lib;

namespace Tyuiu.GaleevTS.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\timur_8n182p8\source\repos\Tyuiu.GaleevTS.Sprint6\Tyuiu.GaleevTS.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";
        private void buttonDone_GTS_Click(object sender, EventArgs e)
        {
            dataGridViewInPutData_GTS.ColumnCount = 2;
            dataGridViewInPutData_GTS.Columns[0].Width = 50;
            dataGridViewInPutData_GTS.Columns[1].Width = 100;

            this.chartData_GTS.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartData_GTS.ChartAreas[0].AxisX.Title = "Ось Y";
            chartData_GTS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewInPutData_GTS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartData_GTS.Series[0].Points.AddXY(i, numsMass[i]);

            }
        }

        private void buttonToCheckInPutData_GTS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();

        }

        private void button_FAQ_GTS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент ИИПб-23-3 Галеев Тимур Серикович", "Сообщение");
        }
    }
}
