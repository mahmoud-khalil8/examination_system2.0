using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms.admin
{
    public partial class Form1 : Form
    {

        UserModel admin;
        public Form1( UserModel _admin)
        {
            
            InitializeComponent();
            this.admin = _admin;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MngStdsBtn_Click(object sender, EventArgs e)
        {
            StudentForm stdform = new StudentForm( admin);
            stdform.Show();
            //this.Hide();
        }

        private void MngTeachersBtn_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm( admin);
            teacherForm.Show();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonColorButton1_SelectedColorChanged(object sender, ComponentFactory.Krypton.Toolkit.ColorEventArgs e)
        {

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
