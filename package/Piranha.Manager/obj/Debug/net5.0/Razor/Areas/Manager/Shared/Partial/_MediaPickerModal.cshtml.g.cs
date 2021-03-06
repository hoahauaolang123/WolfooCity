#pragma checksum "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28521b8d9f9e030151c636085593afd01233660f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Shared_Partial__MediaPickerModal), @"mvc.1.0.view", @"/Areas/Manager/Shared/Partial/_MediaPickerModal.cshtml")]
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
#line 1 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\_ViewImports.cshtml"
using Piranha.Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\_ViewImports.cshtml"
using Piranha.Manager.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\_ViewImports.cshtml"
using Piranha.Manager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28521b8d9f9e030151c636085593afd01233660f", @"/Areas/Manager/Shared/Partial/_MediaPickerModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178bd1e3bb561a59d5c2cdea0385fcdd05ea76ac", @"/Areas/Manager/Shared/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manager_Shared_Partial__MediaPickerModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropzone needsclick dz-clickable"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/manager/assets/img/media-placeholder.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- The Modal -->
<div class=""modal modal-panel fade"" id=""mediapicker"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h5 class=""modal-title""><i class=""fas fa-images""></i> ");
#nullable restore
#line 11 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
                                                                 Write(Localizer.Media["Select media"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <!-- Modal Body -->
            <div class=""modal-body bg-light"">
                <!-- Pills -->
                <div class=""row"">
                    <div class=""col"">
                        <ul class=""nav nav-pills mb-3"">
                            <li class=""nav-item"">
                                <a class=""nav-link"" :class=""{active: listView}"" v-on:click.prevent=""toggle"" href=""#""><i class=""fas fa-list""></i></a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" :class=""{active: !listView}"" v-on:click.prevent=""toggle"" href=""#""><i class=""fas fa-table""></i></a>
                            </li>
                        </ul>
                    </div>
                    <div class=""col"">
                   ");
            WriteLiteral("     <div class=\"d-flex flex-row\">\n");
#nullable restore
#line 33 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
                             if ((await Auth.AuthorizeAsync(User, Permission.MediaAddFolder)).Succeeded)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input v-model=\"folderName\" v-on:keyup.enter=\"savefolder\" type=\"text\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1687, "\"", 1731, 1);
#nullable restore
#line 35 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
WriteAttributeValue("", 1701, Localizer.Media["Add folder"], 1701, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control flex-fill\">\n                            <button v-on:click.prevent=\"savefolder\" class=\"btn btn-primary ml-3\"><i class=\"fas fa-plus\"></i></button>\n");
#nullable restore
#line 37 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n                    </div>\n                </div>\n\n");
#nullable restore
#line 42 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
                 if ((await Auth.AuthorizeAsync(User, Permission.MediaAdd)).Succeeded)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"mediapicker-upload-container\" class=\"dropzone-container\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28521b8d9f9e030151c636085593afd01233660f9012", async() => {
                WriteLiteral(@"
                            <input type=""hidden"" name=""Model.ParentId"" v-model=""currentFolderId"" />
                            <div class=""dz-message needsclick text-center"">
                                <span class=""fas fa-cloud-upload-alt""></span>
                                ");
#nullable restore
#line 49 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
                           Write(Localizer.Media["Drop files here or click to upload."]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n                            <div class=\"file-list\"></div>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 45 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
AddHtmlAttributeValue("", 2241, Url.Action("Upload", "MediaApi"), 2241, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <ul class=\"media-list list-unstyled\"></ul>\n                    </div>\n");
#nullable restore
#line 55 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <div class=\"form-group mt-3\">\n                     <input id=\"mediapickerSearch\" class=\"form-control\" v-model=\"search\" v-on:keyup.enter=\"onEnter\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3089, "\"", 3134, 1);
#nullable restore
#line 58 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
WriteAttributeValue("", 3103, Localizer.General["Search..."], 3103, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n                </div>\n\n                <div v-if=\"currentFolderBreadcrumb != null\" class=\"breadcrumb\">\n                    <span class=\"folder\"><a href=\"#\" v-on:click.prevent=\"load()\"><i class=\"fas fa-folder-open\"></i>");
#nullable restore
#line 62 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
                                                                                                              Write(Localizer.Media["Media"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></span>
                    <span v-for=""folder in currentFolderBreadcrumb"" class=""folder""><a href=""#"" v-on:click.prevent=""load(folder.id)""><i class=""fas fa-folder-open""></i>{{ folder.name }}</a></span>

                </div>

                <template v-if=""listView"">
                    <table class=""table table-borderless table-media"">
                        <thead>
                            <tr>
                                <th>");
#nullable restore
#line 71 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
                               Write(Localizer.General["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                <th class=\"td-medium d-none\">");
#nullable restore
#line 72 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
                                                        Write(Localizer.General["Type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                <th class=\"td-small d-none\">");
#nullable restore
#line 73 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
                                                       Write(Localizer.General["Size"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                <th class=\"td-small\">");
#nullable restore
#line 74 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
                                                Write(Localizer.General["Modified"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr v-if=""currentFolderId != null"">
                                <td><a href=""#"" v-on:click.prevent=""load(parentFolderId)""><i class=""fas fa-folder-open""></i>...</a></td>
                                <td class=""d-none""></td>
                                <td class=""d-none""></td>
                                <td></td>
                            </tr>
                            <tr v-for=""folder in filteredFolders"">
                                <td><a href=""#"" v-on:click.prevent=""load(folder.id)""><i class=""fas fa-folder-open""></i>{{ folder.name }}</a></td>
                                <td class=""d-none""></td>
                                <td class=""d-none""></td>
                                <td></td>
                            </tr>
                            <tr v-for=""item in filteredItems"">
                                <td>
                         ");
            WriteLiteral(@"           <a href=""#"" v-on:click.prevent=""select(item)"">
                                        <i v-if=""item.type === 'Audio'"" class=""fas fa-volume-up""></i>
                                        <i v-if=""item.type === 'Document'"" class=""fas fa-file-alt""></i>
                                        <i v-if=""item.type === 'Image'"" class=""fas fa-image""></i>
                                        <i v-if=""item.type === 'Video'"" class=""fas fa-video""></i>
                                        <i v-if=""item.type === 'Resource'"" class=""fas fa-box-open""></i>
                                        {{ item.filename }}
                                    </a>
                                </td>
                                <td class=""d-none"">{{ item.contentType }}</td>
                                <td class=""d-none"">{{ item.size }}</td>
                                <td>{{ item.lastModified }}</td>
                            </tr>
                        </tbody>
                    </table>
         ");
            WriteLiteral("       </template>\n\n                <template v-if=\"!listView\">\n                    <div class=\"gallery gallery-sm\">\n                        <div class=\"gallery-header\">\n                            ");
#nullable restore
#line 112 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_MediaPickerModal.cshtml"
                       Write(Localizer.Media["Gallery"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n\n                        <a href=\"#\" class=\"thumbnail\" v-if=\"currentFolderId != null\" v-on:click.prevent=\"load(parentFolderId)\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "28521b8d9f9e030151c636085593afd01233660f17759", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""thumbnail-icon"">
                                <i class=""fas fa-folder-open fa-3x""></i>
                            </div>
                            <p class=""thumbnail-text"">...</p>
                        </a>

                        <a href=""#"" class=""thumbnail"" v-for=""folder in filteredFolders"" v-on:click.prevent=""load(folder.id)"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "28521b8d9f9e030151c636085593afd01233660f19214", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""thumbnail-icon"">
                                <i class=""fas fa-folder fa-3x""></i>
                            </div>
                            <p class=""thumbnail-text"">{{ folder.name }}</p>
                        </a>

                        <template v-for=""item in filteredItems"">
                            <a href=""#"" class=""thumbnail"" v-on:click.prevent=""select(item)"">

                                <template v-if=""item.type === 'Image'"">
                                    <img class=""thumbnail-image"" :src=""getThumbnailUrl(item)"">
                                </template>

                                <template v-else-if=""item.type === 'Document'"">
                                    <div class=""thumbnail-icon"">
                                        <i class=""fas fa-file-alt fa-3x""></i>
                                    </div>
                                </template>

                                <template v-else-if=""item.type === 'Video'""");
            WriteLiteral(@">
                                    <div class=""thumbnail-icon"">
                                        <i class=""fas fa-film fa-3x""></i>
                                    </div>
                                </template>

                                <template v-else-if=""item.type === 'Resource'"">
                                    <div class=""thumbnail-icon"">
                                        <i class=""fas fa-box-open fa-3x""></i>
                                    </div>
                                </template>

                                <template v-else>
                                    <div class=""thumbnail-icon"">
                                        <i class=""fas fa-file""></i>
                                        <i class=""fas fa-file fa-3x""></i>
                                    </div>
                                </template>

                                <p class=""thumbnail-text"">{{ item.filename }}</p>
                            </a>
                        ");
            WriteLiteral("</template>\n                    </div>\n                </template>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
