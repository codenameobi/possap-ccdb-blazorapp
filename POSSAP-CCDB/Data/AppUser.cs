namespace POSSAP_CCDB.Data
{
    public class AppUser
    {
        public string status { get; set; }
        public string userId { get; set; }
        public string token { get; set; }
        public string refreshToken { get; set; }
        public bool isProfileCompleted { get; set; }
        public string message { get; set; }
        public string role { get; set; }
        public string fullName { get; set; }
    }
}
