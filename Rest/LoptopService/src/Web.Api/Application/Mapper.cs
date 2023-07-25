
using Employee.Web.Api.Contacts.Response;

namespace Application
{
    public static class Mapper
    {
        public static IEnumerable<GetLaptopResponse> MapLaptop(IEnumerable<Domain.Laptops> laptop)
        {
            return laptop.Select(e => new GetLaptopResponse()
            {
                Name = e.Name,
            });
        }

        public static GetLaptopResponse MapLaptop(Domain.Laptops laptop)
        {
            return new GetLaptopResponse()
            {
                Name = laptop.Name,   
            };
        }
    }
}
