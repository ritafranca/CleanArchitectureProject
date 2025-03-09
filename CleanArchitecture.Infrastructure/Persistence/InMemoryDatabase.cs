using CleanArchitecture.Domain.Entities;
using System.Collections.Generic;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class InMemoryDatabase
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public int SaveChanges()
        {
            return 1; // Simula um salvamento bem-sucedido
        }
    }
}
