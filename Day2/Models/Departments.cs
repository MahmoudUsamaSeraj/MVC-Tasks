using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable enable
namespace Day2.Models
{
    public class Departments
    {
        public string Dname { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Dnum { get; set; }
        [ForeignKey("manager")]
        public int? MGRSSN {  get; set; }
        public DateTime MGRStartDate {  get; set; }
        [InverseProperty("Worksdepartment")]
        public virtual List<Employee> employees { get; set; } = new List<Employee>();
        [InverseProperty("Managesdepartment")]
        public virtual Employee manager { get; set; }
        public virtual List<Project> projects { get; set; } = new List<Project>();




    }
}
