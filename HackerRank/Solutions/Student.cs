using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    class Student:Person
    {
        private int[] testScores;
        public Student(string firstName, string lastName, int id, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            testScores = scores;
        }
        public string Calculate()
        {
            double average = testScores.Average();
            string grade = "";
            Console.WriteLine(average);
            if (average < 40)
                grade = "T";
            if (average >= 40 && average < 55)
                grade = "D";
            if (average >= 90)
                grade = "O";
            if (average >= 80 && average < 90)
                grade = "E";
            if (average >= 70 && average < 80)
                grade = "A";
            if (average >= 55 && average < 70)
                grade = "P";
            return grade;
        }
    }
}
