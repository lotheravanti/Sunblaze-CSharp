using NUnit.Framework.Internal;

namespace SunblazeFE
{
    public class AlphaOne
    {
        //Primitives
        int integer = 10;
        double decimalValue = 12.45;
        float realNumber = 3.1417639f;
        long largeNumber = 100000000000L;
        //Max value for byte is 100
        byte binaryValue = 100;
        bool booleanValue = true;
        //Single quotes for Character
        char character = 'a';

        //Non Primitives
        //Double quotes for String
        static String message = "Alpha One Initialized";
        static String lowerCase = "lower case text";
        String replacedMessage = message.Replace("One", "Prime");
        //Convert to Upper Case
        String upperCase = lowerCase.ToUpper();
        bool startsWith = message.StartsWith("Alpha");
        bool endsWith = message.EndsWith("Initialized");
        int[] integerArray = { 1, 1 };
        String[] stringArray = { "First", "Second" };

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void DisplayMessage()
        {
            Console.WriteLine(replacedMessage + " starts with Alpha: " + startsWith + " and ends with Initialized: " + endsWith);
        }

        //Add a wait at the end of every test for visibility when running manually
        //Ensure driver is closed
        [TearDown]
        public void Dispose()
        {
            
        }
    }
}