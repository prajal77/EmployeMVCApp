using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeMVC.Models
{
    public class Designation
    {
        [Key]
        public int Id { get; set; }

        [Column("Designation Name:", TypeName = "varchar(50)")]
        public string Name { get; set; }
    }
}
