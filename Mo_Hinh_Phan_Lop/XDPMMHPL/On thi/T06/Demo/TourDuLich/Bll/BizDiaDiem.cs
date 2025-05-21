using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourDuLich.Dal;

namespace TourDuLich.Bll
{
    public class BizDiaDiem
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String maDD;
        public String MaDD
        {
            get { return maDD; }
            set { maDD = value; }
        }

        private String tenDD;
        public String TenDD
        {
            get { return tenDD; }
            set { tenDD = value; }
        }

        public bool updated = false;

        public BizDiaDiem(int _id, String _ma, String _ten)
        {
            Id = _id;
            MaDD = _ma;
            TenDD = _ten;
        }

        internal void Save()
        {
            if (Id == -1)
            {
                id = DalDiaDiem.Insert(this);
            }

            if(updated)
                DalDiaDiem.Update(this);
        }

        internal void Delete()
        {
            DalDiaDiem.Delete(this);
        }
    }
}
