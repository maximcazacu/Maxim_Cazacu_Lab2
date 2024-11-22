using Microsoft.EntityFrameworkCore;
using Maxim_Cazacu_Lab2.Models;
namespace Maxim_Cazacu_Lab2.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) :
       base(options)
        {
        }
        public DbSet<Maxim_Cazacu_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Maxim_Cazacu_Lab2.Models.Customer> Customer { get; set; } = default!;
        public DbSet<Maxim_Cazacu_Lab2.Models.Genre> Genre { get; set; } = default!;
    }
}