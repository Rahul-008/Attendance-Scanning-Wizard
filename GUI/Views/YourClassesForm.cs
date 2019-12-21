using DataLayer.Models;
using GUI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using GUI.Properties;
using QRCoder;
using DataLayer.Models.UserModels;

namespace GUI.Views
{
    public partial class YourClassesForm : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        FlowLayoutPanel flowLayoutPanelToday = new FlowLayoutPanel();
        FlowLayoutPanel flowLayoutPanelTomorrow = new FlowLayoutPanel();
        public YourClassesForm(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
            labelWelcome.Text = faculty.FullName;

            Label labelToday = new Label();
            labelToday.Anchor = System.Windows.Forms.AnchorStyles.Left;
            labelToday.AutoSize = true;
            labelToday.Font = new System.Drawing.Font("Arial", 12.5F);
            labelToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            labelToday.Location = new System.Drawing.Point(25, 151);
            labelToday.Margin = new System.Windows.Forms.Padding(20, 10, 0, 10);
            labelToday.Name = "labelToday";
            labelToday.Size = new System.Drawing.Size(52, 19);
            labelToday.TabIndex = 8;
            labelToday.Text = "Today";
            labelToday.Margin = new Padding(25, 13, 0, 0);

            flowLayoutPanelClasses.Controls.Add(labelToday);

            Panel panelTodayUL = new Panel();
            panelTodayUL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            panelTodayUL.Location = new System.Drawing.Point(20, 178);
            panelTodayUL.Name = "panelTodayUL";
            panelTodayUL.Size = new System.Drawing.Size(576, 1);
            panelTodayUL.TabIndex = 9;
            panelTodayUL.Margin = new Padding(19, 8, 0, 0);

            flowLayoutPanelClasses.Controls.Add(panelTodayUL);

            flowLayoutPanelToday.AutoScroll = false;
            flowLayoutPanelToday.AutoSize = true;
            flowLayoutPanelToday.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelToday.Location = new System.Drawing.Point(20, 186);
            flowLayoutPanelToday.Name = "flowLayoutPanelToday";
            flowLayoutPanelToday.Size = new System.Drawing.Size(0, 0);
            flowLayoutPanelToday.TabIndex = 10;
            flowLayoutPanelToday.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelToday_ControlAdded);
            flowLayoutPanelToday.WrapContents = true;
            flowLayoutPanelToday.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelToday.Margin = new Padding(19, 5, 0, 0);

