using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shanash.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100000,ErrorMessage ="Display order must be between 1 and 100000")]
        public int displayOrder { get; set; }
        public DateTime createdDateTime { get; set; } = DateTime.Now;

    }
}
