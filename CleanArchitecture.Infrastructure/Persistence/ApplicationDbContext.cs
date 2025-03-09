using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class ApplicationDbContext : IApplicationDbContext
    {
        private readonly InMemoryDatabase _database;

        public ApplicationDbContext()
        {
            _database = new InMemoryDatabase();
        }

        public ICollection<Product> Products 
        { 
            get => _database.Products; 
            set => _database.Products = (List<Product>)value; 
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(_database.SaveChanges());
        }
    }
}
