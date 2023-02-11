using System.ComponentModel.DataAnnotations;

namespace Handmade.Web.Models
{
	public class EmbroideryDto
	{
		public int EmbroideryId { get; set; }
		public string EmbroideryName { get; set; }
		public double Price { get; set; }
		public string CategoryName { get; set; }
		public string ImageURL { get; set; }

	}
}

