namespace GUI.Views
{
    partial class YourClassesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YourClassesForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.flowTodaysClass = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTodaysClasses = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelClasses = new System.Windows.Forms.FlowLayoutPanel();
            this.panelYourSections = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelYourClasses = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelYourSections.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelLeft.Controls.Add(this.flowTodaysClass);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Controls.Add(this.labelSubtitle);
            this.panelLeft.Controls.Add(this.labelTitle);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(333, 628);
            this.panelLeft.TabIndex = 7;
            // 
            // flowTodaysClass
            // 
            this.flowTodaysClass.AutoScroll = true;
            this.flowTodaysClass.Location = new System.Drawing.Point(0, 232);
            this.flowTodaysClass.Margin = new System.Windows.Forms.Padding(0);
            this.flowTodaysClass.Name = "flowTodaysClass";
            this.flowTodaysClass.Size = new System.Drawing.Size(333, 396);
            this.flowTodaysClass.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.labelTodaysClasses);
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 37, 0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 62);
            this.panel2.TabIndex = 4;
            // 
            // labelTodaysClasses
            // 
            this.labelTodaysClasses.AutoSize = true;
            this.labelTodaysClasses.Font = new System.Drawing.Font("Arial", 13F);
            this.labelTodaysClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.labelTodaysClasses.Location = new System.Drawing.Point(16, 18);
            this.labelTodaysClasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTodaysClasses.Name = "labelTodaysClasses";
            this.labelTodaysClasses.Size = new System.Drawing.Size(170, 25);
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
            this.labelSubtitle.Location = new System.Drawing.Point(79, 108);
            this.labelSubtitle.Margin = new System.Windows.Forms.Padding(69, 25, 0, 0);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(168, 25);
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
            this.labelTitle.Location = new System.Drawing.Point(71, 37);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(67, 0, 67, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(170, 78);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "ASW";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanelClasses);
            this.panel3.Controls.Add(this.panelYourSections);
            this.panel3.Controls.Add(this.labelWelcome);
            this.panel3.Location = new System.Drawing.Point(331, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(821, 628);
            this.panel3.TabIndex = 8;
            // 
            // flowLayoutPanelClasses
            // 
            this.flowLayoutPanelClasses.AutoScroll = true;
            this.flowLayoutPanelClasses.Location = new System.Drawing.Point(0, 170);
            this.flowLayoutPanelClasses.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelClasses.Name = "flowLayoutPanelClasses";
            this.flowLayoutPanelClasses.Size = new System.Drawing.Size(821, 458);
            this.flowLayoutPanelClasses.TabIndex = 8;
            // 
            // panelYourSections
            // 
            this.panelYourSections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.panelYourSections.Controls.Add(this.buttonRefresh);
            this.panelYourSections.Controls.Add(this.buttonAddClass);
            this.panelYourSections.Controls.Add(this.buttonLogin);
            this.panelYourSections.Controls.Add(this.buttonBack);
            this.panelYourSections.Controls.Add(this.labelYourClasses);
            this.panelYourSections.Location = new System.Drawing.Point(0, 78);
            this.panelYourSections.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.panelYourSections.Name = "panelYourSections";
            this.panelYourSections.Size = new System.Drawing.Size(821, 92);
            this.panelYourSections.TabIndex = 7;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonRefresh.Location = new System.Drawing.Point(416, 30);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(73, 32, 0, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 33);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAddClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.buttonAddClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClass.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonAddClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonAddClass.Location = new System.Drawing.Point(531, 30);
            this.buttonAddClass.Margin = new System.Windows.Forms.Padding(73, 32, 0, 0);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(125, 33);
            this.buttonAddClass.TabIndex = 7;
            this.buttonAddClass.Text = "Add Class";
            this.buttonAddClass.UseVisualStyleBackColor = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLogin.Location = new System.Drawing.Point(669, 30);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(73, 32, 0, 0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 33);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "View All";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 92);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // labelYourClasses
            // 
            this.labelYourClasses.AutoSize = true;
            this.labelYourClasses.Font = new System.Drawing.Font("Arial", 17F);
            this.labelYourClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelYourClasses.Location = new System.Drawing.Point(108, 31);
            this.labelYourClasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYourClasses.Name = "labelYourClasses";
            this.labelYourClasses.Size = new System.Drawing.Size(186, 33);
            this.labelYourClasses.TabIndex = 0;
            this.labelYourClasses.Text = "Your Classes";
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcome.Font = new System.Drawing.Font("Arial", 12F);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelWelcome.Location = new System.Drawing.Point(47, 20);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(13, 12, 40, 12);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(723, 41);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Faculty";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YourClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1152, 629);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "YourClassesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormYourClasses";
            this.Load += new System.EventHandler(this.YourClassesForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelYourSections.ResumeLayout(false);
            this.panelYourSections.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTodaysClasses;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelYourSections;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelYourClasses;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelClasses;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.FlowLayoutPanel flowTodaysClass;
    }
}