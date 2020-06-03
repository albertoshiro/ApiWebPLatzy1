using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApiSQL.Models
{
    public class ContactsContext : DbContext
    {
        
        public ContactsContext (DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Contacts> ContactSet { get; set; }

    }
}
