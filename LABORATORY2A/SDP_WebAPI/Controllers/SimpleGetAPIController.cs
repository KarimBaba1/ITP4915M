using System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DatabaseAccessController;
using Newtonsoft.Json;

namespace SDP_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleGetAPIController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SimpleGetAPIController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("SimpleGetMethod")]
        public String Get()
        {
            return $"This is returned by the web API server. Current time is : {DateTime.Now}";
        }

        [HttpGet("GetCustomerData")]
        public String GetCustomerData()
        {
            dboGetCompanyData dboGetCompanyData = new dboGetCompanyData(_configuration["ConnectionStrings"]);
            DataTable dtResult = dboGetCompanyData.GetAllCustomerData();

            // Convert DataTable to JSON string
            string jsonString = JsonConvert.SerializeObject(dtResult);

            // Return JSON string
            return jsonString;
        }

        [HttpGet("FindCustomer")]
        public String FindCustomerData(String CustomerName)
        {
            dboGetCompanyData dboGetCompanyData = new dboGetCompanyData(_configuration["ConnectionStrings"]);
            DataTable dtResult = dboGetCompanyData.FindCustomerData(CustomerName);

            // Convert DataTable to JSON string
            string jsonString = JsonConvert.SerializeObject(dtResult);

            // Return JSON string
            return jsonString;
        }
    }
}
