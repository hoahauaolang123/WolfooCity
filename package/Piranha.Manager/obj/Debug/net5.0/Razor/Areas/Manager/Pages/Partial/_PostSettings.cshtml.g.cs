#pragma checksum "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4838803192adae2f05e3e92fd9836d618cc14905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Pages_Partial__PostSettings), @"mvc.1.0.view", @"/Areas/Manager/Pages/Partial/_PostSettings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4838803192adae2f05e3e92fd9836d618cc14905", @"/Areas/Manager/Pages/Partial/_PostSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178bd1e3bb561a59d5c2cdea0385fcdd05ea76ac", @"/Areas/Manager/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manager_Pages_Partial__PostSettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("route"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("route in routes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-if", new global::Microsoft.AspNetCore.Html.HtmlString("redirectUrl !== null && redirectUrl.length > 0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Permanent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Temporary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""postSettings"" class=""modal modal-panel fade"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <!-- Header -->
            <div class=""modal-header border-bottom-0"">
                <h5 class=""modal-title""><i class=""fas fa-cog""></i> ");
#nullable restore
#line 8 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                                              Write(Localizer.General["Settings"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <!-- Tabs -->
            <ul class=""nav nav-tabs"" role=""tablist"">
                <li class=""nav-item"">
                    <a href=""#"" class=""nav-link"" :class=""{ active: selectedSetting === 'uid-settings' }"" v-on:click.prevent=""selectSetting('uid-settings')"">");
#nullable restore
#line 17 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                                                                                                                                       Write(Localizer.General["General"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </li>\n                <li class=\"nav-item\">\n                    <a href=\"#\" class=\"nav-link\" :class=\"{ active: selectedSetting === \'uid-seo\' }\" v-on:click.prevent=\"selectSetting(\'uid-seo\')\">");
#nullable restore
#line 20 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                                                                                                                             Write(Localizer.General["SEO"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </li>\n                <li class=\"nav-item\">\n                    <a href=\"#\" class=\"nav-link\" :class=\"{ active: selectedSetting === \'uid-sharing\' }\" v-on:click.prevent=\"selectSetting(\'uid-sharing\')\">");
#nullable restore
#line 23 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                                                                                                                                     Write(Localizer.General["Sharing"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </li>\n                <li class=\"nav-item\">\n                    <a href=\"#\" class=\"nav-link\" :class=\"{ active: selectedSetting === \'uid-advanced\' }\" v-on:click.prevent=\"selectSetting(\'uid-advanced\')\">");
#nullable restore
#line 26 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                                                                                                                                       Write(Localizer.General["Advanced"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                </li>
                <li class=""nav-item"" v-for=""region in settingRegions"">
                    <a href=""#"" class=""nav-link"" :class=""{ active: selectedSetting === region.meta.uid }"" v-on:click.prevent=""selectSetting(region.meta.uid)"">{{ region.meta.name }}</a>
                </li>
            </ul>

            <!-- Body -->
            <div class=""modal-body bg-light"">
                <div :class=""{ 'd-none': selectedSetting != 'uid-settings' }"">
                    <div class=""form-group"" v-if=""usePrimaryImage"">
                        <label>");
