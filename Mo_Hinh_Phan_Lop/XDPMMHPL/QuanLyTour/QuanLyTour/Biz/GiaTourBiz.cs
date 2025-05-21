using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTour.Dal;

namespace QuanLyTour.Biz
{
   public class GiaTourBiz
    {
       public String magia;
       public long giatri;
       public DateTime thoigianbatdau;
       public DateTime thoigianketthuc;
       public int dangapdung;
       public String matour;
       public GiaTourDAL dal = new GiaTourDAL();
       public GiaTourBiz()
       {
           this.magia = "";
           this.giatri = 0;
           this.thoigianbatdau = DateTime.Now;
           this.thoigianketthuc = DateTime.Now;
           this.dangapdung = 1;
           this.matour = "";
       }
       public Boolean them()
       {
           return dal.Insert(this);
       }
       public Boolean sua()
       {
           return dal.Edit(this);
       }
       public Boolean xoa()
       {
           return dal.delete(this);
       }
       public Boolean ktra_ma()
       {
           return dal.check_ma(this.magia);
       }
    }
}
