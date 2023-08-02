# Speech-To-Text

A simple C# desktop application that converts speech to text using Microsoft Azure Cognitive Services.

## Features:
- It can convert speech to text using Microsoft Azure Cognitive Services.
- It can translate speech to different languages using Microsoft Azure Translator.
- It can copy the text to the clipboard or show it on the screen.
- It can select the language of the speech from a dropdown menu.

## Prerequisites

Before running the app, make sure you have the following:

- API Keys for Azure Services (Translator and Speech service).
- Installed the following NuGet packages: DotNetEnv, Azure.CognitiveServices.Speech, and Newtonsoft.Json.

## Getting Started

To get the app up and running, follow these steps:

1. Clone this repository.
2. Navigate to the directory where the code is cloned.
3. Create a `.env` file in the root directory.
4. In the .env file, add your Keys and Region of Azure Services Subscription as follows:
```bash
   Speech_API_KEY = "Your_Speech_service_API_Key"
   Translator_API_KEY = "Your_Translator_API_Key"
   Region = "Subscription_Region"
```
5. Build and run the application.

## How to Use the App

1. Click the "Start" button and begin speaking. The app will automatically recognize when you stop speaking without requiring you to click the "Stop" button.

2. The "Stop" button is only for canceling the process if needed.

3. Radio buttons:
   - **Speech:** This option converts speech to text. Remember to select the language for speech recognition.
   - **Translation:** Use this option to translate to any language.

4. Checkboxes:
   - **Copy Text:** Enable this option to copy the text after finishing the speech or translation.
   - **Show Text:** Enable this option to display the text of the speech or the translated text from the app.


![App Screenshot](https://raw.githubusercontent.com/yousef0sa/Speech-To-Text/master/Home.PNG)

## Built With

* C#
* DotNetEnv
* Azure.CognitiveServices.Speech
* Newtonsoft.Json

## Authors

- [@Yousef](https://github.com/yousef0sa)

