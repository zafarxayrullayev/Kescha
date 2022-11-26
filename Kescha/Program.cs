using ClassLibrary1;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kescha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;

            do
            {
                Console.Write("Parolni kitit : ");
                password = Console.ReadLine();
            } while (password != "my");
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your first name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {name} {firstName}, Sizning yoshingiz {age} da ekan");

            // obyekt yaratish va uning fieldlarini kiritish.
            Animal kescha = new Animal();
            Console.Write("Enter animal age : ");
            kescha.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Eneter animal name : ");
            kescha.Name = Console.ReadLine();

            //methods 
            kescha.CalculateAgeDifference(age, kescha.Age);
            kescha.CompareAge(age, kescha.Age);
            kescha.TellMeAboutFriends();

            

            //string[] friendsName = { "Ali", "Vali", "Aziz" };
            //int[] friendsAge = { 10, 18, 12 };
            //string[] adress = { "sam", "tosh", "buh" };
            //Console.WriteLine($"{friendsName[0]} is {friendsAge[0]} years old");
            //Console.WriteLine($"{friendsName[1]} is {friendsAge[1]} years old");
            //Console.WriteLine($"{friendsName[0]} was born in {adress[0]}");

            //foreach (string names in friendsName)
            //{
            //    Console.WriteLine(names);
            //}
        }
    }
}
