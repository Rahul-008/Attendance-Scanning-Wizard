using DataLayer.Models;
using DataLayer.Models.UserModels;
using GUI.Controllers;
using GUI.Properties;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class YourSectionsForm : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        private FacultyUserModel faculty1;

        public YourSectionsForm(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
            labelWelcome.Text = faculty.FullName;

            SectionController controller = new SectionController();
            try
            {
                List<SectionModel> sectionList = controller.GetByFaculty(faculty);
                if (sectionList.Count == 0)
                {
                    Label noSections = new Label();
                    noSections.Text = "You have no sections added. To add a section,";
                    noSections.Font = new Font("Arial", 12, FontStyle.Regular);
                    noSections.TextAlign = ContentAlignment.MiddleCenter;
                    noSections.ForeColor = Color.FromArgb(217, 217, 217);
                    noSections.AutoSize = true;
                    noSections.Margin = new Padding(3, 3, 0, 3);

                    flowLayoutPanelSections.Controls.Add(noSections);

                    Label clickHere = new Label();
                    clickHere.Text = "click here";
                    clickHere.Font = new Font("Arial", 12, FontStyle.Underline);
                    clickHere.ForeColor = Color.FromArgb(217, 217, 217);
                    clickHere.Margin = new Padding(0, 3, 3, 3);
                    clickHere.Cursor = Cursors.Hand;
                    clickHere.Click += new System.EventHandler(this.ClickHere_Click); ;

                    flowLayoutPanelSections.Controls.Add(clickHere);
                }
                int r = 28;
                int g = 124;
                int b = 143;
                int i = 1;
                foreach (SectionModel model in sectionList)
                {
                    //Console.WriteLine("Name: " + model.SectionName);
                    FlowLayoutPanel sectionPanel = new FlowLayoutPanel();
                    sectionPanel.Width = 188;
                    sectionPanel.Height = 110;
                    sectionPanel.BorderStyle = BorderStyle.None;
                    sectionPanel.Margin = new Padding(0, 3, 7, 5);
                    sectionPanel.BackColor = Color.FromArgb(r, g, b);
                    sectionPanel.FlowDirection = FlowDirection.LeftToRight;
                    sectionPanel.WrapContents = true;
                    sectionPanel.AutoScroll = false;
                    sectionPanel.VerticalScroll.Visible = false;
                    sectionPanel.HorizontalScroll.Enabled = false;
                    flowLayoutPanelSections.Controls.Add(sectionPanel);

                    Label labelSectionName = new Label();
                    labelSectionName.Text = model.SectionName;
                    labelSectionName.Font = new Font("Arial", 10, FontStyle.Regular);
                    labelSectionName.ForeColor = Color.FromArgb(217, 217, 217);
                    labelSectionName.AutoSize = false;
                    labelSectionName.Size = new Size(sectionPanel.Width - 4, 32);
                    labelSectionName.Margin = new Padding(5, 8, 0, 3);
                    labelSectionName.UseMnemonic = false;

                    sectionPanel.Controls.Add(labelSectionName);

                    SectionTimeController timeController = new SectionTimeController();
                    List<SectionTimeModel> sectionTimes = timeController.GetBySection(model);

                    foreach (SectionTimeModel timeModel in sectionTimes)
                    {
                        WeekDayController dayCon = new WeekDayController();
                        ClassTimeController classCon = new ClassTimeController();

                        Label sectionTimeText1 = new Label();
                        sectionTimeText1.Text = timeModel.ClassType + ": " + dayCon.Get(timeModel.WeekDayId).WeekDayText.Substring(0, 3) + " " + classCon.Get(timeModel.StartTimeId).ClassTimeText + " - " + classCon.Get(timeModel.EndTimeId).ClassTimeText + " [" + timeModel.RoomNo + "]";
                        if (sectionTimes.Count == 2)
                            sectionTimeText1.AutoSize = true;
                        else
                            sectionTimeText1.Size = new Size(sectionPanel.Width - 4, 32);
                        sectionTimeText1.Font = new Font("Arial", 8, FontStyle.Italic);
                        sectionTimeText1.ForeColor = Color.FromArgb(217, 217, 217);

                        if (timeModel == sectionTimes[0])
                            sectionTimeText1.Margin = new Padding(4, 0, 0, 0);
                        else
                            sectionTimeText1.Margin = new Padding(4, 0, 0, 4);

                        sectionPanel.Controls.Add(sectionTimeText1);
                    }

                    Button studentsButton = new Button();
                    studentsButton.Text = "Students";
                    studentsButton.BackColor = Color.FromArgb(38, 143, 164);
                    studentsButton.Cursor = Cursors.Hand;
                    studentsButton.FlatAppearance.BorderSize = 0;
                    studentsButton.FlatStyle = FlatStyle.Flat;
                    studentsButton.Font = new Font("Arial", 10F);
                    studentsButton.ForeColor = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    studentsButton.AutoSize = false;
                    studentsButton.Size = new Size(75, 25);
                    studentsButton.Margin = new Padding(12, 2, 6, 0);
                    studentsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                    studentsButton.Dock = DockStyle.Bottom | DockStyle.Left;
                    studentsButton.Click += delegate (object sender, EventArgs e) { studentsButton_Click(sender, e, model); };


                    sectionPanel.Controls.Add(studentsButton);

                    Button editButton = new Button();
                    editButton.Text = "Edit";
                    editButton.BackColor = Color.FromArgb(38, 143, 164);
                    editButton.Cursor = Cursors.Hand;
                    editButton.FlatAppearance.BorderSize = 0;
                    editButton.FlatStyle = FlatStyle.Flat;
                    editButton.Font = new Font("Arial", 10F);
                    editButton.ForeColor = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    editButton.AutoSize = false;
                    editButton.Size = new Size(75, 25);
                    editButton.Margin = new Padding(6, 2, 12, 0);
                    editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                    editButton.Click += delegate (object sender, EventArgs e) { editButton_Click(sender, e, model, sectionTimes); };

                    sectionPanel.Controls.Add(editButton);

                    if (i % 3 == 0)
                    {
                        r -= 5; g -= 5; b -= 5;
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClickHere_Click(object sender, EventArgs e)
        {
            var addSection = new FormAddSection(faculty);
            addSection.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            addSection.Show();
            this.Hide();
        }

        private void studentsButton_Click(object sender, EventArgs e, SectionModel section)
        {
            //Console.WriteLine("Students clicked on " + section.SectionName);
            var students = new FormStudentList(faculty, section);
            students.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            students.Show();
            this.Hide();
        }

        private void editButton_Click(object sender, EventArgs e, SectionModel section, List<SectionTimeModel> sectionTimes)
        {
            var edit = new EditSectionForm(faculty, section, sectionTimes);
            edit.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            edit.Show();
            this.Hide();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
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

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            var dash = new FormDashboard(faculty);
            dash.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            dash.Show();
            this.Hide();
        }

        private void FormYourSections_Load(object sender, EventArgs e)
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
