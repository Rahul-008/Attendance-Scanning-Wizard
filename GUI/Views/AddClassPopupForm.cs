using DataLayer.Models;
using DataLayer.Models.UserModels;
using DataLayer.Utils;
using GUI.Controllers;
using GUI.Controllers.BaseController;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class AddClassPopupForm : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        SectionModel section = new SectionModel();
        public AddClassPopupForm(FacultyUserModel gotFaculty, SectionModel gotSection)
        {
            InitializeComponent();
            faculty = gotFaculty;
            section = gotSection;

            datePicker.CalendarForeColor = Color.FromArgb(217, 217, 217);
            datePicker.CalendarMonthBackground = Color.FromArgb(49, 49, 49);

            datePicker.MinDate = DateTime.Today;
            datePicker.MaxDate = DateTime.MaxValue;
            datePicker.Value = DateTime.Today;

            List<ClassTimeModel> timeListStart = new List<ClassTimeModel>();
            ClassTimeController timeControllerStart = new ClassTimeController();
            timeListStart = timeControllerStart.Get();

            comboBoxStartTime.DataSource = timeListStart;
            comboBoxStartTime.DisplayMember = "ClassTimeText";
            comboBoxStartTime.ValueMember = "Id";

            List<ClassTimeModel> timeListEnd = new List<ClassTimeModel>();
            ClassTimeController timeControllerEnd = new ClassTimeController();
            timeListEnd = timeControllerEnd.Get();

            comboBoxEndTime.DataSource = timeListEnd;
            comboBoxEndTime.DisplayMember = "ClassTimeText";
            comboBoxEndTime.ValueMember = "Id";

            comboBoxClassType.DataSource = Enum.GetValues(typeof(ClassTypes));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClassModel Class = new ClassModel();
            Class.ClassDate = datePicker.Value.ToString("yyyy-MM-dd");
            Class.StartTimeId = comboBoxStartTime.SelectedIndex + 1;
            Class.EndTimeId = comboBoxEndTime.SelectedIndex + 1;
            Class.RoomNo = textBoxRoomNo.Text;
            Class.SectionId = section.Id;
            if (comboBoxClassType.SelectedIndex == 0)
            {
                Class.ClassType = ClassTypes.Lab;
            }
            else if (comboBoxClassType.SelectedIndex == 1)
            {
                Class.ClassType = ClassTypes.Theory;
            }
            else
            {
                try
                {
                    throw new Exception("Invalid class type");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            ClassController ccontroller = new ClassController();

            try
            {
                Class.IsValid();

                List<ClassModel> sameDayClasses = ccontroller.GetByDateAndFacultyId(Class.ClassDate, faculty.Id);
                //Console.WriteLine("Found " + sameDayClasses.Count + " classes");
                foreach (ClassModel model in sameDayClasses)
                {
                    //Console.WriteLine("start id: " + model.StartTimeId + " end id: " + model.EndTimeId);
                    //Console.WriteLine("this start: " + Class.StartTimeId + " this end: " + Class.EndTimeId);

                    if(Class.StartTimeId < model.EndTimeId && Class.StartTimeId >= model.StartTimeId)
                    {
                        throw new Exception("Class time clashes with another class on " + Class.ClassDate);
                    }
                    if(Class.EndTimeId <= model.EndTimeId && Class.EndTimeId > model.StartTimeId)
                    {
                        throw new Exception("Class time clashes with another class on " + Class.ClassDate);
                    }
                }
                //Console.WriteLine("Clash checking complete");
                try
                {
                    var createdClass = ccontroller.Create(Class);

                    string qrstring = createdClass.Id.ToString() + "|" + section.SectionName.ToString() + "|" + createdClass.CreatedAt.ToString();
                    string encodedqrstring = Convert.ToBase64String(Encoding.UTF8.GetBytes(qrstring));
                    string decodedqrstring = (Encoding.UTF8.GetString(Convert.FromBase64String(encodedqrstring)));
                    //Console.WriteLine(decodedqrstring);
                    try
                    {
                        ccontroller.InsertQRCode(createdClass.Id, encodedqrstring);

                        SectionStudentController sscontroller = new SectionStudentController();
                        List<int> sectionStudentsId = sscontroller.GetAllBySection(section.Id);

                        AttendanceController acontroller = new AttendanceController();

                        foreach (int StudentId in sectionStudentsId)
                        {
                            AttendanceModel attendance = new AttendanceModel();
                            attendance.ClassId = createdClass.Id;
                            attendance.StudentId = StudentId;

                            try
                            {
                                acontroller.Create(attendance);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        //Console.WriteLine("Created class id: " + createdClass.Id);
                        MessageBox.Show("Class added on " + (createdClass.ClassDate));
                        this.Hide();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void AddClassPopupForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                            this.DisplayRectangle);
        }
    }
}
