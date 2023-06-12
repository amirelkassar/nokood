namespace NokoodAssignment.Application.Dots
{
    public class UserTokenDto
    {
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool Success { get; set; } = false;
    }
}
