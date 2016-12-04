using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL
{
    public class Blog
    {

        [Key]
        public Guid BlogId { get; set; }

        [Required]
        public string Name { get; set; }
        public string BlogBody { get; set; }
        public string Creator { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }
    }
}