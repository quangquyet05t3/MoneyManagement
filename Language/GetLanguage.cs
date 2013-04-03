using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Language
{
    public enum Language
    {
        English,
        Vietnamese
    }

    public class GetLanguage
    {
        private static Language _Language = Language.English;
        private English english = new English();
        private Vietnamese vietnamese = new Vietnamese();
        private static GetLanguage _getLanguage;
        private static object _lockObj = new object();

        private GetLanguage()
        {

        }

        public static GetLanguage Instance(Language p_Language)
        {
            if (_getLanguage == null)
            {
                lock (_lockObj)
                {
                    if (_getLanguage == null)
                    {
                        _getLanguage = new GetLanguage();
                    }
                }
            }

            _Language = p_Language;

            return _getLanguage;
        }

        public string GetString(string p_Key)
        {
            if (_Language == Language.English)
            {
                return english.GetString(p_Key);
            }
            else
            {
                return vietnamese.GetString(p_Key);
            }
        }
    }
}
