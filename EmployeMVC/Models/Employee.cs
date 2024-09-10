using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeMVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Employee Name:", TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Required]
        [Column("Employee Email:", TypeName = "Nvarchar(300)")]
        public string Email { get; set; }

        [Required]
        [Column("Employee Phone Number:", TypeName = "varchar(10)")]
        public string PhoneNo { get; set; }

        [Required]
        [Column("Employee Address:", TypeName = "varchar(30)")]
        public string Address { get; set; }

        [ValidateNever]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        [ValidateNever]
        public Department Department { get; set; }

        [ValidateNever]
        public int DesignationId { get; set; }
        [ForeignKey("DesignationId")]
        [ValidateNever]
        public Designation Designation { get; set;}
    }
}
