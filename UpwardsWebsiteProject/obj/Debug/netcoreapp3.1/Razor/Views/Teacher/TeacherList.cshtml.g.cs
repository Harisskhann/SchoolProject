#pragma checksum "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c951f8ba5b7a385c3886bae038413a1737aa268"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_TeacherList), @"mvc.1.0.view", @"/Views/Teacher/TeacherList.cshtml")]
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
#nullable restore
#line 1 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\_ViewImports.cshtml"
using UpwardsWebsiteProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\_ViewImports.cshtml"
using UpwardsWebsiteProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c951f8ba5b7a385c3886bae038413a1737aa268", @"/Views/Teacher/TeacherList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3021f85c220ab7fc633c717709442f53433c57e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Teacher_TeacherList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UpwardsWebsiteProject.Models.TeacherEntity>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTeacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
  
    ViewData["Title"] = "TeacherList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>TeacherList</h1>\r\n<hr />\r\n\r\n<p class=\"float-left\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c951f8ba5b7a385c3886bae038413a1737aa2684530", async() => {
                WriteLiteral("Add Teacher");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<p class=\"float-right\">\r\n");
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n           \r\n            <th>\r\n                ");
#nullable restore
#line 24 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 35 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 39 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
           Write(Html.DisplayNameFor(model => model.Qualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 43 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
           Write(Html.DisplayNameFor(model => model.Subjects));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 47 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 51 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 55 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
           Write(Html.DisplayNameFor(model => model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 59 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
           Write(Html.DisplayNameFor(model => model.SchoolId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 63 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
           Write(Html.DisplayNameFor(model => model.BranchId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n\r\n\r\n\r\n\r\n            <th>Actions</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 76 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n               \r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 90 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 95 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 100 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Qualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 105 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Subjects));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 110 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 115 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 120 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 125 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
               Write(Html.DisplayFor(modelItem => item.SchoolId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 132 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
               Write(Html.DisplayFor(modelItem => item.BranchId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n               \r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 140 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
               Write(Html.ActionLink("Update", "AddTeacher", new {  item.TeacherId, item.Name, item.PhoneNumber, item.Gender, item.Email, item.Qualification ,item.Subjects,item.Age,item.Address,item.Experience,item.SchoolId,item.BranchId } , new { @class="btn btn-outline-success rounded-pill"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 141 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
               Write(Html.ActionLink("Delete", "DeleteTeacher", new {  item.TeacherId  }, new { @class = "btn btn-outline-danger rounded-pill",onclick="return confirm('Do you really want this record?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 145 "D:\UpwardsProject\UpwardsProject\UpwardsWebsiteProject\Views\Teacher\TeacherList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UpwardsWebsiteProject.Models.TeacherEntity>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591