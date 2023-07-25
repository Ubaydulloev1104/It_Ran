using Application.Abstractions.Repositories;
using Domain;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class LaptopRepository :ILaptopRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public LaptopRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Add(Laptops laptops)
        {
            _applicationDbContext.Add(laptops);
            _applicationDbContext.SaveChanges();
        }

        public void Delete(Laptops laptops)
        {
            _applicationDbContext.Laptops.Remove(laptops);
            _applicationDbContext.SaveChanges();
        }

        public IQueryable<Laptops> GetAll()
        {
            var myLinqQuery = _applicationDbContext.Laptops;
            return myLinqQuery;
        }

        public void Update(Guid id, Laptops employee)
        {
            Laptops LaptopsToUpdate = _applicationDbContext.Laptops.Find(id);
			LaptopsToUpdate.Name = employee.Name;
            _applicationDbContext.SaveChanges();
        }
    }
}
