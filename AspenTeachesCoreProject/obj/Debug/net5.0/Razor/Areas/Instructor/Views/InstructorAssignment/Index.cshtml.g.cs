#pragma checksum "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Areas/Instructor/Views/InstructorAssignment/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "480e3845fbc090677dbfd1ce7de306dae2d2c042"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Instructor_Views_InstructorAssignment_Index), @"mvc.1.0.view", @"/Areas/Instructor/Views/InstructorAssignment/Index.cshtml")]
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
#line 1 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Areas/Instructor/Views/InstructorAssignment/Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"480e3845fbc090677dbfd1ce7de306dae2d2c042", @"/Areas/Instructor/Views/InstructorAssignment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Areas/Instructor/Views/_ViewImports.cshtml")]
    public class Areas_Instructor_Views_InstructorAssignment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Assignment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Areas/Instructor/Views/InstructorAssignment/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_InstructorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Give Assignment</h4>
            <p class=""card-description"">
                You can give assignments to your students via their Student ID.
            </p>

");
            WriteLiteral(@"
            <div class=""form-group"">

                <input type=""text"" class=""form-control"" id=""inpname"" placeholder=""Student ID"" />
                <br />
                <input type=""text"" class=""form-control"" id=""inpname"" placeholder=""Title"" />
                <br />
                <input type=""text"" class=""form-control"" id=""inpname"" placeholder=""Description"" />
                <br />
                <input type=""text"" class=""form-control"" id=""inpdate"" placeholder=""Deadline"" />
                <br />
                <button type=""button"" id=""btnadd"" class=""btn btn-success"">Submit</button>
            </div>
            <br />
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>$(""#btngetlistall"").click(function () {
                                $.ajax({
                                    contentType: ""application/json"",
                                    dataType: ""json"",
                                    type: ""Get"",
                                    url: ""/Assignment/ListAssignment/"",

                                    success: function (funk) {
                                        let values = jQuery.parseJSON(funk);
                                        console.log(values);

                                        let htmlst = ""<table class=table table-bordered> <tr> <th> ID </th> <th> Title </th> <th> Deadline </th> </tr>"";
                                        $.each(values, (index, value) => {
                                            htmlst += `<tr> <td>${value.AssignmentID}</td> <td>${value.Name}</td> <td>${value.Deadline}</td> </tr>`
                                        });
                                        htmlst += ""</table>"";
 ");
                WriteLiteral(@"                                       $(""#listassignment"").html(htmlst);
                                    }
                                });
                            });

                            $(""#btnadd"").click(function () {
                                let values = {
                                    Name: $(""#inpname"").val(),
                                    Date: $(""#inpdate"").val()
                                };

                                $.ajax({
                                    type: ""Post"",
                                    url: ""/InstructorAssignment/InstructorAddAssignment/"",
                                    data: values,
                                    success: function (funk1) {
                                        let result = jQuery.parseJSON(funk1);
                                        alert(""Successfully added!"");
                                    }
                                });
                            });

                       ");
                WriteLiteral(@"     $(""#btnid"").click(x => {
                                let id = $(""#inpid"").val();

                                $.ajax({
                                    contentType: ""application/json"",
                                    dataType: ""json"",
                                    type: ""Get"",
                                    url: ""/Assignment/GetById/"",
                                    data: { ExperienceID: id },
                                    success: function (funk2) {
                                        let result = jQuery.parseJSON(funk2);
                                        console.log(result);
                                        let htmlstr = `<table class=table table-hover> <tr> <th>Deneyim ID</th> <td>${result.AssignmentID}</td></tr> <tr> <th> Deneyim Başlığı </th> <td> ${result.Name}</td> </tr> </table>`;
                                        $(""#listbyidassignment"").html(htmlstr);
                                    }
                                });

          ");
                WriteLiteral(@"                  });

                            $(""#btndelete"").click(x => {
                                let id = $(""#inpexpid"").val();
                                $.ajax({
                                    url: ""/Assignment/DeleteAssignment/"" + id,
                                    type: ""post"",
                                    contentType: ""application/json"",
                                    dataType: ""json"",
                                    success: function (funk3) {
                                        loadData();
                                    }
                                });
                            });

                            $(""#btnupdate"").click(function () {
                                let values = {
                                    ExperienceID: $(""#inpeditexpid"").val(),
                                    Name: $(""#inpeditexpname"").val()
                                };

                                $.ajax({
                                ");
                WriteLiteral(@"    type: ""post"",
                                    url: ""/InstructorAssignment/InstructorUpdateAssignment/"",
                                    data: values,
                                    success: function (func4) {
                                        alert(""Successfully updated!"");
                                    }
                                });
                            });</script>
");
            }
            );
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "480e3845fbc090677dbfd1ce7de306dae2d2c0429681", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Assignment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
