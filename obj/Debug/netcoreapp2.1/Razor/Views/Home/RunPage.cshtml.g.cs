#pragma checksum "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf2612e0031cf6d68233cc0a434aedee409aff96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RunPage), @"mvc.1.0.view", @"/Views/Home/RunPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RunPage.cshtml", typeof(AspNetCore.Views_Home_RunPage))]
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
#line 1 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
using tangenportalv2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf2612e0031cf6d68233cc0a434aedee409aff96", @"/Views/Home/RunPage.cshtml")]
    public class Views_Home_RunPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Nugget>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/bootstrap/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bootstrap/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family: \'Ubuntu Mono\', monospace; padding: 25px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 49, true);
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n\r\n");
            EndContext();
            BeginContext(96, 514, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f73bb92766454ee9ab39a2374af71bdb", async() => {
                BeginContext(102, 15, true);
                WriteLiteral("\r\n\r\n    <title>");
                EndContext();
                BeginContext(118, 18, false);
#line 8 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
      Write(Model.run.uniqueId);

#line default
#line hidden
                EndContext();
                BeginContext(136, 300, true);
                WriteLiteral(@"</title>

    <link rel=""stylesheet"" href=""//cdn.jsdelivr.net/chartist.js/latest/chartist.min.css"">
    <script src=""//cdn.jsdelivr.net/chartist.js/latest/chartist.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/gh/google/code-prettify@master/loader/run_prettify.js""></script>

    ");
                EndContext();
                BeginContext(436, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6731626d219c42ab8e65a4610a698f22", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(474, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(480, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b8e46644c4a84eaeb819586b74446a31", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(542, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(548, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd4821d969594d12b6872aa1f857d97c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(599, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(610, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(614, 3209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0b3a288365b4a52b74d9b30ebd34f19", async() => {
                BeginContext(682, 268, true);
                WriteLiteral(@"

    <div class=""row"" style=""text-align: center; margin-bottom: 50px;"">
        <div class=""col"">

            <div class=""row"" style=""margin-bottom: 50px;"">
                <div class=""col"">
                    <h2>Run: <strong style=""color: cornflowerblue;"">");
                EndContext();
                BeginContext(951, 18, false);
#line 27 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                                                               Write(Model.run.uniqueId);

#line default
#line hidden
                EndContext();
                BeginContext(969, 40, true);
                WriteLiteral("</strong></h2>\r\n                    <h3>");
                EndContext();
                BeginContext(1010, 18, false);
#line 28 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                   Write(Model.run.dateTime);

#line default
#line hidden
                EndContext();
                BeginContext(1028, 130, true);
                WriteLiteral("</h3>\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"row\" style=\"display: block; text-align: center;\">\r\n");
                EndContext();
#line 34 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                 using (Html.BeginForm("downloadHandlerRaw", "Home", FormMethod.Post))
                {

#line default
#line hidden
                BeginContext(1265, 33, true);
                WriteLiteral("                    <input hidden");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1298, "\"", 1322, 1);
#line 36 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
WriteAttributeValue("", 1306, Model.run.RunId, 1306, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1323, 29, true);
                WriteLiteral(" id=\"runid\" name=\"runid\" />\r\n");
                EndContext();
#line 37 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                     if (Model.run.uniqueId == null)
                    {

#line default
#line hidden
                BeginContext(1429, 102, true);
                WriteLiteral("                        <button disabled class=\"btn btn-sm btn-secondary\">Download raw data</button>\r\n");
                EndContext();
#line 40 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(1603, 93, true);
                WriteLiteral("                        <button class=\"btn btn-sm btn-secondary\">Download raw data</button>\r\n");
                EndContext();
#line 44 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                    }

#line default
#line hidden
#line 44 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                     

                }

#line default
#line hidden
                BeginContext(1740, 97, true);
                WriteLiteral("            </div>\r\n\r\n            <div class=\"row\" style=\"display: block; text-align: center;\">\r\n");
                EndContext();
#line 50 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                 using (Html.BeginForm("downloadLog", "Home", FormMethod.Post))
                {

#line default
#line hidden
                BeginContext(1937, 33, true);
                WriteLiteral("                    <input hidden");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1970, "\"", 1994, 1);
#line 52 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
WriteAttributeValue("", 1978, Model.run.RunId, 1978, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1995, 29, true);
                WriteLiteral(" id=\"runid\" name=\"runid\" />\r\n");
                EndContext();
#line 53 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                     if (Model.run.uniqueId == null)
                    {

#line default
#line hidden
                BeginContext(2101, 106, true);
                WriteLiteral("                        <button disabled class=\"btn btn-sm btn-secondary\">Download run log file</button>\r\n");
                EndContext();
#line 56 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(2279, 97, true);
                WriteLiteral("                        <button class=\"btn btn-sm btn-secondary\">Download run log file</button>\r\n");
                EndContext();
#line 60 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                    }

#line default
#line hidden
#line 60 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(2418, 240, true);
                WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"ct-chart\" id=\"chart2\" style=\"width: 100vw; height: 45vh; color: black; margin-top: 5vh;\"></div>\r\n\r\n        <script>\r\n            var plate = (\'");
                EndContext();
                BeginContext(2659, 20, false);
#line 72 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                     Write(Model.logmodel.plate);

#line default
#line hidden
                EndContext();
                BeginContext(2679, 41, true);
                WriteLiteral("\').split(\",\");\r\n            var tube = (\'");
                EndContext();
                BeginContext(2721, 19, false);
#line 73 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                    Write(Model.logmodel.tube);

#line default
#line hidden
                EndContext();
                BeginContext(2740, 44, true);
                WriteLiteral("\').split(\",\");\r\n            var diskTop = (\'");
                EndContext();
                BeginContext(2785, 22, false);
#line 74 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                       Write(Model.logmodel.diskTop);

#line default
#line hidden
                EndContext();
                BeginContext(2807, 47, true);
                WriteLiteral("\').split(\",\");\r\n            var diskBottom = (\'");
                EndContext();
                BeginContext(2855, 25, false);
#line 75 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                          Write(Model.logmodel.diskBottom);

#line default
#line hidden
                EndContext();
                BeginContext(2880, 46, true);
                WriteLiteral("\').split(\",\");\r\n            var fluidTemp = (\'");
                EndContext();
                BeginContext(2927, 24, false);
#line 76 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                         Write(Model.logmodel.fluidTemp);

#line default
#line hidden
                EndContext();
                BeginContext(2951, 49, true);
                WriteLiteral("\').split(\",\");\r\n            var piezoCurrent = (\'");
                EndContext();
                BeginContext(3001, 27, false);
#line 77 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                            Write(Model.logmodel.piezoCurrent);

#line default
#line hidden
                EndContext();
                BeginContext(3028, 676, true);
                WriteLiteral(@"').split("","");
            var data = {
                series: [{""name"": ""test1"", ""data"":plate}, tube, diskTop, diskBottom, fluidTemp, piezoCurrent]
            }
            var options = {
                showPoint: false,
                showArea: true,
                fullWidth: true
            }
            new Chartist.Line(
                '#chart2',
                data,
                options
            );
        </script>
    </div>

    <div class=""row"">
        <div class=""col"">
            <div class=""card text-center"">
                <div class=""card-body"" style=""text-align: left;"">
                    <pre class=""prettyprint"">");
                EndContext();
                BeginContext(3705, 19, false);
#line 98 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\RunPage.cshtml"
                                        Write(Model.run.getJSON());

#line default
#line hidden
                EndContext();
                BeginContext(3724, 92, true);
                WriteLiteral("</pre>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3823, 15, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nugget> Html { get; private set; }
    }
}
#pragma warning restore 1591
