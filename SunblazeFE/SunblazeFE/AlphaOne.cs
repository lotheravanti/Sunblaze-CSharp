using NUnit.Framework.Internal;

namespace SunblazeFE
{
    public class AlphaOne
    {
        //Primitives
        static readonly int integer = 10;
        static readonly double decimalValue = 12.45;
        static readonly float realNumber = 3.1417639f;
        static readonly long largeNumber = 100000000000L;
        //Max value for byte is 100
        static readonly byte binaryValue = 100;
        static readonly bool booleanValue = true;
        //Single quotes for Character
        static readonly char character = 'a';

        //Non Primitives
        //Double quotes for String
        static readonly String message = "Alpha One Initialized";
        //Arrays
        static readonly int[] integerArray = [1, 2, 3, 4, 5, 6, 7];
        static readonly String[] stringArray = ["This", "is", "an", "Array", "from", "a", "String."];

        //String Operations
        static readonly String stringValue = "lower case text";
        //Get length of String
        //Convert to Upper Case
        static readonly String upperCase = stringValue.ToUpper();
        //Reverse String
        //Replace part of String
        static readonly String replacedMessage = message.Replace("One", "Prime");
        //Get last N characters of a String
        //Remove First and Last characters of String
        //Check if String is Alphabet
        //Verify if String starts or ends with
        static readonly bool startsWith = message.StartsWith("Alpha");
        static readonly bool endsWith = message.EndsWith("Initialized");
        //Check if String is Upper Case or Lower Case

        //Array Operations
        //Generate String from Array with delimiter
        //Reverse Array

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void DisplayMessage()
        {
            Console.WriteLine(replacedMessage + " starts with Alpha: " + startsWith + " and ends with Initialized: " + endsWith);
            Console.WriteLine(stringArray[0]);
        }

        //Add a wait at the end of every test for visibility when running manually
        //Ensure driver is closed
        [TearDown]
        public void Dispose()
        {
            
        }
    }
}