#pragma checksum "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06bd59c878bddd180e6eec7e275ff23da7bb2429"
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
#line 1 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\_ViewImports.cshtml"
using EdmanOnlineShop;

#line default
#line hidden
#line 2 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\_ViewImports.cshtml"
using EdmanOnlineShop.Models;

#line default
#line hidden
#line 1 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06bd59c878bddd180e6eec7e275ff23da7bb2429", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7c810fb923ab48b6fd0b186cb5101541f59b0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EdmanOnlineShop.ViewModels.CartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Request", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RequestConfirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline justify-content-end"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateQuantity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline  justify-content-end"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
  
    ViewBag.Title = "Category";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(152, 229, true);
            WriteLiteral("\r\n\r\n<div class=\"wrapper container-fluid\" style=\"width: 90%!important;margin: auto;\">\r\n    <div class=\"row mt-3\">\r\n        <div class=\"col-8\">\r\n            <h2 class=\"h2 pt-0\"> My Cart </h2>\r\n            <div class=\"mt-4\"></div>\r\n");
            EndContext();
#line 14 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
             if (Model.CartItems.Count == 0)
            {

#line default
#line hidden
            BeginContext(442, 92, true);
            WriteLiteral("                <h4 class=\"display-4\" style=\"font-size: 32px;\"> No items to display. </h4>\r\n");
            EndContext();
#line 17 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
            }
            else
            {
                foreach (var cartItem in Model.CartItems)
                {

#line default
#line hidden
            BeginContext(660, 216, true);
            WriteLiteral("                    <div class=\"card mb-2\">\r\n                        <div class=\"card-body p-3\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-2 p-0 pr-2 pl-4 m-0\">\r\n");
            EndContext();
#line 26 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                      
                                        var base64 = Convert.ToBase64String(@cartItem.ProductImage);
                                        var imgSrc = String.Format("data:image/gif;base64,{0}", base64);
                                    

#line default
#line hidden
            BeginContext(1163, 40, true);
            WriteLiteral("                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1203, "\"", 1216, 1);
#line 30 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1209, imgSrc, 1209, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1217, 197, true);
            WriteLiteral(" class=\"img-fluid\" alt=\"\"/>\r\n                                </div>\r\n                                <div class=\"col-10 pl-4 m-0\">\r\n                                    <h4 class=\"product-name-h4\"> ");
            EndContext();
            BeginContext(1415, 50, false);
#line 33 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => cartItem.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1465, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 34 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                     if (cartItem.Inventory.Quantity < cartItem.Quantity)
                                    {

#line default
#line hidden
            BeginContext(1602, 261, true);
            WriteLiteral(@"                                        <p class=""text-danger text-small""> <i class=""fas fa-info-circle""></i> This product will not be proccessed when you checkout as it exceeds the current available stocks for this item which is <span class=""font-weight-bold"">");
            EndContext();
            BeginContext(1864, 27, false);
#line 36 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                                                                                                                                                                                                                                                Write(cartItem.Inventory.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1891, 217, true);
            WriteLiteral("</span>. \r\n                                        </p>\r\n                                        <p class=\"text-black-100 text-small\">\r\n                                            If you want to request for this item ");
            EndContext();
            BeginContext(2108, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06bd59c878bddd180e6eec7e275ff23da7bb242911299", async() => {
                BeginContext(2245, 11, true);
                WriteLiteral(" Click here");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cartItemID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                                                                                                                                   WriteLiteral(cartItem.CartItemID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartItemID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cartItemID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartItemID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2260, 48, true);
            WriteLiteral("\r\n                                        </p>\r\n");
            EndContext();
#line 41 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2347, 370, true);
            WriteLiteral(@"                                    <div class=""row mr-4"">
                                        <div class=""col-4"">
                                            <p class=""product-price-cart"">
                                                ₱
                                                <span class=""price"">
                                                    ");
            EndContext();
            BeginContext(2718, 44, false);
#line 47 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => cartItem.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2762, 170, true);
            WriteLiteral("</span>\r\n                                            </p>\r\n                                        </div>\r\n                                        <div class=\"col-8\">\r\n\r\n");
            EndContext();
            BeginContext(3254, 197, true);
            WriteLiteral("                                            <div class=\"form-row\">\r\n                                                <div class=\"col-9 m-0 p-0\">\r\n                                                    ");
            EndContext();
            BeginContext(3451, 814, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06bd59c878bddd180e6eec7e275ff23da7bb242915789", async() => {
                BeginContext(3569, 420, true);
                WriteLiteral(@"
                                                        <div class=""form-group"">
                                                            <label for=""""> Quantity</label>
                                                            <input type=""number"" min=""1""
                                                                   class=""form-control ml-2"" style=""width: 60px!important;"" name=""quantity"" id=""quantity""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3989, "\"", 4015, 1);
#line 63 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3997, cartItem.Quantity, 3997, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4016, 242, true);
                WriteLiteral("/>\r\n\r\n                                                            <input type=\"submit\" class=\"btn btn-dark\" value=\"Update\"/>\r\n                                                        </div>\r\n                                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cartItemId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                                                                                                                        WriteLiteral(cartItem.CartItemID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["cartItemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cartItemId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["cartItemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4265, 187, true);
            WriteLiteral("\r\n                                                </div>\r\n                                                <div class=\"col-3 m-0 p-0\">\r\n                                                    ");
            EndContext();
            BeginContext(4452, 349, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06bd59c878bddd180e6eec7e275ff23da7bb242920009", async() => {
                BeginContext(4569, 225, true);
                WriteLiteral("\r\n                                                        <button class=\"btn btn-danger\">                                <i class=\"fas fa-fw fa-trash\"></i>Delete </button>\r\n                                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
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
            BeginContext(4801, 340, true);
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
#line 82 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(5175, 45, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-4\">\r\n");
            EndContext();
#line 86 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
             if (Model.CartItems.Count != 0 && Model.Total != 0)
            {

#line default
#line hidden
            BeginContext(5301, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(5317, 528, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06bd59c878bddd180e6eec7e275ff23da7bb242924161", async() => {
                BeginContext(5336, 48, true);
                WriteLiteral("\r\n                    <h6> Order Summary </h6>\r\n");
                EndContext();
                BeginContext(5447, 133, true);
                WriteLiteral("                    <p class=\"text-muted mb-0\"> Total Ammount Due: </p>\r\n                    <h5 class=\" mb-3\"> ₱<span class=\"price\">");
                EndContext();
                BeginContext(5581, 11, false);
#line 92 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
                                                       Write(Model.Total);

#line default
#line hidden
                EndContext();
                BeginContext(5592, 246, true);
                WriteLiteral(" </span></h5>\r\n                    <a class=\"btn btn-primary btn-lg\" href=\"/Orders/Checkout\">\r\n                        <i class=\"fas fa-fw fa-cart-plus\"></i>\r\n                        Proceed To Checkout\r\n                    </a>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5845, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 98 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5862, 34, true);
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
