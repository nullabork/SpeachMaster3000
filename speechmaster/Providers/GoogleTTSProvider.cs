using Google.Cloud.TextToSpeech.V1;
using speechmaster.Voices;

namespace speechmaster.Providers
{
    public class GoogleTTSProvider : ITTSProvider
    {
        public async Task<Stream> GetSpeechFromTextAsync(string text)
        {

            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "config\\GoogleAuth.json");

            // Initialize the Text-to-Speech client
            TextToSpeechClient client = TextToSpeechClient.Create();

            // Define the input text to be synthesized
            SynthesisInput input = new SynthesisInput
            {
                Text = text
            };

            VoiceSelectionParams voice = new VoiceSelectionParams
            {
                LanguageCode = "en-US",
                SsmlGender = SsmlVoiceGender.Female
            };

            // Specify the type of audio file to return
            AudioConfig config = new AudioConfig
            {
                AudioEncoding = AudioEncoding.Mp3
            };


            // Perform the Text-to-Speech request
            SynthesizeSpeechResponse response = await client.SynthesizeSpeechAsync(input, voice, config);

            var ms = new MemoryStream();
            response.AudioContent.WriteTo(ms);
            ms.Position = 0;

            return ms;
        }

        public async Task<IEnumerable<IVoice>> GetVoicesAsync()
        {
            TextToSpeechClient client = TextToSpeechClient.Create();
            var voices = await client.ListVoicesAsync(new ListVoicesRequest());
            return voices.Voices.Select(v => new GoogleVoice(v));
        }
    }

}



