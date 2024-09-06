// Services/HttpClientHelper.cs
using System.Net.Http;
using System.Threading.Tasks;

public static class HttpClientHelper
{
    public static async Task<bool> IsOnline()
    {
        try
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("api/data");
                return response.IsSuccessStatusCode;
            }
        }
        catch
        {
            return false;
        }
    }
}