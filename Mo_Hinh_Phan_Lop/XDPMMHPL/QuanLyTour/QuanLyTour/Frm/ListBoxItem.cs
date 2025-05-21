using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTour.Frm
{
    class ListBoxItem
    {
        public ListBoxItem(Object name, Object value)
        {
            this.name = name;
            this.value = value;
        }
        public Object name = "";
        public Object value = 0;
        public override string ToString()
        {
            return name.ToString();
        }
    }
}
