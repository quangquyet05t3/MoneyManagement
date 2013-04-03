using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Resources;

namespace MoneyManagement
{
    public static class PublicVariables
    {
        public static List<Data> listData = new List<Data>();
        public static CultureInfo AppCulture = null;
        public static Language.Language Language = global::Language.Language.English;
        public static string MessageError = null;
        public static string CaptionError = null;
        public static string MessageDelete = null;
        public static string CaptionDelete = null;
        public static string MessageDeleteError = null;
        public static string MessageDeleteUnable = null;
        public static string MessageUnderConstruction = null;
        public static string CaptionUnderConstruction = null;
    }
}
