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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void diaDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhMucDiaDiem dd = new FormDanhMucDiaDiem();
            dd.Show();
        }

        private void tourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhMucTour tour = new FormDanhMucTour();
            tour.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
