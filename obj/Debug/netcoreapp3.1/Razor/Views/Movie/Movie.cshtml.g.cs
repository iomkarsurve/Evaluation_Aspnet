#pragma checksum "C:\Users\Admin\Documents\dotnettraining\UserApp\Views\Movie\Movie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "084c8d9a2d4e46412487a647679f189b129ecbb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Movie), @"mvc.1.0.view", @"/Views/Movie/Movie.cshtml")]
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
#line 1 "C:\Users\Admin\Documents\dotnettraining\UserApp\Views\_ViewImports.cshtml"
using UserApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\dotnettraining\UserApp\Views\_ViewImports.cshtml"
using UserApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084c8d9a2d4e46412487a647679f189b129ecbb3", @"/Views/Movie/Movie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e34c925b69d60b81f4781e86e696c35aaaca0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Movie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserApp.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Documents\dotnettraining\UserApp\Views\Movie\Movie.cshtml"
  
    ViewBag.Title = "Movie";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div><b>Movie Data </b><br /></div>
<table class=""table table-bordered table-responsive table-hover"">
    <tr>
        <th>ID</th>
        <th>Title </th>
        <th>Director </th>
        <th>DateReleased</th>
        <th>Hero</th>
    </tr>
");
#nullable restore
#line 19 "C:\Users\Admin\Documents\dotnettraining\UserApp\Views\Movie\Movie.cshtml"
     foreach (var m in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Admin\Documents\dotnettraining\UserApp\Views\Movie\Movie.cshtml"
           Write(m.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Admin\Documents\dotnettraining\UserApp\Views\Movie\Movie.cshtml"
           Write(m.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Admin\Documents\dotnettraining\UserApp\Views\Movie\Movie.cshtml"
           Write(m.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Admin\Documents\dotnettraining\UserApp\Views\Movie\Movie.cshtml"
           Write(m.DateReleased);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Admin\Documents\dotnettraining\UserApp\Views\Movie\Movie.cshtml"
           Write(m.Hero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Admin\Documents\dotnettraining\UserApp\Views\Movie\Movie.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</table> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserApp.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
