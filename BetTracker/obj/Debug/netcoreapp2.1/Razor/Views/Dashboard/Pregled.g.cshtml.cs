#pragma checksum "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "673b39b18fff70b5d158416f8e1827057ee5826f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"673b39b18fff70b5d158416f8e1827057ee5826f", @"/Views/Dashboard/Pregled.cshtml")]
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
#line 2 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
  
    Layout = "~/Views/Dashboard/headerdashboard.cshtml";

#line default
#line hidden
            BeginContext(67, 54, true);
            WriteLiteral("\r\n<style>\r\n\r\n\r\n</style>\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(121, 930, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa358f585bfe4593a802a29aac2fa812", async() => {
                BeginContext(127, 917, true);
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
            BeginContext(1051, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1053, 3071, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ea0a0e456754d94ada10753a0ebdb5e", async() => {
                BeginContext(1059, 139, true);
                WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n        <div class=\"bg-light text-dark\" style=\"padding: 30px; border-radius: 20px; margin-bottom:20px;\">\r\n");
                EndContext();
#line 29 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
              
                if (ViewBag.dodano != null)
                {

#line default
#line hidden
                BeginContext(1278, 79, true);
                WriteLiteral("                    <div class=\"alert alert-success\">\r\n                        ");
                EndContext();
                BeginContext(1358, 14, false);
#line 33 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                   Write(ViewBag.dodano);

#line default
#line hidden
                EndContext();
                BeginContext(1372, 30, true);
                WriteLiteral("\r\n                    </div>\r\n");
                EndContext();
#line 35 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                }
            

#line default
#line hidden
                BeginContext(1436, 164, true);
                WriteLiteral("            <div style=\"margin-bottom:15px;\">\r\n                <a href=\"/Dashboard/Dodaj\" class=\"btn btn-info\" role=\"button\">Dodaj stavo</a>\r\n            </div>\r\n\r\n");
                EndContext();
#line 41 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
              
                if (ViewBag.podatki != null)
                {
                    var data = ViewBag.podatki;

#line default
#line hidden
                BeginContext(1730, 663, true);
                WriteLiteral(@"                    <table class=""table table-hover"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th scope=""col"">#</th>
                                <th scope=""col"">Domači</th>
                                <th scope=""col"">Gosti</th>
                                <th scope=""col"">Kvota</th>
                                <th scope=""col"">Količina</th>
                                <th scope=""col"">Izbira</th>
                                <th scope=""col"">Izid</th>
                            </tr>
                        </thead>
                        <tbody>
");
                EndContext();
#line 58 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                              
                                int i = 0;
                            

#line default
#line hidden
                BeginContext(2500, 28, true);
                WriteLiteral("                            ");
                EndContext();
#line 61 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                             foreach (var x in data)
                            {
                                i++;
                                double preracunano = Math.Round(x.Kvota * x.Kolicina, 2);


#line default
#line hidden
                BeginContext(2716, 45, true);
                WriteLiteral("                                <tr data-id=\"");
                EndContext();
                BeginContext(2762, 10, false);
#line 66 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                        Write(x.ID_stava);

#line default
#line hidden
                EndContext();
                BeginContext(2772, 56, true);
                WriteLiteral("\">\r\n                                    <td scope=\"row\">");
                EndContext();
                BeginContext(2829, 1, false);
#line 67 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                               Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(2830, 47, true);
                WriteLiteral("</td>\r\n                                    <td>");
                EndContext();
                BeginContext(2878, 10, false);
#line 68 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                   Write(x.Ime_doma);

#line default
#line hidden
                EndContext();
                BeginContext(2888, 47, true);
                WriteLiteral("</td>\r\n                                    <td>");
                EndContext();
                BeginContext(2936, 11, false);
#line 69 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                   Write(x.Ime_goste);

#line default
#line hidden
                EndContext();
                BeginContext(2947, 47, true);
                WriteLiteral("</td>\r\n                                    <td>");
                EndContext();
                BeginContext(2995, 7, false);
#line 70 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                   Write(x.Kvota);

#line default
#line hidden
                EndContext();
                BeginContext(3002, 47, true);
                WriteLiteral("</td>\r\n                                    <td>");
                EndContext();
                BeginContext(3050, 10, false);
#line 71 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                   Write(x.Kolicina);

#line default
#line hidden
                EndContext();
                BeginContext(3060, 47, true);
                WriteLiteral("</td>\r\n                                    <td>");
                EndContext();
                BeginContext(3108, 8, false);
#line 72 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                   Write(x.Izbral);

#line default
#line hidden
                EndContext();
                BeginContext(3116, 9, true);
                WriteLiteral("</td>\r\n\r\n");
                EndContext();
#line 74 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                     if (x.Izid == 1)
                                    {

#line default
#line hidden
                BeginContext(3219, 78, true);
                WriteLiteral("                                        <td><span class=\"badge badge-success\">");
                EndContext();
                BeginContext(3298, 11, false);
#line 76 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                                                         Write(preracunano);

#line default
#line hidden
                EndContext();
                BeginContext(3309, 14, true);
                WriteLiteral("</span></td>\r\n");
                EndContext();
#line 77 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                    }
                                    else if (x.Izid == 2)
                                    {
                                        preracunano = x.Kolicina * -1;

#line default
#line hidden
                BeginContext(3532, 77, true);
                WriteLiteral("                                        <td><span class=\"badge badge-danger\">");
                EndContext();
                BeginContext(3610, 11, false);
#line 81 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                                                        Write(preracunano);

#line default
#line hidden
                EndContext();
                BeginContext(3621, 14, true);
                WriteLiteral("</span></td>\r\n");
                EndContext();
#line 82 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                    }
                                    else if (x.Izid == 3)
                                    {

#line default
#line hidden
                BeginContext(3772, 102, true);
                WriteLiteral("                                        <td><span class=\"badge badge-warning\">0 (V igri)</span></td>\r\n");
                EndContext();
#line 86 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                                    }

#line default
#line hidden
                BeginContext(3913, 39, true);
                WriteLiteral("                                </tr>\r\n");
                EndContext();
#line 88 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                            }

#line default
#line hidden
                BeginContext(3983, 64, true);
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
                EndContext();
#line 91 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Pregled.cshtml"
                }
            

#line default
#line hidden
                BeginContext(4081, 36, true);
                WriteLiteral("            </div>\r\n        </div>\r\n");
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
            BeginContext(4124, 132, true);
            WriteLiteral("\r\n</html>\r\n\r\n<script>\r\n    let navbar = document.querySelectorAll(\".nav-item\");\r\n    navbar[0].classList.add(\"active\");\r\n</script>\r\n");
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
