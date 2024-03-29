#pragma checksum "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\ViewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa295281f89ede83c70a47ff4e5ae88dba3d8383"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ViewProduct), @"mvc.1.0.view", @"/Views/Products/ViewProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/ViewProduct.cshtml", typeof(AspNetCore.Views_Products_ViewProduct))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa295281f89ede83c70a47ff4e5ae88dba3d8383", @"/Views/Products/ViewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7c810fb923ab48b6fd0b186cb5101541f59b0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ViewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EdmanOnlineShop.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\ViewProduct.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
            BeginContext(85, 601, true);
            WriteLiteral(@"


<div class=""container-fluid"" style=""width: 90%!important; margin: auto!important;"">
    <div class=""row"">
        <div class=""col mt-3"">
               <nav aria-label=""breadcrumb"">
                 <ol class=""breadcrumb"" style=""border-radius: 0!important; background: #fafafa;"">
                   <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                     <li class=""breadcrumb-item""><a href=""#"">Products</a></li>
                     <li class=""breadcrumb-item""><a href=""#"">Category</a></li>
                     <li class=""breadcrumb-item active"" aria-current=""page"">");
            EndContext();
            BeginContext(687, 17, false);
#line 17 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\ViewProduct.cshtml"
                                                                       Write(Model.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(704, 163, true);
            WriteLiteral("</li>\r\n                 </ol>\r\n               </nav>\r\n        </div>\r\n    </div>\r\n    <div class=\"row view-product m-0\">\r\n\r\n        <div class=\"col-4 pt-2 pb-2\">\r\n");
            EndContext();
#line 25 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\ViewProduct.cshtml"
              
                var base64 = Convert.ToBase64String(@Model.ProductImage);
                var imgSrc = String.Format("data:image/gif;base64,{0}", base64);
            

#line default
#line hidden
            BeginContext(1055, 16, true);
            WriteLiteral("            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1071, "\"", 1084, 1);
#line 29 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\ViewProduct.cshtml"
WriteAttributeValue("", 1077, imgSrc, 1077, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1085, 111, true);
            WriteLiteral(" class=\"img-fluid\" alt=\"\">\r\n        </div>\r\n        <div class=\"col-8\">\r\n            <h4 class=\"product-name\"> ");
            EndContext();
            BeginContext(1197, 43, false);
#line 32 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\ViewProduct.cshtml"
                                 Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 62, true);
            WriteLiteral("</h4>\r\n            <p class=\"text-muted product-description\"> ");
            EndContext();
            BeginContext(1303, 50, false);
#line 33 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\ViewProduct.cshtml"
                                                  Write(Html.DisplayFor(model => model.ProductDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 85, true);
            WriteLiteral("</p>\r\n            <h2 class=\"product-price product-price-lg\"> ₱ <span class=\"price\"> ");
            EndContext();
            BeginContext(1439, 37, false);
#line 34 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\ViewProduct.cshtml"
                                                                          Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1476, 383, true);
            WriteLiteral(@" </span></h2>
            <div class=""row mt-4"">
                <div class=""col-3 pr-0"">

                    <button class=""btn btn-dark btn-block btn-lg"">
                        <i class=""fas fa-fw fa-shopping-cart""></i>
                        Buy Now
                    </button>

                </div>
                <div class=""col-3 pl-0"">
                    ");
            EndContext();
            BeginContext(1859, 338, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa295281f89ede83c70a47ff4e5ae88dba3d83838189", async() => {
                BeginContext(1949, 241, true);
                WriteLiteral("\r\n                        <button class=\"btn btn-primary btn-block btn-lg\">\r\n                            <i class=\"fas fa-fw fa-cart-plus\"></i>\r\n                            Add to Cart\r\n                        </button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\laure\Desktop\Projects\EdmanOnlineShop\Views\Products\ViewProduct.cshtml"
                                                         WriteLiteral(Model.ProductID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2197, 88, true);
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EdmanOnlineShop.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
