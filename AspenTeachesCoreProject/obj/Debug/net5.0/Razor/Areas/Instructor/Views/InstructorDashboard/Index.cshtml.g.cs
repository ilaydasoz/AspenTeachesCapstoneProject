#pragma checksum "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Areas/Instructor/Views/InstructorDashboard/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5518edad9c5760f7749dbc560fc1fdbb4fbf6499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Instructor_Views_InstructorDashboard_Index), @"mvc.1.0.view", @"/Areas/Instructor/Views/InstructorDashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5518edad9c5760f7749dbc560fc1fdbb4fbf6499", @"/Areas/Instructor/Views/InstructorDashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Areas/Instructor/Views/_ViewImports.cshtml")]
    public class Areas_Instructor_Views_InstructorDashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/skydash/images/dashboard/people.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("people"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Areas/Instructor/Views/InstructorDashboard/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_InstructorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12 grid-margin\">\n        <div class=\"row\">\n            <div class=\"col-12 col-xl-8 mb-4 mb-xl-0\">\n\n                <h3 class=\"font-weight-bold\">Welcome, Instructor ");
#nullable restore
#line 11 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Areas/Instructor/Views/InstructorDashboard/Index.cshtml"
                                                            Write(ViewBag.v);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"!</h3>
                <h6 class=""font-weight-normal mb-0"">It's always good to see you.</h6>
            </div>
            <div class=""col-12 col-xl-4"">
                <div class=""justify-content-end d-flex"">
                    <div class=""dropdown flex-md-grow-1 flex-xl-grow-0"">
                        <button class=""btn btn-sm btn-light bg-white dropdown-toggle"" type=""button"" id=""dropdownMenuDate2"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true"">
                            <i class=""mdi mdi-calendar""></i> ");
#nullable restore
#line 18 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Areas/Instructor/Views/InstructorDashboard/Index.cshtml"
                                                        Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-6 grid-margin stretch-card"">
        <div class=""card tale-bg"">
            <div class=""card-people mt-auto"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5518edad9c5760f7749dbc560fc1fdbb4fbf64995646", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <div class=\"weather-info\">\n                    <div class=\"d-flex\">\n                        <div>\n                            <h2 class=\"mb-0 font-weight-normal\"><i class=\"icon-sun mr-2\"></i>");
