using Speech_To_Text.Class;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            var selectedFromValue = "";
            var selectedToValue = "";

            if (cbFrom.InvokeRequired)
            {
                cbFrom.Invoke(new MethodInvoker(delegate ()
                {
                    selectedFromValue = (string)cbFrom.SelectedValue;

                }));
            }
            else
            {
                selectedFromValue = (string)cbFrom.SelectedValue;
            }

            if (cbTo.InvokeRequired)
            {
                cbTo.Invoke(new MethodInvoker(delegate ()
                {
                    selectedToValue = (string)cbTo.SelectedValue;
                }));
            }
            else
            {
                selectedToValue = (string)cbTo.SelectedValue;

            }



            // Create a new instance of the Speech class and the Translation class
            var speechLanguage = Languages.speechLanguages(selectedFromValue.ToString());
            var speech = new Speech(speech_apiKey, region, speechLanguage);
            var translation = new Translation(translator_apiKey, region);

            // Start the speech recognition
            await speech.StartMyContinuousRecognitionAsync();

            // Loop until the speech recognition returns a value
            while (true)
            {
                if (speech.Text != null)
                {

                    if (rbTranslation.Checked)
                    {
                        await translation.TranslateTextAsync(speech.Text, selectedFromValue.ToString(), selectedToValue.ToString());

                    }
                    if (buttStart.InvokeRequired)
                    {
                        buttStart.BeginInvoke(new Action(() => { buttStart.Text = "Start"; }));
                    }


                    // Check if rbSpeech is Checked
                    if (rbSpeech.Checked)
                    {
                        var SpText = Convert.ToString(speech.Text, CultureInfo.InvariantCulture);
                        //if the CheckBox is checked, show the text in the message box
                        if (cbShowText.Checked)
                        {
                            MessageBox.Show(SpText, "Speech");
                        }
                        //if the CheckBox is checked, copy the text to the clipboard
                        if (cbCopyText.Checked)
                        {
                            TheText theText = new TheText();
                            theText.CopyText(SpText);
                        }

                    }

                    // Check if rbTranslation is Checked
                    if (rbTranslation.Checked)
                    {

                        //Convert change the text to string that can be shown in the message box 

                        var speechText = Convert.ToString(speech.Text, CultureInfo.InvariantCulture);
                        var trText = Convert.ToString(translation.TrText.text, CultureInfo.InvariantCulture);
                        var trlanguage = Convert.ToString(translation.TrText.to, CultureInfo.InvariantCulture);

                        //if the CheckBox is checked, show the text in the message box
                        if (cbShowText.Checked)
                        {
                            MessageBox.Show($"{speechText}\n{trText}", $"From: {selectedFromValue} To: {selectedToValue}");
                        }
                        //if the CheckBox is checked, copy the text to the clipboard
                        if (cbCopyText.Checked)
                        {
                            TheText theText = new TheText();
                            theText.CopyText(trText);
                        }


                    }

                    // Clear the text
                    await speech.StopMyContinuousRecognitionAsync();

                    break;
                }

                //if background worker was canceled, stop the speech recognition
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add the languages to the combo boxes
            var cb1Items = new List<Languages>(Languages.Items);
            var cb2Items = new List<Languages>(Languages.Items);

            cbFrom.DataSource = cb1Items;
            cbFrom.DisplayMember = "Text";
            cbFrom.ValueMember = "Value";

            cbTo.DataSource = cb2Items;
            cbTo.DisplayMember = "Text";
            cbTo.ValueMember = "Value";

            //Loading settings
            rbSpeech.Checked = Properties.Settings.Default.rbSpeech;
            rbTranslation.Checked = Properties.Settings.Default.rbTranslation;
            cbCopyText.Checked = Properties.Settings.Default.cbCopyText;
            cbShowText.Checked = Properties.Settings.Default.cbShowText;
            cbFrom.SelectedIndex = Properties.Settings.Default.cbFrom;
            cbTo.SelectedIndex = Properties.Settings.Default.cbTo;



        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Saving settings
            Properties.Settings.Default.rbSpeech = rbSpeech.Checked;
            Properties.Settings.Default.rbTranslation = rbTranslation.Checked;
            Properties.Settings.Default.cbCopyText = cbCopyText.Checked;
            Properties.Settings.Default.cbShowText = cbShowText.Checked;
            Properties.Settings.Default.cbFrom = cbFrom.SelectedIndex;
            Properties.Settings.Default.cbTo = cbTo.SelectedIndex;


            // Save the settings
            Properties.Settings.Default.Save();

        }
    }
}
