#pragma checksum "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\FeedbacksTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63513ce338ae17cace07fdc978e9b4de1b74513d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedbacks_FeedbacksTable), @"mvc.1.0.view", @"/Views/Feedbacks/FeedbacksTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Feedbacks/FeedbacksTable.cshtml", typeof(AspNetCore.Views_Feedbacks_FeedbacksTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63513ce338ae17cace07fdc978e9b4de1b74513d", @"/Views/Feedbacks/FeedbacksTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7c810fb923ab48b6fd0b186cb5101541f59b0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedbacks_FeedbacksTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EdmanOnlineShop.ViewModels.FeedbackTableViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\FeedbacksTable.cshtml"
  
    ViewBag.Title = "Feedbacks";
    Layout = "_DashboardLayout";

#line default
#line hidden
            BeginContext(133, 309, true);
            WriteLiteral(@"

<h2 class=""h2"">Feedbacks</h2>

<table id=""feedbacks_table"" class=""table table-bordered  table-hover table-sm"">
    <thead>
    <tr>
        <th scope=""col"">Date</th>
        <th scope=""col"">ID</th>
        <th> Message </th>
        <th> Customer Name </th>
    </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\FeedbacksTable.cshtml"
     foreach (var item in Model.Feedbacks)
    {

#line default
#line hidden
            BeginContext(493, 58, true);
            WriteLiteral("        <tr href=\"#\">\r\n            <td >\r\n                ");
            EndContext();
            BeginContext(552, 16, false);
#line 24 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\FeedbacksTable.cshtml"
           Write(item.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(568, 38, true);
            WriteLiteral("\r\n            </td>\r\n            <td >");
            EndContext();
            BeginContext(607, 15, false);
#line 26 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\FeedbacksTable.cshtml"
            Write(item.FeedbackID);

#line default
#line hidden
            EndContext();
            BeginContext(622, 27, true);
            WriteLiteral(" </td>\r\n            <td> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 649, "\"", 699, 2);
            WriteAttributeValue("", 656, "/Feedbacks/ViewFeedback?id=", 656, 27, true);
#line 27 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\FeedbacksTable.cshtml"
WriteAttributeValue("", 683, item.FeedbackID, 683, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(700, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(702, 20, false);
#line 27 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\FeedbacksTable.cshtml"
                                                                  Write(item.FeedbackMessage);

#line default
#line hidden
            EndContext();
            BeginContext(722, 29, true);
            WriteLiteral(" </a></td>\r\n            <td> ");
            EndContext();
            BeginContext(752, 19, false);
#line 28 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\FeedbacksTable.cshtml"
            Write(item.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(771, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(773, 18, false);
#line 28 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\FeedbacksTable.cshtml"
                                 Write(item.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(791, 23, true);
            WriteLiteral(" </td>\r\n        </tr>\r\n");
            EndContext();
#line 30 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\FeedbacksTable.cshtml"
    }

#line default
#line hidden
            BeginContext(821, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EdmanOnlineShop.ViewModels.FeedbackTableViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
