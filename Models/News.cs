using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LangMulti.Models
{
    public class News
    {
        [Key]
        public int News_Id { get; set; }

    
        public int Lang_Id { get; set; }

        [Required]
        [MaxLength(300)]

        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [MaxLength(50)]
        public string ImageName { get; set; }

        public DateTime CreateDate { get; set; }



        public Language Language { get; set; }
    }
}
