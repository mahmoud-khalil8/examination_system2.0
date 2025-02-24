namespace WindowsFormsApp1.UserControls.TeacherUC
{
    partial class DeleteTeacherUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.DgvTchRemove = new System.Windows.Forms.DataGridView();
            this.DltTchUCBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTchRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(78, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Remove Teacher";
            // 
            // DgvTchRemove
            // 
            this.DgvTchRemove.BackgroundColor = System.Drawing.Color.White;
            this.DgvTchRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTchRemove.Location = new System.Drawing.Point(34, 98);
            this.DgvTchRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvTchRemove.Name = "DgvTchRemove";
            this.DgvTchRemove.RowHeadersWidth = 47;
            this.DgvTchRemove.Size = new System.Drawing.Size(1084, 509);
            this.DgvTchRemove.TabIndex = 5;
            this.DgvTchRemove.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTchRemove_CellContentClick);
            // 
            // DltTchUCBtn
            // 
            this.DltTchUCBtn.Location = new System.Drawing.Point(860, 641);
            this.DltTchUCBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DltTchUCBtn.Name = "DltTchUCBtn";
            this.DltTchUCBtn.Size = new System.Drawing.Size(222, 62);
            this.DltTchUCBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DltTchUCBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DltTchUCBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.DltTchUCBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.DltTchUCBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DltTchUCBtn.StateCommon.Border.Rounding = 10;
            this.DltTchUCBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.DltTchUCBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.DltTchUCBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DltTchUCBtn.TabIndex = 6;
            this.DltTchUCBtn.Values.Text = "Delete";
            this.DltTchUCBtn.Click += new System.EventHandler(this.DltTchUCBtn_Click);
            // 
            // DeleteTeacherUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DltTchUCBtn);
            this.Controls.Add(this.DgvTchRemove);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DeleteTeacherUC";
            this.Size = new System.Drawing.Size(1136, 785);
            this.Load += new System.EventHandler(this.DeleteTeacherUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTchRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvTchRemove;
        private ComponentFactory.Krypton.Toolkit.KryptonButton DltTchUCBtn;
    }
}
