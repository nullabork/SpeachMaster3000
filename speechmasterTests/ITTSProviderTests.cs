using speechmaster;
using speechmaster.Providers;

using System.Reflection;

namespace speechmasterTests
{
  [TestClass]
  public class ITTSProviderTests
  {
    [TestMethod]
    [DataRow("Hello, World!")]
    public async Task GetSpeechFromTextAsync_Works_Test(string text)
    {
      foreach (var provider in GetTTSProviders())
      {
        System.Diagnostics.Debug.WriteLine("Testing GetSpeechFromTextAsync: " + provider.GetType().Name);
        using var stream = await provider.GetSpeechFromTextAsync(text, CancellationToken.None);
        Assert.IsNotNull(stream, "Stream is null for " + provider.GetType().Name);
        Assert.IsTrue(stream.Length > 0, "Stream is empty for " + provider.GetType().Name);
        Assert.IsTrue(stream.Position == 0, "Stream position is not 0 for " + provider.GetType().Name);
      }
    }

    [TestMethod]
    public async Task GetVoicesAsync_Works_Test()
    {
      foreach (var provider in GetTTSProviders())
      {
        System.Diagnostics.Debug.WriteLine("Testing GetVoicesAsync: " + provider.GetType().Name);
        var voices = await provider.GetVoicesAsync(CancellationToken.None);
        Assert.IsNotNull(voices, "Voice list is null for " + provider.GetType().Name);
        Assert.IsTrue(voices.Count() > 0, "Voice list is empty for " + provider.GetType().Name);
        System.Diagnostics.Debug.WriteLine("Voice count: " + voices.Count());
      }
    }

    private List<ITTSProvider> GetTTSProviders()
    {
      return Assembly.GetAssembly(typeof(ITTSProvider))?.GetTypes()
        .Where(t => t.IsClass && !t.IsAbstract && t.GetInterfaces().Contains(typeof(ITTSProvider)))
        .Select(t => Activator.CreateInstance(t) as ITTSProvider)
        .ToList() ?? new List<ITTSProvider>();
    }

  }
}