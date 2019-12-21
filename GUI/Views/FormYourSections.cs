using DataLayer.Models;
using DataLayer.Models.BaseModels;
using GUI.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FormYourSections : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        public FormYourSections(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
            labelWelcome.Text = faculty.FullName;

            SectionController controller = new SectionController();
            try
            {
                List<SectionModel> sectionList = controller.GetByFaculty(faculty);
                //Console.WriteLine("Sections: ");
                foreach (SectionModel model in sectionList)
                {
                    //Console.WriteLine("Name: " + model.SectionName);
                    Panel sectionPanel = new Panel();
                    sectionPanel.Width = 194;
                    sectionPanel.Height = 102;
                    sectionPanel.BorderStyle = BorderStyle.None;
                    sectionPanel.Margin = new Padding(0,3,7,5);
                    sectionPanel.BackColor = Color.FromArgb(38, 143, 164);
                    flowLayoutPanelSections.Controls.Add(sectionPanel);

                    Label labelSectionName = new Label();
                    labelSectionName.Text = model.SectionName;
                    labelSectionName.Font = new Font("Arial", 10, FontStyle.Regular);
                    labelSectionName.ForeColor = Color.FromArgb(217, 217, 217);
                    labelSectionName.Location = new Point(8, 8);
                    labelSectionName.Size = new Size(186,100);

                    SectionTimeController timeController = new SectionTimeController();
                    List<SectionTimeModel> sectionTimes = timeController.GetBySection(model);

                    sectionPanel.Controls.Add(labelSectionName);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            
        }
    }
}
