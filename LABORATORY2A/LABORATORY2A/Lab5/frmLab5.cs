using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LABORATORY2A.Lab5
{
    public partial class frmLab5 : Form
    {
        public frmLab5()
        {
            InitializeComponent();
        }

        private async void frmLab5_Load(object sender, EventArgs e)
        {
            DataTable dt = await GetCustomerDataFromApiResponse();
            dgvCustomerDetails.DataSource = dt;
            dt.AcceptChanges();
        }
        private async Task<DataTable> GetCustomerDataFromApiResponse()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]); // Adjust the base address as needed
                    HttpResponseMessage response = await client.GetAsync("/api/SimpleGetAPI/GetCustomerData");

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();

                        DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(jsonString);

                        return dataTable;
                    }
                    else
                    {
                        // Log the status code and reason
                        string error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                        throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
            }
            catch (HttpRequestException e)
            {
                // Log the exception message
                MessageBox.Show($"Request error: {e.Message}");
                throw e;
            }
            catch (Exception ex)
            {
                // Log any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
                throw ex;
            }
        }


    }
}
