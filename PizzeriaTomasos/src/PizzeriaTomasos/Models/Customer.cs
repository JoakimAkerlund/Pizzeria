using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaTomasos.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
