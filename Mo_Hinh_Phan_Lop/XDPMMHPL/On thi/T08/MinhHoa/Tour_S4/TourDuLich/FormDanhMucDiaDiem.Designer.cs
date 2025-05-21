namespace TourDuLich
{
    partial class FormDanhMucDiaDiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cbDiaPhuong = new System.Windows.Forms.ComboBox();
            this.txtTenDD = new System.Windows.Forms.TextBox();
            this.txtMaDD = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gvDiaDiem = new System.Windows.Forms.DataGridView();
            this.maDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaPhuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiaDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Địa phương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã";
            // 
            // btnDong
            // 
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDong.Location = new System.Drawing.Point(112, 0);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(88, 29);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.Location = new System.Drawing.Point(0, 0);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 29);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbDiaPhuong
            // 
            this.cbDiaPhuong.FormattingEnabled = true;
            this.cbDiaPhuong.Location = new System.Drawing.Point(142, 97);
            this.cbDiaPhuong.Margin = new System.Windows.Forms.Padding(4);
            this.cbDiaPhuong.Name = "cbDiaPhuong";
            this.cbDiaPhuong.Size = new System.Drawing.Size(214, 24);
            this.cbDiaPhuong.TabIndex = 3;
            // 
            // txtTenDD
            // 
            this.txtTenDD.Location = new System.Drawing.Point(142, 59);
            this.txtTenDD.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDD.Name = "txtTenDD";
            this.txtTenDD.Size = new System.Drawing.Size(214, 23);
            this.txtTenDD.TabIndex = 2;
            // 
            // txtMaDD
            // 
            this.txtMaDD.Location = new System.Drawing.Point(142, 22);
            this.txtMaDD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDD.Name = "txtMaDD";
            this.txtMaDD.Size = new System.Drawing.Size(214, 23);
            this.txtMaDD.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(393, 54);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 28);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(393, 92);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 28);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(393, 17);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 28);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaDD);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTenDD);
            this.panel1.Controls.Add(this.cbDiaPhuong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 147);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Location = new System.Drawing.Point(420, 642);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 29);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gvDiaDiem);
            this.panel3.Location = new System.Drawing.Point(41, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 483);
            this.panel3.TabIndex = 21;
            // 
            // gvDiaDiem
            // 
            this.gvDiaDiem.AllowUserToAddRows = false;
            this.gvDiaDiem.AllowUserToDeleteRows = false;
            this.gvDiaDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDiaDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDiaDiem,
            this.tenDiaDiem,
            this.diaPhuong});
            this.gvDiaDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDiaDiem.Location = new System.Drawing.Point(0, 0);
            this.gvDiaDiem.Margin = new System.Windows.Forms.Padding(4);
            this.gvDiaDiem.Name = "gvDiaDiem";
            this.gvDiaDiem.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDiaDiem.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvDiaDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDiaDiem.Size = new System.Drawing.Size(579, 483);
            this.gvDiaDiem.TabIndex = 7;
            this.gvDiaDiem.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvDiaDiem_CellMouseUp);
            // 
            // maDiaDiem
            // 
            this.maDiaDiem.DataPropertyName = "MaDD";
            this.maDiaDiem.HeaderText = "Mã";
            this.maDiaDiem.Name = "maDiaDiem";
            this.maDiaDiem.ReadOnly = true;
            // 
            // tenDiaDiem
            // 
            this.tenDiaDiem.DataPropertyName = "TenDD";
            this.tenDiaDiem.HeaderText = "Tên";
            this.tenDiaDiem.Name = "tenDiaDiem";
            this.tenDiaDiem.ReadOnly = true;
            this.tenDiaDiem.Width = 200;
            // 
            // diaPhuong
            // 
            this.diaPhuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaPhuong.HeaderText = "Địa Phương";
            this.diaPhuong.Name = "diaPhuong";
            this.diaPhuong.ReadOnly = true;
            // 
            // FormDanhMucDiaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 701);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormDanhMucDiaDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Địa Điểm";
            this.Load += new System.EventHandler(this.FormDanhMucDiaDiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDiaDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cbDiaPhuong;
        private System.Windows.Forms.TextBox txtTenDD;
        private System.Windows.Forms.TextBox txtMaDD;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gvDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaPhuong;
    }
}

