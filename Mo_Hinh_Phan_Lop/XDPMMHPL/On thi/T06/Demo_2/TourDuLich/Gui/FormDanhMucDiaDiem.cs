using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TourDuLich.Dal;
using TourDuLich.Bll;

namespace TourDuLich
{
    public partial class FormDanhMucDiaDiem : Form
    {
        List<BizDiaDiem> listDiaDiem;
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
            listDiaDiem = DalDiaDiem.GetAllDiaDiem();

            gvDiaDiem.AutoGenerateColumns = false;
            gvDiaDiem.DataSource = listDiaDiem;            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BizDiaDiem diaDiem = new BizDiaDiem(-1, txtMaDD.Text, txtTenDD.Text);
            listDiaDiem.Add(diaDiem);

            gvDiaDiem.DataSource = null;
            gvDiaDiem.DataSource = listDiaDiem;            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gvDiaDiem.SelectedRows.Count > 0)
            {
                BizDiaDiem dd = listDiaDiem[gvDiaDiem.SelectedRows[0].Index];//(BizDiaDiem)gvDiaDiem.SelectedRows[0].DataBoundItem;
                dd.MaDD = txtMaDD.Text;
                dd.TenDD = txtTenDD.Text;

                dd.updated = true;

                gvDiaDiem.DataSource = null;
                gvDiaDiem.DataSource = listDiaDiem;
            }
        }

        private void gvDiaDiem_SelectionChanged(object sender, EventArgs e)
        {
            if (gvDiaDiem.SelectedRows.Count > 0)
            {
                BizDiaDiem dd = (BizDiaDiem)gvDiaDiem.SelectedRows[0].DataBoundItem;
                txtMaDD.Text = dd.MaDD;
                txtTenDD.Text = dd.TenDD;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gvDiaDiem.SelectedRows)
            {
                BizDiaDiem dd = (BizDiaDiem)row.DataBoundItem;
                diaDiemsToDelete.Add(dd);
                listDiaDiem.Remove(dd);

                gvDiaDiem.DataSource = null;
                gvDiaDiem.DataSource = listDiaDiem;
            }     
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (BizDiaDiem dd in listDiaDiem)
                {
                    dd.Save();
                }

                foreach (BizDiaDiem dd in diaDiemsToDelete)
                {
                    dd.Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi :(");
            }
        }

    }
}
