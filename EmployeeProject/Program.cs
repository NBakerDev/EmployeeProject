using System;
using EmployeeLibrary;
using System.Collections.Generic;

namespace EmployeeProject {
    class Program {
        static void Main(string[] args) {
            var mgr1 = new Manager("John", "DevOps", 150000M, 8);
            var mgr2 = new Manager("Joe", "DataAdmin", 150000M, 8);

            var emp1 = new Employee("Chris", "JrDev", 55000M);
            var emp2 = new Employee("Jane", "JrDev", 55000M);
            Console.WriteLine(mgr1.Print());

            var emps = new List<Employee>() { emp1, emp2, mgr1, mgr2 };
            foreach(var emp in emps) {
                Console.WriteLine(emp.Print());
            }
        }
    }
}
