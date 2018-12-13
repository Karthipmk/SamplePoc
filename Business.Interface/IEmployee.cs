using ModelEntities;
using System;
using System.Collections.Generic;

namespace Business.Interface
{
    public interface IEmployee
    {
        void add(EmployeeEntities emp);
        void Delete(int id);

        void Update(int id,EmployeeEntities employee);

        List<EmployeeEntities> GetEmployee();
    }
}
