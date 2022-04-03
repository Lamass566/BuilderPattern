using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new()
            {
                new Employee { Name = "Ivan", Salary = 100 },
                new Employee { Name = "Boris", Salary = 200 },
                new Employee { Name = "Fedor", Salary = 300 }
            };

            var builder = new EmployeeReportBuilder(employees);
            //var director = new EmployeeReportDirector(builder);

            //director.Build();
            builder.Build();
            var report = builder.GetReport();
            Console.WriteLine(report);
            Console.ReadKey();
        }
    }
}
