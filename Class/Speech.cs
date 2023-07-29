using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.Threading.Tasks;

namespace Speech_To_Text.Class
{

    public class Speech
    {
        private readonly SpeechRecognizer recognizer;

        public Speech(string subscriptionKey, string serviceRegion)
        {

            var speechConfig = SpeechConfig.FromSubscription(subscriptionKey, serviceRegion);

            var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            recognizer = new SpeechRecognizer(speechConfig, audioConfig);
            recognizer.Recognized += Recognizer_Recognized;
        }

        private void Recognizer_Recognized(object sender, SpeechRecognitionEventArgs e)
        {
            if (e.Result.Reason == ResultReason.RecognizedSpeech)
            {
                Console.WriteLine($"Recognized text: {e.Result.Text}");
            }
            else if (e.Result.Reason == ResultReason.NoMatch)
            {
                Console.WriteLine("NOMATCH: Speech could not be recognized.");
            }
        }

        public async Task StartMyContinuousRecognitionAsync()
        {
            await recognizer.StartContinuousRecognitionAsync();
        }
    }


}
