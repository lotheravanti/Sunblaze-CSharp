using System.Text.Json;

namespace SunblazeFE
{
    //Superclass/Base Class
    public class AlphaTwo
    {
        //Fields/Properties
        public string outerAlphaTwoString;
        static string? staticAlphaTwoString;
        public int[] alphaTwoIntArray = [1, 2, 3, 4, 0];
        public string overLoadString = "OVERLOADED";

        //Constructor needs to be made public in C#
        public AlphaTwo()
        {
            this.outerAlphaTwoString = "This is AlphaTwo's String";
            staticAlphaTwoString = "This is AlphaTwo's Static String and can be used in Inner Class";
            this.alphaTwoIntArray[4] = 5;
        }

        //Methods
        //Public method, C# is an OOP language and doesn't have functions that are declared outside of classes
        //All functions in C# are actually methods
        public int SumIntArray(int[] intArray)
        {
            return intArray.Sum();
        }
        //Static method, can be used without instantiating Object
        public static int AverageIntArray(int[] intArray)
        {
            return intArray.Sum()/intArray.Length;
        }
        //Void method does not have return type, it only executes code
        public void VoidAlphaTwo()
        {
            Console.WriteLine($"AlphaTwo's Void method returned: {outerAlphaTwoString}");
        }
        public string ReverseString(string s)
        {
            return string.Join("", s.ToCharArray().Reverse().ToArray());
        }
        //Method overloading, using same name but differing number of parameters
        public string ReverseString(string s, string overLoad)
        {
            return overLoad + string.Join("", s.ToCharArray().Reverse().ToArray());
        }
        public static string? getTextFile(string filePath)
        {
            StreamReader? streamReader = null;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                streamReader = new StreamReader(filePath);
                //Read the first line of text
                string? fileValueString = streamReader.ReadLine();
                //For demonstration purposes, attempting to parse file value as date
                DateTime.Parse(fileValueString);
                return fileValueString;
            }
            //Catch example for empty file path
            catch (ArgumentException e)
            {
                //Handling errors in order: Empty file path > File not Found > File could not be read
                Console.WriteLine($"Provided path was empty: {e.Message}");
                return null;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File not found: {e.Message}");
                return null;
            }
            //Catch example for file could not be read
            catch (IOException e)
            {
                Console.WriteLine($"Could not read data: {e.Message}");
                return null;
            }
            //Catch example for file could not be read
            catch (FormatException e)
            {
                Console.WriteLine($"Invalid Date format: {e.Message}");
                return null;
            }
            //Make sure to close Stream Reader so file doesn't remain open
            finally
            {
                if (streamReader != null)
                {
                    try
                    {
                        streamReader.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Closing file: {e.Message}");
                    }
                }
            }
        }
        public static JsonDocument? getJSON(string filePath)
        {
            FileStream? fileStream = null;
            JsonDocument? jsonData = null;

            try
            {
                fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                jsonData = JsonDocument.Parse(fileStream);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error reading JSON file: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error parsing JSON: {e.Message}");
            }
            finally
            {
                fileStream?.Close();
            }
            return jsonData;
        }
        //Generics can be used to process multiple data types, for example either an array of strings or integers
        public static string GenericTwoDimArrayPrinter<T>(T[,] arr)
        {
            string printArr = "[";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                printArr += "[";
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j < arr.GetLength(1) - 1)
                    {
                        printArr += $"{arr[i, j]}, ";
                    }
                    else
                    {
                        printArr += $"{arr[i, j]}]";
                    }
                }
                if (i < arr.GetLength(0) - 1)
                {
                    printArr += $", ";
                }
                else
                {
                    printArr += $"]";
                }
            }
            return printArr;
        }
        public static string GenericJaggedTwoDimArrayPrinter<T>(T[][] arr)
        {
            string printArr = "[";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                printArr += $"[{string.Join(", ", arr[i])}";
                if (i < arr.GetLength(0) - 1)
                {
                    printArr += $"], ";
                }
                else
                {
                    printArr += $"]";
                }
            }
            printArr += "]";
            return printArr;
        }

        //Inner Class can not be static in C#, compared to JAVA
        public class InnerAlphaTwo
        {
            string? innerAlphaTwoString;

            //Setter
            public void InnerAlphaTwoSet()
            {
                innerAlphaTwoString = "This is InnerAlphaTwo's String";
                staticAlphaTwoString = "AlphaTwo's Static String has been updated from within InnerAlphaTwo";
            }

            //Getter
            public void InnerAlphaTwoGet()
            {
                Console.WriteLine($"Inner Class of AlphaTwo's property reads: {innerAlphaTwoString}");
                //Public outerAlphaTwoString cannot be used in Inner Class, but static staticAlphaTwoString can
                Console.WriteLine(staticAlphaTwoString);
            }

            public int MinIntArray(int[] intArray)
            {
                return intArray.Min();
            }
        }
    }
}
