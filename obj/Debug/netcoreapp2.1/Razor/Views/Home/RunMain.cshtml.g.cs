#pragma checksum "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7563de7588faaadb6bcbd5b3744ccac6bfa93c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RunMain), @"mvc.1.0.view", @"/Views/Home/RunMain.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RunMain.cshtml", typeof(AspNetCore.Views_Home_RunMain))]
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
#line 2 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunMain.cshtml"
using tangenportalv2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7563de7588faaadb6bcbd5b3744ccac6bfa93c4", @"/Views/Home/RunMain.cshtml")]
    public class Views_Home_RunMain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tangenportalv2.Models.Nugget>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 138, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-2\">\r\n            \r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
            EndContext();
#line 14 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunMain.cshtml"
     foreach (RunMod run in Model.runs)
    {

#line default
#line hidden
            BeginContext(255, 393, true);
            WriteLiteral(@"    <div class=""card animated bounceInUp"" style=""border-left-color: cornflowerblue; border-left-width: 7px; width: 18rem; width: 60vw; height:60px; text-align: left; left: auto; right: auto; margin-bottom: 1vh;"">
        <div class=""card-body"">
            <div class=""row"" style=""margin-top: -1vh;"">
                <div class=""col-sm-1"" style=""font-weight: bold; "">
                    #");
            EndContext();
            BeginContext(649, 11, false);
#line 20 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunMain.cshtml"
                Write(run.assayId);

#line default
#line hidden
            EndContext();
            BeginContext(660, 86, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(747, 12, false);
#line 23 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunMain.cshtml"
               Write(run.dateTime);

#line default
#line hidden
            EndContext();
            BeginContext(759, 86, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(846, 12, false);
#line 26 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunMain.cshtml"
               Write(run.uniqueId);

#line default
#line hidden
            EndContext();
            BeginContext(858, 66, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-1\">\r\n");
            EndContext();
#line 29 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunMain.cshtml"
                     using (Html.BeginForm("ViewRun", "Home", FormMethod.Post))
                    {

#line default
#line hidden
            BeginContext(1028, 37, true);
            WriteLiteral("                        <input hidden");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1065, "\"", 1080, 1);
#line 31 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunMain.cshtml"
WriteAttributeValue("", 1073, run.Id, 1073, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1081, 107, true);
            WriteLiteral(" id=\"runid\" name=\"runid\" />\r\n                        <button class=\"btn btn-sm btn-primary\">View</button>\r\n");
            EndContext();
#line 33 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunMain.cshtml"
                    }

#line default
#line hidden
            BeginContext(1211, 64, true);
            WriteLiteral("                </div>\r\n                <div class=\"col-sm-2\">\r\n");
            EndContext();
#line 36 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunMain.cshtml"
                     using (Html.BeginForm("DownloadRun", "Home", FormMethod.Post))
                    {

#line default
#line hidden
            BeginContext(1383, 123, true);
            WriteLiteral("                        <button class=\"btn btn-sm\" style=\"background-color: #FE6505; color: white;\">Download Zip</button>\r\n");
            EndContext();
#line 39 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunMain.cshtml"
                    }

#line default
#line hidden
            BeginContext(1529, 76, true);
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 46 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunMain.cshtml"
    }

#line default
#line hidden
            BeginContext(1612, 10, true);
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tangenportalv2.Models.Nugget> Html { get; private set; }
    }
}
#pragma warning restore 1591
