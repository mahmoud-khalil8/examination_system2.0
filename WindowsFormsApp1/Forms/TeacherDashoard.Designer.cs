namespace WindowsFormsApp1.Forms
{
    partial class TeacherDashoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashoard));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbteacgername = new System.Windows.Forms.Label();
            this.linklblogout = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnallstudents = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnviewdeleteq = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnupdatequestion = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnaddquestion = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.UpdateQuetionsUserControl = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panalchange = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panalchange)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lbteacgername);
            this.kryptonPanel1.Controls.Add(this.linklblogout);
            this.kryptonPanel1.Controls.Add(this.btnallstudents);
            this.kryptonPanel1.Controls.Add(this.btnviewdeleteq);
            this.kryptonPanel1.Controls.Add(this.btnupdatequestion);
            this.kryptonPanel1.Controls.Add(this.btnaddquestion);
            this.kryptonPanel1.Controls.Add(this.UpdateQuetionsUserControl);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(311, 803);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonPanel1.TabIndex = 0;
            // 
            // lbteacgername
            // 
            this.lbteacgername.BackColor = System.Drawing.Color.Transparent;
            this.lbteacgername.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbteacgername.ForeColor = System.Drawing.Color.White;
            this.lbteacgername.Location = new System.Drawing.Point(0, 162);
            this.lbteacgername.Name = "lbteacgername";
            this.lbteacgername.Size = new System.Drawing.Size(311, 37);
            this.lbteacgername.TabIndex = 3;
            this.lbteacgername.Text = "Teacher Name";
            this.lbteacgername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linklblogout
            // 
            this.linklblogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linklblogout.Location = new System.Drawing.Point(0, 776);
            this.linklblogout.Name = "linklblogout";
            this.linklblogout.Size = new System.Drawing.Size(311, 27);
            this.linklblogout.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.linklblogout.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblogout.TabIndex = 2;
            this.linklblogout.Values.Text = "Log Out";
            // 
            // btnallstudents
            // 
            this.btnallstudents.Location = new System.Drawing.Point(40, 582);
            this.btnallstudents.Name = "btnallstudents";
            this.btnallstudents.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnallstudents.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnallstudents.OverrideDefault.Back.ColorAngle = 45F;
            this.btnallstudents.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnallstudents.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnallstudents.OverrideDefault.Border.ColorAngle = 45F;
            this.btnallstudents.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnallstudents.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnallstudents.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnallstudents.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnallstudents.Size = new System.Drawing.Size(229, 47);
            this.btnallstudents.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnallstudents.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnallstudents.StateCommon.Back.ColorAngle = 45F;
            this.btnallstudents.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnallstudents.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnallstudents.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnallstudents.StateCommon.Border.ColorAngle = 45F;
            this.btnallstudents.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnallstudents.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnallstudents.StateCommon.Border.Rounding = 20;
            this.btnallstudents.StateCommon.Border.Width = 1;
            this.btnallstudents.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnallstudents.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnallstudents.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnallstudents.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnallstudents.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnallstudents.StateNormal.Back.ColorAngle = 45F;
            this.btnallstudents.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnallstudents.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnallstudents.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnallstudents.StateNormal.Border.ColorAngle = 45F;
            this.btnallstudents.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnallstudents.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnallstudents.StateNormal.Border.Rounding = 20;
            this.btnallstudents.StateNormal.Border.Width = 1;
            this.btnallstudents.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnallstudents.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnallstudents.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnallstudents.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnallstudents.StatePressed.Back.ColorAngle = 135F;
            this.btnallstudents.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnallstudents.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnallstudents.StatePressed.Border.ColorAngle = 135F;
            this.btnallstudents.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnallstudents.StatePressed.Border.Rounding = 20;
            this.btnallstudents.StatePressed.Border.Width = 1;
            this.btnallstudents.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnallstudents.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnallstudents.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnallstudents.StateTracking.Back.ColorAngle = 45F;
            this.btnallstudents.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnallstudents.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnallstudents.StateTracking.Border.ColorAngle = 45F;
            this.btnallstudents.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnallstudents.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnallstudents.StateTracking.Border.Rounding = 20;
            this.btnallstudents.StateTracking.Border.Width = 1;
            this.btnallstudents.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnallstudents.TabIndex = 1;
            this.btnallstudents.Values.Text = "All Students Result";
            this.btnallstudents.Click += new System.EventHandler(this.btnallstudents_Click);
            // 
            // btnviewdeleteq
            // 
            this.btnviewdeleteq.Location = new System.Drawing.Point(40, 498);
            this.btnviewdeleteq.Name = "btnviewdeleteq";
            this.btnviewdeleteq.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnviewdeleteq.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnviewdeleteq.OverrideDefault.Back.ColorAngle = 45F;
            this.btnviewdeleteq.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnviewdeleteq.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnviewdeleteq.OverrideDefault.Border.ColorAngle = 45F;
            this.btnviewdeleteq.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnviewdeleteq.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnviewdeleteq.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnviewdeleteq.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnviewdeleteq.Size = new System.Drawing.Size(229, 47);
            this.btnviewdeleteq.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnviewdeleteq.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnviewdeleteq.StateCommon.Back.ColorAngle = 45F;
            this.btnviewdeleteq.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnviewdeleteq.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnviewdeleteq.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnviewdeleteq.StateCommon.Border.ColorAngle = 45F;
            this.btnviewdeleteq.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnviewdeleteq.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnviewdeleteq.StateCommon.Border.Rounding = 20;
            this.btnviewdeleteq.StateCommon.Border.Width = 1;
            this.btnviewdeleteq.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnviewdeleteq.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnviewdeleteq.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewdeleteq.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnviewdeleteq.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnviewdeleteq.StateNormal.Back.ColorAngle = 45F;
            this.btnviewdeleteq.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnviewdeleteq.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnviewdeleteq.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnviewdeleteq.StateNormal.Border.ColorAngle = 45F;
            this.btnviewdeleteq.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnviewdeleteq.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnviewdeleteq.StateNormal.Border.Rounding = 20;
            this.btnviewdeleteq.StateNormal.Border.Width = 1;
            this.btnviewdeleteq.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnviewdeleteq.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnviewdeleteq.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnviewdeleteq.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnviewdeleteq.StatePressed.Back.ColorAngle = 135F;
            this.btnviewdeleteq.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnviewdeleteq.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnviewdeleteq.StatePressed.Border.ColorAngle = 135F;
            this.btnviewdeleteq.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnviewdeleteq.StatePressed.Border.Rounding = 20;
            this.btnviewdeleteq.StatePressed.Border.Width = 1;
            this.btnviewdeleteq.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnviewdeleteq.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnviewdeleteq.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnviewdeleteq.StateTracking.Back.ColorAngle = 45F;
            this.btnviewdeleteq.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnviewdeleteq.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnviewdeleteq.StateTracking.Border.ColorAngle = 45F;
            this.btnviewdeleteq.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnviewdeleteq.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnviewdeleteq.StateTracking.Border.Rounding = 20;
            this.btnviewdeleteq.StateTracking.Border.Width = 1;
            this.btnviewdeleteq.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnviewdeleteq.TabIndex = 1;
            this.btnviewdeleteq.Values.Text = "View / Delete Questions";
            this.btnviewdeleteq.Click += new System.EventHandler(this.btnviewdeleteq_Click);
            // 
            // btnupdatequestion
            // 
            this.btnupdatequestion.Location = new System.Drawing.Point(40, 414);
            this.btnupdatequestion.Name = "btnupdatequestion";
            this.btnupdatequestion.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdatequestion.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdatequestion.OverrideDefault.Back.ColorAngle = 45F;
            this.btnupdatequestion.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdatequestion.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdatequestion.OverrideDefault.Border.ColorAngle = 45F;
            this.btnupdatequestion.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnupdatequestion.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnupdatequestion.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnupdatequestion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnupdatequestion.Size = new System.Drawing.Size(229, 47);
            this.btnupdatequestion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdatequestion.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdatequestion.StateCommon.Back.ColorAngle = 45F;
            this.btnupdatequestion.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnupdatequestion.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdatequestion.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdatequestion.StateCommon.Border.ColorAngle = 45F;
            this.btnupdatequestion.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnupdatequestion.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnupdatequestion.StateCommon.Border.Rounding = 20;
            this.btnupdatequestion.StateCommon.Border.Width = 1;
            this.btnupdatequestion.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnupdatequestion.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnupdatequestion.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatequestion.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdatequestion.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdatequestion.StateNormal.Back.ColorAngle = 45F;
            this.btnupdatequestion.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnupdatequestion.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdatequestion.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdatequestion.StateNormal.Border.ColorAngle = 45F;
            this.btnupdatequestion.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnupdatequestion.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnupdatequestion.StateNormal.Border.Rounding = 20;
            this.btnupdatequestion.StateNormal.Border.Width = 1;
            this.btnupdatequestion.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnupdatequestion.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnupdatequestion.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnupdatequestion.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnupdatequestion.StatePressed.Back.ColorAngle = 135F;
            this.btnupdatequestion.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnupdatequestion.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnupdatequestion.StatePressed.Border.ColorAngle = 135F;
            this.btnupdatequestion.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnupdatequestion.StatePressed.Border.Rounding = 20;
            this.btnupdatequestion.StatePressed.Border.Width = 1;
            this.btnupdatequestion.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnupdatequestion.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnupdatequestion.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnupdatequestion.StateTracking.Back.ColorAngle = 45F;
            this.btnupdatequestion.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnupdatequestion.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnupdatequestion.StateTracking.Border.ColorAngle = 45F;
            this.btnupdatequestion.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnupdatequestion.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnupdatequestion.StateTracking.Border.Rounding = 20;
            this.btnupdatequestion.StateTracking.Border.Width = 1;
            this.btnupdatequestion.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnupdatequestion.TabIndex = 1;
            this.btnupdatequestion.Values.Text = "Update Questions";
            this.btnupdatequestion.Click += new System.EventHandler(this.btnupdatequestion_Click);
            // 
            // btnaddquestion
            // 
            this.btnaddquestion.Location = new System.Drawing.Point(40, 330);
            this.btnaddquestion.Name = "btnaddquestion";
            this.btnaddquestion.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddquestion.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddquestion.OverrideDefault.Back.ColorAngle = 45F;
            this.btnaddquestion.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddquestion.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddquestion.OverrideDefault.Border.ColorAngle = 45F;
            this.btnaddquestion.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnaddquestion.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnaddquestion.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnaddquestion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnaddquestion.Size = new System.Drawing.Size(229, 47);
            this.btnaddquestion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddquestion.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddquestion.StateCommon.Back.ColorAngle = 45F;
            this.btnaddquestion.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnaddquestion.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddquestion.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddquestion.StateCommon.Border.ColorAngle = 45F;
            this.btnaddquestion.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnaddquestion.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnaddquestion.StateCommon.Border.Rounding = 20;
            this.btnaddquestion.StateCommon.Border.Width = 1;
            this.btnaddquestion.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnaddquestion.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnaddquestion.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddquestion.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddquestion.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddquestion.StateNormal.Back.ColorAngle = 45F;
            this.btnaddquestion.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnaddquestion.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddquestion.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddquestion.StateNormal.Border.ColorAngle = 45F;
            this.btnaddquestion.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnaddquestion.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnaddquestion.StateNormal.Border.Rounding = 20;
            this.btnaddquestion.StateNormal.Border.Width = 1;
            this.btnaddquestion.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnaddquestion.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnaddquestion.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnaddquestion.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnaddquestion.StatePressed.Back.ColorAngle = 135F;
            this.btnaddquestion.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnaddquestion.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnaddquestion.StatePressed.Border.ColorAngle = 135F;
            this.btnaddquestion.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnaddquestion.StatePressed.Border.Rounding = 20;
            this.btnaddquestion.StatePressed.Border.Width = 1;
            this.btnaddquestion.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnaddquestion.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnaddquestion.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnaddquestion.StateTracking.Back.ColorAngle = 45F;
            this.btnaddquestion.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnaddquestion.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnaddquestion.StateTracking.Border.ColorAngle = 45F;
            this.btnaddquestion.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnaddquestion.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnaddquestion.StateTracking.Border.Rounding = 20;
            this.btnaddquestion.StateTracking.Border.Width = 1;
            this.btnaddquestion.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnaddquestion.TabIndex = 1;
            this.btnaddquestion.Values.Text = "Add New Questions";
            this.btnaddquestion.Click += new System.EventHandler(this.btnaddquestion_Click);
            // 
            // UpdateQuetionsUserControl
            // 
            this.UpdateQuetionsUserControl.CausesValidation = false;
            this.UpdateQuetionsUserControl.Location = new System.Drawing.Point(40, 246);
            this.UpdateQuetionsUserControl.Name = "UpdateQuetionsUserControl";
            this.UpdateQuetionsUserControl.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.OverrideDefault.Back.ColorAngle = 45F;
            this.UpdateQuetionsUserControl.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.OverrideDefault.Border.ColorAngle = 45F;
            this.UpdateQuetionsUserControl.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UpdateQuetionsUserControl.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.UpdateQuetionsUserControl.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.UpdateQuetionsUserControl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.UpdateQuetionsUserControl.Size = new System.Drawing.Size(229, 47);
            this.UpdateQuetionsUserControl.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.StateCommon.Back.ColorAngle = 45F;
            this.UpdateQuetionsUserControl.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.UpdateQuetionsUserControl.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.StateCommon.Border.ColorAngle = 45F;
            this.UpdateQuetionsUserControl.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UpdateQuetionsUserControl.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.UpdateQuetionsUserControl.StateCommon.Border.Rounding = 20;
            this.UpdateQuetionsUserControl.StateCommon.Border.Width = 1;
            this.UpdateQuetionsUserControl.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.UpdateQuetionsUserControl.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.UpdateQuetionsUserControl.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateQuetionsUserControl.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.StateNormal.Back.ColorAngle = 45F;
            this.UpdateQuetionsUserControl.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.UpdateQuetionsUserControl.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.StateNormal.Border.ColorAngle = 45F;
            this.UpdateQuetionsUserControl.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UpdateQuetionsUserControl.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.UpdateQuetionsUserControl.StateNormal.Border.Rounding = 20;
            this.UpdateQuetionsUserControl.StateNormal.Border.Width = 1;
            this.UpdateQuetionsUserControl.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.UpdateQuetionsUserControl.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.UpdateQuetionsUserControl.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.UpdateQuetionsUserControl.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.UpdateQuetionsUserControl.StatePressed.Back.ColorAngle = 135F;
            this.UpdateQuetionsUserControl.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.UpdateQuetionsUserControl.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.UpdateQuetionsUserControl.StatePressed.Border.ColorAngle = 135F;
            this.UpdateQuetionsUserControl.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UpdateQuetionsUserControl.StatePressed.Border.Rounding = 20;
            this.UpdateQuetionsUserControl.StatePressed.Border.Width = 1;
            this.UpdateQuetionsUserControl.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.UpdateQuetionsUserControl.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateQuetionsUserControl.StateTracking.Back.ColorAngle = 45F;
            this.UpdateQuetionsUserControl.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.UpdateQuetionsUserControl.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.UpdateQuetionsUserControl.StateTracking.Border.ColorAngle = 45F;
            this.UpdateQuetionsUserControl.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UpdateQuetionsUserControl.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.UpdateQuetionsUserControl.StateTracking.Border.Rounding = 20;
            this.UpdateQuetionsUserControl.StateTracking.Border.Width = 1;
            this.UpdateQuetionsUserControl.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.UpdateQuetionsUserControl.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.UpdateQuetionsUserControl.TabIndex = 1;
            this.UpdateQuetionsUserControl.Values.Text = "Add Exam";
            this.UpdateQuetionsUserControl.Click += new System.EventHandler(this.btnaddexam_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 20;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // panalchange
            // 
            this.panalchange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panalchange.Location = new System.Drawing.Point(311, 0);
            this.panalchange.Name = "panalchange";
            this.panalchange.Size = new System.Drawing.Size(827, 801);
            this.panalchange.StateCommon.Color1 = System.Drawing.Color.White;
            this.panalchange.StateCommon.Color2 = System.Drawing.Color.White;
            this.panalchange.StateCommon.Image = ((System.Drawing.Image)(resources.GetObject("panalchange.StateCommon.Image")));
            this.panalchange.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.panalchange.TabIndex = 1;
            this.panalchange.Paint += new System.Windows.Forms.PaintEventHandler(this.panalchange_Paint);
            // 
            // TeacherDashoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1138, 803);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.panalchange);
            this.MinimumSize = new System.Drawing.Size(1156, 847);
            this.Name = "TeacherDashoard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.TeacherDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panalchange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnviewdeleteq;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnupdatequestion;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnaddquestion;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel linklblogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnallstudents;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panalchange;
        private ComponentFactory.Krypton.Toolkit.KryptonButton UpdateQuetionsUserControl;
        private System.Windows.Forms.Label lbteacgername;
    }
}