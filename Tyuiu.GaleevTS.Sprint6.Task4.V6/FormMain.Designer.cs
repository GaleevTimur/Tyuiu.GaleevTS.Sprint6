
namespace Tyuiu.GaleevTS.Sprint6.Task4.V6
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.textBoxCondition_GTS = new System.Windows.Forms.TextBox();
            this.labelStop_GTS = new System.Windows.Forms.Label();
            this.labelStart_GTS = new System.Windows.Forms.Label();
            this.textBoxInPutStop_GTS = new System.Windows.Forms.TextBox();
            this.textBoxInPutStart_GTS = new System.Windows.Forms.TextBox();
            this.buttonDone_GTS = new System.Windows.Forms.Button();
            this.buttonSave_GTS = new System.Windows.Forms.Button();
            this.button_FAQ_GTS = new System.Windows.Forms.Button();
            this.chartFunction_GTS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelInfo_GTS = new System.Windows.Forms.Panel();
            this.groupBoxInfo_GTS = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_GTS = new System.Windows.Forms.GroupBox();
            this.panelOutPut_GTS = new System.Windows.Forms.Panel();
            this.panelGraph_GTS = new System.Windows.Forms.Panel();
            this.textBoxResult_GTS = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GTS)).BeginInit();
            this.panelInfo_GTS.SuspendLayout();
            this.groupBoxInfo_GTS.SuspendLayout();
            this.groupBoxInPut_GTS.SuspendLayout();
            this.panelOutPut_GTS.SuspendLayout();
            this.panelGraph_GTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCondition_GTS
            // 
            this.textBoxCondition_GTS.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxCondition_GTS.Location = new System.Drawing.Point(3, 16);
            this.textBoxCondition_GTS.Multiline = true;
            this.textBoxCondition_GTS.Name = "textBoxCondition_GTS";
            this.textBoxCondition_GTS.ReadOnly = true;
            this.textBoxCondition_GTS.Size = new System.Drawing.Size(482, 78);
            this.textBoxCondition_GTS.TabIndex = 1;
            this.textBoxCondition_GTS.Text = "Написать программу, которая выводит таблицу значений функции на заданном диапазон" +
    "е. Результат вывести в textBox, построить график функции и сохранить в файл OutP" +
    "utFileTask.txt по нажатию кнопки.  ";
            // 
            // labelStop_GTS
            // 
            this.labelStop_GTS.AutoSize = true;
            this.labelStop_GTS.Location = new System.Drawing.Point(128, 47);
            this.labelStop_GTS.Name = "labelStop_GTS";
            this.labelStop_GTS.Size = new System.Drawing.Size(69, 13);
            this.labelStop_GTS.TabIndex = 3;
            this.labelStop_GTS.Text = "Конец шага:";
            // 
            // labelStart_GTS
            // 
            this.labelStart_GTS.AutoSize = true;
            this.labelStart_GTS.Location = new System.Drawing.Point(6, 47);
            this.labelStart_GTS.Name = "labelStart_GTS";
            this.labelStart_GTS.Size = new System.Drawing.Size(67, 13);
            this.labelStart_GTS.TabIndex = 2;
            this.labelStart_GTS.Text = "Старт шага:";
            // 
            // textBoxInPutStop_GTS
            // 
            this.textBoxInPutStop_GTS.Location = new System.Drawing.Point(131, 63);
            this.textBoxInPutStop_GTS.Name = "textBoxInPutStop_GTS";
            this.textBoxInPutStop_GTS.Size = new System.Drawing.Size(117, 20);
            this.textBoxInPutStop_GTS.TabIndex = 1;
            // 
            // textBoxInPutStart_GTS
            // 
            this.textBoxInPutStart_GTS.Location = new System.Drawing.Point(6, 63);
            this.textBoxInPutStart_GTS.Name = "textBoxInPutStart_GTS";
            this.textBoxInPutStart_GTS.Size = new System.Drawing.Size(115, 20);
            this.textBoxInPutStart_GTS.TabIndex = 0;
            // 
            // buttonDone_GTS
            // 
            this.buttonDone_GTS.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDone_GTS.Location = new System.Drawing.Point(754, 22);
            this.buttonDone_GTS.Name = "buttonDone_GTS";
            this.buttonDone_GTS.Size = new System.Drawing.Size(75, 70);
            this.buttonDone_GTS.TabIndex = 1;
            this.buttonDone_GTS.Text = "Выполнить";
            this.buttonDone_GTS.UseVisualStyleBackColor = false;
            this.buttonDone_GTS.Click += new System.EventHandler(this.buttonDone_GTS_Click);
            // 
            // buttonSave_GTS
            // 
            this.buttonSave_GTS.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSave_GTS.Location = new System.Drawing.Point(835, 22);
            this.buttonSave_GTS.Name = "buttonSave_GTS";
            this.buttonSave_GTS.Size = new System.Drawing.Size(75, 70);
            this.buttonSave_GTS.TabIndex = 2;
            this.buttonSave_GTS.Text = "Сохранить";
            this.buttonSave_GTS.UseVisualStyleBackColor = false;
            this.buttonSave_GTS.Click += new System.EventHandler(this.buttonSave_GTS_Click);
            // 
            // button_FAQ_GTS
            // 
            this.button_FAQ_GTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_FAQ_GTS.BackColor = System.Drawing.Color.Teal;
            this.button_FAQ_GTS.Location = new System.Drawing.Point(946, 22);
            this.button_FAQ_GTS.Name = "button_FAQ_GTS";
            this.button_FAQ_GTS.Size = new System.Drawing.Size(75, 70);
            this.button_FAQ_GTS.TabIndex = 3;
            this.button_FAQ_GTS.Text = "Справка";
            this.button_FAQ_GTS.UseVisualStyleBackColor = false;
            this.button_FAQ_GTS.Click += new System.EventHandler(this.button_FAQ_GTS_Click);
            // 
            // chartFunction_GTS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_GTS.ChartAreas.Add(chartArea1);
            this.chartFunction_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_GTS.Legends.Add(legend1);
            this.chartFunction_GTS.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_GTS.Name = "chartFunction_GTS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_GTS.Series.Add(series1);
            this.chartFunction_GTS.Size = new System.Drawing.Size(698, 461);
            this.chartFunction_GTS.TabIndex = 0;
            this.chartFunction_GTS.Text = "123";
            title1.Name = "Title1";
            title1.Text = "График функции";
            this.chartFunction_GTS.Titles.Add(title1);
            // 
            // panelInfo_GTS
            // 
            this.panelInfo_GTS.Controls.Add(this.groupBoxInfo_GTS);
            this.panelInfo_GTS.Controls.Add(this.groupBoxInPut_GTS);
            this.panelInfo_GTS.Controls.Add(this.buttonDone_GTS);
            this.panelInfo_GTS.Controls.Add(this.button_FAQ_GTS);
            this.panelInfo_GTS.Controls.Add(this.buttonSave_GTS);
            this.panelInfo_GTS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo_GTS.Location = new System.Drawing.Point(0, 0);
            this.panelInfo_GTS.Name = "panelInfo_GTS";
            this.panelInfo_GTS.Size = new System.Drawing.Size(1034, 100);
            this.panelInfo_GTS.TabIndex = 1;
            // 
            // groupBoxInfo_GTS
            // 
            this.groupBoxInfo_GTS.Controls.Add(this.textBoxCondition_GTS);
            this.groupBoxInfo_GTS.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInfo_GTS.Name = "groupBoxInfo_GTS";
            this.groupBoxInfo_GTS.Size = new System.Drawing.Size(482, 97);
            this.groupBoxInfo_GTS.TabIndex = 4;
            this.groupBoxInfo_GTS.TabStop = false;
            this.groupBoxInfo_GTS.Text = "Условие";
            // 
            // groupBoxInPut_GTS
            // 
            this.groupBoxInPut_GTS.Controls.Add(this.textBoxInPutStart_GTS);
            this.groupBoxInPut_GTS.Controls.Add(this.labelStart_GTS);
            this.groupBoxInPut_GTS.Controls.Add(this.labelStop_GTS);
            this.groupBoxInPut_GTS.Controls.Add(this.textBoxInPutStop_GTS);
            this.groupBoxInPut_GTS.Location = new System.Drawing.Point(491, 3);
            this.groupBoxInPut_GTS.Name = "groupBoxInPut_GTS";
            this.groupBoxInPut_GTS.Size = new System.Drawing.Size(254, 89);
            this.groupBoxInPut_GTS.TabIndex = 5;
            this.groupBoxInPut_GTS.TabStop = false;
            this.groupBoxInPut_GTS.Text = "Ввод данных";
            // 
            // panelOutPut_GTS
            // 
            this.panelOutPut_GTS.Controls.Add(this.textBoxResult_GTS);
            this.panelOutPut_GTS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_GTS.Location = new System.Drawing.Point(0, 100);
            this.panelOutPut_GTS.Name = "panelOutPut_GTS";
            this.panelOutPut_GTS.Size = new System.Drawing.Size(336, 461);
            this.panelOutPut_GTS.TabIndex = 2;
            // 
            // panelGraph_GTS
            // 
            this.panelGraph_GTS.Controls.Add(this.chartFunction_GTS);
            this.panelGraph_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph_GTS.Location = new System.Drawing.Point(336, 100);
            this.panelGraph_GTS.Name = "panelGraph_GTS";
            this.panelGraph_GTS.Size = new System.Drawing.Size(698, 461);
            this.panelGraph_GTS.TabIndex = 3;
            // 
            // textBoxResult_GTS
            // 
            this.textBoxResult_GTS.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_GTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.textBoxResult_GTS.Location = new System.Drawing.Point(0, 0);
            this.textBoxResult_GTS.Multiline = true;
            this.textBoxResult_GTS.Name = "textBoxResult_GTS";
            this.textBoxResult_GTS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_GTS.Size = new System.Drawing.Size(336, 461);
            this.textBoxResult_GTS.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(336, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 461);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelGraph_GTS);
            this.Controls.Add(this.panelOutPut_GTS);
            this.Controls.Add(this.panelInfo_GTS);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 6 | Галеев Т. С.";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GTS)).EndInit();
            this.panelInfo_GTS.ResumeLayout(false);
            this.groupBoxInfo_GTS.ResumeLayout(false);
            this.groupBoxInfo_GTS.PerformLayout();
            this.groupBoxInPut_GTS.ResumeLayout(false);
            this.groupBoxInPut_GTS.PerformLayout();
            this.panelOutPut_GTS.ResumeLayout(false);
            this.panelOutPut_GTS.PerformLayout();
            this.panelGraph_GTS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCondition_GTS;
        private System.Windows.Forms.Label labelStop_GTS;
        private System.Windows.Forms.Label labelStart_GTS;
        private System.Windows.Forms.TextBox textBoxInPutStop_GTS;
        private System.Windows.Forms.TextBox textBoxInPutStart_GTS;
        private System.Windows.Forms.Button buttonDone_GTS;
        private System.Windows.Forms.Button buttonSave_GTS;
        private System.Windows.Forms.Button button_FAQ_GTS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GTS;
        private System.Windows.Forms.Panel panelInfo_GTS;
        private System.Windows.Forms.GroupBox groupBoxInfo_GTS;
        private System.Windows.Forms.GroupBox groupBoxInPut_GTS;
        private System.Windows.Forms.Panel panelOutPut_GTS;
        private System.Windows.Forms.Panel panelGraph_GTS;
        private System.Windows.Forms.TextBox textBoxResult_GTS;
        private System.Windows.Forms.Splitter splitter1;
    }
}

