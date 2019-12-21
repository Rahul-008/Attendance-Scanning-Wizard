using DataLayer.Models;
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
    public partial class QRdisplayForm : Form
    {
        ClassModel Class = new ClassModel();
        public QRdisplayForm(ClassModel gotClass, Bitmap image)
        {
            InitializeComponent();
            Class = gotClass;

            pbQR.BackgroundImage = image;
            pbQR.BackgroundImageLayout = ImageLayout.Zoom;
            pbQR.BackColor = Color.White;
        }

        private void QRdisplayForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void QRdisplayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClassController classController = new ClassController();
            try
            {
                Console.WriteLine("trying");
                classController.InsertQRDisplayEndTime(Class.Id, DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
