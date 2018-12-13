using System;
using System.Collections.Generic;
using ModelEntities;

namespace Repository.Interface
{
    public interface IEmployeeRepository
    {
       void Add(EmployeeEntities employee);
        List<EmployeeEntities> GetEmployee();
    }
}
