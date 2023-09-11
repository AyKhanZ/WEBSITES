using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using IdentityModel;
using System.Security.Claims;

namespace EcommerceMVC;

public class SD
{
    public const string User = "User";
    public const string Admin = "Admin";


    public static IEnumerable<IdentityResource> IdentityResources =>
        new List<IdentityResource>
        {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile(),
        };
    public static IEnumerable<ApiScope> ApiScopes =>
        new List<ApiScope>
        {
                new ApiScope(name: "read",   displayName: "Read your data."),
                new ApiScope(name: "write",  displayName: "Write your data."),
                new ApiScope(name: "delete", displayName: "Delete your data.")
        };

    public static IEnumerable<Client> Cleints =>
   new List<Client>
        {
                //new Client
                //{
                //    ClientId = "service.client",
                //    ClientSecrets = { new Secret("secret".Sha256()) },
                //    AllowedGrantTypes = GrantTypes.ClientCredentials,
                //    AllowedScopes = { "api1", "api2.read_only" }
                //},
                new Client
                {
                    ClientId = "Identity.API",
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.Code,
                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        JwtClaimTypes.Role,
                    },
                    
                    RedirectUris={ "https://localhost:7002/signin-oidc" },
                    PostLogoutRedirectUris={"https://localhost:7002/signout-callback-oidc" },
                }
        };
}
