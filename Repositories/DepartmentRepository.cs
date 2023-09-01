using EF_CodeFirst_Demo.Models;

namespace EF_CodeFirst_Demo.Repositories
{
    public class DepartmentRepository : IDepartmentRepo
    {
        readonly DepartmentDbContext _context;
        public DepartmentRepository(DepartmentDbContext context)
        {
            _context = context;
        }
        public Department AddNewDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return department;           
        }

        public string DeleteDepartment(int id)
        {
            Department deleteDepartment=_context.Departments.Where(d => d.Id== id).FirstOrDefault();
            if (deleteDepartment!=null)
            {
                _context.Departments.Remove(deleteDepartment);
                _context.SaveChanges();
                return "Given Department Id Removed from Database";
            }
            else
            {
                return "Given Department Id is not available in Database";
            }
            
        }

        public List<Department> GetAllDepartments()
        {
            return _context.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
          
            Department department=_context.Departments.Where(d => d.Id== id).FirstOrDefault();
            if (department != null)
            {
                return department;
            }
            else
            {
                return null; 
            }
        }

        public Department UpdateDepartment(Department department)
        {
            Department newDepartment = _context.Departments.Where(d =>d.Id== department.Id).FirstOrDefault();
            if (newDepartment != null)
            {
                newDepartment.Name = department.Name;
                newDepartment.Location = department.Location;
                newDepartment.Head = department.Head;
                _context.SaveChanges();
                return newDepartment;
            }
            else
            {
                return null
            }
            
        }
    }
}
