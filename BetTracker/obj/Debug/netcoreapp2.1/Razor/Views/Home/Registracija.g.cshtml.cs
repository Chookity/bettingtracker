#pragma checksum "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Home\Registracija.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9677e69f48a0ab72fd1b935c7ce2bc1fbf938c0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9677e69f48a0ab72fd1b935c7ce2bc1fbf938c0", @"/Views/Home/Registracija.cshtml")]
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
#line 2 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
  
    Layout = "headerhome.cshtml";
    ViewData["Title"] = "Registracija";

#line default
#line hidden
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(87, 2087, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c96e866106a24dfcb42a5b48b71fa934", async() => {
                BeginContext(93, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
      
        var drzave = ViewBag.Drzava;
    

#line default
#line hidden
                BeginContext(148, 953, true);
                WriteLiteral(@"    <div class=""container"" style=""display: flex; justify-content: center"">
        <!-- Default form register -->
        <form class=""text-center border border-light p-5"" action=""Vstavi"" method=""post"" style=""width: 900px;"">

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
#line 32 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
                 foreach (var d in drzave)
                {

#line default
#line hidden
                BeginContext(1164, 27, true);
                WriteLiteral("                    <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1191, "\"", 1211, 1);
#line 34 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
WriteAttributeValue("", 1199, d.ID_drzava, 1199, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1212, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1214, 5, false);
#line 34 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
                                            Write(d.Ime);

#line default
#line hidden
                EndContext();
                BeginContext(1219, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 35 "E:\FRI\2.letnik\2.semester\Uporabniški vmesniki\projekt\BettingTrackerReal\BettingTracker\BetTracker\Views\Home\Registracija.cshtml"
                }

#line default
#line hidden
                BeginContext(1249, 918, true);
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
        <!-- Default form register -->
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
            BeginContext(2174, 2, true);
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
