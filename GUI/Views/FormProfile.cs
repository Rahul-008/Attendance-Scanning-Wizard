using DataLayer.Models;
using DataLayer.Models.BaseModels;
using GUI.Controllers;
using System;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FormProfile : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        public FormProfile(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
            labelWelcome.Text = faculty.FullName;
            textBoxFirstName.Text = faculty.FirstName;
            textBoxLastName.Text = faculty.LastName;
            textBoxEmail.Text = faculty.Email;
            textBoxAcademicId.Text = faculty.AcademicId;
            //faculty.
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

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            var pass = new FormChangePassword(faculty);
            pass.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            pass.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxFirstName.Text) && !string.IsNullOrWhiteSpace(textBoxLastName.Text) && !string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                FacultyUserModel updatedModel = new FacultyUserModel();
                updatedModel.AcademicId = faculty.AcademicId;
                updatedModel.FirstName = textBoxFirstName.Text;
                updatedModel.LastName = textBoxLastName.Text;
                updatedModel.Email = textBoxEmail.Text;
                updatedModel.Id = faculty.Id;
                updatedModel.Password = faculty.Password;

                try
                {
                    updatedModel.IsValid();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if(MessageBox.Show("Save changes?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        var controller = new UserController();
                        faculty = controller.Update(updatedModel);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill up all fields");
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset all fields?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                textBoxFirstName.Text = faculty.FirstName;
                textBoxLastName.Text = faculty.LastName;
                textBoxEmail.Text = faculty.Email;
            }
        }
    }
}
