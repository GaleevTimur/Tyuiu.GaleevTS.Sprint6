
namespace Tyuiu.GaleevTS.Sprint6.Task7.V9
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
            this.groupBoxInPut_GTS = new System.Windows.Forms.GroupBox();
            this.groupBoxCondition_GTS = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_GTS = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_GTS = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_GTS = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutPut_GTS = new System.Windows.Forms.DataGridView();
            this.splitterGrid_GTS = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_GTS = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_GTS = new System.Windows.Forms.SaveFileDialog();
            this.buttonHelp_GTS = new System.Windows.Forms.Button();
            this.buttonSave_GTS = new System.Windows.Forms.Button();
            this.buttonDone_GTS = new System.Windows.Forms.Button();
            this.buttonOpenFile_GTS = new System.Windows.Forms.Button();
            this.toolTip_GTS = new System.Windows.Forms.ToolTip(this.components);
            this.panelInfo_GTS.SuspendLayout();
            this.panelData_GTS.SuspendLayout();
            this.groupBoxInPut_GTS.SuspendLayout();
            this.groupBoxCondition_GTS.SuspendLayout();
            this.groupBoxOutPut_GTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_GTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_GTS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo_GTS
            // 
            this.panelInfo_GTS.Controls.Add(this.buttonHelp_GTS);
            this.panelInfo_GTS.Controls.Add(this.buttonSave_GTS);
            this.panelInfo_GTS.Controls.Add(this.buttonDone_GTS);
            this.panelInfo_GTS.Controls.Add(this.buttonOpenFile_GTS);
            this.panelInfo_GTS.Controls.Add(this.splitterPanel_GTS);
            this.panelInfo_GTS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo_GTS.Location = new System.Drawing.Point(0, 0);
            this.panelInfo_GTS.Name = "panelInfo_GTS";
            this.panelInfo_GTS.Size = new System.Drawing.Size(800, 74);
            this.panelInfo_GTS.TabIndex = 1;
            // 
            // splitterPanel_GTS
            // 
            this.splitterPanel_GTS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterPanel_GTS.Location = new System.Drawing.Point(0, 71);
            this.splitterPanel_GTS.Name = "splitterPanel_GTS";
            this.splitterPanel_GTS.Size = new System.Drawing.Size(800, 3);
            this.splitterPanel_GTS.TabIndex = 0;
            this.splitterPanel_GTS.TabStop = false;
            // 
            // panelData_GTS
            // 
            this.panelData_GTS.Controls.Add(this.splitterGrid_GTS);
            this.panelData_GTS.Controls.Add(this.groupBoxOutPut_GTS);
            this.panelData_GTS.Controls.Add(this.groupBoxInPut_GTS);
            this.panelData_GTS.Controls.Add(this.groupBoxCondition_GTS);
            this.panelData_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData_GTS.Location = new System.Drawing.Point(0, 74);
            this.panelData_GTS.Name = "panelData_GTS";
            this.panelData_GTS.Size = new System.Drawing.Size(800, 376);
            this.panelData_GTS.TabIndex = 2;
            // 
            // groupBoxInPut_GTS
            // 
            this.groupBoxInPut_GTS.Controls.Add(this.dataGridViewInPut_GTS);
            this.groupBoxInPut_GTS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInPut_GTS.Location = new System.Drawing.Point(0, 97);
            this.groupBoxInPut_GTS.Name = "groupBoxInPut_GTS";
            this.groupBoxInPut_GTS.Size = new System.Drawing.Size(403, 279);
            this.groupBoxInPut_GTS.TabIndex = 1;
            this.groupBoxInPut_GTS.TabStop = false;
            this.groupBoxInPut_GTS.Text = "Ввод:";
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
            // groupBoxOutPut_GTS
            // 
            this.groupBoxOutPut_GTS.Controls.Add(this.dataGridViewOutPut_GTS);
            this.groupBoxOutPut_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_GTS.Location = new System.Drawing.Point(403, 97);
            this.groupBoxOutPut_GTS.Name = "groupBoxOutPut_GTS";
            this.groupBoxOutPut_GTS.Size = new System.Drawing.Size(397, 279);
            this.groupBoxOutPut_GTS.TabIndex = 1;
            this.groupBoxOutPut_GTS.TabStop = false;
            this.groupBoxOutPut_GTS.Text = "Вывод:";
            // 
            // dataGridViewInPut_GTS
            // 
            this.dataGridViewInPut_GTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_GTS.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInPut_GTS.Name = "dataGridViewInPut_GTS";
            this.dataGridViewInPut_GTS.Size = new System.Drawing.Size(397, 260);
            this.dataGridViewInPut_GTS.TabIndex = 0;
            // 
            // dataGridViewOutPut_GTS
            // 
            this.dataGridViewOutPut_GTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_GTS.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPut_GTS.Name = "dataGridViewOutPut_GTS";
            this.dataGridViewOutPut_GTS.Size = new System.Drawing.Size(391, 260);
            this.dataGridViewOutPut_GTS.TabIndex = 1;
            // 
            // splitterGrid_GTS
            // 
            this.splitterGrid_GTS.Location = new System.Drawing.Point(403, 97);
            this.splitterGrid_GTS.Name = "splitterGrid_GTS";
            this.splitterGrid_GTS.Size = new System.Drawing.Size(3, 279);
            this.splitterGrid_GTS.TabIndex = 2;
            this.splitterGrid_GTS.TabStop = false;
            // 
            // openFileDialogTask_GTS
            // 
            this.openFileDialogTask_GTS.FileName = "openFileDialogTask";
            // 
            // buttonHelp_GTS
            // 
            this.buttonHelp_GTS.BackColor = System.Drawing.Color.DarkGray;
            this.buttonHelp_GTS.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_GTS.Image = global::Tyuiu.GaleevTS.Sprint6.Task7.V9.Properties.Resources.help;
            this.buttonHelp_GTS.Location = new System.Drawing.Point(712, 0);
            this.buttonHelp_GTS.Name = "buttonHelp_GTS";
            this.buttonHelp_GTS.Size = new System.Drawing.Size(88, 71);
            this.buttonHelp_GTS.TabIndex = 4;
            this.toolTip_GTS.SetToolTip(this.buttonHelp_GTS, "Разработчик программы");
            this.buttonHelp_GTS.UseVisualStyleBackColor = false;
            this.buttonHelp_GTS.Click += new System.EventHandler(this.buttonHelp_GTS_Click);
            this.buttonHelp_GTS.MouseEnter += new System.EventHandler(this.buttonHelp_GTS_MouseEnter);
            // 
            // buttonSave_GTS
            // 
            this.buttonSave_GTS.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSave_GTS.Enabled = false;
            this.buttonSave_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_GTS.Image = global::Tyuiu.GaleevTS.Sprint6.Task7.V9.Properties.Resources.table_save;
            this.buttonSave_GTS.Location = new System.Drawing.Point(196, 3);
            this.buttonSave_GTS.Name = "buttonSave_GTS";
            this.buttonSave_GTS.Size = new System.Drawing.Size(88, 58);
            this.buttonSave_GTS.TabIndex = 3;
            this.toolTip_GTS.SetToolTip(this.buttonSave_GTS, "Сохраняет файл в формате CSV");
            this.buttonSave_GTS.UseVisualStyleBackColor = false;
            this.buttonSave_GTS.Click += new System.EventHandler(this.buttonSave_GTS_Click);
            this.buttonSave_GTS.MouseEnter += new System.EventHandler(this.buttonSave_GTS_MouseEnter);
            // 
            // buttonDone_GTS
            // 
            this.buttonDone_GTS.BackColor = System.Drawing.Color.Silver;
            this.buttonDone_GTS.Enabled = false;
            this.buttonDone_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_GTS.Image = global::Tyuiu.GaleevTS.Sprint6.Task7.V9.Properties.Resources.page_go;
            this.buttonDone_GTS.Location = new System.Drawing.Point(97, 3);
            this.buttonDone_GTS.Name = "buttonDone_GTS";
            this.buttonDone_GTS.Size = new System.Drawing.Size(93, 58);
            this.buttonDone_GTS.TabIndex = 2;
            this.toolTip_GTS.SetToolTip(this.buttonDone_GTS, "Обрабатывает файл по условию");
            this.buttonDone_GTS.UseVisualStyleBackColor = false;
            this.buttonDone_GTS.Click += new System.EventHandler(this.buttonDone_GTS_Click);
            this.buttonDone_GTS.MouseEnter += new System.EventHandler(this.buttonDone_GTS_MouseEnter);
            // 
            // buttonOpenFile_GTS
            // 
            this.buttonOpenFile_GTS.BackColor = System.Drawing.Color.Silver;
            this.buttonOpenFile_GTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenFile_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_GTS.Image = global::Tyuiu.GaleevTS.Sprint6.Task7.V9.Properties.Resources.folder_page;
            this.buttonOpenFile_GTS.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_GTS.Name = "buttonOpenFile_GTS";
            this.buttonOpenFile_GTS.Size = new System.Drawing.Size(88, 58);
            this.buttonOpenFile_GTS.TabIndex = 1;
            this.toolTip_GTS.SetToolTip(this.buttonOpenFile_GTS, "Открывает файл в формате CSV");
            this.buttonOpenFile_GTS.UseVisualStyleBackColor = false;
            this.buttonOpenFile_GTS.Click += new System.EventHandler(this.buttonOpenFile_GTS_Click);
            this.buttonOpenFile_GTS.MouseEnter += new System.EventHandler(this.buttonOpenFile_GTS_MouseEnter);
            // 
            // toolTip_GTS
            // 
            this.toolTip_GTS.IsBalloon = true;
            this.toolTip_GTS.Tag = "";
            this.toolTip_GTS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelData_GTS);
            this.Controls.Add(this.panelInfo_GTS);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 28 | Галеев Т. С.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelInfo_GTS.ResumeLayout(false);
            this.panelData_GTS.ResumeLayout(false);
            this.groupBoxInPut_GTS.ResumeLayout(false);
            this.groupBoxCondition_GTS.ResumeLayout(false);
            this.groupBoxCondition_GTS.PerformLayout();
            this.groupBoxOutPut_GTS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_GTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_GTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo_GTS;
        private System.Windows.Forms.Button buttonSave_GTS;
        private System.Windows.Forms.Button buttonDone_GTS;
        private System.Windows.Forms.Button buttonOpenFile_GTS;
        private System.Windows.Forms.Splitter splitterPanel_GTS;
        private System.Windows.Forms.Panel panelData_GTS;
        private System.Windows.Forms.Splitter splitterGrid_GTS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GTS;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_GTS;
        private System.Windows.Forms.GroupBox groupBoxInPut_GTS;
        private System.Windows.Forms.DataGridView dataGridViewInPut_GTS;
        private System.Windows.Forms.GroupBox groupBoxCondition_GTS;
        private System.Windows.Forms.TextBox textBoxCondition_GTS;
        private System.Windows.Forms.Button buttonHelp_GTS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_GTS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_GTS;
        private System.Windows.Forms.ToolTip toolTip_GTS;
    }
}

