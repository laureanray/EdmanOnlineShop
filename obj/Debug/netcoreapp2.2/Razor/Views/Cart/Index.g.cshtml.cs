#pragma checksum "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6ac1391f16124a4662f0e846e2ac38f9858f74e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ac1391f16124a4662f0e846e2ac38f9858f74e", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7c810fb923ab48b6fd0b186cb5101541f59b0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EdmanOnlineShop.ViewModels.CartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateQuantity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                 if (Model.CartItems.Count == 0)
                {

#line default
#line hidden
            BeginContext(262, 63, true);
            WriteLiteral("                    <h1 class=\"display-4\"> Empty Cart :(</h1>\r\n");
            EndContext();
#line 14 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
                }
                else{
                
                    foreach (var cartItem in Model.CartItems)
            {

#line default
#line hidden
            BeginContext(463, 196, true);
            WriteLiteral("                <div class=\"card mb-1\">\r\n                    <div class=\"card-body\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2 p-0 pr-2 pl-2 m-0\">\r\n");
            EndContext();
#line 23 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                  
                                    var base64 = Convert.ToBase64String(@cartItem.ProductImage);
                                    var imgSrc = String.Format("data:image/gif;base64,{0}", base64);
                                

#line default
#line hidden
            BeginContext(930, 36, true);
            WriteLiteral("                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 966, "\"", 979, 1);
#line 27 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 972, imgSrc, 972, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(980, 184, true);
            WriteLiteral(" class=\"img-fluid\" alt=\"\"/>\r\n                            </div>\r\n                            <div class=\"col-10 p-0 m-0\">\r\n                                <h4 class=\"product-name-h4\"> ");
            EndContext();
            BeginContext(1165, 50, false);
#line 30 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                                        Write(Html.DisplayFor(modelItem => cartItem.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 355, true);
            WriteLiteral(@"</h4>

                                <div class=""row mr-4"">
                                    <div class=""col-7"">
                                        <p class=""product-price-cart"">
                                            ₱
                                            <span class=""price"">
                                                ");
            EndContext();
            BeginContext(1571, 44, false);
#line 37 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => cartItem.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 339, true);
            WriteLiteral(@"</span>
                                        </p>
                                    </div>
                                    <div class=""col-5"">
                                        <label for=""""> Quantity</label>

                                        <div class=""form-row"">
                                            ");
            EndContext();
            BeginContext(1954, 788, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6ac1391f16124a4662f0e846e2ac38f9858f74e8002", async() => {
                BeginContext(2050, 300, true);
                WriteLiteral(@"
                                                <div class=""col p-0 m-0"">
                                                    <input type=""number""  min=""1""
                                                           class=""form-control"" style=""width: 60px!important;"" name=""quantity"" id=""quantity""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2350, "\"", 2376, 1);
#line 47 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2358, cartItem.Quantity, 2358, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2377, 358, true);
                WriteLiteral(@"/>
                                                </div>
                                                <div class=""col p-0 m-0"">
                                                    <input type=""submit""  class=""btn btn-dark btn-block"" value=""Update""/>
                                                </div>
                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
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
            BeginContext(2742, 121, true);
            WriteLiteral("\r\n                                            <div class=\"col p-0 m-0\">\r\n                                                ");
            EndContext();
            BeginContext(2863, 277, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6ac1391f16124a4662f0e846e2ac38f9858f74e11984", async() => {
                BeginContext(2939, 194, true);
                WriteLiteral("\r\n                                                    <button class=\"btn btn-danger btn-block\" style=\"width: 70px!important;\" > Delete </button>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
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
            BeginContext(3140, 306, true);
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
#line 65 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
            }
        
                    }   

#line default
#line hidden
            BeginContext(3497, 50, true);
            WriteLiteral("             </div>\r\n        <div class=\"col-4\">\r\n");
            EndContext();
#line 70 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
             if (Model.CartItems.Count != 0)
            {

#line default
#line hidden
            BeginContext(3608, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3624, 449, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6ac1391f16124a4662f0e846e2ac38f9858f74e15759", async() => {
                BeginContext(3631, 191, true);
                WriteLiteral("\r\n                    <h6> Order Summary </h6>\r\n                    <p class=\"text-muted mb-0\"> Total Ammount Due:  </p>\r\n                    <h5 class=\" mb-3\">          ₱<span class=\"price\">");
                EndContext();
                BeginContext(3823, 11, false);
#line 75 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                                                Write(Model.Total);

#line default
#line hidden
                EndContext();
                BeginContext(3834, 232, true);
                WriteLiteral(" </span></h5>\r\n                    <button class=\"btn btn-primary btn-lg\">\r\n                        <i class=\"fas fa-fw fa-cart-plus\"></i>\r\n                        Proceed To Checkout\r\n                    </button>\r\n                ");
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
            BeginContext(4073, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 81 "C:\Users\laure\Desktop\EdmanOnlineShop\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4090, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
