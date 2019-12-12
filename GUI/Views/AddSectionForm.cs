using DataLayer.Models;
using DataLayer.Models.BaseModels;
using DataLayer.Models.UserModels;
using GUI.Controllers;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            List<StudentUserModel> studentList = new List<StudentUserModel>();
            var createManual = new CreateManualFrom(faculty, studentList);
            createManual.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            createManual.Show();
            this.Hide();
        }

        private void buttonImportSpreadsheet_Click(object sender, EventArgs e)
        {
            
        }

        private void FormAddSection_Load(object sender, EventArgs e)
        {

        }
    }
}
