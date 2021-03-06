﻿using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanse02
{
    class GoodStudent : Student
    {
        public GoodStudent(string name, int num) : base(name, num)
        {
        }

        public GoodStudent(string name, int num, string lastName) : base(name, num, lastName)
        {
        }

        override public void Study()
        {
            base.Study();
            Console.WriteLine("********");
        }

        override public void Read()
        {
            base.Read();
            Console.WriteLine("******");
        }

        override public void Write()
        {
            base.Write();
            Console.WriteLine("******");
        }

        override public void Relax()
        {
            base.Relax();
            Console.WriteLine("***");
        }
    }
}
