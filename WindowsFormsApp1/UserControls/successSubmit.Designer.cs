namespace WindowsFormsApp1.UserControls
{
    partial class successSubmit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(successSubmit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.examSubmittedlbl = new System.Windows.Forms.Label();
            this.examsubmittedlbl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(278, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 519);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // examSubmittedlbl
            // 
            this.examSubmittedlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.examSubmittedlbl.AutoSize = true;
            this.examSubmittedlbl.Font = new System.Drawing.Font("JetBrains Mono", 15.78182F, System.Drawing.FontStyle.Bold);
            this.examSubmittedlbl.ForeColor = System.Drawing.Color.Black;
            this.examSubmittedlbl.Location = new System.Drawing.Point(537, 603);
            this.examSubmittedlbl.Name = "examSubmittedlbl";
            this.examSubmittedlbl.Size = new System.Drawing.Size(434, 32);
            this.examSubmittedlbl.TabIndex = 19;
            this.examSubmittedlbl.Text = "Exam Submitted Successfully!\r\n";
            // 
            // examsubmittedlbl2
            // 
            this.examsubmittedlbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.examsubmittedlbl2.AutoSize = true;
            this.examsubmittedlbl2.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examsubmittedlbl2.ForeColor = System.Drawing.Color.Black;
            this.examsubmittedlbl2.Location = new System.Drawing.Point(361, 635);
            this.examsubmittedlbl2.Name = "examsubmittedlbl2";
            this.examsubmittedlbl2.Size = new System.Drawing.Size(857, 23);
            this.examsubmittedlbl2.TabIndex = 20;
            this.examsubmittedlbl2.Text = "Your answers have been recorded. Great job! You\'ll receive your results soon.\r\n";
            // 
            // successSubmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.examsubmittedlbl2);
            this.Controls.Add(this.examSubmittedlbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "successSubmit";
            this.Size = new System.Drawing.Size(1444, 768);
            this.Load += new System.EventHandler(this.successSubmit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label examSubmittedlbl;
        private System.Windows.Forms.Label examsubmittedlbl2;
    }
}
