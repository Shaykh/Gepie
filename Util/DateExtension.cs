using System;

namespace Gepie.Util
{
    public static class DateExtension
    {
        public const string FORMAT_DATE_COMPLET = "dd-MM-yyyy à HH:mm";
        public const string FORMAT_DATE = "dd-MM-yyyy";

        public static string DisplayFull(this DateTime value)
        {
            return value.ToString(FORMAT_DATE_COMPLET);
        }

        public static string DisplayFull(this DateTime? value)
        {
            return value.HasValue ? value.Value.DisplayFull() : "Non Défini";
        }

        public static string Display(this DateTime value)
        {
            return value.ToString(FORMAT_DATE);
        }

        public static string Display(this DateTime? value)
        {
            return value.HasValue ? value.Value.Display() : "Non Défini";
        }

    }
}