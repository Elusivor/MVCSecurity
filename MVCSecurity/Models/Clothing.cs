using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSecurity.Models
{
    public class Clothing
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "The Description is Required")]
        public string Description { get; set; }
        public int Size { get; set; }
        public bool CanDryClean { get; set; }
        public DateTime FirstProduced { get; set; }
    }
}