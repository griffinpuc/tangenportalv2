#pragma checksum "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f535013db5eb7bc5ea644e2e40566d710c33876c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Instruments), @"mvc.1.0.view", @"/Views/Home/Instruments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Instruments.cshtml", typeof(AspNetCore.Views_Home_Instruments))]
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
#line 2 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
using tangenportalv2.Models;

#line default
#line hidden
#line 3 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
using System.Net;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f535013db5eb7bc5ea644e2e40566d710c33876c", @"/Views/Home/Instruments.cshtml")]
    public class Views_Home_Instruments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tangenportalv2.Models.Nugget>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sb-admin-2.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/animate.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/load-min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(89, 39, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(128, 2839, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3058ddd51464e73bbbc1f7da74c486e", async() => {
                BeginContext(134, 590, true);
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">

    <title>TangenPortal</title>

    <!-- Custom fonts for this template-->
    <script src=""https://kit.fontawesome.com/2f4791119e.js"" crossorigin=""anonymous""></script>

    <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"" rel=""stylesheet"">
    ");
                EndContext();
                BeginContext(724, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ca360c9226b49169754841044c84cc3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(777, 106, true);
                WriteLiteral("\r\n    <link href=\"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" />\r\n    ");
                EndContext();
                BeginContext(883, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1685708c90ce4e02b300c30ce7390157", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(933, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(939, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7aa52c326f3443ea909ffeb3d592e44a", async() => {
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
                BeginContext(986, 997, true);
                WriteLiteral(@"

    <!-- Custom styles for this template-->
    <link href=""css/sb-admin-2.min.css"" rel=""stylesheet"">

    <script src=""https://code.jquery.com/jquery-3.4.1.js""
            integrity=""sha256-WpOohJOqMqqyKL9FccASB9O0KwACQJpFTUBLTYOVvVU=""
            crossorigin=""anonymous"">
    </script>

    <script>

        try {
            var connection = new signalR.HubConnectionBuilder().withUrl(""/dataHub"").build();
        }
        catch (error) {
            console.error(error);
        }

        connection.on(""push"", function (status, instrument_ID, colorcode) {
            document.getElementById(""ins_status_"" + instrument_ID).innerHTML = (""<strong style=\""color:"" + colorcode + "";\"">"" + status + ""</strong>"");
        });

        connection.start().then(function () {
        }).catch(function (err) {
            return console.error(err.toString());
        });

        function toggleInstrument(instrumentID) {
            $.ajax({
                url: '");
                EndContext();
                BeginContext(1984, 38, false);
#line 55 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                 Write(Url.Action("toggleInstrument", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(2022, 883, true);
                WriteLiteral(@"',
                type: ""POST"",
                dataType: ""json"",
                data: { instrumentID },
                success: function (response) {
                    if (response == 'OK') {

                        var elem = document.getElementById('toggle-' + instrumentID);
                        var outer = document.getElementById('outer-' + instrumentID);

                        if (elem.hasAttribute('data-active')) {
                            outer.innerHTML = (""<i id=\""toggle-"" + instrumentID + ""\"" class=\""fas fa-toggle-off\""></i>"");
                        }
                        else {
                            outer.innerHTML = (""<i id=\""toggle-"" + instrumentID + ""\"" data-active class=\""fas fa-toggle-on\""></i>"");
                        }
                    }
                }
            });
        }

    </script>

    ");
                EndContext();
                BeginContext(2905, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "232993b325e74d48980790feafc48892", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2956, 4, true);
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
            BeginContext(2967, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(2971, 11500, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a744766708cf4acab84b43ea190e450d", async() => {
                BeginContext(2991, 2038, true);
                WriteLiteral(@"

    <!-- Page Wrapper -->
    <div id=""wrapper"">

        <!-- Sidebar -->
        <ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

            <!-- Sidebar - Brand -->
            <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""Index"">
                <div class=""sidebar-brand-text mx-3"">Tangen Portal <sup>2</sup></div>
            </a>

            <!-- Divider -->
            <hr class=""sidebar-divider my-0"">

            <!-- Nav Item - Dashboard -->
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Home/Index""><i class=""fas fa-home""></i>Dashboard</a>
                <a class=""nav-link"" href=""/Home/Instruments""><i class=""fas fa-robot""></i>Instruments</a>
                <a class=""nav-link"" href=""/Home/UpdateAgent""><i class=""fas fa-terminal""></i></i>Update Agent</a>
            </li>

            <!-- Divider -->
            <hr class=""sidebar-divider"">


        </ul>
 ");
                WriteLiteral(@"       <!-- End of Sidebar -->
        <!-- Content Wrapper -->
        <div id=""content-wrapper"" class=""d-flex flex-column"">

            <!-- Main Content -->
            <div id=""content"">

                <!-- End of Topbar -->
                <!-- Begin Page Content -->
                <!-- Partial page begin-->
                <div id=""mainview"" style=""margin-top: 50px;"">

                    <div class=""container-fluid"">

                        <div class=""row animated bounceInLeft"" style=""margin-bottom: 50px;"">
                            <div class=""col"">
                                <div class=""card"" style=""border: 3.5px solid #f0f0f0; width: 700px;"">
                                    <div class=""card-body"">
                                        <div class=""row"">
                                            <h3 style=""margin-left: 15px;"">Add Instrument</h3>
                                        </div>
                                        <div class=""row"">
");
                EndContext();
#line 132 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                             using (Html.BeginForm("addInstrument", "Home", FormMethod.Post))
                                            {

#line default
#line hidden
                BeginContext(5187, 1839, true);
                WriteLiteral(@"                                                <div class=""form-inline"" style=""margin-top:15px;"">
                                                    <div class=""col"">
                                                        <input class=""form-control"" placeholder=""Nickname"" type=""text"" name=""nickname"" />
                                                    </div>
                                                    <div class=""col"">
                                                        <input class=""form-control"" placeholder=""Address or name"" type=""text"" name=""address"" />
                                                    </div>
                                                </div>
                                                <div class=""form-inline"" style=""margin-top:15px;"">
                                                    <div class=""col"">
                                                        <input class=""form-control"" placeholder=""Device username"" type=""text"" name=""address"" />
      ");
                WriteLiteral(@"                                              </div>
                                                    <div class=""col"">
                                                        <input class=""form-control"" placeholder=""Device password"" type=""password"" name=""address"" />
                                                    </div>
                                                </div>
                                                <div class=""form-inline"" style=""margin-top:15px;"">
                                                    <div class=""col"">
                                                        <button type=""submit"" class=""btn btn-primary"" style=""width: 300px;"">Add</button>
                                                    </div>
                                                </div>
");
                EndContext();
#line 155 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                            }

#line default
#line hidden
                BeginContext(7073, 273, true);
                WriteLiteral(@"                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""col"" style=""position: relative;"">
");
                EndContext();
#line 163 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                             foreach (InstrumentMod instrument in Model.instruments)
                            {

#line default
#line hidden
                BeginContext(7463, 851, true);
                WriteLiteral(@"                                <div class=""row"">
                                    <div class=""col-sm-7"">
                                        <div class=""card animated bounceInLeft"" style=""border-left-color: orange; border-left-width: 7px; width: auto; height:75px; text-align: left; left: auto; right: auto; margin-bottom: 1vh; box-shadow: #f0f0f0 4px 4px;"">
                                            <div class=""card-body"">

                                                <div class=""row"">

                                                    <div class=""col"">
                                                        <div class=""row"">
                                                            <div class=""col-sm-5"" style=""font-weight: bolder; font-size: 15pt;"">
                                                                #");
                EndContext();
                BeginContext(8315, 15, false);
#line 175 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                            Write(instrument.name);

#line default
#line hidden
                EndContext();
                BeginContext(8330, 224, true);
                WriteLiteral("\r\n                                                            </div>\r\n                                                            <div class=\"col-sm-3\">\r\n\r\n                                                                <div");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 8554, "\"", 8584, 2);
                WriteAttributeValue("", 8559, "ins_status_", 8559, 11, true);
#line 179 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
WriteAttributeValue("", 8570, instrument.ID, 8570, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8585, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 180 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                                     if (instrument.status.Equals("PAUSED"))
                                                                    {

#line default
#line hidden
                BeginContext(8769, 303, true);
                WriteLiteral(@"                                                                        <strong style=""color: #FFA500;"">
                                                                            <div class=""loader""></div>  PAUSED  
                                                                        </strong>
");
                EndContext();
#line 185 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                                    }
                                                                    else
                                                                    {

#line default
#line hidden
                BeginContext(9288, 315, true);
                WriteLiteral(@"                                                                        <strong style=""color: lightslategrey;"">
                                                                            <div class=""loader""></div>  CONNECTING...
                                                                        </strong>
");
                EndContext();
#line 191 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                                    }

#line default
#line hidden
                BeginContext(9674, 226, true);
                WriteLiteral("                                                                </div>\r\n\r\n                                                            </div>\r\n                                                            <div class=\"col-sm-3\">\r\n");
                EndContext();
#line 196 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                                 if (instrument.localAddress.Contains("."))
                                                                {
                                                                    

#line default
#line hidden
                BeginContext(10145, 23, false);
#line 198 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                               Write(instrument.localAddress);

#line default
#line hidden
                EndContext();
#line 198 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                                                            
                                                                }
                                                                else
                                                                {

#line default
#line hidden
                BeginContext(10374, 105, true);
                WriteLiteral("                                                                    <span style=\"color: cornflowerblue;\">");
                EndContext();
                BeginContext(10480, 23, false);
#line 202 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                                                                    Write(instrument.localAddress);

#line default
#line hidden
                EndContext();
                BeginContext(10503, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 203 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                                }

#line default
#line hidden
                BeginContext(10579, 1104, true);
                WriteLiteral(@"                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-sm-1"">
                                        <div class=""card animated bounceInLeft"" style=""display: inline-block; border-left-color: lightcoral; border-left-width: 7px; width: auto; height:75px; text-align: left; left: auto; right: auto; margin-bottom: 1vh; box-shadow: #f0f0f0 4px 4px;"">
                                            <div class=""card-body"">

                                                <div class=""row"">

                                                    <div class=""col-sm-1"">
                                                        <div class=""");
                WriteLiteral("btn-group\">\r\n                                                            <button");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 11683, "\"", 11708, 2);
                WriteAttributeValue("", 11688, "outer-", 11688, 6, true);
#line 220 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
WriteAttributeValue("", 11694, instrument.ID, 11694, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(11709, 22, true);
                WriteLiteral(" class=\"btn btn-light\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 11731, "\"", 11774, 3);
                WriteAttributeValue("", 11741, "toggleInstrument(", 11741, 17, true);
#line 220 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
WriteAttributeValue("", 11758, instrument.ID, 11758, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 11772, ");", 11772, 2, true);
                EndWriteAttribute();
                BeginContext(11775, 5, true);
                WriteLiteral(">\r\n\r\n");
                EndContext();
#line 222 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                                 if (instrument.isActive)
                                                                {

#line default
#line hidden
                BeginContext(11938, 70, true);
                WriteLiteral("                                                                    <i");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 12008, "\"", 12034, 2);
                WriteAttributeValue("", 12013, "toggle-", 12013, 7, true);
#line 224 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
WriteAttributeValue("", 12020, instrument.ID, 12020, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(12035, 44, true);
                WriteLiteral(" data-active class=\"fas fa-toggle-on\"></i>\r\n");
                EndContext();
#line 225 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                                }
                                                                else
                                                                {

#line default
#line hidden
                BeginContext(12283, 70, true);
                WriteLiteral("                                                                    <i");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 12353, "\"", 12379, 2);
                WriteAttributeValue("", 12358, "toggle-", 12358, 7, true);
#line 228 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
WriteAttributeValue("", 12365, instrument.ID, 12365, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(12380, 33, true);
                WriteLiteral(" class=\"fas fa-toggle-off\"></i>\r\n");
                EndContext();
#line 229 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                                }

#line default
#line hidden
                BeginContext(12480, 73, true);
                WriteLiteral("\r\n                                                            </button>\r\n");
                EndContext();
#line 232 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                             using (Html.BeginForm("removeInstrument", "Home", FormMethod.Post))
                                                            {

#line default
#line hidden
                BeginContext(12746, 70, true);
                WriteLiteral("                                                                <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 12816, "\"", 12838, 1);
#line 234 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
WriteAttributeValue("", 12824, instrument.ID, 12824, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(12839, 329, true);
                WriteLiteral(@" name=""id"" hidden />
                                                                <button class=""btn btn-light"" type=""submit"">
                                                                    <i class=""far fa-trash-alt"" style=""color: red;""></i>
                                                                </button>
");
                EndContext();
#line 238 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"
                                                            }

#line default
#line hidden
                BeginContext(13231, 366, true);
                WriteLiteral(@"                                                        </div>
                                                    </div>

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
                EndContext();
#line 247 "C:\Users\griff\Workspace\tangenportalv2\tangen-dataportal-version2\tangen-dataportal-version2\Views\Home\Instruments.cshtml"

                            }

#line default
#line hidden
                BeginContext(13630, 834, true);
                WriteLiteral(@"                        </div>
                    </div>
                </div>





                <!-- End of Main Content -->
                <!-- Footer -->
                <!-- End of Footer -->

            </div>

            <!-- End of Content Wrapper -->
            <footer class=""sticky-footer bg-white"">
                <div class=""container my-auto"">
                    <div class=""copyright text-center my-auto"">
                        <span>Copyright &copy; Tangen Biosciences 2020</span>
                    </div>
                </div>
            </footer>
        </div>


        <!-- End of Page Wrapper -->
        <!-- Scroll to Top Button-->
        <a class=""scroll-to-top rounded"" href=""#page-top"">
            <i class=""fas fa-angle-up""></i>
        </a>
    </div>


");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14471, 15, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tangenportalv2.Models.Nugget> Html { get; private set; }
    }
}
#pragma warning restore 1591
