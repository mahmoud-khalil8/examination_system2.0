namespace WindowsFormsApp1.Forms.admin
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.OutTchBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.UpdTchBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DeleTchBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ViewAllTchBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.AddTchBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteTeacherUC1 = new WindowsFormsApp1.UserControls.TeacherUC.DeleteTeacherUC();
            this.updTeacherUC1 = new WindowsFormsApp1.UserControls.TeacherUC.UpdTeacherUC();
            this.addTeacherUc1 = new WindowsFormsApp1.UserControls.TeacherUC.AddTeacherUc();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.OutTchBtn);
            this.panel1.Controls.Add(this.UpdTchBtn);
            this.panel1.Controls.Add(this.DeleTchBtn);
            this.panel1.Controls.Add(this.ViewAllTchBtn);
            this.panel1.Controls.Add(this.AddTchBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 785);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // OutTchBtn
            // 
            this.OutTchBtn.Location = new System.Drawing.Point(28, 726);
            this.OutTchBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OutTchBtn.Name = "OutTchBtn";
            this.OutTchBtn.Size = new System.Drawing.Size(135, 33);
            this.OutTchBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OutTchBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OutTchBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.OutTchBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.OutTchBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OutTchBtn.StateCommon.Border.Rounding = 10;
            this.OutTchBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.OutTchBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.OutTchBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutTchBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.OutTchBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.OutTchBtn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.OutTchBtn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.OutTchBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OutTchBtn.StateTracking.Border.Rounding = 10;
            this.OutTchBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.OutTchBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.OutTchBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutTchBtn.TabIndex = 11;
            this.OutTchBtn.Values.Text = "Exit";
            this.OutTchBtn.Click += new System.EventHandler(this.OutTchBtn_Click);
            // 
            // UpdTchBtn
            // 
            this.UpdTchBtn.Location = new System.Drawing.Point(56, 558);
            this.UpdTchBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdTchBtn.Name = "UpdTchBtn";
            this.UpdTchBtn.Size = new System.Drawing.Size(307, 48);
            this.UpdTchBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdTchBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdTchBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.UpdTchBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.UpdTchBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UpdTchBtn.StateCommon.Border.Rounding = 10;
            this.UpdTchBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.UpdTchBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.UpdTchBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdTchBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.UpdTchBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.UpdTchBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UpdTchBtn.StateTracking.Border.Rounding = 10;
            this.UpdTchBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.UpdTchBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.UpdTchBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdTchBtn.TabIndex = 10;
            this.UpdTchBtn.Values.Text = "Update Teachers";
            this.UpdTchBtn.Click += new System.EventHandler(this.UpdTchBtn_Click);
            // 
            // DeleTchBtn
            // 
            this.DeleTchBtn.Location = new System.Drawing.Point(56, 477);
            this.DeleTchBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleTchBtn.Name = "DeleTchBtn";
            this.DeleTchBtn.Size = new System.Drawing.Size(307, 48);
            this.DeleTchBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleTchBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleTchBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.DeleTchBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.DeleTchBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DeleTchBtn.StateCommon.Border.Rounding = 10;
            this.DeleTchBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.DeleTchBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.DeleTchBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleTchBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.DeleTchBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.DeleTchBtn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.DeleTchBtn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.DeleTchBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DeleTchBtn.StateTracking.Border.Rounding = 10;
            this.DeleTchBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.DeleTchBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.DeleTchBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleTchBtn.TabIndex = 9;
            this.DeleTchBtn.Values.Text = "Remove Teacher";
            this.DeleTchBtn.Click += new System.EventHandler(this.DeleTchBtn_Click);
            // 
            // ViewAllTchBtn
            // 
            this.ViewAllTchBtn.Location = new System.Drawing.Point(56, 401);
            this.ViewAllTchBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViewAllTchBtn.Name = "ViewAllTchBtn";
            this.ViewAllTchBtn.Size = new System.Drawing.Size(307, 48);
            this.ViewAllTchBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ViewAllTchBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ViewAllTchBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.ViewAllTchBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.ViewAllTchBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ViewAllTchBtn.StateCommon.Border.Rounding = 10;
            this.ViewAllTchBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ViewAllTchBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ViewAllTchBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllTchBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.ViewAllTchBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.ViewAllTchBtn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.ViewAllTchBtn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.ViewAllTchBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ViewAllTchBtn.StateTracking.Border.Rounding = 10;
            this.ViewAllTchBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.ViewAllTchBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.ViewAllTchBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllTchBtn.TabIndex = 8;
            this.ViewAllTchBtn.Values.Text = "View All Teachers";
            this.ViewAllTchBtn.Click += new System.EventHandler(this.ViewAllTchBtn_Click);
            // 
            // AddTchBtn
            // 
            this.AddTchBtn.Location = new System.Drawing.Point(56, 331);
            this.AddTchBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddTchBtn.Name = "AddTchBtn";
            this.AddTchBtn.Size = new System.Drawing.Size(307, 48);
            this.AddTchBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddTchBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddTchBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.AddTchBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.AddTchBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddTchBtn.StateCommon.Border.Rounding = 10;
            this.AddTchBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.AddTchBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.AddTchBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTchBtn.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.AddTchBtn.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.AddTchBtn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.AddTchBtn.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.AddTchBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddTchBtn.StatePressed.Border.Rounding = 10;
            this.AddTchBtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.AddTchBtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.AddTchBtn.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTchBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.AddTchBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.AddTchBtn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.AddTchBtn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.AddTchBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddTchBtn.StateTracking.Border.Rounding = 10;
            this.AddTchBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.AddTchBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.AddTchBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTchBtn.TabIndex = 7;
            this.AddTchBtn.Values.Text = "Add New Teacher";
            this.AddTchBtn.Click += new System.EventHandler(this.AddTchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Teacher";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteTeacherUC1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.updTeacherUC1);
            this.panel2.Controls.Add(this.addTeacherUc1);
            this.panel2.Location = new System.Drawing.Point(434, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 785);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(5, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.Size = new System.Drawing.Size(1136, 785);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // deleteTeacherUC1
            // 
            this.deleteTeacherUC1.BackColor = System.Drawing.Color.White;
            this.deleteTeacherUC1.Location = new System.Drawing.Point(5, -3);
            this.deleteTeacherUC1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.deleteTeacherUC1.Name = "deleteTeacherUC1";
            this.deleteTeacherUC1.Size = new System.Drawing.Size(1136, 785);
            this.deleteTeacherUC1.TabIndex = 3;
            this.deleteTeacherUC1.Load += new System.EventHandler(this.deleteTeacherUC1_Load);
            // 
            // updTeacherUC1
            // 
            this.updTeacherUC1.BackColor = System.Drawing.Color.White;
            this.updTeacherUC1.Location = new System.Drawing.Point(5, 0);
            this.updTeacherUC1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.updTeacherUC1.Name = "updTeacherUC1";
            this.updTeacherUC1.Size = new System.Drawing.Size(1136, 785);
            this.updTeacherUC1.TabIndex = 1;
            this.updTeacherUC1.Visible = false;
            // 
            // addTeacherUc1
            // 
            this.addTeacherUc1.BackColor = System.Drawing.Color.White;
            this.addTeacherUc1.Location = new System.Drawing.Point(5, 0);
            this.addTeacherUc1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.addTeacherUc1.Name = "addTeacherUc1";
            this.addTeacherUc1.Size = new System.Drawing.Size(1136, 785);
            this.addTeacherUc1.TabIndex = 0;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 785);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TeacherForm";
            this.ShowIcon = false;
            this.Text = "Teacher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AddTchBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ViewAllTchBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton DeleTchBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton UpdTchBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton OutTchBtn;
        private UserControls.TeacherUC.AddTeacherUc addTeacherUc1;
        private UserControls.TeacherUC.UpdTeacherUC updTeacherUC1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UserControls.TeacherUC.DeleteTeacherUC deleteTeacherUC1;
    }
}