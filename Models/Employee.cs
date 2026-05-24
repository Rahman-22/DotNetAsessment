using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetAsessment.Models
{
    [Table("employee_biodata")]
    public class Employee
    {
        [Key]
        [Column("employee_no")]
        public string EmployeeNo { get; set; }

        [Column("employee_name")]
        public string EmployeeName { get; set; }

        [Column("birth_date")]
        public DateTime BirthDate { get; set; }
    }
}