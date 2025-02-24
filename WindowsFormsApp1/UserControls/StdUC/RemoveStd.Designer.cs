namespace WindowsFormsApp1.UserControls.StdUC
{
    partial class RemoveStd
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
            this.DltStdUCBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DgvRemove = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // DltStdUCBtn
            // 
            this.DltStdUCBtn.Location = new System.Drawing.Point(737, 595);
            this.DltStdUCBtn.Name = "DltStdUCBtn";
            this.DltStdUCBtn.Size = new System.Drawing.Size(190, 58);
            this.DltStdUCBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DltStdUCBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DltStdUCBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.DltStdUCBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.DltStdUCBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DltStdUCBtn.StateCommon.Border.Rounding = 10;
            this.DltStdUCBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.DltStdUCBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.DltStdUCBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DltStdUCBtn.TabIndex = 0;
            this.DltStdUCBtn.Values.Text = "Delete";
            this.DltStdUCBtn.Click += new System.EventHandler(this.DltStdUCBtn_Click);
            // 
            // DgvRemove
            // 
            this.DgvRemove.BackgroundColor = System.Drawing.Color.White;
            this.DgvRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRemove.Location = new System.Drawing.Point(29, 91);
            this.DgvRemove.Name = "DgvRemove";
            this.DgvRemove.Size = new System.Drawing.Size(929, 473);
            this.DgvRemove.TabIndex = 2;
            this.DgvRemove.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRemove_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(67, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Remove Student";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RemoveStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvRemove);
            this.Controls.Add(this.DltStdUCBtn);
            this.Name = "RemoveStd";
            this.Size = new System.Drawing.Size(977, 695);
            this.Load += new System.EventHandler(this.RemoveStd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton DltStdUCBtn;
        private System.Windows.Forms.DataGridView DgvRemove;
        private System.Windows.Forms.Label label1;
    }
}
