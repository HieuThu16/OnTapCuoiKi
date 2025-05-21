using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTour.Biz;
using QuanLyTour.Dal;
using System.Windows.Forms;
using System.Windows.Controls;

namespace QuanLyTour.Frm
{
    public partial class ChiTietTourFrm : Form
    {
        public TourBiz current = new TourBiz();
        public Boolean giatour_editmode = false;
        public Boolean editmode = false;
        public ChiTietTourFrm(Boolean mode,TourBiz tour)
        {
            InitializeComponent();
            this.editmode = mode;
            this.current = tour;
            if (editmode)
            {
                txtMa.Text = current.matour;
                txtTen.Text = current.tentour;
                if (current.tourtn == 1) radioTN.Checked = true;
                else if (current.tourtn == 0) radioNN.Checked = true;
            }
            this.Load_DSGiaTour();
            this.load_dsDiaDiem();
        }
        public void load_dsDiaDiem()
        {
            this.listAllDD.Items.Clear();
            DiaDiemDAL dal1 = new DiaDiemDAL();
            List<DiaDiemBiz> listAll=dal1.getAll();
            foreach (DiaDiemBiz dt in listAll)
            {
                ListBoxItem itm = new ListBoxItem(dt.tendiadiem,dt.madiadiem);
                listAllDD.Items.Add(itm);
            }
            if (editmode)
            {
                DanhSachDDDAL dal = new DanhSachDDDAL();
                List<DiaDiemBiz> dsdd=dal.getAll(current.matour);
                foreach (DiaDiemBiz dt in dsdd)
                {
                    ListBoxItem itm = new ListBoxItem(dt.tendiadiem, dt.madiadiem);
                    listDSDD.Items.Add(itm);
                    for (int i = 0; i < listAllDD.Items.Count; i++)
                    {
                        if ((listAllDD.Items[i] as ListBoxItem).value.Equals(itm.value))
                        {
                            listAllDD.Items.RemoveAt(i); break;
                        }
                    }
                }
            }
        }
        public void Load_DSGiaTour()
        {
            this.listGiaTour.Clear();
            this.listGiaTour.View = View.Details;
            this.listGiaTour.Columns.Add("");
            this.listGiaTour.Columns[0].Width = 0;
            this.listGiaTour.Columns.Add("Mã giá");
        //    this.listGiaTour.Columns[1].Width = this.listGiaTour.Width / 2;
            this.listGiaTour.Columns.Add("Giá trị");
        //    this.listGiaTour.Columns[2].Width = this.listGiaTour.Width / 2;
            this.listGiaTour.Columns.Add("Ngày bắt đầu");
        //    this.listGiaTour.Columns[2].Width = this.listGiaTour.Width / 2;
            this.listGiaTour.Columns.Add("Ngày kết thúc");
        //    this.listGiaTour.Columns[2].Width = this.listGiaTour.Width / 2;
            this.listGiaTour.Columns.Add("Đang áp dụng");
         //   this.listGiaTour.Columns[2].Width = this.listGiaTour.Width / 2;
            if (editmode)
            {
                GiaTourDAL dal = new GiaTourDAL();
                List<GiaTourBiz> list = new List<GiaTourBiz>();
                list=dal.getAll(current.matour);
                if (list.Count == 0) return;
                current.ds_giatour = list;
                foreach (GiaTourBiz dt in list)
                {
                    ListViewItem itm = new ListViewItem();
                    itm.SubItems.Add(dt.magia);
                    itm.SubItems.Add(dt.giatri.ToString());
                    itm.SubItems.Add(dt.thoigianbatdau.Date.ToShortDateString());
                    itm.SubItems.Add(dt.thoigianketthuc.Date.ToShortDateString());
                    itm.SubItems.Add(dt.dangapdung.ToString());
                    listGiaTour.Items.Add(itm);
                }
            }
        }


        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            if (txtMaGia.Text == "" || txtGiaTri.Text == "")
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
                return;
            }
            if (giatour_editmode)
            {
                //Sửa giá tour đã có trong ds
                if (listGiaTour.SelectedItems[0].SubItems[1].Text.Equals(txtMaGia.Text))
                {
                    listGiaTour.SelectedItems[0].SubItems[2].Text = txtGiaTri.Text;
                    listGiaTour.SelectedItems[0].SubItems[3].Text = date1.Value.Date.ToShortDateString();
                    listGiaTour.SelectedItems[0].SubItems[4].Text = date2.Value.Date.ToShortDateString();
                    if (chkDangAP.Checked == true) listGiaTour.SelectedItems[0].SubItems[5].Text = "1";
                    else listGiaTour.SelectedItems[0].SubItems[5].Text = "0";
                   
                }
                else
                {
                    MessageBox.Show("Không thể thay đổi mã giá tour");
                    txtMaGia.Text = listGiaTour.SelectedItems[0].SubItems[1].Text;
                    txtMaGia.Select();
                    return;
                }

            }
            else
            {
                //thêm giá tour mới
                //kiem tra mã giá tour có bị trùng trong danh sách hay không
                if (listGiaTour.Items.Count > 0)
                {
                    for (int i = 0; i < listGiaTour.Items.Count; i++)
                    {
                        if (listGiaTour.Items[i].SubItems[1].Text.ToString().Equals(txtMaGia.Text))
                        {
                            MessageBox.Show("Mã giá bị trùng!");
                            txtMaGia.Select();
                            return; 
                        }
                    }
                }
                //thêm giá tour mới vào listview
                ListViewItem itm = new ListViewItem();
                itm.SubItems.Add(txtMaGia.Text);
                itm.SubItems.Add(txtGiaTri.Text);
                itm.SubItems.Add(date1.Value.Date.ToShortDateString());
                itm.SubItems.Add(date2.Value.Date.ToShortDateString());
                if (this.chkDangAP.Checked) itm.SubItems.Add("1");
                else itm.SubItems.Add("0");
                listGiaTour.Items.Add(itm);
            }
        }

        private void btnLuuTour_Click(object sender, EventArgs e)
        {
            if (this.txtMa.Text.Equals("") || this.txtTen.Text.Equals(""))
            {
                MessageBox.Show("Xin nhập đầy đủ các thông tin của tour");
                txtMa.Focus();
                return;
            }
            current.tentour = this.txtTen.Text;
            if (radioTN.Checked) current.tourtn = 1;
            else if (radioNN.Checked) current.tourtn = 0;
            //xóa danh sách giá tour để cập nhật danh sách mới
            current.ds_giatour.Clear();
            for (int i = 0; i < listGiaTour.Items.Count; i++)
            {
                GiaTourBiz dt = new GiaTourBiz();
                dt.magia = listGiaTour.Items[i].SubItems[1].Text.ToString();
                dt.giatri = int.Parse(listGiaTour.Items[i].SubItems[2].Text.ToString());
                dt.thoigianbatdau = DateTime.Parse(listGiaTour.Items[i].SubItems[3].Text.ToString());
                dt.thoigianketthuc = DateTime.Parse(listGiaTour.Items[i].SubItems[4].Text.ToString());
                dt.dangapdung = int.Parse(listGiaTour.Items[i].SubItems[5].Text.ToString());
                dt.matour = current.matour;
                current.ds_giatour.Add(dt);
            }
            current.ds_diadiem.Clear();
            for (int i = 0; i < listDSDD.Items.Count; i++)
            {
                DiaDiemBiz dt = new DiaDiemBiz();
                dt.madiadiem = (listDSDD.Items[i] as ListBoxItem).value.ToString();
                current.ds_diadiem.Add(dt);
            }
            if (editmode)
            {
                if (!current.matour.Equals(txtMa.Text))
                {
                    MessageBox.Show("Không thể thay đổi mã tour");
                    txtMa.Text = current.matour;
                    txtMa.Select();
                    return;
                }
                if (current.Sua()) MessageBox.Show("Sửa thành công");
                else MessageBox.Show("Sửa Không thành công");
            }
            else
            {
                current.matour = this.txtMa.Text;
                if (!current.ktra_ma())
                {
                    MessageBox.Show("Mã tour bị trùng!");
                    txtMa.Select();
                    txtMa.SelectAll();
                    return;
                }
                if (current.Them())
                {
                    MessageBox.Show("Thêm thành công");
                    txtMa.Text = "";
                    txtTen.Text = "";
                    listGiaTour.Items.Clear();
                    this.btnRS_Click(sender, e);
                }
                else MessageBox.Show("Không thể thêm tour mới");
            }
        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            if (date2.Value < date1.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");
                date2.Focus();
                date2.Select();
            }
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            txtMaGia.Text = "";
            txtGiaTri.Text = "";
            date1.Value = DateTime.Now;
            date2.Value = DateTime.Now;
            chkDangAP.Checked = false;
        }

        private void chkDangAP_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.listGiaTour.SelectedItems.Count == 1)
            {
                giatour_editmode = true;
                txtMaGia.Focus();
            }
            else MessageBox.Show("Chọn giá tour để sửa!");
        }

        private void listGiaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listGiaTour_Click(sender,e);
        }

        private void listGiaTour_Click(object sender, EventArgs e)
        {
            if (this.listGiaTour.SelectedItems.Count == 1)
            {
                giatour_editmode = true;
                txtMaGia.Text = listGiaTour.SelectedItems[0].SubItems[1].Text.ToString();
                txtGiaTri.Text = listGiaTour.SelectedItems[0].SubItems[2].Text.ToString();
                date1.Value = DateTime.Parse(listGiaTour.SelectedItems[0].SubItems[3].Text.ToString());
                date2.Value = DateTime.Parse(listGiaTour.SelectedItems[0].SubItems[4].Text.ToString());
                if (listGiaTour.SelectedItems[0].SubItems[5].Text.ToString() == "1") chkDangAP.Checked = true;
                else chkDangAP.Checked = false;
            }
        }

        private void btnThemGiaTour_Click(object sender, EventArgs e)
        {
            giatour_editmode = false;
            this.btnRS_Click(sender,e);
            txtMaGia.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.listGiaTour.SelectedItems.Count == 1)
            {
                DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn xóa giá tour này?", "Chú ý", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                    listGiaTour.SelectedItems[0].Remove();
                else if (a == DialogResult.No) return;
                
            }
            else MessageBox.Show("Chọn giá tour cần xóa");
        }

        private void chkDangAP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listGiaTour.Items.Count; i++)
            {
                if (listGiaTour.Items[i].SubItems[5].Text.ToString().Equals("1")&&listGiaTour.Items[i].SubItems[1].Text.ToString()!=txtMaGia.Text)
                {
                    MessageBox.Show("Đã có giá tour được áp dụng trong danh sách.Hủy áp dụng giá tour cũ để áp dụng giá tour này!");
                    chkDangAP.Checked = false;
                    chkDangAP.Focus();
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listAllDD.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listAllDD.SelectedItems.Count; i++)
                {
                    
                    listDSDD.Items.Add(listAllDD.SelectedItems[i]);
                    listDSDD.SelectedItems.Add(listAllDD.SelectedItems[i]);
                }
                for (int i = listAllDD.SelectedItems.Count - 1; i >= 0; i--)
                   listAllDD.Items.Remove(listAllDD.SelectedItems[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listDSDD.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listDSDD.SelectedItems.Count; i++)
                {

                    listAllDD.Items.Add(listDSDD.SelectedItems[i]);
                    listAllDD.SelectedItems.Add(listDSDD.SelectedItems[i]);
                }
                for (int i = listDSDD.SelectedItems.Count - 1; i >= 0; i--)
                    listDSDD.Items.Remove(listDSDD.SelectedItems[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listDSDD.SelectedItems.Count > 0)
            {
                List<ListBoxItem> list = new List<ListBoxItem>();
                for (int i = 0; i < listDSDD.SelectedItems.Count; i++)
                {
                    list.Add(listDSDD.SelectedItems[i] as ListBoxItem);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    ListBoxItem temp = list[i] as ListBoxItem;
                    int k = listDSDD.Items.IndexOf(temp);
                    if (k == 0) return;
                    listDSDD.Items.Remove(temp);
                    listDSDD.Items.Insert(k - 1, temp);
                    listDSDD.SelectedItems.Add(temp);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listDSDD.SelectedItems.Count > 0)
            {
                List<ListBoxItem> list = new List<ListBoxItem>();
                for (int i = 0; i < listDSDD.SelectedItems.Count; i++)
                {
                    list.Add(listDSDD.SelectedItems[i] as ListBoxItem);
                }
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    ListBoxItem temp = list[i] as ListBoxItem;
                    int k = listDSDD.Items.IndexOf(temp);
                    if (k == listDSDD.Items.Count-1) return;
                    listDSDD.Items.Remove(temp);
                    listDSDD.Items.Insert(k + 1, temp);
                    listDSDD.SelectedItems.Add(temp);
                }
            }
        }

        private void btnThemDiaDiem_Click(object sender, EventArgs e)
        {
            ThemDiaDiem f = new ThemDiaDiem();
            f.ShowDialog();
            this.load_dsDiaDiem();
        }


      
    }
}
