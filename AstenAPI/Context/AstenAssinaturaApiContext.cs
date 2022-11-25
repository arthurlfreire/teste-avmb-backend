using AstenAssinaturaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AstenAssinaturaAPI.Context
{
    public class AstenAssinaturaApiContext : DbContext
    {
        public AstenAssinaturaApiContext(DbContextOptions<AstenAssinaturaApiContext> options) : base(options)
        {}

        public DbSet<Envelope>? Envelopes { get; set; }
    }
}
