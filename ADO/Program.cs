using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //Employeeproc employeeproc = new Employeeproc();
            EmployeeModel emp = new EmployeeModel();
            while (true)
            {
                Console.WriteLine("1:craete database\n2:Create table\n3:insert record\n4:delete record\n5:retrive record\n6:update record\n7 insert stored procedure\n8 Delete stored procedure");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        employee.createDatabase();
                        break;
                    case 2:
                        employee.Createtable();
                       break;
                    case 3:
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter salary:");
                        string salary = Console.ReadLine();
                        Console.WriteLine("Enter age:");
                        int age = Convert.ToInt32(Console.ReadLine());

                        employee.InsertRecord(name, salary, age);
                        break;
                    //case 4:
                    //    Console.WriteLine("enter name");
                    //    string name1=Console.ReadLine();
                    //    employee.Delete(name1);
                    //        break;
                    //case 5:
                    //    employee.RetriveData();
                    //    break;
                    case 6:
                        Console.WriteLine("enter name");
                        string name2 = Console.ReadLine();
                        Console.WriteLine("enter salary");
                        string salary2 = Console.ReadLine();
                        employee.UpdateData(name2, salary2);
                        break;
                        //case 7:
                        //    Console.WriteLine("Enter name:");
                        //    emp.Empname = Console.ReadLine();
                        //    Console.WriteLine("Enter salary:");
                        //    emp.salary = Convert.ToInt32(Console.ReadLine());
                        //    Console.WriteLine("Enter age:");
                        //   emp.Age = Convert.ToInt32(Console.ReadLine());
                        //    employeeproc.InsertRecord(emp);
                        //    break;
                        //case 8:
                        //    Console.WriteLine("Enter name:");
                        //    string name4 = Console.ReadLine();
                        //    employeeproc.delete(name4);
                        //    break;



                }
            }
        }
    }
}
