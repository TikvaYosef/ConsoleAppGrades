using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGrades
{
    internal class Teacher
    {
       public string teacherName;
       public string studentName;
       public int studentId;
       public  int[] grade; 

        public Teacher(string teacherName, string studentName, int studentId, int[] grade) 
        {
              this.teacherName = teacherName;   
            this.studentName = studentName; 
            this.studentId = studentId;
            this.grade = grade;
        }

    }
}
