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
using WindowsFormsApp1.UserControls.StdUC;

namespace WindowsFormsApp1.Forms.admin
{
    public partial class StudentForm : Form
    {

        UserModel admin;
        public StudentForm(UserModel _admin)
        {

            InitializeComponent();
            this.admin = _admin;
        }

        


        private void ViewAllStdBtn_Click(object sender, EventArgs e)
        {
            addStd3.Visible = false;
            dgvViewAll.BackgroundColor = Color.White;
            dgvViewAll.Size = new Size(974, 729);
            dgvViewAll.Visible = true;
            removeStd1.Visible = false;
            updateStdUc1.Visible = false;
            dgvViewAll.DataSource = StudentBLL.GetAllStudents();
        }

        private void addStd3_Load(object sender, EventArgs e)
        {

        }

        private void DeletStdBtn_Click(object sender, EventArgs e)
        {
            //DgvRemove.DataSource = BusinessLogicLayer.StudentBLL.GetALLStudents();
            removeStd1.LoadStudentsData();
            addStd3.Visible = false;
            dgvViewAll.Visible = false;
            removeStd1.Visible = true;
            updateStdUc1.Visible = false;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            dgvViewAll.DataSource = StudentBLL.GetAllStudents();
            addStd3.Visible = false;


        }

        private void UpdStdBtn_Click(object sender, EventArgs e)
        {
            addStd3.Visible = false;
            dgvViewAll.Visible = false;
            removeStd1.Visible = false;
            updateStdUc1.Visible = true;
        }

        private void OutStdBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            admin.Form1 form = new admin.Form1(admin);
            form.Show();
        }

        private void AddStdBtn_Click(object sender, EventArgs e)
        {

            addStd3.Visible = true;
            dgvViewAll.Visible = false;
            removeStd1.Visible = false;
            updateStdUc1.Visible = false;
        }

        private void updateStdUc1_Load(object sender, EventArgs e)
        {

        }
    }
}
