using DataLayer.Models;
using DataLayer.Models.UserModels;
using DataLayer.Utils;
using GUI.Controllers;
using GUI.Controllers.BaseController;
using GUI.Properties;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class CreateManualFrom : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        List<StudentUserModel> studentList = new List<StudentUserModel>();
        public CreateManualFrom(FacultyUserModel gotFaculty, List<StudentUserModel> gotStudentList)
        {
            InitializeComponent();
            faculty = gotFaculty;
            studentList = gotStudentList;
            labelWelcome.Text = faculty.FullName;

            List<WeekDayModel> dayList1 = new List<WeekDayModel>();
            WeekDayController dayController1 = new WeekDayController();
            dayList1 = dayController1.Get();

            comboBoxWeekDay1.DataSource = dayList1;
            comboBoxWeekDay1.DisplayMember = "WeekDayText";
            comboBoxWeekDay1.ValueMember = "Id";

            List<WeekDayModel> dayList2 = new List<WeekDayModel>();
            WeekDayController dayController2 = new WeekDayController();
            dayList2 = dayController2.Get();

            comboBoxWeekDay2.DataSource = dayList2;
            comboBoxWeekDay2.DisplayMember = "WeekDayText";
            comboBoxWeekDay2.ValueMember = "Id";

            List<ClassTimeModel> timeListStart1 = new List<ClassTimeModel>();
            ClassTimeController timeControllerStart1 = new ClassTimeController();
            timeListStart1 = timeControllerStart1.Get();

            comboBoxStartTime1.DataSource = timeListStart1;
            comboBoxStartTime1.DisplayMember = "ClassTimeText";
            comboBoxStartTime1.ValueMember = "Id";

            List<ClassTimeModel> timeListStart2 = new List<ClassTimeModel>();
            ClassTimeController timeControllerStart2 = new ClassTimeController();
            timeListStart2 = timeControllerStart2.Get();

            comboBoxStartTime2.DataSource = timeListStart2;
            comboBoxStartTime2.DisplayMember = "ClassTimeText";
            comboBoxStartTime2.ValueMember = "Id";

            List<ClassTimeModel> timeListEnd1 = new List<ClassTimeModel>();
            ClassTimeController timeControllerEnd1 = new ClassTimeController();
            timeListEnd1 = timeControllerEnd1.Get();

            comboBoxEndTime1.DataSource = timeListEnd1;
            comboBoxEndTime1.DisplayMember = "ClassTimeText";
            comboBoxEndTime1.ValueMember = "Id";

            List<ClassTimeModel> timeListEnd2 = new List<ClassTimeModel>();
            ClassTimeController timeControllerEnd2 = new ClassTimeController();
            timeListEnd2 = timeControllerEnd2.Get();

            comboBoxEndTime2.DataSource = timeListEnd2;
            comboBoxEndTime2.DisplayMember = "ClassTimeText";
            comboBoxEndTime2.ValueMember = "Id";

            comboBoxClassType1.DataSource = Enum.GetValues(typeof(ClassTypes));
            comboBoxClassType2.DataSource = Enum.GetValues(typeof(ClassTypes));
        }

        private void buttonBack_Click(object sender, System.EventArgs e)
        {
            var addSection = new FormAddSection(faculty);
            addSection.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            addSection.Show();
            this.Hide();
        }

        private void dash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void labelTitle_Click(object sender, System.EventArgs e)
        {
            var dash = new FormDashboard(faculty);
            dash.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            dash.Show();
            this.Hide();
        }

        private void textBoxSectionName_Click(object sender, System.EventArgs e)
        {
            if (textBoxSectionName.Text == "Course [Section]")
            {
                textBoxSectionName.Clear();
                textBoxSectionName.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
            }
        }

        private void textBoxSectionName_Leave(object sender, System.EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxSectionName.Text))
            {
                textBoxSectionName.ForeColor = Color.FromArgb(112, 112, 112);
                textBoxSectionName.Text = "Course [Section]";
            }
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            SectionModel section = new SectionModel();
            section.SectionName = textBoxSectionName.Text.Trim();
            section.FacultyId = faculty.Id;

            SectionTimeController stcontroller = new SectionTimeController();
            List<SectionTimeModel> sectionTimes = stcontroller.GetByFaculty(faculty.Id);

            try
            {
                section.IsValid();

                //Console.WriteLine("Section name: " + section.SectionName);
                //Console.WriteLine("Section facultyID: " + section.FacultyId);

                SectionTimeModel sectionTime1 = new SectionTimeModel();
                if (comboBoxClassType1.SelectedIndex == 0)
                {
                    sectionTime1.ClassType = ClassTypes.Lab;
                }
                else if (comboBoxClassType1.SelectedIndex == 1)
                {
                    sectionTime1.ClassType = ClassTypes.Theory;
                }

                sectionTime1.RoomNo = textBoxRoomNo1.Text;
                sectionTime1.StartTimeId = comboBoxStartTime1.SelectedIndex + 1;
                sectionTime1.EndTimeId = comboBoxEndTime1.SelectedIndex + 1;
                sectionTime1.WeekDayId = comboBoxWeekDay1.SelectedIndex + 1;

                //Console.WriteLine("Section Time 1 info:");
                //Console.WriteLine("Start Id: " + sectionTime1.StartTimeId);
                //Console.WriteLine("End Id: " + sectionTime1.EndTimeId);
                //Console.WriteLine("Day Id: " + sectionTime1.WeekDayID);
                //Console.WriteLine("Room no: " + sectionTime1.RoomNo);
                //Console.WriteLine("Class type: " + sectionTime1.ClassType.ToString());
                //Console.WriteLine("Class length: " + (sectionTime1.EndTimeId - sectionTime1.StartTimeId).ToString());

                try
                {
                    sectionTime1.IsValid();

                    foreach (SectionTimeModel model in sectionTimes)
                    {
                        if (model.WeekDayId == sectionTime1.WeekDayId)
                        {
                            if (sectionTime1.StartTimeId < model.EndTimeId && sectionTime1.StartTimeId >= model.StartTimeId)
                            {
                                //Console.WriteLine("Clash 1 with\nstart id: " + model.StartTimeId + "\nend id: " + model.EndTimeId);
                                throw new Exception("Section 1 time clashes with another section. Please choose a different time");

                            }
                            if (sectionTime1.EndTimeId <= model.EndTimeId && sectionTime1.EndTimeId > model.StartTimeId)
                            {
                                //Console.WriteLine("Clash 2 with\nstart id: " + model.StartTimeId + "\nend id: " + model.EndTimeId);
                                throw new Exception("Section 1 time clashes with another section. Please choose a different time");
                            }
                            if (sectionTime1.StartTimeId < model.StartTimeId && sectionTime1.EndTimeId > model.EndTimeId)
                            {
                                //Console.WriteLine("Clash 3 with\nstart id: " + model.StartTimeId + "\nend id: " + model.EndTimeId);
                                throw new Exception("Section 1 time clashes with another section. Please choose a different time");
                            }
                        }
                    }

                    SectionTimeModel sectionTime2 = new SectionTimeModel();
                    if (!checkBoxIgnore.Checked)
                    {
                        if (comboBoxClassType2.SelectedIndex == 0)
                        {
                            sectionTime2.ClassType = ClassTypes.Lab;
                        }
                        else if (comboBoxClassType2.SelectedIndex == 1)
                        {
                            sectionTime2.ClassType = ClassTypes.Theory;
                        }
                        sectionTime2.RoomNo = textBoxRoomNo2.Text;
                        sectionTime2.StartTimeId = comboBoxStartTime2.SelectedIndex + 1;
                        sectionTime2.EndTimeId = comboBoxEndTime2.SelectedIndex + 1;
                        sectionTime2.WeekDayId = comboBoxWeekDay2.SelectedIndex + 1;

                        //Console.WriteLine("Section Time 2 info:");
                        //Console.WriteLine("Start Id: " + sectionTime2.StartTimeId);
                        //Console.WriteLine("End Id: " + sectionTime2.EndTimeId);
                        //Console.WriteLine("Day Id: " + sectionTime2.WeekDayID);
                        //Console.WriteLine("Room no: " + sectionTime2.RoomNo);
                        //Console.WriteLine("Class type: " + sectionTime2.ClassType.ToString());
                        //Console.WriteLine("Class length: " + (sectionTime2.EndTimeId - sectionTime2.StartTimeId).ToString());
                    }

                    SectionModel createdSection = new SectionModel();
                    try
                    {
                        if (!checkBoxIgnore.Checked)
                        {
                            sectionTime2.IsValid();
                            foreach (SectionTimeModel model in sectionTimes)
                            {
                                if (model.WeekDayId == sectionTime2.WeekDayId)
                                {
                                    if (sectionTime2.StartTimeId < model.EndTimeId && sectionTime2.StartTimeId >= model.StartTimeId)
                                    {
                                        throw new Exception("Section 2 time clashes with another section. Please choose a different time");
                                    }
                                    if (sectionTime2.EndTimeId <= model.EndTimeId && sectionTime2.EndTimeId > model.StartTimeId)
                                    {
                                        throw new Exception("Section 2 time clashes with another section. Please choose a different time");
                                    }
                                    if (sectionTime2.StartTimeId < model.StartTimeId && sectionTime2.EndTimeId > model.EndTimeId)
                                    {
                                        //Console.WriteLine("Clash 3 with\nstart id: " + model.StartTimeId + "\nend id: " + model.EndTimeId);
                                        throw new Exception("Section 2 time clashes with another section. Please choose a different time");
                                    }
                                }
                            }
                        }
                        SectionController controller = new SectionController();

                        try
                        {
                            createdSection = controller.Create(section);

                            //Console.WriteLine("Created section id: " + createdSection.Id);

                            sectionTime1.SectionId = createdSection.Id;
                            if (!checkBoxIgnore.Checked)
                                sectionTime2.SectionId = createdSection.Id;

                            SectionTimeController controller2 = new SectionTimeController();

                            try
                            {
                                controller2.Create(sectionTime1);
                                if (!checkBoxIgnore.Checked)
                                    controller2.Create(sectionTime2);

                                MessageBox.Show(createdSection.SectionName + " created!");
                                LoadingForm loadingForm = new LoadingForm();

                                if (studentList.Count != 0)
                                {
                                    UserController ucontroller = new UserController();

                                    //loading screen

                                    loadingForm.Show();
                                    //Console.WriteLine("Starting loop");
                                    foreach (StudentUserModel student in studentList)
                                    {
                                        try
                                        {
                                            var createdStudent = ucontroller.Create(student);
                                            try
                                            {
                                                SectionStudentController sscontroller = new SectionStudentController();
                                                sscontroller.Create(createdSection.Id, student.Id);
                                            }
                                            catch (SQLiteException exc)
                                            {
                                                if (exc.ErrorCode == 19)
                                                {
                                                    MessageBox.Show("Error: Student already exists in this section");
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                            }
                                        }
                                        catch (SQLiteException ex)
                                        {
                                            var existingStudent = ucontroller.GetByAcademicId(student.AcademicId);
                                            try
                                            {
                                                SectionStudentController sscontroller = new SectionStudentController();
                                                sscontroller.Create(createdSection.Id, existingStudent.Id);
                                            }
                                            catch (SQLiteException exc)
                                            {
                                                if (exc.ErrorCode == 19)
                                                {
                                                    MessageBox.Show("Error: Student already exists in this section");
                                                }
                                            }
                                            catch (Exception exc)
                                            {
                                                MessageBox.Show(exc.Message);
                                            }
                                        }
                                        loadingForm.Step(1);
                                    }
                                    //Console.WriteLine("Ending loop");
                                }
                                loadingForm.Close();

                                buttonBack.PerformClick();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateManualFrom_Load(object sender, EventArgs e)
        {
            flowTodaysClass.Width = panelLeft.Width + SystemInformation.VerticalScrollBarWidth;
            ClassController ccontroller = new ClassController();
            ClassTimeController classTimeController = new ClassTimeController();
            List<ClassModel> todaysClasses = ccontroller.GetByDateAndFacultyId(DateTime.Today.ToString("yyyy-MM-dd"), faculty.Id);
            int i = 0;
            foreach (ClassModel Class in todaysClasses)
            {
                FlowLayoutPanel todaysClassPanel = new FlowLayoutPanel();
                todaysClassPanel.Size = new System.Drawing.Size(250, 80);
                todaysClassPanel.Margin = new Padding(0, 0, 0, 0);
                if (i % 2 == 0)
                {
                    todaysClassPanel.BackColor = Color.FromArgb(59, 59, 59);
                }
                else
                {
                    todaysClassPanel.BackColor = Color.FromArgb(48, 48, 48);
                }

                SectionController scontroller = new SectionController();

                Label sectionName = new Label();
                sectionName.Font = new Font("Arial", 9.5F, System.Drawing.FontStyle.Bold);
                sectionName.ForeColor = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                sectionName.Location = new Point(8, 8);
                sectionName.Margin = new Padding(8, 5, 4, 4);
                sectionName.Size = new Size(188, 36);
                sectionName.TabIndex = 0;
                sectionName.Text = scontroller.Get(Class.SectionId).SectionName;
                sectionName.TextAlign = ContentAlignment.MiddleLeft;

                Button qr = new Button();
                qr.BackgroundImage = Resources.qr;
                qr.BackgroundImageLayout = ImageLayout.Stretch;
                qr.FlatAppearance.BorderSize = 0;
                qr.Cursor = Cursors.Hand;
                qr.FlatStyle = FlatStyle.Flat;
                qr.Location = new Point(202, 8);
                qr.Margin = new Padding(2, 8, 2, 2);
                qr.Size = new Size(33, 33);
                qr.TabIndex = 4;
                qr.UseVisualStyleBackColor = true;

                qr.Click += delegate (object s, EventArgs ev) { qrButton_Click(sender, e, Class); };

                Label classType = new Label();
                classType.Font = new Font("Arial", 10.2F);
                classType.ForeColor = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                classType.Location = new Point(8, 48);
                classType.Margin = new Padding(8, 0, 4, 4);
                classType.Name = "label2";
                classType.Size = new Size(53, 28);
                classType.TabIndex = 1;
                classType.Text = Class.ClassType.ToString();
                classType.TextAlign = ContentAlignment.MiddleLeft;

                Label time = new Label();
                time.Font = new Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                time.ForeColor = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                time.Location = new Point(69, 48);
                time.Margin = new Padding(4, 0, 4, 4);
                time.Size = new Size(104, 28);
                time.TabIndex = 2;
                time.Text = classTimeController.Get(Class.StartTimeId).ClassTimeText + " - " + classTimeController.Get(Class.EndTimeId).ClassTimeText;
                time.TextAlign = ContentAlignment.MiddleCenter;

                Label room = new Label();
                room.Font = new Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                room.ForeColor = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                room.Location = new Point(181, 48);
                room.Margin = new Padding(4, 0, 4, 4);
                room.Size = new Size(52, 28);
                room.TabIndex = 3;
                room.Text = Class.RoomNo;
                room.TextAlign = ContentAlignment.MiddleRight;

                todaysClassPanel.Controls.Add(sectionName);
                todaysClassPanel.Controls.Add(qr);
                todaysClassPanel.Controls.Add(classType);
                todaysClassPanel.Controls.Add(time);
                todaysClassPanel.Controls.Add(room);

                flowTodaysClass.Controls.Add(todaysClassPanel);
                i++;
            }
        }

        private void qrButton_Click(object sender, EventArgs e, ClassModel Class)
        {
            if (Class.QRDisplayStartTime == null)
            {
                //Console.WriteLine("Clicked class QR: " + Encoding.UTF8.GetString(Convert.FromBase64String(Class.QRCode)));
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData data = qRCodeGenerator.CreateQrCode(Class.QRCode, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                Bitmap image = code.GetGraphic(50);

                ClassController classController = new ClassController();
                try
                {
                    var updatedClass = classController.InsertQRDisplayStartTime(Class.Id, DateTime.Now.ToString());

                    var qrForm = new QRdisplayForm(Class, image);
                    qrForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure you want to show QR again? Previous display time will be overwritten!",
                                     "Confirm",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    //Console.WriteLine("Clicked class QR: " + Encoding.UTF8.GetString(Convert.FromBase64String(Class.QRCode)));
                    QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                    QRCodeData data = qRCodeGenerator.CreateQrCode(Class.QRCode, QRCodeGenerator.ECCLevel.Q);
                    QRCode code = new QRCode(data);
                    Bitmap image = code.GetGraphic(50);

                    ClassController classController = new ClassController();
                    try
                    {
                        //var updatedClass = classController.InsertQRDisplayStartTime(Class.Id, DateTime.Now.ToString());

                        var qrForm = new QRdisplayForm(Class, image);
                        qrForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
