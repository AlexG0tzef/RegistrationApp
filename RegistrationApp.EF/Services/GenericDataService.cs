using Microsoft.EntityFrameworkCore.ChangeTracking;
using RegistrationApp.Domain.Models;
using RegistrationApp.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.EF.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {
        private readonly RegistrationAppDbContextFactory _contextFactory;

        public GenericDataService(RegistrationAppDbContextFactory _registrationAppDbContextFactory) 
        {
            _contextFactory = _registrationAppDbContextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using (RegistrationAppDbContext dbContext = _contextFactory.CreateDbContext()) 
            { 
                EntityEntry<T> createdResult = await dbContext.Set<T>().AddAsync(entity);
                await dbContext.SaveChangesAsync();

                return createdResult.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (RegistrationAppDbContext dbContext = _contextFactory.CreateDbContext())
            {
                T entity = dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
                dbContext.Set<T>().Remove(entity);
                await dbContext.SaveChangesAsync();

                return true;
            }
        }

        public async Task<T> Get(int id)
        {
            using (RegistrationAppDbContext dbContext = _contextFactory.CreateDbContext())
            {
                T entity = dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
                return entity;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (RegistrationAppDbContext dbContext = _contextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = dbContext.Set<T>().ToList();
                return entities;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (RegistrationAppDbContext dbContext = _contextFactory.CreateDbContext())
            {
                entity.Id = id;
                dbContext.Set<T>().Update(entity);
                await dbContext.SaveChangesAsync();

                return entity;
            }
        }
    }
}
