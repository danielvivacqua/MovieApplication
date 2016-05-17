using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApplication.Models
{
    [MetadataType(typeof(MovyBuddy))]
    public partial class Movy
    {

    }

    public class MovyBuddy
    {
        public int MovieID { get; set; }

        [Display(Name = "The Title")]
        public string Title { get; set; }

        public string Director { get; set; }

        public string Genre { get; set; }
    }
}