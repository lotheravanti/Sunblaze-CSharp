
namespace SunblazeFE
{
    public class AlphaTwo
    {
        //Properties
        public string outerAlphaTwoString;
        static string? staticAlphaTwoString;

        //Constructor needs to be made public in C#
        public AlphaTwo()
        {
            this.outerAlphaTwoString = "This is AlphaTwo's String";
            staticAlphaTwoString = "This is AlphaTwo's Static String and can be used in Inner Class";
        }

        //Methods
        //Public method, C# is an OOP language and doesn't have functions that are declared outside of classes
        //All functions in C# are actually methods
        public int SumIntArray(int[] intArray)
        {
            return intArray.Sum();
        }
        //Static method
        public static int AverageIntArray(int[] intArray)
        {
            return intArray.Sum()/intArray.Length;
        }
        //Void method does not have return type, it only executes code
        public void VoidAlphaTwo()
        {
            Console.WriteLine($"AlphaTwo's Void method returned: {outerAlphaTwoString}");
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
