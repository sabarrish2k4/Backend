namespace Agreement_Maintenance.Models
{
    public class AgreementRequest
    {
        //public int Sno { get; set; }
        public string NameOfTheParty { get; set; }
        public string VendorCode { get; set; }
        public DateTime StartDateOfAgreement { get; set; }
        public DateTime EndDateOfAgreement { get; set; }
        public string Division { get; set; }
        public string Department { get; set; }
        public string NatureOfAgreement { get; set; }
        public string Attachment { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string AgreementStatus { get; set; }
        public int NotificationTriggeredCount { get; set; }
    }
}
