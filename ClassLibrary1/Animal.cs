using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Animal
    {
        public int Age { get; set; }
        public int AgeDifference { get; set; }
        public int AnimalAge { get; set; }
        public string Name { get; set; }

        public Animal(int userAge) 
        {
            Console.WriteLine("Enter animal name!");
            Name = Console.ReadLine();
            Console.WriteLine("Enter animal age!");
            Age = Convert.ToInt32(Console.ReadLine());
            AgeDifference = Math.Abs(userAge - Age);
             
        } 

    }
}
