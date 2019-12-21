namespace GUI.Views
{
    partial class EditClassPopupForm
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
            this.comboBoxClassType = new System.Windows.Forms.ComboBox();
            this.labelClassType = new System.Windows.Forms.Label();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.panelRoomNo1BG = new System.Windows.Forms.Panel();
            this.labelRoomNo = new System.Windows.Forms.Label();
            this.comboBoxEndTime = new System.Windows.Forms.ComboBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboBoxStartTime = new System.Windows.Forms.ComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxClassType
            // 
            this.comboBoxClassType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.comboBoxClassType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClassType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClassType.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxClassType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBoxClassType.FormattingEnabled = true;
            this.comboBoxClassType.Items.AddRange(new object[] {
            "Lab",
            "Theory"});
            this.comboBoxClassType.Location = new System.Drawing.Point(149, 169);
            this.comboBoxClassType.Name = "comboBoxClassType";
            this.comboBoxClassType.Size = new System.Drawing.Size(185, 26);
            this.comboBoxClassType.TabIndex = 50;
            // 
            // labelClassType
            // 
            this.labelClassType.AutoSize = true;
            this.labelClassType.Font = new System.Drawing.Font("Arial", 12F);
            this.labelClassType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelClassType.Location = new System.Drawing.Point(37, 172);
            this.labelClassType.Name = "labelClassType";
            this.labelClassType.Size = new System.Drawing.Size(93, 18);
            this.labelClassType.TabIndex = 58;
            this.labelClassType.Text = "Class Type :";
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBoxRoomNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRoomNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxRoomNo.Location = new System.Drawing.Point(158, 219);
            this.textBoxRoomNo.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(177, 19);
            this.textBoxRoomNo.TabIndex = 51;
            // 
            // panelRoomNo1BG
            // 
            this.panelRoomNo1BG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelRoomNo1BG.Location = new System.Drawing.Point(149, 215);
            this.panelRoomNo1BG.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panelRoomNo1BG.Name = "panelRoomNo1BG";
            this.panelRoomNo1BG.Size = new System.Drawing.Size(185, 26);
            this.panelRoomNo1BG.TabIndex = 52;
            // 
            // labelRoomNo
            // 
            this.labelRoomNo.AutoSize = true;
            this.labelRoomNo.Font = new System.Drawing.Font("Arial", 12F);
            this.labelRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelRoomNo.Location = new System.Drawing.Point(37, 219);
            this.labelRoomNo.Name = "labelRoomNo";
            this.labelRoomNo.Size = new System.Drawing.Size(82, 18);
            this.labelRoomNo.TabIndex = 57;
            this.labelRoomNo.Text = "Room No :";
            // 
            // comboBoxEndTime
            // 
            this.comboBoxEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.comboBoxEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEndTime.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBoxEndTime.FormattingEnabled = true;
            this.comboBoxEndTime.Location = new System.Drawing.Point(233, 123);
            this.comboBoxEndTime.Name = "comboBoxEndTime";
            this.comboBoxEndTime.Size = new System.Drawing.Size(101, 26);
            this.comboBoxEndTime.TabIndex = 49;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Arial", 12F);
            this.labelTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelTo.Location = new System.Drawing.Point(205, 127);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(21, 18);
            this.labelTo.TabIndex = 56;
            this.labelTo.Text = "to";
            // 
            // comboBoxStartTime
            // 
            this.comboBoxStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.comboBoxStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStartTime.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBoxStartTime.FormattingEnabled = true;
            this.comboBoxStartTime.Location = new System.Drawing.Point(92, 123);
            this.comboBoxStartTime.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.comboBoxStartTime.Name = "comboBoxStartTime";
            this.comboBoxStartTime.Size = new System.Drawing.Size(101, 26);
            this.comboBoxStartTime.TabIndex = 48;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Arial", 12F);
            this.labelFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelFrom.Location = new System.Drawing.Point(37, 127);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(39, 18);
            this.labelFrom.TabIndex = 55;
            this.labelFrom.Text = "from";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonEdit.Location = new System.Drawing.Point(170, 257);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(76, 27);
            this.buttonEdit.TabIndex = 53;
            this.buttonEdit.Text = "Save";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonCancel.Location = new System.Drawing.Point(259, 257);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 27);
            this.buttonCancel.TabIndex = 54;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Arial", 9F);
            this.datePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.datePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.datePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.datePicker.Font = new System.Drawing.Font("Arial", 9F);
            this.datePicker.Location = new System.Drawing.Point(92, 81);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.datePicker.MinDate = new System.DateTime(2019, 10, 31, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(242, 21);
            this.datePicker.TabIndex = 47;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelDate.Location = new System.Drawing.Point(37, 82);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(50, 18);
            this.labelDate.TabIndex = 46;
            this.labelDate.Text = "Date :";
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelTitle.Location = new System.Drawing.Point(37, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(297, 44);
            this.labelTitle.TabIndex = 59;
            this.labelTitle.Text = "Edit class of ";
            // 
            // EditClassPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(371, 309);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboBoxClassType);
            this.Controls.Add(this.labelClassType);
            this.Controls.Add(this.textBoxRoomNo);
            this.Controls.Add(this.panelRoomNo1BG);
            this.Controls.Add(this.labelRoomNo);
            this.Controls.Add(this.comboBoxEndTime);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.comboBoxStartTime);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.labelDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditClassPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditClassPopupForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EditClassPopupForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClassType;
        private System.Windows.Forms.Label labelClassType;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.Panel panelRoomNo1BG;
        private System.Windows.Forms.Label labelRoomNo;
        private System.Windows.Forms.ComboBox comboBoxEndTime;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboBoxStartTime;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTitle;
    }
}