#pragma checksum "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Employee\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbe4e3f636f74e524c46d273fcecbba315e29beb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Edit), @"mvc.1.0.view", @"/Views/Employee/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbe4e3f636f74e524c46d273fcecbba315e29beb", @"/Views/Employee/Edit.cshtml")]
    public class Views_Employee_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FirstWebApplication.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Employee\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n<h4>Employee</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <form asp-action=\"Edit\">\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n             ");
#nullable restore
#line 15 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Employee\Edit.cshtml"
        Write(Html.EditorFor(emp=>emp.Id,new{ htmlAttributes=new{@class="form-control"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Employee\Edit.cshtml"
       Write(Html.LabelFor(emp=>emp.Name,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 17 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Employee\Edit.cshtml"
       Write(Html.EditorFor(emp=>emp.Name,new{ htmlAttributes=new{@class="form-control"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Employee\Edit.cshtml"
       Write(Html.LabelFor(emp=>emp.Age,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Employee\Edit.cshtml"
       Write(Html.EditorFor(emp=>emp.Age,new{ htmlAttributes=new{@class="form-control"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 32 "D:\Data\d drive\Corp\RPS\CTS\INTCDE22ID010\FirstWebApplication\FirstWebApplication\Views\Employee\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
