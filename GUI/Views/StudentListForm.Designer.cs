namespace GUI.Views
{
    partial class FormStudentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentList));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTodaysClasses = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.dataGridViewSln = new System.Windows.Forms.DataGridView();
            this.panelYourSections = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelSearchBG = new System.Windows.Forms.Panel();
            this.labelStudents = new System.Windows.Forms.Label();
            this.buttonSearh = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.flowTodaysClass = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSln)).BeginInit();
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
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 510);
            this.panelLeft.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.labelTodaysClasses);
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 50);
            this.panel2.TabIndex = 4;
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
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel3.Controls.Add(this.dataGridViewStudentList);
            this.panel3.Controls.Add(this.dataGridViewSln);
            this.panel3.Controls.Add(this.panelYourSections);
            this.panel3.Controls.Add(this.labelWelcome);
            this.panel3.Location = new System.Drawing.Point(250, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 510);
            this.panel3.TabIndex = 9;
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.AllowUserToAddRows = false;
            this.dataGridViewStudentList.AllowUserToDeleteRows = false;
            this.dataGridViewStudentList.AllowUserToOrderColumns = true;
            this.dataGridViewStudentList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewStudentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudentList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.dataGridViewStudentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudentList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewStudentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStudentList.ColumnHeadersHeight = 21;
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudentList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStudentList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewStudentList.EnableHeadersVisualStyles = false;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(30, 138);
            this.dataGridViewStudentList.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewStudentList.MultiSelect = false;
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudentList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStudentList.RowHeadersVisible = false;
            this.dataGridViewStudentList.RowHeadersWidth = 51;
            this.dataGridViewStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(586, 372);
            this.dataGridViewStudentList.StandardTab = true;
            this.dataGridViewStudentList.TabIndex = 10;
            // 
            // dataGridViewSln
            // 
            this.dataGridViewSln.AllowUserToAddRows = false;
            this.dataGridViewSln.AllowUserToDeleteRows = false;
            this.dataGridViewSln.AllowUserToOrderColumns = true;
            this.dataGridViewSln.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewSln.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSln.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.dataGridViewSln.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSln.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSln.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSln.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSln.ColumnHeadersHeight = 21;
            this.dataGridViewSln.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSln.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSln.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewSln.EnableHeadersVisualStyles = false;
            this.dataGridViewSln.Location = new System.Drawing.Point(0, 138);
            this.dataGridViewSln.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewSln.MultiSelect = false;
            this.dataGridViewSln.Name = "dataGridViewSln";
            this.dataGridViewSln.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSln.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSln.RowHeadersVisible = false;
            this.dataGridViewSln.RowHeadersWidth = 51;
            this.dataGridViewSln.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewSln.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSln.Size = new System.Drawing.Size(30, 372);
            this.dataGridViewSln.StandardTab = true;
            this.dataGridViewSln.TabIndex = 11;
            // 
            // panelYourSections
            // 
            this.panelYourSections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.panelYourSections.Controls.Add(this.buttonInfo);
            this.panelYourSections.Controls.Add(this.buttonRefresh);
            this.panelYourSections.Controls.Add(this.textBoxSearch);
            this.panelYourSections.Controls.Add(this.panelSearchBG);
            this.panelYourSections.Controls.Add(this.buttonBack);
            this.panelYourSections.Controls.Add(this.labelStudents);
            this.panelYourSections.Controls.Add(this.buttonSearh);
            this.panelYourSections.Location = new System.Drawing.Point(0, 63);
            this.panelYourSections.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panelYourSections.Name = "panelYourSections";
            this.panelYourSections.Size = new System.Drawing.Size(616, 75);
            this.panelYourSections.TabIndex = 7;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.textBoxSearch.Location = new System.Drawing.Point(461, 28);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(144, 19);
            this.textBoxSearch.TabIndex = 13;
            this.textBoxSearch.Text = "Search";
            // 
            // panelSearchBG
            // 
            this.panelSearchBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelSearchBG.Location = new System.Drawing.Point(453, 22);
            this.panelSearchBG.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panelSearchBG.Name = "panelSearchBG";
            this.panelSearchBG.Size = new System.Drawing.Size(152, 30);
            this.panelSearchBG.TabIndex = 14;
            // 
            // labelStudents
            // 
            this.labelStudents.Font = new System.Drawing.Font("Arial", 14F);
            this.labelStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelStudents.Location = new System.Drawing.Point(70, 10);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(293, 54);
            this.labelStudents.TabIndex = 0;
            this.labelStudents.Text = "Students";
            this.labelStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSearh
            // 
            this.buttonSearh.Location = new System.Drawing.Point(500, 35);
            this.buttonSearh.Name = "buttonSearh";
            this.buttonSearh.Size = new System.Drawing.Size(5, 5);
            this.buttonSearh.TabIndex = 0;
            this.buttonSearh.Text = "button1";
            this.buttonSearh.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcome.Font = new System.Drawing.Font("Arial", 12F);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelWelcome.Location = new System.Drawing.Point(35, 16);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(10, 10, 30, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(542, 33);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Faculty";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.AutoPopDelay = 5000;
            this.toolTipInfo.InitialDelay = 100;
            this.toolTipInfo.ReshowDelay = 100;
            this.toolTipInfo.ShowAlways = true;
            // 
            // flowTodaysClass
            // 
            this.flowTodaysClass.AutoScroll = true;
            this.flowTodaysClass.Location = new System.Drawing.Point(0, 188);
            this.flowTodaysClass.Margin = new System.Windows.Forms.Padding(0);
            this.flowTodaysClass.Name = "flowTodaysClass";
            this.flowTodaysClass.Size = new System.Drawing.Size(250, 322);
            this.flowTodaysClass.TabIndex = 8;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo.BackgroundImage")));
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonInfo.Location = new System.Drawing.Point(374, 22);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(26, 28);
            this.buttonInfo.TabIndex = 15;
            this.buttonInfo.UseVisualStyleBackColor = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.BackgroundImage")));
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonRefresh.Location = new System.Drawing.Point(413, 22);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(26, 28);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Image = global::GUI.Properties.Resources.back;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 75);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // FormStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStudentList";
            this.Load += new System.EventHandler(this.FormStudentList_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSln)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.Panel panelYourSections;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelSearchBG;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Label labelWelcome;
        public System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSearh;
        private System.Windows.Forms.DataGridView dataGridViewSln;
        public System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.FlowLayoutPanel flowTodaysClass;
    }
}