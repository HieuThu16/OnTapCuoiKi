using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TourDuLich
{
    public partial class FormTour : Form
    {
        public FormTour()
        {
            InitializeComponent();
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
    }
}
