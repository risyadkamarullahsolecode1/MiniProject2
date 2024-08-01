using System.ComponentModel.DataAnnotations;

namespace MiniProject2.Models
{
    public class Menu
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100), MinLength(2)]
        public string Name { get; set; }
        [Range(0.01, 100000)]
        public decimal Price { get; set; }
        [RegularExpression("Food|Beverage|Desert")]
        public string Category { get; set; }
        [Range(0, 5)]
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsAvailable {  get; set; }

        public Menu(int id, string name, decimal price, string category, int rating, DateTime createdDate, bool isAvailable)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
            Rating = rating;
            CreatedDate = createdDate;
            IsAvailable = isAvailable;
        }
    }
}
