#pragma checksum "C:\Users\Holmes HQ\source\repos\StarWars API\StarWars API\Views\StarWars\DisplayPeople.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76f9367dbd9a4ae581c085e1d25219c2639e9cf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StarWars_DisplayPeople), @"mvc.1.0.view", @"/Views/StarWars/DisplayPeople.cshtml")]
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
#line 1 "C:\Users\Holmes HQ\source\repos\StarWars API\StarWars API\Views\_ViewImports.cshtml"
using StarWars_API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Holmes HQ\source\repos\StarWars API\StarWars API\Views\_ViewImports.cshtml"
using StarWars_API.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f9367dbd9a4ae581c085e1d25219c2639e9cf7", @"/Views/StarWars/DisplayPeople.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dab9241fa1836371eba769d381c672a9a457e77", @"/Views/_ViewImports.cshtml")]
    public class Views_StarWars_DisplayPeople : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PeopleRoot>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Holmes HQ\source\repos\StarWars API\StarWars API\Views\StarWars\DisplayPeople.cshtml"
  
    ViewData["Title"] = "DisplayPeople";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>DisplayPeople</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Height</th>\r\n        <th>Gender</th>\r\n        <th>Home World</th>\r\n        <th>Films</th>\r\n    </tr>\r\n\r\n    \r\n        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Holmes HQ\source\repos\StarWars API\StarWars API\Views\StarWars\DisplayPeople.cshtml"
           Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Holmes HQ\source\repos\StarWars API\StarWars API\Views\StarWars\DisplayPeople.cshtml"
           Write(Model.height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Holmes HQ\source\repos\StarWars API\StarWars API\Views\StarWars\DisplayPeople.cshtml"
           Write(Model.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Holmes HQ\source\repos\StarWars API\StarWars API\Views\StarWars\DisplayPeople.cshtml"
           Write(Model.homeworld);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Holmes HQ\source\repos\StarWars API\StarWars API\Views\StarWars\DisplayPeople.cshtml"
           Write(Model.films);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n    \r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PeopleRoot> Html { get; private set; }
    }
}
#pragma warning restore 1591