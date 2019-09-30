using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class CreatorHero1
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string PrimartyAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string CatchPhrase { get; set; }


    }
}