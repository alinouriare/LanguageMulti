using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LangMulti.Models
{
    public class Language
    {
        [Key]
        public int Lang_Id { get; set; }

        [Required]
        [MaxLength(100)]

        public string LanguageTitle { get; set; }

        public List<News> News { get; set; }

    }
}
