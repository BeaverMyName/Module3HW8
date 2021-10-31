using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3FinalProject.Models
{
    public class Order
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int Id { get; init; }
        [Required]
        [Range(0, int.MaxValue)]
        public int UserId { get; init; }
        [Required]
        [Range(0, int.MaxValue)]
        public int OrderNumber { get; init; }
        [Required]
        public string OrderDate { get; init; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Total { get; init; }
    }
}
