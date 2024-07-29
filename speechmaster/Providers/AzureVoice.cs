using Microsoft.CognitiveServices.Speech;

namespace speechmaster.Providers
{
  public class AzureVoice : IVoice
  {
    public AzureVoice(VoiceInfo voice)
    {
      Name = voice.Name;
      Language = voice.Locale;
    }

    public string Name { get; }
    public string Language { get; }
  }
}



