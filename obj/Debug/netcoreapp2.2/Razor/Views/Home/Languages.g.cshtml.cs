#pragma checksum "D:\New folder\Language\LangMulti\LangMulti\Views\Home\Languages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8c56731a1a5d4d0b1072e8967f01f7853e2a68e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Languages), @"mvc.1.0.view", @"/Views/Home/Languages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Languages.cshtml", typeof(AspNetCore.Views_Home_Languages))]
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
#line 1 "D:\New folder\Language\LangMulti\LangMulti\Views\_ViewImports.cshtml"
using LangMulti;

#line default
#line hidden
#line 2 "D:\New folder\Language\LangMulti\LangMulti\Views\_ViewImports.cshtml"
using LangMulti.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8c56731a1a5d4d0b1072e8967f01f7853e2a68e", @"/Views/Home/Languages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a18004ff2579344fc7e47d55e994e4bd86e3d86", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Languages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Language>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\New folder\Language\LangMulti\LangMulti\Views\Home\Languages.cshtml"
 foreach (var item in Model)
{
   

#line default
#line hidden
            BeginContext(72, 45, true);
            WriteLiteral("        <li class=\"nav-item\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 117, "\"", 164, 2);
            WriteAttributeValue("", 124, "/Home/ChangeLanguage/", 124, 21, true);
#line 8 "D:\New folder\Language\LangMulti\LangMulti\Views\Home\Languages.cshtml"
WriteAttributeValue("", 145, item.LanguageTitle, 145, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(165, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(167, 18, false);
#line 8 "D:\New folder\Language\LangMulti\LangMulti\Views\Home\Languages.cshtml"
                                                          Write(item.LanguageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(185, 21, true);
            WriteLiteral("</a>\r\n        </li>\r\n");
            EndContext();
#line 10 "D:\New folder\Language\LangMulti\LangMulti\Views\Home\Languages.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Language>> Html { get; private set; }
    }
}
#pragma warning restore 1591
