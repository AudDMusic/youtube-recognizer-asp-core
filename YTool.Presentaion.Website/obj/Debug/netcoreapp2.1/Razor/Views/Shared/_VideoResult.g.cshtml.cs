#pragma checksum "/home/amr/Documents/YTools/YTool.Presentaion.Website/Views/Shared/_VideoResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5384d46c8b7d93d28ed5dc8e4c89d840e5bf58a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__VideoResult), @"mvc.1.0.view", @"/Views/Shared/_VideoResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_VideoResult.cshtml", typeof(AspNetCore.Views_Shared__VideoResult))]
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
#line 1 "/home/amr/Documents/YTools/YTool.Presentaion.Website/Views/_ViewImports.cshtml"
using YTool.Presentaion.Website;

#line default
#line hidden
#line 2 "/home/amr/Documents/YTools/YTool.Presentaion.Website/Views/_ViewImports.cshtml"
using YTool.Presentaion.Website.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5384d46c8b7d93d28ed5dc8e4c89d840e5bf58a9", @"/Views/Shared/_VideoResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fb88712b419b98d63004bc96a46e7eeb9cdef46", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__VideoResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YTool.Business.ViewModels.VideoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 328, true);
            WriteLiteral(@"
<div class=""panel panel-default"">
    <div class=""panel-heading"">Video Informtion from Youtube site using (YoutubeExplode lib)</div>
    <div class=""panel-body"">
        <div class=""container"">
            <dl class=""dl-horizontal"">
                <dt><label class=""form-label"">Author </label></dt>
                <dd>");
            EndContext();
            BeginContext(378, 12, false);
#line 9 "/home/amr/Documents/YTools/YTool.Presentaion.Website/Views/Shared/_VideoResult.cshtml"
               Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(390, 97, true);
            WriteLiteral("</dd>\r\n                <dt><label class=\"form-label\">Duration </label></dt>\r\n                <dd>");
            EndContext();
            BeginContext(488, 14, false);
#line 11 "/home/amr/Documents/YTools/YTool.Presentaion.Website/Views/Shared/_VideoResult.cshtml"
               Write(Model.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(502, 91, true);
            WriteLiteral("</dd>\r\n                <dt><label class=\"form-label\">ID </label></dt>\r\n                <dd>");
            EndContext();
            BeginContext(594, 8, false);
#line 13 "/home/amr/Documents/YTools/YTool.Presentaion.Website/Views/Shared/_VideoResult.cshtml"
               Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(602, 97, true);
            WriteLiteral("</dd>\r\n                <dt><label class=\"form-label\">Keywords </label></dt>\r\n                <dd>");
            EndContext();
            BeginContext(700, 14, false);
#line 15 "/home/amr/Documents/YTools/YTool.Presentaion.Website/Views/Shared/_VideoResult.cshtml"
               Write(Model.Keywords);

#line default
#line hidden
            EndContext();
            BeginContext(714, 94, true);
            WriteLiteral("</dd>\r\n                <dt><label class=\"form-label\">Title </label></dt>\r\n                <dd>");
            EndContext();
            BeginContext(809, 11, false);
#line 17 "/home/amr/Documents/YTools/YTool.Presentaion.Website/Views/Shared/_VideoResult.cshtml"
               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(820, 99, true);
            WriteLiteral("</dd>\r\n                <dt><label class=\"form-label\">UploadDate </label></dt>\r\n                <dd>");
            EndContext();
            BeginContext(920, 16, false);
#line 19 "/home/amr/Documents/YTools/YTool.Presentaion.Website/Views/Shared/_VideoResult.cshtml"
               Write(Model.UploadDate);

#line default
#line hidden
            EndContext();
            BeginContext(936, 64, true);
            WriteLiteral("</dd>\r\n            </dl>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YTool.Business.ViewModels.VideoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
