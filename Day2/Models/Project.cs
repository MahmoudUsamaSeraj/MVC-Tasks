#nullable enable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Pnum { get; set; }
        public string Pname { get; set; }
        public string Plocation { get; set; }
        public string City { get; set; }
        public int? Dnum { get; set; }
        [ForeignKey("Dnum")]
        public virtual Departments department { get; set; }
        public virtual List<Works_For> works_for { get; set; } = new List<Works_For>();



    }
}
