using System.ComponentModel.DataAnnotations;

namespace w10d2.Models
{
    public class Job
    {
        public string Id { get; set; }

        public Job(string jobTitle, int rate, int hours, string description, string company)
        {
            JobTitle = jobTitle;
            Rate = rate;
            Hours = hours;
            Description = description;
            Company = company;
            Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string JobTitle { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Rate { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Hours { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Company { get; set; }
    }
}