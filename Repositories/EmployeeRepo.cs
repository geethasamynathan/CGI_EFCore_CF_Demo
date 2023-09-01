using EF_CodeFirst_Demo.Models;

namespace EF_CodeFirst_Demo.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly DepartmentDbContext _context;
        public EmployeeRepo(DepartmentDbContext context)
        {
            _context = context;
        }
        public Employee AddNewEmployee(Employee employee)
        {
           _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public string DeleteEmployee(int id)
        {
            Employee employee = _context.Employees.SingleOrDefault(x => x.Id == id);
            if(employee != null)
            {
                return employee.Name+ " Removed from DB";
            }
            else
            {
                return "No Employee Id Available in the DB";
            }
        }

        public List<Employee> GetAllEmployees()
        {
           return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
           Employee employee= _context.Employees.SingleOrDefault(e => e.Id == id);
            if(employee != null)
            {
                return employee as Employee;
            }
            else
            {
                return null;
            }
        }

        public Employee UpdateEmployee(Employee employee)
        {
            Employee updateEmployee=_context.Employees.SingleOrDefault(e => e.Id==employee.Id);
            if(updateEmployee != null)
            {
                updateEmployee.Name = employee.Name;
                updateEmployee.Salary = employee.Salary;
                updateEmployee.Designation = employee.Designation;
                // updateEmployee.Department.Id = employee.Department.Id;
                _context.SaveChanges();
                return updateEmployee;
            }
            else
            { return null; }
        }
    }
}
