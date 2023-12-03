
namespace Tyuiu.GaleevTS.Sprint6.Task1.V10
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
            this.groupBoxCondition_GTS = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxResult_GTS = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_GTS = new System.Windows.Forms.GroupBox();
            this.textBoxInputStart = new System.Windows.Forms.TextBox();
            this.textBoxInPutStop = new System.Windows.Forms.TextBox();
            this.labelStartInput_GTS = new System.Windows.Forms.Label();
            this.labelEndInput_GTS = new System.Windows.Forms.Label();
            this.buttonFAQ_GTS = new System.Windows.Forms.Button();
            this.buttonCompleteTask_GTS = new System.Windows.Forms.Button();
            this.textBoxResult_GTS = new System.Windows.Forms.TextBox();
            this.labelResultTag_GTS = new System.Windows.Forms.Label();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelConditionPicture = new System.Windows.Forms.Label();
            this.groupBoxCondition_GTS.SuspendLayout();
            this.groupBoxResult_GTS.SuspendLayout();
            this.groupBoxInput_GTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_GTS
            // 
            this.groupBoxCondition_GTS.Controls.Add(this.labelConditionPicture);
            this.groupBoxCondition_GTS.Controls.Add(this.pictureBox1);
            this.groupBoxCondition_GTS.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition_GTS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_GTS.Name = "groupBoxCondition_GTS";
            this.groupBoxCondition_GTS.Size = new System.Drawing.Size(566, 331);
            this.groupBoxCondition_GTS.TabIndex = 0;
            this.groupBoxCondition_GTS.TabStop = false;
            this.groupBoxCondition_GTS.Text = "Условие";
            // 
            // groupBoxResult_GTS
            // 
            this.groupBoxResult_GTS.Controls.Add(this.labelResultTag_GTS);
            this.groupBoxResult_GTS.Controls.Add(this.textBoxResult_GTS);
            this.groupBoxResult_GTS.Location = new System.Drawing.Point(584, 12);
            this.groupBoxResult_GTS.Name = "groupBoxResult_GTS";
            this.groupBoxResult_GTS.Size = new System.Drawing.Size(204, 431);
            this.groupBoxResult_GTS.TabIndex = 1;
            this.groupBoxResult_GTS.TabStop = false;
            this.groupBoxResult_GTS.Text = "Вывод данных";
            // 
            // groupBoxInput_GTS
            // 
            this.groupBoxInput_GTS.Controls.Add(this.labelEndInput_GTS);
            this.groupBoxInput_GTS.Controls.Add(this.labelStartInput_GTS);
            this.groupBoxInput_GTS.Controls.Add(this.textBoxInPutStop);
            this.groupBoxInput_GTS.Controls.Add(this.textBoxInputStart);
            this.groupBoxInput_GTS.Location = new System.Drawing.Point(13, 359);
            this.groupBoxInput_GTS.Name = "groupBoxInput_GTS";
            this.groupBoxInput_GTS.Size = new System.Drawing.Size(312, 84);
            this.groupBoxInput_GTS.TabIndex = 2;
            this.groupBoxInput_GTS.TabStop = false;
            this.groupBoxInput_GTS.Text = "Ввод данных";
            // 
            // textBoxInputStart
            // 
            this.textBoxInputStart.Location = new System.Drawing.Point(7, 59);
            this.textBoxInputStart.Name = "textBoxInputStart";
            this.textBoxInputStart.Size = new System.Drawing.Size(134, 20);
            this.textBoxInputStart.TabIndex = 3;
            // 
            // textBoxInPutStop
            // 
            this.textBoxInPutStop.Location = new System.Drawing.Point(170, 60);
            this.textBoxInPutStop.Name = "textBoxInPutStop";
            this.textBoxInPutStop.Size = new System.Drawing.Size(134, 20);
            this.textBoxInPutStop.TabIndex = 4;
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
            // labelEndInput_GTS
            // 
            this.labelEndInput_GTS.AutoSize = true;
            this.labelEndInput_GTS.Location = new System.Drawing.Point(167, 44);
            this.labelEndInput_GTS.Name = "labelEndInput_GTS";
            this.labelEndInput_GTS.Size = new System.Drawing.Size(69, 13);
            this.labelEndInput_GTS.TabIndex = 5;
            this.labelEndInput_GTS.Text = "Конец шага:";
            // 
            // buttonFAQ_GTS
            // 
            this.buttonFAQ_GTS.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonFAQ_GTS.Location = new System.Drawing.Point(331, 366);
            this.buttonFAQ_GTS.Name = "buttonFAQ_GTS";
            this.buttonFAQ_GTS.Size = new System.Drawing.Size(88, 77);
            this.buttonFAQ_GTS.TabIndex = 3;
            this.buttonFAQ_GTS.Text = "Справка";
            this.buttonFAQ_GTS.UseVisualStyleBackColor = false;
            this.buttonFAQ_GTS.Click += new System.EventHandler(this.buttonFAQ_GTS_Click);
            // 
            // buttonCompleteTask_GTS
            // 
            this.buttonCompleteTask_GTS.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonCompleteTask_GTS.Location = new System.Drawing.Point(425, 366);
            this.buttonCompleteTask_GTS.Name = "buttonCompleteTask_GTS";
            this.buttonCompleteTask_GTS.Size = new System.Drawing.Size(152, 76);
            this.buttonCompleteTask_GTS.TabIndex = 4;
            this.buttonCompleteTask_GTS.Text = "Выполнить";
            this.buttonCompleteTask_GTS.UseVisualStyleBackColor = false;
            this.buttonCompleteTask_GTS.Click += new System.EventHandler(this.buttonCompleteTask_GTS_Click);
            // 
            // textBoxResult_GTS
            // 
            this.textBoxResult_GTS.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_GTS.Location = new System.Drawing.Point(0, 41);
            this.textBoxResult_GTS.Multiline = true;
            this.textBoxResult_GTS.Name = "textBoxResult_GTS";
            this.textBoxResult_GTS.ReadOnly = true;
            this.textBoxResult_GTS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_GTS.Size = new System.Drawing.Size(199, 404);
            this.textBoxResult_GTS.TabIndex = 0;
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
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(6, 40);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(554, 301);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = "Написать программу, которая выводит таблицу значений функции F(x) на заданном диа" +
    "пазоне. ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.GaleevTS.Sprint6.Task1.V10.Properties.Resources.Снимок_экрана_2023_12_03_145634;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(15, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 42);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCompleteTask_GTS);
            this.Controls.Add(this.buttonFAQ_GTS);
            this.Controls.Add(this.groupBoxInput_GTS);
            this.Controls.Add(this.groupBoxResult_GTS);
            this.Controls.Add(this.groupBoxCondition_GTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 10 | Галеев Т. С.";
            this.groupBoxCondition_GTS.ResumeLayout(false);
            this.groupBoxCondition_GTS.PerformLayout();
            this.groupBoxResult_GTS.ResumeLayout(false);
            this.groupBoxResult_GTS.PerformLayout();
            this.groupBoxInput_GTS.ResumeLayout(false);
            this.groupBoxInput_GTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_GTS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.GroupBox groupBoxResult_GTS;
        private System.Windows.Forms.Label labelResultTag_GTS;
        private System.Windows.Forms.TextBox textBoxResult_GTS;
        private System.Windows.Forms.GroupBox groupBoxInput_GTS;
        private System.Windows.Forms.Label labelEndInput_GTS;
        private System.Windows.Forms.Label labelStartInput_GTS;
        private System.Windows.Forms.TextBox textBoxInPutStop;
        private System.Windows.Forms.TextBox textBoxInputStart;
        private System.Windows.Forms.Button buttonFAQ_GTS;
        private System.Windows.Forms.Button buttonCompleteTask_GTS;
        private System.Windows.Forms.Label labelConditionPicture;
    }
}

