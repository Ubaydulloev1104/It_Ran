using Application.Abstractions.Services;
using Domain;
using Employee.Web.Api.Contacts.Requests;
using Infrastructure.Data;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using Web.Api.Dto;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LaptopController : ControllerBase
    {
        private readonly ILaptopService _Laptopservice;
        public LaptopController(ILaptopService Laptopservice, ApplicationDbContext context)
        {
			_Laptopservice = _Laptopservice;

            if (!context.Laptops.Any())
            {
                var newContact = new Contact()
                {
                    Id = Guid.NewGuid(),
                    Address = "some",
                    City = "st",
                    Country = "c",
                    Fax = "f",
                    Phone = "f",
                    PostalCode = "f",
                    Region = "f",

                };
                var newEmployee = new Domain.Laptops
                {
					Name = " HP ",
					Manufacturer = " Hp ",
					Description = "bla_bla",
					Hard_Drive = "ssd",
					Ram = 16,
					CPU = "ddo",
					Price = 12345
				};
                context.Contact.Add(newContact);
                context.Laptops.Add(newEmployee);
                context.SaveChanges();
            }
        }

		[HttpGet]
        public IEnumerable Get()
        {
            return _Laptopservice.GetAll();
        }

        [HttpGet("{id}")]
        public GetLaptopRequest Get(Guid id)
        {
            return _Laptopservice.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateLaptopDto dto)
        {
            var createdId = _Laptopservice.Create(dto.Name, dto.Description ,dto.Manufacturer, dto.Price, dto.Ram, dto.CPU,dto.Hard_Drive);
            return Created($"Employees/{createdId}", null);
        }

        [HttpPut("{id}")]
        public GetLaptopRequest Put(Guid id)
        {
            return _Laptopservice.GetById(id);
        }
    }
}