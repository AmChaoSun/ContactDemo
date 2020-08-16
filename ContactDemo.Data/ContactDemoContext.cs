using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactDemo.Data
{
    public class ContactDemoContext : DbContext
    {
        public ContactDemoContext(DbContextOptions<ContactDemoContext> options)
            : base(options)
        {
        }

        public DbSet<ContactDemo.Domain.Contact> Contact { get; set; }
    }
}
