#pragma checksum "C:\Users\vakidev\Documents\TelefonRehberiProje\TelefonRehberi\TelefonRehberi.WebUI\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "662850162a945063770f6615b0445e61b5794d3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
#nullable restore
#line 1 "C:\Users\vakidev\Documents\TelefonRehberiProje\TelefonRehberi\TelefonRehberi.WebUI\Views\_ViewImports.cshtml"
using TelefonRehberi.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vakidev\Documents\TelefonRehberiProje\TelefonRehberi\TelefonRehberi.WebUI\Views\_ViewImports.cshtml"
using TelefonRehberi.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"662850162a945063770f6615b0445e61b5794d3a", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3aca4b09811d6d9b129bb6bc2afad2086d7407", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662850162a945063770f6615b0445e61b5794d3a4260", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 193, "\"", 203, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""author"" content=""Mark Otto, Jacob Thornton, and Bootstrap contributors"">
    <meta name=""generator"" content=""Jekyll v3.8.6"">
    <title>Dashboard Template · Bootstrap</title>

    <link rel=""canonical"" href=""https://getbootstrap.com/docs/4.4/examples/dashboard/"">

    <!-- Bootstrap core CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
    <!-- Favicons -->
    <link rel=""apple-touch-icon"" href=""/docs/4.4/assets/img/favicons/apple-touch-icon.png"" sizes=""180x180"">
    <link rel=""icon"" href=""/docs/4.4/assets/img/favicons/favicon-32x32.png"" sizes=""32x32"" type=""image/png"">
    <link rel=""icon"" href=""/docs/4.4/assets/img/favicons/favicon-16x16.png"" sizes=""16x16"" type=""image/png"">
    <link rel=""manifest"" href=""/docs/4.4/assets/img/favicons/manifest.json"">
    <link rel=""mask-icon"" href=""/docs/4.4/assets/img/fav");
                WriteLiteral(@"icons/safari-pinned-tab.svg"" color=""#563d7c"">
    <link rel=""icon"" href=""/docs/4.4/assets/img/favicons/favicon.ico"">
    <meta name=""msapplication-config"" content=""/docs/4.4/assets/img/favicons/browserconfig.xml"">
    <meta name=""theme-color"" content=""#563d7c"">


    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "662850162a945063770f6615b0445e61b5794d3a6233", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.4.1.js""
            integrity=""sha256-WpOohJOqMqqyKL9FccASB9O0KwACQJpFTUBLTYOVvVU=""
            crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.20/css/jquery.dataTables.css"">

    <script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.20/js/jquery.dataTables.js""></script>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662850162a945063770f6615b0445e61b5794d3a8556", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-dark fixed-top bg-dark flex-md-nowrap p-0 shadow"">
        <a class=""navbar-brand col-sm-3 col-md-2 mr-0"" href=""#"">Telefon Rehberi Admin</a>
       
        <ul class=""navbar-nav px-3"">
            <li class=""nav-item text-nowrap"">
                <a class=""nav-link"" href=""#"">Sign out</a>
            </li>
        </ul>
    </nav>

    <div class=""container-fluid"">
        <div class=""row"">
            <nav class=""col-md-2 d-none d-md-block bg-light sidebar"">
                <div class=""sidebar-sticky"">
                    <ul class=""nav flex-column"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Index"">
                                <span data-feather=""home""></span>
                                Anasayfa <span class=""sr-only"">(current)</span>
                            </a>
                        </li>
                      
                       
                        <li class");
                WriteLiteral(@"=""nav-item"">
                            <a class=""nav-link"" href=""/Calisan/Index"">
                                <span data-feather=""users""></span>
                                Çalışan
                            </a>
                        </li>
                       
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Departman/Index"">
                                <span data-feather=""layers""></span>
                                Departman
                            </a>
                        </li>
                    </ul>

                   
                </div>
            </nav>

            <main role=""main"" class=""col-md-9 ml-sm-auto col-lg-10 px-4"">
");
#nullable restore
#line 79 "C:\Users\vakidev\Documents\TelefonRehberiProje\TelefonRehberi\TelefonRehberi.WebUI\Views\Shared\_AdminLayout.cshtml"
                if (TempData["message"] != null)
               {

#line default
#line hidden
#nullable disable
                WriteLiteral("                   <div class=\"alert alert-success\">\r\n                       ");
#nullable restore
#line 82 "C:\Users\vakidev\Documents\TelefonRehberiProje\TelefonRehberi\TelefonRehberi.WebUI\Views\Shared\_AdminLayout.cshtml"
                  Write(TempData["message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                   </div>\r\n");
#nullable restore
#line 84 "C:\Users\vakidev\Documents\TelefonRehberiProje\TelefonRehberi\TelefonRehberi.WebUI\Views\Shared\_AdminLayout.cshtml"
               }

#line default
#line hidden
#nullable disable
                WriteLiteral("               ");
#nullable restore
#line 85 "C:\Users\vakidev\Documents\TelefonRehberiProje\TelefonRehberi\TelefonRehberi.WebUI\Views\Shared\_AdminLayout.cshtml"
          Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </main>\r\n        </div>\r\n    </div>\r\n   \r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
