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
    public partial class FormDanhMucTour : Form
    {
        List<BizTour> tours;

        public FormDanhMucTour()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormTour tour = new FormTour();
            tour.Show();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhMucTour_Load(object sender, EventArgs e)
        {
            tours = DalTour.GetAll();

            gvTour.AutoGenerateColumns = false;
            gvTour.DataSource = tours;
        }

        private void gvTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gvTour.Columns["sua"].Index)
            {
                BizTour tour = tours[e.RowIndex];

                FormTour frm = new FormTour(tour);
                frm.Show();
            }
            if (e.ColumnIndex == gvTour.Columns["xoa"].Index)
            {
                BizTour tour = tours[e.RowIndex];
                if (MessageBox.Show("Chắc không?", "Hỏi", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    tour.Delete();
                }
            }
        }
    }
}
