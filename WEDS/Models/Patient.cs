namespace WEDS.Models
{
    public class Patient
    {
        public string CaseNo { get; set; }
        public string NhsNumber { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string Postcode { get; set; }
        public string Address { get; set; }
    }
}
