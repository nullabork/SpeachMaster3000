using System;
using System.IO;
using Newtonsoft.Json;

public class GoogleAuthSettings : JsonSerializable<GoogleAuthSettings>
{
    protected override string FilePath => Path.Combine("config", "GoogleAuth.json");
    public static new GoogleAuthSettings GetInstance() => Instance;

    public string? Type { get; set; }
    public string? ProjectId { get; set; }
    public string? PrivateKeyId { get; set; }
    public string? PrivateKey { get; set; }
    public string? ClientEmail { get; set; }
    public string? ClientId { get; set; }
    public string AuthUri { get; set; } = "https://accounts.google.com/o/oauth2/auth";
    public string TokenUri { get; set; } = "https://oauth2.googleapis.com/token";
    public string AuthProviderX509CertUrl { get; set; } = "https://www.googleapis.com/oauth2/v1/certs";
    public string ClientX509CertUrl { get; set; } = "https://www.googleapis.com/robot/v1/metadata/x509/server%40talk-bork.iam.gserviceaccount.com";
}
