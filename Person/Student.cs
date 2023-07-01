using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Student : Person
    {
        private string major;
        private string studentId;

        public Student (string id, string lname, string fname, int anAge, DateTime dob, string maj, string sId) 
            : base(id,lname,fname,anAge, dob)
        {
            major = maj;
            studentId = sId;
        }

        public override string Exercise()
        {
            return "hello";
        }
        public DateTime GetDob()
        {
             return base.dateOfBirth;
             
        }
        
    }
}
