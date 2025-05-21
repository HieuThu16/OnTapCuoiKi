using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTour.Dal;
namespace QuanLyTour.Biz
{
  public  class DiaDiemBiz
    {
        public String madiadiem="";
        public String tendiadiem="";
        private DiaDiemDAL dal = new DiaDiemDAL();
        public DiaDiemBiz()
        {
            this.madiadiem = "";
            this.tendiadiem = "";
        }
        public Boolean ktra_ma()
        {
           return dal.check_ma(this.madiadiem);
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
