#pragma checksum "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Dodaj.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58a0688ddf21775d60f2e62ff6a52cfc3a3067c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Dodaj), @"mvc.1.0.view", @"/Views/Dashboard/Dodaj.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Dodaj.cshtml", typeof(AspNetCore.Views_Dashboard_Dodaj))]
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
#line 5 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Dodaj.cshtml"
using BetTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a0688ddf21775d60f2e62ff6a52cfc3a3067c0", @"/Views/Dashboard/Dodaj.cshtml")]
    public class Views_Dashboard_Dodaj : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Dodaj.cshtml"
  
    Layout = "~/Views/Dashboard/headerdashboard.cshtml";

#line default
#line hidden
            BeginContext(93, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(122, 928, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52cdac8766334811989e49e3c987dea9", async() => {
                BeginContext(128, 915, true);
                WriteLiteral(@"

    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"" crossorigin=""anonymous""></script>


    <meta name=""viewport"" content=""width=device-width"" />
    <title>Domov</title>
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
            BeginContext(1050, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Dodaj.cshtml"
   
    var data = ViewBag.Message;

#line default
#line hidden
            BeginContext(1093, 2161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b349c4f8263431381a0c9f26c722779", async() => {
                BeginContext(1099, 33, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n\r\n");
                EndContext();
#line 27 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Dodaj.cshtml"
          
            if (data != null)
            {

#line default
#line hidden
                BeginContext(1190, 70, true);
                WriteLiteral("                <div class=\"alert alert-danger\">\r\n                    ");
                EndContext();
                BeginContext(1261, 4, false);
#line 31 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Dodaj.cshtml"
               Write(data);

#line default
#line hidden
                EndContext();
                BeginContext(1265, 26, true);
                WriteLiteral("\r\n                </div>\r\n");
                EndContext();
#line 33 "D:\projects\novo\BettingTracker\BetTracker\Views\Dashboard\Dodaj.cshtml"
            }
        

#line default
#line hidden
                BeginContext(1317, 1930, true);
                WriteLiteral(@"       
        <form action=""VnesiStavo"" method=""post"" id=""vnos"">
            <div class=""form-group"">
                <label>Home team:</label>
                <input type=""text"" name=""domaca_ekipa"" class=""form-control"" id=""domaca_ekipa"">
            </div>

            <div class=""form-group"">
                <label>Away team:</label>
                <input type=""text"" name=""gostujoca_ekipa"" class=""form-control"" id=""gostujoca_ekipa"">
            </div>

            <div class=""form-group"">
                <label>Type of sport:</label>
                <select class=""form-control"" name=""sport"" id=""sport"">
                    <option value=""1"">Football</option>
                    <option value=""2"">Basketball</option>
                    <option value=""3"">Tennis</option>
                    <option value=""4"">E-sport</option>
                    <option value=""5"">Ice hokey</option>
                </select>
            </div>

            <div class=""form-group"">
                <label>");
                WriteLiteral(@"Multiplier:</label>
                <input type=""text"" name=""kvota"" class=""form-control"" id=""kvota"">
            </div>

            <div class=""form-group"">
                <label>How much money:</label>
                <input type=""text"" name=""stava"" class=""form-control"" id=""stava"">
            </div>

            <div class=""form-group"">
                <label>Pick:</label>
                <input type=""text"" name=""izbera"" class=""form-control"" id=""izbera"">
            </div>

            <div class=""form-group"">
                <label>Status:</label>
                <select class=""form-control"" name=""status"" id=""status"">
                    <option value=""1"">Won</option>
                    <option value=""2"">Lost</option>
                </select>
            </div>

            <button type=""submit"" class=""btn btn-primary"">Submit</button>
        </form>
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
            BeginContext(3254, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
