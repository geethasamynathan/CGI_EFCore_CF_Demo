using EF_CodeFirst_Demo.Models;

namespace EF_CodeFirst_Demo.Repositories
{
    public interface IDepartmentRepo
    {
        public List<Department> GetAllDepartments();
        public Department GetDepartmentById(int id);
        public Department AddNewDepartment(Department department);
        public Department UpdateDepartment(Department department);
        public string DeleteDepartment(int id);
    }
}
