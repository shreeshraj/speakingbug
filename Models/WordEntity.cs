using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreProject.Models
{
     [Table("tblWord")]
    public class WordEntity
    {


        [Key]
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        [Required]
        public string Word { get; set; }
        [Required]
        public string Description { get; set; }

        public WordEntity(){
            this.Date=System.DateTime.Now;
        }
    }
}