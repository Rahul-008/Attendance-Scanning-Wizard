using DataLayer.Models;
using System;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FormAddClass : Form
    {
        public FacultyUserModel faculty = new FacultyUserModel();
        public FormAddClass(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
            labelWelcome.Text = gotFaculty.FullName;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            var dash = new FormDashboard(faculty);
            dash.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            dash.Show();
            this.Hide();
        }

        private void dash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
