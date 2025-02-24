using NUnit.Framework.Internal;
using System.Text.RegularExpressions;
using static SunblazeFE.AlphaTwo;

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
        //Lists
        List<int> intList = new List<int>{8, 9, 10, 11};
        List<string> stringList = new List<string> {"This", "is", "a", "List"};

        [Test]
        public void Integers()
        {
            //Integer Operations
            
        }
        
        [Test]
        public void Strings()
        {
            //Implicit variable declaration can only be done inside a Method
            var varString = "varString";
            var varInteger = new int[1, 2, 3, 4, 5];

            //String Operations
            String stringValue = "lower case text";
            //Get length of String
            int lengthString = stringValue.Length;
            //Convert to Upper Case
            String upperCase = stringValue.ToUpper();
            //Reverse String
            String reverseString = string.Join("", stringValue.ToCharArray().Reverse().ToArray());
            //Replace part of String
            String replacedMessage = message.Replace("One", "Prime");
            //Get first N characters of a String
            String firstOfString = stringValue.Substring(0, 1);
            //Get last N characters of a String
            String lastOfString = stringValue.Substring(stringValue.Length - 3);
            //Remove First and Last characters of String
            String removeFirstLast = stringValue.Substring(1, stringValue.Length -2);
            //Check if String is Alphabet
            String stringAlphabet = "OnLyAlPhAbEt";
            bool checkAlphabet = Regex.IsMatch(stringAlphabet, @"^[a-zA-Z]+$");
            //Verify if String starts or ends with
            bool startsWith = message.StartsWith("Alpha");
            bool endsWith = message.EndsWith("Initialized");
            //Check if String is Upper Case or Lower Case
            String upperString = "ALLCAPS";
            bool isUpper = upperString.Equals(upperString.ToUpper());
            String lowerString = "alllower";
            bool isLower = lowerString.Equals(lowerString.ToLower());

            //String Interpolation format is easier to work with
            Console.WriteLine($"String length for '{stringValue}' is {lengthString}");
            Console.WriteLine($"Reversed String is '{reverseString}'");
            Console.WriteLine($"First character from '{stringValue}' is '{firstOfString}'");
            Console.WriteLine($"Last 3 characters from '{stringValue}' are '{lastOfString}'");
            Console.WriteLine($"Removing first and last characters from '{stringValue}' results in '{removeFirstLast}'");
            Console.WriteLine($"'{stringAlphabet}' contains only alphabet characters: {checkAlphabet}");
            Console.WriteLine($"'{replacedMessage}' starts with Alpha: '{startsWith}' and ends with Initialized: '{endsWith}'");
            Console.WriteLine($"'{upperString}' is all Upper Case: {isUpper}");
            Console.WriteLine($"'{lowerString}' is all Lower Case: {isLower}");
        }

        [Test]
        public void Arrays()
        {
            //Array Operations
            //Get length of Array
            int lengthArray = stringArray.Length;
            //Create new placeholder Array of fixed length
            int[] fixedArray = new int[5];
            fixedArray[2] = 10;
            //Create Two Dimensional Array
            int[][] twoDimArray = [[1, 2], [3, 4], [5, 6]];
            //Generate String from Array with delimiter
            String joinedArray = string.Join(" ", stringArray);
            //Reverse Array requires var in C#
            var reverseArray = stringArray.Reverse();
            //Count occurrences in Array
            //Split String into Integer Array, split to String Array, then convert into Integer Array
            String stringInt = "549713";
            String[] stringToArray = stringInt.Select(x => x.ToString()).ToArray();
            int[] stringToIntArray = Array.ConvertAll(stringToArray, int.Parse);
            //Get Minimum and Maximum values from an Array
            int minArray = integerArray.Min();
            int maxArray = integerArray.Max();

            Console.WriteLine($"Joined Array is '{joinedArray}'");
            Console.WriteLine($"Reversed Array is '{string.Join(" ", reverseArray)}'");
            Console.WriteLine("[{0}]", string.Join(", ", stringToIntArray));
            Console.WriteLine($"Minimum value of Array '[{string.Join(" ", integerArray)}]' is {minArray}, Maximum value is {maxArray}");
        }

        [Test]
        public void Lists()
        {
            //ListOperations
            //Add to a List
            int listAddValue = 12;
            intList.Add(listAddValue);
            //Get List length
            int listLength = intList.Count;

            //Use double {{ and }} in $ string
            Console.WriteLine($"Integer '{listAddValue}' has been added to List '{{{string.Join(" ", intList)}}}'");
            Console.WriteLine($"List length for '{{{string.Join(" ", intList)}}}' is {listLength}");

        }
        [Test]
        public void IfStatements()
        {
            //If statement
            bool condition;
            if (integerArray[0] == 1)
            {
                condition = true;
            }
            else
            {
                condition = false;
            }
            Console.WriteLine(condition);
            //If statement with AND
            if (integerArray[0] == 1 && integerArray[1] == 2)
            {
                condition = true;
            }
            Console.WriteLine(condition);
            //If statement with OR
            if (integerArray[0] == 1 || integerArray[1] == 2)
            {
                condition = true;
            }
            Console.WriteLine(condition);
        }

        [Test]
        public void ForLoops()
        {
            //For index in Array
            int forCount = 0;
            for (int i = 0; i < integerArray.Length; i++)
            {
                forCount = forCount + integerArray[i];
            }
            //For item in Array
            String sentenceString = "";
            foreach (String s in stringArray)
            {
                sentenceString += s;
            }
            Console.WriteLine($"Using Index For Loop to count Array '[{string.Join(" ", integerArray)}]' returns {forCount}");
            Console.WriteLine($"Using Foreach Loop on every element in Array '[{string.Join(" ", stringArray)}]' returns the following String '{sentenceString}'");
        }

        [Test]
        public void OOP()
        {
            //Public method requires Instance of Class
            AlphaTwo _alphaTwo = new AlphaTwo();
            int alphaTwoIntSum = _alphaTwo.SumIntArray(integerArray);
            //Static method does not require Instance of Class
            int alphaTwoIntAverage = AlphaTwo.AverageIntArray(integerArray);
            //Create instance of Inner Class
            InnerAlphaTwo _innerAlphaTwo = new InnerAlphaTwo();
            int innerAlphaTwoIntMin = _innerAlphaTwo.MinIntArray(integerArray);
            _innerAlphaTwo.InnerAlphaTwoSet();

            Console.WriteLine($"After creating instance of Class AlphaTwo, using its method SumIntArray to calculate sum of '[{string.Join(" ", integerArray)}]' is {alphaTwoIntSum}");
            Console.WriteLine($"Static method of Class AlphaTwo AverageIntArray used to calculate average of '[{string.Join(" ", integerArray)}]' is {alphaTwoIntAverage}");
            _alphaTwo.VoidAlphaTwo();
            Console.WriteLine($"Method of Inner Class InnerAlphaTwo MinIntArray used to retrieve minimum value of '[{string.Join(" ", integerArray)}]' is {innerAlphaTwoIntMin}");
            _innerAlphaTwo.InnerAlphaTwoGet();
        }
    }
}