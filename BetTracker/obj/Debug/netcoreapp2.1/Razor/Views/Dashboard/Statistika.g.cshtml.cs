#pragma checksum "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Statistika.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e46bab6b9065ada65cb5a97bb249845538dadefd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Statistika), @"mvc.1.0.view", @"/Views/Dashboard/Statistika.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Statistika.cshtml", typeof(AspNetCore.Views_Dashboard_Statistika))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e46bab6b9065ada65cb5a97bb249845538dadefd", @"/Views/Dashboard/Statistika.cshtml")]
    public class Views_Dashboard_Statistika : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Statistika.cshtml"
  
    Layout = "~/Views/Dashboard/headerdashboard.cshtml";

#line default
#line hidden
            BeginContext(65, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(94, 958, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "814a39687bd04decb98696918b80aa13", async() => {
                BeginContext(100, 945, true);
                WriteLiteral(@"

    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">

    <!-- JQuery -->
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <!-- Bootstrap tooltips -->
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.4/umd/popper.min.js""></script>
    <!-- Bootstrap core JavaScript -->
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/js/bootstrap.min.js""></script>
    <!-- MDB core JavaScript -->
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.8.2/js/mdb.min.js""></script>

    <meta name=""viewport"" content=""width=device-width"" />
    <title>Statistika</title>
");
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
            BeginContext(1052, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1054, 1322, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4aa9d133a60d4d439ca752fed33db504", async() => {
                BeginContext(1060, 59, true);
                WriteLiteral("\r\n\r\n    <div id=\"vrednosti\" style=\"display: none\" data-id=\"");
                EndContext();
                BeginContext(1120, 17, false);
#line 26 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Statistika.cshtml"
                                                  Write(ViewBag.skozi_cas);

#line default
#line hidden
                EndContext();
                BeginContext(1137, 505, true);
                WriteLiteral(@"""></div>

    <div class=""container"">
        <div class=""bg-light text-dark"" style=""padding: 30px; border-radius: 20px;"">
            <table class=""table"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">Denar</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Skupaj</td>
                        <td>");
                EndContext();
                BeginContext(1643, 14, false);
#line 40 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Statistika.cshtml"
                       Write(ViewBag.stanje);

#line default
#line hidden
                EndContext();
                BeginContext(1657, 143, true);
                WriteLiteral(" €</td>\r\n                    </tr>\r\n\r\n                    <tr>\r\n                        <td>Največji dobitek</td>\r\n                        <td>");
                EndContext();
                BeginContext(1801, 19, false);
#line 45 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Statistika.cshtml"
                       Write(ViewBag.maxdobljeno);

#line default
#line hidden
                EndContext();
                BeginContext(1820, 142, true);
                WriteLiteral(" €</td>\r\n                    </tr>\r\n\r\n                    <tr>\r\n                        <td>Največja izguba</td>\r\n                        <td>");
                EndContext();
                BeginContext(1963, 17, false);
#line 50 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Statistika.cshtml"
                       Write(ViewBag.maxizguba);

#line default
#line hidden
                EndContext();
                BeginContext(1980, 144, true);
                WriteLiteral(" €</td>\r\n                    </tr>\r\n\r\n                    <tr>\r\n                        <td>Dobljene stave(%)</td>\r\n                        <td>");
                EndContext();
                BeginContext(2125, 12, false);
#line 55 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Statistika.cshtml"
                       Write(ViewBag.winp);

#line default
#line hidden
                EndContext();
                BeginContext(2137, 232, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n        <h3 style=\"text-align: center; margin-top:20px;\">Stanje čez stave</h3>\r\n        <canvas id=\"lineChart\"></canvas>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2376, 979, true);
            WriteLiteral(@"
</html>

<script>
    let navbar = document.querySelectorAll("".nav-item"");
    navbar[1].classList.add(""active"");

    let vrednosti = $('#vrednosti').data('id');

    let v = vrednosti.split(', ');
    let stevilo_vseh = v.length - 1;

    let vsi = [];
    for (let i = 1; i <= stevilo_vseh; i++) {
        vsi.push(i);
    }

    var ctxL = document.getElementById(""lineChart"").getContext('2d');
    var myLineChart = new Chart(ctxL, {
        type: 'line',
        data: {
            labels: vsi,
            datasets: [{
                label: ""Skupaj skozi čas(€)"",
                data: v,
                backgroundColor: [
                    'rgba(105, 0, 132, .2)',
                ],
                borderColor: [
                    'rgba(200, 99, 132, .7)',
                ],
                borderWidth: 2
            },
            ]
        },
        options: {
            responsive: true
        }
    });
</script>");
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
