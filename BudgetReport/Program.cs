//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using System;
using BudgetReport.Service.Database;
using BudgetReport.Service.Report;
internal class Program
{
    private static void Main(string[] args)
    {
        bool isContinue = true;

        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to, my project");
            Console.WriteLine("1. MySql ");
            Console.WriteLine("2. ModgoDB ");

            Console.Write("Enter your command(1 or 2): ");
            string command = Console.ReadLine();

            if (command.Contains("1") is true)
            {
                IReport budgetReport = new BudgetReportt();
                Console.Clear();
                Console.WriteLine("== MySql ==");
                Console.WriteLine("1. Open");
                Console.WriteLine("2. Save");

                Console.Write("Enter your command(1, 2...): ");
                string commandMySql = Console.ReadLine();

                switch (commandMySql)
                {
                    case "1":
                        var listInfo = budgetReport.Open("Uzbekistan");
                        foreach(var info in listInfo)
                        {
                            System.Console.WriteLine($"{info}");
                        }
                        break;
                    case "2":
                        System.Console.Write("Enter your message: ");
                        string message = Console.ReadLine();
                        budgetReport.Save(message);
                        break;
                }
            }

            if (command.Contains("2") is true)
            {
                IReport budgetReport = new BudgetReportt();
                Console.Clear();
                Console.WriteLine("== MongoDb ==");
                Console.WriteLine("1. Open");
                Console.WriteLine("2. Save");

                Console.Write("Enter your command(1, 2...): ");
                string commandMySql = Console.ReadLine();

                switch (commandMySql)
                {
                    case "1":
                        var listInfo = budgetReport.Open("Uzbekistan");
                        foreach(var info in listInfo)
                        {
                            System.Console.WriteLine($"{info}");
                        }
                        break;
                    case "2":
                        System.Console.Write("Enter your message: ");
                        string message = Console.ReadLine();
                        budgetReport.Save(message);
                        break;
                }
            }

            Console.Write("Is continue(no or yes): ");
            string isContinueCommand = Console.ReadLine();

            if (isContinueCommand.ToLower().Contains("no") is true)
            {
                isContinue = false;
            }
        } while (isContinue is true);
    }
}