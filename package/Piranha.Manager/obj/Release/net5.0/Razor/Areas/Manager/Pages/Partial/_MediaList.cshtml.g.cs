#pragma checksum "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\Partial\_MediaList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "679d8d9c2cdfa780b22f28158f0dda1c0a565e1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Pages_Partial__MediaList), @"mvc.1.0.view", @"/Areas/Manager/Pages/Partial/_MediaList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"679d8d9c2cdfa780b22f28158f0dda1c0a565e1f", @"/Areas/Manager/Pages/Partial/_MediaList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178bd1e3bb561a59d5c2cdea0385fcdd05ea76ac", @"/Areas/Manager/Pages/_ViewImports.cshtml")]
    public class Areas_Manager_Pages_Partial__MediaList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<table v-if=\"listView\" class=\"table table-borderless table-media\">\n    <thead>\n        <tr>\n            <th>");
#nullable restore
#line 6 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\Partial\_MediaList.cshtml"
           Write(Localizer.General["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th class=\"td-medium\">");
#nullable restore
#line 7 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\Partial\_MediaList.cshtml"
                             Write(Localizer.General["Type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th class=\"td-medium\">");
#nullable restore
#line 8 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\Partial\_MediaList.cshtml"
                             Write(Localizer.General["Size"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th class=\"td-small\">");
#nullable restore
#line 9 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\Partial\_MediaList.cshtml"
                            Write(Localizer.General["Modified"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
            <th class=""actions one""></th>
        </tr>
    </thead>
    <tbody>
        <tr class=""droppable"" v-if=""currentFolderId != null"" v-on:dragover=""dragover"" v-on:dragleave=""dragleave"" v-on:drop=""drop($event, parentFolderId)"">
            <td>
                <a href=""#"" v-on:click.prevent=""load(parentFolderId)""><i class=""fas fa-folder-open""></i>...</a>
            </td>
            <td></td>
            <td></td>
            <td></td>
            <td class=""actions one""></td>
        </tr>
        <tr class=""droppable"" v-for=""folder in folders"" draggable=""true"" v-on:dragstart=""drag($event, folder)"" v-on:dragover=""dragover"" v-on:dragleave=""dragleave"" v-on:drop=""drop($event, folder.id)"">
            <td>
                <a href=""#"" v-on:click.prevent=""load(folder.id)""><i class=""fas fa-folder""></i>{{ folder.name }}</a>
            </td>
            <td></td>
            <td></td>
            <td>{{ folder.itemCount + (folder.itemCount == 1 ? "" ");
#nullable restore
#line 29 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\Partial\_MediaList.cshtml"
                                                            Write(Localizer.General["item"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" : \" ");
#nullable restore
#line 29 "C:\Repo\package\Piranha.Manager\Areas\Manager\Pages\Partial\_MediaList.cshtml"
                                                                                            Write(Localizer.General["items"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""") }}</td>
            <td class=""actions one"">
                <a href=""#"" class=""danger"" v-if=""folder.itemCount === 0"" v-on:click.prevent=""removeFolder(folder.id)""><i class=""fas fa-trash""></i></a>
            </td>
        </tr>
        <tr v-for=""item in items"" :class=""{ selected: item.selected }"" draggable=""true"" v-on:dragstart=""drag($event, item)"">
            <td>
                <a href=""#"" v-on:click.prevent=""onItemClick($event, item)"">
                <i v-if=""item.type === 'Audio'"" class=""fas fa-volume-up""></i>
                <i v-if=""item.type === 'Document'"" class=""fas fa-file-alt""></i>
                <i v-if=""item.type === 'Image'"" class=""fas fa-image""></i>
                <i v-if=""item.type === 'Video'"" class=""fas fa-video""></i>
                <i v-if=""item.type === 'Resource'"" class=""fas fa-box-open""></i>
                {{ item.filename }}</a>
            </td>
            <td>{{ item.contentType }}</td>
            <td>{{ item.size }}</td>
            <td>{{ item.lastModified }}</td>
     ");
            WriteLiteral("       <td class=\"actions one\">\n                <a href=\"#\" class=\"danger\" v-on:click.prevent=\"remove(item.id)\"><i class=\"fas fa-trash\"></i></a>\n            </td>\n        </tr>\n    </tbody>\n</table>\n");
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
