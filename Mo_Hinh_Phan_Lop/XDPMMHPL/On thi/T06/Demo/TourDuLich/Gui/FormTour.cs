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
            listDiaDiem.DataSource = DalDiaDiem.GetAllDiaDiem();
            listDiaDiem.DisplayMember = "TenDD";

            if (tour.Id != -1)
            {
                txtTenTour.Text = tour.TenTour;

                // load giá
                gvGia.AutoGenerateColumns = false;
                gvGia.DataSource = tour.Gias;
                loadGia(tour.Gias[0]);

                // load đđ
                listDDTour.DataSource = tour.DiaDiems;
                listDDTour.DisplayMember = "TenDD";
                
            }
        }

        private void loadGia(BizGiaTour gia)
        {
            dtTgbd.Value = gia.ThoiGianBatDau;

            txtGiaTour.Text = gia.GiaTri;
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            BizDiaDiem dd = (BizDiaDiem)listDiaDiem.SelectedItem;

            tour.DiaDiems.Add(dd);

            listDDTour.DataSource = null;
            listDDTour.DataSource = tour.DiaDiems;
            listDDTour.DisplayMember = "TenDD";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listDDTour.SelectedIndex > 0)
            {
                BizDiaDiem tmp = tour.DiaDiems[listDDTour.SelectedIndex];
                tour.DiaDiems[listDDTour.SelectedIndex] = tour.DiaDiems[listDDTour.SelectedIndex-1];
                tour.DiaDiems[listDDTour.SelectedIndex-1] = tmp;

                listDDTour.DataSource = null;
                listDDTour.DataSource = tour.DiaDiems;
                listDDTour.DisplayMember = "TenDD";
            }
            
        }

        private void gvGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BizGiaTour gia = tour.Gias[e.RowIndex];

            loadGia(gia);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gvGia.SelectedRows.Count > 0)
            {
                BizGiaTour gia = tour.Gias[gvGia.SelectedRows[0].Index];

                gia.GiaTri = txtGiaTour.Text;

                gvGia.DataSource = null;
                gvGia.DataSource = tour.Gias;
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tour.Save();
        }
    }
}
