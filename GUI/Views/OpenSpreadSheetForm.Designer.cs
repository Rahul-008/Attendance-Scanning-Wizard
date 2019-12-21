namespace GUI.Views
{
    partial class OpenSpreadSheetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenSpreadSheetForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDisclaimer = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.panelSectionNameBG = new System.Windows.Forms.Panel();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelSheet = new System.Windows.Forms.Label();
            this.comboBoxSheet = new System.Windows.Forms.ComboBox();
            this.dataGridViewStudenList = new System.Windows.Forms.DataGridView();
            this.labelPreview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudenList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDisclaimer
            // 
            this.labelDisclaimer.AutoSize = true;
            this.labelDisclaimer.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Underline);
            this.labelDisclaimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelDisclaimer.Location = new System.Drawing.Point(25, 27);
            this.labelDisclaimer.Name = "labelDisclaimer";
            this.labelDisclaimer.Size = new System.Drawing.Size(113, 25);
            this.labelDisclaimer.TabIndex = 1;
            this.labelDisclaimer.Text = "Disclaimer";
            // 
            // labelWarning
            // 
            this.labelWarning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWarning.Font = new System.Drawing.Font("Arial", 11F);
            this.labelWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelWarning.Location = new System.Drawing.Point(27, 62);
            this.labelWarning.Margin = new System.Windows.Forms.Padding(10, 10, 30, 10);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(611, 95);
            this.labelWarning.TabIndex = 6;
            this.labelWarning.Text = resources.GetString("labelWarning.Text");
            // 
            // labelFileName
            // 
            this.labelFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelFileName.Location = new System.Drawing.Point(27, 173);
            this.labelFileName.Margin = new System.Windows.Forms.Padding(10, 10, 30, 10);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(92, 19);
            this.labelFileName.TabIndex = 7;
            this.labelFileName.Text = "File name :";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBoxFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFileName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxFileName.Location = new System.Drawing.Point(131, 173);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(447, 19);
            this.textBoxFileName.TabIndex = 13;
            // 
            // panelSectionNameBG
            // 
            this.panelSectionNameBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelSectionNameBG.Location = new System.Drawing.Point(123, 167);
            this.panelSectionNameBG.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panelSectionNameBG.Name = "panelSectionNameBG";
            this.panelSectionNameBG.Size = new System.Drawing.Size(455, 30);
            this.panelSectionNameBG.TabIndex = 14;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.buttonBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonBrowse.Location = new System.Drawing.Point(586, 168);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(52, 26);
            this.buttonBrowse.TabIndex = 15;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonNext.Location = new System.Drawing.Point(441, 218);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(90, 31);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonCancel.Location = new System.Drawing.Point(548, 218);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 31);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelSheet
            // 
            this.labelSheet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSheet.AutoSize = true;
            this.labelSheet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelSheet.Location = new System.Drawing.Point(27, 225);
            this.labelSheet.Margin = new System.Windows.Forms.Padding(10, 10, 30, 10);
            this.labelSheet.Name = "labelSheet";
            this.labelSheet.Size = new System.Drawing.Size(63, 19);
            this.labelSheet.TabIndex = 18;
            this.labelSheet.Text = "Sheet :";
            // 
            // comboBoxSheet
            // 
            this.comboBoxSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.comboBoxSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSheet.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBoxSheet.FormattingEnabled = true;
            this.comboBoxSheet.Location = new System.Drawing.Point(123, 221);
            this.comboBoxSheet.Name = "comboBoxSheet";
            this.comboBoxSheet.Size = new System.Drawing.Size(283, 26);
            this.comboBoxSheet.TabIndex = 16;
            this.comboBoxSheet.SelectedIndexChanged += new System.EventHandler(this.comboBoxSheet_SelectedIndexChanged);
            // 
            // dataGridViewStudenList
            // 
            this.dataGridViewStudenList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridViewStudenList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudenList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudenList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudenList.Location = new System.Drawing.Point(31, 287);
            this.dataGridViewStudenList.Name = "dataGridViewStudenList";
            this.dataGridViewStudenList.ReadOnly = true;
            this.dataGridViewStudenList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewStudenList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStudenList.Size = new System.Drawing.Size(607, 259);
            this.dataGridViewStudenList.TabIndex = 19;
            // 
            // labelPreview
            // 
            this.labelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPreview.AutoSize = true;
            this.labelPreview.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelPreview.Location = new System.Drawing.Point(28, 264);
            this.labelPreview.Margin = new System.Windows.Forms.Padding(10, 10, 30, 10);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(100, 18);
            this.labelPreview.TabIndex = 21;
            this.labelPreview.Text = "File Preview";
            // 
            // OpenSpreadSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(675, 567);
            this.ControlBox = false;
            this.Controls.Add(this.labelPreview);
            this.Controls.Add(this.dataGridViewStudenList);
            this.Controls.Add(this.comboBoxSheet);
            this.Controls.Add(this.labelSheet);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.panelSectionNameBG);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.labelDisclaimer);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenSpreadSheetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenSpreadSheetForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OpenSpreadSheetForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudenList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDisclaimer;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Panel panelSectionNameBG;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelSheet;
        private System.Windows.Forms.ComboBox comboBoxSheet;
        private System.Windows.Forms.DataGridView dataGridViewStudenList;
        private System.Windows.Forms.Label labelPreview;
    }
}