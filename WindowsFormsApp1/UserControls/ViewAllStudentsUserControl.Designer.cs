namespace WindowsFormsApp1.UserControls
{
    partial class ViewAllStudentsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllStudentsUserControl));
            this.lbout = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbstud = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btndetails = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbstud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbout
            // 
            this.lbout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbout.Location = new System.Drawing.Point(39, 712);
            this.lbout.Name = "lbout";
            this.lbout.Size = new System.Drawing.Size(849, 25);
            this.lbout.TabIndex = 15;
            this.lbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.CausesValidation = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.ColumnHeadersHeight = 29;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv.Location = new System.Drawing.Point(39, 206);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(850, 484);
            this.dgv.TabIndex = 14;
            // 
            // cbstud
            // 
            this.cbstud.DropDownHeight = 150;
            this.cbstud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstud.DropDownWidth = 150;
            this.cbstud.IntegralHeight = false;
            this.cbstud.Location = new System.Drawing.Point(187, 141);
            this.cbstud.Name = "cbstud";
            this.cbstud.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbstud.Size = new System.Drawing.Size(250, 37);
            this.cbstud.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.cbstud.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Black;
            this.cbstud.StateCommon.ComboBox.Border.Rounding = 10F;
            this.cbstud.StateCommon.ComboBox.Border.Width = 1;
            this.cbstud.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstud.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbstud.StateCommon.DropBack.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbstud.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbstud.StateCommon.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbstud.StateNormal.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.cbstud.StateNormal.ComboBox.Border.Color2 = System.Drawing.Color.Black;
            this.cbstud.StateNormal.ComboBox.Border.Rounding = 10F;
            this.cbstud.TabIndex = 13;
            this.cbstud.SelectedIndexChanged += new System.EventHandler(this.cbstud_SelectedIndexChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(39, 145);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(142, 29);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 12;
            this.kryptonLabel1.Values.Text = "Student Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(39, 36);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(219, 39);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 10;
            this.kryptonLabel3.Values.Text = "View All Students";
            // 
            // btndetails
            // 
            this.btndetails.Location = new System.Drawing.Point(692, 760);
            this.btndetails.Name = "btndetails";
            this.btndetails.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndetails.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btndetails.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btndetails.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btndetails.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btndetails.OverrideFocus.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndetails.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndetails.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndetails.OverrideFocus.Border.Rounding = 20;
            this.btndetails.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.Size = new System.Drawing.Size(196, 57);
            this.btndetails.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndetails.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndetails.StateCommon.Border.Rounding = 20;
            this.btndetails.StateCommon.Border.Width = 1;
            this.btndetails.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btndetails.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btndetails.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetails.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btndetails.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btndetails.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndetails.StateDisabled.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndetails.StateDisabled.Border.Rounding = 20;
            this.btndetails.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndetails.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndetails.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndetails.StateNormal.Border.Rounding = 20;
            this.btndetails.StateNormal.Border.Width = 1;
            this.btndetails.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btndetails.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btndetails.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btndetails.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btndetails.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndetails.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndetails.StatePressed.Border.Rounding = 20;
            this.btndetails.StatePressed.Border.Width = 1;
            this.btndetails.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btndetails.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btndetails.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndetails.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndetails.StateTracking.Border.Rounding = 20;
            this.btndetails.StateTracking.Border.Width = 1;
            this.btndetails.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetails.TabIndex = 16;
            this.btndetails.Values.Text = "Details";
            this.btndetails.Click += new System.EventHandler(this.btndetails_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(475, 760);
            this.btnsave.Name = "btnsave";
            this.btnsave.OverrideDefault.Back.Color1 = System.Drawing.Color.Green;
            this.btnsave.OverrideDefault.Back.Color2 = System.Drawing.Color.Green;
            this.btnsave.OverrideDefault.Border.Color1 = System.Drawing.Color.Green;
            this.btnsave.OverrideDefault.Border.Color2 = System.Drawing.Color.Green;
            this.btnsave.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnsave.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnsave.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnsave.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnsave.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnsave.OverrideFocus.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnsave.OverrideFocus.Border.Color1 = System.Drawing.Color.Green;
            this.btnsave.OverrideFocus.Border.Color2 = System.Drawing.Color.Green;
            this.btnsave.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnsave.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnsave.OverrideFocus.Border.Rounding = 20;
            this.btnsave.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.Green;
            this.btnsave.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.Green;
            this.btnsave.Size = new System.Drawing.Size(196, 57);
            this.btnsave.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.btnsave.StateCommon.Back.Color2 = System.Drawing.Color.Green;
            this.btnsave.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.btnsave.StateCommon.Border.Color2 = System.Drawing.Color.Green;
            this.btnsave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnsave.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnsave.StateCommon.Border.Rounding = 20;
            this.btnsave.StateCommon.Border.Width = 1;
            this.btnsave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnsave.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnsave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnsave.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnsave.StateDisabled.Border.Color1 = System.Drawing.Color.Green;
            this.btnsave.StateDisabled.Border.Color2 = System.Drawing.Color.Green;
            this.btnsave.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnsave.StateDisabled.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnsave.StateDisabled.Border.Rounding = 20;
            this.btnsave.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Green;
            this.btnsave.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.Green;
            this.btnsave.StateNormal.Back.Color1 = System.Drawing.Color.Green;
            this.btnsave.StateNormal.Back.Color2 = System.Drawing.Color.Green;
            this.btnsave.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnsave.StateNormal.Border.Color1 = System.Drawing.Color.Green;
            this.btnsave.StateNormal.Border.Color2 = System.Drawing.Color.Green;
            this.btnsave.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnsave.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnsave.StateNormal.Border.Rounding = 20;
            this.btnsave.StateNormal.Border.Width = 1;
            this.btnsave.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnsave.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnsave.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnsave.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnsave.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnsave.StatePressed.Border.Color1 = System.Drawing.Color.Green;
            this.btnsave.StatePressed.Border.Color2 = System.Drawing.Color.Green;
            this.btnsave.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnsave.StatePressed.Border.Rounding = 20;
            this.btnsave.StatePressed.Border.Width = 1;
            this.btnsave.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Green;
            this.btnsave.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Green;
            this.btnsave.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnsave.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnsave.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnsave.StateTracking.Border.Color1 = System.Drawing.Color.Green;
            this.btnsave.StateTracking.Border.Color2 = System.Drawing.Color.Green;
            this.btnsave.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnsave.StateTracking.Border.Rounding = 20;
            this.btnsave.StateTracking.Border.Width = 1;
            this.btnsave.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Green;
            this.btnsave.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Green;
            this.btnsave.TabIndex = 16;
            this.btnsave.Values.Text = "Save As Excel";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // ViewAllStudentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndetails);
            this.Controls.Add(this.lbout);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cbstud);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonLabel3);
            this.Name = "ViewAllStudentsUserControl";
            this.Size = new System.Drawing.Size(939, 832);
            this.Load += new System.EventHandler(this.ViewAllStudentsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbstud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbout;
        private System.Windows.Forms.DataGridView dgv;
        private Krypton.Toolkit.KryptonComboBox cbstud;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btndetails;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnsave;
    }
}
