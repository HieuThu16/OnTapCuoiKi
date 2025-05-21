namespace TourDuLich
{
    partial class FormDanhMucTour
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvTour = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourTN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.giaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sua = new System.Windows.Forms.DataGridViewLinkColumn();
            this.xoa = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTour)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 34);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDong.Location = new System.Drawing.Point(126, 0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 34);
            this.btnDong.TabIndex = 26;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gvTour);
            this.panel1.Location = new System.Drawing.Point(27, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 618);
            this.panel1.TabIndex = 27;
            // 
            // gvTour
            // 
            this.gvTour.AllowUserToAddRows = false;
            this.gvTour.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTour,
            this.tenTour,
            this.loaiTour,
            this.tourTN,
            this.giaTour,
            this.sua,
            this.xoa});
            this.gvTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTour.Location = new System.Drawing.Point(0, 0);
            this.gvTour.Margin = new System.Windows.Forms.Padding(5);
            this.gvTour.Name = "gvTour";
            this.gvTour.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTour.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvTour.Size = new System.Drawing.Size(605, 618);
            this.gvTour.TabIndex = 18;
            this.gvTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTour_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Location = new System.Drawing.Point(417, 655);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 34);
            this.panel2.TabIndex = 28;
            // 
            // maTour
            // 
            this.maTour.FillWeight = 60F;
            this.maTour.HeaderText = "Mã";
            this.maTour.Name = "maTour";
            this.maTour.ReadOnly = true;
            this.maTour.Width = 60;
            // 
            // tenTour
            // 
            this.tenTour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenTour.DataPropertyName = "TenTour";
            this.tenTour.HeaderText = "Tên";
            this.tenTour.Name = "tenTour";
            this.tenTour.ReadOnly = true;
            // 
            // loaiTour
            // 
            this.loaiTour.DataPropertyName = "LoaiTour.TenLoai";
            this.loaiTour.HeaderText = "Loại";
            this.loaiTour.Name = "loaiTour";
            this.loaiTour.ReadOnly = true;
            // 
            // tourTN
            // 
            this.tourTN.HeaderText = "Tour TN";
            this.tourTN.Name = "tourTN";
            this.tourTN.ReadOnly = true;
            this.tourTN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tourTN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tourTN.Width = 85;
            // 
            // giaTour
            // 
            this.giaTour.DataPropertyName = "GiaDangApDung";
            this.giaTour.HeaderText = "Giá";
            this.giaTour.Name = "giaTour";
            this.giaTour.ReadOnly = true;
            // 
            // sua
            // 
            this.sua.FillWeight = 60F;
            this.sua.HeaderText = "Sửa";
            this.sua.Name = "sua";
            this.sua.ReadOnly = true;
            this.sua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sua.Text = "Sửa";
            this.sua.UseColumnTextForLinkValue = true;
            this.sua.Width = 60;
            // 
            // xoa
            // 
            this.xoa.FillWeight = 60F;
            this.xoa.HeaderText = "Xóa";
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xoa.Text = "Xóa";
            this.xoa.UseColumnTextForLinkValue = true;
            this.xoa.Width = 60;
            // 
            // FormDanhMucTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDanhMucTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Tour";
            this.Load += new System.EventHandler(this.FormDanhMucTour_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTour)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvTour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiTour;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tourTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTour;
        private System.Windows.Forms.DataGridViewLinkColumn sua;
        private System.Windows.Forms.DataGridViewLinkColumn xoa;
    }
}