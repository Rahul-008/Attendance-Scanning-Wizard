using System;

namespace GUI.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.textBoxConfirmPassSignUp = new System.Windows.Forms.TextBox();
            this.panelConfirmPassSignUpUnderline = new System.Windows.Forms.Panel();
            this.textBoxPassSignUp = new System.Windows.Forms.TextBox();
            this.panelPassSignUpUnderline = new System.Windows.Forms.Panel();
            this.textBoxEmailSignup = new System.Windows.Forms.TextBox();
            this.panelEmailSignUpUnderline = new System.Windows.Forms.Panel();
            this.textBoxLastNameSignUp = new System.Windows.Forms.TextBox();
            this.panelLastNameSignUpUnderline = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.textBoxFirstNameSignUp = new System.Windows.Forms.TextBox();
            this.panelFirstNameSignUpUnderline = new System.Windows.Forms.Panel();
            this.textBoxAcademicIdSignUp = new System.Windows.Forms.TextBox();
            this.panelIdSignUpUnderline = new System.Windows.Forms.Panel();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.panelResetPassword = new System.Windows.Forms.Panel();
            this.buttonCancelReset = new System.Windows.Forms.Button();
            this.buttonResetPassword = new System.Windows.Forms.Button();
            this.textBoxEmailReset = new System.Windows.Forms.TextBox();
            this.panelEmailResetUnderline = new System.Windows.Forms.Panel();
            this.labelResetPassword = new System.Windows.Forms.Label();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.labelNewtoASW = new System.Windows.Forms.Label();
            this.buttonForgotPassword = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelPasswordUnderline = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panelEmailUnderline = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.timerLoginPanelSlider = new System.Windows.Forms.Timer(this.components);
            this.timerLoginPanelSliderReverse = new System.Windows.Forms.Timer(this.components);
            this.timerResetPasswordSlider = new System.Windows.Forms.Timer(this.components);
            this.timerResetPasswordSliderReverse = new System.Windows.Forms.Timer(this.components);
            this.toolTipWarning = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPass = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEmail = new System.Windows.Forms.ToolTip(this.components);
            this.panelLogin.SuspendLayout();
            this.panelSignUp.SuspendLayout();
            this.panelResetPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelLogin.Controls.Add(this.panelSignUp);
            this.panelLogin.Controls.Add(this.panelResetPassword);
            this.panelLogin.Controls.Add(this.buttonCreateAccount);
            this.panelLogin.Controls.Add(this.labelNewtoASW);
            this.panelLogin.Controls.Add(this.buttonForgotPassword);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.panelPasswordUnderline);
            this.panelLogin.Controls.Add(this.textBoxEmail);
            this.panelLogin.Controls.Add(this.panelEmailUnderline);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Controls.Add(this.pictureBox2);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Location = new System.Drawing.Point(687, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(467, 638);
            this.panelLogin.TabIndex = 0;
            // 
            // panelSignUp
            // 
            this.panelSignUp.Controls.Add(this.textBoxConfirmPassSignUp);
            this.panelSignUp.Controls.Add(this.panelConfirmPassSignUpUnderline);
            this.panelSignUp.Controls.Add(this.textBoxPassSignUp);
            this.panelSignUp.Controls.Add(this.panelPassSignUpUnderline);
            this.panelSignUp.Controls.Add(this.textBoxEmailSignup);
            this.panelSignUp.Controls.Add(this.panelEmailSignUpUnderline);
            this.panelSignUp.Controls.Add(this.textBoxLastNameSignUp);
            this.panelSignUp.Controls.Add(this.panelLastNameSignUpUnderline);
            this.panelSignUp.Controls.Add(this.buttonCancel);
            this.panelSignUp.Controls.Add(this.buttonSignUp);
            this.panelSignUp.Controls.Add(this.textBoxFirstNameSignUp);
            this.panelSignUp.Controls.Add(this.panelFirstNameSignUpUnderline);
            this.panelSignUp.Controls.Add(this.textBoxAcademicIdSignUp);
            this.panelSignUp.Controls.Add(this.panelIdSignUpUnderline);
            this.panelSignUp.Controls.Add(this.labelSignUp);
            this.panelSignUp.Location = new System.Drawing.Point(467, 0);
            this.panelSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(467, 638);
            this.panelSignUp.TabIndex = 21;
            // 
            // textBoxConfirmPassSignUp
            // 
            this.textBoxConfirmPassSignUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxConfirmPassSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.textBoxConfirmPassSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmPassSignUp.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxConfirmPassSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.textBoxConfirmPassSignUp.Location = new System.Drawing.Point(79, 422);
            this.textBoxConfirmPassSignUp.Margin = new System.Windows.Forms.Padding(80, 25, 0, 0);
            this.textBoxConfirmPassSignUp.Name = "textBoxConfirmPassSignUp";
            this.textBoxConfirmPassSignUp.Size = new System.Drawing.Size(313, 22);
            this.textBoxConfirmPassSignUp.TabIndex = 34;
            this.textBoxConfirmPassSignUp.Text = "Confirm Password";
            this.textBoxConfirmPassSignUp.Click += new System.EventHandler(this.ButtonCancelReset_Click);
            this.textBoxConfirmPassSignUp.Enter += new System.EventHandler(this.TextBoxConfirmPassSignUp_Click);
            this.textBoxConfirmPassSignUp.Leave += new System.EventHandler(this.TextBoxConfirmPassSignUp_Leave);
            // 
            // panelConfirmPassSignUpUnderline
            // 
            this.panelConfirmPassSignUpUnderline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelConfirmPassSignUpUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panelConfirmPassSignUpUnderline.Location = new System.Drawing.Point(72, 448);
            this.panelConfirmPassSignUpUnderline.Margin = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.panelConfirmPassSignUpUnderline.Name = "panelConfirmPassSignUpUnderline";
            this.panelConfirmPassSignUpUnderline.Size = new System.Drawing.Size(327, 1);
            this.panelConfirmPassSignUpUnderline.TabIndex = 33;
            // 
            // textBoxPassSignUp
            // 
            this.textBoxPassSignUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.textBoxPassSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassSignUp.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxPassSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.textBoxPassSignUp.Location = new System.Drawing.Point(79, 372);
            this.textBoxPassSignUp.Margin = new System.Windows.Forms.Padding(80, 25, 0, 0);
            this.textBoxPassSignUp.Name = "textBoxPassSignUp";
            this.textBoxPassSignUp.Size = new System.Drawing.Size(313, 22);
            this.textBoxPassSignUp.TabIndex = 32;
            this.textBoxPassSignUp.Text = "Password";
            this.textBoxPassSignUp.Click += new System.EventHandler(this.TextBoxPassSignUp_Click);
            this.textBoxPassSignUp.Enter += new System.EventHandler(this.TextBoxPassSignUp_Click);
            this.textBoxPassSignUp.Leave += new System.EventHandler(this.TextBoxPassSignUp_Leave);
            this.textBoxPassSignUp.MouseHover += new System.EventHandler(this.textBoxPassSignUp_MouseHover);
            // 
            // panelPassSignUpUnderline
            // 
            this.panelPassSignUpUnderline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelPassSignUpUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panelPassSignUpUnderline.Location = new System.Drawing.Point(72, 398);
            this.panelPassSignUpUnderline.Margin = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.panelPassSignUpUnderline.Name = "panelPassSignUpUnderline";
            this.panelPassSignUpUnderline.Size = new System.Drawing.Size(327, 1);
            this.panelPassSignUpUnderline.TabIndex = 31;
            // 
            // textBoxEmailSignup
            // 
            this.textBoxEmailSignup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEmailSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.textBoxEmailSignup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmailSignup.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxEmailSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.textBoxEmailSignup.Location = new System.Drawing.Point(79, 321);
            this.textBoxEmailSignup.Margin = new System.Windows.Forms.Padding(80, 25, 0, 0);
            this.textBoxEmailSignup.Name = "textBoxEmailSignup";
            this.textBoxEmailSignup.Size = new System.Drawing.Size(313, 22);
            this.textBoxEmailSignup.TabIndex = 30;
            this.textBoxEmailSignup.Text = "Academic Email";
            this.textBoxEmailSignup.Click += new System.EventHandler(this.TextBoxEmailSignup_Click);
            this.textBoxEmailSignup.Enter += new System.EventHandler(this.TextBoxEmailSignup_Click);
            this.textBoxEmailSignup.Leave += new System.EventHandler(this.TextBoxEmailSignup_Leave);
            this.textBoxEmailSignup.MouseHover += new System.EventHandler(this.textBoxEmailSignup_MouseHover);
            // 
            // panelEmailSignUpUnderline
            // 
            this.panelEmailSignUpUnderline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelEmailSignUpUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panelEmailSignUpUnderline.Location = new System.Drawing.Point(72, 347);
            this.panelEmailSignUpUnderline.Margin = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.panelEmailSignUpUnderline.Name = "panelEmailSignUpUnderline";
            this.panelEmailSignUpUnderline.Size = new System.Drawing.Size(327, 1);
            this.panelEmailSignUpUnderline.TabIndex = 29;
            // 
            // textBoxLastNameSignUp
            // 
            this.textBoxLastNameSignUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLastNameSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.textBoxLastNameSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastNameSignUp.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxLastNameSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.textBoxLastNameSignUp.Location = new System.Drawing.Point(79, 272);
            this.textBoxLastNameSignUp.Margin = new System.Windows.Forms.Padding(80, 25, 0, 0);
            this.textBoxLastNameSignUp.Name = "textBoxLastNameSignUp";
            this.textBoxLastNameSignUp.Size = new System.Drawing.Size(313, 22);
            this.textBoxLastNameSignUp.TabIndex = 28;
            this.textBoxLastNameSignUp.Text = "Last Name";
            this.textBoxLastNameSignUp.Click += new System.EventHandler(this.TextBoxLastNameSignUp_Click);
            this.textBoxLastNameSignUp.Enter += new System.EventHandler(this.TextBoxLastNameSignUp_Click);
            this.textBoxLastNameSignUp.Leave += new System.EventHandler(this.TextBoxLastNameSignUp_Leave);
            // 
            // panelLastNameSignUpUnderline
            // 
            this.panelLastNameSignUpUnderline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelLastNameSignUpUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panelLastNameSignUpUnderline.Location = new System.Drawing.Point(72, 298);
            this.panelLastNameSignUpUnderline.Margin = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.panelLastNameSignUpUnderline.Name = "panelLastNameSignUpUnderline";
            this.panelLastNameSignUpUnderline.Size = new System.Drawing.Size(327, 1);
            this.panelLastNameSignUpUnderline.TabIndex = 27;
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
            this.buttonCancel.Location = new System.Drawing.Point(300, 478);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(73, 32, 0, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 33);
            this.buttonCancel.TabIndex = 36;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click_1);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignUp.FlatAppearance.BorderSize = 0;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUp.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonSignUp.Location = new System.Drawing.Point(73, 479);
            this.buttonSignUp.Margin = new System.Windows.Forms.Padding(73, 32, 0, 0);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(100, 33);
            this.buttonSignUp.TabIndex = 35;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // textBoxFirstNameSignUp
            // 
            this.textBoxFirstNameSignUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFirstNameSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.textBoxFirstNameSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstNameSignUp.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxFirstNameSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.textBoxFirstNameSignUp.Location = new System.Drawing.Point(80, 220);
            this.textBoxFirstNameSignUp.Margin = new System.Windows.Forms.Padding(80, 25, 0, 0);
            this.textBoxFirstNameSignUp.Name = "textBoxFirstNameSignUp";
            this.textBoxFirstNameSignUp.Size = new System.Drawing.Size(313, 22);
            this.textBoxFirstNameSignUp.TabIndex = 26;
            this.textBoxFirstNameSignUp.Text = "First Name";
            this.textBoxFirstNameSignUp.Click += new System.EventHandler(this.TextBoxFirstNameSignUp_Click);
            this.textBoxFirstNameSignUp.Enter += new System.EventHandler(this.TextBoxFirstNameSignUp_Click);
            this.textBoxFirstNameSignUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxFirstNameSignUp_KeyDown);
            this.textBoxFirstNameSignUp.Leave += new System.EventHandler(this.TextBoxFirstNameSignUp_Leave);
            this.textBoxFirstNameSignUp.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TextBoxFirstNameSignUp_PreviewKeyDown);
            // 
            // panelFirstNameSignUpUnderline
            // 
            this.panelFirstNameSignUpUnderline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelFirstNameSignUpUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panelFirstNameSignUpUnderline.Location = new System.Drawing.Point(73, 246);
            this.panelFirstNameSignUpUnderline.Margin = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.panelFirstNameSignUpUnderline.Name = "panelFirstNameSignUpUnderline";
            this.panelFirstNameSignUpUnderline.Size = new System.Drawing.Size(327, 1);
            this.panelFirstNameSignUpUnderline.TabIndex = 25;
            // 
            // textBoxAcademicIdSignUp
            // 
            this.textBoxAcademicIdSignUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAcademicIdSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.textBoxAcademicIdSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAcademicIdSignUp.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxAcademicIdSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.textBoxAcademicIdSignUp.Location = new System.Drawing.Point(80, 171);
            this.textBoxAcademicIdSignUp.Margin = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.textBoxAcademicIdSignUp.Name = "textBoxAcademicIdSignUp";
            this.textBoxAcademicIdSignUp.Size = new System.Drawing.Size(313, 22);
            this.textBoxAcademicIdSignUp.TabIndex = 24;
            this.textBoxAcademicIdSignUp.Text = "Academic ID";
            this.textBoxAcademicIdSignUp.Click += new System.EventHandler(this.TextBoxIdSignUp_Click);
            this.textBoxAcademicIdSignUp.TextChanged += new System.EventHandler(this.TextBoxIdSignUp_TextChanged);
            this.textBoxAcademicIdSignUp.Enter += new System.EventHandler(this.TextBoxIdSignUp_Click);
            this.textBoxAcademicIdSignUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAcademicIdSignUp_KeyPress);
            this.textBoxAcademicIdSignUp.Leave += new System.EventHandler(this.TextBoxIdSignUp_Leave);
            this.textBoxAcademicIdSignUp.MouseHover += new System.EventHandler(this.textBoxAcademicIdSignUp_MouseHover);
            // 
            // panelIdSignUpUnderline
            // 
            this.panelIdSignUpUnderline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelIdSignUpUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panelIdSignUpUnderline.Location = new System.Drawing.Point(73, 197);
            this.panelIdSignUpUnderline.Margin = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.panelIdSignUpUnderline.Name = "panelIdSignUpUnderline";
            this.panelIdSignUpUnderline.Size = new System.Drawing.Size(327, 1);
            this.panelIdSignUpUnderline.TabIndex = 23;
            // 
            // labelSignUp
            // 
            this.labelSignUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSignUp.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelSignUp.Location = new System.Drawing.Point(67, 113);
            this.labelSignUp.Margin = new System.Windows.Forms.Padding(67, 0, 0, 32);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(99, 26);
            this.labelSignUp.TabIndex = 22;
            this.labelSignUp.Text = "Sign Up";
            // 
            // panelResetPassword
            // 
            this.panelResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelResetPassword.Controls.Add(this.buttonCancelReset);
            this.panelResetPassword.Controls.Add(this.buttonResetPassword);
            this.panelResetPassword.Controls.Add(this.textBoxEmailReset);
            this.panelResetPassword.Controls.Add(this.panelEmailResetUnderline);
            this.panelResetPassword.Controls.Add(this.labelResetPassword);
            this.panelResetPassword.Location = new System.Drawing.Point(-467, 0);
            this.panelResetPassword.Margin = new System.Windows.Forms.Padding(0);
            this.panelResetPassword.Name = "panelResetPassword";
            this.panelResetPassword.Size = new System.Drawing.Size(467, 638);
            this.panelResetPassword.TabIndex = 22;
            // 
            // buttonCancelReset
            // 
            this.buttonCancelReset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCancelReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonCancelReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelReset.FlatAppearance.BorderSize = 0;
            this.buttonCancelReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelReset.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonCancelReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonCancelReset.Location = new System.Drawing.Point(64, 420);
            this.buttonCancelReset.Margin = new System.Windows.Forms.Padding(73, 25, 0, 0);
            this.buttonCancelReset.Name = "buttonCancelReset";
            this.buttonCancelReset.Size = new System.Drawing.Size(328, 42);
            this.buttonCancelReset.TabIndex = 24;
            this.buttonCancelReset.Text = "Cancel";
            this.buttonCancelReset.UseVisualStyleBackColor = false;
            this.buttonCancelReset.Click += new System.EventHandler(this.ButtonCancelReset_Click);
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetPassword.FlatAppearance.BorderSize = 0;
            this.buttonResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonResetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonResetPassword.Location = new System.Drawing.Point(64, 353);
            this.buttonResetPassword.Margin = new System.Windows.Forms.Padding(73, 25, 0, 0);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(328, 42);
            this.buttonResetPassword.TabIndex = 22;
            this.buttonResetPassword.Text = "Reset Password";
            this.buttonResetPassword.UseVisualStyleBackColor = false;
            this.buttonResetPassword.Click += new System.EventHandler(this.ButtonResetPassword_Click);
            // 
            // textBoxEmailReset
            // 
            this.textBoxEmailReset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEmailReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.textBoxEmailReset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmailReset.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxEmailReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.textBoxEmailReset.Location = new System.Drawing.Point(72, 283);
            this.textBoxEmailReset.Margin = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.textBoxEmailReset.Name = "textBoxEmailReset";
            this.textBoxEmailReset.Size = new System.Drawing.Size(313, 22);
            this.textBoxEmailReset.TabIndex = 23;
            this.textBoxEmailReset.Text = "Enter email to continue";
            this.textBoxEmailReset.Click += new System.EventHandler(this.TextBoxEmailReset_Click);
            // 
            // panelEmailResetUnderline
            // 
            this.panelEmailResetUnderline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelEmailResetUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panelEmailResetUnderline.Location = new System.Drawing.Point(65, 309);
            this.panelEmailResetUnderline.Margin = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.panelEmailResetUnderline.Name = "panelEmailResetUnderline";
            this.panelEmailResetUnderline.Size = new System.Drawing.Size(327, 1);
            this.panelEmailResetUnderline.TabIndex = 22;
            // 
            // labelResetPassword
            // 
            this.labelResetPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResetPassword.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelResetPassword.Location = new System.Drawing.Point(67, 212);
            this.labelResetPassword.Margin = new System.Windows.Forms.Padding(67, 0, 0, 32);
            this.labelResetPassword.Name = "labelResetPassword";
            this.labelResetPassword.Size = new System.Drawing.Size(209, 26);
            this.labelResetPassword.TabIndex = 1;
            this.labelResetPassword.Text = "Reset Password";
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateAccount.FlatAppearance.BorderSize = 0;
            this.buttonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonCreateAccount.Location = new System.Drawing.Point(72, 453);
            this.buttonCreateAccount.Margin = new System.Windows.Forms.Padding(73, 25, 0, 0);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(328, 42);
            this.buttonCreateAccount.TabIndex = 8;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.ButtonCreateAccount_Click);
            // 
            // labelNewtoASW
            // 
            this.labelNewtoASW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNewtoASW.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewtoASW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelNewtoASW.Location = new System.Drawing.Point(67, 402);
            this.labelNewtoASW.Margin = new System.Windows.Forms.Padding(67, 0, 0, 0);
            this.labelNewtoASW.Name = "labelNewtoASW";
            this.labelNewtoASW.Size = new System.Drawing.Size(333, 26);
            this.labelNewtoASW.TabIndex = 7;
            this.labelNewtoASW.Text = "New to ASW?";
            // 
            // buttonForgotPassword
            // 
            this.buttonForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonForgotPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonForgotPassword.FlatAppearance.BorderSize = 0;
            this.buttonForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForgotPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.buttonForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonForgotPassword.Location = new System.Drawing.Point(243, 327);
            this.buttonForgotPassword.Margin = new System.Windows.Forms.Padding(0, 0, 67, 0);
            this.buttonForgotPassword.Name = "buttonForgotPassword";
            this.buttonForgotPassword.Size = new System.Drawing.Size(157, 33);
            this.buttonForgotPassword.TabIndex = 6;
            this.buttonForgotPassword.Text = "Forgot Password?";
            this.buttonForgotPassword.UseVisualStyleBackColor = false;
            this.buttonForgotPassword.Click += new System.EventHandler(this.ButtonForgotPassword_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLogin.Location = new System.Drawing.Point(73, 327);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(73, 32, 0, 0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 33);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            this.buttonLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonLogin_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.textBoxPassword.Location = new System.Drawing.Point(80, 270);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(313, 22);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Click += new System.EventHandler(this.TextBoxPassword_Click);
            this.textBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Click);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            this.textBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // panelPasswordUnderline
            // 
            this.panelPasswordUnderline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelPasswordUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panelPasswordUnderline.Location = new System.Drawing.Point(73, 295);
            this.panelPasswordUnderline.Margin = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.panelPasswordUnderline.Name = "panelPasswordUnderline";
            this.panelPasswordUnderline.Size = new System.Drawing.Size(327, 1);
            this.panelPasswordUnderline.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.textBoxEmail.Location = new System.Drawing.Point(80, 220);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(313, 22);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.Click += new System.EventHandler(this.TextBoxEmail_Click);
            this.textBoxEmail.Enter += new System.EventHandler(this.TextBoxEmail_Click);
            this.textBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEmail_KeyDown);
            this.textBoxEmail.Leave += new System.EventHandler(this.TextBoxEmail_Leave);
            // 
            // panelEmailUnderline
            // 
            this.panelEmailUnderline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelEmailUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panelEmailUnderline.Location = new System.Drawing.Point(73, 246);
            this.panelEmailUnderline.Margin = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.panelEmailUnderline.Name = "panelEmailUnderline";
            this.panelEmailUnderline.Size = new System.Drawing.Size(327, 1);
            this.panelEmailUnderline.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLogin.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelLogin.Location = new System.Drawing.Point(67, 162);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(67, 0, 0, 32);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(72, 26);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 263);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 217);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelTitle.Location = new System.Drawing.Point(67, 279);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(67, 0, 40, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(498, 40);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Attendance Scanning Wizard";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelSubtitle.Location = new System.Drawing.Point(69, 345);
            this.labelSubtitle.Margin = new System.Windows.Forms.Padding(69, 25, 0, 0);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(201, 22);
            this.labelSubtitle.TabIndex = 2;
            this.labelSubtitle.Text = "Automate Your Class";
            // 
            // panelTitle
            // 
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(687, 638);
            this.panelTitle.TabIndex = 9;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTitle_Paint);
            // 
            // timerLoginPanelSlider
            // 
            this.timerLoginPanelSlider.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timerLoginPanelSliderReverse
            // 
            this.timerLoginPanelSliderReverse.Tick += new System.EventHandler(this.TimerLoginPanelSliderReverse_Tick);
            // 
            // timerResetPasswordSlider
            // 
            this.timerResetPasswordSlider.Interval = 1;
            this.timerResetPasswordSlider.Tick += new System.EventHandler(this.TimerResetPasswordSlider_Tick);
            // 
            // timerResetPasswordSliderReverse
            // 
            this.timerResetPasswordSliderReverse.Interval = 1;
            this.timerResetPasswordSliderReverse.Tick += new System.EventHandler(this.TimerResetPasswordSliderReverse_Tick);
            // 
            // toolTipWarning
            // 
            this.toolTipWarning.AutoPopDelay = 5000;
            this.toolTipWarning.InitialDelay = 0;
            this.toolTipWarning.ReshowDelay = 100;
            // 
            // toolTipPass
            // 
            this.toolTipPass.AutomaticDelay = 5000;
            this.toolTipPass.ShowAlways = true;
            // 
            // toolTipEmail
            // 
            this.toolTipEmail.AutoPopDelay = 5000;
            this.toolTipEmail.InitialDelay = 0;
            this.toolTipEmail.ReshowDelay = 100;
            this.toolTipEmail.ShowAlways = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1152, 629);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1165, 662);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Scanning Wizard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            this.panelResetPassword.ResumeLayout(false);
            this.panelResetPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelPasswordUnderline;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panelEmailUnderline;
        private System.Windows.Forms.Button buttonForgotPassword;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label labelNewtoASW;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Timer timerLoginPanelSlider;
        private System.Windows.Forms.Timer timerLoginPanelSliderReverse;
        private System.Windows.Forms.Panel panelResetPassword;
        private System.Windows.Forms.Button buttonResetPassword;
        private System.Windows.Forms.TextBox textBoxEmailReset;
        private System.Windows.Forms.Panel panelEmailResetUnderline;
        private System.Windows.Forms.Label labelResetPassword;
        private System.Windows.Forms.Button buttonCancelReset;
        private System.Windows.Forms.Timer timerResetPasswordSlider;
        private System.Windows.Forms.Timer timerResetPasswordSliderReverse;
        private System.Windows.Forms.Panel panelSignUp;
        private System.Windows.Forms.TextBox textBoxConfirmPassSignUp;
        private System.Windows.Forms.Panel panelConfirmPassSignUpUnderline;
        private System.Windows.Forms.TextBox textBoxPassSignUp;
        private System.Windows.Forms.Panel panelPassSignUpUnderline;
        private System.Windows.Forms.TextBox textBoxEmailSignup;
        private System.Windows.Forms.Panel panelEmailSignUpUnderline;
        private System.Windows.Forms.TextBox textBoxLastNameSignUp;
        private System.Windows.Forms.Panel panelLastNameSignUpUnderline;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.TextBox textBoxFirstNameSignUp;
        private System.Windows.Forms.Panel panelFirstNameSignUpUnderline;
        private System.Windows.Forms.TextBox textBoxAcademicIdSignUp;
        private System.Windows.Forms.Panel panelIdSignUpUnderline;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTipWarning;
        private System.Windows.Forms.ToolTip toolTipPass;
        private System.Windows.Forms.ToolTip toolTipEmail;
    }
}

