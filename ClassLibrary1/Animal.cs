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
        public int UserAge { get; set; }
        public string Name { get; set; }
        
        
        public void CalculateAgeDifference(int userAge, int animalAge)
        {
            Console.WriteLine($"Sizning {Name} bilan yosh farqingiz {userAge - animalAge}");
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

        public void TellMeAboutFriends()
        {
            string[] friendsName = new string[100];
            Console.WriteLine("Enter your friends name");
            for (int i = 0; i < 3; i++)
            {
                friendsName[i] = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{friendsName[i]},   ");
            }
        }

    }
}
