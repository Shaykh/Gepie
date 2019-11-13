using System;

namespace Gepie.Util
{
    public static class ValueExtension
    {
        public const string CULTURE_STRING_CI = "fr-CI";
     
        public static string Display(this decimal nombre)
        {
            return nombre.ToString("### ### ### ### ##0.###").Trim();
        }

        public static string Display(this decimal? nombre)
        {
            return nombre.HasValue ? nombre.Value.Display() : "Non Défini";
        }
        
        public static string Display(this double nombre)
        {
            return nombre.ToString("### ### ### ### ##0.###").Trim();
        }

        public static string Display(this double? nombre)
        {
            return nombre.HasValue ? nombre.Value.Display() : "Non Défini";
        }

        public static string Display(this short nombre)
        {
            return nombre.ToString("N0", System.Globalization.CultureInfo.CreateSpecificCulture(CULTURE_STRING_CI));
        }

        public static string Display(this short? nombre)
        {
            return nombre.HasValue ? nombre.Value.Display() : "Non Défini";
        }

        public static string Display(this int nombre)
        {
            return nombre.ToString("N0", System.Globalization.CultureInfo.CreateSpecificCulture(CULTURE_STRING_CI));
        }

        public static string Display(this int? nombre)
        {
            return nombre.HasValue ? nombre.Value.Display() : "Non Défini";
        }

        public static string Display(this long nombre)
        {
            return nombre.ToString("N0", System.Globalization.CultureInfo.CreateSpecificCulture(CULTURE_STRING_CI));
        }

        public static string Display(this long? nombre)
        {
            return nombre.HasValue ? nombre.Value.Display() : "Non Défini";
        }

        public static string DisplayCFA(this decimal nombre)
        {
            return nombre.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture(CULTURE_STRING_CI));
        }

    }
}