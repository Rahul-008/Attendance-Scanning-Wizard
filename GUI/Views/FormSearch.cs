using DataLayer.Models;
using DataLayer.Models.BaseModels;
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
    public partial class FormSearch : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        public FormSearch(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
            labelWelcome.Text = faculty.FullName;
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

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text == "Search")
            {
                textBoxSearch.Clear();
                textBoxSearch.ForeColor = Color.FromArgb(217, 217, 217);
            }
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Search";
                textBoxSearch.ForeColor = Color.FromArgb(156,156,156);
            }
        }
    }
}
