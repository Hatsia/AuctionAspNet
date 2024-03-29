﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_App_MVC_.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int StartPrice { get; set; }

        public string Img { get; set; }

        public DateTime EndTimeRequest { get; set; }

        public DateTime StartTimeTrading { get; set; }

        public DateTime EndTimeTrading { get; set; }
        public ICollection<Bet> Bets { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}
