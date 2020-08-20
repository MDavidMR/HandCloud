using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandCloud.WebApp.Models
{
    public class Car
    {
        [Key]
        [HiddenInput(DisplayValue = true)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "{0} can only contain {1} characters.")]
        public string Model { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(100, ErrorMessage = "{0} can only contain {1} characters.")]
        public string Description { get; set; }

        [Range(0, 9000, ErrorMessage = "{0} must be greater than {1} and less than {2}.")]
        public int Year { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "{0} can only contain {1} characters.")]
        public string Brand { get; set; }

        [Required]
        [Range(0, 1000000, ErrorMessage = "{0} must be greater than {1} and less than {2}.")]
        public int Kilometers { get; set; }

        [Required]
        [Range(0, 10000000, ErrorMessage = "{0} must be greater than {1} and less than {2}.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

    }
}
