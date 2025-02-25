using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    partial class StudentExam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentExam));
            this.RemainingTimeLabel = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.totalQuestionLabel = new System.Windows.Forms.Label();
            this.ExamNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subjectNameLbl = new System.Windows.Forms.Label();
            this.TotalMarksLabel = new System.Windows.Forms.Label();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.questionLabel = new System.Windows.Forms.Label();
            this.nextbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.prevbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SubmitBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.questionNumlbl = new System.Windows.Forms.Label();
            this.headerlbl = new System.Windows.Forms.Label();
            this.showAnswersBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RemainingTimeLabel
            // 
            this.RemainingTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemainingTimeLabel.AutoSize = true;
            this.RemainingTimeLabel.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingTimeLabel.ForeColor = System.Drawing.Color.White;
            this.RemainingTimeLabel.Location = new System.Drawing.Point(1014, 116);
            this.RemainingTimeLabel.Name = "RemainingTimeLabel";
            this.RemainingTimeLabel.Size = new System.Drawing.Size(276, 25);
            this.RemainingTimeLabel.TabIndex = 18;
            this.RemainingTimeLabel.Text = "Remaining time: 00:20:33";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimeLabel.ForeColor = System.Drawing.Color.White;
            this.totalTimeLabel.Location = new System.Drawing.Point(1014, 77);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(199, 25);
            this.totalTimeLabel.TabIndex = 17;
            this.totalTimeLabel.Text = "Total Time: 60min";
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumberLabel.ForeColor = System.Drawing.Color.White;
            this.questionNumberLabel.Location = new System.Drawing.Point(135, 77);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(210, 25);
            this.questionNumberLabel.TabIndex = 16;
            this.questionNumberLabel.Text = "Question Number: 4";
            // 
            // totalQuestionLabel
            // 
            this.totalQuestionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalQuestionLabel.AutoSize = true;
            this.totalQuestionLabel.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.totalQuestionLabel.Location = new System.Drawing.Point(135, 38);
            this.totalQuestionLabel.Name = "totalQuestionLabel";
            this.totalQuestionLabel.Size = new System.Drawing.Size(210, 25);
            this.totalQuestionLabel.TabIndex = 15;
            this.totalQuestionLabel.Text = "Total Question: 30";
            // 
            // ExamNameLabel
            // 
            this.ExamNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExamNameLabel.AutoSize = true;
            this.ExamNameLabel.Font = new System.Drawing.Font("JetBrains Mono", 12.74545F);
            this.ExamNameLabel.ForeColor = System.Drawing.Color.White;
            this.ExamNameLabel.Location = new System.Drawing.Point(625, 9);
            this.ExamNameLabel.Name = "ExamNameLabel";
            this.ExamNameLabel.Size = new System.Drawing.Size(108, 26);
            this.ExamNameLabel.TabIndex = 14;
            this.ExamNameLabel.Text = "ExamName";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.subjectNameLbl);
            this.panel1.Controls.Add(this.TotalMarksLabel);
            this.panel1.Controls.Add(this.ExamNameLabel);
            this.panel1.Controls.Add(this.RemainingTimeLabel);
            this.panel1.Controls.Add(this.totalQuestionLabel);
            this.panel1.Controls.Add(this.totalTimeLabel);
            this.panel1.Controls.Add(this.questionNumberLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 179);
            this.panel1.TabIndex = 19;
            // 
            // subjectNameLbl
            // 
            this.subjectNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subjectNameLbl.AutoSize = true;
            this.subjectNameLbl.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectNameLbl.ForeColor = System.Drawing.Color.White;
            this.subjectNameLbl.Location = new System.Drawing.Point(1014, 28);
            this.subjectNameLbl.Name = "subjectNameLbl";
            this.subjectNameLbl.Size = new System.Drawing.Size(210, 25);
            this.subjectNameLbl.TabIndex = 20;
            this.subjectNameLbl.Text = "Subject Name: name";
            // 
            // TotalMarksLabel
            // 
            this.TotalMarksLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalMarksLabel.AutoSize = true;
            this.TotalMarksLabel.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMarksLabel.ForeColor = System.Drawing.Color.White;
            this.TotalMarksLabel.Location = new System.Drawing.Point(135, 116);
            this.TotalMarksLabel.Name = "TotalMarksLabel";
            this.TotalMarksLabel.Size = new System.Drawing.Size(188, 25);
            this.TotalMarksLabel.TabIndex = 19;
            this.TotalMarksLabel.Text = "Total Marks: 100";
            // 
            // optionsPanel
            // 
            this.optionsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionsPanel.Location = new System.Drawing.Point(83, 292);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(1207, 334);
            this.optionsPanel.TabIndex = 0;
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("JetBrains Mono", 12.78182F, System.Drawing.FontStyle.Bold);
            this.questionLabel.ForeColor = System.Drawing.Color.Black;
            this.questionLabel.Location = new System.Drawing.Point(112, 253);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(120, 26);
            this.questionLabel.TabIndex = 20;
            this.questionLabel.Text = "Question?";
            // 
            // nextbtn
            // 
            this.nextbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextbtn.Location = new System.Drawing.Point(1127, 694);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.OverrideDefault.Back.ColorAngle = 45F;
            this.nextbtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.OverrideDefault.Border.ColorAngle = 45F;
            this.nextbtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextbtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextbtn.OverrideDefault.Border.Rounding = 10;
            this.nextbtn.OverrideDefault.Border.Width = 1;
            this.nextbtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.nextbtn.Size = new System.Drawing.Size(163, 43);
            this.nextbtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.StateCommon.Back.ColorAngle = 45F;
            this.nextbtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.StateCommon.Border.ColorAngle = 45F;
            this.nextbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextbtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextbtn.StateCommon.Border.Rounding = 10;
            this.nextbtn.StateCommon.Border.Width = 1;
            this.nextbtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 1);
            this.nextbtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextbtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("JetBrains Mono", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.StatePressed.Back.ColorAngle = 135F;
            this.nextbtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.StatePressed.Border.ColorAngle = 135F;
            this.nextbtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextbtn.StatePressed.Border.Rounding = 10;
            this.nextbtn.StatePressed.Border.Width = 1;
            this.nextbtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.nextbtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.nextbtn.StateTracking.Back.ColorAngle = 45F;
            this.nextbtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.StateTracking.Border.ColorAngle = 45F;
            this.nextbtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextbtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextbtn.StateTracking.Border.Rounding = 10;
            this.nextbtn.StateTracking.Border.Width = 1;
            this.nextbtn.TabIndex = 21;
            this.nextbtn.Values.Text = "Next";
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // prevbtn
            // 
            this.prevbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prevbtn.Location = new System.Drawing.Point(83, 694);
            this.prevbtn.Name = "prevbtn";
            this.prevbtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.OverrideDefault.Back.ColorAngle = 45F;
            this.prevbtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.OverrideDefault.Border.ColorAngle = 45F;
            this.prevbtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.prevbtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.prevbtn.OverrideDefault.Border.Rounding = 10;
            this.prevbtn.OverrideDefault.Border.Width = 1;
            this.prevbtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.prevbtn.Size = new System.Drawing.Size(163, 43);
            this.prevbtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.StateCommon.Back.ColorAngle = 45F;
            this.prevbtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.StateCommon.Border.ColorAngle = 45F;
            this.prevbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.prevbtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.prevbtn.StateCommon.Border.Rounding = 10;
            this.prevbtn.StateCommon.Border.Width = 1;
            this.prevbtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 1);
            this.prevbtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.prevbtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.prevbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("JetBrains Mono", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevbtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.StatePressed.Back.ColorAngle = 135F;
            this.prevbtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.StatePressed.Border.ColorAngle = 135F;
            this.prevbtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.prevbtn.StatePressed.Border.Rounding = 10;
            this.prevbtn.StatePressed.Border.Width = 1;
            this.prevbtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.prevbtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.prevbtn.StateTracking.Back.ColorAngle = 45F;
            this.prevbtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevbtn.StateTracking.Border.ColorAngle = 45F;
            this.prevbtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.prevbtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.prevbtn.StateTracking.Border.Rounding = 10;
            this.prevbtn.StateTracking.Border.Width = 1;
            this.prevbtn.TabIndex = 24;
            this.prevbtn.Values.Text = "Previous";
            this.prevbtn.Click += new System.EventHandler(this.prevbtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SubmitBtn.Location = new System.Drawing.Point(579, 694);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.SubmitBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.OverrideDefault.Border.ColorAngle = 45F;
            this.SubmitBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SubmitBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SubmitBtn.OverrideDefault.Border.Rounding = 10;
            this.SubmitBtn.OverrideDefault.Border.Width = 1;
            this.SubmitBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.SubmitBtn.Size = new System.Drawing.Size(163, 43);
            this.SubmitBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.StateCommon.Back.ColorAngle = 45F;
            this.SubmitBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.StateCommon.Border.ColorAngle = 45F;
            this.SubmitBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SubmitBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SubmitBtn.StateCommon.Border.Rounding = 10;
            this.SubmitBtn.StateCommon.Border.Width = 1;
            this.SubmitBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 1);
            this.SubmitBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.SubmitBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.SubmitBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("JetBrains Mono", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.StatePressed.Back.ColorAngle = 135F;
            this.SubmitBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.StatePressed.Border.ColorAngle = 135F;
            this.SubmitBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SubmitBtn.StatePressed.Border.Rounding = 10;
            this.SubmitBtn.StatePressed.Border.Width = 1;
            this.SubmitBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.SubmitBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.SubmitBtn.StateTracking.Back.ColorAngle = 45F;
            this.SubmitBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitBtn.StateTracking.Border.ColorAngle = 45F;
            this.SubmitBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SubmitBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SubmitBtn.StateTracking.Border.Rounding = 10;
            this.SubmitBtn.StateTracking.Border.Width = 1;
            this.SubmitBtn.TabIndex = 25;
            this.SubmitBtn.Values.Text = "Submit";
            this.SubmitBtn.Visible = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backgroundPanel.BackColor = System.Drawing.Color.White;
            this.backgroundPanel.Controls.Add(this.pictureBox1);
            this.backgroundPanel.Controls.Add(this.questionNumlbl);
            this.backgroundPanel.Controls.Add(this.headerlbl);
            this.backgroundPanel.Controls.Add(this.showAnswersBtn);
            this.backgroundPanel.Controls.Add(this.SubmitBtn);
            this.backgroundPanel.Controls.Add(this.optionsPanel);
            this.backgroundPanel.Controls.Add(this.prevbtn);
            this.backgroundPanel.Controls.Add(this.nextbtn);
            this.backgroundPanel.Controls.Add(this.questionLabel);
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1444, 768);
            this.backgroundPanel.TabIndex = 26;
            this.backgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // questionNumlbl
            // 
            this.questionNumlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questionNumlbl.AutoSize = true;
            this.questionNumlbl.Font = new System.Drawing.Font("JetBrains Mono", 12.78182F, System.Drawing.FontStyle.Bold);
            this.questionNumlbl.ForeColor = System.Drawing.Color.Black;
            this.questionNumlbl.Location = new System.Drawing.Point(78, 253);
            this.questionNumlbl.Name = "questionNumlbl";
            this.questionNumlbl.Size = new System.Drawing.Size(36, 26);
            this.questionNumlbl.TabIndex = 28;
            this.questionNumlbl.Text = "1)";
            // 
            // headerlbl
            // 
            this.headerlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerlbl.AutoSize = true;
            this.headerlbl.Font = new System.Drawing.Font("JetBrains Mono", 12.12727F);
            this.headerlbl.ForeColor = System.Drawing.Color.Black;
            this.headerlbl.Location = new System.Drawing.Point(45, 197);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(177, 25);
            this.headerlbl.TabIndex = 27;
            this.headerlbl.Text = "Question Header";
            // 
            // showAnswersBtn
            // 
            this.showAnswersBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.showAnswersBtn.Location = new System.Drawing.Point(523, 713);
            this.showAnswersBtn.Name = "showAnswersBtn";
            this.showAnswersBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.showAnswersBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.OverrideDefault.Border.ColorAngle = 45F;
            this.showAnswersBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.showAnswersBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.showAnswersBtn.OverrideDefault.Border.Rounding = 10;
            this.showAnswersBtn.OverrideDefault.Border.Width = 1;
            this.showAnswersBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.showAnswersBtn.Size = new System.Drawing.Size(303, 42);
            this.showAnswersBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.StateCommon.Back.ColorAngle = 45F;
            this.showAnswersBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.StateCommon.Border.ColorAngle = 45F;
            this.showAnswersBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.showAnswersBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.showAnswersBtn.StateCommon.Border.Rounding = 10;
            this.showAnswersBtn.StateCommon.Border.Width = 1;
            this.showAnswersBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 1);
            this.showAnswersBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.showAnswersBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.showAnswersBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("JetBrains Mono", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAnswersBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.StatePressed.Back.ColorAngle = 135F;
            this.showAnswersBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.StatePressed.Border.ColorAngle = 135F;
            this.showAnswersBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.showAnswersBtn.StatePressed.Border.Rounding = 10;
            this.showAnswersBtn.StatePressed.Border.Width = 1;
            this.showAnswersBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.showAnswersBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.showAnswersBtn.StateTracking.Back.ColorAngle = 45F;
            this.showAnswersBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showAnswersBtn.StateTracking.Border.ColorAngle = 45F;
            this.showAnswersBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.showAnswersBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.showAnswersBtn.StateTracking.Border.Rounding = 10;
            this.showAnswersBtn.StateTracking.Border.Width = 1;
            this.showAnswersBtn.TabIndex = 26;
            this.showAnswersBtn.Values.Text = "Show Answers";
            this.showAnswersBtn.Visible = false;
            this.showAnswersBtn.Click += new System.EventHandler(this.showAnswersBtn_Click);
            // 
            // StudentExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1444, 767);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backgroundPanel);
            this.MinimumSize = new System.Drawing.Size(1462, 811);
            this.Name = "StudentExam";
            this.Text = "StudentExam";
            this.Load += new System.EventHandler(this.StudentExam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label RemainingTimeLabel;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label totalQuestionLabel;
        private System.Windows.Forms.Label ExamNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label questionLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton nextbtn;
        private System.Windows.Forms.Label TotalMarksLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton prevbtn;
        private System.Windows.Forms.Panel optionsPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SubmitBtn;
        private Panel backgroundPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton showAnswersBtn;
        private Label headerlbl;
        private PictureBox pictureBox1;
        private Label questionNumlbl;
        private Label subjectNameLbl;
    }
}