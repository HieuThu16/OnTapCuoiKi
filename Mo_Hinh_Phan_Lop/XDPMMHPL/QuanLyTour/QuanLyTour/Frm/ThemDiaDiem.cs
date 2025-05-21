using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTour.Biz;

namespace QuanLyTour.Frm
{
    public partial class ThemDiaDiem : Form
    {
        public DiaDiemBiz current = new DiaDiemBiz();
        public ThemDiaDiem()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Equals("") || txtTen.Text.Equals(""))
            {
                MessageBox.Show("Xin nhập mã và tên địa điểm");
                return;
            }
            if (current == null) current = new DiaDiemBiz();
            current.tendiadiem = txtTen.Text;
              current.madiadiem = txtMa.Text;
                if (!current.ktra_ma())
                {
                    MessageBox.Show("Mã địa điểm bị trùng!");
                    txtMa.Select();
                    txtMa.SelectAll();
                    return;
                }
                if (current.Them()) MessageBox.Show("Thêm thành công");
                else MessageBox.Show("Thêm Không thành công");
            
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtMa.Text = "";
            this.txtTen.Text = "";
        }
    }
}
