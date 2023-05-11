namespace POSSAP_CCDB.Data.Response
{
    public class DEConvictReportCountsResponseData
    {
        public int totalConvicts { get; set; }
        public int totalMaleConvicts { get; set; }
        public int totalFemaleConvicts { get; set; }
        public int totalDataEntryPerDay { get; set; }
        public int totalDataEntryPerWeek { get; set; }
        public int totalDataEntryPerMonth { get; set; }
        public int totalQuerriedDataEntry { get; set; }
        public int totalSuccessfulDataEntry { get; set; }
        public int totalPendingDataEntry { get; set; }
        public int totalIncompletDataEntry { get; set; }
    }

    public class DEConvictReportCountsResponse
    {
        public string message { get; set; }
        public string status { get; set; }
        public DEConvictReportCountsResponseData data { get; set; }
    }
}
