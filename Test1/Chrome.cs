using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Chrome : Test1
    {
        public Chrome(string fname, string lname, int myage) : base(fname, lname, myage)
        {
        }

        public override void Andrew()
        {
            Console.WriteLine("Chrome");
        }
    }
}
