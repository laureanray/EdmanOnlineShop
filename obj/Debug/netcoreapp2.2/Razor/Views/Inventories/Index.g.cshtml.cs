#pragma checksum "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Inventories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d7356489b8c4d4db827b952ba586950772edd8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventories_Index), @"mvc.1.0.view", @"/Views/Inventories/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventories/Index.cshtml", typeof(AspNetCore.Views_Inventories_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\_ViewImports.cshtml"
using EdmanOnlineShop;

#line default
#line hidden
#line 2 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\_ViewImports.cshtml"
using EdmanOnlineShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d7356489b8c4d4db827b952ba586950772edd8b", @"/Views/Inventories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7c810fb923ab48b6fd0b186cb5101541f59b0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EdmanOnlineShop.ViewModels.IndexInventoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Inventories\Index.cshtml"
  
    ViewData["Title"] = "Products Table";
    Layout = "_DashboardLayout";

#line default
#line hidden
            BeginContext(159, 517, true);
            WriteLiteral(@"
<div class=""row mb-2"">
    <div class=""col"">
        <h2 class=""h2""> Inventory </h2>
    </div>
</div>

         <table id=""products_table"" class=""table  table-sm"">
             <thead>
             <tr>
                 <th scope=""col"">ID</th>
                 <th scope=""col"">Product Name</th>
                 <th scope=""col"">Quantity</th>
                 <th scope=""col"">Critical</th>
                 <th scope=""col"">Restock</th>
             </tr>
             </thead>
             <tbody>
");
            EndContext();
#line 25 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Inventories\Index.cshtml"
               foreach (var item in Model)
              {

#line default
#line hidden
            BeginContext(737, 52, true);
            WriteLiteral("                  <tr>\r\n                      <td > ");
            EndContext();
            BeginContext(790, 46, false);
#line 28 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Inventories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.InventoryID));

#line default
#line hidden
            EndContext();
            BeginContext(836, 35, true);
            WriteLiteral("</td>\r\n                      <td > ");
            EndContext();
            BeginContext(872, 46, false);
#line 29 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Inventories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(918, 35, true);
            WriteLiteral("</td>\r\n                      <td > ");
            EndContext();
            BeginContext(954, 43, false);
#line 30 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Inventories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(997, 35, true);
            WriteLiteral("</td>\r\n                      <td > ");
            EndContext();
            BeginContext(1033, 44, false);
#line 31 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Inventories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Crtitical));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 144, true);
            WriteLiteral("</td>\r\n                      <td> <a class=\"btn btn-primary text-light\"> Restock</a>\r\n                          </td>\r\n                  </tr>\r\n");
            EndContext();
#line 35 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Inventories\Index.cshtml"
              }

#line default
#line hidden
            BeginContext(1238, 42, true);
            WriteLiteral("             </tbody>\r\n         </table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EdmanOnlineShop.ViewModels.IndexInventoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
