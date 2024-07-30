using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Books
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string? AuthorName { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
    }
}
