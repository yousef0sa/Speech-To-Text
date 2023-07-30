using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Speech_To_Text.Class
{
    public class Translation
    {
        public dynamic TrText { get { return translations; } private set { translations = value; } }


        private static dynamic translations;
        private string key;
        private string location;
        private readonly string endpoint = "https://api.cognitive.microsofttranslator.com";

        // This class performs translation using the Translator Text API.
        public Translation(string subscriptionKey, string serviceRegion)
        {
            key = subscriptionKey;
            location = serviceRegion;
        }

        // This method translates the given text into the given language.
        public async Task TranslateTextAsync(string textToTranslate, string fromLanguage, string toLanguage)
        {
            if (string.IsNullOrEmpty(textToTranslate))
            {
                return;
            }

            string route = $"/translate?api-version=3.0&from={fromLanguage}&to={toLanguage}";
            object[] body = new object[] { new { Text = textToTranslate } };
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(endpoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", key);
                request.Headers.Add("Ocp-Apim-Subscription-Region", location);

                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                string result = await response.Content.ReadAsStringAsync();

                // Parse the JSON response to get the translation text
                var translationData = JsonConvert.DeserializeObject<dynamic>(result);
                translations = translationData[0].translations;
                foreach (var translation in translations)
                {
                    //Console.WriteLine($"Translated to {translation.to}: {translation.text}");
                    TrText = translation;

                }
            }
        }
    }
}