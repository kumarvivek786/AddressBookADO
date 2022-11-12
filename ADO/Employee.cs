using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data;

namespace ADO
{
    internal class Employee
    {
        public void createDatabase()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=.;
                Initial Catalog=master;Integrated Security=true");
                connection.Open();
                SqlCommand cmd= new SqlCommand("create database Employee",connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee database created");
                connection.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public SqlConnection connection = new SqlConnection(@"Data Source=.;
                Initial Catalog=Employee;Integrated Security=true");
        //public void Createtable()
        //{
        //    try
        //    {
                
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand("create Table Employeedata(Empid int identity(1,1) primary key,Empname varchar(200),salary varchar(200),Age int)", connection);
        //        cmd.ExecuteNonQuery();
        //        Console.WriteLine("Employee Table created");
        //        connection.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //}
        //public void InsertRecord(string name,string salary, int age)
        //{
        //    try
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand("insert into Employeedata values('"+name+"','"+salary+"',"+age+")",connection);
        //        cmd.ExecuteNonQuery();
        //        Console.WriteLine("Record Inserted");
        //        connection.Close();

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //}
        //public void Delete(string name)
        //{
        //    try
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand("delete from Employeedata where Empname='"+name+"'", connection);
        //        cmd.ExecuteNonQuery();
        //        Console.WriteLine("Record Deleted");
        //        connection.Close();

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
        //public void UpdateData(string name,string salary)
        //{
        //    try
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand("update Employeedata set salary='" +salary+"'where Empname='"+name+"'", connection);
        //        cmd.ExecuteNonQuery();
        //        Console.WriteLine("Record Updated");
        //        connection.Close();

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
        //public void RetriveData()
        //{
        //    try
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand("select * from Employeedata", connection);
        //        SqlDataReader sdr = cmd.ExecuteReader();
        //        while (sdr.Read())
        //        {
        //            var id = Convert.ToInt32(sdr["Empid"]);
        //            string name = (string)sdr["Empname"];
        //            string salary = (string)sdr["salary"];
        //            var age = Convert.ToInt64(sdr["Age"]);

        //            Console.WriteLine("Empid=" + id + "|" + "Empname=" + name + "|" + "salary=" + salary + "|" + "Age=" + age);
        //        }
        //        Console.WriteLine("Record retrived");
        //        connection.Close();

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //}
        
    }

}
