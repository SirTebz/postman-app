using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PostmanLibrary;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(string url, string content, HttpAction action = HttpAction.GET, bool isformatOutput = true)
    {

    }

    public async Task<string> CallApiAsync(string url, bool isformatOutput = true, HttpAction action = HttpAction.GET, HttpContent? content = null)
    {
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();

            if (isformatOutput)
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                json = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
            }

            return json;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }

    }

    public bool isValidUrl(string url)
    {
        if (string.IsNullOrEmpty(url))
        {
            return false;
        }

        bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput) && (uriOutput.Scheme == Uri.UriSchemeHttps);

        return output;
    }
}
