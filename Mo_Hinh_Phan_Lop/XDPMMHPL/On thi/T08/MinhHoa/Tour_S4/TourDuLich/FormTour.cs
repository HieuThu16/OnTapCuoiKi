using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TourDuLich.Biz;
using TourDuLich.Dal;

namespace TourDuLich
{
    public partial class FormTour : Form
    {
        BizTour tour;

        public FormTour()
        {
            InitializeComponent();

            //tour = new BizTour(-1);
        }

        public FormTour(BizTour _tour) : this()
        {
            tour = _tour;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDanhMucDiaDiem formDd = new FormDanhMucDiaDiem();
            formDd.ShowDialog();

            // địa điểm
            List<BizDiaDiem> diaDiems = BizDiaDiem.GetAll();
            int i = 0;
            while (i < diaDiems.Count)
            {
                BizDiaDiem dd = diaDiems[i];
                if (tour.DiaDiems.Contains(dd, new DiaDiemComparer()))
                    diaDiems.Remove(dd);
                else
                    i++;
            }

            listDiaDiem.DataSource = null;
            listDiaDiem.DataSource = diaDiems;
            listDiaDiem.DisplayMember = "TenDd";
            listDiaDiem.ValueMember = "Id";

            //listDDTour.DataSource = null;
            //listDDTour.DataSource = tour.DiaDiems;
            //listDDTour.DisplayMember = "TenDd";
            //listDDTour.ValueMember = "Id";            
        }

        private void FormTour_Load(object sender, EventArgs e)
        {
            cbLoaiTour.DataSource = DalTour.GetAllLoaiTour();
            cbLoaiTour.DisplayMember = "TenLoai";
            cbLoaiTour.ValueMember = "Id";

            DisplayGeneralTourInfo();

            // giá
            gvGia.AutoGenerateColumns = false;
            gvGia.DataSource = tour.Gias;

            // địa điểm
            List<BizDiaDiem> diaDiems = BizDiaDiem.GetAll();
            int i = 0;
            while (i < diaDiems.Count)
            {
                BizDiaDiem dd = diaDiems[i];
                if (tour.DiaDiems.Contains(dd, new DiaDiemComparer()))
                    diaDiems.Remove(dd);
                else
                    i++;
            }                
            
            listDiaDiem.DataSource = diaDiems;
            
            listDDTour.DataSource = tour.DiaDiems;
        }

        private void DisplayGeneralTourInfo()
        {
            txtMaTour.Text = tour.MaTour;
            txtTenTour.Text = tour.TenTour;
            ckTourTrongNuoc.Checked = tour.LaTourTrongNuoc;

            //List<BizLoaiTour> loaiTours = (List<BizLoaiTour>) cbLoaiTour.DataSource;
            cbLoaiTour.Text = tour.TenLoaiTour;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Decimal tmp;
            if (Decimal.TryParse(txtGiaTour.Text, out tmp))
            {
                BizGiaTour giaTour = new BizGiaTour(-1, ckApDung.Checked,
                    tmp, dtTgbd.Value,
                    dtTgkt.Value, tour);
                tour.Gias.Add(giaTour);

                tour.CapNhatGiaDangApDung(giaTour);

                gvGia.DataSource = null;
                gvGia.DataSource = tour.Gias;
            }            
        }

