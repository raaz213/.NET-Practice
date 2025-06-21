// swapping integers (value types)
//Value types directly contain their data and are stored in the stack memory. When you assign a value type to another variable, a copy of the data is created.
using System;

class Program
{
    static void Main(string[] args)
    {
        
        int a = 5;
        int b = 10;

        Console.WriteLine($"Before swapping: a = {a}, b = {b}");
        SwapIntegers( a,  b);
        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }

    static void SwapIntegers( int x,  int y)
    {
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"Inside Method: a = {x}, b = {y}");
    }
}
/** However, the issue with this code is that it attempts to swap the values of a and b within the SwapIntegers method, but it doesn't affect the original variables a and b in the Main method. This is because the method is called with the values of a and b, which are passed by value, meaning that the method works with copies of a and b, not the original variables. Therefore, the swapping occurs within the method's scope, but it doesn't reflect outside the method. To achieve the desired result, you can pass the variables by reference using the ref keyword, as demonstrated in the previous solution.


 **/
//reference type
//Reference types store a reference (memory address) to the memory location where the actual data is stored. When you assign a reference type to another variable, both variables refer to the same data in memory.
using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        Console.WriteLine($"Before swapping: a = {a}, b = {b}");
        SwapIntegers(ref a, ref b);
        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }

    static void SwapIntegers(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"Inside Method: a = {x}, b = {y}");
    }
}

// multicast delegate
using System;
delegate int calculator(int a, int b);
class Program
{
    public static int sum(int a, int b)
    {
        int s = a + b;
        return s;
    }
    public static int sub(int a, int b)
    {
        int s = a - b;
        return s;
    }

    public static void Main(string[] args)
    {
        calculator c1 = new calculator(sum);
        calculator c2 = new calculator(sub);
        calculator c3 = c1 + c2;
        int result = c3(10, 20);
        Console.WriteLine(result);
        c3 = c3 - c2;
        result = c3(10, 20);
        Console.WriteLine(result);
    }
}


//LINQ
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{

    public static void Main(string[] args)
    {
        List<string> list = new List<string>() { "a", "b", "c", "d" };
        var result = from item in list where item.Contains("a") select item;
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}

//Lambda expression
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{

    public static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        var result = list.FindAll(x => x % 2 == 0);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
//2020 past question no. 11 a
using System;
using System.Collections.Generic;
using System.Linq;
class Employees
{
    public string Name { get; set; }
    public string Address { get; set; }
    public double Salary { get; set; }
}
class Program
{

    public static void Main(string[] args)
    {
        List<Employees> list = new List<Employees>(){
        new Employees {Name="raj",Address="Kathmandu",Salary=40000},
          new Employees {Name="ram",Address="Damak",Salary=5000},
              new Employees {Name="rajesh",Address="Kathmandu",Salary=50000},

      };
        var result = list.Where(x => x.Salary > 20000 && x.Address == "Kathmandu");
        foreach (var item in result)
        {
            Console.WriteLine(item.Name + " " + item.Address + " " + item.Salary);
        }
    }
}
//2022 9 b
using System;
using System.Linq;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}

class Program
{
    static void Main()
    {
        // Define a list of employee records
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Alice", Salary = 50000 },
            new Employee { Name = "Bob", Salary = 60000 },
            new Employee { Name = "Charlie", Salary = 55000 },
            new Employee { Name = "David", Salary = 70000 },
            new Employee { Name = "Eve", Salary = 45000 }
        };

        // Compute aggregate salary using Aggregate operator
        int totalSalary = employees.Aggregate(0, (acc, emp) => acc + emp.Salary);

        Console.WriteLine($"Total Salary of 5 Employees: {totalSalary}");

        // Display employee records in descending order of salary
        var sortedEmployees = employees.OrderByDescending(emp => emp.Salary);

        Console.WriteLine("\nEmployee Records in Descending Order of Salary:");
        foreach (var emp in sortedEmployees)
        {
            Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
        }
    }
}

//orderBy asceding
using System;
using System.Collections.Generic;
using System.Linq;
class Employees
{
    public string Name { get; set; }
    public string Address { get; set; }
    public double Salary { get; set; }
}
class Program
{

    public static void Main(string[] args)
    {
        List<Employees> list = new List<Employees>(){
        new Employees {Name="raj",Address="khorsane",Salary=40000},
          new Employees {Name="ram",Address="Damak",Salary=5000},
              new Employees {Name="rajesh",Address="Kathmandu",Salary=50000},

      };
        var result = list.OrderBy(x => x.Salary);//OrderBydescending->for descending
        foreach (var item in result)
        {
            Console.WriteLine(item.Name + " " + item.Address + " " + item.Salary);
        }
    }
}
//group by
using System;
using System.Collections.Generic;
using System.Linq;
class Employees
{
    public string Name { get; set; }
    public string Address { get; set; }
    public double Salary { get; set; }
}
class Program
{

