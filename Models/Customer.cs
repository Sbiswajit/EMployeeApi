using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMployeeApi.Models
{[Table("Customer")]
    public class Customer
    {[Key]
        public int Cid { get; set; }
        public string Cname{ get; set; }
        public DateTime dob{ get; set; }
        [MaxLength(4)]
        public int Pin { get; set; }
    }
}
