#pragma checksum "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Sample\EmployeeView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a8d1b37a4afe548533d4dffc6a6075e22e88860"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sample_EmployeeView), @"mvc.1.0.view", @"/Views/Sample/EmployeeView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a8d1b37a4afe548533d4dffc6a6075e22e88860", @"/Views/Sample/EmployeeView.cshtml")]
    public class Views_Sample_EmployeeView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FirstWebApplication.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    div{\r\n        background-color:beige;\r\n        height:200px;\r\n        width:200px;\r\n        border:2px solid darkolivegreen;\r\n    }\r\n</style>\r\n");
            WriteLiteral("<div>\r\n    Employee Id: ");
#nullable restore
#line 22 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Sample\EmployeeView.cshtml"
            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Employee Name: ");
#nullable restore
#line 24 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Sample\EmployeeView.cshtml"
              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Employee Age: ");
#nullable restore
#line 26 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Sample\EmployeeView.cshtml"
             Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstWebApplication.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
