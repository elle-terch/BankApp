﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**********************");
            Console.WriteLine("Welcome to the bank!");
            Console.WriteLine("**********************");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Print all accounts");

            Console.Write("Please choose one option from above: ");
            var choice = Console.ReadLine();

            switch(choice)

            {
                case "0":
                    Console.WriteLine("Thank you for visiting");
                    return;
                case "1":
                    Console.Write("Please provide your email address:");
                    var emailAddress = Console.ReadLine();
                    Console.Write("PLease provide your account name:");
                    var accountName = Console.ReadLine();
                    Console.WriteLine("Please choose your account type");
                    var typeOfAccounts = Enum.GetNames(typeof(TypeOfAccount));
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    break;
            }

        }
    }
}
