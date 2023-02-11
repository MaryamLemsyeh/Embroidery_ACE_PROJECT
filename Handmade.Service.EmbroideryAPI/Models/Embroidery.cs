using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Handmade.Service.EmbroideryAPI.Models
{
    [Table("Embroideries")]
    public class Embroidery
	{
        [Key]
        public int EmbroideryId { get; set; }
        [Required, StringLength(25)]
        public string EmbroideryName { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }
    }
}
