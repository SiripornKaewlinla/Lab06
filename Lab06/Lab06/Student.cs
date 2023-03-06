using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class Student
    {
        private string name;
        private string student_id;

        public Student(string name,
            string student_id)
        {
            this.name = name;
            this.student_id = student_id;
        }
        public string displayInfo()
        {
            return student_id + "," + name;
        }
    }
}
