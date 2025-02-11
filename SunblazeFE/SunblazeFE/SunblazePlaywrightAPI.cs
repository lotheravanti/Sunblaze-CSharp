using SunblazeFE.API;
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
            var responseJSON = requestResponse.Deserialize<AuthenticateToken>();
            Console.WriteLine(responseJSON?.token);
        }

        [Test]
        public async Task POSTCreateUser()
        {
            var requestResponse = await initializeAPI.PostAPI(initializeAPI._urlUsers, initializeAPI._requestBodyUsers);
            //Deserialize JSON using Class as schema
            var responseJSON = requestResponse.Deserialize<CreateUser>();
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
