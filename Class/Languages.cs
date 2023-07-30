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
    new Languages { Text = "Assamese", Value = "as" },
    new Languages { Text = "Azerbaijani (Latin)", Value = "az" },
    new Languages { Text = "Bangla", Value = "bn" },
    new Languages { Text = "Bashkir", Value = "ba" },
    new Languages { Text = "Basque", Value = "eu" },
    new Languages { Text = "Bosnian (Latin)", Value = "bs" },
    new Languages { Text = "Bulgarian", Value = "bg" },
    new Languages { Text = "Cantonese (Traditional)", Value = "yue" },
    new Languages { Text = "Catalan", Value = "ca" },
    new Languages { Text = "Chinese (Literary)", Value = "lzh" },
    new Languages { Text = "Chinese Simplified", Value = "zh-Hans" },
    new Languages { Text = "Chinese Traditional", Value = "zh-Hant" },
    new Languages { Text = "Croatian", Value = "hr" },
    new Languages { Text = "Czech", Value = "cs" },
    new Languages { Text = "Danish", Value = "da" },
    new Languages { Text = "Dari", Value = "prs" },
    new Languages { Text = "Divehi", Value = "dv" },
    new Languages { Text = "Dutch", Value = "nl" },
    new Languages { Text = "English", Value = "en" },
    new Languages { Text = "Estonian", Value = "et" },
    new Languages { Text = "Faroese", Value = "fo" },
    new Languages { Text = "Fijian", Value = "fj" },
    new Languages { Text = "Filipino", Value = "fil" },
    new Languages { Text = "Finnish", Value = "fi" },
    new Languages { Text = "French", Value = "fr" },
    new Languages { Text = "French (Canada)", Value = "fr-ca" },
    new Languages { Text = "Galician", Value = "gl" },
    new Languages { Text = "Georgian", Value = "ka" },
    new Languages { Text = "German", Value = "de" },
    new Languages { Text = "Greek", Value = "el" },
    new Languages { Text = "Gujarati", Value = "gu" },
    new Languages { Text = "Haitian Creole", Value = "ht" },
    new Languages { Text = "Hebrew", Value = "he" },
    new Languages { Text = "Hindi", Value = "hi" },
    new Languages { Text = "Hmong Daw (Latin)", Value = "mww" },
    new Languages { Text = "Hungarian", Value = "hu" },
    new Languages { Text = "Icelandic", Value = "is" },
    new Languages { Text = "Indonesian", Value = "id" },
    new Languages { Text = "Inuinnaqtun", Value = "ikt" },
    new Languages { Text = "Inuktitut", Value = "iu" },
    new Languages { Text = "Inuktitut (Latin)", Value = "iu-Latn" },
    new Languages { Text = "Irish", Value = "ga" },
    new Languages { Text = "Italian", Value = "it" },
    new Languages { Text = "Japanese", Value = "ja" },
    new Languages { Text = "Kannada", Value = "kn" },
    new Languages { Text = "Kazakh", Value = "kk" },
    new Languages { Text = "Khmer", Value = "km" },
    new Languages { Text = "Klingon", Value = "tlh-Latn" },
    new Languages { Text = "Klingon (plqaD)", Value = "tlh-Piqd" },
    new Languages { Text = "Korean", Value = "ko" },
    new Languages { Text = "Kurdish (Central)", Value = "ku" },
    new Languages { Text = "Kurdish (Northern)", Value = "kmr" },
    new Languages { Text = "Kyrgyz (Cyrillic)", Value = "ky" },
    new Languages { Text = "Lao", Value = "lo" },
    new Languages { Text = "Latvian", Value = "lv" },
    new Languages { Text = "Lithuanian", Value = "lt" },
    new Languages { Text = "Macedonian", Value = "mk" },
    new Languages { Text = "Malagasy", Value = "mg" },
    new Languages { Text = "Malay (Latin)", Value = "ms" },
    new Languages { Text = "Malayalam", Value = "ml" },
    new Languages { Text = "Maltese", Value = "mt" },
    new Languages { Text = "Maori", Value = "mi" },
    new Languages { Text = "Marathi", Value = "mr" },
    new Languages { Text = "Mongolian (Cyrillic)", Value = "mn-Cyrl" },
    new Languages { Text = "Mongolian (Traditional)", Value = "mn-Mong" },
    new Languages { Text = "Myanmar", Value = "my" },
    new Languages { Text = "Nepali", Value = "ne" },
    new Languages { Text = "Norwegian", Value = "nb" },
    new Languages { Text = "Odia", Value = "or" },
    new Languages { Text = "Pashto", Value = "ps" },
    new Languages { Text = "Persian", Value = "fa" },
    new Languages { Text = "Polish", Value = "pl" },
    new Languages { Text = "Portuguese (Brazil)", Value = "pt" },
    new Languages { Text = "Portuguese (Portugal)", Value = "pt-pt" },
    new Languages { Text = "Punjabi", Value = "pa" },
    new Languages { Text = "Queretaro Otomi", Value = "otq" },
    new Languages { Text = "Romanian", Value = "ro" },
    new Languages { Text = "Russian", Value = "ru" },
    new Languages { Text = "Samoan (Latin)", Value = "sm" },
    new Languages { Text = "Serbian (Cyrillic)", Value = "sr-Cyrl" },
    new Languages { Text = "Serbian (Latin)", Value = "sr-Latn" },
    new Languages { Text = "Slovak", Value = "sk" },
    new Languages { Text = "Slovenian", Value = "sl" },
    new Languages { Text = "Somali (Arabic)", Value = "so" },
    new Languages { Text = "Spanish", Value = "es" },
    new Languages { Text = "Swahili (Latin)", Value = "sw" },
    new Languages { Text = "Swedish", Value = "sv" },
    new Languages { Text = "Tahitian", Value = "ty" },
    new Languages { Text = "Tamil", Value = "ta" },
    new Languages { Text = "Tatar (Latin)", Value = "tt" },
    new Languages { Text = "Telugu", Value = "te" },
    new Languages { Text = "Thai", Value = "th" },
    new Languages { Text = "Tibetan", Value = "bo" },
    new Languages { Text = "Tigrinya", Value = "ti" },
    new Languages { Text = "Tongan", Value = "to" },
    new Languages { Text = "Turkish", Value = "tr" },
    new Languages { Text = "Turkmen (Latin)", Value = "tk" },
    new Languages { Text = "Ukrainian", Value = "uk" },
    new Languages { Text = "Upper Sorbian", Value = "hsb" },
    new Languages { Text = "Urdu", Value = "ur" },
    new Languages { Text = "Uyghur (Arabic)", Value = "ug" },
    new Languages { Text = "Uzbek (Latin)", Value = "uz" },
    new Languages { Text = "Vietnamese", Value = "vi" },
    new Languages { Text = "Welsh", Value = "cy" },
    new Languages { Text = "Yucatec Maya", Value = "yua" },
    new Languages { Text = "Zulu", Value = "zu" }
        };
            return items;
        });

        public string Text { get; private set; }
        public string Value { get; private set; }

        public static List<Languages> Items => _items.Value;
    }
};



