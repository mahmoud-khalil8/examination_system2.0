namespace WindowsFormsApp1.Forms
{
    partial class PracticeExamAnswers
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
            this.TotalMarksLabel = new System.Windows.Forms.Label();
            this.ExamNameLabel = new System.Windows.Forms.Label();
            this.totalQuestionLabel = new System.Windows.Forms.Label();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prevBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.questionLabel = new System.Windows.Forms.Label();
            this.nextBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.correctAnsLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalMarksLabel
            // 
            this.TotalMarksLabel.AutoSize = true;
            this.TotalMarksLabel.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMarksLabel.ForeColor = System.Drawing.Color.White;
            this.TotalMarksLabel.Location = new System.Drawing.Point(60, 116);
            this.TotalMarksLabel.Name = "TotalMarksLabel";
            this.TotalMarksLabel.Size = new System.Drawing.Size(188, 25);
            this.TotalMarksLabel.TabIndex = 25;
            this.TotalMarksLabel.Text = "Total Marks: 100";
            // 
            // ExamNameLabel
            // 
            this.ExamNameLabel.AutoSize = true;
            this.ExamNameLabel.Font = new System.Drawing.Font("JetBrains Mono", 12.74545F);
            this.ExamNameLabel.ForeColor = System.Drawing.Color.White;
            this.ExamNameLabel.Location = new System.Drawing.Point(521, 9);
            this.ExamNameLabel.Name = "ExamNameLabel";
            this.ExamNameLabel.Size = new System.Drawing.Size(108, 26);
            this.ExamNameLabel.TabIndex = 20;
            this.ExamNameLabel.Text = "ExamName";
            // 
            // totalQuestionLabel
            // 
            this.totalQuestionLabel.AutoSize = true;
            this.totalQuestionLabel.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.totalQuestionLabel.Location = new System.Drawing.Point(60, 38);
            this.totalQuestionLabel.Name = "totalQuestionLabel";
            this.totalQuestionLabel.Size = new System.Drawing.Size(210, 25);
            this.totalQuestionLabel.TabIndex = 21;
            this.totalQuestionLabel.Text = "Total Question: 30";
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("JetBrains Mono Light", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumberLabel.ForeColor = System.Drawing.Color.White;
            this.questionNumberLabel.Location = new System.Drawing.Point(60, 77);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(210, 25);
            this.questionNumberLabel.TabIndex = 22;
            this.questionNumberLabel.Text = "Question Number: 4";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.ExamNameLabel);
            this.panel1.Controls.Add(this.TotalMarksLabel);
            this.panel1.Controls.Add(this.questionNumberLabel);
            this.panel1.Controls.Add(this.totalQuestionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 180);
            this.panel1.TabIndex = 26;
            // 
            // prevBtn
            // 
            this.prevBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevBtn.Location = new System.Drawing.Point(62, 591);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.prevBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.OverrideDefault.Border.ColorAngle = 45F;
            this.prevBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.prevBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.prevBtn.OverrideDefault.Border.Rounding = 10;
            this.prevBtn.OverrideDefault.Border.Width = 1;
            this.prevBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.prevBtn.Size = new System.Drawing.Size(163, 43);
            this.prevBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.StateCommon.Back.ColorAngle = 45F;
            this.prevBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.StateCommon.Border.ColorAngle = 45F;
            this.prevBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.prevBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.prevBtn.StateCommon.Border.Rounding = 10;
            this.prevBtn.StateCommon.Border.Width = 1;
            this.prevBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 1);
            this.prevBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.prevBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.prevBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("JetBrains Mono", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.StatePressed.Back.ColorAngle = 135F;
            this.prevBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.StatePressed.Border.ColorAngle = 135F;
            this.prevBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.prevBtn.StatePressed.Border.Rounding = 10;
            this.prevBtn.StatePressed.Border.Width = 1;
            this.prevBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.prevBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.prevBtn.StateTracking.Back.ColorAngle = 45F;
            this.prevBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prevBtn.StateTracking.Border.ColorAngle = 45F;
            this.prevBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.prevBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.prevBtn.StateTracking.Border.Rounding = 10;
            this.prevBtn.StateTracking.Border.Width = 1;
            this.prevBtn.TabIndex = 30;
            this.prevBtn.Values.Text = "Previous";
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.optionsPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(79, 259);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(997, 317);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.panel2);
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
            this.questionLabel.Location = new System.Drawing.Point(74, 230);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(120, 26);
            this.questionLabel.TabIndex = 27;
            this.questionLabel.Text = "Question?";
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextBtn.Location = new System.Drawing.Point(979, 591);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.nextBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.OverrideDefault.Border.ColorAngle = 45F;
            this.nextBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextBtn.OverrideDefault.Border.Rounding = 10;
            this.nextBtn.OverrideDefault.Border.Width = 1;
            this.nextBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.nextBtn.Size = new System.Drawing.Size(163, 43);
            this.nextBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.StateCommon.Back.ColorAngle = 45F;
            this.nextBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.StateCommon.Border.ColorAngle = 45F;
            this.nextBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextBtn.StateCommon.Border.Rounding = 10;
            this.nextBtn.StateCommon.Border.Width = 1;
            this.nextBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 1);
            this.nextBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("JetBrains Mono", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.StatePressed.Back.ColorAngle = 135F;
            this.nextBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.StatePressed.Border.ColorAngle = 135F;
            this.nextBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextBtn.StatePressed.Border.Rounding = 10;
            this.nextBtn.StatePressed.Border.Width = 1;
            this.nextBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.nextBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.nextBtn.StateTracking.Back.ColorAngle = 45F;
            this.nextBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextBtn.StateTracking.Border.ColorAngle = 45F;
            this.nextBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextBtn.StateTracking.Border.Rounding = 10;
            this.nextBtn.StateTracking.Border.Width = 1;
            this.nextBtn.TabIndex = 28;
            this.nextBtn.Values.Text = "Next";
            this.nextBtn.Click += new System.EventHandler(this.nextbtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 12.78182F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Correct Answer: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.correctAnsLbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 43);
            this.panel2.TabIndex = 33;
            // 
            // correctAnsLbl
            // 
            this.correctAnsLbl.AutoSize = true;
            this.correctAnsLbl.Font = new System.Drawing.Font("JetBrains Mono", 12.78182F, System.Drawing.FontStyle.Bold);
            this.correctAnsLbl.ForeColor = System.Drawing.Color.Black;
            this.correctAnsLbl.Location = new System.Drawing.Point(201, 9);
            this.correctAnsLbl.Name = "correctAnsLbl";
            this.correctAnsLbl.Size = new System.Drawing.Size(84, 26);
            this.correctAnsLbl.TabIndex = 32;
            this.correctAnsLbl.Text = "answer";
            // 
            // PracticeExamAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 656);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.panel1);
            this.Name = "PracticeExamAnswers";
            this.Text = "PracticeExamAnswers";
            this.Load += new System.EventHandler(this.PracticeExamAnswers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalMarksLabel;
        private System.Windows.Forms.Label ExamNameLabel;
        private System.Windows.Forms.Label totalQuestionLabel;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton prevBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Label questionLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton nextBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label correctAnsLbl;
    }
}