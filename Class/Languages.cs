using System;
using System.Collections.Generic;


namespace Speech_To_Text.Class
{
    public class Languages
    {
        // This class is used to store the language data
        private static Lazy<List<Languages>> _items = new Lazy<List<Languages>>(() =>
        {
            List<Languages> items = new List<Languages>
{
    new Languages { Text = "Afrikaans", Value = "af" },
    new Languages { Text = "Albanian", Value = "sq" },
    new Languages { Text = "Amharic", Value = "am" },
    new Languages { Text = "Arabic", Value = "ar" },
    new Languages { Text = "Armenian", Value = "hy" },
    new Languages { Text = "Azerbaijani ", Value = "az" },
    new Languages { Text = "Basque", Value = "eu" },
    new Languages { Text = "Bosnian ", Value = "bs" },
    new Languages { Text = "Catalan", Value = "ca" },
    new Languages { Text = "Chinese Simplified", Value = "zh-Hans" },
    new Languages { Text = "Chinese Traditional", Value = "zh-Hant" },
    new Languages { Text = "Croatian", Value = "hr" },
    new Languages { Text = "Czech", Value = "cs" },
    new Languages { Text = "Danish", Value = "da" },
    new Languages { Text = "Dutch", Value = "nl" },
    new Languages { Text = "English", Value = "en" },
    new Languages { Text = "Estonian", Value = "et" },
    new Languages { Text = "Filipino", Value = "fil" },
    new Languages { Text = "Finnish", Value = "fi" },
    new Languages { Text = "French", Value = "fr" },
    new Languages { Text = "French (Canada)", Value = "fr-ca" },
    new Languages { Text = "Galician", Value = "gl" },
    new Languages { Text = "Georgian", Value = "ka" },
    new Languages { Text = "German", Value = "de" },
    new Languages { Text = "Greek", Value = "el" },
    new Languages { Text = "Gujarati", Value = "gu" },
    new Languages { Text = "Hebrew", Value = "he" },
    new Languages { Text = "Hindi", Value = "hi" },
    new Languages { Text = "Hungarian", Value = "hu" },
    new Languages { Text = "Icelandic", Value = "is" },
    new Languages { Text = "Indonesian", Value = "id" },
    new Languages { Text = "Irish", Value = "ga" },
    new Languages { Text = "Italian", Value = "it" },
    new Languages { Text = "Japanese", Value = "ja" },
    new Languages { Text = "Kannada", Value = "kn" },
    new Languages { Text = "Kazakh", Value = "kk" },
    new Languages { Text = "Khmer", Value = "km" },
    new Languages { Text = "Korean", Value = "ko" },
    new Languages { Text = "Lao", Value = "lo" },
    new Languages { Text = "Latvian", Value = "lv" },
    new Languages { Text = "Lithuanian", Value = "lt" },
    new Languages { Text = "Macedonian", Value = "mk" },
    new Languages { Text = "Malay (Latin)", Value = "ms" },
    new Languages { Text = "Malayalam", Value = "ml" },
    new Languages { Text = "Maltese", Value = "mt" },
    new Languages { Text = "Marathi", Value = "mr" },
    new Languages { Text = "Myanmar", Value = "my" },
    new Languages { Text = "Nepali", Value = "ne" },
    new Languages { Text = "Norwegian", Value = "nb" },
    new Languages { Text = "Pashto", Value = "ps" },
    new Languages { Text = "Persian", Value = "fa" },
    new Languages { Text = "Polish", Value = "pl" },
    new Languages { Text = "Portuguese (Brazil)", Value = "pt" },
    new Languages { Text = "Portuguese (Portugal)", Value = "pt-pt" },
    new Languages { Text = "Romanian", Value = "ro" },
    new Languages { Text = "Russian", Value = "ru" },
    new Languages { Text = "Serbian (Cyrillic)", Value = "sr-Cyrl" },
    new Languages { Text = "Slovak", Value = "sk" },
    new Languages { Text = "Slovenian", Value = "sl" },
    new Languages { Text = "Somali (Arabic)", Value = "so" },
    new Languages { Text = "Spanish", Value = "es" },
    new Languages { Text = "Swahili", Value = "sw" },
    new Languages { Text = "Swedish", Value = "sv" },
    new Languages { Text = "Tamil", Value = "ta" },
    new Languages { Text = "Telugu", Value = "te" },
    new Languages { Text = "Thai", Value = "th" },
    new Languages { Text = "Turkish", Value = "tr" },
    new Languages { Text = "Ukrainian", Value = "uk" },
    new Languages { Text = "Uzbek", Value = "uz" },
    new Languages { Text = "Vietnamese", Value = "vi" },
    new Languages { Text = "Welsh", Value = "cy" },
    new Languages { Text = "Zulu", Value = "zu" }
        };
            return items;
        });

