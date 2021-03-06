#pragma checksum "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88b9a962a560d745d7de25d610c8f615ec0bc25d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Shared_Partial__EditorConfig), @"mvc.1.0.view", @"/Areas/Manager/Shared/Partial/_EditorConfig.cshtml")]
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
#nullable restore
#line 1 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
using Piranha.Manager.Editor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88b9a962a560d745d7de25d610c8f615ec0bc25d", @"/Areas/Manager/Shared/Partial/_EditorConfig.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178bd1e3bb561a59d5c2cdea0385fcdd05ea76ac", @"/Areas/Manager/Shared/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manager_Shared_Partial__EditorConfig : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script>\n    piranha.editorconfig = new function() {\n        \"use strict\";\n\n        this.plugins = \"");
#nullable restore
#line 6 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
                   Write(EditorConfig.Current.Plugins);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n        this.toolbar = \"");
#nullable restore
#line 7 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
                   Write(EditorConfig.Current.Toolbar);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n        this.extended_valid_elements = \"");
#nullable restore
#line 8 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
                                   Write(EditorConfig.Current.ExtendedValidElements);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n        this.block_formats = \"");
#nullable restore
#line 9 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
                         Write(EditorConfig.Current.BlockFormats);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n        this.style_formats = [\n");
#nullable restore
#line 11 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
             foreach (var style in EditorConfig.Current.StyleFormats)
            {
                if (style.Type == EditorStyleType.Block)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            { title: \"");
#nullable restore
#line 15 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
                       Write(style.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", block: \"");
#nullable restore
#line 15 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
                                              Write(style.Tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
#nullable restore
#line 15 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
                                                         Write(Html.Raw(style.HasClasses ? ", classes: \"" + style.Classes + "\"" : ""));

#line default
#line hidden
#nullable disable
            WriteLiteral(" },\n");
#nullable restore
#line 16 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
       
                }
                else if (style.Type == EditorStyleType.Format)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            { title: \"");
#nullable restore
#line 20 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
                       Write(style.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", format: \"");
#nullable restore
#line 20 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
                                               Write(style.Tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
#nullable restore
#line 20 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
                                                          Write(Html.Raw(style.HasClasses ? ", classes: \"" + style.Classes + "\"" : ""));

#line default
#line hidden
#nullable disable
            WriteLiteral(" },\n");
#nullable restore
#line 21 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
       
                }
                else if (style.Type == EditorStyleType.Inline)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            { title: \"");
#nullable restore
#line 25 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
                       Write(style.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", inline: \"");
#nullable restore
#line 25 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
                                               Write(style.Tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
#nullable restore
#line 25 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
                                                          Write(Html.Raw(style.HasClasses ? ", classes: \"" + style.Classes + "\"" : ""));

#line default
#line hidden
#nullable disable
            WriteLiteral(" },\n");
#nullable restore
#line 26 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Shared\Partial\_EditorConfig.cshtml"
       
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ];\n    };\n</script>\n");
        }
        #pragma warning restore 1998
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
