using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumPractice.HR
{
    public class Person
    {
       

        public Person(int age, int experience, string name)
        {
            age = age + 10;
            experience = experience + 10;
            name = name + ", Esq.";
            //Console.WriteLine($"this is the age: {age}, this is the experience & name: {experience}, {name}");
            
            void GetPersonData()
            {
                Console.WriteLine($"This is age: {age}, this is the experience & name: {experience}, {name} ");
                Console.ReadLine();
            }
            
               
        }
        

        
    }
}
