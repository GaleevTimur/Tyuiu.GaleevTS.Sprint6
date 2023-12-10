
namespace Tyuiu.GaleevTS.Sprint6.Task6.V28
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelInfo_GTS = new System.Windows.Forms.Panel();
            this.splitterPanel_GTS = new System.Windows.Forms.Splitter();
            this.panelData_GTS = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_GTS = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_GTS = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_GTS = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_GTS = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_GTS = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_GTS = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_GTS = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_GTS = new System.Windows.Forms.ToolTip(this.components);
            this.buttonHelp_GTS = new System.Windows.Forms.Button();
            this.buttonDone_GTS = new System.Windows.Forms.Button();
            this.buttonOpenFile_GTS = new System.Windows.Forms.Button();
            this.panelInfo_GTS.SuspendLayout();
            this.panelData_GTS.SuspendLayout();
            this.groupBoxOutPut_GTS.SuspendLayout();
            this.groupBoxInPut_GTS.SuspendLayout();
            this.groupBoxCondition_GTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo_GTS
            // 
            this.panelInfo_GTS.Controls.Add(this.buttonHelp_GTS);
            this.panelInfo_GTS.Controls.Add(this.buttonDone_GTS);
            this.panelInfo_GTS.Controls.Add(this.buttonOpenFile_GTS);
            this.panelInfo_GTS.Controls.Add(this.splitterPanel_GTS);
            this.panelInfo_GTS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo_GTS.Location = new System.Drawing.Point(0, 0);
            this.panelInfo_GTS.Name = "panelInfo_GTS";
            this.panelInfo_GTS.Size = new System.Drawing.Size(800, 64);
            this.panelInfo_GTS.TabIndex = 0;
            // 
            // splitterPanel_GTS
            // 
            this.splitterPanel_GTS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterPanel_GTS.Location = new System.Drawing.Point(0, 61);
            this.splitterPanel_GTS.Name = "splitterPanel_GTS";
            this.splitterPanel_GTS.Size = new System.Drawing.Size(800, 3);
            this.splitterPanel_GTS.TabIndex = 0;
            this.splitterPanel_GTS.TabStop = false;
            // 
            // panelData_GTS
            // 
            this.panelData_GTS.Controls.Add(this.groupBoxOutPut_GTS);
            this.panelData_GTS.Controls.Add(this.groupBoxInPut_GTS);
            this.panelData_GTS.Controls.Add(this.groupBoxCondition_GTS);
            this.panelData_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData_GTS.Location = new System.Drawing.Point(0, 64);
            this.panelData_GTS.Name = "panelData_GTS";
            this.panelData_GTS.Size = new System.Drawing.Size(800, 386);
            this.panelData_GTS.TabIndex = 1;
            // 
            // groupBoxOutPut_GTS
            // 
            this.groupBoxOutPut_GTS.Controls.Add(this.textBoxOutPut_GTS);
            this.groupBoxOutPut_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_GTS.Location = new System.Drawing.Point(403, 97);
            this.groupBoxOutPut_GTS.Name = "groupBoxOutPut_GTS";
            this.groupBoxOutPut_GTS.Size = new System.Drawing.Size(397, 289);
            this.groupBoxOutPut_GTS.TabIndex = 2;
            this.groupBoxOutPut_GTS.TabStop = false;
            this.groupBoxOutPut_GTS.Text = "Вывод:";
            // 
            // textBoxOutPut_GTS
            // 
            this.textBoxOutPut_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPut_GTS.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutPut_GTS.Multiline = true;
            this.textBoxOutPut_GTS.Name = "textBoxOutPut_GTS";
            this.textBoxOutPut_GTS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_GTS.Size = new System.Drawing.Size(391, 270);
            this.textBoxOutPut_GTS.TabIndex = 1;
            // 
            // groupBoxInPut_GTS
            // 
            this.groupBoxInPut_GTS.Controls.Add(this.textBoxInPut_GTS);
            this.groupBoxInPut_GTS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInPut_GTS.Location = new System.Drawing.Point(0, 97);
            this.groupBoxInPut_GTS.Name = "groupBoxInPut_GTS";
            this.groupBoxInPut_GTS.Size = new System.Drawing.Size(403, 289);
            this.groupBoxInPut_GTS.TabIndex = 1;
            this.groupBoxInPut_GTS.TabStop = false;
            this.groupBoxInPut_GTS.Text = "Ввод:";
            // 
            // textBoxInPut_GTS
            // 
            this.textBoxInPut_GTS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxInPut_GTS.Location = new System.Drawing.Point(3, 78);
            this.textBoxInPut_GTS.Multiline = true;
            this.textBoxInPut_GTS.Name = "textBoxInPut_GTS";
            this.textBoxInPut_GTS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_GTS.Size = new System.Drawing.Size(397, 208);
            this.textBoxInPut_GTS.TabIndex = 0;
            // 
            // groupBoxCondition_GTS
            // 
            this.groupBoxCondition_GTS.Controls.Add(this.textBoxCondition_GTS);
            this.groupBoxCondition_GTS.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCondition_GTS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCondition_GTS.Name = "groupBoxCondition_GTS";
            this.groupBoxCondition_GTS.Size = new System.Drawing.Size(800, 97);
            this.groupBoxCondition_GTS.TabIndex = 0;
            this.groupBoxCondition_GTS.TabStop = false;
            this.groupBoxCondition_GTS.Text = "Условие:";
            // 
            // textBoxCondition_GTS
            // 
            this.textBoxCondition_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCondition_GTS.Location = new System.Drawing.Point(3, 16);
            this.textBoxCondition_GTS.Multiline = true;
            this.textBoxCondition_GTS.Name = "textBoxCondition_GTS";
            this.textBoxCondition_GTS.ReadOnly = true;
            this.textBoxCondition_GTS.Size = new System.Drawing.Size(794, 78);
            this.textBoxCondition_GTS.TabIndex = 0;
            this.textBoxCondition_GTS.Text = resources.GetString("textBoxCondition_GTS.Text");
            // 
            // openFileDialogTask_GTS
            // 
            this.openFileDialogTask_GTS.FileName = "openFileDialog1";
            // 
            // toolTip_GTS
            // 
            this.toolTip_GTS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_GTS.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_GTS
            // 
            this.buttonHelp_GTS.BackColor = System.Drawing.Color.DarkGray;
            this.buttonHelp_GTS.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp_GTS.Image = global::Tyuiu.GaleevTS.Sprint6.Task6.V28.Properties.Resources.help;
            this.buttonHelp_GTS.Location = new System.Drawing.Point(712, 0);
            this.buttonHelp_GTS.Name = "buttonHelp_GTS";
            this.buttonHelp_GTS.Size = new System.Drawing.Size(88, 61);
            this.buttonHelp_GTS.TabIndex = 3;
            this.toolTip_GTS.SetToolTip(this.buttonHelp_GTS, "Сведение о программе");
            this.buttonHelp_GTS.UseVisualStyleBackColor = false;
            this.buttonHelp_GTS.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDone_GTS
            // 
            this.buttonDone_GTS.BackColor = System.Drawing.Color.Silver;
            this.buttonDone_GTS.Enabled = false;
            this.buttonDone_GTS.Image = global::Tyuiu.GaleevTS.Sprint6.Task6.V28.Properties.Resources.page_add;
            this.buttonDone_GTS.Location = new System.Drawing.Point(94, 3);
            this.buttonDone_GTS.Name = "buttonDone_GTS";
            this.buttonDone_GTS.Size = new System.Drawing.Size(93, 58);
            this.buttonDone_GTS.TabIndex = 2;
            this.toolTip_GTS.SetToolTip(this.buttonDone_GTS, "Выводит предпоследнее слово каждой строки в результирующею строку");
            this.buttonDone_GTS.UseVisualStyleBackColor = false;
            this.buttonDone_GTS.Click += new System.EventHandler(this.buttonDone_GTS_Click);
            // 
            // buttonOpenFile_GTS
            // 
            this.buttonOpenFile_GTS.BackColor = System.Drawing.Color.Silver;
            this.buttonOpenFile_GTS.Image = global::Tyuiu.GaleevTS.Sprint6.Task6.V28.Properties.Resources.folder_page;
            this.buttonOpenFile_GTS.Location = new System.Drawing.Point(0, 3);
            this.buttonOpenFile_GTS.Name = "buttonOpenFile_GTS";
            this.buttonOpenFile_GTS.Size = new System.Drawing.Size(88, 58);
            this.buttonOpenFile_GTS.TabIndex = 1;
            this.toolTip_GTS.SetToolTip(this.buttonOpenFile_GTS, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_GTS.UseVisualStyleBackColor = false;
            this.buttonOpenFile_GTS.Click += new System.EventHandler(this.buttonOpenFile_GTS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelData_GTS);
            this.Controls.Add(this.panelInfo_GTS);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 28 | Галеев Т. С.";
            this.panelInfo_GTS.ResumeLayout(false);
            this.panelData_GTS.ResumeLayout(false);
            this.groupBoxOutPut_GTS.ResumeLayout(false);
            this.groupBoxOutPut_GTS.PerformLayout();
            this.groupBoxInPut_GTS.ResumeLayout(false);
            this.groupBoxInPut_GTS.PerformLayout();
            this.groupBoxCondition_GTS.ResumeLayout(false);
            this.groupBoxCondition_GTS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo_GTS;
        private System.Windows.Forms.Button buttonHelp_GTS;
        private System.Windows.Forms.Button buttonDone_GTS;
        private System.Windows.Forms.Button buttonOpenFile_GTS;
        private System.Windows.Forms.Splitter splitterPanel_GTS;
        private System.Windows.Forms.Panel panelData_GTS;
        private System.Windows.Forms.GroupBox groupBoxInPut_GTS;
        private System.Windows.Forms.TextBox textBoxInPut_GTS;
        private System.Windows.Forms.GroupBox groupBoxCondition_GTS;
        private System.Windows.Forms.TextBox textBoxCondition_GTS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_GTS;
        private System.Windows.Forms.ToolTip toolTip_GTS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GTS;
        private System.Windows.Forms.TextBox textBoxOutPut_GTS;
    }
}

