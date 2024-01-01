namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ClientRegistrationPolicy
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public ClientRegistrationPolicyProviders Providers { get; set; }
    }
}
