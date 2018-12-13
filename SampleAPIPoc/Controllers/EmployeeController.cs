using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelEntities;

namespace SampleAPIPoc.Controllers
{

   

    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        private readonly IEmployee _Iemployee;
        public EmployeeController(IEmployee employee)
        {
            _Iemployee = employee;
        }

        [Authorize]
        // GET: api/Employee
        [HttpGet]
        [Route("GetEmployee")]
        public List<EmployeeEntities> Get()
        {
            return _Iemployee.GetEmployee();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public EmployeeEntities Get(int id)
        {
            List <EmployeeEntities> EmpDetails= new List<EmployeeEntities>();
            EmpDetails = _Iemployee.GetEmployee();
            return EmpDetails.Where(s => s.EmpId == id).FirstOrDefault();
        }


        // POST: api/Employee
        [HttpPost]
        [Route("AddEmployee")]
        public ActionResult Post([FromBody] EmployeeEntities empValue)
        {
            _Iemployee.add(empValue);
            return Ok();
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EmployeeEntities empValue)
        {
            _Iemployee.Update(id, empValue);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
