using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SwaggerAPI.Models
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }
        public string SKU { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double QOH { get; set; }
        public double Mask { get; set; }
    }
}