using AQMBCore.DataAccess;
using AQMDCore.DataAccess;
using AQMDCore.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AQMDCore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilitiesController : ControllerBase
    {
        [HttpGet("GetContactDetails/id")]
        public AQMDContact GetContactDetails(int FacilityID, string SystemType)
        {
            return new ContactData().ContactDetails(FacilityID, SystemType);
        }

        [HttpPut("UpdateContactDetails")]
        public string UpdateContactDetails(AQMDContact aqmdcontact, int FacilityID)
        {
            return new ContactData().UpdateContact(aqmdcontact, FacilityID);
        }

        [HttpPost]
        public string CretaeContactDetails(AQMDContact aqmdcontact)
        {
            return null;
        }


    }
}
