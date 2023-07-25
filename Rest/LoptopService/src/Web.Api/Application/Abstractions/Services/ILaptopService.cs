using Domain;
using Employee.Web.Api.Contacts.Requests;
using Employee.Web.Api.Contacts.Response;

namespace Application.Abstractions.Services
{
    public interface ILaptopService
    {
        IEnumerable<GetLaptopResponse> GetAll();
		Guid Create(string Name, string Description,string Manufacturer,decimal Price, int Ram , string CPU ,string Hard_Drive);
        void Delete(Guid id);
        void Update(Guid id, string Name, string Description, string Manufacturer, decimal Price, int Ram, string CPU, string Hard_Drive);
		GetLaptopRequest GetById(Guid id);
	}
}
