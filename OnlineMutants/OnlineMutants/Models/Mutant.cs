using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineMutants.Models
{
    public class Mutant
    {
        public int Id { get; set; }
        [Required, StringLength(25)]
        public string RealName { get; set; }
        [Required, StringLength(25)]
        public string Alias { get; set; }
        [Required, StringLength(50)]
        public string Powers { get; set; }
        [Required, StringLength(20)]
        public string Team { get; set; }
    }
}
