using System.ComponentModel.DataAnnotations;

namespace LearningASP.Models
{
    public class Chapter
    {
        public int Id { get; set; }

        public string? Title { get; set; }
        
        public string? Description { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; } = default;
        
        public string? AuthorName { get; set; }
        
    }
}
