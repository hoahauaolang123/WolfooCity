#pragma checksum "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "264c05c2795096f0076b6375cefb8dffc9bfbd86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Pages_Login), @"mvc.1.0.razor-page", @"/Areas/Manager/Pages/Login.cshtml")]
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
#line 1 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\_ViewImports.cshtml"
using Piranha.Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\_ViewImports.cshtml"
using Piranha.Manager.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\_ViewImports.cshtml"
using Piranha.Manager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "~/manager/login")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"264c05c2795096f0076b6375cefb8dffc9bfbd86", @"/Areas/Manager/Pages/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178bd1e3bb561a59d5c2cdea0385fcdd05ea76ac", @"/Areas/Manager/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manager_Pages_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manager/assets/css/slim.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
  
    Layout = null;
    var module = Piranha.App.Modules.Get<Piranha.Manager.Module>();
    var prerelease = Piranha.Utils.IsPreRelease(typeof(Piranha.Manager.Module).Assembly) ? "pre-release" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!doctype html>\n<html lang=\"en\" style=\"min-height:100%\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "264c05c2795096f0076b6375cefb8dffc9bfbd866785", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "264c05c2795096f0076b6375cefb8dffc9bfbd867173", async() => {
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
                WriteLiteral("\n");
#nullable restore
#line 16 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
     foreach (var style in module.Styles) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <link");
                BeginWriteAttribute("href", " href=\"", 589, "\"", 615, 1);
#nullable restore
#line 17 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
WriteAttributeValue("", 596, Url.Content(style), 596, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\n");
#nullable restore
#line 18 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <title>");
#nullable restore
#line 20 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
      Write(Localizer.General["Login"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "264c05c2795096f0076b6375cefb8dffc9bfbd8610152", async() => {
                WriteLiteral("\n");
#nullable restore
#line 23 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
     if (!string.IsNullOrEmpty(prerelease))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"pre-release\">Pre-release</div>\n");
#nullable restore
#line 26 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"container\">\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "264c05c2795096f0076b6375cefb8dffc9bfbd8610928", async() => {
                    WriteLiteral("\n            <div");
                    BeginWriteAttribute("class", " class=\"", 965, "\"", 1036, 3);
                    WriteAttributeValue("", 973, "card", 973, 4, true);
                    WriteAttributeValue(" ", 977, "card-login", 978, 11, true);
#nullable restore
#line 29 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
WriteAttributeValue(" ", 988, !Model.ModelState.IsValid ? "has-error" : "", 989, 47, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                <div class=\"card-body card-body-logo\">\n                    <div class=\"logo\"></div>\n                    <p class=\"banner\">\n                        Piranha CMS\n                        <small>");
#nullable restore
#line 34 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
                          Write(Localizer.General["Version"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 34 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
                                                        Write(Piranha.Utils.GetAssemblyVersion(typeof(Piranha.Manager.Module).Assembly));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</small>\n                    </p>\n                </div>\n\n");
#nullable restore
#line 38 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
                 if (!Model.ModelState.IsValid)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <p class=\"error-message\">");
#nullable restore
#line 40 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
                                        Write(string.Join("\r\n", ModelState.SelectMany(p => p.Value.Errors).Select(e => e.ErrorMessage)));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\n");
#nullable restore
#line 41 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\n                <div class=\"card-body card-body-form\">\n                    <div class=\"form-group\">\n                        <label for=\"username\" class=\"col-form-label col-form-label-lg\">");
#nullable restore
#line 45 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
                                                                                  Write(Localizer.General["Username"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\n                        <input autofocus id=\"username\" required name=\"username\" type=\"text\" class=\"form-control form-control-lg text-center\"");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 2000, "\"", 2060, 1);
#nullable restore
#line 46 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
WriteAttributeValue("", 2014, Localizer.General["Username"].Value.ToLower(), 2014, 46, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                    </div>\n                    <div class=\"form-group\">\n                        <label for=\"password\" class=\"col-form-label col-form-label-lg\">");
#nullable restore
#line 49 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
                                                                                  Write(Localizer.General["Password"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\n                        <input name=\"password\" required type=\"password\" class=\"form-control form-control-lg text-center\"");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 2381, "\"", 2441, 1);
#nullable restore
#line 50 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
WriteAttributeValue("", 2395, Localizer.General["Password"].Value.ToLower(), 2395, 46, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                    </div>\n                    <button class=\"btn btn-lg btn-block btn-primary\" type=\"submit\">\n                        <i class=\"fas fa-check\"></i>\n                    </button>\n                </div>\n            </div>\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>
    <script>
        (function () {
            'use strict';
            window.addEventListener('load', function () {
                var forms = document.getElementsByClassName('needs-validation');
                var validation = Array.prototype.filter.call(forms, function (form) {
                    form.addEventListener('submit', function (event) {
                        if (form.checkValidity() === false) {
                            event.preventDefault();
                            event.stopPropagation();
                        }
                        form.classList.add('was-validated');
                    }, false);
                });
            }, false);
        })();
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 22 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Login.cshtml"
AddHtmlAttributeValue("", 739, prerelease, 739, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ManagerLocalizer Localizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel>)PageContext?.ViewData;
        public LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
