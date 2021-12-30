namespace Blog.Entity.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public Role(int Id_, string Name_, string Slug_)
        {
            this.Id = Id_;
            this.Name = Name_;
            this.Slug = Slug_;
        }
    }
}