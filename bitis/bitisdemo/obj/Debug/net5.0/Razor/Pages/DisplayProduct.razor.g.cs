#pragma checksum "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\DisplayProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3820ffe9af9bcf88fa9d8e9c6426ee7b08bc7880"
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
    public partial class DisplayProduct : DisplayProductBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col l-2-4");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "class", "product");
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 4 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\DisplayProduct.razor"
                               $"productdetails/{Product.IdSp}"

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "product-header");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "class", "product-img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 6 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\DisplayProduct.razor"
                                           Product.HinhSp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "product-heading");
            __builder.OpenElement(13, "h2");
            __builder.AddAttribute(14, "class", "product-name");
            __builder.AddContent(15, 
#nullable restore
#line 9 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\DisplayProduct.razor"
                                      Product.TenSp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "h3");
            __builder.AddAttribute(18, "class", "product-price");
            __builder.AddContent(19, 
#nullable restore
#line 10 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\DisplayProduct.razor"
                                       Product.Gia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "product-hover");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "product-wrap");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 16 "D:\GitHub\Nhom_AspNet\bitis\bitisdemo\Pages\DisplayProduct.razor"
                           $"editproduct/{Product.IdSp}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "class", "btn btn-primary product-btn");
            __builder.AddContent(28, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n                ");
            __builder.AddMarkupContent(30, "<a href=\"#\" class=\"btn btn-danger product-btn\">Delete</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591