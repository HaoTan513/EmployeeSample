using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            using (HREntities context = new HREntities())
            {
                employee emp1 = new employee
                {
                    FirstName = "Hao",
                    Title = "CEO"
                };

                employee emp2 = new employee
                {
                    Id = 1,
                    FirstName = "Xiao",
                    Title = "VP"
                };

                employee emp3 = new employee
                {
                    Id = 2,
                    FirstName = "Wang",
                    Title = "Director"
                };

                //context.employees.Add(emp1);

                //context.employees.Add(emp2);

                //context.employees.Add(emp1);
                //context.SaveChanges();
                
            }
        }
    }
}
