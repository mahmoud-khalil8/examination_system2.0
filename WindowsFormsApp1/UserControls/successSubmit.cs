﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using WindowsFormsApp1.BusinessLogic;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.UserControls
{
    public partial class successSubmit : UserControl
    {
        
        public successSubmit()
        {
            InitializeComponent();
        }

        private void successSubmit_Load(object sender, EventArgs e)
        {
            examSubmittedlbl.Text = TranslationHelper.GetTranslation("ExamSubmitted");
            examsubmittedlbl2.Text = TranslationHelper.GetTranslation("AnswersRecorded");
        }

    }
}
