
namespace Tyuiu.GaleevTS.Sprint6.Task5.V22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelInfo_GTS = new System.Windows.Forms.Panel();
            this.buttonToCheckInPutData_GTS = new System.Windows.Forms.Button();
            this.groupBoxInfo_GTS = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_GTS = new System.Windows.Forms.TextBox();
            this.buttonDone_GTS = new System.Windows.Forms.Button();
            this.button_FAQ_GTS = new System.Windows.Forms.Button();
            this.panelGridData_GTS = new System.Windows.Forms.Panel();
            this.groupBoxGridData_GTS = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPutData_GTS = new System.Windows.Forms.DataGridView();
            this.panelGraphData_GTS = new System.Windows.Forms.Panel();
            this.chartData_GTS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelInfo_GTS.SuspendLayout();
            this.groupBoxInfo_GTS.SuspendLayout();
            this.panelGridData_GTS.SuspendLayout();
            this.groupBoxGridData_GTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_GTS)).BeginInit();
            this.panelGraphData_GTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData_GTS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo_GTS
            // 
            this.panelInfo_GTS.Controls.Add(this.buttonToCheckInPutData_GTS);
            this.panelInfo_GTS.Controls.Add(this.groupBoxInfo_GTS);
            this.panelInfo_GTS.Controls.Add(this.buttonDone_GTS);
            this.panelInfo_GTS.Controls.Add(this.button_FAQ_GTS);
            this.panelInfo_GTS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo_GTS.Location = new System.Drawing.Point(0, 0);
            this.panelInfo_GTS.Name = "panelInfo_GTS";
            this.panelInfo_GTS.Size = new System.Drawing.Size(800, 100);
            this.panelInfo_GTS.TabIndex = 2;
            // 
            // buttonToCheckInPutData_GTS
            // 
            this.buttonToCheckInPutData_GTS.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonToCheckInPutData_GTS.Location = new System.Drawing.Point(597, 30);
            this.buttonToCheckInPutData_GTS.Name = "buttonToCheckInPutData_GTS";
            this.buttonToCheckInPutData_GTS.Size = new System.Drawing.Size(94, 70);
            this.buttonToCheckInPutData_GTS.TabIndex = 3;
            this.buttonToCheckInPutData_GTS.Text = "Открыть файл";
            this.buttonToCheckInPutData_GTS.UseVisualStyleBackColor = false;
            this.buttonToCheckInPutData_GTS.Click += new System.EventHandler(this.buttonToCheckInPutData_GTS_Click);
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
            // textBoxCondition_GTS
            // 
            this.textBoxCondition_GTS.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxCondition_GTS.Location = new System.Drawing.Point(3, 16);
            this.textBoxCondition_GTS.Multiline = true;
            this.textBoxCondition_GTS.Name = "textBoxCondition_GTS";
            this.textBoxCondition_GTS.ReadOnly = true;
            this.textBoxCondition_GTS.Size = new System.Drawing.Size(482, 78);
            this.textBoxCondition_GTS.TabIndex = 1;
            this.textBoxCondition_GTS.Text = resources.GetString("textBoxCondition_GTS.Text");
            // 
            // buttonDone_GTS
            // 
            this.buttonDone_GTS.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDone_GTS.Location = new System.Drawing.Point(491, 30);
            this.buttonDone_GTS.Name = "buttonDone_GTS";
            this.buttonDone_GTS.Size = new System.Drawing.Size(97, 70);
            this.buttonDone_GTS.TabIndex = 1;
            this.buttonDone_GTS.Text = "Выполнить";
            this.buttonDone_GTS.UseVisualStyleBackColor = false;
            this.buttonDone_GTS.Click += new System.EventHandler(this.buttonDone_GTS_Click);
            // 
            // button_FAQ_GTS
            // 
            this.button_FAQ_GTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_FAQ_GTS.BackColor = System.Drawing.Color.Teal;
            this.button_FAQ_GTS.Location = new System.Drawing.Point(700, 30);
            this.button_FAQ_GTS.Name = "button_FAQ_GTS";
            this.button_FAQ_GTS.Size = new System.Drawing.Size(100, 70);
            this.button_FAQ_GTS.TabIndex = 3;
            this.button_FAQ_GTS.Text = "Справка";
            this.button_FAQ_GTS.UseVisualStyleBackColor = false;
            this.button_FAQ_GTS.Click += new System.EventHandler(this.button_FAQ_GTS_Click);
            // 
            // panelGridData_GTS
            // 
            this.panelGridData_GTS.Controls.Add(this.groupBoxGridData_GTS);
            this.panelGridData_GTS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGridData_GTS.Location = new System.Drawing.Point(0, 100);
            this.panelGridData_GTS.Name = "panelGridData_GTS";
            this.panelGridData_GTS.Size = new System.Drawing.Size(260, 350);
            this.panelGridData_GTS.TabIndex = 3;
            // 
            // groupBoxGridData_GTS
            // 
            this.groupBoxGridData_GTS.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxGridData_GTS.Controls.Add(this.dataGridViewInPutData_GTS);
            this.groupBoxGridData_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGridData_GTS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGridData_GTS.Name = "groupBoxGridData_GTS";
            this.groupBoxGridData_GTS.Size = new System.Drawing.Size(260, 350);
            this.groupBoxGridData_GTS.TabIndex = 0;
            this.groupBoxGridData_GTS.TabStop = false;
            this.groupBoxGridData_GTS.Text = "Вывод данных:";
            // 
            // dataGridViewInPutData_GTS
            // 
            this.dataGridViewInPutData_GTS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewInPutData_GTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutData_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPutData_GTS.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInPutData_GTS.Name = "dataGridViewInPutData_GTS";
            this.dataGridViewInPutData_GTS.RowHeadersVisible = false;
            this.dataGridViewInPutData_GTS.Size = new System.Drawing.Size(254, 331);
            this.dataGridViewInPutData_GTS.StandardTab = true;
            this.dataGridViewInPutData_GTS.TabIndex = 0;
            // 
            // panelGraphData_GTS
            // 
            this.panelGraphData_GTS.Controls.Add(this.chartData_GTS);
            this.panelGraphData_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraphData_GTS.Location = new System.Drawing.Point(260, 100);
            this.panelGraphData_GTS.Name = "panelGraphData_GTS";
            this.panelGraphData_GTS.Size = new System.Drawing.Size(540, 350);
            this.panelGraphData_GTS.TabIndex = 0;
            // 
            // chartData_GTS
            // 
            this.chartData_GTS.BackColor = System.Drawing.Color.LightSalmon;
            this.chartData_GTS.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartData_GTS.ChartAreas.Add(chartArea3);
            this.chartData_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartData_GTS.Legends.Add(legend3);
            this.chartData_GTS.Location = new System.Drawing.Point(0, 0);
            this.chartData_GTS.Name = "chartData_GTS";
            this.chartData_GTS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartData_GTS.Series.Add(series3);
            this.chartData_GTS.Size = new System.Drawing.Size(540, 350);
            this.chartData_GTS.TabIndex = 1;
            this.chartData_GTS.Text = "chart1";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(797, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 350);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelGraphData_GTS);
            this.Controls.Add(this.panelGridData_GTS);
            this.Controls.Add(this.panelInfo_GTS);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Спринт 6 | Таск 5 | Вариант 22 | Галеев Т. С.";
            this.panelInfo_GTS.ResumeLayout(false);
            this.groupBoxInfo_GTS.ResumeLayout(false);
            this.groupBoxInfo_GTS.PerformLayout();
            this.panelGridData_GTS.ResumeLayout(false);
            this.groupBoxGridData_GTS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_GTS)).EndInit();
            this.panelGraphData_GTS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartData_GTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo_GTS;
        private System.Windows.Forms.GroupBox groupBoxInfo_GTS;
        private System.Windows.Forms.TextBox textBoxCondition_GTS;
        private System.Windows.Forms.Button buttonDone_GTS;
        private System.Windows.Forms.Button button_FAQ_GTS;
        private System.Windows.Forms.Button buttonToCheckInPutData_GTS;
        private System.Windows.Forms.Panel panelGridData_GTS;
        private System.Windows.Forms.Panel panelGraphData_GTS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxGridData_GTS;
        private System.Windows.Forms.DataGridView dataGridViewInPutData_GTS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData_GTS;
        private System.Windows.Forms.Splitter splitter1;
    }
}

