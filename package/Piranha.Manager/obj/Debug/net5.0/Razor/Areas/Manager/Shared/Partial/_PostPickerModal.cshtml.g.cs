#pragma checksum "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_PostPickerModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dea122edac0ebee3b688f598b4dc6b06d1481cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Shared_Partial__PostPickerModal), @"mvc.1.0.view", @"/Areas/Manager/Shared/Partial/_PostPickerModal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dea122edac0ebee3b688f598b4dc6b06d1481cf", @"/Areas/Manager/Shared/Partial/_PostPickerModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178bd1e3bb561a59d5c2cdea0385fcdd05ea76ac", @"/Areas/Manager/Shared/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manager_Shared_Partial__PostPickerModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- The Modal -->
<div class=""modal modal-panel fade"" id=""postpicker"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header border-bottom-0"">
                <h5 class=""modal-title""><i class=""fas fa-copy""></i> ");
#nullable restore
#line 10 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_PostPickerModal.cshtml"
                                                               Write(Localizer.General["Select post"]);

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
                <div v-if=""archives.length > 1 || sites.length > 1"" class=""form-group d-flex justify-content-center"">
                    <div v-if=""archives.length > 1"" class=""dropdown mr-3"">
                        <button class=""btn btn-primary btn-labeled dropdown-toggle"" type=""button"" data-toggle=""dropdown"">
                            <span class=""btn-label"">
                                <i class=""fas fa-font""></i>
                            </span>
                            {{ currentArchiveTitle }}
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"" li v-for=""archive in archives"" v-on:click.prevent=""load(currentSiteId, arch");
            WriteLiteral(@"ive.id)"">{{ archive.title }}</a>
                        </div>
                    </div>
                    <div v-if=""sites.length > 1"" class=""dropdown"" v-if=""sites.length > 1"">
                        <button class=""btn btn-primary btn-labeled dropdown-toggle"" type=""button"" data-toggle=""dropdown"">
                            <span class=""btn-label"">
                                <i class=""fas fa-globe""></i>
                            </span>
                            {{ currentSiteTitle }}
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"" li v-for=""site in sites"" v-on:click.prevent=""load(site.id)"">{{ site.title }}</a>
                        </div>
                    </div>
                </div>

                <div class=""form-group"" :class=""{ 'mt-3': archives.length > 1 || sites.length > 1 }"">
                    <input id=""postpickerSearch"" class=""form-control"" v-model=""search"" v-on:keyup.enter=""o");
            WriteLiteral("nEnter\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2430, "\"", 2475, 1);
#nullable restore
#line 44 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_PostPickerModal.cshtml"
WriteAttributeValue("", 2444, Localizer.General["Search..."], 2444, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                </div>\n\n                <table class=\"table table-borderless table-media\">\n                    <thead>\n                        <tr>\n                            <th>");
#nullable restore
#line 50 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_PostPickerModal.cshtml"
                           Write(Localizer.General["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                            <th class=\"td-medium\">");
#nullable restore
#line 51 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_PostPickerModal.cshtml"
                                             Write(Localizer.General["Publish date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for=""post in filteredPosts"">
                            <td><a href=""#"" v-on:click.prevent=""select(post)"">{{ post.title }}</a></td>
                            <td>{{ post.published }}</td>
                        </tr>
                    </tbody>
                </table>

            </div>
        </div>
    </div>
</div>");
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