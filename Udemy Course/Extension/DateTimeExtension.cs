using System.Globalization;

// namespace Udemy_Course.Extension
// You can create the extension method in the same namespace of the type that you want to you
namespace System
{
    static class DateTimeExtension
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24)
            {
                return $"{duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture)} hours";
            }
            else
            {
                return $"{duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture)} days";
            }
        }
    }
}
