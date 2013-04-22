using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace MasterDetailsViews.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public int UserId { get; set; }
        
        [ForeignKey("UserId")]
        [ScriptIgnore]
        public User ParentUser { get; set; }
    }
}