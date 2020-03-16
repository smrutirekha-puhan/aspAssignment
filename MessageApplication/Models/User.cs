using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MessageApplication.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName="nvarchar(250)")]
        [Required]
        [DisplayName("User Name")]
        public string UserName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        
        public string Message { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Comment { get; set; }

        [Column(TypeName = "int")]
        public int Like { get; set; }
        //public string Share { get; set; }
    }
}
