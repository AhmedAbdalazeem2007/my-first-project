using Comments;
using Microsoft.EntityFrameworkCore;
using My_practices.Context;
using My_practices.Entrities;
using System.Collections;
using System.Security.Cryptography;

namespace My_practices
{
    class ass
    {
        public int x;
        public ass()
        {
            this.x = 0;
        }
    }
    
    internal class Program
    {
        public readonly int x;
        public static void print<T>(T i)
        {
            
            Console.WriteLine(i);
        }
      static  public T get_<T>(T i)
        {
            return i;
        }
      //public static void asdf(double int b)
      //  {
      //      Console.WriteLine(b);
      //  }
        static void Main(string[] args)
        {
            ass m=new ass();
            
            char a = '\u0050';
            
            Console.WriteLine(a);
            ICollection<int> ints = new List<int>();
            int[] A = { 7, 6, 5, 4, 3, 2, 1 };
            
            print(9);
            print("jjijk");
            Console.WriteLine(get_(9));

            /*CompanyDBcontext companyDBcontext = new CompanyDBcontext();
                Employee employee = new Employee() { Name = "jkj", Sal = 30, Age = 29, Email = "kjodfsl" };
                //Console.WriteLine(companyDBcontext.Entry(employee).State);
                companyDBcontext.Employees.Add(employee);
               dbcontext1.Set<Employee>().Add(employee1);
          dbcontext1.Add(employee1);
          dbcontext1.Entry(employee).State = EntityState.Added;
                companyDBcontext.SaveChanges();
                //companyDBcontext.Employees;
                // companyDBcontext.Database.Migrate();


                companyDBcontext.Dispose();
              */

            //List<Employee> employees = new List<Employee>(2);
            //Console.WriteLine(employees.Sum((i) => i.Id));
            //// Console.WriteLine(employees.Average((i) => i.Id));
            //// Console.WriteLine(employees.First((i) => i.Id==0));
            //Console.WriteLine(employees.SingleOrDefault((i) => i.Id == 1));
            //double a = 4332545.67;
            //Console.WriteLine($"{a:c}");
            //var p = employees.MaxBy((i) => i.Id);
            //Console.WriteLine(p);
            
            //foreach(var i in p)
            //{
            //    Console.WriteLine(i.ToString());
            //}
            //List<int> pp = list.Where((x) => x % 2 == 0 && x != 4).ToList();

            /*      string x = "12m3";
                  bool flag = int.TryParse(x, out int y);
                  Console.WriteLine(y);*/







            Console.ReadKey();
        }
    }
}
