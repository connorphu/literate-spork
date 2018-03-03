using Microsoft.EntityFrameworkCore;
using ThatOneStore.Library.Models;

namespace ThatOneStore.Context
{
    public class ThatOneStoreContext : DbContext
    {
        public ThatOneStoreContext(DbContextOptions<ThatOneStoreContext> options) : base(options) { }

        public DbSet<Person> Peeps { get; set; }
    }
}
