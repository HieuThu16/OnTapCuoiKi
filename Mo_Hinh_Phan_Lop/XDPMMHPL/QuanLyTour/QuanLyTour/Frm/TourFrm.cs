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
using QuanLyTour.Dal;

namespace QuanLyTour.Frm
{
    public partial class TourFrm : Form
    {
        public TourBiz current = new TourBiz();
        public TourDAL dal = new TourDAL();
        public TourFrm()
        {
            InitializeComponent();
            this.Load_DSTour();
        }
        public void Load_DSTour()
        {
            this.listTour.Clear();
            this.listTour.View = View.Details;
            this.listTour.Columns.Add("");
            this.listTour.Columns[0].Width = 0;
            this.listTour.Columns.Add("Mã tour");
            this.listTour.Columns[1].Width = this.listTour.Width / 3;
            this.listTour.Columns.Add("Tên tour");
            this.listTour.Columns[2].Width = this.listTour.Width / 3;
            this.listTour.Columns.Add("Loại tour");
            this.listTour.Columns[2].Width = (this.listTour.Width / 3)+10;

            List<TourBiz> list = new List<TourBiz>();
            list = dal.getAll();
            if (list.Count == 0) return;
            foreach (TourBiz dt in list)
            {
                ListViewItem itm = new ListViewItem();
                itm.SubItems.Add(dt.matour);
                itm.SubItems.Add(dt.tentour);
                if (dt.tourtn == 1) itm.SubItems.Add("Tour trong nước");
                else itm.SubItems.Add("Tour nước ngoài");
                listTour.Items.Add(itm);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChiTietTourFrm dt = new ChiTietTourFrm(false,new TourBiz());
      //      dt.editmode = false;
            dt.ShowDialog();
            this.Load_DSTour();
        }

        private void listTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTour.SelectedItems.Count == 1)
            {
                current.matour = listTour.SelectedItems[0].SubItems[1].Text.ToString();
                current.tentour = listTour.SelectedItems[0].SubItems[2].Text.ToString();
                if(listTour.SelectedItems[0].SubItems[3].Text.Equals("Tour trong nước"))
                    current.tourtn=1;
                else current.tourtn=0;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listTour.SelectedItems.Count == 1)
            {
                ChiTietTourFrm ct = new ChiTietTourFrm(true,this.current);
             //   ct.editmode = true;
            //    ct.current = this.current;
                ct.ShowDialog();
                this.Load_DSTour();
            }
            else MessageBox.Show("Chọn tour cần sửa!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listTour.SelectedItems.Count == 1)
            {
                DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn xóa tour này?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {
                    GiaTourDAL giatourdal = new GiaTourDAL();
                    current.ds_giatour = giatourdal.getAll(current.matour);
                    if (dal.delete(current))
                    {
                        MessageBox.Show("Xóa thành công");
                        this.Load_DSTour();
                    }
                    else MessageBox.Show("Xóa không thành công");
                }
                else return;
            }
            else MessageBox.Show("Chọn tour cần xóa");

        }
    }
}
