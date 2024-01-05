﻿namespace Keycloak.Net.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData(RealmId)]
        public async Task GetClientScopesAsync(string realm)
        {
            var result = await _client.GetClientScopesAsync(realm).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(RealmId)]
        public async Task GetClientScopeAsync(string realm)
        {
            var clientScopes = await _client.GetClientScopesAsync(realm).ConfigureAwait(false);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var result = await _client.GetClientScopeAsync(realm, clientScopeId).ConfigureAwait(false);
                Assert.NotNull(result);
            }
        }
    }
}
