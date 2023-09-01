using EF_CodeFirst_Demo.Models;
using EF_CodeFirst_Demo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_CodeFirst_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        readonly IDepartmentRepo _repo;
        public DepartmentsController(IDepartmentRepo repo)
        {
            _repo = repo;

        }
        [HttpGet]
        public ActionResult<List<Department>> GetAllDepartments()
        {
            return Ok(_repo.GetAllDepartments());
        }
        [HttpGet("GetDepartmentById")]
        public ActionResult<List<Department>> GetAllDepartmentById(int id)
        {
            Department dept=_repo.GetDepartmentById(id);
            if (dept == null)
            {
                return Ok("No Data available ");
            }
            else
            {
                return Ok(dept);
            }
        }

        [HttpPost]
        public ActionResult<List<Department>> Post(Department department)
        {
            return Ok(_repo.AddNewDepartment(department));
        }
        [HttpPut]
        public ActionResult<Department> Update(int id,Department department)
        {
            Department dept = _repo.UpdateDepartment(department);
            if (dept == null)
            {
                return Ok("No Data available ");
            }
            else
            {
                return Ok(dept);
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok(_repo.DeleteDepartment(id));  
        }
    }
}
