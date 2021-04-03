using System;

namespace Practice_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineerSalary = EmployeeService.CalculateSalary(EmployeeType.Engineer, 2);
            Console.WriteLine(string.Format("Engineer's Salary: {0}", engineerSalary));

            var managerSalary = EmployeeService.CalculateSalary(EmployeeType.Manager, 5);
            Console.WriteLine(string.Format("Manager's Salary: {0}", managerSalary));

            var expertSalary = EmployeeService.CalculateSalary(EmployeeType.Expert, 8);
            Console.WriteLine(string.Format("Expert's Salary: {0}", expertSalary));

            Console.ReadLine();
        }
    }
}
