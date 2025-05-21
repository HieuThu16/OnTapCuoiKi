using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourDuLich.Bll;
using TourDuLich.Dal;

namespace TourDuLich.Bll
{
    public class BizTour
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string ma;
        public string MaTour
        {
            get { return ma; }
            set { ma = value; }
        }

        private string ten;
        public string TenTour
        {
            get { return ten; }
            set { ten = value; }
        }

        private bool laTourTrongNuoc;
        public bool LaTourTrongNuoc
        {
            get { return laTourTrongNuoc; }
            set { laTourTrongNuoc = value; }
        }

        private BizLoaiTour loaiTour;
        public BizLoaiTour LoaiTour
        {
            get { return loaiTour; }
            set { loaiTour = value; }
        }

        private List<BizGiaTour> gias;
        public List<BizGiaTour> Gias
        {
            get 
            {
                if (gias == null)
                    LoadGia();
                return gias; 
            }
            set { gias = value; }
        }
        public String GiaHienTai
        {
            get
            {
                foreach (BizGiaTour gia in Gias)
                {
                    if (gia.DangApDung)
                    {
                        return gia.GiaTri;
                    }
                }
                return String.Empty;
            }
        }

        private void LoadGia()
        {
            gias = DalTour.GetGiaByTour(this);
        }

        public string TenLoaiTour
        {
            get { return LoaiTour == null ? String.Empty : LoaiTour.TenLoai; }
        }

        public BizTour(int _id, string _ma, string _ten,
            bool _laTourTN, BizLoaiTour _loaiTour)
        {
            Id = _id;
            MaTour = _ma;
            TenTour = _ten;
            LaTourTrongNuoc = _laTourTN;
            LoaiTour = _loaiTour;
        }

        public BizTour(int _id)
        {
            Id = _id;
        }

        internal void Delete()
        {
            DalTour.Delete(this);
        }

        internal void CapNhatGiaDangApDung(BizGiaTour giaTourMoiNhat)
        {
            if (giaTourMoiNhat.DangApDung)
            {
                foreach (BizGiaTour gia in Gias)
                {
                    if (gia.Id != giaTourMoiNhat.Id)
                        if (gia.DangApDung)
                            gia.DangApDung = false;
                }
            }
        }

        private List<BizDiaDiem> diaDiems;
        public List<BizDiaDiem> DiaDiems
        {
            get 
            {
                if (diaDiems == null)
                {
                    diaDiems = DalDiaDiem.GetDiaDiemByTour(this);
                }
                return diaDiems; 
            }
            set { diaDiems = value; }
        }


        internal void Save()
        {
            if (Id == -1)
            {
                Id = DalTour.InsertNewTour(this);
            }

            DalTour.DeleteGiaByTour(this);
            DalTour.InsertGiaByTour(this);

            DalTour.DeleteDiaDiemByTour(this);
            DalTour.InsertDiaDiemByTour(this);
        }

        public string GiaDangApDung
        {
            get
            {
                string result = String.Empty;
                foreach (BizGiaTour gia in Gias)
                    if (gia.DangApDung)
                    {
                        result = gia.GiaTri.ToString();
                        break;
                    }
                return result;
            }
        }
    }
}
