using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        List<Employee> list = new List<Employee>();
        public void AddNewEmployee(Employee e)
        {
            list.Add(e);
        }

        public void DeleteEmployee(int id)
        {
            Employee e = list.SingleOrDefault(emp => emp.empid == id);
            list.Remove(e);
        }

        public Employee GetEmployee(int id)
        {
            return list.SingleOrDefault(emp => emp.empid == id);
        }

        public List<Employee> GetEmployees()
        {
            return list;
        }
    }
}
