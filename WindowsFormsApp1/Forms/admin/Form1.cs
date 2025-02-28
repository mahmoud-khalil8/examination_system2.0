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
        public Form1(UserModel _admin)
        {

            InitializeComponent();
            this.admin = _admin;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MngStdsBtn_Click(object sender, EventArgs e)
        {
            StudentForm stdform = new StudentForm(admin);
            stdform.Show();
            //this.Hide();
            MngStdsBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            MngStdsBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            MngStdsBtn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            MngStdsBtn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;

            MngStdsBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            MngStdsBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            MngStdsBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            MngStdsBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;

            MngStdsBtn.StateNormal.Back.Color1 = System.Drawing.Color.White;
            MngStdsBtn.StateNormal.Back.Color2 = System.Drawing.Color.White;
            MngStdsBtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            MngStdsBtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;

            MngStdsBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            MngStdsBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            MngStdsBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            MngStdsBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;

            MngStdsBtn.StatePressed.Back.Color1 = System.Drawing.Color.White;
            MngStdsBtn.StatePressed.Back.Color2 = System.Drawing.Color.White;
            MngStdsBtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            MngStdsBtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
        }

        private void MngTeachersBtn_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm(admin);
            teacherForm.Show();
            //this.Hide();
            MngTeachersBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            MngTeachersBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            MngTeachersBtn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            MngTeachersBtn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;

            MngTeachersBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            MngTeachersBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            MngTeachersBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            MngTeachersBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;

            MngTeachersBtn.StateNormal.Back.Color1 = System.Drawing.Color.White;
            MngTeachersBtn.StateNormal.Back.Color2 = System.Drawing.Color.White;
            MngTeachersBtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            MngTeachersBtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;

            MngTeachersBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            MngTeachersBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            MngTeachersBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            MngTeachersBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;

            MngTeachersBtn.StatePressed.Back.Color1 = System.Drawing.Color.White;
            MngTeachersBtn.StatePressed.Back.Color2 = System.Drawing.Color.White;
            MngTeachersBtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            MngTeachersBtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;


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
            LogOutBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            LogOutBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            LogOutBtn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            LogOutBtn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;

            LogOutBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            LogOutBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            LogOutBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            LogOutBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;

            LogOutBtn.StateNormal.Back.Color1 = System.Drawing.Color.White;
            LogOutBtn.StateNormal.Back.Color2 = System.Drawing.Color.White;
            LogOutBtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            LogOutBtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;

            LogOutBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            LogOutBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            LogOutBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            LogOutBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;

            LogOutBtn.StatePressed.Back.Color1 = System.Drawing.Color.White;
            LogOutBtn.StatePressed.Back.Color2 = System.Drawing.Color.White;
            LogOutBtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            LogOutBtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;


        }

    }
}
