#pragma checksum "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf650a2ef5ee334df2d4b801b10b777de3e1057"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf650a2ef5ee334df2d4b801b10b777de3e1057", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7c810fb923ab48b6fd0b186cb5101541f59b0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EdmanOnlineShop.ViewModels.CartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateQuantity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
  
    ViewBag.Title = "Category";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(114, 79, true);
            WriteLiteral("\r\n\r\n<div class=\"wrapper\">\r\n    <div class=\"row\">\r\n        <div class=\"col-8\">\r\n");
            EndContext();
#line 11 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
             foreach (var cartItem in Model.CartItems)
            {

#line default
#line hidden
            BeginContext(264, 196, true);
            WriteLiteral("                <div class=\"card mb-1\">\r\n                    <div class=\"card-body\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2 p-0 pr-2 pl-2 m-0\">\r\n");
            EndContext();
#line 17 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                  
                                    var base64 = Convert.ToBase64String(@cartItem.ProductImage);
                                    var imgSrc = String.Format("data:image/gif;base64,{0}", base64);
                                

#line default
#line hidden
            BeginContext(731, 36, true);
            WriteLiteral("                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 767, "\"", 780, 1);
#line 21 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 773, imgSrc, 773, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(781, 184, true);
            WriteLiteral(" class=\"img-fluid\" alt=\"\"/>\r\n                            </div>\r\n                            <div class=\"col-10 p-0 m-0\">\r\n                                <h4 class=\"product-name-h4\"> ");
            EndContext();
            BeginContext(966, 50, false);
#line 24 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                                        Write(Html.DisplayFor(modelItem => cartItem.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 355, true);
            WriteLiteral(@"</h4>

                                <div class=""row mr-4"">
                                    <div class=""col-8"">
                                        <p class=""product-price-cart"">
                                            ₱
                                            <span class=""price"">
                                                ");
            EndContext();
            BeginContext(1372, 44, false);
#line 31 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => cartItem.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 339, true);
            WriteLiteral(@"</span>
                                        </p>
                                    </div>
                                    <div class=""col-4"">
                                        <label for=""""> Quantity</label>

                                        <div class=""form-row"">
                                            ");
            EndContext();
            BeginContext(1755, 649, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccf650a2ef5ee334df2d4b801b10b777de3e10577241", async() => {
                BeginContext(1831, 192, true);
                WriteLiteral("\r\n                                            <div class=\"col p-0 m-0\">\r\n                                                <input type=\"number\" class=\"form-control\" name=\"quantity\" id=\"quantity\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2023, "\"", 2049, 1);
#line 40 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2031, cartItem.Quantity, 2031, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2050, 347, true);
                WriteLiteral(@"/>
                                            </div>
                                            <div class=""col p-0 m-0"">
                                                <input type=""submit"" class=""btn btn-dark btn-block"" placeholder=""Update""/>
                                            </div>
                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                                                                       WriteLiteral(cartItem.ProductID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2404, 121, true);
            WriteLiteral("\r\n                                            <div class=\"col p-0 m-0\">\r\n                                                ");
            EndContext();
            BeginContext(2525, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccf650a2ef5ee334df2d4b801b10b777de3e105711000", async() => {
                BeginContext(2601, 162, true);
                WriteLiteral("\r\n                                                    <button class=\"btn btn-danger btn-block\"> Delete </button>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                                                                           WriteLiteral(cartItem.ProductID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2770, 306, true);
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
            EndContext();
#line 58 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3091, 57, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-4\">\r\n            ");
            EndContext();
            BeginContext(3148, 361, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccf650a2ef5ee334df2d4b801b10b777de3e105714428", async() => {
                BeginContext(3155, 130, true);
                WriteLiteral("\r\n                <h6> Order Summary </h6>\r\n                <p class=\"text-muted\"> Total Ammount Due:  </p>\r\n                <h5> ");
                EndContext();
                BeginContext(3286, 11, false);
#line 64 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
                Write(Model.Total);

#line default
#line hidden
                EndContext();
                BeginContext(3297, 205, true);
                WriteLiteral(" </h5>\r\n                <button class=\"btn btn-primary btn-lg\">\r\n                    <i class=\"fas fa-fw fa-cart-plus\"></i>\r\n                    Proceed To Checkout\r\n                </button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3509, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EdmanOnlineShop.ViewModels.CartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
