using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Agreement_Maintenance.Models;

namespace Agreement_Maintenance.Controllers
{
    [ApiController]
    [EnableCors("corspolicy")]
    public class AgreementController : ControllerBase
    {
        private AgreementMaintenanceContext context;

        public AgreementController(AgreementMaintenanceContext context)
        {
            this.context = context;
        }

        [HttpPost]
        [Route("api/agreements/post")]
        public IActionResult AddAgreement([FromBody] AgreementDetail agreement)
        {
            try
            {
                AgreementDetail ob = new AgreementDetail
                {
                    NameOfTheParty = agreement.NameOfTheParty,
                    VendorCode = agreement.VendorCode,
                    StartDateOfAgreement = agreement.StartDateOfAgreement,
                    EndDateOfAgreement = agreement.EndDateOfAgreement,
                    Division = agreement.Division,
                    Department = agreement.Department,
                    NatureOfAgreement = agreement.NatureOfAgreement,
                    Attachment = agreement.Attachment,
                    CreatedOn = agreement.CreatedOn,
                    CreatedBy = agreement.CreatedBy,
                    AgreementStatus = agreement.AgreementStatus,
                    NotificationTriggeredCount = agreement.NotificationTriggeredCount,
                };

                context.AgreementDetails.Add(ob);
                context.SaveChanges();

                // Return a success response
                return Ok("Agreement added successfully");
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine($"Error: {ex.Message}");

                // Return an error response
                return BadRequest("Failed to add the agreement");
            }
        }
    }
    
}
