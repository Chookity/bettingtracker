#pragma checksum "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e40145de107c48f91d7a4eb6609805953324334"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e40145de107c48f91d7a4eb6609805953324334", @"/Views/Dashboard/Profil.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7cc17dc48194ef3bd8faad55ccb2c9b", async() => {
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
            BeginContext(1053, 1393, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "767b5fc104d9471bbd990272a0e62d8d", async() => {
                BeginContext(1059, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 22 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
       
        var data = ViewBag.Message;
        var drzave = ViewBag.Drzava;
    

#line default
#line hidden
                BeginContext(1152, 225, true);
                WriteLiteral("   \r\n    <div class=\"container\">\r\n        <form class=\"col-md-6\" action=\"PosodobiProfil\" method=\"post\">\r\n            <div class=\"form-group\">\r\n                <label>Ime </label>\r\n                <input type=\"text\" name=\"ime\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1377, "\"", 1394, 1);
#line 31 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
WriteAttributeValue("", 1385, data.Ime, 1385, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1395, 220, true);
                WriteLiteral(" class=\"form-control\" id=\"ime\" placeholder=\"Vnesite ime uporabnika\">\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label>Priimek </label>\r\n                <input type=\"text\" name=\"priimek\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1615, "\"", 1636, 1);
#line 36 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
WriteAttributeValue("", 1623, data.Priimek, 1623, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1637, 225, true);
                WriteLiteral(" class=\"form-control\" id=\"priimek\" placeholder=\"Vnesite priimek uporabnika\">\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label>Email </label>\r\n                <input type=\"email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1862, "\"", 1881, 1);
#line 41 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
WriteAttributeValue("", 1870, data.Email, 1870, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1882, 236, true);
                WriteLiteral(" class=\"form-control\" id=\"email\" placeholder=\"Vnesite svoj email naslov\">\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label>Država </label>\r\n                <select class=\"form-control\" name=\"drzava\">\r\n");
                EndContext();
#line 47 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                     foreach (var d in drzave)
                    {

#line default
#line hidden
                BeginContext(2189, 31, true);
                WriteLiteral("                        <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2220, "\"", 2240, 1);
#line 49 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
WriteAttributeValue("", 2228, d.ID_drzava, 2228, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2241, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2243, 5, false);
#line 49 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                                                Write(d.Ime);

#line default
#line hidden
                EndContext();
                BeginContext(2248, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 50 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Profil.cshtml"
                    }

#line default
#line hidden
                BeginContext(2282, 157, true);
                WriteLiteral("                </select>\r\n            </div>\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary\">Posodobi</button>\r\n        </form>\r\n    </div>\r\n\r\n");
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
            BeginContext(2446, 11, true);
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
