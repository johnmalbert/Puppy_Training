#pragma checksum "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\VesperDachi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69af643b13fd867664f022c405ef55c82b97dfe6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\VesperDachi\Views\_ViewImports.cshtml"
using VesperDachi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\VesperDachi\Views\_ViewImports.cshtml"
using VesperDachi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69af643b13fd867664f022c405ef55c82b97dfe6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ec4873eb83ebb5b73b4a6cc057b82d219b6cfe9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\VesperDachi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">VesperDachi</h1>\r\n        <div class=\"row m-5\">\r\n            <div class=\"col border\"><h3>Meals: ");
#nullable restore
#line 9 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\VesperDachi\Views\Home\Index.cshtml"
                                          Write(ViewBag.Meals);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n            <div class=\"col border\"><h3>Fullness: ");
#nullable restore
#line 10 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\VesperDachi\Views\Home\Index.cshtml"
                                             Write(ViewBag.Fullness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n            <div class=\"col border\"><h3>Happiness: ");
#nullable restore
#line 11 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\VesperDachi\Views\Home\Index.cshtml"
                                              Write(ViewBag.Happiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n            <div class=\"col border\"><h3>Energy: ");
#nullable restore
#line 12 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\VesperDachi\Views\Home\Index.cshtml"
                                           Write(ViewBag.Energy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n        </div>\r\n\r\n    <div class=\"col border p-5\">\r\n        <h3>");
#nullable restore
#line 16 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\VesperDachi\Views\Home\Index.cshtml"
       Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <img");
            BeginWriteAttribute("src", " src= \"", 562, "\"", 597, 1);
#nullable restore
#line 17 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\VesperDachi\Views\Home\Index.cshtml"
WriteAttributeValue("", 569, Url.Content(ViewBag.ImgUrl), 569, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 598, "\"", 604, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height: 40vh; border: 2px solid gray;\">\r\n        <h3>Choose your next action wisely!</h3>\r\n    </div>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 21 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\VesperDachi\Views\Home\Index.cshtml"
         if(@ViewBag.Meals > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col\"><a href=\"/feed\"><button class=\"btn btn-primary m-2\">Feed Vesper</button></a></div>\r\n");
#nullable restore
#line 23 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\VesperDachi\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col""><a href=""/play""><button class=""btn btn-primary m-2""> Go Play</button></a></div>
        <div class=""col""><a href=""/work""><button class=""btn btn-primary m-2""> Make Vesper Work</button></a></div>
        <div class=""col""><a href=""/sleep""><button class=""btn btn-primary m-2""> Make Vesper Sleep</button></a></div>
    </div>
</div>
");
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