#pragma checksum "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "236a0c2daa6a53d26dc02ee862cb17b2e9a2fbae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Profil), @"mvc.1.0.view", @"/Views/Dashboard/Profil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Profil.cshtml", typeof(AspNetCore.Views_Dashboard_Profil))]
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
#line 1 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
using BetTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"236a0c2daa6a53d26dc02ee862cb17b2e9a2fbae", @"/Views/Dashboard/Profil.cshtml")]
    public class Views_Dashboard_Profil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(26, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
  
    Layout = "~/Views/Dashboard/headerdashboard.cshtml";

#line default
#line hidden
            BeginContext(95, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(122, 929, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6bc5ec575934563be2a7a714e80a07f", async() => {
                BeginContext(128, 916, true);
                WriteLiteral(@"

    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"" crossorigin=""anonymous""></script>


    <meta name=""viewport"" content=""width=device-width"" />
    <title>Profil</title>
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
            BeginContext(1053, 3459, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9754127d1c58482f9d8334193a142e20", async() => {
                BeginContext(1059, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 22 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
      
        var data = ViewBag.Message;
        var drzave = ViewBag.Drzava;
    

#line default
#line hidden
                BeginContext(1151, 324, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""bg-light text-dark"" style=""padding: 30px; border-radius: 20px;"">
            <form class=""col-md-6"" action=""PosodobiProfil"" method=""post"">
                <div class=""form-group"">
                    <label>Ime </label>
                    <input type=""text"" name=""ime""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1475, "\"", 1492, 1);
#line 32 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
WriteAttributeValue("", 1483, data.Ime, 1483, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1493, 236, true);
                WriteLiteral(" class=\"form-control\" id=\"ime\" placeholder=\"Vnesite ime uporabnika\">\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label>Priimek </label>\r\n                    <input type=\"text\" name=\"priimek\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1729, "\"", 1750, 1);
#line 37 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
WriteAttributeValue("", 1737, data.Priimek, 1737, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1751, 241, true);
                WriteLiteral(" class=\"form-control\" id=\"priimek\" placeholder=\"Vnesite priimek uporabnika\">\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label>Email </label>\r\n                    <input type=\"email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1992, "\"", 2011, 1);
#line 42 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
WriteAttributeValue("", 2000, data.Email, 2000, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2012, 252, true);
                WriteLiteral(" class=\"form-control\" id=\"email\" placeholder=\"Vnesite svoj email naslov\">\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label>Država </label>\r\n                    <select class=\"form-control\" name=\"drzava\">\r\n");
                EndContext();
#line 48 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                         foreach (var d in drzave)
                        {

#line default
#line hidden
                BeginContext(2343, 35, true);
                WriteLiteral("                            <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2378, "\"", 2398, 1);
#line 50 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
WriteAttributeValue("", 2386, d.ID_drzava, 2386, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2399, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2401, 5, false);
#line 50 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                                                    Write(d.Ime);

#line default
#line hidden
                EndContext();
                BeginContext(2406, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 51 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                        }

#line default
#line hidden
                BeginContext(2444, 1007, true);
                WriteLiteral(@"                    </select>
                </div>

                <button type=""submit"" class=""btn btn-info"">Posodobi</button>
            </form>

            <form class=""text-center border border-light p-5"" action=""PosodobiProfil"" method=""post"" style=""width: 900px;"">

            <p class=""h4 mb-4"">Registracija</p>

            <div class=""form-row mb-4"">
                <div class=""col"">
                    <!-- First name -->
                    <input type=""text"" id=""ime"" name=""ime"" class=""form-control"" placeholder=""Ime"">
                </div>
                <div class=""col"">
                    <!-- Last name -->
                    <input type=""text"" name=""priimek"" id=""priimek"" class=""form-control"" placeholder=""Priimek"">
                </div>
            </div>

            <!-- E-mail -->
            <input type=""email"" id=""email"" name=""email"" class=""form-control mb-4"" placeholder=""E-mail"">

            <select class=""form-control mb-4"" name=""drzava"">
");
                EndContext();
#line 77 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                 foreach (var d in drzave)
                {

#line default
#line hidden
                BeginContext(3514, 27, true);
                WriteLiteral("                    <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3541, "\"", 3561, 1);
#line 79 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
WriteAttributeValue("", 3549, d.ID_drzava, 3549, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3562, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(3564, 5, false);
#line 79 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                                            Write(d.Ime);

#line default
#line hidden
                EndContext();
                BeginContext(3569, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 80 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                }

#line default
#line hidden
                BeginContext(3599, 906, true);
                WriteLiteral(@"            </select>

            <!-- Password -->
            <input type=""password"" name=""geslo"" id=""geslo"" class=""form-control mb-4"" placeholder=""Geslo"" aria-describedby=""geslo"">

            <input type=""password"" name=""geslo_ponovi"" id=""geslo_ponovi"" class=""form-control mb-4"" placeholder=""Ponovi geslo"" aria-describedby=""geslo_ponovi"">
            <small id=""defaultRegisterFormPasswordHelpBlock"" class=""form-text text-muted mb-4"">
                Minimalno 8 znakov in 1 številka
            </small>

            <!-- Sign up button -->
            <button class=""btn btn-info my-4 btn-block"" type=""submit"">Registracija</button>

            <hr>

            <!-- Terms of service -->
            <p>
                Z registracijo se strinjate z našimi pogoji
                <a href=""/Home/Pogoji"">pogoji uporabe</a>

                </form>
        </div>
    </div>

");
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
            BeginContext(4512, 132, true);
            WriteLiteral("\r\n</html>\r\n\r\n<script>\r\n    let navbar = document.querySelectorAll(\".nav-item\");\r\n    navbar[2].classList.add(\"active\");\r\n</script>\r\n");
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
