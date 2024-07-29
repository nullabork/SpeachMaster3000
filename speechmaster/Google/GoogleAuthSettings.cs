using System;
using System.IO;
using Newtonsoft.Json;

public class GoogleAuthSettings : JsonSerializable<GoogleAuthSettings>
{
    protected override string FilePath => Path.Combine("config", "GoogleAuth.json");
    public static new GoogleAuthSettings GetInstance() => Instance;

    [JsonProperty("type")]
    public string? type { get; set; }

    [JsonProperty("project_id")]
    public string? projectId { get; set; }

    [JsonProperty("private_key_id")]
    public string? privateKeyId { get; set; }

    [JsonProperty("private_key")]
    public string? privateKey { get; set; }

    [JsonProperty("client_email")]
    public string? clientEmail { get; set; }

    [JsonProperty("client_id")]
    public string? clientId { get; set; }

    [JsonProperty("auth_uri")]
    public string authUri { get; set; } = "https://accounts.google.com/o/oauth2/auth";

    [JsonProperty("token_uri")]
    public string tokenUri { get; set; } = "https://oauth2.googleapis.com/token";

    [JsonProperty("auth_provider_x509_cert_url")]
    public string authProviderX509CertUrl { get; set; } = "https://www.googleapis.com/oauth2/v1/certs";

    [JsonProperty("client_x509_cert_url")]
    public string clientX509CertUrl { get; set; } = "https://www.googleapis.com/robot/v1/metadata/x509/server%40talk-bork.iam.gserviceaccount.com";
}