#nullable restore
#line 37 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
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
                                    </div>
                                    <div class=""card text");
            WriteLiteral(@"-left"">
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
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 63 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                          Write(Localizer.General["Slug"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <div class=""input-group"">
                            <input v-model=""slug"" type=""text"" maxlength=""128"" class=""form-control"">
                            <div class=""input-group-append"">
                                <div class=""input-group-text text-muted"">
                                    {{ piranha.utils.strLength(slug) + ""/128"" }}
                                </div>
                            </div>
                        </div>
                        <span class=""field-description small text-muted"">
                            http://localhost:5000/<span v-text=""slug""></span>
                        </span>
                    </div>
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 77 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                          Write(Localizer.General["Publish date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <div class=""row"">
                            <div class=""col"">
                                <datepicker v-model=""published"" :format=""'yyyy-MM-dd'"" :monday-first=""true"" :typeable=""true"" :bootstrap-styling=""true""></datepicker>
                            </div>
                            <div class=""col""></div>
                        </div>
                    </div>
                    <div class=""form-group"" v-if=""useExcerpt"">
                        <label>");
#nullable restore
#line 86 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
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
                        <textarea v-else v-model=""excerpt"" rows=""5"" maxlength=""255"" class=""form-control""></textarea>
                    </div>
                </div>

                <div :class=""{ 'd-none': selectedSetting != 'uid-seo' }"">
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 98 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                          Write(Localizer.Page["Meta title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <div class=""input-group"">
                            <input v-model=""metaTitle"" type=""text"" maxlength=""128"" class=""form-control"" :placeholder=""title"">
                            <div class=""input-group-append"">
                                <div class=""input-group-text text-muted"">
                                    {{ piranha.utils.strLength(metaTitle) + ""/128"" }}
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 109 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                          Write(Localizer.Page["Meta keywords"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <div class=""input-group"">
                            <input v-model=""metaKeywords"" type=""text"" maxlength=""128"" class=""form-control"">
                            <div class=""input-group-append"">
                                <div class=""input-group-text text-muted"">
                                    {{ piranha.utils.strLength(metaKeywords) + ""/128"" }}
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 120 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                          Write(Localizer.Page["Meta description"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <div class=""input-group"">
                            <textarea v-model=""metaDescription"" rows=""5"" maxlength=""255"" class=""form-control""></textarea>
                            <div class=""input-group-append"">
                                <div class=""input-group-text text-muted"">
                                    {{ piranha.utils.strLength(metaDescription) + ""/255"" }}
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""metaIndex"">");
#nullable restore
#line 131 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                          Write(Localizer.Content["Meta index"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <div class=""form-switch"">
                            <button id=""metaIndex"" v-on:click.prevent=""metaIndex = !metaIndex"" class=""switch"" :aria-pressed=""metaIndex""><span></span></button>
                            <label for=""metaIndex"" class=""form-check-label"">");
#nullable restore
#line 134 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                                                       Write(Localizer.Post["If the post should be indexed by search engines."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        </div>\n                    </div>\n                    <div class=\"form-group\">\n                        <label for=\"metaFollow\">");
#nullable restore
#line 138 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                           Write(Localizer.Content["Meta follow"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <div class=""form-switch"">
                            <button id=""metaFollow"" v-on:click.prevent=""metaFollow = !metaFollow"" class=""switch"" :aria-pressed=""metaFollow""><span></span></button>
                            <label for=""metaFollow"" class=""form-check-label"">");
#nullable restore
#line 141 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                                                        Write(Localizer.Post["If links from this post should be indexed."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        </div>\n                    </div>\n                    <div class=\"form-group\">\n                        <div class=\"d-flex\">\n                            <label><strong>");
#nullable restore
#line 146 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                      Write(Localizer.Content["Meta priority"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></label>
                            <span class=""ml-auto"">{{ metaPriorityDescription }}</span>
                        </div>
                        <input v-model=""metaPriority"" type=""range""  class=""custom-range"" min=""0"" max=""1"" step=""0.1"">
                        <small>");
#nullable restore
#line 150 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                          Write(Localizer.Content["Search engine priority, compared to other content in the same site."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n                    </div>\n                </div>\n\n                <div :class=\"{ \'d-none\': selectedSetting != \'uid-sharing\' }\">\n                    <div class=\"form-group\">\n                        <label>");
#nullable restore
#line 156 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                          Write(Localizer.Page["Og title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <div class=""input-group"">
                            <input v-model=""ogTitle"" type=""text"" maxlength=""128"" class=""form-control"" :placeholder=""metaTitle !== null && metaTitle !== '' ? metaTitle : title"">
                            <div class=""input-group-append"">
                                <div class=""input-group-text text-muted"">
                                    {{ piranha.utils.strLength(ogTitle) + ""/128"" }}
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 167 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                          Write(Localizer.Page["Og image"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        <image-field v-bind:uid=\"\'og_image_\' + id\" v-bind:meta=\"{ placeholder: null }\" v-bind:model=\"ogImage\"></image-field>\n                    </div>\n                    <div class=\"form-group\">\n                        <label>");
#nullable restore
#line 171 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                          Write(Localizer.Page["Og description"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <div class=""input-group"">
                            <textarea v-model=""ogDescription"" rows=""5"" maxlength=""255"" class=""form-control"" :placeholder=""metaDescription""></textarea>
                            <div class=""input-group-append"">
                                <div class=""input-group-text text-muted"">
                                    {{ piranha.utils.strLength(ogDescription) + ""/255"" }}
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div :class=""{ 'd-none': selectedSetting != 'uid-advanced' }"">
                    <div class=""form-group"">
                        <label for=""enableComments"">");
#nullable restore
#line 185 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                               Write(Localizer.General["Comments"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <div class=""form-switch"">
                            <button id=""enableComments"" v-on:click.prevent=""enableComments = !enableComments"" class=""switch"" :aria-pressed=""enableComments""><span></span></button>
                            <label for=""enableComments"" class=""form-check-label"">");
#nullable restore
#line 188 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                                                            Write(Localizer.Post["If comments should be enabled for this post"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        </div>\n                    </div>\n                    <div class=\"form-group\">\n                        <label>");
#nullable restore
#line 192 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                          Write(Localizer.Comment["Days allowed for commenting"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        <input type=\"number\" v-model.number=\"closeCommentsAfterDays\" class=\"form-control\">\n                        <span v-if=\"enableComments === false\" class=\"field-description small text-muted\">\n                            ");
#nullable restore
#line 195 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                       Write(Localizer.Comment["Comments are not allowed."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </span>\n                        <span v-else-if=\"published === null\" class=\"field-description small text-muted\">\n                            ");
#nullable restore
#line 198 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                       Write(Localizer.Comment["Comments are not allowed for unpublished content."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </span>\n                        <span v-else-if=\"closeCommentsAfterDays === 0 || isCommentsOpen()\" class=\"field-description small text-muted\">\n                            ");
#nullable restore
#line 201 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                       Write(Localizer.Comment["Comments are currently open."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </span>\n                        <span v-else class=\"field-description small text-muted\">\n                            ");
#nullable restore
#line 204 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                       Write(Localizer.Comment["Comments were closed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" {{ commentsClosedDate() }}.\n                        </span>\n                    </div>\n                    <div class=\"form-group\" v-if=\"routes && routes.length > 1\">\n                        <label>");
#nullable restore
#line 208 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                          Write(Localizer.General["Route"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        <select v-model=\"selectedRoute\" class=\"form-control\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4838803192adae2f05e3e92fd9836d618cc1490527129", async() => {
                WriteLiteral("{{ route.title }}");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </select>\n                    </div>\n                    <div class=\"form-group\">\n                        <label>");
#nullable restore
#line 214 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                          Write(Localizer.General["Redirect"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <div class=""input-group"">
                            <input v-model=""redirectUrl"" type=""text"" maxlength=""256"" class=""form-control"">
                            <div class=""input-group-append"">
                                <div class=""input-group-text text-muted"">
                                    {{ piranha.utils.strLength(redirectUrl) + ""/256"" }}
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 225 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                          Write(Localizer.General["Redirect Type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        <select v-model=\"redirectType\" class=\"form-control\" :disabled=\"redirectUrl === null || redirectUrl.length === 0\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4838803192adae2f05e3e92fd9836d618cc1490529739", async() => {
#nullable restore
#line 227 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                                                                                       Write(Localizer.General["Permanent"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4838803192adae2f05e3e92fd9836d618cc1490531218", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("v-else", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4838803192adae2f05e3e92fd9836d618cc1490532672", async() => {
#nullable restore
#line 228 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                                                                                                       Write(Localizer.General["Temporary"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4838803192adae2f05e3e92fd9836d618cc1490534151", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("v-else", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
                    <div v-if=""permissions.length > 0"" class=""row"">
                        <div class=""col"">
                            <div class=""form-group"">
                            <label>");
#nullable restore
#line 234 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                              Write(Localizer.General["Permissions"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                                <span v-if=\"selectedPermissions.length > 0\" class=\"field-description small text-muted d-block\">\n                                    ");
#nullable restore
#line 236 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Partial\_PostSettings.cshtml"
                               Write(Localizer.Post["By specifying one or more permissions only authenticated users will have access to the post."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                                <ul class=""list-group"">
                                    <li class=""list-group-item"">
                                        <div class=""row"">
                                            <div v-for=""permission in permissions"" class=""col-sm-4"">
                                                <div class=""checkbox"">
                                                    <label class=""mb-0"">
                                                        <input v-model=""selectedPermissions"" type=""checkbox"" :value=""permission.key""> {{ permission.value }}
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
               ");
            WriteLiteral(@" </div>

                <div class=""region"" :class=""{ 'd-none': selectedSetting != region.meta.uid }"" v-for=""region in settingRegions"">
                    <region v-bind:content=""'post'"" v-bind:type=""typeId"" v-bind:model=""region""></region>
                </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
