using Microsoft.Playwright;
using System.Text.Json;

namespace SunblazeFE.API
{
    public class InitializeAPI
    {
        public async Task<IAPIRequestContext> InitializeRequestContext()
        {
            var playwright = await Playwright.CreateAsync();
            //Set base URL for endpoints
            var requestContext = await playwright.APIRequest.NewContextAsync(new APIRequestNewContextOptions
            {
                BaseURL = "https://reqres.in/api/"
            });
            return requestContext;
        }
        public async Task<JsonElement> PostAPI(string urlString, object requestBody)
        {
            var requestContext = await InitializeRequestContext();
            var response = await requestContext.PostAsync(url: urlString, new APIRequestContextOptions()
            {
                DataObject = requestBody
            });
            //Get Response
            var responseJSON = await response.JsonAsync();
            //Add JsonElement return type
            return (JsonElement)responseJSON;
        }
        public InitializeAPI() 
        {
        }
    }

    public class AuthenticateToken
    {
        public string? token { get; set; }
    }
}
