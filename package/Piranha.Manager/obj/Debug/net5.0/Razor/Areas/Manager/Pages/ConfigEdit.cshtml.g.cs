#pragma checksum "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24054bbb4748c5ea893dbd611a0fded35d3ec432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Pages_ConfigEdit), @"mvc.1.0.razor-page", @"/Areas/Manager/Pages/ConfigEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "~/manager/config")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24054bbb4748c5ea893dbd611a0fded35d3ec432", @"/Areas/Manager/Pages/ConfigEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178bd1e3bb561a59d5c2cdea0385fcdd05ea76ac", @"/Areas/Manager/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manager_Pages_ConfigEdit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/manager/assets/js/piranha.config.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
  
    ViewBag.Title = Localizer.Config["Config"];
    ViewBag.MenuItem = "Config";

#line default
#line hidden
#nullable disable
            DefineSection("script", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24054bbb4748c5ea893dbd611a0fded35d3ec4324938", async() => {
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
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n<div id=\"config\">\n    <div class=\"top\">\n        <nav aria-label=\"breadcrumb\">\n            <ol class=\"breadcrumb\">\n                <li class=\"breadcrumb-item\">");
#nullable restore
#line 18 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                       Write(Localizer.Menu["System"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 19 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                                  Write(Localizer.Menu["Config"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            </ol>\n        </nav>\n\n        <div class=\"container-fluid\">\n            <div class=\"top-nav\">\n");
#nullable restore
#line 25 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                 foreach (var action in Piranha.Manager.Actions.Toolbars.ConfigEdit)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "24054bbb4748c5ea893dbd611a0fded35d3ec4327327", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                       WriteLiteral(action.ActionView);

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
#line 28 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n\n    <div class=\"container-fluid mb-3 app\" :class=\"{ ready: !loading }\">\n        <div class=\"card\">\n            <div class=\"card-header\">\n                <span class=\"title\">");
#nullable restore
#line 36 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.General["General"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <div class=""card-body"">
                <ul class=""list-group list-group-flush"">
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 43 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Expanded levels in the sitemap"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 45 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["The default number of levels that should be expanded in the page sitemap. This is useful for smaller sitemaps."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <input v-model=""model.expandedSitemapLevels"" class=""form-control"" type=""number"">
                            </div>
                        </div>
                    </li>
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 56 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Manager list size"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 58 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["The page size for lists within the manager interface."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <input v-model=""model.managerPageSize"" class=""form-control"" type=""number"">
                            </div>
                        </div>
                    </li>
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 69 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Hierarchical page slugs"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 71 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["If page slugs should take their parent slug into account when being generated. This is prefered for larger sitemaps."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <button v-on:click.prevent=""model.hierarchicalPageSlugs = !model.hierarchicalPageSlugs"" class=""switch switch-lg"" :aria-pressed=""model.hierarchicalPageSlugs""><span></span></button>
                            </div>
                        </div>
                    </li>
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 82 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Collapse blocks"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 84 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["If blocks should be collapsed by default when opening a page or post in the manager."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <button v-on:click.prevent=""model.defaultCollapsedBlocks = !model.defaultCollapsedBlocks"" class=""switch switch-lg"" :aria-pressed=""model.defaultCollapsedBlocks""><span></span></button>
                            </div>
                        </div>
                    </li>
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 95 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Collapse block headers"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">");
#nullable restore
#line 96 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                        Write(Localizer.Config["If block group headers should be collapsed by default when opening a page or post in the manager."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <div class=""col-md-4"">
                                <button v-on:click.prevent=""model.defaultCollapsedBlockGroupHeaders = !model.defaultCollapsedBlockGroupHeaders"" class=""switch switch-lg"" :aria-pressed=""model.defaultCollapsedBlockGroupHeaders""><span></span></button>
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-header"">
                <span class=""title"">");
