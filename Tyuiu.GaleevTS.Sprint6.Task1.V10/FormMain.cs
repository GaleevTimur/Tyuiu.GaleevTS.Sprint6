using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GaleevTS.Sprint6.Task1.V10.Lib;

namespace Tyuiu.GaleevTS.Sprint6.Task1.V10
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
                textBoxResult_GTS.Text = "";
                textBoxResult_GTS.AppendText("+----------+-----------+" + Environment.NewLine);
                textBoxResult_GTS.AppendText("|    X     |   f(x)    |" + Environment.NewLine);
                textBoxResult_GTS.AppendText("+----------+-----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_GTS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_GTS.AppendText("+----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFAQ_GTS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент ИИПб-23-3 Галеев Тимур Серикович", "Сообщение");
        }
    }
}
