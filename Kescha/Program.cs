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
            //string password;

            //do
            //{
            //    Console.WriteLine("Parolni kitit : ");
            //    password = Console.ReadLine();
            //} while (password != "mykescha");
            //Console.Write("Enter your name : ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your first name : ");
            //string firstName = Console.ReadLine();
            //Console.Write("Enter your age : ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Hello {name} {firstName}, Sizning yoshingiz {age} da ekan");
            //Console.WriteLine("Sizning Keschangizning yoshi nechchida? yoki nechinchi yil tug'lgan?");
            //Console.WriteLine("Yosh kiritsangiz 1 ni, yil kiritsangiz 2 ni kiriting!");
            //int tanla = Convert.ToInt32(Console.ReadLine());
            //int keschaAge = int.MinValue, keschaBorn, nowYear;
            //switch (tanla)
            //{
            //    case 1:
            //        Console.Write("Yoshni tanladingiz, yoshni kiriting! ");
            //        keschaAge = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine($"Yosh farqi {Math.Abs(age - keschaAge)} ga teng.");
            //        break;
            //    case 2:
            //        Console.Write("Yilni tanladingiz, yilini kiriting! ");
            //    z:
            //        keschaBorn = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("Hozirgi yilni kiriting! ");
            //        nowYear = Convert.ToInt32(Console.ReadLine());
            //        if (nowYear < keschaBorn)
            //        {
            //            Console.WriteLine("Hozirgi yil tug'ilgan yildan yo katta yo teng bo'ladi!!!\nQayta kiriting : ");
            //            goto z;
            //        }
            //        Console.WriteLine($"Yosh farqi {Math.Abs(age - (nowYear - keschaBorn))}");
            //        break;
            //    default:
            //        break;
            //}

            //if (age < keschaAge)
            //{
            //    Console.WriteLine("You are younger than Kescha");
            //}
            //else if (age == keschaAge)
            //{
            //    Console.WriteLine("You are equal");
            //}
            //else 
            //{
            //    Console.WriteLine("You are older than Kescha");
            //}

            string[] friendsName = { "Ali", "Vali", "Aziz" };
            int[] friendsAge = { 10, 18, 12 };
            string[] adress = { "sam", "tosh", "buh" };
            //            Console.WriteLine($"{friendsName[0]} is {friendsAge[0]} years old");
            //            Console.WriteLine($"{friendsName[1]} is {friendsAge[1]} years old");
            //            Console.WriteLine($"{friendsName[0]} was born in {adress[0]}");

            foreach (string names in friendsName)
            {
                Console.WriteLine(names);
            }
        }
    }
}
