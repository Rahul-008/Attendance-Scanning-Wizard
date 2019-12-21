using DataLayer.Models;
using DataLayer.Models.UserModels;
using DataLayer.Utils;
using GUI.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class EditClassPopupForm : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        ClassModel Class = new ClassModel();
        public EditClassPopupForm(FacultyUserModel gotFaculty, ClassModel gotClass)
        {
            InitializeComponent();
            faculty = gotFaculty;
            Class = gotClass;

            SectionController scontroller = new SectionController();
            labelTitle.Text = "Edit class of " + scontroller.Get(Class.SectionId).SectionName + " on " + Class.ClassDate;

            datePicker.CalendarForeColor = Color.FromArgb(217, 217, 217);
            datePicker.CalendarMonthBackground = Color.FromArgb(49, 49, 49);

            datePicker.MinDate = DateTime.Today;
            datePicker.MaxDate = DateTime.MaxValue;
            datePicker.Value = DateTime.Parse(Class.ClassDate);

            List<ClassTimeModel> timeListStart = new List<ClassTimeModel>();
            ClassTimeController timeControllerStart = new ClassTimeController();
            timeListStart = timeControllerStart.Get();

            comboBoxStartTime.DataSource = timeListStart;
            comboBoxStartTime.DisplayMember = "ClassTimeText";
            comboBoxStartTime.ValueMember = "Id";
            comboBoxStartTime.SelectedIndex = Class.StartTimeId-1;

            List<ClassTimeModel> timeListEnd = new List<ClassTimeModel>();
            ClassTimeController timeControllerEnd = new ClassTimeController();
            timeListEnd = timeControllerEnd.Get();

            comboBoxEndTime.DataSource = timeListEnd;
            comboBoxEndTime.DisplayMember = "ClassTimeText";
            comboBoxEndTime.ValueMember = "Id";
            comboBoxEndTime.SelectedIndex = Class.EndTimeId-1;

            comboBoxClassType.DataSource = Enum.GetValues(typeof(ClassTypes));
            comboBoxClassType.SelectedIndex = Convert.ToInt32(Class.ClassType);

            textBoxRoomNo.Text = Class.RoomNo;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            ClassModel editedClass = new ClassModel();
            editedClass.Id = Class.Id;
            editedClass.ClassDate = datePicker.Value.ToString("yyyy-MM-dd");
            editedClass.StartTimeId = comboBoxStartTime.SelectedIndex + 1;
            editedClass.EndTimeId = comboBoxEndTime.SelectedIndex + 1;
            editedClass.RoomNo = textBoxRoomNo.Text;
            if (comboBoxClassType.SelectedIndex == 0)
            {
                editedClass.ClassType = ClassTypes.Lab;
            }
            else if (comboBoxClassType.SelectedIndex == 1)
            {
                editedClass.ClassType = ClassTypes.Theory;
            }
            else
            {
                try
                {
                    throw new Exception("Invalid class type");
                }
                catch (Exception ex)
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
                    //Console.WriteLine("this id: " + editedClass.Id + "\nComparing with id" + model.Id);
                    //Console.WriteLine("start id: " + model.StartTimeId + " end id: " + model.EndTimeId);
                    //Console.WriteLine("this start: " + editedClass.StartTimeId + " this end: " + editedClass.EndTimeId);

                    if (Class.Id != model.Id)
                    {
                        if (editedClass.StartTimeId < model.EndTimeId && editedClass.StartTimeId >= model.StartTimeId)
                        {
                            //Console.WriteLine("clash with: " + model.ClassDate + "\nStart: " + model.StartTimeId + "\nEnd: " + model.EndTimeId);
                            throw new Exception("Class time clashes with another class on " + editedClass.ClassDate);
                        }
                        if (editedClass.EndTimeId <= model.EndTimeId && editedClass.EndTimeId > model.StartTimeId)
                        {
                            //Console.WriteLine("clash with: " + model.ClassDate + "\nStart: " + model.StartTimeId + "\nEnd: " + model.EndTimeId);
                            throw new Exception("Class time clashes with another class on " + editedClass.ClassDate);
                        }
                    }
                }
                //Console.WriteLine("Clash checking complete");
                try
                {
                    var NewEditedClass = ccontroller.Update(editedClass);
                    //Console.WriteLine("edited class id: " + NewEditedClass.Id);
                    MessageBox.Show("Class edited. New date: " + (NewEditedClass.ClassDate));
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditClassPopupForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 3),
                            this.DisplayRectangle);
        }
    }
}
