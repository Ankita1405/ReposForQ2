#pragma checksum "C:\Users\Ankita Sharma\source\repos\Proj2\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "077cd273d96e764f00f6fa3746eae7320d5ec321"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\Ankita Sharma\source\repos\Proj2\Views\_ViewImports.cshtml"
using Proj2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ankita Sharma\source\repos\Proj2\Views\_ViewImports.cshtml"
using Proj2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"077cd273d96e764f00f6fa3746eae7320d5ec321", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489e68b0ff4328c1366664f77026a3459f7540bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ankita Sharma\source\repos\Proj2\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n\r\n");
            WriteLiteral("    <table class=\"table\">\r\n\r\n        <tr>\r\n            <td>Id</td>\r\n            <td>Name</td>\r\n            <td>Salary</td>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Ankita Sharma\source\repos\Proj2\Views\Employee\Index.cshtml"
         foreach (var e in ViewBag.employee)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Ankita Sharma\source\repos\Proj2\Views\Employee\Index.cshtml"
               Write(e.Empid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Ankita Sharma\source\repos\Proj2\Views\Employee\Index.cshtml"
               Write(e.Empname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Ankita Sharma\source\repos\Proj2\Views\Employee\Index.cshtml"
               Write(e.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Ankita Sharma\source\repos\Proj2\Views\Employee\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>");
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
