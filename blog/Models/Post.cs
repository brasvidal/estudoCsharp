using System;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public Post(int Id_, int CategoryId_, int AuthorId_, string Title_, string Summary_, string Body_, string Slug_, DateTime CreateDate_, DateTime LastUpdateDate_)
        {
            this.Id = Id_;
            this.CategoryId = CategoryId_;
            this.AuthorId = AuthorId_;
            this.Title = Title_;
            this.Summary = Summary_;
            this.Body = Body_;
            this.Slug = Slug_;
            this.CreateDate = CreateDate_;
            this.LastUpdateDate = LastUpdateDate_;
        }
    }

}

