using speechmaster.Voices;

namespace speechmaster.Providers
{
    public interface ITTSProvider
    {
        Task<Stream> GetSpeechFromTextAsync(string text);
        Task<IEnumerable<IVoice>> GetVoicesAsync();
    }

}
