using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourDuLich.Dal;

namespace TourDuLich.Biz
{
    public class BizDiaDiem
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string ma;
        public string MaDD
        {
            get { return ma; }
            set { ma = value; }
        }

        private string ten;
        public string TenDD
        {
            get { return ten; }
            set { ten = value; }
        }

        public BizDiaDiem(int _id, string _ma, string _ten)
        {
            Id = _id;
            MaDD = _ma;
            TenDD = _ten;
        }

        public BizDiaDiem()
        {
            // TODO: Complete member initialization
        }

        internal static List<BizDiaDiem> GetAll()
        {
            return DalDiaDiem.GetAll();
        }

        internal void Add()
        {
            this.Id = DalDiaDiem.Add(this);
        }

        internal bool updated = false;

        internal void Update()
        {
            DalDiaDiem.Update(this);
        }

        internal void Delete()
        {
            DalDiaDiem.Delete(this);
        }
    }

    class DiaDiemComparer : IEqualityComparer<BizDiaDiem>
    {

        #region IEqualityComparer<BizDiaDiem> Members

        public bool Equals(BizDiaDiem x, BizDiaDiem y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(BizDiaDiem obj)
        {
            return obj.GetHashCode();
        }

        #endregion
    }
}









