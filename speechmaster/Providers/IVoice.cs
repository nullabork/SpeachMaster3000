namespace speechmaster.Providers
{
    public interface IVoice
    {
        string Name { get; }
        string Language { get; }
    }
}