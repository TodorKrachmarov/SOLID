namespace _03.Detail_Printer
{
    using System;
    using System.Collections.Generic;

    public class DetailsPrinter
    {
        private IList<Employee> employees;

        public DetailsPrinter(IList<Employee> employees)
        {
            this.employees = employees;
        }

        public void printDetails()
        {
            foreach (Employee employee in this.employees)
            {
                this.PrintEmployee(employee);
            }
        }

        private void PrintEmployee(Employee employee)
        {
            Console.WriteLine(employee);
        }
    }
}