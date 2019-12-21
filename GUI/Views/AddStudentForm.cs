using DataLayer.Models;
using DataLayer.Models.BaseModels;
using DataLayer.Models.UserModels;
using GUI.Controllers;
using GUI.Controllers.BaseController;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class AddStudentForm : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        SectionModel section = new SectionModel();
        public AddStudentForm(FacultyUserModel gotFaculty, SectionModel gotSection)
        {
            InitializeComponent();
            faculty = gotFaculty;
            section = gotSection;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            var students = new FormStudentList(faculty, section);
            students.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            students.Show();
            this.Hide();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            StudentUserModel student = new StudentUserModel();
            student.FirstName = textBoxStudentFirstName.Text.Trim();
            student.LastName = textBoxStudentLastName.Text.Trim();
            student.AcademicId = textBoxStudentId.Text;

            try
            {
                student.IsValid();
                UserController controller = new UserController();
                try
                {
                    BaseUserModel createdStudent = controller.Create(student);

                    SectionStudentController controller1 = new SectionStudentController();
                    controller1.Create(section.Id, createdStudent.Id);

                    ClassController ccontroller = new ClassController();
                    List<ClassModel> classList = ccontroller.GetBySectionId(section.Id);
                    AttendanceController acontroller = new AttendanceController();
                    
                    foreach(ClassModel Class in classList)
                    {
                        AttendanceModel attendance = new AttendanceModel();
                        attendance.StudentId = createdStudent.Id;
                        attendance.ClassId = Class.Id;
                        try
                        {
                            acontroller.Create(attendance);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    MessageBox.Show(student.FullName + " added in " + section.SectionName);
                    var students = new FormStudentList(faculty, section);
                    students.FormClosed += new FormClosedEventHandler(dash_FormClosed);
                    students.Show();
                    this.Hide();
                }
                catch(NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (SQLiteException ex)
            {
                try
                {
                    UserController controller = new UserController();
                    var gotStudent = controller.GetByAcademicId(student.AcademicId);
                    string message = "Student already exists in our database. Are you sure you want to add " + gotStudent.FullName + "(" + gotStudent.AcademicId + ")?";

                    DialogResult dialogResult = MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            SectionStudentController controller1 = new SectionStudentController();
                            controller1.Create(section.Id, gotStudent.Id);
                            MessageBox.Show(gotStudent.FullName + " added in " + section.SectionName);

                            var students = new FormStudentList(faculty, section);
                            students.FormClosed += new FormClosedEventHandler(dash_FormClosed);
                            students.Show();
                            this.Hide();
    }
                        catch(SQLiteException exc)
                        {
                            if(exc.ErrorCode == 19)
                            {
                                MessageBox.Show("Error: Student already exists in this section");
                            }
                        }
                        catch(Exception exv)
                        {
                            MessageBox.Show(exv.Message);
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Hide();
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var myParent = this.Owner;
            myParent.Hide();
            var students = new FormStudentList(faculty, section);
            students.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            students.Show();
        }

        private void dash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void AddStudentForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 3),
                            this.DisplayRectangle);
        }

        private void textBoxStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '-' || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
