﻿using System;
using MySharedLibrary;
namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Get email input from the user.
                Console.Write("Enter your email address: ");
                string email = Console.ReadLine();

                if (MySharedLibrary.Class1.IsValidEmailAddress(email))
                {
                    Console.WriteLine($"Email '{email}' is valid.");
                }
                else
                {
                    Console.WriteLine($"Email '{email}' is invalid.");
                }

                // Get username input from the user.
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();

                if (MySharedLibrary.Class1.IsValidUsername(username))
                {
                    Console.WriteLine($"Username '{username}' is valid.");
                }
                else
                {
                    Console.WriteLine($"Username '{username}' is invalid.");
                }

                // Get password input from the user.
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (MySharedLibrary.Class1.IsValidPassword(password))
                {
                    Console.WriteLine("Password is valid.");
                }
                else
                {
                    Console.WriteLine("Password is invalid. Password must be at least 8 characters long.");
                }

            Console.ReadKey();
            }
        }
    }