        private void gvGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BizGiaTour giaTour = (BizGiaTour)tour.Gias[e.RowIndex];
            ckApDung.Checked = giaTour.DangApDung;
            txtGiaTour.Text = giaTour.GiaTri.ToString();
            dtTgbd.Value = giaTour.ThoiGianBatDau;
            dtTgkt.Value = giaTour.ThoiGianKetThuc;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gvGia.SelectedRows.Count > 0)
            {
                BizGiaTour giaTour = (BizGiaTour)gvGia.SelectedRows[0].DataBoundItem;
                giaTour.DangApDung = ckApDung.Checked;
                giaTour.GiaTri = txtGiaTour.Text;
                giaTour.ThoiGianBatDau = dtTgbd.Value;
                giaTour.ThoiGianKetThuc = dtTgkt.Value;
                giaTour.Updated = true;

                tour.CapNhatGiaDangApDung(giaTour);                

                gvGia.DataSource = null;
                gvGia.DataSource = tour.Gias;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gvGia.SelectedRows)
            {
                BizGiaTour giaTour = (BizGiaTour)row.DataBoundItem;
                tour.Gias.Remove(giaTour);

                gvGia.DataSource = null;
                gvGia.DataSource = tour.Gias;
            }
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            List<BizDiaDiem> diaDiems = (List<BizDiaDiem>)listDiaDiem.DataSource;
            List<BizDiaDiem> diaDiemsTour = (List<BizDiaDiem>)listDDTour.DataSource;
            diaDiemsTour.Add((BizDiaDiem)listDiaDiem.SelectedItem);
            diaDiems.Remove((BizDiaDiem)listDiaDiem.SelectedItem);

            listDiaDiem.DataSource = null;
            listDiaDiem.DataSource = diaDiems;
            listDiaDiem.DisplayMember = "TenDd";
            listDiaDiem.ValueMember = "Id";

            listDDTour.DataSource = null;
            listDDTour.DataSource = diaDiemsTour;
            listDDTour.DisplayMember = "TenDd";
            listDDTour.ValueMember = "Id";            
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            List<BizDiaDiem> diaDiems = (List<BizDiaDiem>)listDiaDiem.DataSource;
            List<BizDiaDiem> diaDiemsTour = (List<BizDiaDiem>)listDDTour.DataSource;
            diaDiems.Add((BizDiaDiem)listDDTour.SelectedItem);
            diaDiemsTour.Remove((BizDiaDiem)listDDTour.SelectedItem);

            listDiaDiem.DataSource = null;
            listDiaDiem.DataSource = diaDiems;
            listDiaDiem.DisplayMember = "TenDd";
            listDiaDiem.ValueMember = "Id";

            listDDTour.DataSource = null;
            listDDTour.DataSource = diaDiemsTour;
            listDDTour.DisplayMember = "TenDd";
            listDDTour.ValueMember = "Id";   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<BizDiaDiem> diaDiemsTour = (List<BizDiaDiem>)listDDTour.DataSource;
            if (listDDTour.SelectedIndex > 0)
            {
                BizDiaDiem tmp = diaDiemsTour[listDDTour.SelectedIndex];
                diaDiemsTour[listDDTour.SelectedIndex] = diaDiemsTour[listDDTour.SelectedIndex - 1];
                diaDiemsTour[listDDTour.SelectedIndex - 1] = tmp;

                listDDTour.DataSource = null;
                listDDTour.DataSource = diaDiemsTour;
                listDDTour.DisplayMember = "TenDd";
                listDDTour.ValueMember = "Id";   
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<BizDiaDiem> diaDiemsTour = (List<BizDiaDiem>)listDDTour.DataSource;
            if (listDDTour.SelectedIndex < diaDiemsTour.Count - 1)
            {
                BizDiaDiem tmp = diaDiemsTour[listDDTour.SelectedIndex];
                diaDiemsTour[listDDTour.SelectedIndex] = diaDiemsTour[listDDTour.SelectedIndex + 1];
                diaDiemsTour[listDDTour.SelectedIndex + 1] = tmp;

                listDDTour.DataSource = null;
                listDDTour.DataSource = diaDiemsTour;
                listDDTour.DisplayMember = "TenDd";
                listDDTour.ValueMember = "Id";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tour.MaTour = txtMaTour.Text;
            tour.TenTour = txtTenTour.Text;
            tour.LoaiTour = (BizLoaiTour)cbLoaiTour.SelectedItem;
            tour.LaTourTrongNuoc = ckTourTrongNuoc.Checked;

            tour.Save();
        }
    }
}
