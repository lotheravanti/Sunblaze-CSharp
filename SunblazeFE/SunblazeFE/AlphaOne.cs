using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium.BiDi.Modules.Script;
using System;
using System.Collections;
using System.Text.RegularExpressions;
using static SunblazeFE.AlphaTwo;

namespace SunblazeFE
{
    public class AlphaOne
    {
        //Primitives
        static int integer = 16;
        static double decimalValue = 12.45;
        static float realNumber = 3.1417639f;
        static long largeNumber = 100000000000L;
        //Max value for byte is 100
        static byte binaryValue = 100;
        static bool booleanValue = true;
        //Single quotes for Character
        static char character = 'a';

        //Non Primitives
        //Double quotes for String
        static String message = "Alpha One Initialized";
        //Array
        static int[] integerArray = [1, 2, 3, 4, 5, 6, 7];
        static String[] stringArray = ["This", "is", "an", "Array", "from", "a", "String."];
        //List
        List<int> intList = new List<int>{8, 9, 10, 11};
        List<string> stringList = new List<string> {"This", "is", "a", "List"};
        //Tuple
        //Set
        //Dictionary

        [Test]
        public void Integers()
        {
            //Integer Operations
            //Convert String to Integer
            string stringNumber = "12345";
            int intStringNumber = int.Parse(stringNumber);
            //Using System.Math or just System
            //Always return positive number
            int negativeInteger = -4;
            int negativeToPositiveInteger = Math.Abs(negativeInteger);
            //Round down using
            double roundDownInt = Math.Floor(realNumber);
            //Round up using
            double roundUpInt = Math.Ceiling(realNumber);
            //Dividing two Integers will always return a whole number
            int forDivisionInt = 10;
            int divisorInt = 3;
            int divisionResultInt = forDivisionInt / divisorInt;
            //Get number at the power of N
            int numberForPower = 7;
            int powerN = 2;
            int numberAtPowerN = (int)Math.Pow(numberForPower, powerN);
            //Check if number is a perfect square
            double squareRootInt = Math.Sqrt(integer);
            //Get difference between two numbers
            int firstNumber = 40;
            int secondNumber = 13;
            int differenceBetween = Math.Abs(secondNumber - firstNumber);
            //Get current quarter of the year
            int currentMonth = 5;
            int currentQuarter = (int)Math.Ceiling(currentMonth/3.0);

            Console.WriteLine($"Converting String '{stringNumber}' to Integer: {intStringNumber}");
            Console.WriteLine($"{forDivisionInt} can be divided by {divisorInt} a total of {divisionResultInt} times");
            Console.WriteLine($"Current Month {currentMonth} is in Quarter: {currentQuarter} {numberAtPowerN}");

        }

        [Test]
        public void Characters()
        {

        }

