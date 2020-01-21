using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Firefox : Test1
    {
        public Firefox(string fname, string lname, int myage) : base(fname, lname, myage)
        {
        }

        public override void Andrew()
        {
            Console.WriteLine("Firefox");
        }
    }
}
