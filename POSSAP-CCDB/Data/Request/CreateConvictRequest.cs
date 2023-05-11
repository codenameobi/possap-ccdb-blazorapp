namespace POSSAP_CCDB.Data.Request
{
    public class CreateConvictRequest
    {
        public string ConvictUniqueId { get; set; }
        public string NIN { get; set; } = String.Empty;
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Height { get; set; }
        public string Marks { get; set; }
        public string Tribe { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string EyeColour { get; set; }
        public string HairColour { get; set; }
        public string PhoneNumber { get; set; }
        public int CourtId { get; set; }
        public string CourtState { get; set; }
        public int? JudiciaryId { get; set; }
        public string? OtherJudiciaryDivision { get; set; }
        public string OffenceCategory { get; set; }
        public string OffenceOfConviction { get; set; }
        public int? MonthSentenced { get; set; }
        public int? YearSentenced { get; set; }
        public bool IsFined { get; set; } = false;
        public Decimal? Amount { get; set; }
        public string SpecialInstructions { get; set; } = String.Empty;
        public string Comment { get; set; } = String.Empty;
        public string QueryComment { get; set; } = String.Empty;
        public DateTime ConvictionDate { get; set; }
        public string PrisonState { get; set; }
        public int PrisonId { get; set; }
        public string Punishment { get; set; }
        public int JudgeId { get; set; }
        public string KnownAddress { get; set; }
        public int AgencyId { get; set; }
        public string Nationality { get; set; }
        public string State { get; set; }
        public string Weight { get; set; }
        public string PlaceOfBirth { get; set; }
        public string DnaReferenceNo { get; set; } = String.Empty;
    }
}
