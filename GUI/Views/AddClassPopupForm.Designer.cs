namespace GUI.Views
{
    partial class AddClassPopupForm
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
            this.labelDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxClassType = new System.Windows.Forms.ComboBox();
            this.labelClassType = new System.Windows.Forms.Label();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.panelRoomNo1BG = new System.Windows.Forms.Panel();
            this.labelRoomNo = new System.Windows.Forms.Label();
            this.comboBoxEndTime = new System.Windows.Forms.ComboBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboBoxStartTime = new System.Windows.Forms.ComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelDate.Location = new System.Drawing.Point(29, 32);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(50, 18);
            this.labelDate.TabIndex = 28;
            this.labelDate.Text = "Date :";
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Arial", 9F);
            this.datePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.datePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.datePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.datePicker.Font = new System.Drawing.Font("Arial", 9F);
            this.datePicker.Location = new System.Drawing.Point(85, 30);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.datePicker.MinDate = new System.DateTime(2019, 10, 31, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(242, 21);
            this.datePicker.TabIndex = 29;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonAdd.Location = new System.Drawing.Point(163, 213);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(76, 27);
            this.buttonAdd.TabIndex = 35;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.buttonCancel.Location = new System.Drawing.Point(251, 213);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 27);
            this.buttonCancel.TabIndex = 36;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
            this.comboBoxClassType.Location = new System.Drawing.Point(142, 117);
            this.comboBoxClassType.Name = "comboBoxClassType";
            this.comboBoxClassType.Size = new System.Drawing.Size(185, 26);
            this.comboBoxClassType.TabIndex = 32;
            // 
            // labelClassType
            // 
            this.labelClassType.AutoSize = true;
            this.labelClassType.Font = new System.Drawing.Font("Arial", 12F);
            this.labelClassType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelClassType.Location = new System.Drawing.Point(29, 120);
            this.labelClassType.Name = "labelClassType";
            this.labelClassType.Size = new System.Drawing.Size(93, 18);
            this.labelClassType.TabIndex = 45;
            this.labelClassType.Text = "Class Type :";
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBoxRoomNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRoomNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxRoomNo.Location = new System.Drawing.Point(150, 167);
            this.textBoxRoomNo.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(177, 19);
            this.textBoxRoomNo.TabIndex = 34;
            // 
            // panelRoomNo1BG
            // 
            this.panelRoomNo1BG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelRoomNo1BG.Location = new System.Drawing.Point(142, 163);
            this.panelRoomNo1BG.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panelRoomNo1BG.Name = "panelRoomNo1BG";
            this.panelRoomNo1BG.Size = new System.Drawing.Size(185, 26);
            this.panelRoomNo1BG.TabIndex = 34;
            // 
            // labelRoomNo
            // 
            this.labelRoomNo.AutoSize = true;
            this.labelRoomNo.Font = new System.Drawing.Font("Arial", 12F);
            this.labelRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelRoomNo.Location = new System.Drawing.Point(29, 167);
            this.labelRoomNo.Name = "labelRoomNo";
            this.labelRoomNo.Size = new System.Drawing.Size(82, 18);
            this.labelRoomNo.TabIndex = 42;
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
            this.comboBoxEndTime.Location = new System.Drawing.Point(226, 71);
            this.comboBoxEndTime.Name = "comboBoxEndTime";
            this.comboBoxEndTime.Size = new System.Drawing.Size(101, 26);
            this.comboBoxEndTime.TabIndex = 31;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Arial", 12F);
            this.labelTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelTo.Location = new System.Drawing.Point(197, 74);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(21, 18);
            this.labelTo.TabIndex = 40;
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
            this.comboBoxStartTime.Location = new System.Drawing.Point(85, 71);
            this.comboBoxStartTime.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.comboBoxStartTime.Name = "comboBoxStartTime";
            this.comboBoxStartTime.Size = new System.Drawing.Size(101, 26);
            this.comboBoxStartTime.TabIndex = 30;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Arial", 12F);
            this.labelFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelFrom.Location = new System.Drawing.Point(29, 74);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(39, 18);
            this.labelFrom.TabIndex = 38;
            this.labelFrom.Text = "from";
            // 
            // AddClassPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.comboBoxClassType);
            this.Controls.Add(this.labelClassType);
            this.Controls.Add(this.textBoxRoomNo);
            this.Controls.Add(this.panelRoomNo1BG);
            this.Controls.Add(this.labelRoomNo);
            this.Controls.Add(this.comboBoxEndTime);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.comboBoxStartTime);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.labelDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClassPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClassPopupForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddClassPopupForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxClassType;
        private System.Windows.Forms.Label labelClassType;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.Panel panelRoomNo1BG;
        private System.Windows.Forms.Label labelRoomNo;
        private System.Windows.Forms.ComboBox comboBoxEndTime;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboBoxStartTime;
        private System.Windows.Forms.Label labelFrom;
    }
}