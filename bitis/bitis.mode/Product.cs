using System;
using System.ComponentModel.DataAnnotations;

namespace bitis.mode
{
    public class Product
    {
        [Key]
        public int IdSp { get; set; }
        
        [Required(ErrorMessage = "Nhập mã sản phẩm")]
        public string MaSp { get; set; }
        
        [Required(ErrorMessage = "Nhập tên sản phẩm")]
        public string TenSp { get; set; }
        
        [Required(ErrorMessage = "Nhập giá sản phẩm")]
        public int Gia { get; set; }
        
        [Required(ErrorMessage = "Nhập số lượng sản phẩm")]
        public int SoLuong { get; set; }
        public int IdDanhMuc { get; set; }
        public string MoTaSp { get; set; }
        public string ChiTietSP { get; set; }
        public string HinhSp { get; set; }
    }
}
