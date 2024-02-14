#nullable enable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    public class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        [Key]
        public int SSN { get; set; }
        public DateTime BDate { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        [Column(TypeName ="money")]
        public decimal? Salary { get; set; }
        public int? SuperSSN { get; set; }
        [ForeignKey("Worksdepartment")]
        public int? Dno { get; set; }

        [ForeignKey("SuperSSN")]
        public virtual Employee SuperVisor { get; set; }
        [InverseProperty("SuperVisor")]
        public virtual List<Employee> employees { get; set; } = new List<Employee>();
        public virtual List<Dependant> dependants { get; set; } = new List<Dependant>();
        public virtual List<Works_For> works_for { get; set; } = new List<Works_For>();


        public virtual Departments Worksdepartment { get; set; }
        public virtual Departments Managesdepartment { get; set; }


    }
}
