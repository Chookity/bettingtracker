#pragma checksum "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faf79b6c1e818549b54d725463aedf8afbe0030b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faf79b6c1e818549b54d725463aedf8afbe0030b", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(2, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e1d75626732442fbf03a78b79ad3f0a", async() => {
                BeginContext(8, 7, true);
                WriteLiteral("\r\n   \r\n");
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
            BeginContext(22, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Login.cshtml"
  
    Layout = "headerhome.cshtml";
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(104, 2007, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05ad9c839b64ebf97bae0969661ce49", async() => {
                BeginContext(110, 417, true);
                WriteLiteral(@"
    
    <div class=""container"">
        <div class=""bg-light text-dark"" style=""padding: 30px; border-radius: 20px; min-height: 90%;"">
            <!-- Default form login -->
            <div class=""row"" style=""justify-content:center"">
                <form class=""text-center border border-light p-5"" action=""Login"" method=""post"" style=""width: 500px"">

                    <p class=""h4 mb-4"">Prijava</p>

");
                EndContext();
#line 21 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Login.cshtml"
                     if (ViewBag.Success != null)
                    {

#line default
#line hidden
                BeginContext(601, 100, true);
                WriteLiteral("                        <div class=\"alert alert-success\" role=\"alert\">\r\n                            ");
                EndContext();
                BeginContext(702, 15, false);
#line 24 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Login.cshtml"
                       Write(ViewBag.Success);

#line default
#line hidden
                EndContext();
                BeginContext(717, 85, true);
                WriteLiteral("\r\n                            ,prijavite se spodaj!\r\n                        </div>\r\n");
                EndContext();
#line 27 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Login.cshtml"
                    }

#line default
#line hidden
                BeginContext(825, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 29 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Login.cshtml"
                     if (ViewBag.Error == "Napačno uporabniško ime ali geslo")
                    {

#line default
#line hidden
                BeginContext(930, 99, true);
                WriteLiteral("                        <div class=\"alert alert-danger\" role=\"alert\">\r\n                            ");
                EndContext();
                BeginContext(1030, 13, false);
#line 32 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Login.cshtml"
                       Write(ViewBag.Error);

#line default
#line hidden
                EndContext();
                BeginContext(1043, 34, true);
                WriteLiteral("\r\n                        </div>\r\n");
                EndContext();
#line 34 "D:\projects\novo\BettingTracker\BetTracker\Views\Home\Login.cshtml"
                    }

#line default
#line hidden
                BeginContext(1100, 1004, true);
                WriteLiteral(@"
                    <!-- Email -->
                    <input type=""text"" id=""email"" name=""email"" class=""form-control mb-4"" placeholder=""E-mail"">

                    <!-- Password -->
                    <input type=""password"" name=""geslo"" id=""geslo"" class=""form-control mb-4"" placeholder=""Geslo"">

                    <div class=""d-flex justify-content-around"">
                        <div>
                            <!-- Forgot password -->
                            <a href="""">Ste pozabili geslo?</a>
                        </div>
                    </div>

                    <!-- Sign in button -->
                    <button class=""btn btn-info btn-block my-4"" type=""submit"">Prijavi se</button>

                    <!-- Register -->
                    <p>
                        Nimate računa?
                        <a href=""/Home/Registracija"">Registracija</a>
                    </p>
                </form>
            </div>
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
            BeginContext(2111, 2, true);
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
