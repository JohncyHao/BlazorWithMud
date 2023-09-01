using Microsoft.EntityFrameworkCore;

namespace BlazorWithMud.Data
{
    public class XianguContext:DbContext
    {
        public XianguContext() { }
        public XianguContext(DbContextOptions<XianguContext> options):base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=A33573\\SQLEXPRESS;Database=XianguNoOne;Trusted_connection=true;TrustServerCertificate=true;");
        }

        public DbSet<WeatherForecast> forecasts { get; set; }
    }
}
