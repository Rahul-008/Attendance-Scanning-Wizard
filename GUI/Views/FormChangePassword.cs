using DataLayer.Models;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FormChangePassword : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        public FormChangePassword(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
