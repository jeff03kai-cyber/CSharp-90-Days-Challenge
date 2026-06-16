using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 01 --- PasswordMathcers

            Console.Write("Please enter a password :: ");
            string firstPassword = Console.ReadLine();

            Console.Write("Enter password again :: ");
            string secondPassword = Console.ReadLine();

            if (!firstPassword.Equals(String.Empty))
            {
                if (!secondPassword.Equals(String.Empty))
                {
                    if (firstPassword.Length >= 8 && secondPassword.Length >= 8)
                    {
                        if (firstPassword.Equals(secondPassword))
                        {
                            Console.WriteLine("Correct password.");
                            Console.WriteLine("Welcome!");
                            Console.WriteLine($@"For English press ""1""");
                            Console.WriteLine($"For Japnese press \"2\"");
                            Console.Write("Choose a Option : ");

                            if (int.TryParse(Console.ReadLine(), out int option))
                            {
                                switch (option)
                                {
                                    case 1:
                                        Console.WriteLine("You selected English.");
                                        break;
                                    case 2:
                                        Console.WriteLine("You selected Japanese.");
                                        break;
                                    default:
                                        Console.WriteLine("Unknown option selected.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid number choice.");
                            }


                        } else
                        {
                            Console.WriteLine("Password do not match");
                        }
                    } else
                    {
                        Console.WriteLine("Password must 8 or more ");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a password comfirmation.");
                }
            } else
            {
                Console.WriteLine("Please enter a password.");
            }
        }
    }
}
