﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        List<Employee> GetEmployees();
        void AddNewEmployee(Employee e);

        void DeleteEmployee(int id);

    }
}
