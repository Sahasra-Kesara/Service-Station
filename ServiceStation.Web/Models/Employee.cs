using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [StringLength(300)]
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string IsDeleted { get; set; }
    }
}
