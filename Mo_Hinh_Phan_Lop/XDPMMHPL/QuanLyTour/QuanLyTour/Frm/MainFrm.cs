using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTour.Frm;

namespace QuanLyTour
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnDiaDiem_Click(object sender, EventArgs e)
        {
            DiaDiemFrm diadiem = new DiaDiemFrm();
            diadiem.ShowDialog();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            TourFrm tour = new TourFrm();
            tour.ShowDialog();
        }
    }
}
