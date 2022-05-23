using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADOExampleApp
{
    class Program
    {
        SqlConnection con;
        public Program()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            //con.Open();
            //Console.WriteLine("Connect to database");
        }
        void ReadUsingConnected()
        {
            SqlCommand cmd = new SqlCommand("select * from tblEmployee", con);
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine("Employee Id : "+dataReader[0].ToString());
                Console.WriteLine("Employee Name : " + dataReader[1].ToString());
                Console.WriteLine("Employee Age : " + dataReader[2].ToString());
                Console.WriteLine("Employee Salary : " + dataReader[3].ToString());
                Console.WriteLine("-------------------------------");
            }
            con.Close();
        }
        void InsertEmployee()
        {
            Employee emp = GetEmployeeDataFromUSer();
            SqlCommand cmd = new SqlCommand("insert into tblEmployee(name,age,salary) values(@ename,@eage,@esal)", con);
            cmd.Parameters.Add("@ename", SqlDbType.VarChar, 20);
            cmd.Parameters[0].Value = emp.Name;
            cmd.Parameters.AddWithValue("@eage", emp.Age);
            cmd.Parameters.AddWithValue("@esal", emp.Salary);
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if(result>0)
                Console.WriteLine("Employee inserted");
            else
                Console.WriteLine("Some error. Employee not inserted");

        }
        void UpdateEmployee()
        {
            SqlCommand cmd = new SqlCommand("proc_UpdateSalary", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid",101 );
            cmd.Parameters.AddWithValue("@esal", 50000);
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result > 0)
                Console.WriteLine("Employee salary updated");
            else
                Console.WriteLine("Some error. Could not update employee data");

        }
        Employee GetEmployeeDataFromUSer()
        {
            Employee employee = new Employee();
            Console.WriteLine("Please enter the employee name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            employee.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            employee.Salary = float.Parse(Console.ReadLine());
            return employee;
        } 
        void ReadUsingDisConnected()
        {
            Console.WriteLine("Disconnected");
            SqlCommand cmd = new SqlCommand("select * from tblEmployee", con);
            if (con.State == ConnectionState.Open)
                con.Close();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);//connect to database->Fetch the data->put it in the dataset-> disconnect
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine("Employee Id : " + dr[0].ToString());
                Console.WriteLine("Employee Name : " + dr[1].ToString());
                Console.WriteLine("Employee Age : " + dr[2].ToString());
                Console.WriteLine("Employee Salary : " + dr[3].ToString());
                Console.WriteLine("-------------------------------");
            }
            con.Close();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.UpdateEmployee();
            Console.ReadKey();
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
    }
}
