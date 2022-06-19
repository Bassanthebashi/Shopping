using Microsoft.AspNetCore.Identity;

namespace Shopping.Data.Models
{
    public class User:IdentityUser
    {
       public ICollection<Order> Orders { get; set; }
    }
}
