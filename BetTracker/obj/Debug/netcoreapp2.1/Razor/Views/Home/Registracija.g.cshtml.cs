#pragma checksum "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Registracija.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4abf79efd7c090d1fe3d44435a35aa1a5d61f51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registracija), @"mvc.1.0.view", @"/Views/Home/Registracija.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Registracija.cshtml", typeof(AspNetCore.Views_Home_Registracija))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4abf79efd7c090d1fe3d44435a35aa1a5d61f51", @"/Views/Home/Registracija.cshtml")]
    public class Views_Home_Registracija : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
  
    Layout = "headerhome.cshtml";
    ViewData["Title"] = "Registracija";

#line default
#line hidden
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(87, 2557, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f80b59ce5e4a2f93d43cd6e7a042c0", async() => {
                BeginContext(93, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
      
        var drzave = ViewBag.Drzava;
    

#line default
#line hidden
                BeginContext(148, 375, true);
                WriteLiteral(@"    <div class=""container"" style=""display: flex; justify-content: center"">
        <!-- Default form register -->
        <div class=""bg-light text-dark"" style=""padding: 30px; border-radius: 20px;"">
            <form class=""text-center border border-light p-5"" action=""Vstavi"" method=""post"" style=""width: 900px;"">

                <p class=""h4 mb-4"">Registracija</p>

");
                EndContext();
#line 18 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
                 if (ViewBag.Error != null)
                {

#line default
#line hidden
                BeginContext(587, 91, true);
                WriteLiteral("                    <div class=\"alert alert-danger\" role=\"alert\">\r\n                        ");
                EndContext();
                BeginContext(679, 13, false);
#line 21 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
                   Write(ViewBag.Error);

#line default
#line hidden
                EndContext();
                BeginContext(692, 30, true);
                WriteLiteral("\r\n                    </div>\r\n");
                EndContext();
#line 23 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
                }

#line default
#line hidden
                BeginContext(741, 726, true);
                WriteLiteral(@"
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
#line 40 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
                     foreach (var d in drzave)
                    {

#line default
#line hidden
                BeginContext(1538, 31, true);
                WriteLiteral("                        <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1569, "\"", 1589, 1);
#line 42 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
WriteAttributeValue("", 1577, d.ID_drzava, 1577, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1590, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1592, 5, false);
#line 42 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
                                                Write(d.Ime);

#line default
#line hidden
                EndContext();
                BeginContext(1597, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 43 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
                    }

#line default
#line hidden
                BeginContext(1631, 1006, true);
                WriteLiteral(@"                </select>

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
            <!-- Default form register -->
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
            BeginContext(2644, 2, true);
            WriteLiteral("\r\n");
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
