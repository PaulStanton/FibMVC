using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FibMVC.Models
{
    public class FibModel
    {   [Range(0,100,ErrorMessage ="Must enter a number between 0 and 100")]
        public int NumFib { get; set; }
        public List<int> FibNumbers { get; set; }
    }
}