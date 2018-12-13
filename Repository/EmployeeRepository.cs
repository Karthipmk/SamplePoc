using System;
using Repository.Interface;
using ModelEntities;
using Dapper;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class EmployeeRepository :BaseDetails,IEmployeeRepository
    {
        public void Add(EmployeeEntities employee)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@EmpId", employee.EmpId);
                parameters.Add("@Name", employee.Name);
                parameters.Add("@Address", employee.Address);
                parameters.Add("@City", employee.City);
                parameters.Add("@State", employee.State);
                SqlMapper.Execute(con, "AddUser", param: parameters, commandType: CommandType.StoredProcedure);
                // return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EmployeeEntities> GetEmployee()
        {
            try
            {
                string sql = "select EmpId,Name,Address,City,State from EmpAddress";

                using (con)
                {
                    return con.Query<EmployeeEntities>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                throw (ex);
               
            }
        }
    }
}
