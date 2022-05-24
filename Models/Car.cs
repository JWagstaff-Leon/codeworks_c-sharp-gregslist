using System.ComponentModel.DataAnnotations;

namespace w10d2.Models
{
    public class Car
    {
        public Car(string make, string model, string color, int year, int price, string description, string imgUrl)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
            Price = price;
            Description = description;
            ImgUrl = imgUrl;
            Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }
        
        public string Color { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Price { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        public string ImgUrl { get; set; }

        public string Id { get; set; }
    }
}