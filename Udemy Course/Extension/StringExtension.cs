// namespace Udemy_Course.Extension
// You can create the extension method in the same namespace of the type that you want to you
namespace System
{
    static class StringExtension
    {
        public static string Cut(this string thisObj, int count)
        {
            if (thisObj.Length <= count)
            {
                return thisObj;
            } 
            else
            {
                return thisObj.Substring(0,count) + "...";
            }
        }
    }
}
