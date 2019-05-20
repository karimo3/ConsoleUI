using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }


        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public static int getMax(int a, int b)
        {
            int max;
            if (a < b)
            {
                max = b;
            }
            else
                max = a;

            return max;
        }

       
       


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }


        public List<float> grades;


    }//GradeBook
}