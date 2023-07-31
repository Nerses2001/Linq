using System;
using System.Collections.Generic;

using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Salary = 1000,
                    StartDate = DateTime.Parse("1/4/2010")
                },
                new Employee
                {
                    FirstName = "FirstName1",
                    LastName = "LastName1",
                    Salary = 10000,
                    StartDate = DateTime.Parse("1/4/1900")
                },
                new Employee
                {
                    FirstName = "FirstName2",
                    LastName = "LastName2",
                    Salary = 10000,
                    StartDate = DateTime.Parse("8/7/2023")
                },
                new Employee
                {
                    FirstName = "FirstName3",
                    LastName = "LastName3",
                    Salary = 2050000,
                    StartDate = DateTime.Parse("10/4/800")
                },
                new Employee
                {
                    FirstName = "FirstName4",
                    LastName = "LastName4",
                    Salary = 10000,
                    StartDate = DateTime.Parse("1/4/2010")
                },
                new Employee
                {
                    FirstName = "FirstName5",
                    LastName = "LastName5",
                    Salary = 10000,
                    StartDate = DateTime.Parse("1/4/2010")
                },
            };
            var query1 = from emp in employees
                        where emp.Salary> 1000
                        orderby emp.StartDate
                        select new 
                        {
                            LastName = emp.FirstName,
                            First = emp.LastName,
                            Salary = emp.LastName,
                            Date = emp.StartDate,
                        };
            var query2 = employees.Where(x=> x.Salary > 1000)
                .OrderBy(x => x.StartDate)
                .ThenByDescending(x=> x.Salary).
                Select(x=> new 
                {
                    LastName = x.FirstName,
                    First = x.LastName,
                    Salary = x.LastName,
                    Date = x.StartDate,
                }
            );
           

            foreach (var emp in query1)
            {
                Console.WriteLine(emp.First);
                Console.WriteLine(emp.LastName);
                Console.WriteLine(emp.Salary);
                Console.WriteLine(emp.Date);

            }
            Console.WriteLine(new string('_',30));
            foreach (var emp in query2)
            {
                Console.WriteLine(emp.First);
                Console.WriteLine(emp.LastName);
                Console.WriteLine(emp.Salary);
                Console.WriteLine(emp.Date);

            }
            Console.WriteLine(new string('_', 30));
           
            Console.ReadLine();
        }
    }
}
