
namespace Tyuiu.GaleevTS.Sprint6.Task3.V6
{
    partial class FromMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromMain));
            this.groupBoxInPut_GTS = new System.Windows.Forms.GroupBox();
            this.buttonFAQ_GTS = new System.Windows.Forms.Button();
            this.buttonDone_GTS = new System.Windows.Forms.Button();
            this.dataGridViewInPutArray_GTS = new System.Windows.Forms.DataGridView();
            this.textBoxCondition_GTS = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxOutPut_GTS = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPutArray_GTS = new System.Windows.Forms.DataGridView();
            this.groupBoxInPut_GTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutArray_GTS)).BeginInit();
            this.groupBoxOutPut_GTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutArray_GTS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInPut_GTS
            // 
            this.groupBoxInPut_GTS.Controls.Add(this.buttonFAQ_GTS);
            this.groupBoxInPut_GTS.Controls.Add(this.buttonDone_GTS);
            this.groupBoxInPut_GTS.Controls.Add(this.dataGridViewInPutArray_GTS);
            this.groupBoxInPut_GTS.Controls.Add(this.textBoxCondition_GTS);
            this.groupBoxInPut_GTS.Location = new System.Drawing.Point(13, 12);
            this.groupBoxInPut_GTS.Name = "groupBoxInPut_GTS";
            this.groupBoxInPut_GTS.Size = new System.Drawing.Size(574, 429);
            this.groupBoxInPut_GTS.TabIndex = 0;
            this.groupBoxInPut_GTS.TabStop = false;
            this.groupBoxInPut_GTS.Text = "Условие";
            // 
            // buttonFAQ_GTS
            // 
            this.buttonFAQ_GTS.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonFAQ_GTS.Location = new System.Drawing.Point(274, 346);
            this.buttonFAQ_GTS.Name = "buttonFAQ_GTS";
            this.buttonFAQ_GTS.Size = new System.Drawing.Size(88, 77);
            this.buttonFAQ_GTS.TabIndex = 5;
            this.buttonFAQ_GTS.Text = "Справка";
            this.buttonFAQ_GTS.UseVisualStyleBackColor = false;
            this.buttonFAQ_GTS.Click += new System.EventHandler(this.buttonFAQ_GTS_Click);
            // 
            // buttonDone_GTS
            // 
            this.buttonDone_GTS.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDone_GTS.Location = new System.Drawing.Point(405, 346);
            this.buttonDone_GTS.Name = "buttonDone_GTS";
            this.buttonDone_GTS.Size = new System.Drawing.Size(156, 77);
            this.buttonDone_GTS.TabIndex = 3;
            this.buttonDone_GTS.Text = "Выполнить";
            this.buttonDone_GTS.UseVisualStyleBackColor = false;
            this.buttonDone_GTS.Click += new System.EventHandler(this.buttonDone_GTS_Click);
            // 
            // dataGridViewInPutArray_GTS
            // 
            this.dataGridViewInPutArray_GTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutArray_GTS.ColumnHeadersVisible = false;
            this.dataGridViewInPutArray_GTS.Location = new System.Drawing.Point(274, 46);
            this.dataGridViewInPutArray_GTS.Name = "dataGridViewInPutArray_GTS";
            this.dataGridViewInPutArray_GTS.RowHeadersVisible = false;
            this.dataGridViewInPutArray_GTS.Size = new System.Drawing.Size(287, 177);
            this.dataGridViewInPutArray_GTS.TabIndex = 1;
            // 
            // textBoxCondition_GTS
            // 
            this.textBoxCondition_GTS.Location = new System.Drawing.Point(6, 46);
            this.textBoxCondition_GTS.Multiline = true;
            this.textBoxCondition_GTS.Name = "textBoxCondition_GTS";
            this.textBoxCondition_GTS.ReadOnly = true;
            this.textBoxCondition_GTS.Size = new System.Drawing.Size(240, 385);
            this.textBoxCondition_GTS.TabIndex = 0;
            this.textBoxCondition_GTS.Text = resources.GetString("textBoxCondition_GTS.Text");
            // 
            // groupBoxOutPut_GTS
            // 
            this.groupBoxOutPut_GTS.Controls.Add(this.dataGridViewOutPutArray_GTS);
            this.groupBoxOutPut_GTS.Location = new System.Drawing.Point(607, 21);
            this.groupBoxOutPut_GTS.Name = "groupBoxOutPut_GTS";
            this.groupBoxOutPut_GTS.Size = new System.Drawing.Size(365, 420);
            this.groupBoxOutPut_GTS.TabIndex = 1;
            this.groupBoxOutPut_GTS.TabStop = false;
            this.groupBoxOutPut_GTS.Text = "Вывод данных";
            // 
            // dataGridViewOutPutArray_GTS
            // 
            this.dataGridViewOutPutArray_GTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutArray_GTS.ColumnHeadersVisible = false;
            this.dataGridViewOutPutArray_GTS.Location = new System.Drawing.Point(43, 37);
            this.dataGridViewOutPutArray_GTS.Name = "dataGridViewOutPutArray_GTS";
            this.dataGridViewOutPutArray_GTS.RowHeadersVisible = false;
            this.dataGridViewOutPutArray_GTS.Size = new System.Drawing.Size(287, 177);
            this.dataGridViewOutPutArray_GTS.TabIndex = 2;
            // 
            // FromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.groupBoxOutPut_GTS);
            this.Controls.Add(this.groupBoxInPut_GTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FromMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxInPut_GTS.ResumeLayout(false);
            this.groupBoxInPut_GTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutArray_GTS)).EndInit();
            this.groupBoxOutPut_GTS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutArray_GTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInPut_GTS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GTS;
        private System.Windows.Forms.Button buttonDone_GTS;
        private System.Windows.Forms.DataGridView dataGridViewInPutArray_GTS;
        private System.Windows.Forms.TextBox textBoxCondition_GTS;
        private System.Windows.Forms.DataGridView dataGridViewOutPutArray_GTS;
        private System.Windows.Forms.Button buttonFAQ_GTS;
    }
}

