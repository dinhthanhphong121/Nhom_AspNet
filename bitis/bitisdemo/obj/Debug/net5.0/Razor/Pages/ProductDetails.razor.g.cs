#pragma checksum "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60ea9bbf24a84eb110ffe60465ab423047fac7c4"
// <auto-generated/>
#pragma warning disable 1591
namespace bitisdemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\_Imports.razor"
using bitisdemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\_Imports.razor"
using bitisdemo.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productdetails/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/productdetails")]
    public partial class ProductDetails : ProductDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\ProductDetails.razor"
 if (Product == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 7 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\ProductDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "grid wide");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<div class=\"col l-1\"></div>\r\n            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col l-5");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "product_details_avt");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 15 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\ProductDetails.razor"
                               Product.HinhSp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "alt");
            __builder.AddAttribute(13, "class", "product_details_img");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "product_details_description");
            __builder.OpenElement(17, "span");
            __builder.AddAttribute(18, "class", "product_details_description-text");
            __builder.AddContent(19, 
#nullable restore
#line 19 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\ProductDetails.razor"
                         Product.ChiTietSP

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.AddMarkupContent(21, @"<div class=""product_details_evaluate""><span class=""product_details_evaluate-heading"">
                        Đánh giá sản phẩm
                    </span>
                    <div class=""product_details_evaluate-wrap""><div class=""product_details_evaluate-star""><div><i class=""far fa-star product_details_evaluate-star-icon ""></i>
                                <i class=""far fa-star product_details_evaluate-star-icon ""></i>
                                <i class=""far fa-star product_details_evaluate-star-icon ""></i>
                                <i class=""far fa-star product_details_evaluate-star-icon ""></i>
                                <i class=""far fa-star product_details_evaluate-star-icon ""></i></div>
                            <span class=""product_details_evaluate-star-text"">(0 đánh giá)</span></div>
                        <button class=""product_details_evaluate-btn""> Viết đánh giá</button></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col l-6");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "product_details");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "product_details_wrap");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "product_details_heading");
            __builder.AddContent(31, 
#nullable restore
#line 46 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\ProductDetails.razor"
                             Product.TenSp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "product_details_code");
            __builder.AddMarkupContent(35, "\r\n                            Mã sản phẩm: ");
            __builder.AddContent(36, 
#nullable restore
#line 49 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\ProductDetails.razor"
                                          Product.MaSp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "product_details_body");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "product_details_price");
            __builder.AddContent(42, 
#nullable restore
#line 53 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\ProductDetails.razor"
                                 Product.Gia

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, " ₫\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.AddMarkupContent(45, "<div class=\"product_details_vat\">\r\n                                *Đã bao gồm VAT\r\n                            </div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.AddMarkupContent(47, @"<div class=""product_details_color""><span class=""product_details_text"">
                                màu sắc
                            </span>
                            <button class=""product_details_color_btn""><img src=""https://product.hstatic.net/1000230642/product/deb008400xam27_4__765732c397cf4c248b88ea7ea65364f5_icon.jpg"" alt class=""product_details_color_btn-img"">
                                <span class=""product_details_color_btn_text"">Xám</span></button></div>
                        ");
            __builder.AddMarkupContent(48, @"<div class=""product_details_size""><span class=""product_details_text"">
                                kích thước
                            </span>
                            <button class=""product_details_size_btn""><span class=""product_details_size_btn_text"">28</span></button></div>

                        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "product_details_quantity");
            __builder.OpenElement(51, "span");
            __builder.AddAttribute(52, "class", "product_details_text");
            __builder.AddMarkupContent(53, "\r\n                                Còn hàng: ");
            __builder.OpenElement(54, "strong");
            __builder.AddContent(55, 
#nullable restore
#line 80 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\ProductDetails.razor"
                                                   Product.SoLuong

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, " Sản phẩm\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                            ");
            __builder.AddMarkupContent(58, "<a href class=\"product_details_quantity_instruct\">+ hướng dẫn xem thêm size</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n                        ");
            __builder.AddMarkupContent(60, @"<div class=""product_details_btn""><button class=""product_details-btn-buying"">Mua ngay</button>

                            <button class=""product_details-btn-like""><i class=""fa fa-heart""></i>
                                Thêm vào yêu thích
                            </button></div>

                        ");
            __builder.AddMarkupContent(61, @"<div class=""product_details_advise""><span class=""product_details_text"">
                                Tư vấn: 0966 158 666
                            </span>
                            <div class=""product_details_pay-wrap""><div class=""product_details_pay""><img src=""asset/img/zalopay.png"" alt class=""product_details_pay_img""></div>
                                <div class=""product_details_pay""><img src=""asset/img/visa.png"" alt class=""product_details_pay_img""></div>
                                <div class=""product_details_pay""><img src=""asset/img/mastercard.png"" alt class=""product_details_pay_img""></div>
                                <div class=""product_details_pay""><img src=""asset/img/cod.png"" alt class=""product_details_pay_img""></div></div></div>

                        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "card-footer" + " text-center" + " " + (
#nullable restore
#line 114 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\ProductDetails.razor"
                                                             CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "<a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n                            ");
            __builder.OpenElement(65, "a");
            __builder.AddAttribute(66, "href", 
#nullable restore
#line 116 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\ProductDetails.razor"
                                       $"editproduct/{Product.IdSp}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(67, "class", "btn btn-primary");
            __builder.AddContent(68, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                            ");
            __builder.AddMarkupContent(70, "<a href=\"#\" class=\"btn btn-danger\">Delete</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 125 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\ProductDetails.razor"

}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(71, "div");
            __builder.OpenComponent<bitisdemo.Shared.Footer>(72);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
