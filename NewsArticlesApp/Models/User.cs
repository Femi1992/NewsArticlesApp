using Microsoft.AspNetCore.Identity;

namespace NewsArticlesApp.Models
{
    public class User : IdentityUser<int>
    {
        public override int Id { get; set; }
        public string LoginId { get; set; }
        public string Name { get; set; }
    }
}
