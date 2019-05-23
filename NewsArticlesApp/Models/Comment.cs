using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsArticlesApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime PublishDate { get; set; }
        public int AuthorId { get; set; }
        public string CommentText { get; set; }
    }
}
