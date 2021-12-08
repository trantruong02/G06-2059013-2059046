using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thi
{
    class Student
    {
        public String name { get; set; }
        public String ID { get; set; }
        //public int CauTraLoi { get; set; }

        public Student()
        {
            this.name = "";
            this.ID = "";

        }

        public Student(Student s)
        {
            this.name = s.name;
            this.ID = s.ID;
        }

        public override string ToString()
        {
            return this.name + this.ID;
        }
    }
}
