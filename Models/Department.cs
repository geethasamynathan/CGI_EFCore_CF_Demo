﻿namespace EF_CodeFirst_Demo.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Head { get; set; }
        public IEnumerable<Employee>? Employees { get; set;}

    }
}
