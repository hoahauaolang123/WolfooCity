#pragma checksum "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13eecd72307e6c04e38e6c2da47734a6dfbb2046"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Pages_ContentEdit), @"mvc.1.0.razor-page", @"/Areas/Manager/Pages/ContentEdit.cshtml")]
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
#line 1 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\_ViewImports.cshtml"
using Piranha.Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\_ViewImports.cshtml"
using Piranha.Manager.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\_ViewImports.cshtml"
using Piranha.Manager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "~/manager/content/{action}/{contentType}/{id?}/{langId?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13eecd72307e6c04e38e6c2da47734a6dfbb2046", @"/Areas/Manager/Pages/ContentEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178bd1e3bb561a59d5c2cdea0385fcdd05ea76ac", @"/Areas/Manager/Pages/_ViewImports.cshtml")]
    public class Areas_Manager_Pages_ContentEdit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/manager/assets/js/piranha.components.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/manager/assets/js/piranha.contentedit.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partial/_ContentSettings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
  
    ViewBag.Title = "Add/Edit";
    ViewBag.MenuItem = "Add/Edit";
    string action = ((string)RouteData.Values["action"]).ToLower();

    string contentId = RouteData.Values.ContainsKey("id") ? (string)RouteData.Values["id"] : null;
    string languageId = RouteData.Values.ContainsKey("langId") ? (string)RouteData.Values["langId"] : null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("script", async() => {
                WriteLiteral("\n    <script");
                BeginWriteAttribute("src", " src=\"", 506, "\"", 576, 1);
#nullable restore
#line 15 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
WriteAttributeValue("", 512, Url.Content(Piranha.Manager.Editor.EditorScripts.MainScriptUrl), 512, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 599, "\"", 671, 1);
#nullable restore
#line 16 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
WriteAttributeValue("", 605, Url.Content(Piranha.Manager.Editor.EditorScripts.EditorScriptUrl), 605, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13eecd72307e6c04e38e6c2da47734a6dfbb20466758", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13eecd72307e6c04e38e6c2da47734a6dfbb20467855", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
#nullable restore
#line 20 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
     if (action == "edit")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\n            piranha.permissions.load(function () {\n");
#nullable restore
#line 24 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
                 if (languageId != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                piranha.contentedit.load(\"");
#nullable restore
#line 26 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
                                           Write(contentId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"");
#nullable restore
#line 26 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
                                                         Write(languageId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\n");
#nullable restore
#line 27 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
       
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                piranha.contentedit.load(\"");
#nullable restore
#line 31 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
                                           Write(contentId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", null);\n");
#nullable restore
#line 32 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
       
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                $(\".title input\").focus();\n            });\n        </script>\n");
#nullable restore
#line 37 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
    }
    else if (action == "add")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\n            piranha.permissions.load(function () {\n                piranha.contentedit.create(\"");
#nullable restore
#line 42 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
                                       Write(RouteData.Values["contentType"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\n                $(\".title input\").focus();\n            });\n        </script>\n");
#nullable restore
#line 46 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\n");
            DefineSection("partials", async() => {
                WriteLiteral("\n\n");
            }
            );
            WriteLiteral("\n<div id=\"contentedit\">\n    <div class=\"top\">\n        <nav aria-label=\"breadcrumb\">\n            <ol class=\"breadcrumb app\" :class=\"{ ready: !loading }\">\n                <li class=\"breadcrumb-item\">");
#nullable restore
#line 58 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
                                       Write(Localizer.Menu["Content"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                <li class=""breadcrumb-item""><a :href=""piranha.baseUrl + 'manager/content/' + groupId"">{{ groupTitle }}</a></li>
                <li class=""breadcrumb-item"">{{ typeTitle }}</li>
                <li v-if=""state !== 'new'"" class=""breadcrumb-item active"" aria-current=""page"">");
#nullable restore
#line 61 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
                                                                                         Write(Localizer.General["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            </ol>\n        </nav>\n\n        <div class=\"container-fluid app\" :class=\"{ ready: !loading }\">\n            <div class=\"top-nav\">\n");
#nullable restore
#line 67 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
                 foreach (var menuAction in Piranha.Manager.Actions.Toolbars.ContentEdit)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13eecd72307e6c04e38e6c2da47734a6dfbb204613527", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
                       WriteLiteral(menuAction.ActionView);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 70 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>

    <div class=""container-fluid app"" :class=""{ ready: !loading }"">
        <!-- Content navigation -->
        <ul v-if=""editors.length + contentRegions.length > 1"" class=""nav nav-pills nav-pills-card justify-content-center"">
            <li v-for=""editor in editors"" class=""nav-item"">
                <a class=""nav-link"" v-on:click.prevent=""selectRegion(editor)"" :class=""{ active: selectedRegion.uid == editor.uid }"" href=""#"">
                    <i :class=""editor.icon""></i>{{ editor.name }}
                </a>
            </li>
            <li v-for=""region in contentRegions"" class=""nav-item"">
                <a class=""nav-link"" v-on:click.prevent=""selectRegion(region.meta)"" :class=""{ active: selectedRegion.uid == region.meta.uid }"" href=""#"">
                    <i :class=""region.meta.icon""></i>{{ region.meta.name }}
                </a>
            </li>
        </ul>

        <!-- Title -->
        <div class=""card"">
            <div class=""card-body"" :class=""{ '");
            WriteLiteral(@"pb-0': regions.length > 0 }"">
                <div class=""row"">
                    <div class=""col"">
                        <div class=""form-group title"">
                            <input v-model=""title"" type=""text"" class=""form-control form-control-lg""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3760, "\"", 3801, 1);
#nullable restore
#line 96 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
WriteAttributeValue("", 3774, Localizer.General["Title"], 3774, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                </div>
                <div class=""region-center content-center"">
                    <div class=""row"">
                        <div v-if=""usePrimaryImage"" class=""col"">
                            <div class=""form-group"">
                                <label>");
#nullable restore
#line 104 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
                                  Write(Localizer.Content["Primary image"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                <div class=""block image-block primary-image primary-image-modal"">
                                    <div class=""block-body has-media-picker rounded"" :class=""{ empty: primaryImage.id === null }"">
                                        <img class=""rounded"" :src=""primaryImageUrl"">
                                        <div class=""media-picker"">
                                            <div class=""btn-group float-right"">
                                                <button v-on:click.prevent=""selectPrimaryImage"" class=""btn btn-primary text-center"">
                                                    <i class=""fas fa-plus""></i>
                                                </button>
                                                <button v-on:click.prevent=""removePrimaryImage"" class=""btn btn-danger text-center"">
                                                    <i class=""fas fa-times""></i>
                                                </button>
            ");
            WriteLiteral(@"                                </div>
                                            <div class=""card text-left"">
                                                <div class=""card-body"" v-if=""primaryImage.id === null"">
                                                    &nbsp;
                                                </div>
                                                <div class=""card-body"" v-else>
                                                    {{ primaryImage.media.filename }}
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div v-if=""useExcerpt"" class=""col"">
                            <div class=""form-group"">
                                <label>");
#nullable restore
#line 132 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\ContentEdit.cshtml"
                                  Write(Localizer.Content["Excerpt"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                <div v-if=""useHtmlExcerpt"" class=""block text-block ingress"" :class=""{ empty: isExcerptEmpty }"">
                                    <div id=""excerpt-toolbar"" class=""component-toolbar""></div>
                                    <div id=""excerpt-body"" class=""block-body html-block"" contenteditable=""true"" v-html=""excerpt"" v-on:blur=""onExcerptBlur"">
                                    </div>
                                </div>
                                <textarea v-else v-model=""excerpt"" rows=""9"" maxlength=""255"" class=""form-control"" style=""height:218px""></textarea>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Custom Editors -->
        <div class=""card"" :class=""{ 'd-none': selectedRegion.uid != editor.uid }"" v-for=""editor in editors"">
            <div class=""card-body pt-0"">
                <div class=""region-center"">
                    <component ");
            WriteLiteral(@"v-bind:is=""editor.component"" v-bind:uid=""editor.uid"" v-bind:id=""id""></component>
                </div>
            </div>
        </div>

        <!-- Content Regions -->
        <div class=""card"" :class=""{ 'd-none': selectedRegion.uid != region.meta.uid }"" v-for=""region in contentRegions"">
            <div class=""card-body pt-0"">
                <div class=""region region-center"">
                    <region v-bind:content=""'content'"" v-bind:type=""typeId"" v-bind:model=""region""></region>
                    <div class=""content-blocker""></div>
                </div>
            </div>
        </div>
    </div>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13eecd72307e6c04e38e6c2da47734a6dfbb204621700", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ManagerLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentListViewModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContentListViewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContentListViewModel>)PageContext?.ViewData;
        public ContentListViewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
