#pragma checksum "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Metrics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f4b6d5b461ec104da592e858d3310db946a10c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Metrics), @"mvc.1.0.view", @"/Views/Home/Metrics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Metrics.cshtml", typeof(AspNetCore.Views_Home_Metrics))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f4b6d5b461ec104da592e858d3310db946a10c9", @"/Views/Home/Metrics.cshtml")]
    public class Views_Home_Metrics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3128, true);
            WriteLiteral(@"
<div class="""" style=""width: 60vw; text-align: center; left: auto; right: auto;"">
    <div class=""card shadow mb-4"">
        <!-- Card Header - Dropdown -->
        <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
            <h6 class=""m-0 font-weight-bold text-primary"">Usage Overview</h6>
            <div class=""dropdown no-arrow"">
                <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
                </a>
                <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in"" aria-labelledby=""dropdownMenuLink"">
                    <div class=""dropdown-header"">Dropdown Header:</div>
                    <a class=""dropdown-item"" href=""#"">Action</a>
                    <a class=""dropdown-item"" href=""#"">Another action</a>
                    <div class=""dropdown-di");
            WriteLiteral(@"vider""></div>
                    <a class=""dropdown-item"" href=""#"">Something else here</a>
                </div>
            </div>
        </div>
        <!-- Card Body -->
        <div class=""card-body"">
            <div class=""chart-area"">
                <canvas id=""myAreaChart""></canvas>
            </div>
        </div>
    </div>
</div>


<div class=""card shadow mb-4"" style=""width: 60vw;"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">Projects</h6>
    </div>
    <div class=""card-body"">
        <h4 class=""small font-weight-bold"">Server Migration <span class=""float-right"">20%</span></h4>
        <div class=""progress mb-4"">
            <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 20%"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100""></div>
        </div>
        <h4 class=""small font-weight-bold"">Sales Tracking <span class=""float-right"">40%</span></h4>
        <div class=""progress mb-4"">
            <di");
            WriteLiteral(@"v class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 40%"" aria-valuenow=""40"" aria-valuemin=""0"" aria-valuemax=""100""></div>
        </div>
        <h4 class=""small font-weight-bold"">Customer Database <span class=""float-right"">60%</span></h4>
        <div class=""progress mb-4"">
            <div class=""progress-bar"" role=""progressbar"" style=""width: 60%"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100""></div>
        </div>
        <h4 class=""small font-weight-bold"">Payout Details <span class=""float-right"">80%</span></h4>
        <div class=""progress mb-4"">
            <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 80%"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""></div>
        </div>
        <h4 class=""small font-weight-bold"">Account Setup <span class=""float-right"">Complete!</span></h4>
        <div class=""progress"">
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-v");
            WriteLiteral("aluemax=\"100\"></div>\r\n        </div>\r\n    </div>\r\n</div>");
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