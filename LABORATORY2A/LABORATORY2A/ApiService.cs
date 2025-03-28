using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Configuration;
using System.Data;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace LABORATORY2A
{
    public class ApiService
    {
        public async Task<string> APIRequest(string endpoint)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]);
                    HttpResponseMessage response = await client.GetAsync(endpoint);
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        string error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                        MessageBox.Show(error);
                        throw new Exception(error);
                    }
                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show($"Request error: {e.Message}");
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}");
                throw;
            }
        }

    }
}

