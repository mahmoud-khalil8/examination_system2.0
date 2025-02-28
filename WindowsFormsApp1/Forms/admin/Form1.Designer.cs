namespace WindowsFormsApp1.Forms.admin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOutBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MngTeachersBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.MngStdsBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.LogOutBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MngTeachersBtn);
            this.panel1.Controls.Add(this.MngStdsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 785);
            this.panel1.TabIndex = 0;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(10, 702);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(176, 68);
            this.LogOutBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LogOutBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LogOutBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.LogOutBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.LogOutBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LogOutBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.LogOutBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.LogOutBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.LogOutBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.LogOutBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LogOutBtn.StateTracking.Border.Rounding = 10;
            this.LogOutBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.LogOutBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.LogOutBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.TabIndex = 4;
            this.LogOutBtn.Values.Text = "Log Out";
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 327);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MngTeachersBtn
            // 
            this.MngTeachersBtn.Location = new System.Drawing.Point(91, 510);
            this.MngTeachersBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MngTeachersBtn.Name = "MngTeachersBtn";
            this.MngTeachersBtn.Size = new System.Drawing.Size(247, 55);
            this.MngTeachersBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MngTeachersBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MngTeachersBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.MngTeachersBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.MngTeachersBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MngTeachersBtn.StateCommon.Border.Rounding = 10;
            this.MngTeachersBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.MngTeachersBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.MngTeachersBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngTeachersBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.MngTeachersBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.MngTeachersBtn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.MngTeachersBtn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.MngTeachersBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MngTeachersBtn.StateTracking.Border.Rounding = 10;
            this.MngTeachersBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.MngTeachersBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.MngTeachersBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngTeachersBtn.TabIndex = 1;
            this.MngTeachersBtn.Values.Text = "Manage Teachers";
            this.MngTeachersBtn.Click += new System.EventHandler(this.MngTeachersBtn_Click);
            // 
            // MngStdsBtn
            // 
            this.MngStdsBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.MngStdsBtn.Location = new System.Drawing.Point(90, 433);
            this.MngStdsBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MngStdsBtn.Name = "MngStdsBtn";
            this.MngStdsBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MngStdsBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MngStdsBtn.Size = new System.Drawing.Size(247, 55);
            this.MngStdsBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MngStdsBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MngStdsBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.MngStdsBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.MngStdsBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MngStdsBtn.StateCommon.Border.Rounding = 10;
            this.MngStdsBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.MngStdsBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.MngStdsBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngStdsBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.MngStdsBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.MngStdsBtn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.MngStdsBtn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.MngStdsBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MngStdsBtn.StateTracking.Border.Rounding = 10;
            this.MngStdsBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.MngStdsBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.MngStdsBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngStdsBtn.TabIndex = 0;
            this.MngStdsBtn.Values.Text = "Manage Students";
            this.MngStdsBtn.Click += new System.EventHandler(this.MngStdsBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(460, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(958, 696);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1575, 785);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton MngTeachersBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton MngStdsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton LogOutBtn;
    }
}