        public string Text { get; private set; }
        public string Value { get; private set; }

        public static List<Languages> Items => _items.Value;

        //Speech Languages
        public static string speechLanguages(string Languages)
        {
            //Afrikaans
            if (Languages == "af")
            {
                return "af-ZA";
            }
            //Albanian
            else if (Languages == "sq")
            {
                return "sq-AL";
            }
            //Amharic
            else if (Languages == "am")
            {
                return "am-ET";
            }
            //Arabic
            else if (Languages == "ar")
            {
                return "ar-SA";
            }
            //Armenian
            else if (Languages == "hy")
            {
                return "hy-AM";
            }
            //Azerbaijani
            else if (Languages == "az")
            {
                return "az-AZ";
            }
            //Basque
            else if (Languages == "eu")
            {
                return "eu-ES";
            }
            //Bosnian
            else if (Languages == "bs")
            {
                return "bs-BA";
            }
            //Bengali
            else if (Languages == "bn")
            {
                return "bn-BD";
            }
            //Catalan
            else if (Languages == "ca")
            {
                return "ca-ES";
            }
            //Chinese (Simplified)
            else if (Languages == "zh-Hans")
            {
                return "zh-CN";
            }
            //Croatian
            else if (Languages == "hr")
            {
                return "hr-HR";
            }
            //Czech
            else if (Languages == "cs")
            {
                return "cs-CZ";
            }
            //Danish
            else if (Languages == "da")
            {
                return "da-DK";
            }
            //Dutch
            else if (Languages == "nl")
            {
                return "nl-NL";
            }
            //English
            else if (Languages == "en")
            {
                return "en-US";
            }
            //Estonian
            else if (Languages == "et")
            {
                return "et-EE";
            }
            //Filipino
            else if (Languages == "fil")
            {
                return "fil-PH";
            }
            //Finnish
            else if (Languages == "fi")
            {
                return "fi-FI";
            }
            //French
            else if (Languages == "fr")
            {
                return "fr-FR";
            }
            //French (Canadian)
            else if (Languages == "fr-ca")
            {
                return "fr-CA";
            }
            //Galician
            else if (Languages == "gl")
            {
                return "gl-ES";
            }
            //Georgian
            else if (Languages == "ka")
            {
                return "ka-GE";
            }
            //German
            else if (Languages == "de")
            {
                return "de-DE";
            }
            //Greek
            else if (Languages == "el")
            {
                return "el-GR";
            }
            //Gujarati
            else if (Languages == "gu")
            {
                return "gu-IN";
            }
            //Hebrew
            else if (Languages == "iw")
            {
                return "iw-IL";
            }
            //Hindi
            else if (Languages == "hi")
            {
                return "hi-IN";
            }
            //Hungarian
            else if (Languages == "hu")
            {
                return "hu-HU";
            }
            //Icelandic
            else if (Languages == "is")
            {
                return "is-IS";
            }
            //Indonesian
            else if (Languages == "id")
            {
                return "id-ID";
            }
            //Irish
            else if (Languages == "ga")
            {
                return "ga-IE";
            }
            //Italian
            else if (Languages == "it")
            {
                return "it-IT";
            }
            //Japanese
            else if (Languages == "ja")
            {
                return "ja-JP";
            }
            //Kannada
            else if (Languages == "kn")
            {
                return "kn-IN";
            }
            //Kazakh
            else if (Languages == "kk")
            {
                return "kk-KZ";
            }
            //Khmer
            else if (Languages == "km")
            {
                return "km-KH";
            }
            //Korean
            else if (Languages == "ko")
            {
                return "ko-KR";
            }
            //Lao
            else if (Languages == "lo")
            {
                return "lo-LA";
            }
            //Latvian
            else if (Languages == "lv")
            {
                return "lv-LV";
            }
            //Lithuanian
            else if (Languages == "lt")
            {
                return "lt-LT";
            }
            //Macedonian
            else if (Languages == "mk")
            {
                return "mk-MK";
            }
            //Malay
            else if (Languages == "ms")
            {
                return "ms-MY";
            }
            //Malayalam
            else if (Languages == "ml")
            {
                return "ml-IN";
            }
            //Maltese
            else if (Languages == "mt")
            {
                return "mt-MT";
            }
            //Marathi
            else if (Languages == "mr")
            {
                return "mr-IN";
            }
            //Myanmar
            else if (Languages == "my")
            {
                return "my-MM";
            }
            //Nepali
            else if (Languages == "ne")
            {
                return "ne-NP";
            }
            //Norwegian
            else if (Languages == "no")
            {
                return "no-NO";
            }
            //Pashto
            else if (Languages == "ps")
            {
                return "ps-AF";
            }
            //Persian
            else if (Languages == "fa")
            {
                return "fa-IR";
            }
            //Polish
            else if (Languages == "pl")
            {
                return "pl-PL";
            }
            //Portuguese (Brazil)
            else if (Languages == "pt")
            {
                return "pt-BR";
            }
            //Portuguese (Portugal)
            else if (Languages == "pt-pt")
            {
                return "pt-PT";
            }
            //Punjabi
            else if (Languages == "pa")
            {
                return "pa-IN";
            }
            //Romanian
            else if (Languages == "ro")
            {
                return "ro-RO";
            }
            //Russian
            else if (Languages == "ru")
            {
                return "ru-RU";
            }
            //Serbian (Cyrillic)
            else if (Languages == "sr-Cyrl")
            {
                return "sr-RS";
            }
            //Slovak
            else if (Languages == "sk")
            {
                return "sk-SK";
            }
            //Slovenian
            else if (Languages == "sl")
            {
                return "sl-SI";
            }
            //Somali
            else if (Languages == "so")
            {
                return "so-SO";
            }
            //Spanish
            else if (Languages == "es")
            {
                return "es-ES";
            }
            //Swahili
            else if (Languages == "sw")
            {
                return "sw-TZ";
            }
            //Swedish
            else if (Languages == "sv")
            {
                return "sv-SE";
            }
            //Tamil
            else if (Languages == "ta")
            {
                return "ta-IN";
            }
            //Telugu
            else if (Languages == "te")
            {
                return "te-IN";
            }
            //Thai
            else if (Languages == "th")
            {
                return "th-TH";
            }
            //Turkish
            else if (Languages == "tr")
            {
                return "tr-TR";
            }
            //Ukrainian
            else if (Languages == "uk")
            {
                return "uk-UA";
            }
            //Uzbek
            else if (Languages == "uz")
            {
                return "uz-UZ";
            }
            //Vietnamese
            else if (Languages == "vi")
            {
                return "vi-VN";
            }
            //Welsh
            else if (Languages == "cy")
            {
                return "cy-GB";
            }
            //Zulu
            else if (Languages == "zu")
            {
                return "zu-ZA";
            }
            else
            {
                return "en-US";
            }






        }
    }
};



