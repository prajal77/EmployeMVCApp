using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeMVC.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Column("Department Name:", TypeName = "varchar(50)")]
        public string Name { get; set; }
    }
}
