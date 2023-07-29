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
            //if the button is clicked in first time, start the background worker
            //if the button is clicked again, stop the background worker
            if (buttStart.Text == "Start")
            {
                backgroundWorker1.RunWorkerAsync();

                buttStart.Text = "Stop";
            }
            else
            {
                buttStart.Text = "Start";
                backgroundWorker1.CancelAsync();
            }
        }


        private async void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Create a new instance of the Speech class and the Translation class
            var speech = new Speech(speech_apiKey, region);
            var translation = new Translation(translator_apiKey, region);

            // Start the speech recognition
            await speech.StartMyContinuousRecognitionAsync();

            // Loop until the speech recognition returns a value
            while (true)
            {
                if (speech.Text != null)
                {
                    // Check which radio button is selected
                    if (rbSpeech.Checked)
                    {
                        Console.WriteLine(speech.Text);
                        MessageBox.Show(speech.Text, "Title");
                        
                    }
                    else if (rbTranslation.Checked)
                    {
                        await translation.TranslateTextAsync(speech.Text, "en", "zu");
                    }

                    // Reset the speech.Text value, break out of the loop.
                    Console.WriteLine("Speech recognition stop and break out of the loop");
                    if (buttStart.InvokeRequired)
                    {
                        buttStart.BeginInvoke(new Action(() => { buttStart.Text = "Start"; }));
                    }
                    await speech.StopMyContinuousRecognitionAsync();
                    break;
                }

                //if background worker is cancelled, stop the speech recognition
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    await speech.StopMyContinuousRecognitionAsync();
                    Console.WriteLine("Speech recognition stopped");
                    backgroundWorker1.Dispose();
                    break;
                }
            }


        }
    }
}
