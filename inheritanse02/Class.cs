using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanse02
{
    class Class
    {
        private Student[] students = new Student[4];
        public Class(Student s1, Student s2, Student s3, Student s4)
        {
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;
            students[3] = s4;
        }

        public void ShowStudentsInfo()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student._num);
                Console.WriteLine(student._name);
                Console.WriteLine(student._lastName);
                student.Study();
                student.Read();
                student.Write();
                student.Relax();
                Console.WriteLine("___");
            }
        }
    }
}
