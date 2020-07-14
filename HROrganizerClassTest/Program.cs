using System;
using System.Collections.Generic;

namespace HROrganizerClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Employee colin =    new Employee("Colin Dick", "Animal Technician", "November", 2012, 21000, false);
            Employee samantha = new Employee("Samantha Clabby", "Baker", "October", 2008, 12000, false);
            Employee ayla =     new Employee.Manager("Ayla Guler", "Manageress", "August", 2016, 35000, false, true, 5000);
            Employee victoria = new Employee("Victoria Clabby");
            Employee david =    new Employee("David Dick", "Brewery Worker", 1980, 26000);
            Employee muriel =   new Employee("Muriel Dick", "Saleswoman");
            Employee elma =     new Employee.Manager("Elma Guler", "Deputy Manager", "September", 2018, 23000, true, true, 10000);
            Employee jamie =    new Employee("Jamie Clabby", "Teacher", 2000, 24000);
            Employee jacqui =   new Employee("Jacqui Clabby", "Archaeologist", "October", 2000, 30000, true);
            Employee jennifer = new Employee("Jennifer Guler", "Child Minder");
            Employee gunay =    new Employee("Gunay Guler", "Barber", 2016, 19000);

            employees.Add(colin);
            employees.Add(samantha);
            employees.Add(ayla);
            employees.Add(elma);
            employees.Add(victoria);
            employees.Add(david);
            employees.Add(muriel);
            employees.Add(jamie);
            employees.Add(jennifer);
            employees.Add(gunay);
            employees.Add(jacqui);

            foreach(Employee e in employees)
            {
                e.DisplayEmployee();
            }
            Console.Read();
        }
    }
}
