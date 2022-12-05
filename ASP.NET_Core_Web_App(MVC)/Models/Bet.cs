using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_App_MVC_.Models
{
    public class Bet
    {
        public int Id { get; set; }
        
        public DateTime Time { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal StartPrice { get; set; }

        public IdentityUser IdentityUsers { get; set; }
        public Product Products { get; set; }
    }
}
