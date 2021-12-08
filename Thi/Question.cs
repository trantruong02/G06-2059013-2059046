using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thi
{
    class Question
    {
        //public int stt { get; set; }
        public String CauHoi { get; set; }
        public String CauA { get; set; }
        public String CauB { get; set; }
        public String CauC { get; set; }
        public String CauD { get; set; }
        //public int CauTraLoi { get; set; }
        public string CauTraLoi { get; set; }
        public String MaDe { get; set; }
        public Question()
        {
            //this.stt = 0;
            this.CauHoi = this.CauA = this.CauB = this.CauC = this.CauD = String.Empty;
            this.CauTraLoi = this.MaDe = String.Empty;

        }

        public Question(String stt, String ch, String a, String b, String c, String d)
        {
           //this.stt = int.Parse(stt);
            this.CauHoi = ch;
            this.CauA = a;
            this.CauB = b;
            this.CauC = c;
            this.CauD = d;
        
        }

        public override string ToString()
        {
            return /*this.stt.ToString() + "." +*/ this.CauHoi + "\n" + this.CauA + "\n" + this.CauB + "\n" + this.CauC + "\n" + this.CauD;
        }
    }
}

