namespace ProjectManagementHelper
{
    public class User
    {
        public string Username { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Role {  get; set; }
    }
}
