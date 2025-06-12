using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using static OpenQA.Selenium.BiDi.Modules.Script.EvaluateResult;
using static SunblazeFE.AlphaTwo;
using static System.Net.Mime.MediaTypeNames;

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

            Console.WriteLine($"Integer Operations");
            Console.WriteLine($"Converting String '{stringNumber}' to Integer: {intStringNumber}");
            Console.WriteLine($"{forDivisionInt} can be divided by {divisorInt} a total of {divisionResultInt} times");
            Console.WriteLine($"Current Month {currentMonth} is in Quarter: {currentQuarter} {numberAtPowerN}");

        }

        [Test]
        public void Characters()
        {
            Console.WriteLine($"Character Operations");
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
            //Check if String contains a substring using System.Linq
            string containsString = "34enGliSh12";
            bool containsBool = containsString.ToLower().Contains("english");
            //Replace part of String
            string replacedMessage = message.Replace("One", "Prime");
            //Replace all instances of character in String
            string replaceInstances = "T!hi!s i!s a !Str!in!g!";
            string replacedInstances = replaceInstances.Replace("!", "");
            //Replace multiple characters at once using System.Text.RegularExpressions
            string replaceMultiple = "This will be A String wIthoUt all vOwels";
            Regex replacePattern = new Regex("[aeiouAEIOU]");
            string replacedMultiple = replacePattern.Replace(replaceMultiple, "");
            //Add a character N times to a String
            string fiveStars = new string(new char[5]).Replace("\0", "*");
            //Get first N characters of a String
            string firstOfString = stringValue.Substring(0, 1);
            //Get last N characters of a String
            string lastOfString1 = stringValue.Substring(stringValue.Length - 3);
            char lastOfString2 = stringValue[^1];
            //Remove First and Last characters of String
            string removeFirstLast = stringValue.Substring(1, stringValue.Length -2);
            //Remove part of String that comes after unique delimiter
            string toRemoveAnchorString = "www.codewars.com#about";
            string removedAnchorString = toRemoveAnchorString.Split("#")[0];
            //Check if String is Alphabet
            string stringAlphabet = "OnLyAlPhAbEt";
            bool checkAlphabet = Regex.IsMatch(stringAlphabet, @"^[a-zA-Z]+$");
            //Count number of instances of a Character in String using System.Linq
            string countString = "n___nnnn____n_";
            int countCharInString = countString.Count(c => c == 'n');
            //Check if String starts with characters using System.Text.RegularExpressions
            string startsRangeString = "123";
            bool matchStartsRange1 = Regex.IsMatch(startsRangeString, "^[1-3]"); //Range
            bool matchStartsRange2 = Regex.IsMatch(startsRangeString, "^[2,3,4]"); //Individually specified
            //Check if String contains any characters other than specified combination and also of certain length
            string matchCharactersString = "regex_34";
            string noMatchCharactersString = "H 3";
            //Check if String contains any characters other than specified combination and also of certain length
            string matchCharactersRegex = "[a-z0-9_]{4,16}";
            bool matchCharactersBool = Regex.IsMatch(matchCharactersString, matchCharactersRegex);
            bool noMatchCharactersBool = Regex.IsMatch(noMatchCharactersString, matchCharactersRegex);
            //Remove all non-alphabet or non-digit characters using [^'exclude'] using System.Text.RegularExpressions
            string stringMixed = "ultr53o?n";
            Regex removeDigitsPattern = new Regex("[^a-z]");
            string removeDigits = removeDigitsPattern.Replace(stringMixed, "");
            Regex removeAlphabetPattern = new Regex("[^0-9]");
            string removeAlphabet = removeAlphabetPattern.Replace(stringMixed, "");
            //Verify if String starts or ends with
            bool startsWith = message.StartsWith("Alpha");
            bool endsWith = message.EndsWith("Initialized");
            //Check if String is Upper Case or Lower Case
            string upperString = "ALLCAPS";
            bool isUpper = upperString.Equals(upperString.ToUpper());
            string lowerString = "alllower";
            bool isLower = lowerString.Equals(lowerString.ToLower());
            //Count occurrences in String using System.Linq
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
            //Concatenate range from Array
            string[] toConcatenateArray = { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" };
            //2 is starting index and 4 is how many elements to get, not end of range
            string stringConcatenated = string.Join("", toConcatenateArray, 2, 4);


            //String Interpolation format is easier to work with
            Console.WriteLine($"String Operations");
            Console.WriteLine($"String length for '{stringValue}' is {lengthString}");
            Console.WriteLine($"Reversed String is '{reverseString}'");
            Console.WriteLine($"String '{containsString}' contains 'english' case insensitive: {containsBool}");
            Console.WriteLine($"From '{replaceInstances}' removing all instances of '!': '{replacedInstances}'");
            Console.WriteLine($"Removing all vowels from String '{replaceMultiple}' results in: '{replacedMultiple}'");
            Console.WriteLine($"Generating strings with 5 times the character *: '{fiveStars}'");
            Console.WriteLine($"First character from '{stringValue}' is '{firstOfString}'");
            Console.WriteLine($"Last 3 characters from '{stringValue}' are '{lastOfString1}', last 1 as Character: {lastOfString2}");
            Console.WriteLine($"Removing first and last characters from '{stringValue}' results in '{removeFirstLast}'");
            Console.WriteLine($"Remove from '{toRemoveAnchorString}' everything that comes after #: '{removedAnchorString}'");
            Console.WriteLine($"'{stringAlphabet}' contains only alphabet characters: {checkAlphabet}");
            Console.WriteLine($"The character 'n' appears {countCharInString} times in String '{countString}'");
            Console.WriteLine($"'{startsRangeString}' starts with characters from range [1 - 3]: {matchStartsRange1}, but does it start with one of [2,3,4]: {matchStartsRange2}");
            Console.WriteLine($"'{matchCharactersString}' has length between 4 and 6 and only contains lowercase alphabet,_ and numbers: {matchCharactersBool}");
            Console.WriteLine($"'{noMatchCharactersString}' has length between 4 and 6 and only contains lowercase alphabet,_ and numbers: {noMatchCharactersBool}");
            Console.WriteLine($"'{stringMixed}' removing all non-digit characters: {removeAlphabet}");
            Console.WriteLine($"'{stringMixed}' removing all non-alphabet characters: {removeDigits}");
            Console.WriteLine($"'{replacedMessage}' starts with Alpha: '{startsWith}' and ends with Initialized: '{endsWith}'");
            Console.WriteLine($"'{upperString}' is all Upper Case: {isUpper}");
            Console.WriteLine($"'{lowerString}' is all Lower Case: {isLower}");
            Console.WriteLine($"The characters '[{string.Join(", ", occurrencesInString)}]' appear in '[{string.Join(", ", occurrencesArray)}]' a total of {occurrencesInStringCount} times");
            Console.WriteLine($"Creating concatenated string from '[{string.Join(", ", toConcatenateArray)}]' starting from index 2 and concatenating 4 elements: {stringConcatenated}");
        }

        [Test]
        public void Arrays()
        {
            //Array Operations
            //Get length of Array
            int lengthArray = stringArray.Length;
            //Check if Array is empty
            string[] emptyArray = new string[] { };
            bool isArrayEmpty = emptyArray.Length == 0;
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
            //Reverse Array, convert Enumerable stream to Array
            string[] reverseArray1 = stringArray.Reverse().ToArray();
            string[] reverseArray2 = stringArray.OrderByDescending(a => a).ToArray();
            //Join 2 Arrays with no duplicates(Unordered Set) using System.Linq
            int[] arrJoin1 = new[] { 1, 3, 5, 7, 9, 8 };
            int[] arrJoin2 = new[] { 10, 8, 6, 4, 2, 10 };
            int[] arrSet = arrJoin1.Union(arrJoin2).ToArray();
            //Compare if two Arrays are equal using System.Linq
            int[] equalArray1 = new int[] { 1, 2, 3, 4 };
            int[] equalArray2 = new int[] { 1, 2, 3, 4 };
            int[] equalArray3 = new int[] { 1, 2, 5, 4 };
            bool equalsArr1Arr2 = Enumerable.SequenceEqual(equalArray1, equalArray2);
            bool equalsArr1Arr3 = equalArray1.SequenceEqual(equalArray3);
            //Check if array contains value using System.Linq
            int[] containsValueArray = new int[] { 1, 2, 3, 4 };
            int containsValue1 = 3;
            int containsValue2 = 5;
            bool containsBool1 = containsValueArray.Contains(containsValue1) ? true : false;
            bool containsBool2 = containsValueArray.Contains(containsValue2) ? true : false;
            //Count occurrences of specific set of items in Array using System.Linq;
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
            //Split Integer into Integer Array using System.Linq
            int intForArray = 1234567;
            int[] intToArray = intForArray.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
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
            //Sort an Array, cloning original so it isn't affected or use OrderBy
            int[] unsortedArray = { 9, 5, 2, 7, 1, 8, 3, 4, 5 };
            int[] sortedArray1 = (int[])unsortedArray.Clone();
            Array.Sort(sortedArray1);
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
            //Concatenate each entry N times from existing Array
            string[] toConcatenateArray = { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" };
            int intConcatenate = 3;
            string[] arrConcatenate = new string[toConcatenateArray.Length + 1 - intConcatenate];
            for (int i = 0; i < toConcatenateArray.Length - intConcatenate + 1; i++)
            {
                //i for starting range and intConcatenate for how many elements to get, not end of range
                arrConcatenate[i] = string.Join("", toConcatenateArray, i, intConcatenate);
            }
            //Multidimensional Array
            int[,] twoDimArrayMin = new int[3, 5] { { 7, 9, 8, 6, 2 }, { 6, 3, 5, 4, 3 }, { 5, 8, 7, 4, 5 } };
            //Iterating over 2D Array to get the minimum of each entry
            int twoDimMinCount = 0;
            //Use GetLength() instead of Length, Array is of size [3,5] so GetLength(0) is 3 for outer Array
            for (int i = 0; i < twoDimArray.GetLength(0); i++)
            {
                //Array is of size [3,5] so GetLength(1) is 5 for inner Array
                int[] num = new int[twoDimArrayMin.GetLength(1)];
                for (int j = 0; j < twoDimArrayMin.GetLength(1); j++)
                {
                    num[j] = twoDimArrayMin[i, j];
                }
                twoDimMinCount += num.Min();
            }

            Console.WriteLine($"Array Operations");
            Console.WriteLine($"Check if Array '[{string.Join(", ", emptyArray)}]' is empty:{isArrayEmpty}");
            Console.WriteLine($"Split String '{stringToArray}' into Array '[{string.Join(", ", arrayFromString)}]'");
            Console.WriteLine($"String from joined Array is '{joinedStringArray}'");
            Console.WriteLine($"For [{string.Join(", ", stringArray)}]', Reversed Array is '[{string.Join(", ", reverseArray1)}], using OrderByDescending [{string.Join(", ", reverseArray2)}]'");
            Console.WriteLine($"Joining Array '[{string.Join(", ", arrJoin1)}]' with Array '[{string.Join(", ", arrJoin2)}]' and eliminating duplicates(Unordered Set as Array): '[{string.Join(", ", arrSet)}]'");
            Console.WriteLine($"Array '[{string.Join(", ", equalArray1)}]' is equal to Array '[{string.Join(", ", equalArray2)}]': {equalsArr1Arr2}");
            Console.WriteLine($"Array '[{string.Join(", ", equalArray1)}]' is equal to Array '[{string.Join(", ", equalArray3)}]': {equalsArr1Arr3}");
            Console.WriteLine($"Array '[{string.Join(", ", containsValueArray)}]' contains {containsValue1}: {containsBool1} and also contains {containsValue2}: {containsBool2}");
            Console.WriteLine($"The characters '[{string.Join(", ", occurrencesInArray)}]' appear in '[{string.Join(", ", occurrencesArray)}]' a total of {occurrencesInArrayCount} times");
            Console.WriteLine($"Split {intForArray} to Int Array '[{string.Join(", ", intToArray)}]'");
            Console.WriteLine($"Split '{stringInt}' to Int Array '[{string.Join(", ", stringToIntArray)}]'");
            Console.WriteLine($"Minimum value of Integer Array '[{string.Join(", ", integerArray)}]' is {minArray}, Maximum value is {maxArray}");
            Console.WriteLine($"For Integer Array '[{string.Join(", ", integerArray)}]', Sum is '{sumArray}', Average is '{averageArray}' and Product is'{productArray1}'");
            Console.WriteLine($"Unsorted Array is '[{string.Join(", ", unsortedArray)}]', sorted Array is: using Sort '[{string.Join(", ", sortedArray1)}]'");
            Console.WriteLine($"Sum of Object Array '[{string.Join(", ", objArray)}'] is {objArraySum}");
            Console.WriteLine($"Converting binary number {string.Join("", binaryArray)} to base 10 number is {intConvertedFromBinary}");
            Console.WriteLine($"Creating a new Array from '[{string.Join(", ", toConcatenateArray)}]' and concatenating {intConcatenate} times: '[{string.Join(", ", arrConcatenate)}]'");
            Console.WriteLine($"From 2D Array '{{ {{ 7, 9, 8, 6, 2 }}, {{ 6, 3, 5, 4, 3 }}, {{ 5, 8, 7, 4, 5 }} }}' adding all Minimum values of each inner array is: {twoDimMinCount}");
        }

        [Test]
        public void Lists()
        {
            //List Operations using System.Collections.Generic
            int[] arrayForList = [2, 6, 4, 76, 102, 5, 17];
            List<int> collectionList = new List<int>();
            //Add an item to Collection
            collectionList.Add(arrayForList[0]);
            //Add all items to Collection using add
            foreach (var item in arrayForList)
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
            //Convert List to Array
            int[] arrList = collectionList.ToArray();

            //Use double {{ and }} in $ string
            Console.WriteLine($"List Operations");
            Console.WriteLine($"Collection is '{{{string.Join(", ", collectionList)}}}', Sum of Collection using is {collectionSum}");
            Console.WriteLine($"List length for '{{{string.Join(", ", intList)}}}' is {listLength}");
            Console.WriteLine($"Converting List to Array '[{string.Join(", ", arrList)}]'");

        }

        [Test]
        public void Sets()
        {
            //Create Unordered Set to get unique occurences of Array in order they appeared using System.Collections.Generic and System.Linq
            int[] arrayForUnorderedSet = { 1, 2, 1, 1, 3, 2 };
            HashSet<int> intSet = new HashSet<int>(arrayForUnorderedSet);
            for (int i = 0; i < arrayForUnorderedSet.Length; i++)
            {
                intSet.Add(arrayForUnorderedSet[i]);
            }
            Console.WriteLine($"Sets");
            Console.WriteLine($"Getting unique values from Array '[{string.Join(", ", arrayForUnorderedSet)}]' in the same order using an Unordered Set: '{{{string.Join(", ", intSet)}}}'");
        }

        [Test]
        public void Dictionaries()
        {
            //using System.Collections.Generic and System.Linq;
            //Create new Dictionary
            Dictionary<string, int> newDict = new Dictionary<string, int>();
            //Add items to Dictionary
            newDict.Add("oranges", 4);
            newDict.Add("pears", 1);
            newDict.Add("apple", 2);
            newDict.Add("bananas", 3);
            //Get value from Dictionary
            int bananaCount = newDict["bananas"];
            //Get entry at index of Dictionary
            var newDictEntryAtIndex = newDict.ElementAt(0);
            //Sort Dictionary by Value
            var newDictSortedByValue = newDict.OrderBy(value => value.Value);
            //Sort Dictionary by Key
            var newDictSortedByKey = newDict.OrderBy(value => value.Key);
            //Count occurrences of items in Array using Dictionary(Worldpay)
            int[] intOccurrencesArray = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            Dictionary<string, int> dictOccurrences = new Dictionary<string, int>();
            for (int i = 0; i < intOccurrencesArray.Length; i++)
            {
                //If Dictionary does not contain the Key yet, add it
                if (!dictOccurrences.ContainsKey($"'{intOccurrencesArray[i].ToString()}'"))
                {
                    dictOccurrences.Add($"'{intOccurrencesArray[i].ToString()}'", 1);
                }
                else
                {
                    dictOccurrences[$"'{intOccurrencesArray[i].ToString()}'"]++;
                }
            }
            //Sort Array of Strings by length using Dictionary
            string[] stringArrayUnordered = ["Telescopes", "Glasses", "Eyes", "Monocles"];
            Dictionary<int, string> dictUnordered = new Dictionary<int, string>();
            for (int i = 0; i < stringArrayUnordered.Length; i++)
            {
                dictUnordered.Add(stringArrayUnordered[i].Length, stringArrayUnordered[i]);
            }
            string[] stringArrayOrdered = new string[stringArrayUnordered.Length];
            //Order Dictionary while iterating over it
            for (int i = 0; i < stringArrayOrdered.Length; i++)
            {
                stringArrayOrdered[i] = dictUnordered.OrderBy(value => value.Key).ElementAt(i).Value;
            }
            Console.WriteLine($"Dictionaries");
            Console.WriteLine($"From '{{{string.Join(", ", newDict)}}}' getting the number of bananas: {bananaCount}");
            Console.WriteLine($"From '{{{string.Join(", ", newDict)}}}' get entry at Index 0: {newDictEntryAtIndex}");
            Console.WriteLine($"Sorting '{{{string.Join(", ", newDict)}}}' by Value: '{{{string.Join(", ", newDictSortedByValue)}}}'");
            Console.WriteLine($"Sorting '{{{string.Join(", ", newDict)}}}' by Key: '{{{string.Join(", ", newDictSortedByKey)}}}'");
            Console.WriteLine($"Counting occurrence of each unique item in Array '[{string.Join(", ", intOccurrencesArray)}]' and storing in Dictionary '{{{string.Join(", ", dictOccurrences)}}}'");
            Console.WriteLine($"Ordering Array of Strings '[{string.Join(", ", stringArrayUnordered)}]' by length using Dictionary: '[{string.Join(", ", stringArrayOrdered)}]'");
        }

        [Test]
        public void Enumerables()
        {
            //using System.Linq
            //Create Array with values between two Integers
            int startInteger = 3;
            int endInteger = 10;
            int[] startEndEnumerated = Enumerable.Range(startInteger, endInteger - startInteger + 1).ToArray();
            //Sort Array
            int[] unsortedArray = { 9, 5, 2, 7, 1, 8, 3, 4, 5 };
            int[] sortedArray2 = unsortedArray.OrderBy(i => i).ToArray();
            //Create an Array with conditions
            int[] arrForCondition1 = new int[] { 4, 1, 1, 3, 2, 3 };
            int[] arrForCondition2 = new int[] { 1, 2 };
            int[] arrCondition1 = arrForCondition1.Where(n => !arrForCondition2.Contains(n)).ToArray(); //where first Array doesn't contain second
            //Get every odd element(first, third, fith, etc), since i starts at zero, the expression % will be for even indexes
            int[] arrCondition2 = arrForCondition1.Where((e, i) => i % 2 == 0).ToArray(); //'i' is the iterator ,'e' is the element itself
            //Get max number of occurrences of item in array and return max value of occurrence if there are two with the same number
            int[] arrMaxOcc = new int[] { 10, 12, 8, 12, 7, 10, 6, 4, 10, 12 };
            int[] maxOcc = arrMaxOcc
              .GroupBy(i => i)
              .OrderByDescending(gr => gr.Count()) //creates a stream sorted by Count of occurrences: 10:3, 12:3, 8:1, 7:1, 6:1, 4:1
              .ThenByDescending(gr => gr.Key) //sort again so that highest Key with max occurrence is first: 12:3, 10,3, 8:1, 7:1, 6:1, 4:1
              .Select(x => new[] { x.Key, x.Count() }).ToArray() //create two dim array out of stream: [[12, 3], [10, 3], [8, 1], [7,1], [6,1], [4,1]]
              .First(); //Select first array from stream and [0] for Key, [1] for Value
            int maxOccKey = maxOcc[0];
            int maxOccValue = maxOcc[1];
            //Get single element from a sequence that satisfies a condition
            int[] arrSingle = new int[] { 1, 2, 2, 2 };
            int singleElement = arrSingle.GroupBy(x => x).Single(x => x.Count() == 1).Key; //unique element has Count of 1

            Console.WriteLine($"Enumerable Operations");
            Console.WriteLine($"Creating Array starting from {startInteger} to {endInteger}: '[{string.Join(", ", startEndEnumerated)}]'");
            Console.WriteLine($"Unsorted Array is '[{string.Join(", ", unsortedArray)}]', sorted Array using OrderBy: '[{string.Join(", ", sortedArray2)}]'");
            Console.WriteLine($"Removing all occurrences of '[{string.Join(", ", arrForCondition2)}]' from '[{string.Join(", ", arrForCondition1)}]' using Where condition: '[{string.Join(", ", arrCondition1)}]'");
            Console.WriteLine($"From '[{string.Join(", ", arrForCondition1)}]' get every odd element: '[{string.Join(", ", arrCondition2)}]'");
            Console.WriteLine($"Counting occurrences of each item in '[{string.Join(", ", arrMaxOcc)}]' and returning highest entry with max number of occurrences '{maxOccKey}:{maxOccValue}'");
            Console.WriteLine($"From '[{string.Join(", ", arrSingle)}]' the only unique element is: {singleElement}");

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
            //If statement with AND
            if (integerArray[0] == 1 && integerArray[1] == 2)
            {
                condition = true;
            }
            //If statement with OR
            if (integerArray[0] == 1 || integerArray[1] == 2)
            {
                condition = true;
            }
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
            Console.WriteLine($"Conditionals");
            Console.WriteLine(condition);
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
            //Reverse For Loop
            int[] reverseLoopArray = new int[integerArray.Length];
            for (int i = integerArray.Length - 1; i >= 0; i--) {
                reverseLoopArray[integerArray.Length - i - 1] = integerArray[i];
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

            Console.WriteLine($"For Loops");
            Console.WriteLine($"Using Index For Loop to count Array '[{string.Join(", ", integerArray)}]' returns {forLoopCount}");
            Console.WriteLine($"Using Foreach Loop on every element in Array '[{string.Join(" ", stringArray)}]' returns the following String '{forEachString}'");
            Console.WriteLine($"Using Reverse For Loop to created Reversed Array: '[{string.Join(", ", reverseLoopArray)}]'");
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

            Console.WriteLine($"While Loops");
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

            Console.WriteLine($"OOP");
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

        [Test]
        public void TryCatchFinally()
        {
            string filePathCorrectDate = "../../../resources/Exception Correct Date.txt";
            string filePathIncorrectDate = "../../../resources/Exception Incorrect Date.txt";
            string? dataTextFile = AlphaTwo.getTextFile(filePathCorrectDate);

            Console.WriteLine($"Exception Handling");
            Console.WriteLine($"Reading Text File and parsing date: {dataTextFile}");
            //Incorrect Date exception
            AlphaTwo.getTextFile(filePathIncorrectDate);
            //Missing path exception
            AlphaTwo.getTextFile("");
            //Incorrect path exception
            AlphaTwo.getTextFile("/main/file.txt");
            //Throw incorrect argument exception using System;
            int argument = -10;
            if (argument < 0)
            {
                throw new ArgumentException($"Argument Exception: {argument} is less than 0");
                //Use ; for similar functionality to pass in Python
                ;
            }
        }

        [Test]
        public void GetJSONFile()
        {
            string filePath = "../../../resources/Resources.json";
            JsonDocument? jsonData = AlphaTwo.getJSON(filePath);
            JsonElement root = jsonData.RootElement;

            string name = root.GetProperty("name").GetString();
            int age = root.GetProperty("age").GetInt32();
            string email = root.GetProperty("email").GetString();
            bool isEmployed = root.GetProperty("isEmployed").GetBoolean();

            JsonElement address = root.GetProperty("address");
            string street = address.GetProperty("street").GetString();
            string city = address.GetProperty("city").GetString();
            string zipCode = address.GetProperty("zipCode").GetString();
            JsonElement skills = root.GetProperty("skills"); //Gets Array

            Console.WriteLine($"Read JSON file");
            Console.WriteLine($"Reading JSON root: \nname: '{name}' age: '{age}' email: '{email}' isEmployed: '{isEmployed}'");
            Console.WriteLine($"Reading JSON address: \nstreet: '{street}' city: '{city}' zipCode: '{zipCode}'");
            Console.WriteLine($"Reading JSON skills: \n{skills[0]} {skills[1]} {skills[2]} {skills[3]}");
        }

        [Test]
        public void Exercise()
        {
            Console.WriteLine($"Exercise");
        }
    }
}