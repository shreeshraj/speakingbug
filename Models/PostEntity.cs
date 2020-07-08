using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreProject.Models
{
    [Table("tblPost")]
    public class PostEntity
    {
            [Key]
            public int Id { get; set; }
            [Required]
            public string Title { get; set; }
          
            [Required]
            public string Description { get; set; }
         
           
            public DateTime? DateTime { get; set; }
            

       
    }
}