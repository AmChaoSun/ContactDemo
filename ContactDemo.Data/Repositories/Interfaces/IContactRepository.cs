using ContactDemo.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactDemo.Data.Repositories.Interfaces
{
    //in case, we need some speicified methods other than CRUD
    public interface IContactRepository : IGenericRepository<Contact>
    {
        bool Exists(int id);
    }
}