    public static void Main(string[] args)
    {
        List<Employees> list = new List<Employees>(){
        new Employees {Name="raj",Address="Kathmandu",Salary=40000},
          new Employees {Name="ram",Address="Damak",Salary=5000},
              new Employees {Name="rajesh",Address="Kathmandu",Salary=50000},
          new Employees {Name="Hari",Address="Damak",Salary=500000},
      };
        var result = list.GroupBy(x => x.Address);
        foreach (var item in result)
        {
            foreach (var i in item)
            {
                Console.WriteLine(i.Name + " " + i.Address + " " + i.Salary);
            }

        }
    }
}
//Aggregate function
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{

    public static void Main(string[] args)
    {
        List<int> list = new List<int>() { 10, 20, 30, 40, 50 };
        int max = list.Max();
        int min = list.Min();
        int sum = list.Sum();
        int count = list.Count();
        double average = list.Average();
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine(sum);
        Console.WriteLine(count);
        Console.WriteLine(average);
    }
}
// 2022 . 9.b. Write a C# program to compute aggregate salary of 5 employee and then display employee record in descending order with respect to employee salary using LINQ.
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Define a class to represent Employee
        class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }
        }

        // Create a list of Employee objects
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Alice", Salary = 50000 },
            new Employee { Name = "Bob", Salary = 60000 },
            new Employee { Name = "Charlie", Salary = 55000 },
            new Employee { Name = "David", Salary = 70000 },
            new Employee { Name = "Eve", Salary = 48000 }
        };

        // Calculate the aggregate salary of all employees
        double totalSalary = employees.Sum(emp => emp.Salary);
        Console.WriteLine($"Total Salary of all employees: {totalSalary}");

        // Display employee records in descending order of salary
        var sortedEmployees = employees.OrderByDescending(emp => emp.Salary);
        Console.WriteLine("\nEmployee records in descending order of salary:");
        foreach (var emp in sortedEmployees)
        {
            Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
        }
    }
}

//working with databse
//1. creating connection and command
using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        //address of sql server and database
        string path = "Server=.\\SQLEXPRESS;Database=raj;Integrated Security=True";
        //establish connection
        SqlConnection con = new SqlConnection(path);
        //open connection
        con.Open();
        //preapare query
        string sql = "insert into data(id,name,age) values(2,'raj',20),(3,'rajesh',30)";
        //execute query
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.ExecuteNonQuery();
        //close connection
        con.Close();

    }
}
//2020 11.b WAP Program to show insert and select opertion in database
using System;
using System.Data.SqlClient;

namespace ADO.NET
{
    internal class raj
    {
        static void Main()
        {
            string path = "Server=.\\SQLEXPRESS;Database=raj;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);

            // Insert operation
            string insertSql = "INSERT INTO data(id, name, age) VALUES (2, 'raj', 20), (3, 'rajesh', 30)";
            try
            {
                con.Open();
                SqlCommand Cmd = new SqlCommand(insertSql, con);
                int Rows = Cmd.ExecuteNonQuery();
                Console.WriteLine($"{Rows} rows inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Insert error: " + ex.Message);
            }

            // Select operation
            string selectSql = "SELECT * FROM data";
            try
            {
                SqlCommand Cmd = new SqlCommand(selectSql, con);
               var reader = Cmd.ExecuteReader();
                Console.WriteLine("Selected data:");
                while (reader.Read())
               {
                    Console.WriteLine($"Id: {reader["id"]}, Name: {reader["name"]}, Age: {reader["age"]}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Select error: " + ex.Message);
            }

            con.Close();
            Console.ReadLine();
        }
    }
}

//CRUD operation
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
    public class student
    {
        public int sid { get; set; } 
        public string name { get; set; }    
        public string address { get; set; }
        public string email { get; set; }

        public student(int sid, string name, string address, string email)
        {
            this.sid = sid;
            this.name = name;   
            this.address = address; 
            this.email = email; 
        }
    }
    internal class crud
    {
       public static SqlConnection con;
        public static void createCon()
        {
            string path = "Data Source=.\\SQLEXPRESS; Initial Catalog=college; Integrated Security=True";
            con = new SqlConnection(path);
            con.Open();
        }
        public static void insertData(int sid, string name, string address, string email)
        {
            createCon();
            string sql = $"insert into student(sid,name,address,email) values({sid},'{name}','{address}','{email}')";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine($"rows inserted:{rows}");
            }
            catch (SqlException ex) {
                Console.WriteLine(ex.Message);
            
            }
            Console.ReadLine();
            con.Close();
        }
        public static void readData()
        {
            createCon();
            string sql = "select * from student";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader(); 
            while (reader.Read())
            {
                Console.WriteLine($"sid={reader["sid"]},name={reader["name"]},address={reader["address"]},email{reader["email"]} ");
            }
            Console.ReadLine();
            con.Close();
        }
        public static void updateData(int sid, string name, string address)
        {
            createCon();
            string sql = $"update student set name='{name}',address='{address}' where sid={sid}";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine($"rows updated:{rows}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadLine();
            con.Close();
        }
        public static void deleteData(int sid)
        {
            createCon();
            string sql = $"delete from student where sid={sid}";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine($"rows Deleted:{rows}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadLine();
            con.Close();
        }
        public static void Main(string[] args)
        {
            createCon();
            List<student> list = new List<student>()
            {
                new student(1,"Ramesh","Drn","ramesh@gmail.com"),
                new student(2,"Ram","Dmk","ram@gmail.com"),
                new student(3,"Rajesh","Ktm","rajesh@gmail.com")
            };
            foreach (var item in list)
            {

                insertData(item.sid, item.name, item.address, item.email);

            }
            readData();
            updateData(1,"Raj","Tpj");
            readData();
            deleteData(2);
            readData();
            Console.ReadLine();
        }
    }

//ASP.NET
//2022 9.b WAP for handling exception in ASP.NET
using System;

namespace ASP.NET1
{
    public partial class ExceptionHandling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // Simulate a potential exception
                int res = 10 / 0; // This will throw a DivideByZeroException
                result.Text = "Result:" + res;
            }
            catch (Exception ex)
            {
                // Handle the exception
                result.Text = "An error occurred: " + ex.Message;
            }
        }
    }
}