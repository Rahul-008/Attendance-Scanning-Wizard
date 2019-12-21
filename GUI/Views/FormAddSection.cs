using DataLayer.Models;
using DataLayer.Models.BaseModels;
using System;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FormAddSection : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        public FormAddSection(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
            labelWelcome.Text = faculty.FullName;
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

        private void buttonCreateManually_Click(object sender, EventArgs e)
        {
            var createManual = new FormCreateManual(faculty);
            createManual.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            createManual.Show();
            this.Hide();
        }
    }
}
