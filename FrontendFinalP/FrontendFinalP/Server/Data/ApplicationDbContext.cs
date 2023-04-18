using Duende.IdentityServer.EntityFramework.Options;
using FrontendFinalP.Server.Models;
using FrontendFinalP.Shared;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FrontendFinalP.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<ElNombreDeLaClase> PeliculasTableLog { get; set; }
    }
}