
namespace SunblazeFE
{
    //Subclass of AlphaTwo
    class AlphaTwoSub: AlphaTwo
    {
        public string alphaTwoSubString = "This is AlphaTwoSub's String";

        //Subclass Constructor
        public AlphaTwoSub(): base()
        {
            this.alphaTwoIntArray[4] = 6;
            //Use Method of Base Class, in C# this must be a Public Non-Static Method
            this.alphaTwoSubString = base.ReverseString(alphaTwoSubString);
        }
        

    }
}
