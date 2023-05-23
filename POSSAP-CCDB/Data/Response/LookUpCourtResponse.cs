namespace POSSAP_CCDB.Data.Response
{
    public class LookUpCourtResponseData
    {
        public int id { get; set; }
        public string? name { get; set; }
        public object? states { get; set; }
    }

    public class LookUpCourtResponse
    {
        public string? message { get; set; }
        public string? status { get; set; }
        public List<LookUpCourtResponseData> data { get; set; }
    }
}
