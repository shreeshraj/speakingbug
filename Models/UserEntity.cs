using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreProject.Models
{
    [Table("tblUser")]
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Please enter Nickname")]
        public string Name { get; set; }
        [Required(ErrorMessage="Please enter Age")]
        public string Age { get; set; }
        [Required]
        public string Sex { get; set; }
        public string Location { get; set; }
        [Required(ErrorMessage="Please enter Skype Id")]
        public string Skype { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public UserEntity()
        {
            this.IsActive = true;
            this.UpdatedDateTime = System.DateTime.Now.Date;
            
        }
  
    }
}