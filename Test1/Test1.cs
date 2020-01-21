using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    abstract class Test1
    {
        private string practice2;
        public string Firstname
        {
            get

            {
                return practice2;
            }


            set
            {
                if (value.Length>8)
                {
                    practice2 = "Andrew";
                }

                else
                {
                    practice2=value;
                }

            }

        }

        public string SetLastname(string x)
        {
            if (x.Length>8)
            {
                return "Andrew";

            }
            else
            {
                return x;
            }


        }
        public string Lastname;
        //public int Age { get; set; }

        private static int practice1;
        public int Age
        {
            get

            {
                return practice1;
            }


            set
            {
                if (value > 10)
                {
                    practice1 = 1;
                }

                else
                {
                    practice1 = value;
                }

            }

        }



        public Test1(string fname = "Larry", string lname = "Tan", int myage = 19)
        {
            Firstname = fname;
            Lastname = SetLastname(lname);
            Age = myage;

        }

        public void CreateStudent()
        {

            Console.WriteLine($"{Firstname} {Lastname} is {Age} Old");
            Console.Read();
        }

        public abstract void Andrew();



    }
}