        [Test]
        public void Strings()
        {
            //Implicit variable declaration can only be done inside a Method
            var varString = "varString";
            var varInteger = new int[1, 2, 3, 4, 5];

            //String Operations
            string stringValue = "lower case text";
            //Get length of String
            int lengthString = stringValue.Length;
            //Convert to Upper Case
            string upperCase = stringValue.ToUpper();
            //Reverse String
            string reverseString = string.Join("", stringValue.ToCharArray().Reverse().ToArray());
            //Replace part of String
            string replacedMessage = message.Replace("One", "Prime");
            //Get first N characters of a String
            string firstOfString = stringValue.Substring(0, 1);
            //Get last N characters of a String
            string lastOfString = stringValue.Substring(stringValue.Length - 3);
            //Remove First and Last characters of String
            string removeFirstLast = stringValue.Substring(1, stringValue.Length -2);
            //Check if String is Alphabet
            string stringAlphabet = "OnLyAlPhAbEt";
            bool checkAlphabet = Regex.IsMatch(stringAlphabet, @"^[a-zA-Z]+$");
            //Verify if String starts or ends with
            bool startsWith = message.StartsWith("Alpha");
            bool endsWith = message.EndsWith("Initialized");
            //Check if String is Upper Case or Lower Case
            string upperString = "ALLCAPS";
            bool isUpper = upperString.Equals(upperString.ToUpper());
            string lowerString = "alllower";
            bool isLower = lowerString.Equals(lowerString.ToLower());
            //Count occurrences in String
            string occurrencesString = "aabbbbccccddddeeeefffffqqqqqxxyz";
            string[] occurrencesArray = occurrencesString.Select(x => x.ToString()).ToArray();
            string[] occurrencesInString = ["x", "y", "z"];
            int occurrencesInStringCount = 0;
            foreach (string st in occurrencesArray)
            {
                if (occurrencesInString.Contains(st))
                {
                    occurrencesInStringCount += 1;
                }
            }

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
            Console.WriteLine($"The characters '[{string.Join(", ", occurrencesInString)}]' appear in '[{string.Join(", ", occurrencesArray)}]' a total of {occurrencesInStringCount} times");
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
            //Append to Array using System.Linq
            integerArray = integerArray.Append(8).ToArray();
            //Remove item by index from Array => List
            //Generate Array from String
            string stringToArray = "This is an Array from a String.";
            string[] arrayFromString = stringToArray.Split(" ");
            //Generate String from Array with delimiter
            string joinedStringArray = string.Join(" ", stringArray);
            //Reverse Array requires var in C#
            var reverseArray = stringArray.Reverse();
            //Count occurrences in Array
            string[] occurrencesArray = ["a", "a", "b", "c", "d", "d", "e", "e", "f", "x", "x", "y", "y", "z",];
            string[] occurrencesInArray = ["x", "y", "z"];
            int occurrencesInArrayCount = 0;
            foreach (string st in occurrencesArray)
            {
                if (occurrencesInArray.Contains(st))
                {
                    occurrencesInArrayCount += 1;
                }
            }
            //Split String into Integer Array, split to String Array, then convert into Integer Array using System.Linq
            string stringInt = "549713";
            string[] stringIntToArray = stringInt.Select(x => x.ToString()).ToArray();
            int[] stringToIntArray = Array.ConvertAll(stringIntToArray, int.Parse);
            //Get Minimum and Maximum values from an Array using System.Linq
            int minArray = integerArray.Min();
            int maxArray = integerArray.Max();
            //Sum of Array
            int sumArray = integerArray.Sum();
            //Average of Array can return a Double, so use var or OptionalDouble as type
            var averageArray = integerArray.Average();
            //Multiply all elements of Array
            int productArray1 = 1;
            foreach (int num in integerArray)
            {
                productArray1 *= num;
            }                
            int productArray2 = integerArray.Aggregate((a, b) => a * b);
            //Sort an Array, cloning original so it isn't affected
            int[] unsortedArray = { 9, 5, 2, 7, 1, 8, 3, 4 };
            int[] sortedArray = (int[])unsortedArray.Clone();
            Array.Sort(sortedArray);
            //Iterate over object Array using var
            object[] objArray = [1, 2, "3", "4"];
            var objArraySum = 0;
            foreach (var value in objArray)
            {
                objArraySum += int.Parse(value.ToString());
            }
            //Convert from Binary to base 10
            int[] binaryArray = [0, 1, 0, 1];
            int intConvertedFromBinary = 0;
            for (int i = 0; i < binaryArray.Length; i++)
            {
                intConvertedFromBinary += binaryArray[i] * (int)Math.Pow(2, binaryArray.Length - i - 1);
            }

            Console.WriteLine($"Split String '{stringToArray}' into Array '[{string.Join(", ", arrayFromString)}]'");
            Console.WriteLine($"String from joined Array is '{joinedStringArray}'");
            Console.WriteLine($"For [{string.Join(", ", stringArray)}]', Reversed Array is '[{string.Join(", ", reverseArray)}]'");
            Console.WriteLine($"The characters '[{string.Join(", ", occurrencesInArray)}]' appear in '[{string.Join(", ", occurrencesArray)}]' a total of {occurrencesInArrayCount} times");
            Console.WriteLine($"Split '{stringInt}' to Int Array '[{string.Join(", ", stringToIntArray)}]'");
            Console.WriteLine($"Minimum value of Integer Array '[{string.Join(", ", integerArray)}]' is {minArray}, Maximum value is {maxArray}");
            Console.WriteLine($"For Integer Array '[{string.Join(", ", integerArray)}]', Sum is '{sumArray}', Average is '{averageArray}' and Product is'{productArray1}'");
            Console.WriteLine($"Unsorted Array is '[{string.Join(", ", unsortedArray)}]', sorted Array is '[{string.Join(", ", sortedArray)}]'");
            Console.WriteLine($"Sum of Object Array '[{string.Join(", ", objArray)}'] is {objArraySum}");
            Console.WriteLine($"Converting binary number {string.Join("", binaryArray)} to base 10 number is {intConvertedFromBinary}");
        }

        [Test]
        public void Lists()
        {
            //ListOperations(Collections from JAVA)
            int[] arrayForCollection = [2, 6, 4, 76, 102, 5, 17];
            List<int> collectionList = new List<int>();
            //Add an item to Collection
            collectionList.Add(arrayForCollection[0]);
            //Add all items to Collection using add
            foreach (var item in arrayForCollection)
            {
                collectionList.Add(item);
            }
            int collectionSum = 0;
            foreach (var num in collectionList)
            {
                collectionSum += num;
            }
            //Get List length
            int listLength = intList.Count;

            //Use double {{ and }} in $ string
            Console.WriteLine($"Collection is '{{{string.Join(", ", collectionList)}}}', Sum of Collection using is {collectionSum}");
            Console.WriteLine($"List length for '{{{string.Join(", ", intList)}}}' is {listLength}");

        }

