using ChemiShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemiShop.Model.Models
{
    [Table("Pages")]
    public class Page:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [MaxLength(256)]
        [Required]
        public string Name { set; get; }
        [MaxLength(256)]
        [Required]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }
        public string Content { set; get; }
    }
}
