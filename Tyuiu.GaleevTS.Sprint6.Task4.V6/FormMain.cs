using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GaleevTS.Sprint6.Task4.V6.Lib;
using System.IO;

namespace Tyuiu.GaleevTS.Sprint6.Task4.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_GTS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInPutStart_GTS.Text);
                int stopStep = Convert.ToInt32(textBoxInPutStop_GTS.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] mtrx;
                mtrx = new double[len];

                mtrx = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_GTS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_GTS.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_GTS.Text = "";
                chartFunction_GTS.Series[0].Points.Clear();
                for (int i = 0; i<= len - 1; i++)
                {
                    this.chartFunction_GTS.Series[0].Points.AddXY(startStep, mtrx[i]);
                    textBoxResult_GTS.AppendText(mtrx[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_FAQ_GTS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент ИИПб-23-3 Галеев Тимур Серикович", "Сообщение");
        }

        private void buttonSave_GTS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V6.txt";
                File.WriteAllText(path, textBoxResult_GTS.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
