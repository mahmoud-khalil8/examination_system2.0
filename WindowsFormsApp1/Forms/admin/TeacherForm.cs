using ADMIN.BusinessLogicLayer;
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
using WindowsFormsApp1.UserControls.TeacherUC;

namespace WindowsFormsApp1.Forms.admin
{
    public partial class TeacherForm : Form
    {
        UserModel admin;
        public TeacherForm(UserModel admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void AddTchBtn_Click(object sender, EventArgs e)
        {
            addTeacherUc1.Visible = true;
            dataGridView1.Visible = false;
            updTeacherUC1.Visible = false;
            deleteTeacherUC1.Visible = false;

        }

        private void OutTchBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form1 form1 = new Form1(admin);
            form1.Show();
        }

        private void ViewAllTchBtn_Click(object sender, EventArgs e)
        {
            addTeacherUc1.Visible = false;
            updTeacherUC1.Visible = false;
            dataGridView1.Visible = true;
            deleteTeacherUC1.Visible = false;
            dataGridView1.DataSource = TeacherBLL.GetAllTeachers();
        }

        private void DeleTchBtn_Click(object sender, EventArgs e)
        {
            deleteTeacherUC1.LoadTeachersData();
            addTeacherUc1.Visible = false;
            updTeacherUC1.Visible = false;
            dataGridView1.Visible = false;
            deleteTeacherUC1.Visible = true;
        }

        private void UpdTchBtn_Click(object sender, EventArgs e)
        {
            addTeacherUc1.Visible = false;
            updTeacherUC1.Visible = true;
            dataGridView1.Visible = false;
            deleteTeacherUC1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteTeacherUC1_Load(object sender, EventArgs e)
        {

        }
    }
}
