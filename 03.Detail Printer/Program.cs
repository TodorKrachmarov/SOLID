namespace _03.Detail_Printer
{
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            list.Add("rgsadfsdf");
            list.Add("uthdfgwerwerfe");
            list.Add("564351351gr");
            Employee emp = new Employee("Gosho");
            Employee man = new Manager("Pesho", list);
            List<Employee> emps = new List<Employee>();
            emps.Add(emp);
            emps.Add(man);
            emps.Add(emp);
            emps.Add(emp);
            emps.Add(man);
            DetailsPrinter printer = new DetailsPrinter(emps);
            printer.printDetails();
        }
    }
}
