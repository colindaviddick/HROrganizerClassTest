using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HROrganizerClassTest
{
    public class Employee
    {
        string Name { get; set; }
        string JobTitle { get; set; }
        string BirthMonth { get; set; }
        int StartYear { get; set; }
        int Salary { get; set; }
        bool IsOnHoliday { get; set; }

        public Employee(string name)
        {
            Name = name;
            JobTitle = "Not set";
            BirthMonth = "Not set";
            StartYear = 2020;
            Salary = 15000;
            IsOnHoliday = false;
        }
        public Employee(string name, string jobTitle)
        {
            Name = name;
            JobTitle = jobTitle;
            BirthMonth = "Not set";
            StartYear = 2020;
            Salary = 15000;
            IsOnHoliday = false;
        }
        public Employee(string name, string jobTitle, int startYear, int salary)
        {
            Name = name;
            JobTitle = jobTitle;
            BirthMonth = "Not set";
            StartYear = startYear;
            Salary = salary;
            IsOnHoliday = false;
        }

        public Employee(string name, string jobTitle, string birthMonth, int startYear, int salary, bool isOnHoliday)
        {
            Name = name;
            JobTitle = jobTitle;
            BirthMonth = birthMonth;
            StartYear = startYear;
            Salary = salary;
            IsOnHoliday = isOnHoliday;
        }

        public Employee()
        {

        }

        public class Manager : Employee
        {
            bool HasCompanyCar { get; set; }
            int Bonus { get; set; }

            public Manager(string name, string jobTitle, string birthMonth, int startYear, int salary, bool isOnHoliday, bool hasCompanyCar, int bonus)
            {
                Name = name;
                JobTitle = jobTitle;
                BirthMonth = birthMonth;
                StartYear = startYear;
                Salary = salary;
                IsOnHoliday = isOnHoliday;
                HasCompanyCar = hasCompanyCar;
                Bonus = bonus;
            }
            public override void DisplayEmployee()
            {
            Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("_______ _ _ _  _   _     _");
                Console.WriteLine("|    MANAGER");
                Console.WriteLine("|");
                Console.WriteLine("|  - Name            : " + Name);
                Console.WriteLine("|  - Job Title       : " + JobTitle);
                Console.WriteLine("|  - Birth Month     : " + BirthMonth);
                Console.WriteLine("|  - Start Year      : " + StartYear);
                Console.WriteLine("|  - Salary          : " + Salary);
                if (IsOnHoliday)
                {
                    Console.Write("|  - Is On Holiday?  : ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(IsOnHoliday);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else
                {
                    Console.WriteLine("|  - Is On Holiday?  : " + IsOnHoliday);
                }
                Console.WriteLine("|  - Has Company Car : " + HasCompanyCar);
                Console.WriteLine("|  - Bonus           : " + Bonus);
                Console.WriteLine("|_________ _ _ _  _   _     _");
            Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }

        public virtual void DisplayEmployee()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_______ _ _ _  _   _     _");
            Console.WriteLine("|");
            Console.WriteLine("|  - Name            : " + Name);
            Console.WriteLine("|  - Job Title       : " + JobTitle);
            Console.WriteLine("|  - Birth Month     : " + BirthMonth);
            Console.WriteLine("|  - Start Year      : " + StartYear);
            Console.WriteLine("|  - Salary          : " + Salary);
            if(IsOnHoliday)
            {
                Console.Write("|  - Is On Holiday?  : ");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(IsOnHoliday);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.WriteLine("|  - Is On Holiday?  : " + IsOnHoliday);
            }
            Console.WriteLine("|_________ _ _ _  _   _     _");
        }
    }
}
