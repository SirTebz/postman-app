
namespace PostmanLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, string content, HttpAction action = HttpAction.GET, bool isformatOutput = true);
        Task<string> CallApiAsync(string url, HttpContent? content = null, HttpAction action = HttpAction.GET, bool isformatOutput = true);
        bool isValidUrl(string url);
    }
}