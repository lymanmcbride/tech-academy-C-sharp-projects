#pragma checksum "C:\Users\Lyman\Desktop\coding\portfolio_pieces\tech_academy_projects\tech-academy-C-sharp-projects\basic_c#_programs\Challenge1\Challenge1\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bde24d362ea78c7da00e1081caa8d69d6b55a86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Challenge1.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Challenge1.Pages
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
#line 1 "C:\Users\Lyman\Desktop\coding\portfolio_pieces\tech_academy_projects\tech-academy-C-sharp-projects\basic_c#_programs\Challenge1\Challenge1\Pages\_ViewImports.cshtml"
using Challenge1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bde24d362ea78c7da00e1081caa8d69d6b55a86", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0103bdfb823d6267bda64e35c66b837b6d5a6f39", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Lyman\Desktop\coding\portfolio_pieces\tech_academy_projects\tech-academy-C-sharp-projects\basic_c#_programs\Challenge1\Challenge1\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    var dayOfWeek = DateTime.Now.DayOfWeek;
    var month = DateTime.Now.ToString("MMMM");
    var day = DateTime.Now.Day;
    var greeting = $"Hello! Today is {dayOfWeek}, {month} {day}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    <h2>");
#nullable restore
#line 14 "C:\Users\Lyman\Desktop\coding\portfolio_pieces\tech_academy_projects\tech-academy-C-sharp-projects\basic_c#_programs\Challenge1\Challenge1\Pages\Index.cshtml"
   Write(greeting);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p>Current Server Time: ");
#nullable restore
#line 15 "C:\Users\Lyman\Desktop\coding\portfolio_pieces\tech_academy_projects\tech-academy-C-sharp-projects\basic_c#_programs\Challenge1\Challenge1\Pages\Index.cshtml"
                       Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
