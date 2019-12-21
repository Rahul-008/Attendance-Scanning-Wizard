using System;

namespace GUI.Views
{
    partial class FormDashboard
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.flowTodaysClass = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTodaysClasses = new System.Windows.Forms.Panel();
            this.labelTodaysClasses = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelYourSections = new System.Windows.Forms.Label();
            this.labelYourSectionsDesc = new System.Windows.Forms.Label();
            this.buttonYourSections = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelSearchDesc = new System.Windows.Forms.Label();
            this.labelAddSection = new System.Windows.Forms.Label();
            this.labelAddSectionDesc = new System.Windows.Forms.Label();
            this.labelAddClasses = new System.Windows.Forms.Label();
            this.labelAddClassesDesc = new System.Windows.Forms.Label();
            this.labelYourClasses = new System.Windows.Forms.Label();
            this.labelYourClassesDesc = new System.Windows.Forms.Label();
            this.buttonYourClasses = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.buttonAddSection = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelTodaysClasses.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelLeft.Controls.Add(this.flowTodaysClass);
            this.panelLeft.Controls.Add(this.panelTodaysClasses);
            this.panelLeft.Controls.Add(this.labelSubtitle);
            this.panelLeft.Controls.Add(this.labelTitle);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 510);
            this.panelLeft.TabIndex = 0;
            // 
            // flowTodaysClass
            // 
            this.flowTodaysClass.AutoScroll = true;
            this.flowTodaysClass.Location = new System.Drawing.Point(0, 188);
            this.flowTodaysClass.Margin = new System.Windows.Forms.Padding(0);
            this.flowTodaysClass.Name = "flowTodaysClass";
            this.flowTodaysClass.Size = new System.Drawing.Size(250, 322);
            this.flowTodaysClass.TabIndex = 5;
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
            this.labelSubtitle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelSubtitle.Location = new System.Drawing.Point(59, 88);
            this.labelSubtitle.Margin = new System.Windows.Forms.Padding(52, 20, 0, 0);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(126, 20);
            this.labelSubtitle.TabIndex = 3;
            this.labelSubtitle.Text = "Automate Your Class";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelTitle.Location = new System.Drawing.Point(53, 30);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(138, 62);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "ASW";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelWelcome.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelWelcome.Location = new System.Drawing.Point(283, 39);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(30, 30, 30, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(542, 33);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome, Faculty";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelWelcome.Click += new System.EventHandler(this.LabelWelcome_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.labelYourSections);
            this.panelRight.Controls.Add(this.labelYourSectionsDesc);
            this.panelRight.Controls.Add(this.buttonYourSections);
            this.panelRight.Controls.Add(this.buttonLogout);
            this.panelRight.Controls.Add(this.labelSearch);
            this.panelRight.Controls.Add(this.labelSearchDesc);
            this.panelRight.Controls.Add(this.labelAddSection);
            this.panelRight.Controls.Add(this.labelAddSectionDesc);
            this.panelRight.Controls.Add(this.labelAddClasses);
            this.panelRight.Controls.Add(this.labelAddClassesDesc);
            this.panelRight.Controls.Add(this.labelYourClasses);
            this.panelRight.Controls.Add(this.labelYourClassesDesc);
            this.panelRight.Controls.Add(this.buttonYourClasses);
            this.panelRight.Controls.Add(this.buttonSearch);
            this.panelRight.Controls.Add(this.buttonAddClass);
            this.panelRight.Controls.Add(this.buttonAddSection);
            this.panelRight.Location = new System.Drawing.Point(248, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(616, 510);
            this.panelRight.TabIndex = 3;
            // 
            // labelYourSections
            // 
            this.labelYourSections.AutoSize = true;
            this.labelYourSections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.labelYourSections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelYourSections.Font = new System.Drawing.Font("Arial", 16F);
            this.labelYourSections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelYourSections.Location = new System.Drawing.Point(65, 152);
            this.labelYourSections.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelYourSections.Name = "labelYourSections";
            this.labelYourSections.Size = new System.Drawing.Size(145, 25);
            this.labelYourSections.TabIndex = 24;
            this.labelYourSections.Text = "Your Sections";
            this.labelYourSections.Click += new System.EventHandler(this.ButtonYourSections_Click);
            // 
            // labelYourSectionsDesc
            // 
            this.labelYourSectionsDesc.AutoSize = true;
            this.labelYourSectionsDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.labelYourSectionsDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelYourSectionsDesc.Font = new System.Drawing.Font("Arial", 9.5F);
            this.labelYourSectionsDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelYourSectionsDesc.Location = new System.Drawing.Point(67, 180);
            this.labelYourSectionsDesc.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelYourSectionsDesc.Name = "labelYourSectionsDesc";
            this.labelYourSectionsDesc.Size = new System.Drawing.Size(104, 16);
            this.labelYourSectionsDesc.TabIndex = 25;
            this.labelYourSectionsDesc.Text = "and student lists";
            this.labelYourSectionsDesc.Click += new System.EventHandler(this.ButtonYourSections_Click);
            // 
            // buttonYourSections
            // 
            this.buttonYourSections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonYourSections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonYourSections.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonYourSections.FlatAppearance.BorderSize = 0;
            this.buttonYourSections.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonYourSections.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonYourSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYourSections.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYourSections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonYourSections.Location = new System.Drawing.Point(40, 121);
            this.buttonYourSections.Margin = new System.Windows.Forms.Padding(3, 0, 30, 0);
            this.buttonYourSections.Name = "buttonYourSections";
            this.buttonYourSections.Size = new System.Drawing.Size(267, 103);
            this.buttonYourSections.TabIndex = 2;
            this.buttonYourSections.UseVisualStyleBackColor = false;
            this.buttonYourSections.Click += new System.EventHandler(this.ButtonYourSections_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLogout.Location = new System.Drawing.Point(502, 457);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 27);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.labelSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSearch.Font = new System.Drawing.Font("Arial", 16F);
            this.labelSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelSearch.Location = new System.Drawing.Point(61, 363);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(80, 25);
            this.labelSearch.TabIndex = 18;
            this.labelSearch.Text = "Search";
            this.labelSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // labelSearchDesc
            // 
            this.labelSearchDesc.AutoSize = true;
            this.labelSearchDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.labelSearchDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSearchDesc.Font = new System.Drawing.Font("Arial", 9.5F);
            this.labelSearchDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelSearchDesc.Location = new System.Drawing.Point(63, 391);
            this.labelSearchDesc.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelSearchDesc.Name = "labelSearchDesc";
            this.labelSearchDesc.Size = new System.Drawing.Size(163, 16);
            this.labelSearchDesc.TabIndex = 19;
            this.labelSearchDesc.Text = "for students by Name or ID";
            this.labelSearchDesc.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // labelAddSection
            // 
            this.labelAddSection.AutoSize = true;
            this.labelAddSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(164)))), ((int)(((byte)(106)))));
            this.labelAddSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAddSection.Font = new System.Drawing.Font("Arial", 16F);
            this.labelAddSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelAddSection.Location = new System.Drawing.Point(65, 255);
            this.labelAddSection.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelAddSection.Name = "labelAddSection";
            this.labelAddSection.Size = new System.Drawing.Size(130, 25);
            this.labelAddSection.TabIndex = 16;
            this.labelAddSection.Text = "Add Section";
            this.labelAddSection.Click += new System.EventHandler(this.ButtonAddSection_Click);
            // 
            // labelAddSectionDesc
            // 
            this.labelAddSectionDesc.AutoSize = true;
            this.labelAddSectionDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(164)))), ((int)(((byte)(106)))));
            this.labelAddSectionDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAddSectionDesc.Font = new System.Drawing.Font("Arial", 9.5F);
            this.labelAddSectionDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelAddSectionDesc.Location = new System.Drawing.Point(67, 283);
            this.labelAddSectionDesc.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelAddSectionDesc.Name = "labelAddSectionDesc";
            this.labelAddSectionDesc.Size = new System.Drawing.Size(219, 16);
            this.labelAddSectionDesc.TabIndex = 17;
            this.labelAddSectionDesc.Text = "from spreadsheet or create manually";
            this.labelAddSectionDesc.Click += new System.EventHandler(this.ButtonAddSection_Click);
            // 
            // labelAddClasses
            // 
            this.labelAddClasses.AutoSize = true;
            this.labelAddClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(94)))), ((int)(((byte)(56)))));
            this.labelAddClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAddClasses.Font = new System.Drawing.Font("Arial", 16F);
            this.labelAddClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelAddClasses.Location = new System.Drawing.Point(331, 255);
            this.labelAddClasses.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelAddClasses.Name = "labelAddClasses";
            this.labelAddClasses.Size = new System.Drawing.Size(111, 25);
            this.labelAddClasses.TabIndex = 14;
            this.labelAddClasses.Text = "Add Class";
            this.labelAddClasses.Click += new System.EventHandler(this.ButtonAddClass_Click);
            // 
            // labelAddClassesDesc
            // 
            this.labelAddClassesDesc.AutoSize = true;
            this.labelAddClassesDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(94)))), ((int)(((byte)(56)))));
            this.labelAddClassesDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAddClassesDesc.Font = new System.Drawing.Font("Arial", 9.5F);
            this.labelAddClassesDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelAddClassesDesc.Location = new System.Drawing.Point(333, 283);
            this.labelAddClassesDesc.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelAddClassesDesc.Name = "labelAddClassesDesc";
            this.labelAddClassesDesc.Size = new System.Drawing.Size(231, 16);
            this.labelAddClassesDesc.TabIndex = 15;
            this.labelAddClassesDesc.Text = "Schedule and extra lecture, lab or quiz";
            this.labelAddClassesDesc.Click += new System.EventHandler(this.ButtonAddClass_Click);
            // 
            // labelYourClasses
            // 
            this.labelYourClasses.AutoSize = true;
            this.labelYourClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.labelYourClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelYourClasses.Font = new System.Drawing.Font("Arial", 16F);
            this.labelYourClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelYourClasses.Location = new System.Drawing.Point(335, 152);
            this.labelYourClasses.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelYourClasses.Name = "labelYourClasses";
            this.labelYourClasses.Size = new System.Drawing.Size(138, 25);
            this.labelYourClasses.TabIndex = 12;
            this.labelYourClasses.Text = "Your Classes";
            this.labelYourClasses.Click += new System.EventHandler(this.ButtonYourClasses_Click);
            // 
            // labelYourClassesDesc
            // 
            this.labelYourClassesDesc.AutoSize = true;
            this.labelYourClassesDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.labelYourClassesDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelYourClassesDesc.Font = new System.Drawing.Font("Arial", 9.5F);
            this.labelYourClassesDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelYourClassesDesc.Location = new System.Drawing.Point(337, 180);
            this.labelYourClassesDesc.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelYourClassesDesc.Name = "labelYourClassesDesc";
            this.labelYourClassesDesc.Size = new System.Drawing.Size(146, 16);
            this.labelYourClassesDesc.TabIndex = 13;
            this.labelYourClassesDesc.Text = "View all of your lectures";
            this.labelYourClassesDesc.Click += new System.EventHandler(this.ButtonYourClasses_Click);
            // 
            // buttonYourClasses
            // 
            this.buttonYourClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.buttonYourClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonYourClasses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonYourClasses.FlatAppearance.BorderSize = 0;
            this.buttonYourClasses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.buttonYourClasses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.buttonYourClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYourClasses.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYourClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonYourClasses.Location = new System.Drawing.Point(310, 121);
            this.buttonYourClasses.Margin = new System.Windows.Forms.Padding(3, 0, 30, 0);
            this.buttonYourClasses.Name = "buttonYourClasses";
            this.buttonYourClasses.Size = new System.Drawing.Size(267, 103);
            this.buttonYourClasses.TabIndex = 3;
            this.buttonYourClasses.UseVisualStyleBackColor = false;
            this.buttonYourClasses.Click += new System.EventHandler(this.ButtonYourClasses_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonSearch.Location = new System.Drawing.Point(40, 333);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(30, 3, 3, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(267, 103);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(94)))), ((int)(((byte)(56)))));
            this.buttonAddClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonAddClass.FlatAppearance.BorderSize = 0;
            this.buttonAddClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(94)))), ((int)(((byte)(56)))));
            this.buttonAddClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(94)))), ((int)(((byte)(56)))));
            this.buttonAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClass.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonAddClass.Location = new System.Drawing.Point(310, 227);
            this.buttonAddClass.Margin = new System.Windows.Forms.Padding(30, 3, 3, 0);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(267, 103);
            this.buttonAddClass.TabIndex = 5;
            this.buttonAddClass.UseVisualStyleBackColor = false;
            this.buttonAddClass.Click += new System.EventHandler(this.ButtonAddClass_Click);
            // 
            // buttonAddSection
            // 
            this.buttonAddSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(164)))), ((int)(((byte)(106)))));
            this.buttonAddSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddSection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonAddSection.FlatAppearance.BorderSize = 0;
            this.buttonAddSection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(164)))), ((int)(((byte)(106)))));
            this.buttonAddSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(164)))), ((int)(((byte)(106)))));
            this.buttonAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSection.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonAddSection.Location = new System.Drawing.Point(40, 227);
            this.buttonAddSection.Margin = new System.Windows.Forms.Padding(3, 3, 30, 0);
            this.buttonAddSection.Name = "buttonAddSection";
            this.buttonAddSection.Size = new System.Drawing.Size(267, 103);
            this.buttonAddSection.TabIndex = 4;
            this.buttonAddSection.UseVisualStyleBackColor = false;
            this.buttonAddSection.Click += new System.EventHandler(this.ButtonAddSection_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(878, 547);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "q";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelTodaysClasses.ResumeLayout(false);
            this.panelTodaysClasses.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Panel panelTodaysClasses;
        private System.Windows.Forms.Label labelTodaysClasses;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button buttonYourClasses;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.Button buttonAddSection;
        private System.Windows.Forms.Label labelYourClasses;
        private System.Windows.Forms.Label labelYourClassesDesc;
        private System.Windows.Forms.Label labelAddClasses;
        private System.Windows.Forms.Label labelAddClassesDesc;
        private System.Windows.Forms.Label labelAddSection;
        private System.Windows.Forms.Label labelAddSectionDesc;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelSearchDesc;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelYourSections;
        private System.Windows.Forms.Label labelYourSectionsDesc;
        private System.Windows.Forms.Button buttonYourSections;
        private System.Windows.Forms.FlowLayoutPanel flowTodaysClass;
    }
}