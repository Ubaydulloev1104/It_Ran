namespace Employee.Web.Api.Contacts.Requests
{
    public record GetLaptopRequest
    {
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Manufacturer { get; set; } = string.Empty;
		public decimal Price { get; set; }
		public int RAM { get; set; }
		public string CPU { get; set; } = string.Empty;
		public string HardDrive { get; set; } = string.Empty;
	}
}
