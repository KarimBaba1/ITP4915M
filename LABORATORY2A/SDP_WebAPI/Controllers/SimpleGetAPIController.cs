using System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DatabaseAccessController;
using Newtonsoft.Json;
using SDP_EntityModels;
using System.Linq.Expressions;

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

        [HttpPost("UpdateCustomerData")]
        public int UpdateCustomerData([FromBody] JsonDataTable json)
        {
            try
            {
                int totalAffectedRows = 0;

                dboGetCompanyData dboGetCompanyData = new dboGetCompanyData(_configuration["ConnectionStrings"]);

                // Handle updated rows
                if (!string.IsNullOrEmpty(json.dtModified))
                {
                    DataTable dtModified = JsonConvert.DeserializeObject<DataTable>(json.dtModified);
                    if (dtModified != null && dtModified.Rows.Count > 0)
                    {
                        totalAffectedRows += dboGetCompanyData.UpdateCustomerData(dtModified);
                    }
                }

                // Handle new rows to insert
                if (!string.IsNullOrEmpty(json.dtAdded))
                {
                    DataTable dtAdded = JsonConvert.DeserializeObject<DataTable>(json.dtAdded);
                    if (dtAdded != null && dtAdded.Rows.Count > 0)
                    {
                        totalAffectedRows += dboGetCompanyData.InsertCustomerData(dtAdded);
                    }
                }

                // Handle deleted rows
                if (!string.IsNullOrEmpty(json.dtDeleted))
                {
                    List<string> customerNumbers = JsonConvert.DeserializeObject<List<string>>(json.dtDeleted);
                    if (customerNumbers != null && customerNumbers.Count > 0)
                    {
                        foreach (var customerNumber in customerNumbers)
                        {
                            totalAffectedRows += dboGetCompanyData.DeleteCustomerData(customerNumber);
                        }
                    }
                }

                return totalAffectedRows;
            }
            catch (Exception ex)
            {
                // Log the exception (optional) and rethrow
                throw new Exception("An error occurred while updating customer data.", ex);
            }
        }


    }
}


    

