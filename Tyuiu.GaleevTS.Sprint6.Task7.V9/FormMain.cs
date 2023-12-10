using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GaleevTS.Sprint6.Task7.V9.Lib;
using System.IO;

namespace Tyuiu.GaleevTS.Sprint6.Task7.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static string openFilePath;
        static int rows;
        static int colums;
        DataService ds = new DataService();
        public int[,] LoadFromFileData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_m = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_m[j]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_GTS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GTS.ShowDialog();
            openFilePath = openFileDialogTask_GTS.FileName;

            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_GTS.ColumnCount = colums;
            dataGridViewInPut_GTS.RowCount = rows;
            dataGridViewOutPut_GTS.ColumnCount = colums;
            dataGridViewOutPut_GTS.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                dataGridViewInPut_GTS.Columns[i].Width = 50;
                dataGridViewOutPut_GTS.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewInPut_GTS.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_GTS.Enabled = true;
        }

        private void buttonDone_GTS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewOutPut_GTS.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave_GTS.Enabled = true;
        }

        private void buttonSave_GTS_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_GTS.FileName = "OutPutFileTask7V20.csv";
            saveFileDialogMatrix_GTS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_GTS.ShowDialog();

            string path = saveFileDialogMatrix_GTS.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_GTS.RowCount;
            int colums = dataGridViewOutPut_GTS.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + dataGridViewOutPut_GTS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_GTS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_GTS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_GTS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_GTS.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_GTS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_GTS.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_GTS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_GTS.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_GTS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_GTS.ToolTipTitle = "Справка";
        }
    }
}
