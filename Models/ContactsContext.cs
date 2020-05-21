using System.IO.Pipes;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
namespace WebApiSQLAzure.Models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions options) : base (options)
        {
            
        }

        public DbSet<Contacts> ContactSet { set; get;}

    }
}