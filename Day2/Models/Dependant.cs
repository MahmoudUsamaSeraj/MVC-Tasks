#nullable enable
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    [PrimaryKey("ESSN", "Dependant_Name")]
    public class Dependant
    {
        public int? ESSN { get; set; }
        public string Dependant_Name { get; set; }
        public string Sex { get; set; }
        public DateTime BDate {  get; set; }
        [ForeignKey("ESSN")]
        public virtual Employee employee { get; set; }

    }
}
