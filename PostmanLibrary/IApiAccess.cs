
namespace PostmanLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, bool isformatOutput = true, HttpAction action = HttpAction.GET);
        bool isValidUrl(string url);
    }
}