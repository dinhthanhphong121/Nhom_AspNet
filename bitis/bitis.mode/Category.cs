using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitis.mode
{
     public class Category
    {
        [Key]
        public int IdDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
    }
}
