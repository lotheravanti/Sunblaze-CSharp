using SunblazeFE.API_PW;
using System.Text.Json;

namespace SunblazeFE
{
    //Inherit PageTest for Expect methods
    public class PlaywrightAPITests
    {
        InitializeAPI initializeAPI;
        [SetUp]
        public void Setup()
        {
            InitializeAPI _initializeAPI = new();
            initializeAPI = _initializeAPI;
        }

        [Test]
        public async Task POSTGetLoginToken()
        {
            var requestResponse = await initializeAPI.PostAPI(initializeAPI._urlLogin, initializeAPI._requestBodyLogin);
            //Ignore upper case Token so it will match with lower case token from JSON response
            var responseJSON = requestResponse.Deserialize<AuthenticateToken>(new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });
            //Verify token is not null or empty
            Assert.That(responseJSON?.Token, Is.Not.Null);
            Assert.That(responseJSON?.Token, Is.Not.Empty);
            Console.WriteLine(responseJSON?.Token);
        }

        [Test]
        public async Task POSTCreateUser()
        {
            var getToken = await initializeAPI.GetToken();
            Console.WriteLine(getToken);
            var requestResponse = await initializeAPI.PostAPI(initializeAPI._urlUsers, initializeAPI._requestBodyUsers, getToken);
            //Deserialize JSON using Class as schema
            var responseJSON = requestResponse.Deserialize<CreateUser>();
            //Verify multiple values, but don't stop if one fails
            //Error output is more readable with Is.EqualTo
            Assert.Multiple(() =>
            {
                Assert.That(responseJSON?.name, Is.EqualTo("lother"));
                Assert.That(responseJSON?.job, Is.EqualTo("qa automation"));
            });
            Console.WriteLine(responseJSON?.name);
            Console.WriteLine(responseJSON?.job);
            Console.WriteLine(responseJSON?.id);
            Console.WriteLine(responseJSON?.createdAt);
        }

        [Test]
        public async Task GETUsers()
        {
            var requestResponse = await initializeAPI.GetAPI(initializeAPI._urlGetUsers);
            //Deserialize JSON using Class as schema
            var responseJSON = requestResponse.Deserialize<GetUsers>();
            Console.WriteLine(responseJSON?.page);
            Console.WriteLine(responseJSON?.per_page);
            Console.WriteLine(responseJSON?.total);
            Console.WriteLine(responseJSON?.total_pages);
            Array.ForEach(responseJSON?.data, Console.WriteLine);
            Console.WriteLine(responseJSON?.support);
        }

        [TearDown]
        public void Dispose()
        {
            
        }
    }
}
