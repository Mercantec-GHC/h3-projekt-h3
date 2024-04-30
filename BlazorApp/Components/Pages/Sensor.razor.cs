using static System.Net.WebRequestMethods;
using API.Models;
using System.Net.Http.Json;
using System.Text.Json;
using Syncfusion.Blazor.Data;


namespace BlazorApp.Components.Pages
{
    public partial class Sensor
    {
        private HttpClient client = new HttpClient() { BaseAddress = new Uri("https://h3-projektv2-24q2h3-gruppe1-sqve.onrender.com/") };
        public List<Plant>? plants;
        public List<Plant>? plantlist;
        public async Task GetListOfPlants()
        {
            try
            {
                plants = await client.GetFromJsonAsync<List<Plant>>("api/Plants");
           
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"Error fetching plants: {ex.Message}");
            }
        }


        string abe = "a0";
    }
}
