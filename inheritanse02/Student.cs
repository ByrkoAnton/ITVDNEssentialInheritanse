using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanse02
{
    class Student
    {
        public int _num { get; }
        public string _name { get; }
        public string _lastName { get; }

        public Student(string name, int num )
        {
            _name = name;
            _num = num;
        }
        public Student(string name, int num, string lastName)
        {
            _name = name;
            _num = num;
            _lastName = lastName;
        }


        virtual public void Study()
        {
            Console.Write("Study ");
        }

        virtual public void Read()
        {
            Console.Write("Read ");
        }

        virtual public void Write()
        {
            Console.Write("Write ");
        } 

        virtual public void Relax() 
        {
            Console.Write("Relax ");
        }
    }
}
