using System.ComponentModel.DataAnnotations;

namespace RealEstateMVC.Models
{
    public class Property
    {
        [Key]
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
    }
}
