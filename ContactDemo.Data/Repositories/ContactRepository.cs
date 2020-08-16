using ContactDemo.Data.Repositories.Interfaces;
using ContactDemo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactDemo.Data.Repositories
{
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public ContactRepository(ContactDemoContext context) : base(context) { }

        public bool Exists(int id)
        {
            return _context.Contact.Any(e => e.ID == id);
        }
    }
}
