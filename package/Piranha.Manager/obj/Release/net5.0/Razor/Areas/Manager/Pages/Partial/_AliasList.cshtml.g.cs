#pragma checksum "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\Partial\_AliasList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12c70f4bcbf597ca1273c3aa1ebdc9fe64ccd45f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Pages_Partial__AliasList), @"mvc.1.0.view", @"/Areas/Manager/Pages/Partial/_AliasList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c70f4bcbf597ca1273c3aa1ebdc9fe64ccd45f", @"/Areas/Manager/Pages/Partial/_AliasList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178bd1e3bb561a59d5c2cdea0385fcdd05ea76ac", @"/Areas/Manager/Pages/_ViewImports.cshtml")]
    public class Areas_Manager_Pages_Partial__AliasList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"container-fluid\">\n    <div class=\"row\">\n        <div v-if=\"items.length !== 0\" class=\"col\">\n            <table class=\"table table-borderless\">\n                <thead>\n                    <tr>\n                        <th>");
#nullable restore
#line 9 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\Partial\_AliasList.cshtml"
                       Write(Localizer.Alias["Alias URL"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <th>");
#nullable restore
#line 10 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\Partial\_AliasList.cshtml"
                       Write(Localizer.Alias["Redirect URL"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <th class=\"text-center\">");
#nullable restore
#line 11 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\Partial\_AliasList.cshtml"
                                           Write(Localizer.Alias["Permanent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for=""item in items"">
                        <td><code>{{ item.aliasUrl }}</code></td>
                        <td><code>{{ item.redirectUrl }}</code></td>
                        <td class=""text-center""><i v-if=""item.isPermanent"" class=""fas fa-check""></i></td>
                        <td class=""actions one""><a v-if=""piranha.permissions.aliases.delete"" href=""#"" class=""danger"" v-on:click.prevent=""remove(item.id)""><i class=""fas fa-trash""></i></a></td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div v-else class=""col"">
            <div class=""empty-info"">
                <p>");
#nullable restore
#line 27 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\Partial\_AliasList.cshtml"
              Write(Localizer.General["Looks like there's no items here. Click on the button above to get started!"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591