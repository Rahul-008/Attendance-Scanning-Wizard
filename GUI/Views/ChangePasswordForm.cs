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

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            //try
            {
                UserController controller = new UserController();
                Argon2Hashing hashing = new Argon2Hashing();
                //Console.WriteLine("getting pass with id: " + faculty.Id);
                //Console.WriteLine("Verification: " + hashing.VerifyHash(textBoxPassword.Text, Convert.FromBase64String(faculty.salt), Convert.FromBase64String(faculty.Password)));
                if(hashing.VerifyHash(textBoxPassword.Text, Convert.FromBase64String(faculty.salt), Convert.FromBase64String(faculty.Password)))
                {
                    loadingForm.Step(20);
                    if (textBoxNewPassword.Text == textBoxConfirmPassword.Text)
                    {
                        faculty.Password = textBoxNewPassword.Text;
                        //try
                        {
                            faculty.IsValid();
                            faculty.salt = Convert.ToBase64String(hashing.CreateSalt());
                            faculty.Password = Convert.ToBase64String(hashing.HashPassword(faculty.Password, Convert.FromBase64String(faculty.salt)));
                            loadingForm.Step(20);
                            if(hashing.VerifyHash(textBoxNewPassword.Text, Convert.FromBase64String(faculty.salt), Convert.FromBase64String(faculty.Password)))
                            {
                                loadingForm.Step(20);
                                //try
                                {
                                    controller.UpdatePasswordByUser(faculty.Id, faculty.Password, faculty.salt);
                                    loadingForm.Step(60);
                                    loadingForm.Close();
                                    MessageBox.Show("Password successfully updated");
                                    this.Hide();
                                }
                                //catch(Exception ex)
                                //{
                                //    loadingForm.Close();
                                //    MessageBox.Show(ex.Message);
                                //}
                            }
                            else
                            {
                                loadingForm.Close();
                                MessageBox.Show("Hash verification failed");
                            }
                                
                        }
                        //catch (Exception ex)
                        //{
                        //    loadingForm.Close();
                        //    MessageBox.Show(ex.Message+" here");
                        //}
                    }
                    else
                    {
                        loadingForm.Close();
                        MessageBox.Show("Passwords do not match. Please make sure you confirm your password correctly");
                    }
                }
                else
                {
                    loadingForm.Close();
                    MessageBox.Show("Wrong current password. Please try again");
                }
            }
            
            //catch (Exception ex)
            //{

            //    loadingForm.Close();
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void ChangePasswordForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 3),
                            this.DisplayRectangle);
        }
    }
}
