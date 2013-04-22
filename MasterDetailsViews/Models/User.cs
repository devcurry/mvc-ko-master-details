using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsViews.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }    
    }
}