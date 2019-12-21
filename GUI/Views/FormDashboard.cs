using DataLayer.Models;
using DataLayer.Models.BaseModels;
using System;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FormDashboard : Form
    {
        public FacultyUserModel faculty = new FacultyUserModel();
        //pass Faculty ID to constructor
        public FormDashboard(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
            labelWelcome.Text = "Welcome, " +gotFaculty.FullName;
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Logout pressed");
            var login = new FormLogin();
            login.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            login.Show();
            this.Hide();
        }

        private void dash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void ButtonYourSections_Click(object sender, EventArgs e)
        {
            var yourSections = new FormYourSections(faculty);
            yourSections.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            yourSections.Show();
            this.Hide();
        }

        private void ButtonYourClasses_Click(object sender, EventArgs e)
        {
            var yourClasses = new FormYourClasses(faculty);
            yourClasses.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            yourClasses.Show();
            this.Hide();
        }
        private void ButtonAddSection_Click(object sender, EventArgs e)
        {
            var addSection = new FormAddSection(faculty);
            addSection.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            addSection.Show();
            this.Hide();
        }

        private void ButtonAddClass_Click(object sender, EventArgs e)
        {
            var addClass = new FormAddClass(faculty);
            addClass.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            addClass.Show();
            this.Hide();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var search = new FormSearch(faculty);
            search.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            search.Show();
            this.Hide();
        }

        private void LabelWelcome_Click(object sender, EventArgs e)
        {
            var profile = new FormProfile(faculty);
            profile.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            profile.Show();
            this.Hide();
        }
    }
}
