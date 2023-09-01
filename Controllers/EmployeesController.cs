using EF_CodeFirst_Demo.Models;
using EF_CodeFirst_Demo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_CodeFirst_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        readonly IEmployeeRepo _repo;
        public EmployeesController(IEmployeeRepo repo)
        {
            _repo = repo;

        }
        [HttpGet]
        public ActionResult<List<Employee>> GetAllEmployees()
        {
            return Ok(_repo.GetAllEmployees());
        }
        [HttpGet("GetEmployeeById")]
        public ActionResult<List<Employee>> GetAllEmployeeById(int id)
        {
            Employee emp = _repo.GetEmployeeById(id);
            if (emp == null)
            {
                return Ok("No Data available ");
            }
            else
            {
                return Ok(emp);
            }
        }

        [HttpPost]
        public ActionResult<List<Employee>> Post(Employee employee)
        {
            return Ok(_repo.AddNewEmployee(employee));
        }
        [HttpPut]
        public ActionResult<Employee> Update(int id, Employee employee)
        {
            Employee emp = _repo.UpdateEmployee(employee);
            if (emp == null)
            {
                return Ok("No Data available ");
            }
            else
            {
                return Ok(emp);
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok(_repo.DeleteEmployee(id));
        }
    }
}
