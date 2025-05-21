namespace TourDuLich
{
    partial class FormTour
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ckTourTrongNuoc = new System.Windows.Forms.CheckBox();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.ckApDung = new System.Windows.Forms.CheckBox();
            this.txtGiaTour = new System.Windows.Forms.TextBox();
            this.txtTenGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaGia = new System.Windows.Forms.TextBox();
            this.gvGia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listDiaDiem = new System.Windows.Forms.ListBox();
            this.tabPageGia = new System.Windows.Forms.TabPage();
            this.dtTgkt = new System.Windows.Forms.DateTimePicker();
            this.dtTgbd = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listDDTour = new System.Windows.Forms.ListBox();
            this.tabGia = new System.Windows.Forms.TabControl();
            this.tabPageĐiaiem = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.cbLoaiTour = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgbd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apDung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvGia)).BeginInit();
            this.tabPageGia.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabGia.SuspendLayout();
            this.tabPageĐiaiem.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(572, 52);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 29);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(572, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 29);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(572, 89);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 29);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.Location = new System.Drawing.Point(0, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 30);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Loại";
            // 
            // ckTourTrongNuoc
            // 
            this.ckTourTrongNuoc.AutoSize = true;
            this.ckTourTrongNuoc.Location = new System.Drawing.Point(420, 61);
            this.ckTourTrongNuoc.Name = "ckTourTrongNuoc";
            this.ckTourTrongNuoc.Size = new System.Drawing.Size(134, 20);
            this.ckTourTrongNuoc.TabIndex = 4;
            this.ckTourTrongNuoc.Text = "Tour Trong Nước";
            this.ckTourTrongNuoc.UseVisualStyleBackColor = true;
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(128, 23);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(232, 23);
            this.txtMaTour.TabIndex = 1;
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(128, 59);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(232, 23);
            this.txtTenTour.TabIndex = 2;
            // 
            // ckApDung
            // 
            this.ckApDung.AutoSize = true;
            this.ckApDung.Location = new System.Drawing.Point(31, 91);
            this.ckApDung.Name = "ckApDung";
            this.ckApDung.Size = new System.Drawing.Size(117, 20);
            this.ckApDung.TabIndex = 8;
            this.ckApDung.Text = "Đang áp dụng";
            this.ckApDung.UseVisualStyleBackColor = true;
            // 
            // txtGiaTour
            // 
            this.txtGiaTour.Location = new System.Drawing.Point(329, 91);
            this.txtGiaTour.Name = "txtGiaTour";
            this.txtGiaTour.Size = new System.Drawing.Size(200, 23);
            this.txtGiaTour.TabIndex = 11;
            // 
            // txtTenGia
            // 
            this.txtTenGia.Location = new System.Drawing.Point(76, 56);
            this.txtTenGia.Name = "txtTenGia";
            this.txtTenGia.Size = new System.Drawing.Size(148, 23);
            this.txtTenGia.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên";
            // 
            // txtMaGia
            // 
            this.txtMaGia.Location = new System.Drawing.Point(76, 22);
            this.txtMaGia.Name = "txtMaGia";
            this.txtMaGia.Size = new System.Drawing.Size(148, 23);
            this.txtMaGia.TabIndex = 6;
            // 
            // gvGia
            // 
            this.gvGia.AllowUserToAddRows = false;
            this.gvGia.AllowUserToDeleteRows = false;
            this.gvGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGia,
            this.tenGia,
            this.giaTour,
            this.tgbd,
            this.tgkt,
            this.apDung});
            this.gvGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGia.Location = new System.Drawing.Point(0, 0);
            this.gvGia.Name = "gvGia";
            this.gvGia.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvGia.Size = new System.Drawing.Size(618, 344);
            this.gvGia.TabIndex = 15;
            this.gvGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvGia_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Tour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá tour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "TGKT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "TGBD";
            // 
            // listDiaDiem
            // 
            this.listDiaDiem.DisplayMember = "TenDD";
            this.listDiaDiem.FormattingEnabled = true;
            this.listDiaDiem.ItemHeight = 16;
            this.listDiaDiem.Location = new System.Drawing.Point(41, 60);
            this.listDiaDiem.Name = "listDiaDiem";
            this.listDiaDiem.Size = new System.Drawing.Size(223, 388);
            this.listDiaDiem.TabIndex = 0;
            // 
            // tabPageGia
            // 
            this.tabPageGia.Controls.Add(this.dtTgkt);
            this.tabPageGia.Controls.Add(this.dtTgbd);
            this.tabPageGia.Controls.Add(this.btnXoa);
            this.tabPageGia.Controls.Add(this.btnSua);
            this.tabPageGia.Controls.Add(this.btnThem);
            this.tabPageGia.Controls.Add(this.txtGiaTour);
            this.tabPageGia.Controls.Add(this.txtTenGia);
            this.tabPageGia.Controls.Add(this.txtMaGia);
            this.tabPageGia.Controls.Add(this.label6);
            this.tabPageGia.Controls.Add(this.label5);
            this.tabPageGia.Controls.Add(this.label8);
            this.tabPageGia.Controls.Add(this.label7);
            this.tabPageGia.Controls.Add(this.panel4);
            this.tabPageGia.Controls.Add(this.panel5);
            this.tabPageGia.Location = new System.Drawing.Point(4, 25);
            this.tabPageGia.Name = "tabPageGia";
            this.tabPageGia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGia.Size = new System.Drawing.Size(693, 512);
            this.tabPageGia.TabIndex = 0;
            this.tabPageGia.Text = "Giá";
            this.tabPageGia.UseVisualStyleBackColor = true;
            // 
            // dtTgkt
            // 
            this.dtTgkt.Location = new System.Drawing.Point(329, 56);
            this.dtTgkt.Name = "dtTgkt";
            this.dtTgkt.Size = new System.Drawing.Size(200, 23);
            this.dtTgkt.TabIndex = 10;
            // 
            // dtTgbd
            // 
            this.dtTgbd.Location = new System.Drawing.Point(329, 22);
            this.dtTgbd.Name = "dtTgbd";
            this.dtTgbd.Size = new System.Drawing.Size(200, 23);
            this.dtTgbd.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.ckApDung);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(693, 146);
            this.panel4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.gvGia);
            this.panel5.Location = new System.Drawing.Point(31, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(618, 344);
            this.panel5.TabIndex = 13;
            // 
            // listDDTour
            // 
            this.listDDTour.DisplayMember = "TenDD";
            this.listDDTour.FormattingEnabled = true;
            this.listDDTour.ItemHeight = 16;
            this.listDDTour.Location = new System.Drawing.Point(355, 60);
            this.listDDTour.Name = "listDDTour";
            this.listDDTour.Size = new System.Drawing.Size(223, 388);
            this.listDDTour.TabIndex = 1;
            // 
            // tabGia
            // 
            this.tabGia.Controls.Add(this.tabPageGia);
            this.tabGia.Controls.Add(this.tabPageĐiaiem);
            this.tabGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabGia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGia.Location = new System.Drawing.Point(0, 0);
            this.tabGia.Name = "tabGia";
            this.tabGia.SelectedIndex = 0;
            this.tabGia.Size = new System.Drawing.Size(701, 541);
            this.tabGia.TabIndex = 5;
            // 
            // tabPageĐiaiem
            // 
            this.tabPageĐiaiem.Controls.Add(this.button1);
            this.tabPageĐiaiem.Controls.Add(this.label10);
            this.tabPageĐiaiem.Controls.Add(this.label9);
            this.tabPageĐiaiem.Controls.Add(this.listDDTour);
            this.tabPageĐiaiem.Controls.Add(this.listDiaDiem);
            this.tabPageĐiaiem.Controls.Add(this.panel6);
            this.tabPageĐiaiem.Location = new System.Drawing.Point(4, 25);
            this.tabPageĐiaiem.Name = "tabPageĐiaiem";
            this.tabPageĐiaiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageĐiaiem.Size = new System.Drawing.Size(693, 512);
            this.tabPageĐiaiem.TabIndex = 1;
            this.tabPageĐiaiem.Text = "Địa điểm tham quan";
            this.tabPageĐiaiem.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(497, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Quản lý địa điểm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(352, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Địa điểm của Tour";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Danh sách địa điểm";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.btnPhai);
            this.panel6.Controls.Add(this.btnTrai);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Location = new System.Drawing.Point(41, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(608, 448);
            this.panel6.TabIndex = 8;
            // 
            // btnPhai
            // 
            this.btnPhai.BackgroundImage = global::TourDuLich.Properties.Resources.forward;
            this.btnPhai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPhai.Location = new System.Drawing.Point(243, 222);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(52, 29);
            this.btnPhai.TabIndex = 18;
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.BackgroundImage = global::TourDuLich.Properties.Resources.back;
            this.btnTrai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrai.Location = new System.Drawing.Point(243, 257);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(52, 29);
            this.btnTrai.TabIndex = 19;
            this.btnTrai.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::TourDuLich.Properties.Resources.up;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Location = new System.Drawing.Point(559, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 37);
            this.button5.TabIndex = 20;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::TourDuLich.Properties.Resources.down1;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Location = new System.Drawing.Point(559, 257);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 35);
            this.button6.TabIndex = 21;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDong
            // 
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDong.Location = new System.Drawing.Point(113, 0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(87, 30);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cbLoaiTour
            // 
            this.cbLoaiTour.FormattingEnabled = true;
            this.cbLoaiTour.Location = new System.Drawing.Point(478, 22);
            this.cbLoaiTour.Name = "cbLoaiTour";
            this.cbLoaiTour.Size = new System.Drawing.Size(240, 24);
            this.cbLoaiTour.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(34, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 93);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tabGia);
            this.panel2.Location = new System.Drawing.Point(34, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 547);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnDong);
            this.panel3.Location = new System.Drawing.Point(535, 661);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 30);
            this.panel3.TabIndex = 27;
            // 
            // maGia
            // 
            this.maGia.FillWeight = 70F;
            this.maGia.HeaderText = "Mã";
            this.maGia.Name = "maGia";
            this.maGia.ReadOnly = true;
            this.maGia.Width = 70;
            // 
            // tenGia
            // 
            this.tenGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenGia.HeaderText = "Tên";
            this.tenGia.Name = "tenGia";
            this.tenGia.ReadOnly = true;
            // 
            // giaTour
            // 
            this.giaTour.HeaderText = "Giá";
            this.giaTour.Name = "giaTour";
            this.giaTour.ReadOnly = true;
            // 
            // tgbd
            // 
            this.tgbd.DataPropertyName = "sThoiGianBatDau";
            this.tgbd.HeaderText = "TGBD";
            this.tgbd.Name = "tgbd";
            this.tgbd.ReadOnly = true;
            // 
            // tgkt
            // 
            this.tgkt.HeaderText = "TGKT";
            this.tgkt.Name = "tgkt";
            this.tgkt.ReadOnly = true;
            // 
            // apDung
            // 
            this.apDung.FillWeight = 90F;
            this.apDung.HeaderText = "Áp dụng";
            this.apDung.Name = "apDung";
            this.apDung.ReadOnly = true;
            this.apDung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.apDung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.apDung.Width = 90;
            // 
            // FormTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 701);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbLoaiTour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckTourTrongNuoc);
            this.Controls.Add(this.txtMaTour);
            this.Controls.Add(this.txtTenTour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FormTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tour";
            this.Load += new System.EventHandler(this.FormTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGia)).EndInit();
            this.tabPageGia.ResumeLayout(false);
            this.tabPageGia.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tabGia.ResumeLayout(false);
            this.tabPageĐiaiem.ResumeLayout(false);
            this.tabPageĐiaiem.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckTourTrongNuoc;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.CheckBox ckApDung;
        private System.Windows.Forms.TextBox txtGiaTour;
        private System.Windows.Forms.TextBox txtTenGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaGia;
        private System.Windows.Forms.DataGridView gvGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listDiaDiem;
        private System.Windows.Forms.TabPage tabPageGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listDDTour;
        private System.Windows.Forms.TabControl tabGia;
        private System.Windows.Forms.TabPage tabPageĐiaiem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cbLoaiTour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtTgkt;
        private System.Windows.Forms.DateTimePicker dtTgbd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgbd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgkt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn apDung;
    }
}