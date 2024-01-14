namespace Keycloak.Net.Models.Root
{
    using System.Collections.Generic;
    using Keycloak.Net.Models.Common;
    using System.Text.Json.Serialization;

    public class KeycloakAuthenticationAuthenticator
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("helpText")]
        public string HelpText { get; set; }

        [JsonPropertyName("properties")]
        public List<ConfigProperty> Properties { get; set; }

        [JsonPropertyName("metadata")]
        public MetadataClass Metadata { get; set; }
    }
}
