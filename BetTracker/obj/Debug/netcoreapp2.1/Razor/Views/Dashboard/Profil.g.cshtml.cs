#pragma checksum "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c0495be4e7f01fee874d451b8ad93e6fd822f0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c0495be4e7f01fee874d451b8ad93e6fd822f0", @"/Views/Dashboard/Profil.cshtml")]
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
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(126, 929, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36f96731429d4128bc7c0fe0ea27121d", async() => {
                BeginContext(132, 916, true);
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
            BeginContext(1055, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1059, 2364, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db59b0ae386946e4bd5f3935c80ea687", async() => {
                BeginContext(1065, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 25 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
      
        var data = ViewBag.Message;
        var drzave = ViewBag.Drzava;
    

#line default
#line hidden
                BeginContext(1157, 337, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""bg-light text-dark"" style=""padding: 30px; border-radius: 20px; display: flex; justify-content:center;"">

            <form class=""text-center border border-light p-5"" action=""PosodobiProfil"" method=""post"" style=""width: 900px;"">

                <p class=""h4 mb-4"">Moj Profil</p>

");
                EndContext();
#line 37 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                 if (ViewBag.Error != null)
                {

#line default
#line hidden
                BeginContext(1558, 91, true);
                WriteLiteral("                    <div class=\"alert alert-danger\" role=\"alert\">\r\n                        ");
                EndContext();
                BeginContext(1650, 13, false);
#line 40 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                   Write(ViewBag.Error);

#line default
#line hidden
                EndContext();
                BeginContext(1663, 30, true);
                WriteLiteral("\r\n                    </div>\r\n");
                EndContext();
#line 42 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                }

#line default
#line hidden
                BeginContext(1712, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 44 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                 if (ViewBag.Success != null)
                {

#line default
#line hidden
                BeginContext(1780, 92, true);
                WriteLiteral("                    <div class=\"alert alert-success\" role=\"alert\">\r\n                        ");
                EndContext();
                BeginContext(1873, 15, false);
#line 47 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                   Write(ViewBag.Success);

#line default
#line hidden
                EndContext();
                BeginContext(1888, 30, true);
                WriteLiteral("\r\n                    </div>\r\n");
                EndContext();
#line 49 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                }

#line default
#line hidden
                BeginContext(1937, 193, true);
                WriteLiteral("\r\n                <div class=\"form-row mb-4\">\r\n                    <div class=\"col\">\r\n                        <!-- First name -->\r\n                        <input type=\"text\" id=\"ime\" name=\"ime\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2130, "\"", 2147, 1);
#line 54 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
WriteAttributeValue("", 2138, data.Ime, 2138, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2148, 210, true);
                WriteLiteral(" class=\"form-control\" placeholder=\"Ime\">\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <!-- Last name -->\r\n                        <input type=\"text\" name=\"priimek\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2358, "\"", 2379, 1);
#line 58 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
WriteAttributeValue("", 2366, data.Priimek, 2366, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2380, 205, true);
                WriteLiteral(" id=\"priimek\" class=\"form-control\" placeholder=\"Priimek\">\r\n                    </div>\r\n                </div>\r\n\r\n                <!-- E-mail -->\r\n                <input type=\"email\" id=\"email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2585, "\"", 2604, 1);
#line 63 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
WriteAttributeValue("", 2593, data.Email, 2593, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2605, 431, true);
                WriteLiteral(@" class=""form-control mb-4"" placeholder=""E-mail"" disabled>

                <input type=""password"" name=""geslo"" id=""geslo"" class=""form-control mb-4"" placeholder=""Geslo"" aria-describedby=""geslo"">

                <input type=""password"" name=""geslo_ponovi"" id=""geslo_ponovi"" class=""form-control mb-4"" placeholder=""Ponovi geslo"" aria-describedby=""geslo_ponovi"">

                <select class=""form-control mb-4"" name=""drzava"">
");
                EndContext();
#line 70 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                     foreach (var d in drzave)
                    {

#line default
#line hidden
                BeginContext(3107, 31, true);
                WriteLiteral("                        <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3138, "\"", 3158, 1);
#line 72 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
WriteAttributeValue("", 3146, d.ID_drzava, 3146, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3159, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(3161, 5, false);
#line 72 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                                                Write(d.Ime);

#line default
#line hidden
                EndContext();
                BeginContext(3166, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 73 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                    }

#line default
#line hidden
                BeginContext(3200, 216, true);
                WriteLiteral("                </select>\r\n\r\n                <!-- Sign up button -->\r\n                <button class=\"btn btn-info my-4 btn-block\" type=\"submit\">Posodobi</button>\r\n\r\n            </form>\r\n        </div>\r\n    </div>\r\n\r\n");
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
            BeginContext(3423, 132, true);
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