#nullable restore
#line 109 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.General["Archives and Comments"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <div class=""card-body"">
                <ul class=""list-group list-group-flush"">
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 116 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Archive page size"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 118 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["The default page size for archive pages. Please note that this this can be overridden for specific archives."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <input v-model=""model.archivePageSize"" class=""form-control"" type=""number"">
                            </div>
                        </div>
                    </li>
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 129 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Close comments after"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 131 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["The number of days commenting should be open after publish date. A value of 0 means forever."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <input v-model=""model.commentsCloseAfterDays"" class=""form-control"" type=""number"">
                            </div>
                        </div>
                    </li>
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 142 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Comments page size"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 144 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["The default page size when loading comments. Please note that this this can be overridden for specific pages."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <input v-model=""model.commentsPageSize"" class=""form-control"" type=""number"">
                            </div>
                        </div>
                    </li>
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 155 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Enable post comments"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 157 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["If comments should be enabled for posts by default. Please note that this this can be overridden for specific posts."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <button v-on:click.prevent=""model.commentsEnabledForPosts = !model.commentsEnabledForPosts"" class=""switch switch-lg"" :aria-pressed=""model.commentsEnabledForPosts""><span></span></button>
                            </div>
                        </div>
                    </li>
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 168 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Enable page comments"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 170 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["If comments should be enabled for pages by default. Please note that this this can be overridden for specific pages."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <button v-on:click.prevent=""model.commentsEnabledForPages = !model.commentsEnabledForPages"" class=""switch switch-lg"" :aria-pressed=""model.commentsEnabledForPages""><span></span></button>
                            </div>
                        </div>
                    </li>
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 181 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Approve comments"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 183 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["If comments should be approved by default. Please note that this can be overridden by third party moderation services."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <button v-on:click.prevent=""model.commentsApprove = !model.commentsApprove"" class=""switch switch-lg"" :aria-pressed=""model.commentsApprove""><span></span></button>
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-header"">
                <span class=""title"">");
#nullable restore
#line 197 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.General["History"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <div class=""card-body"">
                <ul class=""list-group list-group-flush"">
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 204 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Page revisions"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 206 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["The maximum number of page revisions that should be stored for each page. A value of 0 means no limitation."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <input v-model=""model.pageRevisions"" class=""form-control"" type=""number"">
                            </div>
                        </div>
                    </li>
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 217 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Post revisions"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 219 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["The maximum number of post revisions that should be stored for each post. A value of 0 means no limitation."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <input v-model=""model.postRevisions"" class=""form-control"" type=""number"">
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-header"">
                <span class=""title"">");
#nullable restore
#line 233 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["Caching"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <div class=""card-body"">
                <ul class=""list-group list-group-flush"">
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 240 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Page cache expiration (minutes)"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 242 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["The time in minutes that web browsers can use pages before asking the server for new updates."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <input v-model=""model.pagesExpires"" class=""form-control"" type=""number"">
                            </div>
                        </div>
                    </li>
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 253 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Post cache expiration (minutes)"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 255 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["The time in minutes that web browsers can use posts before asking the server for new updates."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <input v-model=""model.postsExpires"" class=""form-control"" type=""number"">
                            </div>
                        </div>
                    </li>
                    <li class=""list-group-item"">
                        <div class=""row align-items-end"">
                            <div class=""col-md-8"">
                                <strong class=""d-block"">");
#nullable restore
#line 266 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                                                   Write(Localizer.Config["Media CDN"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                <span class=\"text-secondary\">\n                                    ");
#nullable restore
#line 268 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\ConfigEdit.cshtml"
                               Write(Localizer.Config["The full URL (including any folder name) to the CDN used to serve uploaded media. Leave blank to use default storage URL."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""col-md-4"">
                                <input v-model=""model.mediaCDN"" class=""form-control"" type=""text"">
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ManagerLocalizer Localizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService Auth { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfigEditViewModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfigEditViewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfigEditViewModel>)PageContext?.ViewData;
        public ConfigEditViewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
