#pragma checksum "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "346a5c2f07c54ac15cef763f2e3dd29c556a49f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedbacks_Success), @"mvc.1.0.view", @"/Views/Feedbacks/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Feedbacks/Success.cshtml", typeof(AspNetCore.Views_Feedbacks_Success))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"346a5c2f07c54ac15cef763f2e3dd29c556a49f0", @"/Views/Feedbacks/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7c810fb923ab48b6fd0b186cb5101541f59b0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedbacks_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EdmanOnlineShop.ViewModels.FeedBackViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Success.cshtml"
  
    ViewBag.Title = "Feedback Sent";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(123, 1006, true);
            WriteLiteral(@"
<div class=""container-fluid"" style=""width: 90%!important; margin: auto"">
    <div class=""row mt-5 pt-4"">
        <div class=""col text-center auto"">
            <div class=""success-checkmark"">
                <div class=""check-icon"">
                    <span class=""icon-line line-tip""></span>
                    <span class=""icon-line line-long""></span>
                    <div class=""icon-circle""></div>
                    <div class=""icon-fix""></div>
                </div>
            </div>
            <h5 class=""text-center text-success""> Feedback sent! </h5>
            <p class=""text-muted""> Redirecting you back in <span id=""count""> </span> second/s. </p>
        </div>
    </div>
</div>

<script >
    var count = 5;
    $(""#count"").html(count);
    var x = setInterval(function()
    {
        count--;
        $(""#count"").html(count);
    }, 1000);
    setTimeout(function(){
        clearInterval(x);
        window.location = ""./"";
    }, 5000);
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EdmanOnlineShop.ViewModels.FeedBackViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
