#pragma checksum "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "944c3d58a2fad1181abd9e912ca1e9f257886b81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Logout), @"mvc.1.0.view", @"/Views/Home/Logout.cshtml")]
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
#line 1 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\_ViewImports.cshtml"
using car4you;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\_ViewImports.cshtml"
using car4you.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"944c3d58a2fad1181abd9e912ca1e9f257886b81", @"/Views/Home/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c065fa01d2bee8047d66c6a01296f622848f2e9c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Logout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Logout.cshtml"
  
    ViewData["Title"] = "Login";
    var returnUrl = ViewData["ReturnUrl"] as string;
    var error = TempData["Error"] as string;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>title</h2>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
