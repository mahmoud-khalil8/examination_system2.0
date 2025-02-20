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
            this.RemainingTimeLabel = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.totalQuestionLabel = new System.Windows.Forms.Label();
            this.ExamNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalMarksLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.questionLabel = new System.Windows.Forms.Label();
            this.nextbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.prevbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SubmitBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemainingTimeLabel
            // 
            this.RemainingTimeLabel.AutoSize = true;
            this.RemainingTimeLabel.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingTimeLabel.ForeColor = System.Drawing.Color.White;
            this.RemainingTimeLabel.Location = new System.Drawing.Point(800, 77);
            this.RemainingTimeLabel.Name = "RemainingTimeLabel";
            this.RemainingTimeLabel.Size = new System.Drawing.Size(276, 25);
            this.RemainingTimeLabel.TabIndex = 18;
            this.RemainingTimeLabel.Text = "Remaining time: 00:20:33";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimeLabel.ForeColor = System.Drawing.Color.White;
            this.totalTimeLabel.Location = new System.Drawing.Point(800, 38);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(199, 25);
            this.totalTimeLabel.TabIndex = 17;
            this.totalTimeLabel.Text = "Total Time: 60min";
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumberLabel.ForeColor = System.Drawing.Color.White;
            this.questionNumberLabel.Location = new System.Drawing.Point(15, 77);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(210, 25);
            this.questionNumberLabel.TabIndex = 16;
            this.questionNumberLabel.Text = "Question Number: 4";
            // 
            // totalQuestionLabel
            // 
            this.totalQuestionLabel.AutoSize = true;
            this.totalQuestionLabel.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.totalQuestionLabel.Location = new System.Drawing.Point(15, 38);
            this.totalQuestionLabel.Name = "totalQuestionLabel";
            this.totalQuestionLabel.Size = new System.Drawing.Size(210, 25);
            this.totalQuestionLabel.TabIndex = 15;
            this.totalQuestionLabel.Text = "Total Question: 30";
            // 
            // ExamNameLabel
            // 
            this.ExamNameLabel.AutoSize = true;
            this.ExamNameLabel.Font = new System.Drawing.Font("JetBrains Mono", 12.74545F);
            this.ExamNameLabel.ForeColor = System.Drawing.Color.White;
            this.ExamNameLabel.Location = new System.Drawing.Point(516, 9);
            this.ExamNameLabel.Name = "ExamNameLabel";
            this.ExamNameLabel.Size = new System.Drawing.Size(108, 26);
            this.ExamNameLabel.TabIndex = 14;
            this.ExamNameLabel.Text = "ExamName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.TotalMarksLabel);
            this.panel1.Controls.Add(this.ExamNameLabel);
            this.panel1.Controls.Add(this.RemainingTimeLabel);
            this.panel1.Controls.Add(this.totalQuestionLabel);
            this.panel1.Controls.Add(this.totalTimeLabel);
            this.panel1.Controls.Add(this.questionNumberLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 161);
            this.panel1.TabIndex = 19;
            // 
            // TotalMarksLabel
            // 
            this.TotalMarksLabel.AutoSize = true;
            this.TotalMarksLabel.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMarksLabel.ForeColor = System.Drawing.Color.White;
            this.TotalMarksLabel.Location = new System.Drawing.Point(15, 116);
            this.TotalMarksLabel.Name = "TotalMarksLabel";
            this.TotalMarksLabel.Size = new System.Drawing.Size(188, 25);
            this.TotalMarksLabel.TabIndex = 19;
            this.TotalMarksLabel.Text = "Total Marks: 100";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.optionsPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(79, 253);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(997, 317);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Location = new System.Drawing.Point(3, 3);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(1060, 323);
            this.optionsPanel.TabIndex = 0;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("JetBrains Mono", 12.78182F, System.Drawing.FontStyle.Bold);
            this.questionLabel.ForeColor = System.Drawing.Color.Black;
            this.questionLabel.Location = new System.Drawing.Point(74, 224);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(120, 26);
            this.questionLabel.TabIndex = 20;
            this.questionLabel.Text = "Question?";
            // 
            // nextbtn
            // 
            this.nextbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextbtn.Location = new System.Drawing.Point(979, 585);
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
            this.prevbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevbtn.Location = new System.Drawing.Point(62, 585);
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
            this.SubmitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitBtn.Location = new System.Drawing.Point(521, 585);
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
            // StudentExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 656);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.prevbtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.panel1);
            this.Name = "StudentExam";
            this.Text = "StudentExam";
            this.Load += new System.EventHandler(this.StudentExam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RemainingTimeLabel;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label totalQuestionLabel;
        private System.Windows.Forms.Label ExamNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label questionLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton nextbtn;
        private System.Windows.Forms.Label TotalMarksLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton prevbtn;
        private System.Windows.Forms.Panel optionsPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SubmitBtn;
    }
}