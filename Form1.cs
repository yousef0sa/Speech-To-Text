using Speech_To_Text.Class;
using System;
using System.Windows.Forms;


namespace Speech_To_Text
{
    public partial class Form1 : Form
    {
        private string speech_apiKey;
        private string translator_apiKey;
        private string region;
        private Speech speech;

        public Form1()
        {
            InitializeComponent();

            // Get the API key and region from the environment variables
            speech_apiKey = Environment.GetEnvironmentVariable("Speech_API_KEY");
            translator_apiKey = Environment.GetEnvironmentVariable("Translator_API_KEY");
            region = Environment.GetEnvironmentVariable("Region");
        }


        private async void buttStart_Click(object sender, EventArgs e)
        {
            // Check which radio button is selected
            if (rbSpeech.Checked)
            {
                var speech = new Speech(speech_apiKey, region); // Create a new instance of the Speech class
                // Start the speech recognition
                await speech.StartMyContinuousRecognitionAsync();

            }
            else if(rbTranslation.Checked)
            {

            }

        }



    }
}
