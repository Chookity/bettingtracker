#pragma checksum "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ffc64d9d40d7c60d0175f3b1029bbf693e618be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Pregled), @"mvc.1.0.view", @"/Views/Dashboard/Pregled.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Pregled.cshtml", typeof(AspNetCore.Views_Dashboard_Pregled))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ffc64d9d40d7c60d0175f3b1029bbf693e618be", @"/Views/Dashboard/Pregled.cshtml")]
    public class Views_Dashboard_Pregled : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
  
    Layout = "~/Views/Dashboard/headerdashboard.cshtml";

#line default
#line hidden
            BeginContext(67, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(96, 930, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d0ab0e5525a495f9d71b4b0c3b85fd7", async() => {
                BeginContext(102, 917, true);
                WriteLiteral(@"

    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"" crossorigin=""anonymous""></script>


    <meta name=""viewport"" content=""width=device-width"" />
    <title>Pregled</title>
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
            BeginContext(1026, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1028, 2668, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45ff61d0740f4c348b134a15fe3a9fd2", async() => {
                BeginContext(1034, 33, true);
                WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n");
                EndContext();
#line 23 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
          
            if (ViewBag.dodano != null)
            {

#line default
#line hidden
                BeginContext(1135, 71, true);
                WriteLiteral("                <div class=\"alert alert-success\">\r\n                    ");
                EndContext();
                BeginContext(1207, 14, false);
#line 27 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
               Write(ViewBag.dodano);

#line default
#line hidden
                EndContext();
                BeginContext(1221, 26, true);
                WriteLiteral("\r\n                </div>\r\n");
                EndContext();
#line 29 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
            }
        

#line default
#line hidden
                BeginContext(1273, 155, true);
                WriteLiteral("        <div style=\"margin-bottom:15px;\">\r\n            <a href=\"/Dashboard/Dodaj\" class=\"btn btn-primary\" role=\"button\">Dodaj stavo</a>\r\n        </div>\r\n\r\n");
                EndContext();
#line 35 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
          
            if (ViewBag.podatki != null)
            {
                var data = ViewBag.podatki;

#line default
#line hidden
                BeginContext(1542, 599, true);
                WriteLiteral(@"                <table class=""table"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Domači</th>
                            <th scope=""col"">Gosti</th>
                            <th scope=""col"">Kvota</th>
                            <th scope=""col"">Količina</th>
                            <th scope=""col"">Izbera</th>
                            <th scope=""col"">Izid</th>
                        </tr>
                    </thead>
                    <tbody>
");
                EndContext();
#line 52 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                          
                            int i = 0;
                        

#line default
#line hidden
                BeginContext(2236, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 55 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                         foreach (var x in data)
                        {
                            i++;
                            double preracunano = Math.Round(x.Kvota * x.Kolicina, 2);


#line default
#line hidden
                BeginContext(2436, 82, true);
                WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
                EndContext();
                BeginContext(2519, 1, false);
#line 61 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                           Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(2520, 43, true);
                WriteLiteral("</th>\r\n                                <td>");
                EndContext();
                BeginContext(2564, 10, false);
#line 62 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                               Write(x.Ime_doma);

#line default
#line hidden
                EndContext();
                BeginContext(2574, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(2618, 11, false);
#line 63 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                               Write(x.Ime_goste);

#line default
#line hidden
                EndContext();
                BeginContext(2629, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(2673, 7, false);
#line 64 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                               Write(x.Kvota);

#line default
#line hidden
                EndContext();
                BeginContext(2680, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(2724, 10, false);
#line 65 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                               Write(x.Kolicina);

#line default
#line hidden
                EndContext();
                BeginContext(2734, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(2778, 8, false);
#line 66 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                               Write(x.Izbral);

#line default
#line hidden
                EndContext();
                BeginContext(2786, 9, true);
                WriteLiteral("</td>\r\n\r\n");
                EndContext();
#line 68 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                 if (x.Izid == 1)
                                {

#line default
#line hidden
                BeginContext(2881, 74, true);
                WriteLiteral("                                    <td><span class=\"badge badge-success\">");
                EndContext();
                BeginContext(2956, 11, false);
#line 70 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                                                     Write(preracunano);

#line default
#line hidden
                EndContext();
                BeginContext(2967, 14, true);
                WriteLiteral("</span></td>\r\n");
                EndContext();
#line 71 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                }
                                else if (x.Izid == 2)
                                {
                                    preracunano = x.Kolicina * -1;

#line default
#line hidden
                BeginContext(3174, 73, true);
                WriteLiteral("                                    <td><span class=\"badge badge-danger\">");
                EndContext();
                BeginContext(3248, 11, false);
#line 75 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                                                    Write(preracunano);

#line default
#line hidden
                EndContext();
                BeginContext(3259, 14, true);
                WriteLiteral("</span></td>\r\n");
                EndContext();
#line 76 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                }
                                else if (x.Izid == 3)
                                {

#line default
#line hidden
                BeginContext(3398, 98, true);
                WriteLiteral("                                    <td><span class=\"badge badge-warning\">0 (V igri)</span></td>\r\n");
                EndContext();
#line 80 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                }

#line default
#line hidden
                BeginContext(3531, 37, true);
                WriteLiteral("\r\n                            </tr>\r\n");
                EndContext();
#line 83 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                        }

#line default
#line hidden
                BeginContext(3595, 56, true);
                WriteLiteral("                    </tbody>\r\n                </table>\r\n");
                EndContext();
#line 86 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
            }
        

#line default
#line hidden
                BeginContext(3677, 12, true);
                WriteLiteral("    </div>\r\n");
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
            BeginContext(3696, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
