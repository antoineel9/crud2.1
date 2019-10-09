using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD2._1.Data
{
    public class Manufactures
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Ford { get; set; }
        [Display(Name ="maker")]
        public string Taurus { get; set; }
        [Display(Name = "type")]
        public string FI50 { get; set; }

        [ForeignKey("model")]
        public string 
            Modelnumber { get; set; }
    }
}
