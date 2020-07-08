using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreProject.Models
{
    [Table("tblContact")]
    public class ContactEntity
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Please enter name")]
       
        public string Name { get; set; }
        [Required]
         [EmailAddress(ErrorMessage="Please enter valid email")]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string  Message { get; set; }
    }
}