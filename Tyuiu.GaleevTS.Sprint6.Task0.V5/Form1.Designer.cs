
namespace Tyuiu.GaleevTS.Sprint6.Task0.V5
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
            this.pictureBoxFormula_GTS = new System.Windows.Forms.PictureBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_GTS = new System.Windows.Forms.GroupBox();
            this.labelInPutX_GTS = new System.Windows.Forms.Label();
            this.textBoxInPutX = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_GTS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_GTS = new System.Windows.Forms.TextBox();
            this.labelOutPutResult_GTS = new System.Windows.Forms.Label();
            this.buttonClickToSolition_GTS = new System.Windows.Forms.Button();
            this.buttonFAQ_GTS = new System.Windows.Forms.Button();
            this.groupBoxCondition_GTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_GTS)).BeginInit();
            this.groupBoxInPut_GTS.SuspendLayout();
            this.groupBoxOutPut_GTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_GTS
            // 
            this.groupBoxCondition_GTS.Controls.Add(this.pictureBoxFormula_GTS);
            this.groupBoxCondition_GTS.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition_GTS.Location = new System.Drawing.Point(12, 30);
            this.groupBoxCondition_GTS.Name = "groupBoxCondition_GTS";
            this.groupBoxCondition_GTS.Size = new System.Drawing.Size(776, 231);
            this.groupBoxCondition_GTS.TabIndex = 0;
            this.groupBoxCondition_GTS.TabStop = false;
            this.groupBoxCondition_GTS.Text = "Условие";
            // 
            // pictureBoxFormula_GTS
            // 
            this.pictureBoxFormula_GTS.Image = global::Tyuiu.GaleevTS.Sprint6.Task0.V5.Properties.Resources.Снимок_экрана_2023_12_02_233704;
            this.pictureBoxFormula_GTS.Location = new System.Drawing.Point(18, 62);
            this.pictureBoxFormula_GTS.Name = "pictureBoxFormula_GTS";
            this.pictureBoxFormula_GTS.Size = new System.Drawing.Size(752, 150);
            this.pictureBoxFormula_GTS.TabIndex = 1;
            this.pictureBoxFormula_GTS.TabStop = false;
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(18, 28);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(752, 18);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInPut_GTS
            // 
            this.groupBoxInPut_GTS.Controls.Add(this.labelInPutX_GTS);
            this.groupBoxInPut_GTS.Controls.Add(this.textBoxInPutX);
            this.groupBoxInPut_GTS.Location = new System.Drawing.Point(12, 280);
            this.groupBoxInPut_GTS.Name = "groupBoxInPut_GTS";
            this.groupBoxInPut_GTS.Size = new System.Drawing.Size(542, 102);
            this.groupBoxInPut_GTS.TabIndex = 1;
            this.groupBoxInPut_GTS.TabStop = false;
            this.groupBoxInPut_GTS.Text = "Ввод данных";
            // 
            // labelInPutX_GTS
            // 
            this.labelInPutX_GTS.AutoSize = true;
            this.labelInPutX_GTS.Location = new System.Drawing.Point(7, 45);
            this.labelInPutX_GTS.Name = "labelInPutX_GTS";
            this.labelInPutX_GTS.Size = new System.Drawing.Size(84, 13);
            this.labelInPutX_GTS.TabIndex = 2;
            this.labelInPutX_GTS.Text = "Переменная X:";
            // 
            // textBoxInPutX
            // 
            this.textBoxInPutX.Location = new System.Drawing.Point(9, 61);
            this.textBoxInPutX.Name = "textBoxInPutX";
            this.textBoxInPutX.Size = new System.Drawing.Size(82, 20);
            this.textBoxInPutX.TabIndex = 0;
            this.textBoxInPutX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // groupBoxOutPut_GTS
            // 
            this.groupBoxOutPut_GTS.Controls.Add(this.textBoxResult_GTS);
            this.groupBoxOutPut_GTS.Controls.Add(this.labelOutPutResult_GTS);
            this.groupBoxOutPut_GTS.Location = new System.Drawing.Point(570, 281);
            this.groupBoxOutPut_GTS.Name = "groupBoxOutPut_GTS";
            this.groupBoxOutPut_GTS.Size = new System.Drawing.Size(218, 101);
            this.groupBoxOutPut_GTS.TabIndex = 2;
            this.groupBoxOutPut_GTS.TabStop = false;
            this.groupBoxOutPut_GTS.Text = "Вывод данных:";
            // 
            // textBoxResult_GTS
            // 
            this.textBoxResult_GTS.Location = new System.Drawing.Point(9, 61);
            this.textBoxResult_GTS.Name = "textBoxResult_GTS";
            this.textBoxResult_GTS.ReadOnly = true;
            this.textBoxResult_GTS.Size = new System.Drawing.Size(103, 20);
            this.textBoxResult_GTS.TabIndex = 1;
            // 
            // labelOutPutResult_GTS
            // 
            this.labelOutPutResult_GTS.AutoSize = true;
            this.labelOutPutResult_GTS.Location = new System.Drawing.Point(6, 44);
            this.labelOutPutResult_GTS.Name = "labelOutPutResult_GTS";
            this.labelOutPutResult_GTS.Size = new System.Drawing.Size(59, 13);
            this.labelOutPutResult_GTS.TabIndex = 0;
            this.labelOutPutResult_GTS.Text = "Результат";
            // 
            // buttonClickToSolition_GTS
            // 
            this.buttonClickToSolition_GTS.Location = new System.Drawing.Point(649, 388);
            this.buttonClickToSolition_GTS.Name = "buttonClickToSolition_GTS";
            this.buttonClickToSolition_GTS.Size = new System.Drawing.Size(139, 50);
            this.buttonClickToSolition_GTS.TabIndex = 3;
            this.buttonClickToSolition_GTS.Text = "Выполнить";
            this.buttonClickToSolition_GTS.UseVisualStyleBackColor = true;
            this.buttonClickToSolition_GTS.Click += new System.EventHandler(this.buttonClickToSolition_GTS_Click);
            // 
            // buttonFAQ_GTS
            // 
            this.buttonFAQ_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFAQ_GTS.Location = new System.Drawing.Point(571, 388);
            this.buttonFAQ_GTS.Name = "buttonFAQ_GTS";
            this.buttonFAQ_GTS.Size = new System.Drawing.Size(64, 50);
            this.buttonFAQ_GTS.TabIndex = 4;
            this.buttonFAQ_GTS.Text = "?";
            this.buttonFAQ_GTS.UseVisualStyleBackColor = true;
            this.buttonFAQ_GTS.Click += new System.EventHandler(this.buttonFAQ_GTS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFAQ_GTS);
            this.Controls.Add(this.buttonClickToSolition_GTS);
            this.Controls.Add(this.groupBoxOutPut_GTS);
            this.Controls.Add(this.groupBoxInPut_GTS);
            this.Controls.Add(this.groupBoxCondition_GTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 5 | Галеев.Т.С";
            this.groupBoxCondition_GTS.ResumeLayout(false);
            this.groupBoxCondition_GTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_GTS)).EndInit();
            this.groupBoxInPut_GTS.ResumeLayout(false);
            this.groupBoxInPut_GTS.PerformLayout();
            this.groupBoxOutPut_GTS.ResumeLayout(false);
            this.groupBoxOutPut_GTS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_GTS;
        private System.Windows.Forms.GroupBox groupBoxInPut_GTS;
        private System.Windows.Forms.Label labelInPutX_GTS;
        private System.Windows.Forms.TextBox textBoxInPutX;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GTS;
        private System.Windows.Forms.TextBox textBoxResult_GTS;
        private System.Windows.Forms.Label labelOutPutResult_GTS;
        private System.Windows.Forms.Button buttonClickToSolition_GTS;
        private System.Windows.Forms.Button buttonFAQ_GTS;
        private System.Windows.Forms.PictureBox pictureBoxFormula_GTS;
        private System.Windows.Forms.TextBox textBoxCondition;
    }
}

