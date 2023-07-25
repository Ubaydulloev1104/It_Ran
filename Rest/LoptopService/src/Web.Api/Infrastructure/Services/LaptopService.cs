using Application;
using Application.Abstractions.Repositories;
using Application.Abstractions.Services;
using Domain;
using Employee.Web.Api.Contacts.Requests;
using Employee.Web.Api.Contacts.Response;

namespace Infrastructure.Services
{
	public class LaptopService : ILaptopService
	{
		private readonly ILaptopRepository _repository;

		public LaptopService(ILaptopRepository LaptopRepository)
		{
			_repository = LaptopRepository;
		}

		public Guid Create(string Name, string Description, string Manufacturer, decimal Price, int Ram, string CPU, string Hard_Drive)
		{
			var newLaptops = new Laptops
			{
				Id = Guid.NewGuid(),
				Name = Name,
				Description = Description,
				Manufacturer = Manufacturer,
				Price = Price,
				Ram = Ram,
				CPU = CPU,
				Hard_Drive = Hard_Drive
			};

			_repository.Add(newLaptops);
			return newLaptops.Id;
		}

		public void Delete(Guid id)
		{
			var employee = _repository.GetAll().FirstOrDefault(s => s.Id == id);
			if (employee != null)
			{
				_repository.Delete(employee);
			}
		}

		public Laptops GetById(Guid id)
		{
			return _repository.GetAll().FirstOrDefault(s => s.Id == id);
		}
		public void Update(Guid id, string Name, string Description, string Manufacturer, decimal Price, int Ram, string CPU, string Hard_Drive)
		{
			var existing = GetById(id);
			if (existing != null)
			{
				var newEmployee = new Domain.Laptops
				{
					Id = id,
					Name = Name,
					Description = Description,
					Manufacturer = Manufacturer,
					Price = Price,
					CPU = CPU,
					Hard_Drive = Hard_Drive
				};
				_repository.Update(id, newEmployee);
			}
		}

		IEnumerable<GetLaptopResponse> ILaptopService.GetAll()
		{
			IQueryable<Domain.Laptops> allEmployees = _repository.GetAll();

			return Mapper.MapLaptop(allEmployees.ToList());
		}

		GetLaptopRequest ILaptopService.GetById(Guid id)
		{

			var laptops = _repository.GetAll().FirstOrDefault(s => s.Id == id);
			return Mapper.MapLaptop(laptops);
		}
	}
}
