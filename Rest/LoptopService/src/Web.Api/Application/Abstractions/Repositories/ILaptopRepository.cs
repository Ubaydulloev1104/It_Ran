

using Domain;

namespace Application.Abstractions.Repositories
{
    public interface ILaptopRepository
    {

        IQueryable<Laptops> GetAll();

        void Add(Laptops laptops);

        void Delete(Laptops laptops);

        void Update(Guid id, Laptops laptops);
    }
}
