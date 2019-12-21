using DataLayer.Models;
using DataLayer.Models.UserModels;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class OpenSpreadSheetForm : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        public OpenSpreadSheetForm(FacultyUserModel gotFaculty)
        {
            InitializeComponent();

            faculty = gotFaculty;
        }

        DataTableCollection tableCollection;
        DataTable dt = new DataTable();

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        textBoxFileName.Text = dialog.FileName;
                        using (var stream = File.Open(dialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = result.Tables;
                                comboBoxSheet.Items.Clear();
                                foreach (DataTable table in tableCollection)
                                {
                                    comboBoxSheet.Items.Add(table.TableName);
                                }
                                comboBoxSheet.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var addSection = new FormAddSection(faculty);
            addSection.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            addSection.Show();
            this.Hide();
        }

        private void OpenSpreadSheetForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 3),
                            this.DisplayRectangle);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFileName.Text))
                {
                    throw new Exception("Please select an Excel file using the browse button");
                }
                if (!textBoxFileName.Text.EndsWith(".xlsx"))
                {
                    throw new Exception("Invalid file. Please select an .xlsx file");
                }
                if(comboBoxSheet.Items.Count == 0)
                {
                    throw new Exception("Sheets failed to load. Please try again");
                }
                if (comboBoxSheet.SelectedIndex == -1)
                {
                    throw new Exception("Please select a sheet from the dropdown to import that sheet");
                }
                if (dt.Columns.Count < 2)
                {
                    throw new Exception("Sheet doesn't contain enough columns. Please select a proper sheet");
                }

                if (dt.Columns.Count > 2)
                {
                    DialogResult dialogResult = MessageBox.Show("Sheet contains more than two columns. Column 1 will be rendered as Academic ID and column 2 will be rendered as Name. Continue?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            var createManual = new CreateManualFrom(faculty, GenerateStudents(dt));
                            createManual.FormClosed += new FormClosedEventHandler(dash_FormClosed);
                            createManual.Show();
                            this.Hide();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    try
                    {
                        var createManual = new CreateManualFrom(faculty, GenerateStudents(dt));
                        createManual.FormClosed += new FormClosedEventHandler(dash_FormClosed);
                        createManual.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = tableCollection[comboBoxSheet.SelectedItem.ToString()];
            dataGridViewStudenList.DataSource = dt;

            dataGridViewStudenList.Update();
            dataGridViewStudenList.Refresh();
        }

        private List<StudentUserModel> GenerateStudents (DataTable dt)
        {
            List<StudentUserModel> studentList = new List<StudentUserModel>();
            StudentUserModel studentAtHeader = new StudentUserModel();
            try
            {
                studentAtHeader.AcademicId = dt.Columns[0].ColumnName;
                studentAtHeader.LastName = dt.Columns[1].ColumnName.Split(' ').Last();
                int lastL = studentAtHeader.LastName.Length;
                if (studentAtHeader.LastName == dt.Columns[1].ColumnName)
                {
                    studentAtHeader.FirstName = studentAtHeader.LastName;
                }
                else
                {
                    studentAtHeader.FirstName = dt.Columns[1].ColumnName.Substring(0, dt.Columns[1].ColumnName.Length - lastL);
                }
                //Console.WriteLine("Doing header " + studentAtHeader.AcademicId + " " + studentAtHeader.LastName + ", " + studentAtHeader.FirstName);
                try
                {
                    studentAtHeader.IsValid();
                    studentList.Add(studentAtHeader);
                    //Console.WriteLine("Added header");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid entry at header: " + dt.Columns[0].ColumnName + ", " + dt.Columns[1].ColumnName + ".\nError: " + ex.Message + "\nThis header will be skipped");
                }
            }
            catch
            {
                MessageBox.Show("Invalid name: " + dt.Columns[1].ColumnName);
            }
            

            foreach (DataRow row in dt.Rows)
            {
                StudentUserModel student = new StudentUserModel();
                try
                {
                    student.AcademicId = row[0].ToString();
                    student.LastName = row[1].ToString().Split(' ').Last();
                    student.LastName = student.LastName.Trim();
                    int lastLength = student.LastName.Length;
                    if (student.LastName == row[0].ToString())
                    {
                        student.FirstName = student.LastName;
                    }
                    else
                    {
                        student.FirstName = row[1].ToString().Substring(0, row[1].ToString().Length - (lastLength + 1));
                    }
                    //Console.WriteLine("Doing " + student.AcademicId + " " + student.LastName + ", " + student.FirstName);
                    try
                    {
                        student.IsValid();
                        studentList.Add(student);
                        //Console.WriteLine("Added");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid entry at row: " + row[0].ToString() + ", " + row[1].ToString() + ".\nError: " + ex.Message + "\nThis row will be skipped");
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid name: " + row[1].ToString() + "\n this entry will be skipped");
                }
            }

            return studentList;
        }

        private void dash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }

}
