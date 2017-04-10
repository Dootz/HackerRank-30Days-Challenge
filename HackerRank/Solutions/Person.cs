using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    // Challenge Day 4
    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            if (initialAge < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                age = initialAge;
                amIOld();
            }
        }
        public void amIOld()
        {
            string ageString;
            // Do some computations in here and print out the correct statement to the console 
            if (age < 13)
                ageString = "You are young.";
            else if (age >= 13 && age < 18)
                ageString = "You are a teenager";
            else
                ageString = "You are old.";
            Console.WriteLine(ageString);
        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            age++;
        }
    }
}