        [Test]
        public void Enumerables()
        {
            //Create Array with values between two Integers
            int startInteger = 3;
            int endInteger = 10;
            int[] startEndEnumerated = Enumerable.Range(startInteger, endInteger - startInteger + 1).ToArray();

            Console.WriteLine($"Creating Array starting from {startInteger} to {endInteger}: '[{string.Join(", ", startEndEnumerated)}]'");
        }

        [Test]
        public void Conditionals()
        {
            //If Else Statement
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
            //Switch
            string switchString = "Green Light";
            string waitForSwitch = "";
            switch (switchString)
            {
                case "Yellow Light":
                    waitForSwitch = "Wait for Red Light";
                    break;
                case "Red Light":
                    waitForSwitch = "Wait for Green Light";
                    break;
                default:
                    waitForSwitch = "Wait for Yellow Light";
                    break;
            }
        }

        [Test]
        public void ForLoops()
        {
            //For index in Array
            int forLoopCount = 0;
            for (int i = 0; i < integerArray.Length; i++)
            {
                forLoopCount += integerArray[i];
            }
            //For item in Array
            string forEachString = "";
            foreach (string s in stringArray)
            {
                forEachString += s;
            }
            //Count number of matching characters in a String
            string matchingString = "We will count the number of vowels";
            int countMatchingString = 0;
            string[] matchingStringArray = matchingString.Select(x => x.ToString()).ToArray();
            string[] matchingVowels = ["a", "e", "i", "o", "u"];
            for (int i = 0; i < matchingStringArray.Length; i++)
            {
                //Using .matches() with expression to count all vowels
                if (matchingVowels.Contains(matchingStringArray[i]))
                {
                    countMatchingString += 1;
                }
            }
            
            Console.WriteLine($"Using Index For Loop to count Array '[{string.Join(", ", integerArray)}]' returns {forLoopCount}");
            Console.WriteLine($"Using Foreach Loop on every element in Array '[{string.Join(" ", stringArray)}]' returns the following String '{forEachString}'");
            Console.WriteLine($"The number of vowels in '{matchingString}' is {countMatchingString}");
        }

        [Test]
        public void WhileLoops()
        {
            //Calculate number of divisors in a number, example: 30 has 1, 2, 3, 5, 6, 10, 15 and 30
            int intDivisors = 30;
            int numberOfDivisors = 1;
            int whileIterator = 1;
            while (whileIterator < intDivisors)
            {
                //Check if number can be divided by iterator
                if (intDivisors % whileIterator == 0)
                {
                    numberOfDivisors += 1;
                }
                whileIterator += 1;
            }

            Console.WriteLine($"The number {intDivisors} has {numberOfDivisors} divisors");
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
            //Create instance of Subclass(shorthand)
            AlphaTwoSub _alphaTwoSub = new();
            //Subclass inherits method from Superclass
            int alphaTwoSubIntSum = _alphaTwoSub.SumIntArray(_alphaTwoSub.alphaTwoIntArray);

            Console.WriteLine($"After creating instance of Class AlphaTwo, using its method SumIntArray to calculate sum of '[{string.Join(", ", integerArray)}]' is {alphaTwoIntSum}");
            Console.WriteLine($"Static method of Class AlphaTwo AverageIntArray used to calculate average of '[{string.Join(", ", integerArray)}]' is {alphaTwoIntAverage}");
            _alphaTwo.VoidAlphaTwo();
            Console.WriteLine($"Method overloading from Class AlphaTwo of ReverseString Method using second parameter returns '{_alphaTwo.ReverseString(_alphaTwo.outerAlphaTwoString, _alphaTwo.overLoadString)}");
            Console.WriteLine($"Method of Inner Class InnerAlphaTwo MinIntArray used to retrieve minimum value of '[{string.Join(", ", integerArray)}]' is {innerAlphaTwoIntMin}");
            _innerAlphaTwo.InnerAlphaTwoGet();
            Console.WriteLine($"Array Field from AlphaTwo is '[{string.Join(", ", _alphaTwo.alphaTwoIntArray)}]', from AlphaTwoSub is '[{string.Join(", ", _alphaTwoSub.alphaTwoIntArray)}]'");
            Console.WriteLine($"AlphaTwoSub is a Subclass and has inherited SumIntArray from AlphaTwo to sum '[{string.Join(", ", _alphaTwoSub.alphaTwoIntArray)}]', resulting in {alphaTwoSubIntSum}]");
            Console.WriteLine($"AlphaTwoSub's String has been reversed using Base Class' Method: '{_alphaTwoSub.alphaTwoSubString}'");
        }
    }
}