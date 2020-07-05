using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanse02
{
    class BadStudent : Student
    {
        public BadStudent(string name, int num) : base(name, num)
        {
        }

        public BadStudent(string name, int num, string lastName) : base(name, num, lastName)
        {
        }

        override public void Study()
        {
            base.Study();
            Console.WriteLine("**");
        }

        override public void Read()
        {
            base.Read();
            Console.WriteLine("*");
        }

        override public void Write()
        {
            base.Write();
            Console.WriteLine("***");
        }

        override public void Relax()
        {
            base.Relax();
            Console.WriteLine("*************");
        }
    }
}
