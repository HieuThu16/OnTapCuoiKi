using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTour.Dal;

namespace QuanLyTour.Biz
{
    public class TourBiz
    {
        public String matour;
        public String tentour;
        public int tourtn;
        public List<GiaTourBiz> ds_giatour;
        public List<DiaDiemBiz> ds_diadiem;
        public TourDAL dal = new TourDAL();
        public TourBiz()
        {
            this.matour = "";
            this.tentour = "";
            this.tourtn = 1;
            ds_diadiem = new List<DiaDiemBiz>();
            ds_giatour = new List<GiaTourBiz>();
        }
        public Boolean ktra_ma()
        {
            return dal.check_ma(this.matour);
        }
        public Boolean Them()
        {
            return dal.Insert(this);
        }
        public Boolean Sua()
        {
            return dal.Edit(this);
        }
        public Boolean Xoa()
        {
            return dal.delete(this);
        }
    }
}