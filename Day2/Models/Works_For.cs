#nullable enable
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    [PrimaryKey("ESSN", "Pno")]
    public class Works_For
    {
        public int? ESSN { get; set; }
        public int? Pno { get; set; }
        public int? Hours { get; set; }
        [ForeignKey("ESSN")]
        public virtual Employee employee { get; set; }
        [ForeignKey("Pno")]
        public virtual Project project { get; set; }


    }
}
