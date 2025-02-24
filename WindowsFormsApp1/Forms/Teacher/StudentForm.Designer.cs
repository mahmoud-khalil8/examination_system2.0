namespace WindowsFormsApp1.Forms.Teacher
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.OutStdBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewAllStdBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.UpdStdBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DeletStdBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.AddStdBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateStdUc1 = new WindowsFormsApp1.UserControls.StdUC.UpdateStdUc();
            this.removeStd1 = new WindowsFormsApp1.UserControls.StdUC.RemoveStd();
            this.addStd3 = new WindowsFormsApp1.UserControls.StdUC.AddStd();
            this.dgvViewAll = new System.Windows.Forms.DataGridView();
            this.addStd2 = new WindowsFormsApp1.UserControls.StdUC.AddStd();
            this.addStd1 = new WindowsFormsApp1.UserControls.StdUC.AddStd();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.OutStdBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ViewAllStdBtn);
            this.panel1.Controls.Add(this.UpdStdBtn);
            this.panel1.Controls.Add(this.DeletStdBtn);
            this.panel1.Controls.Add(this.AddStdBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 785);
            this.panel1.TabIndex = 0;
            //this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // OutStdBtn
            // 
            this.OutStdBtn.Location = new System.Drawing.Point(56, 714);
            this.OutStdBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OutStdBtn.Name = "OutStdBtn";
            this.OutStdBtn.Size = new System.Drawing.Size(135, 33);
            this.OutStdBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OutStdBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OutStdBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.OutStdBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.OutStdBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OutStdBtn.StateCommon.Border.Rounding = 10;
            this.OutStdBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.OutStdBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.OutStdBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutStdBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.OutStdBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.OutStdBtn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.OutStdBtn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.OutStdBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OutStdBtn.StateTracking.Border.Rounding = 10;
            this.OutStdBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.OutStdBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.OutStdBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutStdBtn.TabIndex = 6;
            this.OutStdBtn.Values.Text = "Log Out";
            this.OutStdBtn.Click += new System.EventHandler(this.OutStdBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ViewAllStdBtn
            // 
            this.ViewAllStdBtn.Location = new System.Drawing.Point(56, 405);
            this.ViewAllStdBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViewAllStdBtn.Name = "ViewAllStdBtn";
            this.ViewAllStdBtn.Size = new System.Drawing.Size(307, 48);
            this.ViewAllStdBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ViewAllStdBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ViewAllStdBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.ViewAllStdBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.ViewAllStdBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ViewAllStdBtn.StateCommon.Border.Rounding = 10;
            this.ViewAllStdBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ViewAllStdBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ViewAllStdBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllStdBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.ViewAllStdBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.ViewAllStdBtn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.ViewAllStdBtn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.ViewAllStdBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ViewAllStdBtn.StateTracking.Border.Rounding = 10;
            this.ViewAllStdBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.ViewAllStdBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.ViewAllStdBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllStdBtn.TabIndex = 3;
            this.ViewAllStdBtn.Values.Text = "View All Students";
            this.ViewAllStdBtn.Click += new System.EventHandler(this.ViewAllStdBtn_Click);
            // 
            // UpdStdBtn
            // 
            this.UpdStdBtn.Location = new System.Drawing.Point(56, 556);
            this.UpdStdBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdStdBtn.Name = "UpdStdBtn";
            this.UpdStdBtn.Size = new System.Drawing.Size(307, 48);
            this.UpdStdBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdStdBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdStdBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.UpdStdBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.UpdStdBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UpdStdBtn.StateCommon.Border.Rounding = 10;
            this.UpdStdBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.UpdStdBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.UpdStdBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdStdBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.UpdStdBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.UpdStdBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UpdStdBtn.StateTracking.Border.Rounding = 10;
            this.UpdStdBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.UpdStdBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.UpdStdBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdStdBtn.TabIndex = 2;
            this.UpdStdBtn.Values.Text = "Update Students";
            this.UpdStdBtn.Click += new System.EventHandler(this.UpdStdBtn_Click);
            // 
            // DeletStdBtn
            // 
            this.DeletStdBtn.Location = new System.Drawing.Point(56, 482);
            this.DeletStdBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeletStdBtn.Name = "DeletStdBtn";
            this.DeletStdBtn.Size = new System.Drawing.Size(307, 48);
            this.DeletStdBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeletStdBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeletStdBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.DeletStdBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.DeletStdBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DeletStdBtn.StateCommon.Border.Rounding = 10;
            this.DeletStdBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.DeletStdBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.DeletStdBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletStdBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.DeletStdBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.DeletStdBtn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.DeletStdBtn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.DeletStdBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DeletStdBtn.StateTracking.Border.Rounding = 10;
            this.DeletStdBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.DeletStdBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.DeletStdBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletStdBtn.TabIndex = 1;
            this.DeletStdBtn.Values.Text = "Remove Student";
            this.DeletStdBtn.Click += new System.EventHandler(this.DeletStdBtn_Click);
            // 
            // AddStdBtn
            // 
            this.AddStdBtn.Location = new System.Drawing.Point(56, 331);
            this.AddStdBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddStdBtn.Name = "AddStdBtn";
            this.AddStdBtn.Size = new System.Drawing.Size(307, 48);
            this.AddStdBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddStdBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddStdBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.AddStdBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.AddStdBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddStdBtn.StateCommon.Border.Rounding = 10;
            this.AddStdBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.AddStdBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.AddStdBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStdBtn.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.AddStdBtn.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.AddStdBtn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.AddStdBtn.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.AddStdBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddStdBtn.StatePressed.Border.Rounding = 10;
            this.AddStdBtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.AddStdBtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.AddStdBtn.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStdBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.AddStdBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.AddStdBtn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.AddStdBtn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.AddStdBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddStdBtn.StateTracking.Border.Rounding = 10;
            this.AddStdBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.AddStdBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.AddStdBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStdBtn.TabIndex = 0;
            this.AddStdBtn.Values.Text = "Add New Student";
            this.AddStdBtn.Click += new System.EventHandler(this.AddStdBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.updateStdUc1);
            this.panel2.Controls.Add(this.removeStd1);
            this.panel2.Controls.Add(this.addStd3);
            this.panel2.Controls.Add(this.dgvViewAll);
            this.panel2.Controls.Add(this.addStd2);
            this.panel2.Controls.Add(this.addStd1);
            this.panel2.Location = new System.Drawing.Point(434, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 803);
            this.panel2.TabIndex = 1;
            // 
            // updateStdUc1
            // 
            this.updateStdUc1.BackColor = System.Drawing.Color.White;
            this.updateStdUc1.Location = new System.Drawing.Point(0, 0);
            this.updateStdUc1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.updateStdUc1.Name = "updateStdUc1";
            this.updateStdUc1.Size = new System.Drawing.Size(1136, 785);
            this.updateStdUc1.TabIndex = 4;
            this.updateStdUc1.Visible = false;
            this.updateStdUc1.Load += new System.EventHandler(this.updateStdUc1_Load);
            // 
            // removeStd1
            // 
            this.removeStd1.BackColor = System.Drawing.Color.White;
            this.removeStd1.Location = new System.Drawing.Point(0, 0);
            this.removeStd1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.removeStd1.Name = "removeStd1";
            this.removeStd1.Size = new System.Drawing.Size(1140, 748);
            this.removeStd1.TabIndex = 3;
            this.removeStd1.Visible = false;
            // 
            // addStd3
            // 
            this.addStd3.BackColor = System.Drawing.Color.White;
            this.addStd3.Location = new System.Drawing.Point(0, 0);
            this.addStd3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.addStd3.Name = "addStd3";
            this.addStd3.Size = new System.Drawing.Size(1028, 803);
            this.addStd3.TabIndex = 2;
            this.addStd3.Load += new System.EventHandler(this.addStd3_Load);
            // 
            // dgvViewAll
            // 
            this.dgvViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewAll.Location = new System.Drawing.Point(0, 0);
            this.dgvViewAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvViewAll.Name = "dgvViewAll";
            this.dgvViewAll.RowHeadersWidth = 47;
            this.dgvViewAll.Size = new System.Drawing.Size(1140, 803);
            this.dgvViewAll.TabIndex = 2;
            this.dgvViewAll.Visible = false;
            // 
            // addStd2
            // 
            this.addStd2.BackColor = System.Drawing.Color.White;
            this.addStd2.Location = new System.Drawing.Point(240, 141);
            this.addStd2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.addStd2.Name = "addStd2";
            this.addStd2.Size = new System.Drawing.Size(35, 9);
            this.addStd2.TabIndex = 1;
            // 
            // addStd1
            // 
            this.addStd1.BackColor = System.Drawing.Color.White;
            this.addStd1.Location = new System.Drawing.Point(0, -3);
            this.addStd1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.addStd1.Name = "addStd1";
            this.addStd1.Size = new System.Drawing.Size(1140, 800);
            this.addStd1.TabIndex = 0;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 785);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StudentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AddStdBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ViewAllStdBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton UpdStdBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton DeletStdBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private UserControls.StdUC.AddStd addStd2;
        private UserControls.StdUC.AddStd addStd1;
        private System.Windows.Forms.DataGridView dgvViewAll;
        private UserControls.StdUC.AddStd addStd3;
        private UserControls.StdUC.RemoveStd removeStd1;
        private UserControls.StdUC.UpdateStdUc updateStdUc1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton OutStdBtn;
    }
}