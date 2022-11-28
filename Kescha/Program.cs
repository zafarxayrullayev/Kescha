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
            // password section START
            do
            {
                Console.Write("Parolni kirit : ");
                password = Console.ReadLine();
            } while (password != "my");
            // pasword section END 

            // introduction section START
            Console.Write("Enter your name : ");
            string userName = Console.ReadLine();
            Console.Write("Enter your surname : ");
            string userSurName = Console.ReadLine();
            Console.Write("Enter your age : ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            // introduction section END

            Bird kescha = new Bird(); // create object in Animal class;
            //Bird bird = new Bird();
            Pet petCat = new Pet();
            petCat.Name = Console.ReadLine();
            petCat.Greeting(petCat.Name);
            
            kescha.Greet(userName, userSurName, userAge);  // metod Greet 

            Console.Write("Enter animal age : ");               // enter field
            kescha.Age = Convert.ToInt32(Console.ReadLine());   // enter field
            Console.Write("Eneter animal name : ");             // enter field
            kescha.Name = Console.ReadLine();                   // enter field

            //methods 
            kescha.CalculateAgeDifference(userAge, kescha.Age);
            kescha.CompareAge(userAge, kescha.Age);
            kescha.TellMeAboutFriends(userName);
        }
    }
}
