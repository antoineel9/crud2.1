using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD2._1.Data
{
    public class Cars
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CID { get; set; }

        [Display(Name = "Car Color")]
        public string Colors { get; set; }
        public int MyProperty { get; set; }

    }
}
