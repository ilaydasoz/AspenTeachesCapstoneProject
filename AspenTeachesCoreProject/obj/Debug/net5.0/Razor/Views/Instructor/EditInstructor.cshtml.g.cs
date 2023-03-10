#pragma checksum "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Instructor/EditInstructor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6fa2a672d415b6955f3b5c4b797fcf02ff94198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_EditInstructor), @"mvc.1.0.view", @"/Views/Instructor/EditInstructor.cshtml")]
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
#line 1 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/_ViewImports.cshtml"
using AspenTeachesCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/_ViewImports.cshtml"
using AspenTeachesCoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/_ViewImports.cshtml"
using DTOLayer.DTOs.InstructorDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6fa2a672d415b6955f3b5c4b797fcf02ff94198", @"/Views/Instructor/EditInstructor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"198572a375cf9f75ef15a7beeb05b3d94c148e36", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructor_EditInstructor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Instructor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Instructor/EditInstructor.cshtml"
  
    ViewData["Title"] = "EditInstructor";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card-header border-0\">\n    <h3 class=\"mb-0\">Edit Instructor</h3>\n</div>\n\n");
#nullable restore
#line 11 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Instructor/EditInstructor.cshtml"
 using (Html.BeginForm("EditInstructor", "Instructor", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\n        <div class=\"card\">\n            <div class=\"card-body\">\n                <h4 class=\"card-title\">Edit Instructor</h4>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6fa2a672d415b6955f3b5c4b797fcf02ff941985011", async() => {
                WriteLiteral("\n                    <div class=\"form-group\">\n                        <label>ID</label>\n                        ");
#nullable restore
#line 20 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Instructor/EditInstructor.cshtml"
                   Write(Html.TextBoxFor(x => x.InstructorID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Name</label>\n                        ");
#nullable restore
#line 24 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Instructor/EditInstructor.cshtml"
                   Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Surname</label>\n                        ");
#nullable restore
#line 28 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Instructor/EditInstructor.cshtml"
                   Write(Html.TextBoxFor(x => x.Surname, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Title</label>\n                        ");
#nullable restore
#line 32 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Instructor/EditInstructor.cshtml"
                   Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>GitHub</label>\n                        ");
#nullable restore
#line 36 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Instructor/EditInstructor.cshtml"
                   Write(Html.TextBoxFor(x => x.GitHubUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Linkedln</label>\n                        ");
#nullable restore
#line 40 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Instructor/EditInstructor.cshtml"
                   Write(Html.TextBoxFor(x => x.LinkedinUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Description</label>\n                        ");
#nullable restore
#line 44 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Instructor/EditInstructor.cshtml"
                   Write(Html.TextAreaFor(x => x.Description, 6, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <button type=\"submit\" class=\"btn btn-primary mr-2\">Save</button>\n                    <button class=\"btn btn-dark\">Cancel</button>\n                ");
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
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 52 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Instructor/EditInstructor.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Instructor> Html { get; private set; }
    }
}
#pragma warning restore 1591
