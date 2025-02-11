﻿using Microsoft.Playwright;
using Newtonsoft.Json;
using System.Text.Json;

namespace SunblazeFE.API
{
    public class InitializeAPI
    {
        //Login
        public object _requestBodyLogin => new
        {
            email = "eve.holt@reqres.in",
            password = "cityslicka"
        };
        public string _urlLogin => "login";
        //Create User
        public object _requestBodyUsers => new
        {
            name = "lother",
            job = "qa automation"
        };
        public string _urlUsers => "users";
        //Get Users
        public string _urlGetUsers => "users?page=2";
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
        public async Task<JsonElement> GetAPI(string urlString, object? requestBody = null)
        {
            var requestContext = await InitializeRequestContext();
            var response = await requestContext.GetAsync(url: urlString, new APIRequestContextOptions()
            {
                DataObject = requestBody
            });
            //Get Response
            var responseJSON = await response.JsonAsync();
            //Add JsonElement return type
            return (JsonElement)responseJSON;
        }
        public async Task<JsonElement> PostAPI(string urlString, object requestBody, string? token = null)
        {
            var requestContext = await InitializeRequestContext();
            //Send request using requestBody arg as body
            //Token is optional in Headers
            var response = await requestContext.PostAsync(url: urlString, new APIRequestContextOptions()
            {
                Headers = new Dictionary<string, string>
                {
                    {"Authorization", $"Bearer {token}" }
                },
                DataObject = requestBody
            });
            //Get Response
            var responseJSON = await response.JsonAsync();
            //Add JsonElement return type
            return (JsonElement)responseJSON;
        }
        public async Task<String?> GetToken()
        {
            JsonElement requestResponse = await PostAPI(_urlLogin, _requestBodyLogin);
            //Ignore upper case Token so it will match with lower case token from JSON response
            var responseJSON = requestResponse.Deserialize<AuthenticateToken>(new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });
            return responseJSON?.Token;
        }
        public object? UnpackJson(JsonElement jsonResponse, string? className = null)
        {
            var responseJSON = jsonResponse.Deserialize<AuthenticateToken>();
            return responseJSON;
        }
        public InitializeAPI()
        {

        }
    }

    public class AuthenticateToken
    {
        [JsonProperty("token")]
        //Token starts with capital letter
        public string? Token { get; set; }
    }

    //Class acts as schema for JSON response
    public class CreateUser
    {
        public string? name { get; set; }
        public string? job { get; set; }
        public string? id { get; set; }
        public string? createdAt { get; set; }
    }

    public class GetUsers
    {
        public int? page { get; set; }
        public int? per_page { get; set; }
        public int? total { get; set; }
        public int? total_pages { get; set; }
        public Object[]? data {  get; set; }
        public object? support { get; set; }
    }
}
