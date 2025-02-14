using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Shopping_store.Models
{
    public class User : IdentityUser
    {
        public List<Order> Orders { get; set; } = new();
        public List<Car> Cars { get; set; } = new();
        public List<CountCarsForUser> Counts { get; set; } = new();
    }
}
