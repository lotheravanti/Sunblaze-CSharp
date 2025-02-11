using SunblazeFE.API;
using System.Text.Json;

namespace SunblazeFE
{
    //Inherit PageTest for Expect methods
    public class PlaywrightAPITests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public async Task GetToken()
        {
            object requestBody = new
            {
                email = "eve.holt@reqres.in",
                password = "cityslicka"
            };
            InitializeAPI getResponse = new();
            var requestResponse = await getResponse.PostAPI("login", requestBody);
            var responseJSON = requestResponse.Deserialize<AuthenticateToken>();
            Console.WriteLine(responseJSON?.token);
        }

        [TearDown]
        public void Dispose()
        {
            
        }
    }
}
