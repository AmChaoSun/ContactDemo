using ContactDemo.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactDemo.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ContactDemoContext _context;

        public GenericRepository(ContactDemoContext context)
        {
            _context = context;
        }

        public virtual DbSet<T> Records
        {
            get
            {
                return _context.Set<T>();
            }
        }

        public virtual T Add(T record)
        {
            _context.Add(record);
            _context.SaveChanges();
            return record;

        }

        public virtual void Delete(T record)
        {
            _context.Remove(record);
            _context.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return Records;
        }

        public virtual T GetById(int? id)
        {
            return Records.Find(id);
        }

        public virtual T Update(T record)
        {
            _context.Attach(record);
            _context.Entry(record).State = EntityState.Modified;
            _context.SaveChanges();
            return record;
        }
    }
}
