namespace Blog.Models
{

    public class Category
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public Category(int id_, string Name_, string Slug_)
        {
            this.id = id_;
            this.Name = Name_;
            this.Slug = Slug_;
        }
    }


}
