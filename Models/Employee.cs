using System.Text.Json.Serialization;

namespace EF_CodeFirst_Demo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public double Salary {get; set; }
        [JsonIgnore]
        public Department? Department { get; set; }
    }
}
