using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_App_MVC_.Models
{
    public class Request
    {
        [Key]
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public IdentityUser IdentityUsers { get; set; }
        public Product Products { get; set; }
    }
}
