using Business.Interface;
using System;
using ModelEntities;
using System.Collections.Generic;
using Repository.Interface;
using System.Linq;

namespace Business
{
    public class Employee : IEmployee
    {
        private readonly IEmployeeRepository _IEmployeeRep;

        public Employee(IEmployeeRepository IEmployeeRep)
        {
            _IEmployeeRep = IEmployeeRep;
        }

        /// <summary>
        /// Add Employee Dateils from Based on Business Logic
        /// </summary>
        /// <param name="employee"></param>
        public void add(EmployeeEntities employee)
        {
            try
            {
                _IEmployeeRep.Add(employee);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        /// <summary>
        /// Delete Employee Based on Business Logic
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get Employees Based On Business Logic
        /// </summary>
        /// <returns></returns>
        public List<EmployeeEntities> GetEmployee()
        {
            return _IEmployeeRep.GetEmployee();
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Update Employee Based on Business Logic
        /// </summary>
        /// <param name="employee"></param>
        public void Update(int id,EmployeeEntities employee)
        {
            try
            {
                List<EmployeeEntities> lstEmp = new List<EmployeeEntities>();
                EmployeeEntities employeeEntities = new EmployeeEntities();
                lstEmp = _IEmployeeRep.GetEmployee();

                if (lstEmp.Count > 0)
                {
                    employeeEntities = lstEmp.Where(s => s.EmpId == id).FirstOrDefault();
                    if (employeeEntities != null)
                    {
                        employeeEntities.Name = employee.Name;
                        employeeEntities.Address = employee.Address;
                        employeeEntities.City = employee.City;
                        employeeEntities.State = employee.State;
                        _IEmployeeRep.Add(employeeEntities);
                    }
                }
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }
    }
}
