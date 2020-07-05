using System;

namespace inheritanse02
{
    class Program
    {
        static void Main(string[] args)
        {
            Class _class = new Class(new ExcelentStudent("Anton", 1), new BadStudent("Bob", 2, "Wob"), 
                new GoodStudent("Ivan", 3, "Kalaban"), new Student("John", 4));

            _class.ShowStudentsInfo();
            
        }
    }
}
