using System.ComponentModel.DataAnnotations;

namespace w10d2.Models
{
    public class House
    {
        public string Id { get; set; }

        public House(int year, int price, int bathrooms, int bedrooms, int levels, string imgUrl, string description)
        {
            Year = year;
            Price = price;
            Bathrooms = bathrooms;
            Bedrooms = bedrooms;
            Levels = levels;
            ImgUrl = imgUrl;
            Description = description;
            Id = Guid.NewGuid().ToString();
        }

        [Required]
        public int Year { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Price { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Bathrooms { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Bedrooms { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Levels { get; set; }

        [Required]
        public string ImgUrl { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }
    }
}