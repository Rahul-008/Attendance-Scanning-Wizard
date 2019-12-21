namespace GUI.Views
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelTodaysClasses = new System.Windows.Forms.Panel();
            this.labelTodaysClasses = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelYourSections = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelYourClasses = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxAcademicId = new System.Windows.Forms.TextBox();
            this.labelAcademicId = new System.Windows.Forms.Label();
            this.panelAcademicIDBG = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panelEmailBG = new System.Windows.Forms.Panel();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.panelLastNameBG = new System.Windows.Forms.Panel();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.panelFirstNameBG = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelTodaysClasses.SuspendLayout();
            this.panelYourSections.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcome.Font = new System.Drawing.Font("Arial", 12F);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelWelcome.Location = new System.Drawing.Point(35, 16);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(10, 10, 30, 10);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(542, 33);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Faculty";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelLeft.Controls.Add(this.panelTodaysClasses);
            this.panelLeft.Controls.Add(this.labelSubtitle);
            this.panelLeft.Controls.Add(this.labelTitle);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 510);
            this.panelLeft.TabIndex = 9;
            // 
            // panelTodaysClasses
            // 
            this.panelTodaysClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panelTodaysClasses.Controls.Add(this.labelTodaysClasses);
            this.panelTodaysClasses.Location = new System.Drawing.Point(0, 138);
            this.panelTodaysClasses.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panelTodaysClasses.Name = "panelTodaysClasses";
            this.panelTodaysClasses.Size = new System.Drawing.Size(250, 50);
            this.panelTodaysClasses.TabIndex = 4;
            // 
            // labelTodaysClasses
            // 
            this.labelTodaysClasses.AutoSize = true;
            this.labelTodaysClasses.Font = new System.Drawing.Font("Arial", 13F);
            this.labelTodaysClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.labelTodaysClasses.Location = new System.Drawing.Point(12, 15);
            this.labelTodaysClasses.Name = "labelTodaysClasses";
            this.labelTodaysClasses.Size = new System.Drawing.Size(140, 21);
            this.labelTodaysClasses.TabIndex = 0;
            this.labelTodaysClasses.Text = "Today\'s Classes";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubtitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSubtitle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelSubtitle.Location = new System.Drawing.Point(59, 88);
            this.labelSubtitle.Margin = new System.Windows.Forms.Padding(52, 20, 0, 0);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(126, 20);
            this.labelSubtitle.TabIndex = 3;
            this.labelSubtitle.Text = "Automate Your Class";
            this.labelSubtitle.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelTitle.Location = new System.Drawing.Point(53, 30);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(138, 62);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "ASW";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // panelYourSections
            // 
            this.panelYourSections.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelYourSections.Controls.Add(this.buttonBack);
            this.panelYourSections.Controls.Add(this.labelYourClasses);
            this.panelYourSections.Location = new System.Drawing.Point(0, 63);
            this.panelYourSections.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panelYourSections.Name = "panelYourSections";
            this.panelYourSections.Size = new System.Drawing.Size(616, 75);
            this.panelYourSections.TabIndex = 7;
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 75);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // labelYourClasses
            // 
            this.labelYourClasses.AutoSize = true;
            this.labelYourClasses.Font = new System.Drawing.Font("Arial", 17F);
            this.labelYourClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelYourClasses.Location = new System.Drawing.Point(81, 25);
            this.labelYourClasses.Name = "labelYourClasses";
            this.labelYourClasses.Size = new System.Drawing.Size(128, 26);
            this.labelYourClasses.TabIndex = 0;
            this.labelYourClasses.Text = "Your Profile";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.buttonReset);
            this.panelRight.Controls.Add(this.buttonSave);
            this.panelRight.Controls.Add(this.buttonChange);
            this.panelRight.Controls.Add(this.labelPassword);
            this.panelRight.Controls.Add(this.textBoxAcademicId);
            this.panelRight.Controls.Add(this.labelAcademicId);
            this.panelRight.Controls.Add(this.panelAcademicIDBG);
            this.panelRight.Controls.Add(this.textBoxEmail);
            this.panelRight.Controls.Add(this.labelEmail);
            this.panelRight.Controls.Add(this.panelEmailBG);
            this.panelRight.Controls.Add(this.textBoxLastName);
            this.panelRight.Controls.Add(this.labelLastName);
            this.panelRight.Controls.Add(this.panelLastNameBG);
            this.panelRight.Controls.Add(this.textBoxFirstName);
            this.panelRight.Controls.Add(this.labelFirstName);
            this.panelRight.Controls.Add(this.panelYourSections);
            this.panelRight.Controls.Add(this.labelWelcome);
            this.panelRight.Controls.Add(this.panelFirstNameBG);
            this.panelRight.Location = new System.Drawing.Point(248, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(616, 510);
            this.panelRight.TabIndex = 10;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonReset.Location = new System.Drawing.Point(502, 453);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 30);
            this.buttonReset.TabIndex = 21;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonSave.Location = new System.Drawing.Point(413, 453);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 30);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.FlatAppearance.BorderSize = 0;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonChange.Location = new System.Drawing.Point(132, 328);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 30);
            this.buttonChange.TabIndex = 12;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelPassword.Location = new System.Drawing.Point(33, 333);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(86, 18);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "Password :";
            // 
            // textBoxAcademicId
            // 
            this.textBoxAcademicId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBoxAcademicId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAcademicId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAcademicId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxAcademicId.Location = new System.Drawing.Point(140, 293);
            this.textBoxAcademicId.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.textBoxAcademicId.Name = "textBoxAcademicId";
            this.textBoxAcademicId.Size = new System.Drawing.Size(437, 19);
            this.textBoxAcademicId.TabIndex = 11;
            this.textBoxAcademicId.Text = "Academic Id";
            // 
            // labelAcademicId
            // 
            this.labelAcademicId.AutoSize = true;
            this.labelAcademicId.Font = new System.Drawing.Font("Arial", 12F);
            this.labelAcademicId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelAcademicId.Location = new System.Drawing.Point(33, 294);
            this.labelAcademicId.Name = "labelAcademicId";
            this.labelAcademicId.Size = new System.Drawing.Size(35, 18);
            this.labelAcademicId.TabIndex = 16;
            this.labelAcademicId.Text = "ID : ";
            // 
            // panelAcademicIDBG
            // 
            this.panelAcademicIDBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelAcademicIDBG.Location = new System.Drawing.Point(132, 287);
            this.panelAcademicIDBG.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.panelAcademicIDBG.Name = "panelAcademicIDBG";
            this.panelAcademicIDBG.Size = new System.Drawing.Size(445, 30);
            this.panelAcademicIDBG.TabIndex = 18;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxEmail.Location = new System.Drawing.Point(140, 253);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(437, 19);
            this.textBoxEmail.TabIndex = 10;
            this.textBoxEmail.Text = "Email";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelEmail.Location = new System.Drawing.Point(33, 254);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(60, 18);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email : ";
            // 
            // panelEmailBG
            // 
            this.panelEmailBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelEmailBG.Location = new System.Drawing.Point(132, 247);
            this.panelEmailBG.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.panelEmailBG.Name = "panelEmailBG";
            this.panelEmailBG.Size = new System.Drawing.Size(445, 30);
            this.panelEmailBG.TabIndex = 15;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxLastName.Location = new System.Drawing.Point(140, 213);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(437, 19);
            this.textBoxLastName.TabIndex = 9;
            this.textBoxLastName.Text = "LastName";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Arial", 12F);
            this.labelLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelLastName.Location = new System.Drawing.Point(33, 214);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(92, 18);
            this.labelLastName.TabIndex = 10;
            this.labelLastName.Text = "Last Name :";
            // 
            // panelLastNameBG
            // 
            this.panelLastNameBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelLastNameBG.Location = new System.Drawing.Point(132, 207);
            this.panelLastNameBG.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.panelLastNameBG.Name = "panelLastNameBG";
            this.panelLastNameBG.Size = new System.Drawing.Size(445, 30);
            this.panelLastNameBG.TabIndex = 12;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxFirstName.Location = new System.Drawing.Point(140, 173);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(437, 19);
            this.textBoxFirstName.TabIndex = 8;
            this.textBoxFirstName.Text = "FirstName";
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Arial", 12F);
            this.labelFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelFirstName.Location = new System.Drawing.Point(33, 174);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(93, 18);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name :";
            // 
            // panelFirstNameBG
            // 
            this.panelFirstNameBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelFirstNameBG.Location = new System.Drawing.Point(132, 167);
            this.panelFirstNameBG.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panelFirstNameBG.Name = "panelFirstNameBG";
            this.panelFirstNameBG.Size = new System.Drawing.Size(445, 30);
            this.panelFirstNameBG.TabIndex = 9;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfile";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelTodaysClasses.ResumeLayout(false);
            this.panelTodaysClasses.PerformLayout();
            this.panelYourSections.ResumeLayout(false);
            this.panelYourSections.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTodaysClasses;
        private System.Windows.Forms.Label labelTodaysClasses;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelYourSections;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelYourClasses;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Panel panelFirstNameBG;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Panel panelLastNameBG;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel panelEmailBG;
        private System.Windows.Forms.Label labelAcademicId;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxAcademicId;
        private System.Windows.Forms.Panel panelAcademicIDBG;
    }
}