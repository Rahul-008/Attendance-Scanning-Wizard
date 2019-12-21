namespace GUI.Views
{
    partial class AddStudentForm
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
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.panelNewPasswordBG = new System.Windows.Forms.Panel();
            this.textBoxStudentFirstName = new System.Windows.Forms.TextBox();
            this.panelPasswordBG = new System.Windows.Forms.Panel();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelStudentFirstName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxStudentLastName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStudentLastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBoxStudentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStudentId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxStudentId.Location = new System.Drawing.Point(122, 102);
            this.textBoxStudentId.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(158, 19);
            this.textBoxStudentId.TabIndex = 31;
            this.textBoxStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStudentId_KeyPress);
            // 
            // panelNewPasswordBG
            // 
            this.panelNewPasswordBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelNewPasswordBG.Location = new System.Drawing.Point(115, 97);
            this.panelNewPasswordBG.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panelNewPasswordBG.Name = "panelNewPasswordBG";
            this.panelNewPasswordBG.Size = new System.Drawing.Size(166, 30);
            this.panelNewPasswordBG.TabIndex = 32;
            // 
            // textBoxStudentFirstName
            // 
            this.textBoxStudentFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBoxStudentFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStudentFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxStudentFirstName.Location = new System.Drawing.Point(122, 23);
            this.textBoxStudentFirstName.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.textBoxStudentFirstName.Name = "textBoxStudentFirstName";
            this.textBoxStudentFirstName.Size = new System.Drawing.Size(158, 19);
            this.textBoxStudentFirstName.TabIndex = 29;
            // 
            // panelPasswordBG
            // 
            this.panelPasswordBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelPasswordBG.Location = new System.Drawing.Point(115, 17);
            this.panelPasswordBG.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panelPasswordBG.Name = "panelPasswordBG";
            this.panelPasswordBG.Size = new System.Drawing.Size(166, 30);
            this.panelPasswordBG.TabIndex = 30;
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("Arial", 12F);
            this.labelStudentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelStudentId.Location = new System.Drawing.Point(21, 103);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(31, 18);
            this.labelStudentId.TabIndex = 28;
            this.labelStudentId.Text = "ID :";
            // 
            // labelStudentFirstName
            // 
            this.labelStudentFirstName.AutoSize = true;
            this.labelStudentFirstName.Font = new System.Drawing.Font("Arial", 12F);
            this.labelStudentFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelStudentFirstName.Location = new System.Drawing.Point(21, 24);
            this.labelStudentFirstName.Name = "labelStudentFirstName";
            this.labelStudentFirstName.Size = new System.Drawing.Size(93, 18);
            this.labelStudentFirstName.TabIndex = 27;
            this.labelStudentFirstName.Text = "First Name :";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonCancel.Location = new System.Drawing.Point(203, 140);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 27);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonAdd.Location = new System.Drawing.Point(115, 140);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(76, 27);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxStudentLastName
            // 
            this.textBoxStudentLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBoxStudentLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStudentLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxStudentLastName.Location = new System.Drawing.Point(122, 63);
            this.textBoxStudentLastName.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.textBoxStudentLastName.Name = "textBoxStudentLastName";
            this.textBoxStudentLastName.Size = new System.Drawing.Size(158, 19);
            this.textBoxStudentLastName.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(115, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 30);
            this.panel1.TabIndex = 37;
            // 
            // labelStudentLastName
            // 
            this.labelStudentLastName.AutoSize = true;
            this.labelStudentLastName.Font = new System.Drawing.Font("Arial", 12F);
            this.labelStudentLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelStudentLastName.Location = new System.Drawing.Point(22, 64);
            this.labelStudentLastName.Name = "labelStudentLastName";
            this.labelStudentLastName.Size = new System.Drawing.Size(92, 18);
            this.labelStudentLastName.TabIndex = 35;
            this.labelStudentLastName.Text = "Last Name :";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(309, 182);
            this.Controls.Add(this.textBoxStudentLastName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelStudentLastName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.panelNewPasswordBG);
            this.Controls.Add(this.textBoxStudentFirstName);
            this.Controls.Add(this.panelPasswordBG);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.labelStudentFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddStudentForm_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddStudentForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Panel panelNewPasswordBG;
        private System.Windows.Forms.TextBox textBoxStudentFirstName;
        private System.Windows.Forms.Panel panelPasswordBG;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelStudentFirstName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxStudentLastName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStudentLastName;
    }
}