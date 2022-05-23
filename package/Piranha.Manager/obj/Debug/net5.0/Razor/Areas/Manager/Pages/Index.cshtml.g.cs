#pragma checksum "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89ad975bc6740b6a7825c57613c933a9fad84857"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Pages_Index), @"mvc.1.0.razor-page", @"/Areas/Manager/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89ad975bc6740b6a7825c57613c933a9fad84857", @"/Areas/Manager/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178bd1e3bb561a59d5c2cdea0385fcdd05ea76ac", @"/Areas/Manager/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manager_Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("script", async() => {
                WriteLiteral("\n    <script>\n        $(\".dd\").nestable({\n            group: 1\n        });\n    </script>\n");
            }
            );
            WriteLiteral(@"
<div class=""top"">
    <nav aria-label=""breadcrumb"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">Section</li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Title</li>
        </ol>
    </nav>

    <div class=""container-fluid"">
        <div class=""top-nav"">
            <div class=""btn-group"" role=""group"">
                <button id=""btnGroupDrop1"" type=""button"" class=""btn btn-primary btn-labeled dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-plus""></i>
                    ");
#nullable restore
#line 26 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Index.cshtml"
               Write(Localizer["Add"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </button>
                <div class=""dropdown-menu"" aria-labelledby=""btnGroupDrop1"">
                    <a class=""dropdown-item"" href=""#"">Dropdown link</a>
                    <a class=""dropdown-item"" href=""#"">Dropdown link</a>
                </div>
            </div>
            <button class=""btn btn-success btn-labeled"" data-toggle=""modal"" data-target=""#aliasModal"">
                <i class=""fas fa-check""></i>");
#nullable restore
#line 34 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Index.cshtml"
                                       Write(Localizer["Save"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </button>
        </div>
    </div>
</div>

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col"">
            <table class=""table table-borderless"">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Type</th>
                        <th>Is Default</th>
                        <th>Modified</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td><a href=""#"">Sollicitudin Pharetra Commodo</a></td>
                        <td></td>
                        <td></td>
                        <td>2019-03-19</td>
                    </tr>
                    <tr>
                        <td><a href=""#"">Ultricies Nibh Fusce</a></td>
                        <td></td>
                        <td></td>
                        <td>2019-03-19</td>
                    </tr>
                    <tr>
                        <td><a href=""#"">Quam Fusce O");
            WriteLiteral(@"rnare</a></td>
                        <td></td>
                        <td></td>
                        <td>2019-03-19</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>

    <div class=""row"">
        <div class=""col"">
            <div class=""sitemap dd"">
                <ol class=""dd-list"">
                    <li class=""dd-item"">
                        <div class=""sitemap-item"">
                            <div class=""handle dd-handle""><i class=""fas fa-ellipsis-v""></i></div>
                            <div class=""link""><a href=""#"">Page link</a></div>
                            <div class=""type d-none d-md-block"">Standard page</div>
                            <div class=""date d-none d-md-block"">2019-03-23</div>
                            <div class=""actions"">
                                <a href=""#""><i class=""fas fa-angle-down""></i></a>
                                <a href=""#""><i class=""fas fa-angle-right""></i></a>
                            ");
            WriteLiteral(@"</div>
                        </div>
                        <ol class=""dd-list"">
                            <li class=""dd-item"">
                                <div class=""sitemap-item"">
                                    <div class=""handle dd-handle""><i class=""fas fa-ellipsis-v""></i></div>
                                    <div class=""link""><a href=""#"">Page link</a></div>
                                    <div class=""type d-none d-md-block"">Standard page</div>
                                    <div class=""date d-none d-md-block"">2019-03-23</div>
                                    <div class=""actions"">
                                        <a href=""#""><i class=""fas fa-angle-down""></i></a>
                                        <a href=""#""><i class=""fas fa-angle-right""></i></a>
                                    </div>
                                </div>
                                <ol class=""dd-list"">
                                    <li class=""dd-item"">
                             ");
            WriteLiteral(@"           <div class=""sitemap-item"">
                                            <div class=""handle dd-handle""><i class=""fas fa-ellipsis-v""></i></div>
                                            <div class=""link""><a href=""#"">Page link</a></div>
                                            <div class=""type d-none d-md-block"">Standard page</div>
                                            <div class=""date d-none d-md-block"">2019-03-23</div>
                                            <div class=""actions"">
                                                <a href=""#""><i class=""fas fa-angle-down""></i></a>
                                                <a href=""#""><i class=""fas fa-angle-right""></i></a>
                                                <a class=""danger"" href=""#""><i class=""fas fa-trash""></i></a>
                                            </div>
                                        </div>
                                    </li>
                                    <li class=""dd-item"">
             ");
            WriteLiteral(@"                           <div class=""sitemap-item"">
                                            <div class=""handle dd-handle""><i class=""fas fa-ellipsis-v""></i></div>
                                            <div class=""link""><a href=""#"">Page link</a></div>
                                            <div class=""type d-none d-md-block"">Standard page</div>
                                            <div class=""date d-none d-md-block"">2019-03-23</div>
                                            <div class=""actions"">
                                                <a href=""#""><i class=""fas fa-angle-down""></i></a>
                                                <a href=""#""><i class=""fas fa-angle-right""></i></a>
                                                <a class=""danger"" href=""#""><i class=""fas fa-trash""></i></a>
                                            </div>
                                        </div>
                                    </li>
                                </ol>
                ");
            WriteLiteral(@"            </li>
                            <li class=""dd-item"">
                                <div class=""sitemap-item"">
                                    <div class=""handle dd-handle""><i class=""fas fa-ellipsis-v""></i></div>
                                    <div class=""link""><a href=""#"">Page link</a></div>
                                    <div class=""type d-none d-md-block"">Standard page</div>
                                    <div class=""date d-none d-md-block"">2019-03-23</div>
                                    <div class=""actions"">
                                        <a href=""#""><i class=""fas fa-angle-down""></i></a>
                                        <a href=""#""><i class=""fas fa-angle-right""></i></a>
                                        <a class=""danger"" href=""#""><i class=""fas fa-trash""></i></a>
                                    </div>
                                </div>
                            </li>
                        </ol>
                    </li>
              ");
            WriteLiteral(@"      <li class=""dd-item"">
                        <div class=""sitemap-item"">
                            <div class=""handle dd-handle""><i class=""fas fa-ellipsis-v""></i></div>
                            <div class=""link""><a href=""#"">Page link</a></div>
                            <div class=""type d-none d-md-block"">Standard page</div>
                            <div class=""date d-none d-md-block"">2019-03-23</div>
                            <div class=""actions"">
                                <a href=""#""><i class=""fas fa-angle-down""></i></a>
                                <a href=""#""><i class=""fas fa-angle-right""></i></a>
                                <a class=""danger"" href=""#""><i class=""fas fa-trash""></i></a>
                            </div>
                        </div>
                    </li>
                </ol>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col"">
            <div class=""card"">
                <div class=""card-header"">
                 ");
            WriteLiteral("   General\n                </div>\n                <div class=\"card-body\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89ad975bc6740b6a7825c57613c933a9fad8485713580", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col"">
                                <div class=""form-group"">
                                    <label>Title</label>
                                    <input type=""text"" class=""form-control form-control-lg"" placeholder=""Add a value"">
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label>Firstname</label>
                                    <input type=""text"" class=""form-control"" placeholder=""Add a value"">
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label>Firstname</label>
                                    <inp");
                WriteLiteral(@"ut type=""text"" class=""form-control"" placeholder=""Add a value"">
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col"">
                                <button class=""btn btn-success btn-labeled"">
                                    <i class=""fas fa-check""></i>");
#nullable restore
#line 198 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\Index.cshtml"
                                                           Write(Localizer["Save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </button>\n                            </div>\n                        </div>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>

    <div class=""gallery gallery-sm"">
        <div class=""gallery-header"">
            Gallery
        </div>

        <a href=""#"" class=""thumbnail"">
            <div class=""thumbnail-icon"">
                <i class=""fas fa-folder fa-3x""></i>
            </div>
            <p class=""thumbnail-text"">...</p>
        </a>

        <a href=""#"" class=""thumbnail"" data-toggle=""modal"" data-target=""#previewModal"">
            <img class=""thumbnail-image"" src=""https://picsum.photos/300/200"">
            <p class=""thumbnail-text"">DC658464_BBQ.jpg</p>
        </a>

        <a href=""#"" class=""thumbnail"">
            <div class=""thumbnail-icon"">
                <i class=""fas fa-film fa-3x""></i>
            </div>
            <p class=""thumbnail-text"">DC658464_BBQ.jpg</p>
        </a>

        <a href=""#"" class=""thumbnail"" data-toggle=""modal"" data-target=""#previewModal"">
            <img class=""thumbnail-image"" src=""https://picsum.photos/300/200"">
        ");
            WriteLiteral(@"    <p class=""thumbnail-text"">DC658464_BBQ.jpg</p>
        </a>

        <a href=""#"" class=""thumbnail"">
            <div class=""thumbnail-icon"">
                <i class=""fas fa-file fa-3x""></i>
            </div>
            <p class=""thumbnail-text"">Report-23A.dox</p>
        </a>

        <a href=""#"" class=""thumbnail"" data-toggle=""modal"" data-target=""#previewModal"">
            <img class=""thumbnail-image"" src=""https://picsum.photos/300/200"">
            <p class=""thumbnail-text"">DC658464_BBQ.jpg</p>
        </a>

        <a href=""#"" class=""thumbnail"" data-toggle=""modal"" data-target=""#previewModal"">
            <img class=""thumbnail-image"" src=""https://picsum.photos/300/200"">
            <p class=""thumbnail-text"">DC658464_BBQ.jpg</p>
        </a>

        <a href=""#"" class=""thumbnail"" data-toggle=""modal"" data-target=""#previewModal"">
            <img class=""thumbnail-image"" src=""https://picsum.photos/300/200"">
            <p class=""thumbnail-text"">DC658464_BBQ.jpg</p>
        </a>

        <a href=""#"" class");
            WriteLiteral(@"=""thumbnail"" data-toggle=""modal"" data-target=""#previewModal"">
            <img class=""thumbnail-image"" src=""https://picsum.photos/300/200"">
            <p class=""thumbnail-text"">DC658464_BBQ.jpg</p>
        </a>
        <a href=""#"" class=""thumbnail"" data-toggle=""modal"" data-target=""#previewModal"">
            <img class=""thumbnail-image"" src=""https://picsum.photos/300/200"">
            <p class=""thumbnail-text"">DC658464_BBQ.jpg</p>
        </a>

        <a href=""#"" class=""thumbnail"" data-toggle=""modal"" data-target=""#previewModal"">
            <img class=""thumbnail-image"" src=""https://picsum.photos/300/200"">
            <p class=""thumbnail-text"">DC658464_BBQ.jpg</p>
        </a>
    </div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
