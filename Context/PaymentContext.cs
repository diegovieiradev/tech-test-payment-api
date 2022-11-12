using Microsoft.EntityFrameworkCore;
using PaymentAPI.Entities;

namespace PaymentAPI.Context
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
        {

        }

        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }

    }
}