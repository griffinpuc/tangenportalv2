#pragma checksum "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cae76f7db07bffe24fbeedf088e26120ff95f0b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Main.cshtml", typeof(AspNetCore.Views_Home_Main))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae76f7db07bffe24fbeedf088e26120ff95f0b7", @"/Views/Home/Main.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 776, true);
            WriteLiteral(@"<script>

</script>

<div class=""container-fluid"">

    <!-- Page Heading -->
    <div class=""card"" style=""width: 18rem; width: 60vw; text-align: center; left: auto; right: auto; margin-bottom: 1vh; border-radius: 15px;"">
        <div class=""card-body"" style=""border-style:solid; border-radius: 15px; border-color: green; border-width: 2px;"">
            <div class=""row"">
                <div class=""col"" style=""text-align: left;"">
                    <h5 class=""card-title""><span class=""btn btn-success btn-circle""><i class=""fas fa-check""></i></span> 1425/1425 files up to date</h5>
                    <p class=""card-text"">Description of the content of the run, stats, etc...</p>
                </div>

            </div>


        </div>
    </div>

");
            EndContext();
#line 22 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Main.cshtml"
     for (int i = 0; i <= 10; i++)
    {

#line default
#line hidden
            BeginContext(819, 1282, true);
            WriteLiteral(@"        <div class=""card"" style=""width: 18rem; width: 60vw; text-align: center; left: auto; right: auto; margin-bottom: 1vh;"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-sm-2"" style=""text-align: left;"">
                        <button class=""btn btn-link"" onclick=""RunLoad();""><h5>#runno</h5></button>
                    </div>
                    <div class=""col"" style=""text-align: left;"">
                        <h5 class=""card-title"">Something</h5>
                        <p class=""card-text"">Description of the content of the run, stats, etc...</p>
                    </div>
                    <div class=""col"">
                        <div class=""row"">
                            <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                                <button type=""button"" class=""btn btn-secondary"">Left</button>
                                <button type=""button"" class=""btn btn-secondary"">Middle</button>
");
            WriteLiteral(@"                                <button type=""button"" class=""btn btn-secondary"">Right</button>
                            </div>
                        </div>
                    </div>

                </div>


            </div>
        </div>
");
            EndContext();
#line 49 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Main.cshtml"
    }

#line default
#line hidden
            BeginContext(2108, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
