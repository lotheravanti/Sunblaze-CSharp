
namespace SunblazeFE
{
    public class AlphaTwo
    {
        //Properties
        string alphaTwoString;

        //Constructor needs to be made public in C#
        public AlphaTwo()
        {
            this.alphaTwoString = "This is AlphaTwo's String";
        }

        //Methods
        public int SumIntArray(int[] intArray)
        {
            return intArray.Sum();
        }
    }
}
