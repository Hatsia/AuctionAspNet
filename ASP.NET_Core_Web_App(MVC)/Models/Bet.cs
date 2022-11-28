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

        public int CustomerId { get; set; }
        
        public int ProductId { get; set; }
        
        public Customer Customer { get; set; }
        
        public Product Product { get; set; }
    }
}
