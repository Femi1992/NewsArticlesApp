using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsArticlesApp.Models
{
    public class User : IdentityUser<int>
    {
        public override int Id { get; set; }
        public string LoginId { get; set; }
        public string Name { get; set; }
    }
}
