namespace GUI.Views
{
    partial class QRdisplayForm
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
            this.pbQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQR
            // 
            this.pbQR.BackColor = System.Drawing.Color.White;
            this.pbQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbQR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbQR.Location = new System.Drawing.Point(0, 0);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(800, 450);
            this.pbQR.TabIndex = 0;
            this.pbQR.TabStop = false;
            // 
            // QRdisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbQR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QRdisplayForm";
            this.ShowInTaskbar = false;
            this.Text = "QRdisplayForm";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QRdisplayForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QRdisplayForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQR;
    }
}