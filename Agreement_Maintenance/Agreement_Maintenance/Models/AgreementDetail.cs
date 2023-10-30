using System;
using System.Collections.Generic;

namespace Agreement_Maintenance.Models;

public partial class AgreementDetail
{
    public int Sno { get; set; }

    public string NameOfTheParty { get; set; } = null!;

    public string VendorCode { get; set; } = null!;

    public DateOnly StartDateOfAgreement { get; set; }

    public DateOnly EndDateOfAgreement { get; set; }

    public string Division { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string NatureOfAgreement { get; set; } = null!;

    public string Attachment { get; set; } = null!;

    public DateOnly? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? AgreementStatus { get; set; }

    public string? NotificationTriggeredCount { get; set; }
}
