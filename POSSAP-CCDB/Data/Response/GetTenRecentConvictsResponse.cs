namespace POSSAP_CCDB.Data.Response
{
    public class GetTenRecentConvictsResponseData
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string prison { get; set; }
        public string prisonState { get; set; }
        public string country { get; set; }
        public string dateOfConviction { get; set; }
        public string createdAt { get; set; }
    }

    public class GetTenRecentConvictsResponse
    {
        public string message { get; set; }
        public string status { get; set; }
        public List<GetTenRecentConvictsResponseData> data { get; set; }
    }
}
