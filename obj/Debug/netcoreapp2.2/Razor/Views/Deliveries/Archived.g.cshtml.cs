#pragma checksum "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Deliveries\Archived.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5d35904cff7f4d24507e1f98ff7fc4b9084f282"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deliveries_Archived), @"mvc.1.0.view", @"/Views/Deliveries/Archived.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Deliveries/Archived.cshtml", typeof(AspNetCore.Views_Deliveries_Archived))]
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
#line 1 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\_ViewImports.cshtml"
using EdmanOnlineShop;

#line default
#line hidden
#line 2 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\_ViewImports.cshtml"
using EdmanOnlineShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5d35904cff7f4d24507e1f98ff7fc4b9084f282", @"/Views/Deliveries/Archived.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7c810fb923ab48b6fd0b186cb5101541f59b0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Deliveries_Archived : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EdmanOnlineShop.ViewModels.IndexOrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Deliveries\Archived.cshtml"
  
    ViewData["Title"] = "Deliveries";
    Layout = "_DashboardLayout";

#line default
#line hidden
            BeginContext(137, 368, true);
            WriteLiteral(@"

<h2 class=""h2"">Archived</h2>

<table id=""archived_table"" class=""table table-bordered table-sm"">
    <thead>
    <tr>
        <th> Deliver Date </th>
        <th> Customer Name</th>
        <th> Product </th>
        <th> Quantity </th>
        <th> Price </th>
        <th> Total </th>
        <th> Status </th>

    </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 25 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Deliveries\Archived.cshtml"
     foreach (var item in Model.Orders)
    {

#line default
#line hidden
            BeginContext(553, 50, true);
            WriteLiteral("        <tr>\r\n            <td class=\"date-only\">  ");
            EndContext();
            BeginContext(604, 16, false);
#line 28 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Deliveries\Archived.cshtml"
                               Write(item.DeliverDate);

#line default
#line hidden
            EndContext();
            BeginContext(620, 25, true);
            WriteLiteral("</td>\r\n            <td > ");
            EndContext();
            BeginContext(646, 14, false);
#line 29 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Deliveries\Archived.cshtml"
             Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(660, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(662, 13, false);
#line 29 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Deliveries\Archived.cshtml"
                             Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(675, 45, true);
            WriteLiteral(" </td>\r\n            <td >\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 720, "\"", 774, 2);
            WriteAttributeValue("", 727, "/Products/ViewProduct?productId=", 727, 32, true);
#line 31 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Deliveries\Archived.cshtml"
WriteAttributeValue("", 759, item.ProductID, 759, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(775, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(777, 46, false);
#line 31 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Deliveries\Archived.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(823, 42, true);
            WriteLiteral("</a>\r\n            </td>\r\n            <td> ");
            EndContext();
            BeginContext(866, 13, false);
#line 33 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Deliveries\Archived.cshtml"
            Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(879, 25, true);
            WriteLiteral(" </td>\r\n            <td> ");
            EndContext();
            BeginContext(905, 10, false);
#line 34 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Deliveries\Archived.cshtml"
            Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(915, 25, true);
            WriteLiteral(" </td>\r\n            <td> ");
            EndContext();
            BeginContext(941, 11, false);
#line 35 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Deliveries\Archived.cshtml"
            Write(item.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(952, 62, true);
            WriteLiteral("</td>\r\n            <td class=\"text-success\">\r\n                ");
            EndContext();
            BeginContext(1015, 11, false);
#line 37 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Deliveries\Archived.cshtml"
           Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1026, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 40 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Deliveries\Archived.cshtml"
    }

#line default
#line hidden
            BeginContext(1069, 72, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<script >\r\n\r\nconsole.log(moment());\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EdmanOnlineShop.ViewModels.IndexOrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591