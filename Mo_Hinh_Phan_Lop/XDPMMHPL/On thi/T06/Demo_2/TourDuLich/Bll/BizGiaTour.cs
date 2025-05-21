using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TourDuLich.Bll
{
    public class BizGiaTour
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }        

        private bool dangApDung;
        public bool DangApDung
        {
            get { return dangApDung; }
            set { dangApDung = value; }
        }

        private Decimal giaTri;
        public String GiaTri
        {
            get { return ((int)giaTri).ToString(); }
            set { giaTri = Decimal.Parse(value); }
        }

        private DateTime thoiGianBatDau;
        public DateTime ThoiGianBatDau
        {
            get { return thoiGianBatDau; }
            set { thoiGianBatDau = value; }
        }
        public string sThoiGianBatDau
        {
            get { return ThoiGianBatDau.ToShortDateString(); }
        }

        private DateTime thoiGianKetThuc;
        public DateTime ThoiGianKetThuc
        {
            get { return thoiGianKetThuc; }
            set { thoiGianKetThuc = value; }
        }
        public string sThoiGianKetThuc
        {
            get { return ThoiGianKetThuc.ToShortDateString(); }
        }

        private BizTour tour;
        public BizTour Tour
        {
            get { return tour; }
            set { tour = value; }
        }

        public BizGiaTour(int _id, bool _apDung, Decimal _giaTri, 
            DateTime _tgbd, DateTime _tgkt, BizTour _tour)
        {
            Id = _id;
            DangApDung = _apDung;
            giaTri = _giaTri;
            ThoiGianBatDau = _tgbd;
            ThoiGianKetThuc = _tgkt;
            Tour = _tour;
        }

        private bool updated = false;
        public bool Updated
        {
            get { return updated; }
            set { updated = value; }
        }
    }
}
