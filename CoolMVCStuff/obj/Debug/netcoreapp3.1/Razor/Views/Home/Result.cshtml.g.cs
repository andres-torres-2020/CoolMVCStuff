#pragma checksum "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\CoolMVCStuff\CoolMVCStuff\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3315532fffa26fc7009a37e5835730e861a44c12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\CoolMVCStuff\CoolMVCStuff\Views\_ViewImports.cshtml"
using CoolMVCStuff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\CoolMVCStuff\CoolMVCStuff\Views\_ViewImports.cshtml"
using CoolMVCStuff.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3315532fffa26fc7009a37e5835730e861a44c12", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1129e99e95273bdf1ced2c8561b2260a5aadf96", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Letter: ");
#nullable restore
#line 1 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\CoolMVCStuff\CoolMVCStuff\Views\Home\Result.cshtml"
       Write(ViewBag.Letter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Position: ");
#nullable restore
#line 2 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\CoolMVCStuff\CoolMVCStuff\Views\Home\Result.cshtml"
         Write(ViewBag.p);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Origin: ");
#nullable restore
#line 3 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\CoolMVCStuff\CoolMVCStuff\Views\Home\Result.cshtml"
       Write(ViewBag.O);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
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