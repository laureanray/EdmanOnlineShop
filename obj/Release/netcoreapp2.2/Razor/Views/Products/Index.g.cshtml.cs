#pragma checksum "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8ca312c75c9138df4fa932f02cc08221c778100"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
#line 1 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8ca312c75c9138df4fa932f02cc08221c778100", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7c810fb923ab48b6fd0b186cb5101541f59b0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EdmanOnlineShop.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(194, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
            BeginContext(240, 166, true);
            WriteLiteral("\r\n<div class=\"wrapper\" style=\"margin: auto!important;width: 90%\">\r\n    \r\n    \r\n<div class=\"row mb-2\">\r\n    <div class=\"col\">\r\n        <h2 class=\"h2\"> Products </h2>\r\n");
            EndContext();
#line 16 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\Index.cshtml"
         if (User.IsInRole("Admin"))
        {

#line default
#line hidden
            BeginContext(455, 68, true);
            WriteLiteral("            <a href=\"/Products/ProductsTable\"> Products Table </a>\r\n");
            EndContext();
#line 19 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(534, 79, true);
            WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n\r\n<div class=\"row\" >\r\n    <div class=\"col-2\">\r\n        ");
            EndContext();
            BeginContext(613, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8ca312c75c9138df4fa932f02cc08221c7781004989", async() => {
                BeginContext(629, 115, true);
                WriteLiteral("\r\n            <input type=\"text\" name=\"ProductSearch\" class=\"form-control\" placeholder=\"Search products\">\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(751, 67, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-10\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 33 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\Index.cshtml"
              foreach (var item in Model)
             {

#line default
#line hidden
            BeginContext(877, 86, true);
            WriteLiteral("                <div class=\"col-lg-3 col-md-8 mb-3 padding-0\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 963, "\"", 1047, 2);
            WriteAttributeValue("", 970, "/Products/ViewProduct?productId=", 970, 32, true);
#line 36 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\Index.cshtml"
WriteAttributeValue("", 1002, Html.DisplayFor(modelItem => item.ProductID), 1002, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1048, 137, true);
            WriteLiteral(">\r\n                        <div class=\"card h-100 card-product\">\r\n                            <div class=\"card-body card-body-product\">\r\n");
            EndContext();
#line 39 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\Index.cshtml"
                                  
                                                        var base64 = Convert.ToBase64String(item.ProductImage);
                                                        var imgSrc = String.Format("data:image/gif;base64,{0}", base64);
                                                     

#line default
#line hidden
            BeginContext(1512, 227, true);
            WriteLiteral("                                <div class=\"img-holder\" style=\"height: 225px!important;\" >\r\n                                    <span class=\"helper\"></span>\r\n                                    <img class=\"card-img-top my-auto\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1739, "\"", 1752, 1);
#line 45 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\Index.cshtml"
WriteAttributeValue("", 1745, imgSrc, 1745, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1753, 240, true);
            WriteLiteral(" style=\"width: 220px; height:  220px;\" alt=\"\"/>\r\n                                </div>\r\n                                                    <h4 class=\"card-title product-name-card\">\r\n                                                        ");
            EndContext();
            BeginContext(1994, 46, false);
#line 48 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(2040, 218, true);
            WriteLiteral("\r\n                                                    </h4>\r\n                                                    <h5 class=\"product-price\">\r\n                                                        ₱<span class=\"price\">");
            EndContext();
            BeginContext(2259, 40, false);
#line 51 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\Index.cshtml"
                                                                        Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2299, 383, true);
            WriteLiteral(@"</span>
                                                    </h5>
                            </div>
                            <div class=""card-footer"">    
                                <p class=""mb-0"">
                                </p>
                                </div>
                        </div>
                    </a>
        
                </div>
");
            EndContext();
#line 62 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\Index.cshtml"
                 
             }

#line default
#line hidden
            BeginContext(2717, 44, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EdmanOnlineShop.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
