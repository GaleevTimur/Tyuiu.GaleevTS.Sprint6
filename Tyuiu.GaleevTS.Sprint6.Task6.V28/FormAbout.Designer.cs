
namespace Tyuiu.GaleevTS.Sprint6.Task6.V28
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBoxInfo_GTS = new System.Windows.Forms.TextBox();
            this.buttonClose_GTS = new System.Windows.Forms.Button();
            this.pictureBoxProfile_GTS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile_GTS)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInfo_GTS
            // 
            this.textBoxInfo_GTS.Location = new System.Drawing.Point(284, 12);
            this.textBoxInfo_GTS.Multiline = true;
            this.textBoxInfo_GTS.Name = "textBoxInfo_GTS";
            this.textBoxInfo_GTS.ReadOnly = true;
            this.textBoxInfo_GTS.Size = new System.Drawing.Size(288, 194);
            this.textBoxInfo_GTS.TabIndex = 1;
            this.textBoxInfo_GTS.Text = resources.GetString("textBoxInfo_GTS.Text");
            // 
            // buttonClose_GTS
            // 
            this.buttonClose_GTS.Location = new System.Drawing.Point(442, 212);
            this.buttonClose_GTS.Name = "buttonClose_GTS";
            this.buttonClose_GTS.Size = new System.Drawing.Size(130, 37);
            this.buttonClose_GTS.TabIndex = 2;
            this.buttonClose_GTS.Text = "ОК";
            this.buttonClose_GTS.UseVisualStyleBackColor = true;
            this.buttonClose_GTS.Click += new System.EventHandler(this.buttonClose_GTS_Click);
            // 
            // pictureBoxProfile_GTS
            // 
            this.pictureBoxProfile_GTS.Image = global::Tyuiu.GaleevTS.Sprint6.Task6.V28.Properties.Resources.AQACCjVFilY9tQfBWZnO63NB_Nn4FCReV4vHENhJeJ6zLqLBhoEJT2aAcVEWfIOu155FrW6vSR2F0doiZ_aV_CZAKpA;
            this.pictureBoxProfile_GTS.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxProfile_GTS.Name = "pictureBoxProfile_GTS";
            this.pictureBoxProfile_GTS.Size = new System.Drawing.Size(266, 237);
            this.pictureBoxProfile_GTS.TabIndex = 0;
            this.pictureBoxProfile_GTS.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.buttonClose_GTS);
            this.Controls.Add(this.textBoxInfo_GTS);
            this.Controls.Add(this.pictureBoxProfile_GTS);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile_GTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile_GTS;
        private System.Windows.Forms.TextBox textBoxInfo_GTS;
        private System.Windows.Forms.Button buttonClose_GTS;
    }
}