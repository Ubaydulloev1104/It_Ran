namespace Web.Api.Dto
{
    public record CreateLaptopDto
    {
		public string Name { get; set; }
		public string Description { get; set; }
		public string Manufacturer { get; set; }

		public decimal Price { get; set; }
		public int Ram { get; set; }
		public string CPU { get; set; }
		public string Hard_Drive { get; set; }

	}
}
