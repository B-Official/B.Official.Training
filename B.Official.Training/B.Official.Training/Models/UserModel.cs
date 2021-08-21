using SQLite;

namespace B.Official.Training.Models
{
    public class UserModel
    {
        [PrimaryKey]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
}
