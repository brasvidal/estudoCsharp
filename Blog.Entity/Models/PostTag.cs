namespace Blog.Entity.Models
{
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }

        public PostTag(int PostId_, int TagId_)
        {
            this.PostId = PostId_;
            this.TagId = TagId_;
        }
    }
}