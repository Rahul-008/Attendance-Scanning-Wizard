using DataLayer.Models.UserModels;
using System;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FormDashboard : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        public FormDashboard(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
            labelWelcome.Text = "Welcome, " +gotFaculty.FullName;

            buttonYourSections.Focus();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Logout pressed");
            var login = new LoginForm();
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
            
        }

        private void ButtonYourClasses_Click(object sender, EventArgs e)
        {
            
        }
        private void ButtonAddSection_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonAddClass_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void LabelWelcome_Click(object sender, EventArgs e)
        {
            
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
