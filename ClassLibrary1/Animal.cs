using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Animal
    {
        public int Age { get; set; }
        public int AgeDifference { get; set; }
        public string Name { get; set; }
        
        
        public void CalculateAgeDifference(int userAge, int animalAge)
        {
            Console.WriteLine($"Sizning {Name} bilan yosh farqingiz {Math.Abs(userAge - animalAge)}");
        }
        
        public void CompareAge(int userAge, int animalAge)
        {
            if (userAge < animalAge)
            {
                Console.WriteLine($"You are younger than {Name}");
            }
            else if (userAge == animalAge)
            {
                Console.WriteLine("You are equal");
            }
            else
            {
                Console.WriteLine($"You are older than {Name}");
            }
        }

        public void Greet(string name, string surname, int age)
        {
            Console.WriteLine($"Hello {name} {surname}, Sizning yoshingiz {age} da ekanligini endi men bilaman!");
        }
        public void TellMeAboutFriends(string userName)
        {
            string[] friendsName = new string[3];

            friendsName[0] = "Ali";
            friendsName[1] = "Ma'mur";
            friendsName[2] = userName;
            foreach (string names in friendsName)
            {
                Console.Write($"{names},    ");
            }
            Console.WriteLine("\n");
        }

    }
}
