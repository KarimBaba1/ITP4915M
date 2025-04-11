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
using SDP_EntityModels;

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
            ApiService apiService = new ApiService();
            DataTable dt = await GetCustomerDataFromApiResponse();
            dgvCustomerDetails.DataSource = dt;
            dt.AcceptChanges();
        }
        private async void btn_search_Click(object sender, EventArgs e)
        {
            string customerName = txt_Customer_Name.Text;
            DataTable dt = await FindCustomerDataFromApiResponse();
            dgvCustomerDetails.DataSource = dt;
            dt.AcceptChanges();
        }
        private async void txt_Customer_Name_TextChanged(object sender, EventArgs e)
        {
            string customerName = txt_Customer_Name.Text;
            DataTable dt = await FindCustomerDataFromApiResponse();
            dgvCustomerDetails.DataSource = dt;
            dt.AcceptChanges();
        }


        private async Task<DataTable> GetCustomerDataFromApiResponse()
        {
            ApiService apiCaller = new ApiService();
            String customerName = txt_Customer_Name.Text;
            String endpoint = $"api/SimpleGetAPI/GetCustomerData";
            String jsonString = await apiCaller.APIRequest(endpoint);
            return JsonConvert.DeserializeObject<DataTable>(jsonString);
        }




        private async Task<DataTable> FindCustomerDataFromApiResponse()
        {
            ApiService apiCaller = new ApiService();
            String customerName = txt_Customer_Name.Text;
            String endpoint = $"api/SimpleGetAPI/FindCustomer?CustomerName={customerName}";
            String jsonString = await apiCaller.APIRequest(endpoint);
            return JsonConvert.DeserializeObject<DataTable>(jsonString);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
           
            DataTable dtUpdated = (DataTable)dgvCustomerDetails.DataSource;
            dtUpdated = dtUpdated.GetChanges();

            if (dtUpdated != null)
            {
                int rowsUpdated = await UpdateCustomerDataToAPI(dtUpdated);
                if (rowsUpdated > 0)
                {
                    dtUpdated.AcceptChanges();
                    dgvCustomerDetails.DataSource = dtUpdated.Copy();
                }
                MessageBox.Show($"{rowsUpdated} rows updated successfully.");
            
        }
           

    }
        private async Task<int> UpdateCustomerDataToAPI(DataTable dtUpdated)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]);

                    // Serialize DataTable to JSON
                    // New Row
                    DataTable dtAdded = dtUpdated.GetChanges(DataRowState.Added);
                    string jsonAdded = JsonConvert.SerializeObject(dtAdded, Formatting.Indented);

                    // Modified Row
                    DataTable dtModified = dtUpdated.GetChanges(DataRowState.Modified);
                    string jsonModified = JsonConvert.SerializeObject(dtModified, Formatting.Indented);

                    //// Deleted Row
                   DataTable dtDeleted = dtUpdated.GetChanges(DataRowState.Deleted);
                    List<string> listCustomerNumber = new List<string>();

                    if (dtDeleted != null && dtDeleted.Rows.Count > 0 )
                    {
                        foreach (DataRow row in dtDeleted.Rows)
                        {
                            // Check if the row has the "CustomerNumber" column and is not null
                            if (!row.IsNull(row.Table.Columns["CustomerNumber"], DataRowVersion.Original))
                            {
                                //Access the original values before deletion
                                String deletedCustomerNumber = row["CustomerNumber", DataRowVersion.Original].ToString();
                                //You can use the deletedCustomerNumber to delete the row from the database
                                listCustomerNumber.Add(deletedCustomerNumber);

                            }
                            if (listCustomerNumber.Count == 0)
                            {
                                MessageBox.Show("No valid rows to delete.");
                                return 0;
                            }


                                
                        }
                    }
                    string jsonDeleted = JsonConvert.SerializeObject(listCustomerNumber, Formatting.Indented);
                    /* String jsonDeleted = "";*/

                    // Create a new instance of JsonDataTable and set its properties
                    JsonDataTable jsonDT = new JsonDataTable();
                    jsonDT.dtAdded = jsonAdded;
                    jsonDT.dtModified = jsonModified;
                    jsonDT.dtDeleted = jsonDeleted;
                    string jsonString = JsonConvert.SerializeObject(jsonDT);

                    StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    // Send POST request to the Web API
                    HttpResponseMessage response = await client.PostAsync("/api/SimpleGetAPI/UpdateCustomerData", content);

                    // Ensure the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string responseString = await response.Content.ReadAsStringAsync();

                        // Parse the response string to an integer
                        int rowsUpdated = int.Parse(responseString);

                        return rowsUpdated;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        return 0;
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

