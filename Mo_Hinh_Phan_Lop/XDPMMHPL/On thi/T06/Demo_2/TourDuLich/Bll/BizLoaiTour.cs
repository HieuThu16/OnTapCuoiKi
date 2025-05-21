using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TourDuLich.Bll
{
    public class BizLoaiTour
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string ma;
        public string MaLoai
        {
            get { return ma; }
            set { ma = value; }
        }

        private string ten;
        public string TenLoai
        {
            get { return ten; }
            set { ten = value; }
        }

        public BizLoaiTour(int _id, string _ma, string _ten)
        {
            Id = _id;
            MaLoai = _ma;
            TenLoai = _ten;
        }
    }
}
