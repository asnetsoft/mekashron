using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mekashron.Models
{
    public class CustomerViewModel
    {
        public int EntityId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Mobile { get; set; }
    }
}