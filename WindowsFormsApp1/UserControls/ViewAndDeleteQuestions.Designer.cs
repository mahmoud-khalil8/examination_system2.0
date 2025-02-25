namespace WindowsFormsApp1.UserControls
{
    partial class ViewAndDeleteQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAndDeleteQuestions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbexamid = new Krypton.Toolkit.KryptonComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbout = new System.Windows.Forms.Label();
            this.btndelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbexamid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(50, 40);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(332, 39);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "View And Delete Questions";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(58, 170);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(88, 29);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Exam ID:";
            // 
            // cbexamid
            // 
            this.cbexamid.DropDownHeight = 150;
            this.cbexamid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbexamid.DropDownWidth = 150;
            this.cbexamid.IntegralHeight = false;
            this.cbexamid.Location = new System.Drawing.Point(152, 166);
            this.cbexamid.Name = "cbexamid";
            this.cbexamid.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbexamid.Size = new System.Drawing.Size(250, 37);
            this.cbexamid.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.cbexamid.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Black;
            this.cbexamid.StateCommon.ComboBox.Border.Rounding = 10F;
            this.cbexamid.StateCommon.ComboBox.Border.Width = 1;
            this.cbexamid.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbexamid.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbexamid.StateCommon.DropBack.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbexamid.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbexamid.StateCommon.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbexamid.StateNormal.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.cbexamid.StateNormal.ComboBox.Border.Color2 = System.Drawing.Color.Black;
            this.cbexamid.StateNormal.ComboBox.Border.Rounding = 10F;
            this.cbexamid.TabIndex = 7;
            this.cbexamid.SelectedIndexChanged += new System.EventHandler(this.cbexamid_SelectedIndexChanged);
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(54, 231);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(850, 484);
            this.dgv.TabIndex = 8;
            // 
            // lbout
            // 
            this.lbout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbout.Location = new System.Drawing.Point(54, 731);
            this.lbout.Name = "lbout";
            this.lbout.Size = new System.Drawing.Size(850, 25);
            this.lbout.TabIndex = 9;
            this.lbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(708, 768);
            this.btndelete.Name = "btndelete";
            this.btndelete.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndelete.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btndelete.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btndelete.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btndelete.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btndelete.OverrideFocus.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndelete.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndelete.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndelete.OverrideFocus.Border.Rounding = 20;
            this.btndelete.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.Size = new System.Drawing.Size(196, 57);
            this.btndelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndelete.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndelete.StateCommon.Border.Rounding = 20;
            this.btndelete.StateCommon.Border.Width = 1;
            this.btndelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btndelete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btndelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btndelete.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btndelete.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndelete.StateDisabled.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndelete.StateDisabled.Border.Rounding = 20;
            this.btndelete.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndelete.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndelete.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndelete.StateNormal.Border.Rounding = 20;
            this.btndelete.StateNormal.Border.Width = 1;
            this.btndelete.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btndelete.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btndelete.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btndelete.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btndelete.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndelete.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndelete.StatePressed.Border.Rounding = 20;
            this.btndelete.StatePressed.Border.Width = 1;
            this.btndelete.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btndelete.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btndelete.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btndelete.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btndelete.StateTracking.Border.Rounding = 20;
            this.btndelete.StateTracking.Border.Width = 1;
            this.btndelete.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.TabIndex = 4;
            this.btndelete.Values.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // ViewAndDeleteQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbout);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cbexamid);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.btndelete);
            this.Name = "ViewAndDeleteQuestions";
            this.Size = new System.Drawing.Size(939, 832);
            this.Load += new System.EventHandler(this.ViewAndDeleteQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbexamid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox cbexamid;
        private System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.Label lbout;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btndelete;
    }
}
