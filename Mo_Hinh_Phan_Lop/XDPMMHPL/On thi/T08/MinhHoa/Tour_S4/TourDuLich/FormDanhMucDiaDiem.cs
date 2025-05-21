using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TourDuLich.Biz;

namespace TourDuLich
{
    public partial class FormDanhMucDiaDiem : Form
    {
        List<BizDiaDiem> diaDiems = new List<BizDiaDiem>();
        List<BizDiaDiem> diaDiemsToDelete = new List<BizDiaDiem>();

        public FormDanhMucDiaDiem()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhMucDiaDiem_Load(object sender, EventArgs e)
        {
            diaDiems = BizDiaDiem.GetAll();

            gvDiaDiem.AutoGenerateColumns = false;
            gvDiaDiem.DataSource = diaDiems;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BizDiaDiem dd = new BizDiaDiem(-1, txtMaDD.Text, txtTenDD.Text);
            diaDiems.Add(dd);

            gvDiaDiem.DataSource = null;
            gvDiaDiem.DataSource = diaDiems;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (BizDiaDiem dd in diaDiems)
            {
                try
                {
                    if (dd.Id == -1)
                        dd.Add();

                    if (dd.updated)
                        dd.Update();
                }
                catch (Exception ex)
                {
                    string s = String.Format("Bị lỗi ở địa điểm ({0}-{1})",
                        dd.MaDD, dd.TenDD);
                    MessageBox.Show(s, "Lỗi");

                    return;
                }                
            }

            foreach (BizDiaDiem dd in diaDiemsToDelete)
            {
                dd.Delete();
            }
        }

        private void gvDiaDiem_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            BizDiaDiem dd = diaDiems[e.RowIndex];
            txtMaDD.Text = dd.MaDD;
            txtTenDD.Text = dd.TenDD;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gvDiaDiem.SelectedRows.Count > 0)
            {
                BizDiaDiem dd = (BizDiaDiem)gvDiaDiem.SelectedRows[0].DataBoundItem;

                dd.MaDD = txtMaDD.Text;
                dd.TenDD = txtTenDD.Text;

                dd.updated = true;

                gvDiaDiem.DataSource = null;
                gvDiaDiem.DataSource = diaDiems;
            }            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in gvDiaDiem.SelectedRows)
            {
                BizDiaDiem dd = (BizDiaDiem)row.DataBoundItem;

                diaDiems.Remove(dd);
                diaDiemsToDelete.Add(dd);

                gvDiaDiem.DataSource = null;
                gvDiaDiem.DataSource = diaDiems;
            }
        }

    }
}
