using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.Threading.Tasks;

namespace Speech_To_Text.Class
{

    public class Speech
    {
        private readonly SpeechRecognizer recognizer;
        public string Text { get; private set; }
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
                Text = e.Result.Text;
            }
            else if (e.Result.Reason == ResultReason.NoMatch)
            {
                Text = e.Result.Text;
            }
        }

        // This method starts the speech recognition.
        public async Task StartMyContinuousRecognitionAsync()
        {
            await recognizer.StartContinuousRecognitionAsync();
        }

        // This method stops the speech recognition and clear the memory.
        public async Task StopMyContinuousRecognitionAsync()
        {
            await recognizer.StopContinuousRecognitionAsync();
            recognizer.Dispose();
            Console.WriteLine("Dispose.");


        }

    }


}
