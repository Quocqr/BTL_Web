using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trang_thong_tin_dien_tu_HOU
{
    public class Post
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Post(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }
    }
}