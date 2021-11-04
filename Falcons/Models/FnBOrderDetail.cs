using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class FnBOrderDetail
    {
        [Key]
        public int ID { get; set; }

        public virtual FnBOrder FnBOrder { get; set; }

        public virtual Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int ProductPrice { get; set; }

    }
}
