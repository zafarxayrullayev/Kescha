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

            Animal kescha = new Animal();
            string password;
            // password section
            do
            {
                Console.Write("Parolni kirit : ");
                password = Console.ReadLine();
            } while (password != "my");
            // pasword section

            // introduction section START
            Console.Write("Enter your name : ");
            string userName = Console.ReadLine();
            Console.Write("Enter your surname : ");
            string userSurName = Console.ReadLine();
            Console.Write("Enter your age : ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Hello {name} {firstName}, Sizning yoshingiz {age} da ekan");
            kescha.Greet(userName, userSurName, userAge);

            // obyekt yaratish va uning fieldlarini kiritish.
            
            Console.Write("Enter animal age : ");
            kescha.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Eneter animal name : ");
            kescha.Name = Console.ReadLine();

            //methods 
            kescha.CalculateAgeDifference(userAge, kescha.Age);
            kescha.CompareAge(userAge, kescha.Age);
            kescha.TellMeAboutFriends(userName);


        }
    }
}
