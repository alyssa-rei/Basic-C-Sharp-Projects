using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creating a list of employees that include their
            // Id, First Name, and Last Name.
            List<Employee> employeesList = new List<Employee>();

            Employee emp1 = new Employee(01, "Joe", "DiMaggio");
            Employee emp2 = new Employee(02, "Babe", "Ruth");
            Employee emp3 = new Employee(03, "Hank", "Aaron");
            Employee emp4 = new Employee(04, "Sandy", "Koufax");
            Employee emp5 = new Employee(05, "Joe", "Morgan");
            Employee emp6 = new Employee(06, "Jackie", "Robinson");
            Employee emp7 = new Employee(07, "Roberto", "Clemente");
            Employee emp8 = new Employee(08, "Ted", "Williams");
            Employee emp9 = new Employee(09, "Ichiro", "Suzuki");
            Employee emp10 = new Employee(10, "Rickey", "Henderson");

            employeesList.Add(emp1);
            employeesList.Add(emp2);
            employeesList.Add(emp3);
            employeesList.Add(emp4);
            employeesList.Add(emp5);
            employeesList.Add(emp6);
            employeesList.Add(emp7);
            employeesList.Add(emp8);
            employeesList.Add(emp9);
            employeesList.Add(emp10);
            
            // Creating a list of employees with the First
            // Name of "Joe".
            foreach (Employee employee in employeesList)
            {
                var id = employee.Id;
                var fname = employee.FirstName;
                var lname = employee.LastName;

                if (employee.FirstName == "Joe")
                {
                    List<Employee> nameList = new List<Employee>();
                    Employee jName = new Employee(id, fname, lname);
                    nameList.Add(jName);
                    Console.Write("\n" + id + " " + fname + " " + lname);
                }
            }

            // Using a Lambda expression to create a list of employees
            // with the First Name of "Joe".
            List<Employee> employeeList2 = employeesList.Where(x => x.FirstName == "Joe").ToList();

            // Using a Lambda expression to create a list of employees
            // with an Id number greater than "5".
            List<Employee> idList = employeesList.Where(x => x.Id > 5).ToList();

            Console.ReadLine();
        }
    }
}
