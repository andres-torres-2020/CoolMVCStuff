#pragma checksum "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\CoolMVCStuff\CoolMVCStuff\Views\Home\Result2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88cdb8769b77fb592f2a5b2842b43aa9b1f53523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result2), @"mvc.1.0.view", @"/Views/Home/Result2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88cdb8769b77fb592f2a5b2842b43aa9b1f53523", @"/Views/Home/Result2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1129e99e95273bdf1ced2c8561b2260a5aadf96", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Alphabet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>Letter: ");
#nullable restore
#line 2 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\CoolMVCStuff\CoolMVCStuff\Views\Home\Result2.cshtml"
      Write(Model.Letter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>Position: ");
#nullable restore
#line 4 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\CoolMVCStuff\CoolMVCStuff\Views\Home\Result2.cshtml"
        Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>Origin: ");
#nullable restore
#line 6 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\CoolMVCStuff\CoolMVCStuff\Views\Home\Result2.cshtml"
      Write(Model.Origin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Alphabet> Html { get; private set; }
    }
}
#pragma warning restore 1591
