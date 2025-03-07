﻿using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FinalExamslbl = new System.Windows.Forms.Label();
            this.noexamspic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.WarmUpMessage = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startFinalBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.nofinallbl = new System.Windows.Forms.Label();
            this.refreshBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ExamsListsPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noexamspic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ExamsListsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.74545F);
            this.studentNameLabel.ForeColor = System.Drawing.Color.White;
            this.studentNameLabel.Location = new System.Drawing.Point(171, 44);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(181, 30);
            this.studentNameLabel.TabIndex = 8;
            this.studentNameLabel.Text = "Student name";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.studentNameLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 114);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FinalExamslbl
            // 
            this.FinalExamslbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinalExamslbl.AutoSize = true;
            this.FinalExamslbl.Font = new System.Drawing.Font("JetBrains Mono", 12.78182F, System.Drawing.FontStyle.Bold);
            this.FinalExamslbl.ForeColor = System.Drawing.Color.Black;
            this.FinalExamslbl.Location = new System.Drawing.Point(37, 39);
            this.FinalExamslbl.Name = "FinalExamslbl";
            this.FinalExamslbl.Size = new System.Drawing.Size(144, 26);
            this.FinalExamslbl.TabIndex = 10;
            this.FinalExamslbl.Text = "Final Exams";
            this.FinalExamslbl.Visible = false;
            // 
            // noexamspic
            // 
            this.noexamspic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noexamspic.Image = ((System.Drawing.Image)(resources.GetObject("noexamspic.Image")));
            this.noexamspic.Location = new System.Drawing.Point(489, 71);
            this.noexamspic.Name = "noexamspic";
            this.noexamspic.Size = new System.Drawing.Size(508, 357);
            this.noexamspic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noexamspic.TabIndex = 10;
            this.noexamspic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.WarmUpMessage);
            this.panel2.Location = new System.Drawing.Point(0, 667);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1444, 100);
            this.panel2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("JetBrains Mono", 11.78182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(1193, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 64);
            this.button2.TabIndex = 0;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WarmUpMessage
            // 
            this.WarmUpMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WarmUpMessage.AutoSize = true;
            this.WarmUpMessage.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarmUpMessage.ForeColor = System.Drawing.Color.Black;
            this.WarmUpMessage.Location = new System.Drawing.Point(215, 15);
            this.WarmUpMessage.Name = "WarmUpMessage";
            this.WarmUpMessage.Size = new System.Drawing.Size(595, 50);
            this.WarmUpMessage.TabIndex = 12;
            this.WarmUpMessage.Text = "Warm up before the real challenge! Hit ‘Start’ for a \r\nPractice Exam.";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridView1.Location = new System.Drawing.Point(42, 90);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 333);
            this.dataGridView1.TabIndex = 13;
            // 
            // startFinalBtn
            // 
            this.startFinalBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startFinalBtn.Location = new System.Drawing.Point(196, 482);
            this.startFinalBtn.Name = "startFinalBtn";
            this.startFinalBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.startFinalBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.OverrideDefault.Border.ColorAngle = 45F;
            this.startFinalBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.startFinalBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.startFinalBtn.OverrideDefault.Border.Rounding = 10;
            this.startFinalBtn.OverrideDefault.Border.Width = 1;
            this.startFinalBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.startFinalBtn.Size = new System.Drawing.Size(230, 43);
            this.startFinalBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.StateCommon.Back.ColorAngle = 45F;
            this.startFinalBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.StateCommon.Border.ColorAngle = 45F;
            this.startFinalBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.startFinalBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.startFinalBtn.StateCommon.Border.Rounding = 10;
            this.startFinalBtn.StateCommon.Border.Width = 1;
            this.startFinalBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 1);
            this.startFinalBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.startFinalBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.startFinalBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("JetBrains Mono", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startFinalBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.StatePressed.Back.ColorAngle = 135F;
            this.startFinalBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.StatePressed.Border.ColorAngle = 135F;
            this.startFinalBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.startFinalBtn.StatePressed.Border.Rounding = 10;
            this.startFinalBtn.StatePressed.Border.Width = 1;
            this.startFinalBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.startFinalBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.startFinalBtn.StateTracking.Back.ColorAngle = 45F;
            this.startFinalBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startFinalBtn.StateTracking.Border.ColorAngle = 45F;
            this.startFinalBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.startFinalBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.startFinalBtn.StateTracking.Border.Rounding = 10;
            this.startFinalBtn.StateTracking.Border.Width = 1;
            this.startFinalBtn.TabIndex = 12;
            this.startFinalBtn.Values.Text = "Start";
            this.startFinalBtn.Visible = false;
            this.startFinalBtn.Click += new System.EventHandler(this.startFinalBtn_Click);
            // 
            // nofinallbl
            // 
            this.nofinallbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nofinallbl.AutoSize = true;
            this.nofinallbl.Font = new System.Drawing.Font("JetBrains Mono", 12.78182F, System.Drawing.FontStyle.Bold);
            this.nofinallbl.ForeColor = System.Drawing.Color.Black;
            this.nofinallbl.Location = new System.Drawing.Point(617, 431);
            this.nofinallbl.Name = "nofinallbl";
            this.nofinallbl.Size = new System.Drawing.Size(228, 26);
            this.nofinallbl.TabIndex = 14;
            this.nofinallbl.Text = "No Final Exams yet";
            this.nofinallbl.Visible = false;
            this.nofinallbl.Click += new System.EventHandler(this.nofinallbl_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshBtn.Location = new System.Drawing.Point(1206, 40);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.refreshBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.OverrideDefault.Border.ColorAngle = 45F;
            this.refreshBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.refreshBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.refreshBtn.OverrideDefault.Border.Rounding = 10;
            this.refreshBtn.OverrideDefault.Border.Width = 1;
            this.refreshBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.refreshBtn.Size = new System.Drawing.Size(112, 44);
            this.refreshBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.StateCommon.Back.ColorAngle = 45F;
            this.refreshBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.StateCommon.Border.ColorAngle = 45F;
            this.refreshBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.refreshBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.refreshBtn.StateCommon.Border.Rounding = 10;
            this.refreshBtn.StateCommon.Border.Width = 1;
            this.refreshBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 1);
            this.refreshBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.refreshBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.refreshBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("JetBrains Mono", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.StatePressed.Back.ColorAngle = 135F;
            this.refreshBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.StatePressed.Border.ColorAngle = 135F;
            this.refreshBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.refreshBtn.StatePressed.Border.Rounding = 10;
            this.refreshBtn.StatePressed.Border.Width = 1;
            this.refreshBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.refreshBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.refreshBtn.StateTracking.Back.ColorAngle = 45F;
            this.refreshBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshBtn.StateTracking.Border.ColorAngle = 45F;
            this.refreshBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.refreshBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.refreshBtn.StateTracking.Border.Rounding = 10;
            this.refreshBtn.StateTracking.Border.Width = 1;
            this.refreshBtn.TabIndex = 15;
            this.refreshBtn.Values.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // ExamsListsPanel
            // 
            this.ExamsListsPanel.Controls.Add(this.noexamspic);
            this.ExamsListsPanel.Controls.Add(this.dataGridView1);
            this.ExamsListsPanel.Controls.Add(this.refreshBtn);
            this.ExamsListsPanel.Controls.Add(this.FinalExamslbl);
            this.ExamsListsPanel.Controls.Add(this.nofinallbl);
            this.ExamsListsPanel.Controls.Add(this.startFinalBtn);
            this.ExamsListsPanel.Location = new System.Drawing.Point(0, 120);
            this.ExamsListsPanel.Name = "ExamsListsPanel";
            this.ExamsListsPanel.Size = new System.Drawing.Size(1444, 546);
            this.ExamsListsPanel.TabIndex = 16;
            this.ExamsListsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ExamsListsPanel_Paint);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1444, 767);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExamsListsPanel);
            this.MinimumSize = new System.Drawing.Size(1403, 773);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noexamspic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ExamsListsPanel.ResumeLayout(false);
            this.ExamsListsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FinalExamslbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox noexamspic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label WarmUpMessage;
        public System.Windows.Forms.Button button2;
        private DataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton startFinalBtn;
        private Label nofinallbl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton refreshBtn;
        public Panel ExamsListsPanel;
    }
}