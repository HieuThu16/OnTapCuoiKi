using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTour.Dal;
using QuanLyTour.Biz;
namespace QuanLyTour.Frm
{
    public partial class DiaDiemFrm : Form
    {
        public DiaDiemBiz current;
        public Boolean editmode = false;

        List<DiaDiemBiz> list = new List<DiaDiemBiz>();

        public DiaDiemFrm()
        {
            InitializeComponent();
            Load_DSDiaDiem();
        }
       
        public void Load_DSDiaDiem()
        {
            this.listDiaDiem.Clear();
            this.listDiaDiem.View = View.Details;
            this.listDiaDiem.Columns.Add("");
            this.listDiaDiem.Columns[0].Width = 0;
            this.listDiaDiem.Columns.Add("Mã địa điểm");
            this.listDiaDiem.Columns[1].Width = this.listDiaDiem.Width / 2;
            this.listDiaDiem.Columns.Add("Tên địa điểm");
            this.listDiaDiem.Columns[2].Width = this.listDiaDiem.Width / 2;
            DiaDiemDAL dal = new DiaDiemDAL();
            
            list = dal.getAll();
            if(list.Count==0) return;
            foreach (DiaDiemBiz dt in list)
            {
                ListViewItem itm=new ListViewItem();
                itm.SubItems.Add(dt.madiadiem);
                itm.SubItems.Add(dt.tendiadiem);
                listDiaDiem.Items.Add(itm);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.current = new DiaDiemBiz();
            this.editmode = false;
            this.txtMa.Text = "";
            this.txtTen.Text = "";
            this.txtMa.Focus();
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
            if (!editmode)
            {
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
            else
            {
                if (!txtMa.Text.Equals(current.madiadiem))
                {
                    MessageBox.Show("Không thể thay đổi mã địa điểm");
                    txtMa.Text = current.madiadiem;
                    txtMa.Select();
                    return;
                }
                if (current.Sua()) MessageBox.Show("Sửa thành công");
                else MessageBox.Show("Sửa Không thành công");
            }
            this.Load_DSDiaDiem();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtMa.Text = "";
            this.txtTen.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.listDiaDiem.SelectedItems.Count == 1)
                txtTen.Focus();
            else MessageBox.Show("Chọn địa điểm để sửa!");
        }


        private void listDiaDiem_Click(object sender, EventArgs e)
        {
            if (this.listDiaDiem.SelectedItems.Count == 1)
            {
               editmode = true;
               /*current = new DiaDiemBiz();
               current.madiadiem= listDiaDiem.SelectedItems[0].SubItems[1].Text.ToString();
               current.tendiadiem = listDiaDiem.SelectedItems[0].SubItems[2].Text.ToString();*/
               current = list[listDiaDiem.SelectedIndices[0]];
               txtMa.Text = current.madiadiem;
               txtTen.Text = current.tendiadiem;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.listDiaDiem.SelectedItems.Count == 1)
            {
                DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn xóa địa điểm này?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {
                    if (current.Xoa())
                        MessageBox.Show("Xóa thành công");
                    else MessageBox.Show("Xóa không thành công");
                }
                else if (a == DialogResult.No) return;
                this.Load_DSDiaDiem();
            }
            else MessageBox.Show("Chọn địa điểm cần xóa");
        }

        private void listDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listDiaDiem_Click(sender,e);
        }

    }
}