            ClassController ccontroller = new ClassController();
            List<ClassModel> todaysClasses = ccontroller.GetByDateAndFacultyId(DateTime.Today.ToString("yyyy-MM-dd"), faculty.Id);
            //todaysClasses.Sort();
            //Console.WriteLine("Found " + todaysClasses.Count + "classes");
            int r = 112;
            int g = 52;
            int b = 158;
            if (todaysClasses.Count != 0)
            {
                foreach (ClassModel model in todaysClasses)
                {
                    Panel classPanel = new Panel();
                    classPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(r)))), ((int)(((byte)(g)))), ((int)(((byte)(b)))));
                    classPanel.Size = new System.Drawing.Size(285, 71);
                    classPanel.Margin = new Padding(0, 0, 5, 5);

                    SectionController scontroller = new SectionController();
                    var gotSection = scontroller.Get(model.SectionId);
                    Label sectionName = new Label();
                    sectionName.Text = gotSection.SectionName;
                    sectionName.Anchor = System.Windows.Forms.AnchorStyles.Left;
                    sectionName.AutoSize = false;
                    sectionName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    sectionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    sectionName.Location = new System.Drawing.Point(10, 10);
                    sectionName.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
                    sectionName.Name = "labelSectionName";
                    sectionName.Size = new System.Drawing.Size(217, 32);

                    classPanel.Controls.Add(sectionName);

                    Label classType = new Label();
                    classType.Text = model.ClassType.ToString();
                    classType.Anchor = System.Windows.Forms.AnchorStyles.Left;
                    classType.AutoSize = true;
                    classType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
                    classType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    classType.Location = new System.Drawing.Point(10, 45);
                    classType.Margin = new System.Windows.Forms.Padding(10, 3, 0, 0);
                    classType.Name = "labelClassType";
                    classType.Size = new System.Drawing.Size(53, 16);

                    classPanel.Controls.Add(classType);

                    ClassTimeController ctcontroller = new ClassTimeController();
                    Label classTime = new Label();
                    classTime.Text = ctcontroller.Get(model.StartTimeId).ClassTimeText + " - " + ctcontroller.Get(model.EndTimeId).ClassTimeText;
                    classTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
                    classTime.AutoSize = true;
                    classTime.Font = new System.Drawing.Font("Arial", 10F);
                    classTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    classTime.Location = new System.Drawing.Point(73, 45);
                    classTime.Margin = new System.Windows.Forms.Padding(10, 3, 0, 0);
                    classTime.Name = "labelClassTime";
                    classTime.Size = new System.Drawing.Size(93, 16);

                    classPanel.Controls.Add(classTime);

                    Label roomNo = new Label();
                    roomNo.Text = model.RoomNo;
                    roomNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
                    roomNo.AutoSize = true;
                    roomNo.Font = new System.Drawing.Font("Arial", 10F);
                    roomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    roomNo.Location = new System.Drawing.Point(176, 45);
                    roomNo.Margin = new System.Windows.Forms.Padding(10, 3, 0, 0);
                    roomNo.Name = "labelRoomNo";
                    roomNo.Size = new System.Drawing.Size(50, 16);

                    classPanel.Controls.Add(roomNo);

                    Button buttonEdit = new Button();
                    buttonEdit.BackgroundImage = Properties.Resources.edit;
                    buttonEdit.Location = new System.Drawing.Point(250, 8);
                    buttonEdit.Size = new System.Drawing.Size(20, 20);
                    buttonEdit.FlatStyle = FlatStyle.Flat;
                    buttonEdit.FlatAppearance.BorderSize = 0;
                    buttonEdit.Cursor = Cursors.Hand;
                    buttonEdit.BackgroundImageLayout = ImageLayout.Stretch;
                    buttonEdit.Click += (sender, EventArgs) => { ButtonEdit_Click(sender, EventArgs, model); }; ;

                    classPanel.Controls.Add(buttonEdit);

                    Button buttonDelete = new Button();
                    buttonDelete.BackgroundImage = Properties.Resources.delete;
                    buttonDelete.Location = new System.Drawing.Point(250, 40);
                    buttonDelete.Size = new System.Drawing.Size(22, 22);
                    buttonDelete.FlatStyle = FlatStyle.Flat;
                    buttonDelete.FlatAppearance.BorderSize = 0;
                    buttonDelete.Cursor = Cursors.Hand;
                    buttonDelete.BackgroundImageLayout = ImageLayout.Center;
                    buttonDelete.Click += (sender, EventArgs) => { ButtonDelete_Click(sender, EventArgs, model); }; ;

                    classPanel.Controls.Add(buttonDelete);

                    flowLayoutPanelToday.Controls.Add(classPanel);

                    r -= 5; g -= 5; b -= 5;
                }
            }
            else
            {
                Label labelNoClasses = new Label();
                labelNoClasses.Anchor = System.Windows.Forms.AnchorStyles.Left;
                labelNoClasses.AutoSize = false;
                labelNoClasses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
                labelNoClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                labelNoClasses.Location = new System.Drawing.Point(25, 151);
                labelNoClasses.Margin = new System.Windows.Forms.Padding(20, 10, 0, 10);
                labelNoClasses.Name = "labelToday";
                labelNoClasses.Size = new System.Drawing.Size(500, 19);
                labelNoClasses.TabIndex = 8;
                labelNoClasses.Text = "No classes today";
                labelNoClasses.Margin = new Padding(25, 13, 0, 0);

                flowLayoutPanelClasses.Controls.Add(labelNoClasses);
            }

            flowLayoutPanelClasses.Controls.Add(flowLayoutPanelToday);

            Label labelTomorrow = new Label();
            labelTomorrow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            labelTomorrow.AutoSize = false;
            labelTomorrow.Font = new System.Drawing.Font("Arial", 12.5F);
            labelTomorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            labelTomorrow.Location = new System.Drawing.Point(25, 151);
            labelTomorrow.Margin = new System.Windows.Forms.Padding(20, 10, 0, 10);
            labelTomorrow.Name = "labelTomorrow";
            labelTomorrow.Size = new System.Drawing.Size(500, 19);
            labelTomorrow.TabIndex = 8;
            labelTomorrow.Text = "Tomorrow";
            labelTomorrow.Margin = new Padding(25, 13, 0, 0);

            flowLayoutPanelClasses.Controls.Add(labelTomorrow);

            Panel panelTommorrowUL = new Panel();
            panelTommorrowUL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            panelTommorrowUL.Location = new System.Drawing.Point(20, 178);
            panelTommorrowUL.Name = "panelTomorrowUL";
            panelTommorrowUL.Size = new System.Drawing.Size(576, 1);
            panelTommorrowUL.TabIndex = 9;
            panelTommorrowUL.Margin = new Padding(19, 8, 0, 0);

            flowLayoutPanelClasses.Controls.Add(panelTommorrowUL);

            flowLayoutPanelTomorrow.AutoScroll = false;
            flowLayoutPanelTomorrow.AutoSize = true;
            flowLayoutPanelTomorrow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelTomorrow.Location = new System.Drawing.Point(20, 186);
            flowLayoutPanelTomorrow.Name = "flowLayoutPanelToday";
            flowLayoutPanelTomorrow.Size = new System.Drawing.Size(0, 0);
            flowLayoutPanelTomorrow.TabIndex = 10;
            flowLayoutPanelTomorrow.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelToday_ControlAdded);
            flowLayoutPanelTomorrow.WrapContents = true;
            flowLayoutPanelTomorrow.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelTomorrow.Margin = new Padding(19, 5, 0, 0);

            List<ClassModel> tomorrowClasses = ccontroller.GetByDateAndFacultyId(DateTime.Today.AddDays(1).ToString("yyyy-MM-dd"), faculty.Id);
            //Console.WriteLine("Found " + todaysClasses.Count + "classes");
            int r2 = 112;
            int g2 = 52;
            int b2 = 158;
            if (tomorrowClasses.Count != 0)
            {
                foreach (ClassModel model in tomorrowClasses)
                {
                    Panel classPanel = new Panel();
                    classPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(r2)))), ((int)(((byte)(g2)))), ((int)(((byte)(b2)))));
                    classPanel.Size = new System.Drawing.Size(285, 71);
                    classPanel.Margin = new Padding(0, 0, 5, 5);

                    SectionController scontroller = new SectionController();
                    var gotSection = scontroller.Get(model.SectionId);
                    Label sectionName = new Label();
                    sectionName.Text = gotSection.SectionName;
                    sectionName.Anchor = System.Windows.Forms.AnchorStyles.Left;
                    sectionName.AutoSize = false;
                    sectionName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    sectionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    sectionName.Location = new System.Drawing.Point(10, 10);
                    sectionName.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
                    sectionName.Name = "labelSectionName";
                    sectionName.Size = new System.Drawing.Size(217, 32);

                    classPanel.Controls.Add(sectionName);

                    Label classType = new Label();
                    classType.Text = model.ClassType.ToString();
                    classType.Anchor = System.Windows.Forms.AnchorStyles.Left;
                    classType.AutoSize = true;
                    classType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
                    classType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    classType.Location = new System.Drawing.Point(10, 45);
                    classType.Margin = new System.Windows.Forms.Padding(10, 3, 0, 0);
                    classType.Name = "labelClassType";
                    classType.Size = new System.Drawing.Size(53, 16);

                    classPanel.Controls.Add(classType);

                    ClassTimeController ctcontroller = new ClassTimeController();
                    Label classTime = new Label();
                    classTime.Text = ctcontroller.Get(model.StartTimeId).ClassTimeText + " - " + ctcontroller.Get(model.EndTimeId).ClassTimeText;
                    classTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
                    classTime.AutoSize = true;
                    classTime.Font = new System.Drawing.Font("Arial", 10F);
                    classTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    classTime.Location = new System.Drawing.Point(73, 45);
                    classTime.Margin = new System.Windows.Forms.Padding(10, 3, 0, 0);
                    classTime.Name = "labelClassTime";
                    classTime.Size = new System.Drawing.Size(93, 16);

                    classPanel.Controls.Add(classTime);

                    Label roomNo = new Label();
                    roomNo.Text = model.RoomNo;
                    roomNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
                    roomNo.AutoSize = true;
                    roomNo.Font = new System.Drawing.Font("Arial", 10F);
                    roomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    roomNo.Location = new System.Drawing.Point(176, 45);
                    roomNo.Margin = new System.Windows.Forms.Padding(10, 3, 0, 0);
                    roomNo.Name = "labelRoomNo";
                    roomNo.Size = new System.Drawing.Size(50, 16);

                    classPanel.Controls.Add(roomNo);

                    Button buttonEdit = new Button();
                    buttonEdit.BackgroundImage = Properties.Resources.edit;
                    buttonEdit.Location = new System.Drawing.Point(250, 8);
                    buttonEdit.Size = new System.Drawing.Size(20, 20);
                    buttonEdit.FlatStyle = FlatStyle.Flat;
                    buttonEdit.FlatAppearance.BorderSize = 0;
                    buttonEdit.Cursor = Cursors.Hand;
                    buttonEdit.BackgroundImageLayout = ImageLayout.Stretch;
                    buttonEdit.Click += (sender, EventArgs) => { ButtonEdit_Click(sender, EventArgs, model); }; ;

                    classPanel.Controls.Add(buttonEdit);

                    Button buttonDelete = new Button();
                    buttonDelete.BackgroundImage = Properties.Resources.delete;
                    buttonDelete.Location = new System.Drawing.Point(250, 40);
                    buttonDelete.Size = new System.Drawing.Size(22, 22);
                    buttonDelete.FlatStyle = FlatStyle.Flat;
                    buttonDelete.FlatAppearance.BorderSize = 0;
                    buttonDelete.Cursor = Cursors.Hand;
                    buttonDelete.BackgroundImageLayout = ImageLayout.Center;
                    buttonDelete.Click += (sender, EventArgs) => { ButtonDelete_Click(sender, EventArgs, model); }; ;

                    classPanel.Controls.Add(buttonDelete);

                    flowLayoutPanelTomorrow.Controls.Add(classPanel);

                    r -= 5; g -= 5; b -= 5;
                }
            }
            else
            {
                Label labelNoClasses = new Label();
                labelNoClasses.Anchor = System.Windows.Forms.AnchorStyles.Left;
                labelNoClasses.AutoSize = false;
                labelNoClasses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
                labelNoClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                labelNoClasses.Location = new System.Drawing.Point(25, 151);
                labelNoClasses.Margin = new System.Windows.Forms.Padding(20, 10, 0, 10);
                labelNoClasses.Name = "labelToday";
                labelNoClasses.Size = new System.Drawing.Size(500, 19);
                labelNoClasses.TabIndex = 8;
                labelNoClasses.Text = "No classes tomorrow";
                labelNoClasses.Margin = new Padding(25, 13, 0, 0);

                flowLayoutPanelClasses.Controls.Add(labelNoClasses);
            }

            flowLayoutPanelClasses.Controls.Add(flowLayoutPanelTomorrow);
        }

        private void ButtonEdit_Click(object sender, EventArgs e, ClassModel model)
        {
            var editClass = new EditClassPopupForm(faculty, model);
            editClass.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            editClass.ShowDialog();
        }

        private void ButtonDelete_Click(object sender, EventArgs e, ClassModel model)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this class?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ClassController ccontroller = new ClassController();
                try
                {
                    AttendanceController acontroller = new AttendanceController();
                    acontroller.DeleteAllByClass(model.Id);

                    ccontroller.Delete(model);
                    MessageBox.Show("Deleted!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        private void flowLayoutPanelToday_ControlAdded(object sender, ControlEventArgs e)
        {
            if (flowLayoutPanelToday.Controls.Count % 2 == 0)
                flowLayoutPanelToday.SetFlowBreak(e.Control as Control, true);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var allClasses = new AllClassesForm(faculty);
            allClasses.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            allClasses.Show();
            this.Hide();
        }

        private void ButtonAddClass_Click(object sender, EventArgs e)
        {
            var addClass = new FormAddClass(faculty);
            addClass.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            addClass.Show();
            this.Hide();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            var yourClasses = new YourClassesForm(faculty);
            yourClasses.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            yourClasses.Show();
            this.Hide();
        }

        private void YourClassesForm_Load(object sender, EventArgs e)
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
