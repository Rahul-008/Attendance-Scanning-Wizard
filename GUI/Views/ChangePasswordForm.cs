using DataLayer.Models;
using DataLayer.Models.UserModels;
using GUI.Controllers;
using GUI.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class ChangePasswordForm : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        public ChangePasswordForm(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void ChangePasswordForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 3),
                            this.DisplayRectangle);
        }
    }
}
