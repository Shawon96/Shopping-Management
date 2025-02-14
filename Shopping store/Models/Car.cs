using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shopping_store.Models
{
    public class Car
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Enter the link to the image")]
        [Url(ErrorMessage = "This is not a link...")]
        [Display(Name = "Link to photo:")]
        public string UrlImage { get; set; }

        [Required(ErrorMessage = "Enter the name of the car")]
        [Display(Name = "Car name:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter a description of the vehicle")]
        [Display(Name = "Vehicle description:")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Enter the price of the car")]
        [Display(Name = "Car price($):")]
        public int? PriceDollars { get; set; }

        public List<User> Users { get; set; } = new();
        public List<CountCarsForUser> Counts { get; set; } = new();
    }
}
