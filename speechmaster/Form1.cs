using NAudio.Wave;
using speechmaster.Providers;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace talbot3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void speakButton_Click(object sender, EventArgs e)
        {
            string text = speakInput.Text;
            if (!string.IsNullOrEmpty(text))
            {
                await SpeakText(text);
            }
        }

        private async Task SpeakText(string text)
        {

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var ttsProvider = new ElevenLabsTTSProvider();
            using var stream = await ttsProvider.GetSpeechFromTextAsync(text, default);

            //var voices = await ttsProvider.GetVoicesAsync();
            //foreach (var voice in voices)
            //{
            //    System.Diagnostics.Debug.WriteLine(voice.Name);
            //}

            System.Diagnostics.Debug.WriteLine("stream: " + stopwatch.ElapsedMilliseconds);

            using var waveOut = new WaveOutEvent { DeviceNumber = GetVBCableDeviceNumber() };
            using var mp3Reader = new Mp3FileReader(stream);

            waveOut.Init(mp3Reader);
            waveOut.Play();

            while (waveOut.PlaybackState == PlaybackState.Playing)
            {
                await Task.Delay(1000);
            }
        }

        private int GetVBCableDeviceNumber()
        {
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                var capabilities = WaveOut.GetCapabilities(i);
                if (capabilities.ProductName.Contains("VB-Audio"))
                {
                    return i;
                }
            }
            throw new Exception("VB-Audio Virtual Cable not found.");
        }

        private void googleAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
