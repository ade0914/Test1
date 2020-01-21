using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Test2 : Test1
    {

       
        public Test2(string fname, string lname, int myage) : base(fname, lname, myage)
        {
        }

        public int Salary{ get; set; }

        public override void Andrew()
        {
            throw new NotImplementedException();
        }



        //public void Mockexam()
        //{


        //}

        //public void Midtermexam()
        //{


        //}









    }
}
