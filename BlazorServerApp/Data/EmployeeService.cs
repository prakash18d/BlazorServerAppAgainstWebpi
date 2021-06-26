using Employee;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerApp.Data
{
    public class EmployeeService
    {
        string baseUrl = "http://localhost:31976/";

        public async Task<EmployeeClass[]> GetEmployeesAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/employee");
            return JsonConvert.DeserializeObject<EmployeeClass[]>(json);
        }

        public async Task<EmployeeClass> GetEmployeesByIdAsync(string id)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Employee/{id}");
            return JsonConvert.DeserializeObject<EmployeeClass>(json);
        }

        public async Task<HttpResponseMessage> InsertEmployeeAsync(EmployeeClass employee)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/Employee", getStringContentFromObject(employee));
        }

        public async Task<HttpResponseMessage> UpdateEmployeeAsync(string id, EmployeeClass employee)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{baseUrl}api/Employee/{id}", getStringContentFromObject(employee));
        }

        public async Task<HttpResponseMessage> DeleteEmployeeAsync(string id)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{baseUrl}api/Employee/{id}");
        }
        //helper method pass object and get string content object
        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
