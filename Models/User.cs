namespace MakeYourDiet.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public string gender { get; set; }

    }
}