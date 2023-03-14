using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BISSCHOOL.ViewModels
{
    public class CustomViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
    }
}