#nullable restore
#line 34 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Areas/Instructor/Views/InstructorDashboard/Index.cshtml"
                                                                                        Write(ViewBag.v5);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<sup>C</sup></h2>
                        </div>
                        <div class=""ml-2"">
                            <h4 class=""location font-weight-normal"">İstanbul</h4>
                            <h6 class=""font-weight-normal"">Turkey</h6>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-6 grid-margin transparent"">
        <div class=""row"">
            <div class=""col-md-6 mb-4 stretch-card transparent"">
                <div class=""card card-tale"">
                    <div class=""card-body"">
                        <p class=""mb-4"">Messages Receieved</p>
                        <p class=""fs-30 mb-2"">43</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 mb-4 stretch-card transparent"">
                <div class=""card card-dark-blue"">
                    <div class=""card-body"">
                        <p class=""mb-4"">Students Online</p>
                  ");
            WriteLiteral(@"      <p class=""fs-30 mb-2"">38</p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 mb-4 mb-lg-0 stretch-card transparent"">
                <div class=""card card-light-blue"">
                    <div class=""card-body"">
                        <p class=""mb-4"">Your Avaliable Courses</p>
                        <p class=""fs-30 mb-2"">3</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 stretch-card transparent"">
                <div class=""card card-light-danger"">
                    <div class=""card-body"">
                        <p class=""mb-4"">Messages Sent</p>
                        <p class=""fs-30 mb-2"">11</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">
        <div class=""card position-relative"">
            <div class=""card-body"">
 ");
            WriteLiteral(@"               <div id=""detailedReports"" class=""carousel slide detailed-report-carousel position-static pt-2"" data-ride=""carousel"">
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active"">
                            <div class=""row"">
                                <div class=""col-md-12 col-xl-3 d-flex flex-column justify-content-start"">
                                    <div class=""ml-xl-4 mt-3"">
                                        <p class=""card-title"">Statistics for You</p>
                                        <h1 class=""text-primary"">123</h1>
                                        <h3 class=""font-weight-500 mb-xl-4 text-primary"">Advanced Java</h3>
                                        <p class=""mb-2 mb-xl-0"">The total number of students.</p>
                                    </div>
                                </div>
                                <div class=""col-md-12 col-xl-9"">
                                    <div class=""row"">
   ");
            WriteLiteral(@"                                     <div class=""col-md-6 border-right"">
                                            <div class=""table-responsive mb-3 mb-md-0 mt-3"">
                                                <table class=""table table-borderless report-table"">
                                                    <tr>
                                                        <td class=""text-muted"">Hours Spent</td>
                                                        <td class=""w-100 px-0"">
                                                            <div class=""progress progress-md mx-4"">
                                                                <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 70%"" aria-valuenow=""70"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                            </div>
                                                        </td>
                                                        <td><h5 class=""font-weight-bold mb-0""");
            WriteLiteral(@">713</h5></td>
                                                    </tr>
                                                    <tr>
                                                        <td class=""text-muted"">Total Interaction</td>
                                                        <td class=""w-100 px-0"">
                                                            <div class=""progress progress-md mx-4"">
                                                                <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 30%"" aria-valuenow=""30"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                            </div>
                                                        </td>
                                                        <td><h5 class=""font-weight-bold mb-0"">1583</h5></td>
                                                    </tr>
                                                    <tr>
                                                        ");
            WriteLiteral(@"<td class=""text-muted"">Assignments</td>
                                                        <td class=""w-100 px-0"">
                                                            <div class=""progress progress-md mx-4"">
                                                                <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 95%"" aria-valuenow=""95"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                            </div>
                                                        </td>
                                                        <td><h5 class=""font-weight-bold mb-0"">102</h5></td>
                                                    </tr>
                                                    <tr>
                                                        <td class=""text-muted"">Enrollments</td>
                                                        <td class=""w-100 px-0"">
                                                            <div class=""pr");
            WriteLiteral(@"ogress progress-md mx-4"">
                                                                <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 60%"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                            </div>
                                                        </td>
                                                        <td><h5 class=""font-weight-bold mb-0"">129</h5></td>
                                                    </tr>
                                                    <tr>
                                                        <td class=""text-muted"">Un-Enrollments</td>
                                                        <td class=""w-100 px-0"">
                                                            <div class=""progress progress-md mx-4"">
                                                                <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 40%"" aria-valuenow=""40"" aria-valu");
            WriteLiteral(@"emin=""0"" aria-valuemax=""100""></div>
                                                            </div>
                                                        </td>
                                                        <td><h5 class=""font-weight-bold mb-0"">32</h5></td>
                                                    </tr>
                                                    <tr>
                                                        <td class=""text-muted"">Completion Rate</td>
                                                        <td class=""w-100 px-0"">
                                                            <div class=""progress progress-md mx-4"">
                                                                <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                            </div>
                                                        </td>
                          ");
            WriteLiteral(@"                              <td><h5 class=""font-weight-bold mb-0"">33</h5></td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </div>
                                        <div class=""col-md-6 mt-3"">
                                            <canvas id=""north-america-chart""></canvas>
                                            <div id=""north-america-legend""></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""carousel-item"">
                            <div class=""row"">
                                <div class=""col-md-12 grid-margin stretch-card"">
                                    <div class=""card position-relative"">
                                        <div c");
            WriteLiteral(@"lass=""card-body"">
                                            <div id=""detailedReports"" class=""carousel slide detailed-report-carousel position-static pt-2"" data-ride=""carousel"">
                                                <div class=""carousel-inner"">
                                                    <div class=""carousel-item active"">
                                                        <div class=""row"">
                                                            <div class=""col-md-12 col-xl-3 d-flex flex-column justify-content-start"">
                                                                <div class=""ml-xl-4 mt-3"">
                                                                    <p class=""card-title"">Statistics for You</p>
                                                                    <h1 class=""text-primary"">123</h1>
                                                                    <h3 class=""font-weight-500 mb-xl-4 text-primary"">Advanced Java</h3>
                               ");
            WriteLiteral(@"                                     <p class=""mb-2 mb-xl-0"">The total number of students.</p>
                                                                </div>
                                                            </div>
                                                            <div class=""col-md-12 col-xl-9"">
                                                                <div class=""row"">
                                                                    <div class=""col-md-6 border-right"">
                                                                        <div class=""table-responsive mb-3 mb-md-0 mt-3"">
                                                                            <table class=""table table-borderless report-table"">
                                                                                <tr>
                                                                                    <td class=""text-muted"">Hours Spent</td>
                                                      ");
            WriteLiteral(@"                              <td class=""w-100 px-0"">
                                                                                        <div class=""progress progress-md mx-4"">
                                                                                            <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 70%"" aria-valuenow=""70"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                                                        </div>
                                                                                    </td>
                                                                                    <td><h5 class=""font-weight-bold mb-0"">713</h5></td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class=""text-muted"">Total Intera");
            WriteLiteral(@"ction</td>
                                                                                    <td class=""w-100 px-0"">
                                                                                        <div class=""progress progress-md mx-4"">
                                                                                            <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 30%"" aria-valuenow=""30"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                                                        </div>
                                                                                    </td>
                                                                                    <td><h5 class=""font-weight-bold mb-0"">1583</h5></td>
                                                                                </tr>
                                                                                <tr>
                                                     ");
            WriteLiteral(@"                               <td class=""text-muted"">Assignments</td>
                                                                                    <td class=""w-100 px-0"">
                                                                                        <div class=""progress progress-md mx-4"">
                                                                                            <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 95%"" aria-valuenow=""95"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                                                        </div>
                                                                                    </td>
                                                                                    <td><h5 class=""font-weight-bold mb-0"">102</h5></td>
                                                                                </tr>
                                                                                ");
            WriteLiteral(@"<tr>
                                                                                    <td class=""text-muted"">Enrollments</td>
                                                                                    <td class=""w-100 px-0"">
                                                                                        <div class=""progress progress-md mx-4"">
                                                                                            <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 60%"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                                                        </div>
                                                                                    </td>
                                                                                    <td><h5 class=""font-weight-bold mb-0"">129</h5></td>
                                                                                </tr>
                        ");
            WriteLiteral(@"                                                        <tr>
                                                                                    <td class=""text-muted"">Un-Enrollments</td>
                                                                                    <td class=""w-100 px-0"">
                                                                                        <div class=""progress progress-md mx-4"">
                                                                                            <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 40%"" aria-valuenow=""40"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                                                        </div>
                                                                                    </td>
                                                                                    <td><h5 class=""font-weight-bold mb-0"">32</h5></td>
                                                 ");
            WriteLiteral(@"                               </tr>
                                                                                <tr>
                                                                                    <td class=""text-muted"">Completion Rate</td>
                                                                                    <td class=""w-100 px-0"">
                                                                                        <div class=""progress progress-md mx-4"">
                                                                                            <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                                                        </div>
                                                                                    </td>
                                                                                    <td><h5 class=""font-weight-bold mb-0"">3");
            WriteLiteral(@"3</h5></td>
                                                                                </tr>
                                                                            </table>
                                                                        </div>
                                                                    </div>
                                                                    <div class=""col-md-6 mt-3"">
                                                                        <canvas id=""north-america-chart""></canvas>
                                                                        <div id=""north-america-legend""></div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                               ");
            WriteLiteral(@"                     <div class=""carousel-item"">

                                                    </div>
                                                </div>
                                                <a class=""carousel-control-prev"" href=""#detailedReports"" role=""button"" data-slide=""prev"">
                                                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                                    <span class=""sr-only"">Previous</span>
                                                </a>
                                                <a class=""carousel-control-next"" href=""#detailedReports"" role=""button"" data-slide=""next"">
                                                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                                                    <span class=""sr-only"">Next</span>
                                                </a>
                                            </div>
           ");
            WriteLiteral(@"                             </div>
                                    </div>
                                </div>
                            </div>  
                        </div>
                    </div>
                    <a class=""carousel-control-prev"" href=""#detailedReports"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#detailedReports"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>
        </div>
    </div>
</div>
 
<div class=""row"">
    <div class=""col-md-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <p class=""c");
            WriteLiteral(@"ard-title"">Today's Quote</p>
                <p class=""font-weight-500"">“The dream begins, most of the time, with a teacher who believes in you, who tugs and pushes and leads you on to the next plateau, sometimes poking you with a sharp stick called truth.” — Dan Rather</p>
            </div>
        </div>
    </div>
    <div class=""col-md-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex justify-content-between"">
                    <p class=""card-title"">Check out our latest Linkeldn post...</p>
                </div>
                <p class=""font-weight-500""><span class=""text-primary""><a href=""https://tr.linkedin.com/"">Aspen: How did I start my own tech career</a></span></p>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
