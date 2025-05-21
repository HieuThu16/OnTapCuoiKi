namespace QuanLyTour
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiaDiem = new System.Windows.Forms.Button();
            this.btnTour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý tour Nhóm Kim Thao Luật";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDiaDiem
            // 
            this.btnDiaDiem.Location = new System.Drawing.Point(46, 102);
            this.btnDiaDiem.Name = "btnDiaDiem";
            this.btnDiaDiem.Size = new System.Drawing.Size(101, 23);
            this.btnDiaDiem.TabIndex = 1;
            this.btnDiaDiem.Text = "Quản lý địa điểm";
            this.btnDiaDiem.UseVisualStyleBackColor = true;
            this.btnDiaDiem.Click += new System.EventHandler(this.btnDiaDiem_Click);
            // 
            // btnTour
            // 
            this.btnTour.Location = new System.Drawing.Point(185, 102);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(103, 23);
            this.btnTour.TabIndex = 2;
            this.btnTour.Text = "Quản lý tour";
            this.btnTour.UseVisualStyleBackColor = true;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 263);
            this.Controls.Add(this.btnTour);
            this.Controls.Add(this.btnDiaDiem);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Quản lý tour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiaDiem;
        private System.Windows.Forms.Button btnTour;
    }
}

