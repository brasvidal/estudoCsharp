namespace Blog.Models
{

    public class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public UserRole(int UserId_, int RoleId_)
        {
            this.UserId = UserId_;
            this.RoleId = RoleId_;
        }
    }


}
