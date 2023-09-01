using EF_CodeFirst_Demo.Models;

namespace EF_CodeFirst_Demo.Repositories
{
    public interface IEmployeeRepo
    {
        public List<Employee> GetAllEmployees();
        public Employee GetEmployeeById(int id);
        public Employee AddNewEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        public string DeleteEmployee(int id);
    }
}
