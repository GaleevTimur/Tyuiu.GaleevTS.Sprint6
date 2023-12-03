using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GaleevTS.Sprint6.Task2.V23.Lib;

namespace Tyuiu.GaleevTS.Sprint6.Task2.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonCompleteTask_GTS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStart.Text);
                int stopStep = Convert.ToInt32(textBoxInPutStop.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_GTS.Titles.Add("График функции");
                this.chartFunction_GTS.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_GTS.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunctionResult_GTS.Rows.Add(Convert.ToInt32(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_GTS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonFAQ_GTS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент ИИПб-23-3 Галеев Тимур Серикович", "Сообщение");
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonCompleteTask_GTS.BackColor = Color.Red;
        }
            
    }
}
