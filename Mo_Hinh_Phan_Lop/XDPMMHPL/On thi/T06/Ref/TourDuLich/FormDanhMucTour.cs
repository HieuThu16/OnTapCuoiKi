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
    public partial class FormDanhMucTour : Form
    {
        List<BizTour> tours = new List<BizTour>();

        public FormDanhMucTour()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BizTour newTour = new BizTour(-1);
            FormTour tour = new FormTour(newTour);
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
            if (e.ColumnIndex == gvTour.Columns["xoa"].Index)
            {
                BizTour tour = tours[e.RowIndex];
                if (DialogResult.Yes == MessageBox.Show("Bạn chắc chứ", "Hỏi", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        tour.Delete();                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không xóa được: " + ex.Message , "Lỗi");
                    }

                    tours.Remove(tour);
                    gvTour.DataSource = null;
                    gvTour.DataSource = tours;
                }                                   
            }
            else if (e.ColumnIndex == gvTour.Columns["sua"].Index)
            {
                BizTour tour = tours[e.RowIndex];                
                FormTour frmTour = new FormTour(tour);
                frmTour.Show();
            }
        }
    }
}
