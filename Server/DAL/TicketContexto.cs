using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using RegistroTicketsDetalle.Shared;

namespace RegistroTicketsDetalle.Server.DAL
{
    public class TicketContexto : DbContext
    {
        public TicketContexto(DbContextOptions<TicketContexto> options) : base(options)
        {   }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<TicketsDetalle> TicketsDetalle { get; set; }
    }
}
