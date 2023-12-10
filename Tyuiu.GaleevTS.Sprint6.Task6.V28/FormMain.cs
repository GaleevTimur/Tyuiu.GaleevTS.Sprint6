using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GaleevTS.Sprint6.Task6.V28.Lib;
using System.IO;

namespace Tyuiu.GaleevTS.Sprint6.Task6.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpenFile_GTS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GTS.ShowDialog();
            openFilePath = openFileDialogTask_GTS.FileName;
            textBoxInPut_GTS.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_GTS.Text = groupBoxInPut_GTS.Text + " " + openFileDialogTask_GTS.FileName;
            buttonDone_GTS.Enabled = true;
        }

        private void buttonDone_GTS_Click(object sender, EventArgs e)
        {
            textBoxOutPut_GTS.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
