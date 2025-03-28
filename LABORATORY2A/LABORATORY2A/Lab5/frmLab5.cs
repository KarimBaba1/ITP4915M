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

    }


}

