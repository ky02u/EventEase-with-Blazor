namespace EventEase.Services
{
    public class UserSessionService
    {
        public string UserName { get; set; } = "";
        public string Email { get; set; } = "";

        public bool IsLoggedIn => !string.IsNullOrWhiteSpace(Email);
    }
}