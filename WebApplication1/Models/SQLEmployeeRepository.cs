using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBContext context;

        public SQLEmployeeRepository(EmployeeDBContext context)
        {
            this.context = context;
        }
        public void AddNewEmployee(Employee e)
        {
            context.employees.Add(e);
            context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employee e = context.employees.SingleOrDefault(emp => emp.empid == id);
            context.employees.Remove(e);
            context.SaveChanges();
        }

        public Employee GetEmployee(int id)
        {
            return context.employees.SingleOrDefault(emp => emp.empid == id);

        }

        public List<Employee> GetEmployees()
        {
            return context.employees.ToList();
        }
    }
}
