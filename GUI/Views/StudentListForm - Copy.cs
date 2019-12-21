using DataLayer.Models;
using GUI.Controllers;
using GUI.Controllers.BaseController;
using GUI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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

            //try
            //{
                UserController controller = new UserController();
                studentList = controller.GetBySection(section);
                ClassController ccontroller = new ClassController();
                classList = ccontroller.GetBySectionId(section.Id);
                AttendanceController acontroller = new AttendanceController();
                attendanceList = acontroller.GetAllBySection(section.Id);

                Console.WriteLine("Found student: " + studentList.Count);
                Console.WriteLine("Found classes: " + classList.Count);
                Console.WriteLine("Found attendances: " + attendanceList.Count);

                List<StudentView> mainList = new List<StudentView>();

                int i = 0;
                foreach(StudentUserModel student in studentList)
                {
                    Console.WriteLine("doing student no. " + i);
                    StudentView view = new StudentView();
                    view.AcademicId = student.AcademicId;
                    view.FullName = student.FullName;
                    int c = 0;
                    foreach(ClassModel Class in classList)
                    {
                        AttendanceModel att = attendanceList.Find(x => (x.ClassId == Class.Id) && (x.StudentId == student.Id));
                        Console.WriteLine("Found attendance id: " + att.Id + " for: " + student.Id + " on: " + Class.Id + " entry: " + att.Entry);
                        view.attendances.Add(att.Entry);

                        DataGridViewColumn col = new DataGridViewTextBoxColumn();
                        col.HeaderText = Class.ClassDate;
                        int colIndex = dataGridViewStudentList.Columns.Add(col);
                        //dataGridViewStudentList.Rows[i].Cells[c+2].Value = att.Entry.ToString();
                        c++;
                    }
                    mainList.Add(view);
                    
                    i++;
                }

                Console.WriteLine("Main list count: " + mainList.Count);
                MySortableBindingList<StudentView> mainListBinding = new MySortableBindingList<StudentView>(mainList);

                dataGridViewStudentList.AutoGenerateColumns = false;
                dataGridViewStudentList.DataSource = mainListBinding;
                dataGridViewSerial.AutoGenerateColumns = false;
                dataGridViewSerial.DataSource = mainListBinding;
                dataGridViewSerial.Columns[0].DefaultCellStyle.Padding = new Padding(3, 0, 0, 0);
                dataGridViewStudentList.DataBindingComplete += (o, e) =>
                {
                    foreach (DataGridViewRow row in dataGridViewSerial.Rows)
                    {
                        row.Cells["sln"].Value = (row.Index + 1).ToString();
                    }
                    foreach (DataGridViewColumn column in dataGridViewStudentList.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.Programmatic;
                    }
                };

                foreach (DataGridViewColumn column in dataGridViewStudentList.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
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
            dataGridViewSerial.Update();
            dataGridViewSerial.Refresh();
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
                    var remove = new MenuItem(string.Format("Remove " + dataGridViewStudentList.Rows[currentMouseOverRow].Cells[currentMouseOverColumn].Value.ToString() + " from section"));
                    m.MenuItems.Add(remove);
                    string data = dataGridViewStudentList.Rows[currentMouseOverRow].Cells[1].Value.ToString() + "(" + dataGridViewStudentList.Rows[currentMouseOverRow].Cells[0].Value.ToString() + ")";
                    string id = dataGridViewStudentList.Rows[currentMouseOverRow].Cells[0].Value.ToString();
                    remove.Click += delegate (object s, EventArgs ev) { Remove_Click(sender, e, data, id); };
                }

                m.Show(dataGridViewStudentList, new Point(e.X, e.Y));
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
            List<StudentUserModel> foundStudentList = studentList.Where(model => (model.FullName.ToUpper().Contains(textBoxSearch.Text.ToUpper()) || model.AcademicId.Contains(textBoxSearch.Text))).ToList();
            MySortableBindingList<StudentUserModel> foundStudentListSortable = new MySortableBindingList<StudentUserModel>(foundStudentList);

            dataGridViewStudentList.AutoGenerateColumns = false;
            dataGridViewStudentList.DataSource = foundStudentListSortable;
            dataGridViewSerial.AutoGenerateColumns = false;
            dataGridViewSerial.DataSource = foundStudentListSortable;
            dataGridViewSerial.Columns[0].DefaultCellStyle.Padding = new Padding(3, 0, 0, 0);
            dataGridViewStudentList.DataBindingComplete += (o, ev) =>
            {
                foreach (DataGridViewRow row in dataGridViewSerial.Rows)
                {
                    row.Cells["sln"].Value = (row.Index + 1).ToString();
                }
                foreach (DataGridViewColumn column in dataGridViewStudentList.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Programmatic;
                }
            };

            foreach (DataGridViewColumn column in dataGridViewStudentList.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            dataGridViewSerial.Update();
            dataGridViewSerial.Refresh();
            dataGridViewStudentList.Update();
            dataGridViewStudentList.Refresh();
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
    }

    public class StudentView
    {
        public string AcademicId { get; set; }
        public string FullName { get; set; }
        public List<int> attendances { get; set; } = new List<int>();
    }
}