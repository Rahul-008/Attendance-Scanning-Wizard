using DataLayer.Models;
using DataLayer.Models.UserModels;
using GUI.Controllers;
using GUI.Controllers.BaseController;
using GUI.Properties;
using GUI.Utils;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FormStudentList : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        SectionModel section = new SectionModel();
        List<StudentUserModel> studentList = new List<StudentUserModel>();
        List<ClassModel> classList = new List<ClassModel>();
        List<AttendanceModel> attendanceList = new List<AttendanceModel>();

        public FormStudentList(FacultyUserModel gotFaculty, SectionModel gotSection)
        {
            InitializeComponent();
            faculty = gotFaculty;
            section = gotSection;

            labelWelcome.Text = faculty.FullName;
            labelStudents.Text = "Students of " + section.SectionName;

            try
            {
                UserController controller = new UserController();
                studentList = controller.GetBySection(section);
                ClassController ccontroller = new ClassController();
                classList = ccontroller.GetBySectionId(section.Id);
                AttendanceController acontroller = new AttendanceController();
                attendanceList = acontroller.GetAllBySection(section.Id);

                //Console.WriteLine("Found student: " + studentList.Count);
                //Console.WriteLine("Found classes: " + classList.Count);
                //Console.WriteLine("Found attendances: " + attendanceList.Count);

                DataGridViewColumn sln = new DataGridViewTextBoxColumn();
                sln.HeaderText = "#";
                sln.Width = 30;
                sln.ReadOnly = true;
                dataGridViewSln.Columns.Add(sln);

                DataGridViewColumn IdCol = new DataGridViewTextBoxColumn();
                IdCol.HeaderText = "ID";
                IdCol.Width = 75;
                IdCol.ReadOnly = true;
                dataGridViewStudentList.Columns.Add(IdCol);
                DataGridViewColumn FullNameCol = new DataGridViewTextBoxColumn();
                FullNameCol.HeaderText = "Name";
                FullNameCol.Width = 200;
                FullNameCol.ReadOnly = true;
                dataGridViewStudentList.Columns.Add(FullNameCol);

                foreach (ClassModel Class in classList)
                {
                    DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                    DateTime date = DateTime.Parse(Class.ClassDate);
                    string dateMod = date.ToString("MMM-dd");
                    col.HeaderText = dateMod;
                    col.ReadOnly = false;
                    col.Width = 50;
                    col.MaxInputLength = 1;
                    col.ValueType = typeof(string);
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridViewStudentList.Columns.Add(col);
                }

                int i = 0;
                foreach (StudentUserModel student in studentList)
                {
                    //Console.WriteLine("doing student no. " + i);
                    StudentView view = new StudentView();
                    view.AcademicId = student.AcademicId;
                    view.FullName = student.FullName;
                    dataGridViewStudentList.Rows.Add();
                    dataGridViewSln.Rows.Add();
                    dataGridViewSln.Rows[i].Cells[0].Value = i + 1;
                    dataGridViewStudentList.Rows[i].Cells[0].Value = student.AcademicId;
                    dataGridViewStudentList.Rows[i].Cells[1].Value = student.FullName;
                    int c = 0;

                    foreach (ClassModel Class in classList)
                    {
                        AttendanceModel att = attendanceList.Find(x => (x.ClassId == Class.Id) && (x.StudentId == student.Id));
                        //Console.WriteLine("Found attendance id: " + att.Id + " for: " + student.Id + " on: " + Class.Id + " entry: " + att.Entry);
                        if (att.Entry == 2)
                        {
                            dataGridViewStudentList.Rows[i].Cells[c + 2].Value = "L";
                        }
                        else
                        {
                            dataGridViewStudentList.Rows[i].Cells[c + 2].Value = att.Entry.ToString();
                        }
                        c++;
                    }
                    i++;
                }

                MySortableBindingList<StudentUserModel> studentListSortable = new MySortableBindingList<StudentUserModel>(studentList);

                dataGridViewStudentList.DataBindingComplete += (o, e) =>
                {
                    foreach (DataGridViewColumn column in dataGridViewStudentList.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.Programmatic;
                    }
                };

                foreach (DataGridViewColumn column in dataGridViewStudentList.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (classList.Count != 0)
            {
                DataGridViewTextBoxColumn totalCol = new DataGridViewTextBoxColumn();
                totalCol.HeaderText = "Total";
                totalCol.Width = 38;
                totalCol.ReadOnly = true;
                totalCol.Name = "Total";
                totalCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewStudentList.Columns.Add(totalCol);

                foreach (DataGridViewRow row in dataGridViewStudentList.Rows)
                {
                    int sum = 0;
                    int classNo = 0;
                    foreach (ClassModel Class in classList)
                    {
                        if (row.Cells[classNo + 2].Value.ToString() == "L" || row.Cells[classNo + 2].Value.ToString() == "l")
                        {
                            sum += 1;
                        }
                        else if (row.Cells[classNo + 2].Value.ToString() == "1")
                        {
                            sum += 1;
                        }
                        classNo++;
                    }
                    row.Cells["Total"].Value = sum.ToString();
                }
            }
        }

        private void dash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            var yourSection = new YourSectionsForm(faculty);
            yourSection.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            yourSection.Show();
            this.Hide();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            var addStudent = new AddStudentForm(faculty, section);
            addStudent.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            addStudent.ShowDialog();
            this.Hide();

            dataGridViewStudentList.Update();
            dataGridViewStudentList.Refresh();
        }

        private void dataGridViewStudentList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dataGridViewStudentList.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dataGridViewStudentList.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    dataGridViewStudentList.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            dataGridViewStudentList.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void dataGridViewStudentList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = dataGridViewStudentList.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverColumn = dataGridViewStudentList.HitTest(e.X, e.Y).ColumnIndex;

                if (currentMouseOverRow >= 0)
                {


                    if (currentMouseOverColumn > 1 && currentMouseOverColumn < dataGridViewStudentList.ColumnCount - 1)
                    {
                        var editClass = new MenuItem(string.Format("Edit Class"));
                        m.MenuItems.Add(editClass);
                        var deleteClass = new MenuItem(string.Format("Delete Class"));
                        m.MenuItems.Add(deleteClass);
                        var clickedClass = classList[currentMouseOverColumn - 2];
                        editClass.Click += delegate (object s, EventArgs ev) { EditClass_Click(sender, e, clickedClass); };
                        deleteClass.Click += delegate (object s, EventArgs ev) { DeleteClass_Click(sender, e, clickedClass); };
                    }
                    else if (currentMouseOverColumn < 2)
                    {
                        var remove = new MenuItem(string.Format("Remove " + dataGridViewStudentList.Rows[currentMouseOverRow].Cells[currentMouseOverColumn].Value.ToString() + " from section"));
                        m.MenuItems.Add(remove);
                        var add = new MenuItem(string.Format("Add student"));
                        m.MenuItems.Add(add);
                        string data = dataGridViewStudentList.Rows[currentMouseOverRow].Cells[1].Value.ToString() + "(" + dataGridViewStudentList.Rows[currentMouseOverRow].Cells[0].Value.ToString() + ")";
                        string id = dataGridViewStudentList.Rows[currentMouseOverRow].Cells[0].Value.ToString();
                        remove.Click += delegate (object s, EventArgs ev) { Remove_Click(sender, e, data, id); };
                        add.Click += delegate (object s, EventArgs ev) { buttonAddStudent_Click(s, ev); };
                    }
                }

                m.Show(dataGridViewStudentList, new Point(e.X, e.Y));
            }
        }

        private void DeleteClass_Click(object sender, MouseEventArgs e, ClassModel clickedClass)
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
                    acontroller.DeleteAllByClass(clickedClass.Id);

                    ccontroller.Delete(clickedClass);
                    MessageBox.Show("Deleted!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditClass_Click(object sender, MouseEventArgs e, ClassModel clickedClass)
        {
            if (DateTime.Parse(clickedClass.ClassDate) >= DateTime.Today)
            {
                var editClass = new EditClassPopupForm(faculty, clickedClass);
                editClass.FormClosed += new FormClosedEventHandler(dash_FormClosed);
                editClass.ShowDialog();
            }
            else
            {
                MessageBox.Show("Can't edit past classes");
            }
        }

        private void Remove_Click(object sender, EventArgs e, string data, string id)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to remove " + data + "?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                UserController ucontroller = new UserController();
                try
                {
                    int gotId = ucontroller.GetIdByAcademicId(id);
                    Console.WriteLine("deleting number: " + gotId);
                    SectionStudentController sscontroller = new SectionStudentController();
                    try
                    {
                        foreach (ClassModel Class in classList)
                        {
                            AttendanceController attendanceController = new AttendanceController();
                            attendanceController.DeleteAllByStudentInSection(gotId, section.Id);
                        }
                        sscontroller.Remove(section.Id, gotId);
                        MessageBox.Show("Removed!" + data);
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
        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search")
            {
                textBoxSearch.Clear();
                textBoxSearch.ForeColor = Color.FromArgb(217, 217, 217);
            }
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.ForeColor = Color.FromArgb(112, 112, 112);
                textBoxSearch.Text = "Search";
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                if (char.IsDigit(textBoxSearch.Text[0]))
                {
                    foreach (DataGridViewRow row in dataGridViewStudentList.Rows)
                    {
                        if (row.Cells[0].Value.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()))
                        {
                            row.Selected = true;
                            dataGridViewStudentList.FirstDisplayedScrollingRowIndex = dataGridViewStudentList.SelectedRows[0].Index;
                            break;
                        }
                    }
                }
                else if (char.IsLetter(textBoxSearch.Text[0]))
                {
                    foreach (DataGridViewRow row in dataGridViewStudentList.Rows)
                    {
                        if (row.Cells[1].Value.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()))
                        {
                            row.Selected = true;
                            dataGridViewStudentList.FirstDisplayedScrollingRowIndex = dataGridViewStudentList.SelectedRows[0].Index;
                            break;
                        }
                    }
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            var students = new FormStudentList(faculty, section);
            students.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            students.Show();
            this.Hide();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            var dash = new FormDashboard(faculty);
            dash.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            dash.Show();
            this.Hide();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            buttonSearh.PerformClick();
        }

        private void dataGridViewStudentList_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridViewSln.FirstDisplayedScrollingRowIndex = dataGridViewStudentList.FirstDisplayedScrollingRowIndex;
        }

        private void dataGridViewStudentList_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewSln_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewSln.ClearSelection();
        }

        private void DataGridViewStudentList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewStudentList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.dataGridViewStudentList.CurrentCell.ColumnIndex > 1 & (e.Control != null))
            {
                TextBox tb = (TextBox)e.Control;
                tb.KeyPress += TextBox_KeyPress;
            }
        }

        private void TextBox_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '1' || e.KeyChar == '0' || e.KeyChar == 'l' || e.KeyChar == 'L' || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void DataGridViewStudentList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 1)
            {
                int stuId = studentList[e.RowIndex].Id;
                int classId = classList[e.ColumnIndex - 2].Id;
                int entry = 0;
                if (dataGridViewStudentList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "l" || dataGridViewStudentList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "L")
                {
                    entry = 2;
                }
                else if (dataGridViewStudentList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "1")
                {
                    entry = 1;
                }
                //Console.WriteLine("Changed entry of " + stuId + " on " + classId + " to " + entry);

                AttendanceController attendanceController = new AttendanceController();
                try
                {
                    attendanceController.UpdateManualByStudentIdAndClassIdAndEntry(stuId, classId, entry);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void ButtonInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipInfo.Show("Insert 1 for present, 0 for absent, L for late. Note: Late will be counted as present in Total column", buttonInfo);
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void FormStudentList_Load(object sender, EventArgs e)
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

        public class StudentView
        {
            public string AcademicId { get; set; }
            public string FullName { get; set; }
            public List<int> attendances { get; set; } = new List<int>();
        }

        private void ButtonAddStudent_Click_1(object sender, EventArgs e)
        {
            var addStudent = new AddStudentForm(faculty, section);
            addStudent.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            addStudent.ShowDialog();
            this.Hide();

            dataGridViewStudentList.Update();
            dataGridViewStudentList.Refresh();
        }
    }
}