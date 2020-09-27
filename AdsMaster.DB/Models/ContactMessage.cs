using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
    [Table("am_ContactMessage")]
    public class ContactMessage
    {
        [Key]
        public int ContactMessageID { get; set; }

        [Column(TypeName = "NVARCHAR(256)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "NVARCHAR(256)")]
        [Required]
        public string Subject { get; set; }

        [Column(TypeName = "NVARCHAR(256)")]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = "NVARCHAR(4000)")]
        [Required]
        public string Message { get; set; }

        public bool IsViewed { get; set; }
    }
}
