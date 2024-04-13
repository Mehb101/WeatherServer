namespace WeatherServer.DTO
{
    public class LoginRequest
    {
        public required String Username { get; set; }
        public required String Password { get; set; }
    }
}
