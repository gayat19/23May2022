#pragma checksum "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Sample\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded757301c53e24c85b3df4b70fa2d3a299e9e7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sample_Index), @"mvc.1.0.view", @"/Views/Sample/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded757301c53e24c85b3df4b70fa2d3a299e9e7e", @"/Views/Sample/Index.cshtml")]
    public class Views_Sample_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>\r\n    Index of Sample\r\n</h1>\r\n<ul>\r\n");
#nullable restore
#line 5 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Sample\Index.cshtml"
 for (var i = 0; i < 10; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 7 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Sample\Index.cshtml"
   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 8 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Sample\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
#nullable restore
#line 10 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Sample\Index.cshtml"
Write(TempData["username"]);

#line default
#line hidden
#nullable disable
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
