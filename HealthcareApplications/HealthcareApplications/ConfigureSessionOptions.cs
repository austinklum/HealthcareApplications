using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
namespace HealthcareApplications
{
    /// <summary>
    /// This class was created so the IService provider can be used to obtain information
    /// before setting the session options
    /// For more information see:
    /// Access services inside ConfigureServices using IConfigureOptions in ASP.NET Core
    /// https://andrewlock.net/access-services-inside-options-and-startup-using-configureoptions/
    /// </summary>
    public class ConfigureSessionOptions : Microsoft.Extensions.Options.IConfigureOptions<SessionOptions>
    {

        private readonly IServiceScopeFactory _serviceScopeFactory;

        public ConfigureSessionOptions(IServiceScopeFactory serviceScopeFactory)
        {

            _serviceScopeFactory = serviceScopeFactory;
        }


        public void Configure(SessionOptions options)
        {

            using (var scope = _serviceScopeFactory.CreateScope())
            {

                var provider = scope.ServiceProvider;
                using (var server = provider.GetRequiredService<IServer>())
                {

                    var addressFeature = server.Features.Get<Microsoft.AspNetCore.Hosting.Server.Features.IServerAddressesFeature>();
                    var firstAddress = addressFeature.Addresses.FirstOrDefault();
                    if (firstAddress != null)
                    {
                        if (Uri.TryCreate(firstAddress, UriKind.RelativeOrAbsolute, out var firstAddressUri))
                        {
                            options.Cookie.Name += firstAddressUri.Port;
                        }

                    }
                }
            }
        }
    }
}