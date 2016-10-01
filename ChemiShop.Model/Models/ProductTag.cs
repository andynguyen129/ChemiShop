using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemiShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { set; get; }
        [Key]
        [MaxLength(50)]
        public string TagID { set; get; }
        [ForeignKey("ProductID")]
        public virtual Product product { set; get; }
        [ForeignKey("TagID")]
        public virtual Tag tag { set; get; }
    }
}
