#pragma checksum "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Shared/Components/ServiceList/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd0d459d5be512ba97abeaaee207e3213a5ef1c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ServiceList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
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
#line 3 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/_ViewImports.cshtml"
using AspenTeachesCoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Shared/Components/ServiceList/Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd0d459d5be512ba97abeaaee207e3213a5ef1c1", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c697ad26d61dcf889c7cc69d803dd488c0965c01", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ServiceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""section px-3 px-lg-4 pt-5"" id=""services"">
    <div class=""container-narrow"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">What To Learn</h2>
        </div>
        <div class=""text-center"">
            <p class=""mx-auto mb-3"" style=""max-width:600px""> Aspen Teaches offers plenty of courses that may interest you.</p>
        </div>
        <div class=""row py-3"">
");
#nullable restore
#line 12 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Shared/Components/ServiceList/Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 text-center\" data-aos=\"fade-up\" data-aos-delay=\"100\">\n                    <img class=\"mb-2\"");
            BeginWriteAttribute("src", " src=\"", 646, "\"", 666, 1);
#nullable restore
#line 15 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Shared/Components/ServiceList/Default.cshtml"
WriteAttributeValue("", 652, item.ImageUrl, 652, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"96\" height=\"96\" alt=\"web design\" />\n                    <div class=\"h5\">");
#nullable restore
#line 16 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Shared/Components/ServiceList/Default.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                </div>\n");
#nullable restore
#line 18 "/Users/ilaydasozyilmaz/Projects/AspenTeachesCoreProject/AspenTeachesCoreProject/Views/Shared/Components/ServiceList/Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591