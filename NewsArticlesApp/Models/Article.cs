using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsArticlesApp.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public int AuthorId { get; set; }
        public int LikesCount { get; set; }
    }
}
