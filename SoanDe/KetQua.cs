using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoanDe
{
    class KetQua
    {
        public String name { get; set; }
        public String Id { get; set; }
        public String thoiGianThi { get; set; }
        public String Diem { get; set; }
        public override string ToString()
        {
            return this.name + " | " + this.Id + " | " + this.Diem + " | " + this.thoiGianThi;
        }
    }
}
