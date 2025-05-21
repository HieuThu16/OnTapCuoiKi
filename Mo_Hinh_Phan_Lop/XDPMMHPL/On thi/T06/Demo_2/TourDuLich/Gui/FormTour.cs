using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TourDuLich.Bll;
using TourDuLich.Dal;

namespace TourDuLich
{
    public partial class FormTour : Form
    {
        BizTour tour;

        public FormTour()
        {
            InitializeComponent();

            tour = new BizTour(-1);
        }

        public FormTour(BizTour _tour)
        {
            InitializeComponent();

            tour = _tour;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDanhMucDiaDiem dd = new FormDanhMucDiaDiem();
            dd.Show();
        }

        private void FormTour_Load(object sender, EventArgs e)
        {
            listDiaDiem.DataSource = DalDiaDiem.GetAllDiaDiem(); ;
            listDiaDiem.DisplayMember = "TenDD";

            if (tour.Id != -1)
            {
                txtTenTour.Text = tour.TenTour;

                //giá
                gvGia.AutoGenerateColumns = false;
                gvGia.DataSource = tour.Gias;

                gvGia.Columns["giaTour"].DataPropertyName = "GiaTri";

                //đđ
                listDDTour.DataSource = tour.DiaDiems;
                listDDTour.DisplayMember = "TenDD";
            }
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            BizDiaDiem dd = (BizDiaDiem)listDiaDiem.SelectedItem;

            tour.DiaDiems.Add(dd);

            listDDTour.DataSource = null;
            listDDTour.DataSource = tour.DiaDiems;
            listDDTour.DisplayMember = "TenDD";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listDDTour.SelectedIndex < tour.DiaDiems.Count - 1)
            {
                BizDiaDiem tmp = tour.DiaDiems[listDDTour.SelectedIndex];
                tour.DiaDiems[listDDTour.SelectedIndex] = tour.DiaDiems[listDDTour.SelectedIndex + 1];
                tour.DiaDiems[listDDTour.SelectedIndex + 1] = tmp;

                listDDTour.DataSource = null;
                listDDTour.DataSource = tour.DiaDiems;
                listDDTour.DisplayMember = "TenDD";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tour.Save();
        }

        private void gvGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BizGiaTour gia = tour.Gias[e.RowIndex];

            txtGiaTour.Text = gia.GiaTri;
            dtTgbd.Value = gia.ThoiGianBatDau;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BizGiaTour gia = (BizGiaTour)gvGia.SelectedRows[0].DataBoundItem;

            gia.GiaTri = txtGiaTour.Text;

            gvGia.DataSource = null;
            gvGia.DataSource = tour.Gias;
        }
    }
}
