using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Albums
    {
        public int ID { get; set; }
        [Required]
        public String Artist { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public String Album { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public String Genre { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Range(0, 20.00)]
        public decimal Price { get; set; }
    }
}
