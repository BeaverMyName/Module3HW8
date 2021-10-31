using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3FinalProject.Models
{
    public class User
    {
        [Required]
        public int Id { get; init; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; init; }
        [Required]
        [StringLength(6, MinimumLength = 4)]
        public string Gender { get; init; }
        [Required]
        [Range(1, 100)]
        public int Age { get; init; }
    }
}
