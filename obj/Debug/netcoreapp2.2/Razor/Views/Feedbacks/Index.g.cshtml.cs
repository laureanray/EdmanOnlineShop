#pragma checksum "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4dc8e562837042ee61cd49b9a4e3f65b6126961"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedbacks_Index), @"mvc.1.0.view", @"/Views/Feedbacks/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Feedbacks/Index.cshtml", typeof(AspNetCore.Views_Feedbacks_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4dc8e562837042ee61cd49b9a4e3f65b6126961", @"/Views/Feedbacks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7c810fb923ab48b6fd0b186cb5101541f59b0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedbacks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EdmanOnlineShop.ViewModels.FeedBackViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendFeedback", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Index.cshtml"
  
    ViewBag.Title = "Feedbacks";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(119, 1181, true);
            WriteLiteral(@"
<div class=""container-fluid"" style=""width: 90%!important; margin: auto"">
  <h2 class=""h2"">Feedback </h2>

  <div class=""row mt-2"">
    <div class=""col-3"">
      <div class=""list-group"" id=""list-tab"" role=""tablist"">
        <a class=""list-group-item list-group-item-action active"" id=""list-compose-list"" data-toggle=""list"" href=""#list-compose"" role=""tab"" aria-controls=""compose"">Compose</a>
        <a class=""list-group-item list-group-item-action"" id=""list-messages-list"" data-toggle=""list"" href=""#list-messages"" role=""tab"" aria-controls=""messages"">Messages</a>
        <a class=""list-group-item list-group-item-action"" id=""list-archive-list"" data-toggle=""list"" href=""#list-archive"" role=""tab"" aria-controls=""archive"">Archive</a>
      </div>
    </div>
    <div class=""col-9"">
      <div class=""tab-content"" id=""nav-tabContent"">
        <div class=""tab-pane fade show active"" id=""list-compose"" role=""tabpanel"" aria-labelledby=""list-compose-list"">
          <h2 class=""h2"" style=""padding-top: 0!important;""> ");
            WriteLiteral("Compose </h2>\r\n          <div class=\"card mt-2\">\r\n            <div class=\"card-body\">\r\n              <h6 class=\"mb-2\"> Write a feedback </h6>\r\n              ");
            EndContext();
            BeginContext(1300, 426, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4dc8e562837042ee61cd49b9a4e3f65b61269617094", async() => {
                BeginContext(1348, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1366, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c4dc8e562837042ee61cd49b9a4e3f65b61269617494", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 26 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 26 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Index.cshtml"
                                                 WriteLiteral(Model.UserID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1426, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1444, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4dc8e562837042ee61cd49b9a4e3f65b612696110088", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 27 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FeedbackMessage);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1512, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1530, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4dc8e562837042ee61cd49b9a4e3f65b612696111879", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 28 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FeedbackMessage);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1600, 119, true);
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Send Feedback\" class=\"btn btn-primary form-control mt-3\">\r\n              ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1726, 508, true);
            WriteLiteral(@"
            </div>
          </div>
        </div>
        <div class=""tab-pane fade"" id=""list-messages"" role=""tabpanel"" aria-labelledby=""list-messages-list"">
          <h2 class=""h2 pt-0""> Messages </h2>
        <table  class=""table table-bordered table-hover table-sm mt-2"">
            <thead>
            <tr>
                <th scope=""col"">Date</th>
                <th scope=""col"">From</th>
                <th> Message </th>
            </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 45 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Index.cshtml"
             foreach (var item in Model.Messages)
            {

#line default
#line hidden
            BeginContext(2300, 82, true);
            WriteLiteral("                <tr href=\"#\">\r\n                    <td >\r\n                        ");
            EndContext();
            BeginContext(2383, 16, false);
#line 49 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Index.cshtml"
                   Write(item.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(2399, 54, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td >");
            EndContext();
            BeginContext(2454, 23, false);
#line 51 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Index.cshtml"
                    Write(item.FromUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2477, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2479, 22, false);
#line 51 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Index.cshtml"
                                             Write(item.FromUser.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2501, 35, true);
            WriteLiteral(" </td>\r\n                    <td> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2536, "\"", 2591, 2);
            WriteAttributeValue("", 2543, "/Feedbacks/ViewMessage?messageId=", 2543, 33, true);
#line 52 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Index.cshtml"
WriteAttributeValue("", 2576, item.MessageID, 2576, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2592, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2594, 19, false);
#line 52 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Index.cshtml"
                                                                               Write(item.MessageContent);

#line default
#line hidden
            EndContext();
            BeginContext(2613, 36, true);
            WriteLiteral("</a>  </td>\r\n                </tr>\r\n");
            EndContext();
#line 54 "C:\Users\laure\OneDrive - Polytechnic University of the Philippines\Desktop\Projects\EdmanOnlineShop\Views\Feedbacks\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2664, 262, true);
            WriteLiteral(@"            </tbody>
        </table>
        </div>
        <div class=""tab-pane fade"" id=""list-Archive"" role=""tabpanel"" aria-labelledby=""list-Archive-list"">
          <h2 class=""h2""> Archive </h2>
        </div>
      </div>
    </div>
  </div>
</div>");
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
