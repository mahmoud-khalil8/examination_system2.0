using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BusinessLogic;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1.Forms
{
    public partial class TeacherDashoard : Form
    {
        int id = intro.CurrentId;

        public static int CurrentExamID = 0;

        public TeacherDashoard()
        {
            InitializeComponent();
        }
        private void SetButtonDefaultStyle(KryptonButton button)
        {
            button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(49, 0, 0);
            button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(49, 0, 0);
            button.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            button.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;

            button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(49, 0, 0);
            button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(49, 0, 0);
            button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;


            button.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(49, 0, 0);
            button.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(49, 0, 0);
            button.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            button.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;

            button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(49, 0, 0);
            button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(49, 0, 0);
            button.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            button.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;

            button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(49, 0, 0);
            button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(49, 0, 0);
            button.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            button.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;

        }

        private void SetButtonActiveStyle(KryptonButton button)
        {
            button.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            button.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            button.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            button.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;

            button.StateCommon.Back.Color1 = System.Drawing.Color.White;
            button.StateCommon.Back.Color2 = System.Drawing.Color.White;
            button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;

            button.StateNormal.Back.Color1 = System.Drawing.Color.White;
            button.StateNormal.Back.Color2 = System.Drawing.Color.White;
            button.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            button.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;

            button.StateTracking.Back.Color1 = System.Drawing.Color.White;
            button.StateTracking.Back.Color2 = System.Drawing.Color.White;
            button.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            button.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;

            button.StatePressed.Back.Color1 = System.Drawing.Color.White;
            button.StatePressed.Back.Color2 = System.Drawing.Color.White;
            button.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            button.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;

        }

        private void changeStyle(object sender)
        {
            KryptonButton clickedButton = sender as KryptonButton;

            if (clickedButton != null)
            {
                if (lastClickedButton != null && lastClickedButton != clickedButton)
                {
                    SetButtonDefaultStyle(lastClickedButton);
                }

                SetButtonActiveStyle(clickedButton);
                lastClickedButton = clickedButton;
            }
        }

        private void ChangePanel(UserControl userControl)
        {
            panalchange.Controls.Clear();
            panalchange.StateCommon.Image = null;
            panalchange.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }


        private KryptonButton lastClickedButton;

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            SetButtonDefaultStyle(btnaddquestion);
            SetButtonDefaultStyle(btnupdatequestion);
            SetButtonDefaultStyle(btnviewdeleteq);
            SetButtonDefaultStyle(btnallstudents);

            DataTable dt = TeacherBL.GetTeacherName(id);

            if (dt.Rows.Count > 0)
            {
                lbteacgername.Text = dt.Rows[0]["FullName"].ToString();
            }
            else
            {
                lbteacgername.Text = "Teacher not found.";
            }
        }


        private void btnaddexam_Click(object sender, EventArgs e)
        {
            changeStyle(sender);
            AddExamUC addExamUC = new AddExamUC();
            ChangePanel(addExamUC);
        }
        private void btnaddquestion_Click(object sender, EventArgs e)
        {
            changeStyle(sender);
            AddNewQuestionsUC addQuestionUC = new AddNewQuestionsUC();
            ChangePanel(addQuestionUC);
        }

        private void btnupdatequestion_Click(object sender, EventArgs e)
        {
            changeStyle(sender);


            UpdateQuetionsUserControl update = new UpdateQuetionsUserControl();
            ChangePanel(update);

        }

        private void btnviewdeleteq_Click(object sender, EventArgs e)
        {
            changeStyle(sender);

            ViewAndDeleteQuestions update = new ViewAndDeleteQuestions();
            ChangePanel(update);
        }

        private void btnallstudents_Click(object sender, EventArgs e)
        {
            changeStyle(sender);

            ViewAllStudentsUserControl update = new ViewAllStudentsUserControl();
            ChangePanel(update);
        }

        private void updateQuetionsUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void panalchange_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
