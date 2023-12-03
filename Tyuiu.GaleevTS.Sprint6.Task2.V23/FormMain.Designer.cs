
namespace Tyuiu.GaleevTS.Sprint6.Task2.V23
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxCondition_GTS = new System.Windows.Forms.GroupBox();
            this.labelConditionPicture = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.groupBoxInput_GTS = new System.Windows.Forms.GroupBox();
            this.labelEndInput_GTS = new System.Windows.Forms.Label();
            this.labelStartInput_GTS = new System.Windows.Forms.Label();
            this.textBoxInPutStop = new System.Windows.Forms.TextBox();
            this.textBoxInputStart = new System.Windows.Forms.TextBox();
            this.buttonFAQ_GTS = new System.Windows.Forms.Button();
            this.buttonCompleteTask_GTS = new System.Windows.Forms.Button();
            this.groupBoxResult_GTS = new System.Windows.Forms.GroupBox();
            this.chartFunction_GTS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunctionResult_GTS = new System.Windows.Forms.DataGridView();
            this.Xfunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunctionXResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResultTag_GTS = new System.Windows.Forms.Label();
            this.groupBoxCondition_GTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInput_GTS.SuspendLayout();
            this.groupBoxResult_GTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunctionResult_GTS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_GTS
            // 
            this.groupBoxCondition_GTS.Controls.Add(this.labelConditionPicture);
            this.groupBoxCondition_GTS.Controls.Add(this.pictureBox1);
            this.groupBoxCondition_GTS.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition_GTS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_GTS.Name = "groupBoxCondition_GTS";
            this.groupBoxCondition_GTS.Size = new System.Drawing.Size(568, 331);
            this.groupBoxCondition_GTS.TabIndex = 1;
            this.groupBoxCondition_GTS.TabStop = false;
            this.groupBoxCondition_GTS.Text = "Условие";
            // 
            // labelConditionPicture
            // 
            this.labelConditionPicture.AutoSize = true;
            this.labelConditionPicture.Location = new System.Drawing.Point(17, 82);
            this.labelConditionPicture.Name = "labelConditionPicture";
            this.labelConditionPicture.Size = new System.Drawing.Size(56, 13);
            this.labelConditionPicture.TabIndex = 2;
            this.labelConditionPicture.Text = "Функция:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.GaleevTS.Sprint6.Task2.V23.Properties.Resources.Снимок_экрана_2023_12_03_164329;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(15, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 42);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(0, 40);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(566, 301);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = "Написать программу, которая выводит таблицу значений функции F(x) и её график на " +
    "заданном диапазоне. ";
            // 
            // groupBoxInput_GTS
            // 
            this.groupBoxInput_GTS.Controls.Add(this.labelEndInput_GTS);
            this.groupBoxInput_GTS.Controls.Add(this.labelStartInput_GTS);
            this.groupBoxInput_GTS.Controls.Add(this.textBoxInPutStop);
            this.groupBoxInput_GTS.Controls.Add(this.textBoxInputStart);
            this.groupBoxInput_GTS.Location = new System.Drawing.Point(12, 359);
            this.groupBoxInput_GTS.Name = "groupBoxInput_GTS";
            this.groupBoxInput_GTS.Size = new System.Drawing.Size(312, 84);
            this.groupBoxInput_GTS.TabIndex = 3;
            this.groupBoxInput_GTS.TabStop = false;
            this.groupBoxInput_GTS.Text = "Ввод данных";
            // 
            // labelEndInput_GTS
            // 
            this.labelEndInput_GTS.AutoSize = true;
            this.labelEndInput_GTS.Location = new System.Drawing.Point(167, 44);
            this.labelEndInput_GTS.Name = "labelEndInput_GTS";
            this.labelEndInput_GTS.Size = new System.Drawing.Size(69, 13);
            this.labelEndInput_GTS.TabIndex = 5;
            this.labelEndInput_GTS.Text = "Конец шага:";
            // 
            // labelStartInput_GTS
            // 
            this.labelStartInput_GTS.AutoSize = true;
            this.labelStartInput_GTS.Location = new System.Drawing.Point(7, 43);
            this.labelStartInput_GTS.Name = "labelStartInput_GTS";
            this.labelStartInput_GTS.Size = new System.Drawing.Size(67, 13);
            this.labelStartInput_GTS.TabIndex = 3;
            this.labelStartInput_GTS.Text = "Старт шага:";
            // 
            // textBoxInPutStop
            // 
            this.textBoxInPutStop.Location = new System.Drawing.Point(170, 60);
            this.textBoxInPutStop.Name = "textBoxInPutStop";
            this.textBoxInPutStop.Size = new System.Drawing.Size(134, 20);
            this.textBoxInPutStop.TabIndex = 4;
            // 
            // textBoxInputStart
            // 
            this.textBoxInputStart.Location = new System.Drawing.Point(7, 59);
            this.textBoxInputStart.Name = "textBoxInputStart";
            this.textBoxInputStart.Size = new System.Drawing.Size(134, 20);
            this.textBoxInputStart.TabIndex = 3;
            // 
            // buttonFAQ_GTS
            // 
            this.buttonFAQ_GTS.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonFAQ_GTS.Location = new System.Drawing.Point(331, 366);
            this.buttonFAQ_GTS.Name = "buttonFAQ_GTS";
            this.buttonFAQ_GTS.Size = new System.Drawing.Size(88, 77);
            this.buttonFAQ_GTS.TabIndex = 4;
            this.buttonFAQ_GTS.Text = "Справка";
            this.buttonFAQ_GTS.UseVisualStyleBackColor = false;
            this.buttonFAQ_GTS.Click += new System.EventHandler(this.buttonFAQ_GTS_Click);
            // 
            // buttonCompleteTask_GTS
            // 
            this.buttonCompleteTask_GTS.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonCompleteTask_GTS.Location = new System.Drawing.Point(428, 367);
            this.buttonCompleteTask_GTS.Name = "buttonCompleteTask_GTS";
            this.buttonCompleteTask_GTS.Size = new System.Drawing.Size(152, 76);
            this.buttonCompleteTask_GTS.TabIndex = 5;
            this.buttonCompleteTask_GTS.Text = "Выполнить";
            this.buttonCompleteTask_GTS.UseVisualStyleBackColor = false;
            this.buttonCompleteTask_GTS.Click += new System.EventHandler(this.buttonCompleteTask_GTS_Click);
            this.buttonCompleteTask_GTS.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            // 
            // groupBoxResult_GTS
            // 
            this.groupBoxResult_GTS.Controls.Add(this.chartFunction_GTS);
            this.groupBoxResult_GTS.Controls.Add(this.dataGridViewFunctionResult_GTS);
            this.groupBoxResult_GTS.Controls.Add(this.labelResultTag_GTS);
            this.groupBoxResult_GTS.Location = new System.Drawing.Point(586, 12);
            this.groupBoxResult_GTS.Name = "groupBoxResult_GTS";
            this.groupBoxResult_GTS.Size = new System.Drawing.Size(666, 431);
            this.groupBoxResult_GTS.TabIndex = 7;
            this.groupBoxResult_GTS.TabStop = false;
            this.groupBoxResult_GTS.Text = "Вывод данных";
            // 
            // chartFunction_GTS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_GTS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_GTS.Legends.Add(legend1);
            this.chartFunction_GTS.Location = new System.Drawing.Point(154, 42);
            this.chartFunction_GTS.Name = "chartFunction_GTS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_GTS.Series.Add(series1);
            this.chartFunction_GTS.Size = new System.Drawing.Size(512, 372);
            this.chartFunction_GTS.TabIndex = 3;
            this.chartFunction_GTS.Text = "chart1";
            // 
            // dataGridViewFunctionResult_GTS
            // 
            this.dataGridViewFunctionResult_GTS.AllowUserToAddRows = false;
            this.dataGridViewFunctionResult_GTS.AllowUserToDeleteRows = false;
            this.dataGridViewFunctionResult_GTS.AllowUserToResizeColumns = false;
            this.dataGridViewFunctionResult_GTS.AllowUserToResizeRows = false;
            this.dataGridViewFunctionResult_GTS.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFunctionResult_GTS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFunctionResult_GTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunctionResult_GTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xfunction,
            this.FunctionXResult});
            this.dataGridViewFunctionResult_GTS.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewFunctionResult_GTS.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewFunctionResult_GTS.Name = "dataGridViewFunctionResult_GTS";
            this.dataGridViewFunctionResult_GTS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewFunctionResult_GTS.RowHeadersVisible = false;
            this.dataGridViewFunctionResult_GTS.Size = new System.Drawing.Size(148, 374);
            this.dataGridViewFunctionResult_GTS.TabIndex = 2;
            // 
            // Xfunction
            // 
            this.Xfunction.HeaderText = "X";
            this.Xfunction.Name = "Xfunction";
            this.Xfunction.ReadOnly = true;
            this.Xfunction.Width = 70;
            // 
            // FunctionXResult
            // 
            this.FunctionXResult.HeaderText = "F(x)";
            this.FunctionXResult.Name = "FunctionXResult";
            this.FunctionXResult.ReadOnly = true;
            this.FunctionXResult.Width = 70;
            // 
            // labelResultTag_GTS
            // 
            this.labelResultTag_GTS.AutoSize = true;
            this.labelResultTag_GTS.Location = new System.Drawing.Point(6, 25);
            this.labelResultTag_GTS.Name = "labelResultTag_GTS";
            this.labelResultTag_GTS.Size = new System.Drawing.Size(62, 13);
            this.labelResultTag_GTS.TabIndex = 1;
            this.labelResultTag_GTS.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 451);
            this.Controls.Add(this.groupBoxResult_GTS);
            this.Controls.Add(this.buttonCompleteTask_GTS);
            this.Controls.Add(this.buttonFAQ_GTS);
            this.Controls.Add(this.groupBoxInput_GTS);
            this.Controls.Add(this.groupBoxCondition_GTS);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 10 | Галеев Т. С.";
            this.groupBoxCondition_GTS.ResumeLayout(false);
            this.groupBoxCondition_GTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInput_GTS.ResumeLayout(false);
            this.groupBoxInput_GTS.PerformLayout();
            this.groupBoxResult_GTS.ResumeLayout(false);
            this.groupBoxResult_GTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunctionResult_GTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_GTS;
        private System.Windows.Forms.Label labelConditionPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.GroupBox groupBoxInput_GTS;
        private System.Windows.Forms.Label labelEndInput_GTS;
        private System.Windows.Forms.Label labelStartInput_GTS;
        private System.Windows.Forms.TextBox textBoxInPutStop;
        private System.Windows.Forms.TextBox textBoxInputStart;
        private System.Windows.Forms.Button buttonFAQ_GTS;
        private System.Windows.Forms.Button buttonCompleteTask_GTS;
        private System.Windows.Forms.GroupBox groupBoxResult_GTS;
        private System.Windows.Forms.Label labelResultTag_GTS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GTS;
        private System.Windows.Forms.DataGridView dataGridViewFunctionResult_GTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xfunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionXResult;
    }
}

