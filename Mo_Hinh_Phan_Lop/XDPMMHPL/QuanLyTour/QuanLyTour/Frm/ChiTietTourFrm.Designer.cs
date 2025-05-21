namespace QuanLyTour.Frm
{
    partial class ChiTietTourFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioNN = new System.Windows.Forms.RadioButton();
            this.radioTN = new System.Windows.Forms.RadioButton();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGia = new System.Windows.Forms.TabPage();
            this.btnThemGiaTour = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.txtMaGia = new System.Windows.Forms.TextBox();
            this.btnRS = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.chkDangAP = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.listGiaTour = new System.Windows.Forms.ListView();
            this.tabDiaDiem = new System.Windows.Forms.TabPage();
            this.btnLuuTour = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listAllDD = new System.Windows.Forms.ListBox();
            this.listDSDD = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnThemDiaDiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGia.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabDiaDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tour";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioNN);
            this.groupBox1.Controls.Add(this.radioTN);
            this.groupBox1.Location = new System.Drawing.Point(16, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại tour";
            // 
            // radioNN
            // 
            this.radioNN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioNN.AutoSize = true;
            this.radioNN.Location = new System.Drawing.Point(149, 22);
            this.radioNN.Name = "radioNN";
            this.radioNN.Size = new System.Drawing.Size(104, 18);
            this.radioNN.TabIndex = 1;
            this.radioNN.Text = "Tour ngoài nước";
            this.radioNN.UseVisualStyleBackColor = true;
            // 
            // radioTN
            // 
            this.radioTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioTN.AutoSize = true;
            this.radioTN.Checked = true;
            this.radioTN.Location = new System.Drawing.Point(6, 22);
            this.radioTN.Name = "radioTN";
            this.radioTN.Size = new System.Drawing.Size(103, 18);
            this.radioTN.TabIndex = 0;
            this.radioTN.TabStop = true;
            this.radioTN.Text = "Tour trong nước";
            this.radioTN.UseVisualStyleBackColor = true;
            // 
            // txtMa
            // 
            this.txtMa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMa.Location = new System.Drawing.Point(63, 13);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(567, 20);
            this.txtMa.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(63, 39);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(567, 20);
            this.txtTen.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabGia);
            this.tabControl1.Controls.Add(this.tabDiaDiem);
            this.tabControl1.Location = new System.Drawing.Point(16, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(615, 330);
            this.tabControl1.TabIndex = 5;
            // 
            // tabGia
            // 
            this.tabGia.Controls.Add(this.btnThemGiaTour);
            this.tabGia.Controls.Add(this.groupBox2);
            this.tabGia.Controls.Add(this.btnXoa);
            this.tabGia.Controls.Add(this.btnSua);
            this.tabGia.Controls.Add(this.listGiaTour);
            this.tabGia.Location = new System.Drawing.Point(4, 22);
            this.tabGia.Name = "tabGia";
            this.tabGia.Padding = new System.Windows.Forms.Padding(3);
            this.tabGia.Size = new System.Drawing.Size(607, 304);
            this.tabGia.TabIndex = 0;
            this.tabGia.Text = "Giá tour";
            this.tabGia.UseVisualStyleBackColor = true;
            // 
            // btnThemGiaTour
            // 
            this.btnThemGiaTour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemGiaTour.Location = new System.Drawing.Point(479, 6);
            this.btnThemGiaTour.Name = "btnThemGiaTour";
            this.btnThemGiaTour.Size = new System.Drawing.Size(122, 27);
            this.btnThemGiaTour.TabIndex = 5;
            this.btnThemGiaTour.Text = "Thêm giá tour";
            this.btnThemGiaTour.UseVisualStyleBackColor = true;
            this.btnThemGiaTour.Click += new System.EventHandler(this.btnThemGiaTour_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.date2);
            this.groupBox2.Controls.Add(this.date1);
            this.groupBox2.Controls.Add(this.txtGiaTri);
            this.groupBox2.Controls.Add(this.txtMaGia);
            this.groupBox2.Controls.Add(this.btnRS);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.chkDangAP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(7, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 166);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết giá tour";
            // 
            // date2
            // 
            this.date2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(322, 71);
            this.date2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(102, 20);
            this.date2.TabIndex = 29;
            this.date2.ValueChanged += new System.EventHandler(this.date2_ValueChanged);
            // 
            // date1
            // 
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(117, 70);
            this.date1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(114, 20);
            this.date1.TabIndex = 28;
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaTri.Location = new System.Drawing.Point(117, 45);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(307, 20);
            this.txtGiaTri.TabIndex = 27;
            // 
            // txtMaGia
            // 
            this.txtMaGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaGia.Location = new System.Drawing.Point(117, 19);
            this.txtMaGia.Name = "txtMaGia";
            this.txtMaGia.Size = new System.Drawing.Size(307, 20);
            this.txtMaGia.TabIndex = 25;
            // 
            // btnRS
            // 
            this.btnRS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRS.Location = new System.Drawing.Point(241, 127);
            this.btnRS.Name = "btnRS";
            this.btnRS.Size = new System.Drawing.Size(123, 24);
            this.btnRS.TabIndex = 24;
            this.btnRS.Text = "Reset";
            this.btnRS.UseVisualStyleBackColor = true;
            this.btnRS.Click += new System.EventHandler(this.btnRS_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(94, 127);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 24);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu vào danh sách";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuuVaoDS_Click);
            // 
            // chkDangAP
            // 
            this.chkDangAP.AutoSize = true;
            this.chkDangAP.Location = new System.Drawing.Point(37, 98);
            this.chkDangAP.Name = "chkDangAP";
            this.chkDangAP.Size = new System.Drawing.Size(127, 18);
            this.chkDangAP.TabIndex = 22;
            this.chkDangAP.Text = "Áp dụng giá tour này";
            this.chkDangAP.UseVisualStyleBackColor = true;
            this.chkDangAP.CheckedChanged += new System.EventHandler(this.chkDangAP_CheckedChanged);
            this.chkDangAP.Click += new System.EventHandler(this.chkDangAP_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 14);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "Giá trị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã giá tour";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(479, 72);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 27);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa khỏi danh sách";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(479, 39);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 27);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa giá tour";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // listGiaTour
            // 
            this.listGiaTour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listGiaTour.FullRowSelect = true;
            this.listGiaTour.GridLines = true;
            this.listGiaTour.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listGiaTour.Location = new System.Drawing.Point(3, 6);
            this.listGiaTour.MultiSelect = false;
            this.listGiaTour.Name = "listGiaTour";
            this.listGiaTour.Size = new System.Drawing.Size(470, 112);
            this.listGiaTour.TabIndex = 0;
            this.listGiaTour.UseCompatibleStateImageBehavior = false;
            this.listGiaTour.SelectedIndexChanged += new System.EventHandler(this.listGiaTour_SelectedIndexChanged);
            this.listGiaTour.Click += new System.EventHandler(this.listGiaTour_Click);
            // 
            // tabDiaDiem
            // 
            this.tabDiaDiem.Controls.Add(this.btnThemDiaDiem);
            this.tabDiaDiem.Controls.Add(this.button4);
            this.tabDiaDiem.Controls.Add(this.button3);
            this.tabDiaDiem.Controls.Add(this.button2);
            this.tabDiaDiem.Controls.Add(this.button1);
            this.tabDiaDiem.Controls.Add(this.label8);
            this.tabDiaDiem.Controls.Add(this.label4);
            this.tabDiaDiem.Controls.Add(this.listDSDD);
            this.tabDiaDiem.Controls.Add(this.listAllDD);
            this.tabDiaDiem.Location = new System.Drawing.Point(4, 22);
            this.tabDiaDiem.Name = "tabDiaDiem";
            this.tabDiaDiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiaDiem.Size = new System.Drawing.Size(607, 304);
            this.tabDiaDiem.TabIndex = 1;
            this.tabDiaDiem.Text = "Địa điểm";
            this.tabDiaDiem.UseVisualStyleBackColor = true;
            // 
            // btnLuuTour
            // 
            this.btnLuuTour.Location = new System.Drawing.Point(184, 471);
            this.btnLuuTour.Name = "btnLuuTour";
            this.btnLuuTour.Size = new System.Drawing.Size(109, 27);
            this.btnLuuTour.TabIndex = 6;
            this.btnLuuTour.Text = "Lưu tour";
            this.btnLuuTour.UseVisualStyleBackColor = true;
            this.btnLuuTour.Click += new System.EventHandler(this.btnLuuTour_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(362, 471);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 27);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listAllDD
            // 
            this.listAllDD.FormattingEnabled = true;
            this.listAllDD.ItemHeight = 14;
            this.listAllDD.Location = new System.Drawing.Point(60, 32);
            this.listAllDD.Name = "listAllDD";
            this.listAllDD.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listAllDD.Size = new System.Drawing.Size(147, 228);
            this.listAllDD.TabIndex = 0;
            // 
            // listDSDD
            // 
            this.listDSDD.FormattingEnabled = true;
            this.listDSDD.ItemHeight = 14;
            this.listDSDD.Location = new System.Drawing.Point(403, 32);
            this.listDSDD.Name = "listDSDD";
            this.listDSDD.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listDSDD.Size = new System.Drawing.Size(147, 228);
            this.listDSDD.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Danh sách địa điểm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 14);
            this.label8.TabIndex = 3;
            this.label8.Text = "Điểm tham quan của tour";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Lên";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(269, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Xuống";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnThemDiaDiem
            // 
            this.btnThemDiaDiem.Location = new System.Drawing.Point(86, 266);
            this.btnThemDiaDiem.Name = "btnThemDiaDiem";
            this.btnThemDiaDiem.Size = new System.Drawing.Size(100, 23);
            this.btnThemDiaDiem.TabIndex = 8;
            this.btnThemDiaDiem.Text = "Thêm địa điểm mới";
            this.btnThemDiaDiem.UseVisualStyleBackColor = true;
            this.btnThemDiaDiem.Click += new System.EventHandler(this.btnThemDiaDiem_Click);
            // 
            // ChiTietTourFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 514);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLuuTour);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietTourFrm";
            this.Text = "Hệ thống quản lý tour - Chi tiết tour";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabGia.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabDiaDiem.ResumeLayout(false);
            this.tabDiaDiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioNN;
        private System.Windows.Forms.RadioButton radioTN;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGia;
        private System.Windows.Forms.ListView listGiaTour;
        private System.Windows.Forms.TabPage tabDiaDiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.TextBox txtMaGia;
        private System.Windows.Forms.Button btnRS;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.CheckBox chkDangAP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuuTour;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnThemGiaTour;
        private System.Windows.Forms.ListBox listDSDD;
        private System.Windows.Forms.ListBox listAllDD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThemDiaDiem;
    }
}