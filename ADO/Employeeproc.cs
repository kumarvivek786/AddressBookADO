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
    //public class Employeeproc
    //{
    //    public SqlConnection connection = new SqlConnection(@"Data Source=.;
    //            Initial Catalog=Employee;Integrated Security=true");
       
    //    public void InsertRecord(EmployeeModel emp)
    //    {
    //        try
    //        {
    //            connection.Open();
    //            SqlCommand cmd = new SqlCommand("InsertRecord", connection);
    //            cmd.CommandType = CommandType.StoredProcedure;
    //            cmd.Parameters.AddWithValue("@name", emp.Empname);
    //            cmd.Parameters.AddWithValue("@salary", emp.salary);
    //            cmd.Parameters.AddWithValue("@age", emp.Age);
    //            cmd.ExecuteNonQuery();
    //            Console.WriteLine("record inserted");
    //            connection.Close();


                

    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e.Message);
    //        }

    //    }
    //    public void delete(string name)
    //    {
    //        try
    //        {
    //            connection.Open();
    //            SqlCommand cmd = new SqlCommand("DeleteRecord", connection);
    //            cmd.CommandType = CommandType.StoredProcedure;
    //            cmd.Parameters.AddWithValue("@name", name);
    //            cmd.ExecuteNonQuery();
    //            Console.WriteLine("record deleted");
    //            connection.Close();
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e.Message);
    //        }

    //    }

    //}
}
