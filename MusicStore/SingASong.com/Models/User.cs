using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace SingASong.com.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } 
        public string Email { get; set; }
        public string Password { get; set; }    
        public string MobileNumber { get; set; } 
        public string Address { get; set; } 
        public string City { get; set; }  
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string TracksOwned { get; set; }   
    }
}
