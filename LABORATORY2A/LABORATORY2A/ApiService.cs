using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY2A
{
    public class ApiService
    {
        _client = new HttpClient();
        {
        baseAddress = new Uri(ConfrationManager.AppSettings["ServerAddress"])
            };
    }
public async Task<string> GetRawStringAsync(string endpoint)
{
   var response =await _client.GetAsync(endpoint);
    response.EnsureSuccessStatusCode();
    return await response.Content.ReadAsStringAsync();
}
