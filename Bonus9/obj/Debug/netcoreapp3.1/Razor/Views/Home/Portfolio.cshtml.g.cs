#pragma checksum "C:\Users\theP4\source\repos\Bonus9\Bonus9\Views\Home\Portfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af20cc751d486805eb8fcf0b136fa6c253fefba9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Portfolio), @"mvc.1.0.view", @"/Views/Home/Portfolio.cshtml")]
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
#line 1 "C:\Users\theP4\source\repos\Bonus9\Bonus9\Views\_ViewImports.cshtml"
using Bonus9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\theP4\source\repos\Bonus9\Bonus9\Views\_ViewImports.cshtml"
using Bonus9.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af20cc751d486805eb8fcf0b136fa6c253fefba9", @"/Views/Home/Portfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c7c4315672f302620ed522ff318c1f7cb3f13d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Portfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\theP4\source\repos\Bonus9\Bonus9\Views\Home\Portfolio.cshtml"
  
    ViewData["Title"] = "Portfolio";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-1""><strong>Portfolio</strong></h1>
</div>
<div class=""section-two"">
    <h3>Projects</h3>
    <p>
        <a href=""http://github.com/irichmond223/MidtermPOS.git"">Point of Sale Console Application</a>
    </p>
</div>


");
            WriteLiteral("\r\n");
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
