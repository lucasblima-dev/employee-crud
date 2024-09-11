using System.ComponentModel.DataAnnotations;
using CrudApi.Enums;

namespace CrudApi.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DepartmentEnum Department { get; set; }
        public bool Active { get; set; }
        public TurnEnum Turn { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime ChangeDate { get; set; } = DateTime.Now.ToLocalTime();
    }
}