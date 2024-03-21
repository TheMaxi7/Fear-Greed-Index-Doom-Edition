
using System.Net.Http;
using Newtonsoft.Json.Linq;
public class FearAndGreedIndexFetcher
{
    private readonly HttpClient _httpClient;
    int index=0;
    string state="";
    public FearAndGreedIndexFetcher()
    {
        _httpClient = new HttpClient();
    }

    public async Task<(int, string)> FetchIndexValueAsync()
    {

        HttpResponseMessage response = await _httpClient.GetAsync("https://api.alternative.me/fng/");

        if (response.IsSuccessStatusCode)
        {

            string responseBody = await response.Content.ReadAsStringAsync();
            JObject jsonResponse = JObject.Parse(responseBody);

            if (jsonResponse != null)
            {
                index = Convert.ToInt32(jsonResponse["data"]?[0]?["value"]);
                state += jsonResponse["data"]?[0]?["value_classification"]?.ToString();
            }

            return (index, state);
        }
        else
        {
            return (404, "Error");
        }

    }
}
