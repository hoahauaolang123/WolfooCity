#pragma checksum "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\QuanLyVe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f90a27ff900955940186fb9672b31e7596479f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Pages_QuanLyVe), @"mvc.1.0.razor-page", @"/Areas/Manager/Pages/QuanLyVe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/quan-ly-ve/{LoaiVe:int?}/{TrangThai:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8f90a27ff900955940186fb9672b31e7596479f", @"/Areas/Manager/Pages/QuanLyVe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178bd1e3bb561a59d5c2cdea0385fcdd05ea76ac", @"/Areas/Manager/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manager_Pages_QuanLyVe : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("cursor:pointer;float:right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Xu???t file excel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Export", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\QuanLyVe.cshtml"
  
    var lv = this.Request.RouteValues["LoaiVe"] ?? "-1";
    var tt = this.Request.RouteValues["TrangThai"] ?? "-1";

    var loaiVe = Int32.Parse(lv.ToString());
    var trangThai = Int32.Parse(tt.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"text\" hidden name=\"TrangThai2\" id=\"TrangThai2\"");
            BeginWriteAttribute("value", " value=\"", 394, "\"", 412, 1);
#nullable restore
#line 12 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\QuanLyVe.cshtml"
WriteAttributeValue("", 402, trangThai, 402, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"text\" hidden name=\"LoaiVe2\" id=\"LoaiVe2\"");
            BeginWriteAttribute("value", " value=\"", 471, "\"", 486, 1);
#nullable restore
#line 13 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\QuanLyVe.cshtml"
WriteAttributeValue("", 479, loaiVe, 479, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<div id=\"formview search-box\">\r\n    <div class=\"card m-3\">\r\n        <h4> Th???ng k?? s??? li???u v??</h4>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 603, "\"", 611, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-3\">\r\n                    ");
#nullable restore
#line 20 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\QuanLyVe.cshtml"
               Write(Html.Label("M?? v??"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 21 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\QuanLyVe.cshtml"
               Write(Html.TextBox("MaVe", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-3\">\r\n                    ");
#nullable restore
#line 24 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\QuanLyVe.cshtml"
               Write(Html.Label("Lo???i v??"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <select class=\"form-control\" id=\"LoaiVe\" name=\"LoaiVe\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f90a27ff900955940186fb9672b31e7596479f10569", async() => {
                WriteLiteral("\r\n                            Ch???n lo???i v??\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f90a27ff900955940186fb9672b31e7596479f11819", async() => {
                WriteLiteral("\r\n                            V?? ng??y th?????ng\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f90a27ff900955940186fb9672b31e7596479f13071", async() => {
                WriteLiteral("\r\n                            V?? ng??y l???, cu???i tu???n\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </select>\r\n                </div>\r\n                <div class=\"form-group col-md-3\">\r\n                    ");
#nullable restore
#line 38 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\QuanLyVe.cshtml"
               Write(Html.Label("Ng??y t???o v??"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div>\r\n                        <div class=\"input-group-prepend\">\r\n                            <span class=\"input-group-text\"><i class=\"far fa-calendar-alt\"></i></span>\r\n                            ");
#nullable restore
#line 42 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\QuanLyVe.cshtml"
                       Write(Html.TextBox("NgayTaoVe", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-md-3\">\r\n                    ");
#nullable restore
#line 47 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\QuanLyVe.cshtml"
               Write(Html.Label("Ng??y b??n v??"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div>\r\n                        <div class=\"input-group-prepend\">\r\n                            <span class=\"input-group-text\"><i class=\"far fa-calendar-alt\"></i></span>\r\n                            ");
#nullable restore
#line 51 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\QuanLyVe.cshtml"
                       Write(Html.TextBox("NgayBanVe", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-3\">\r\n                    ");
#nullable restore
#line 56 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\QuanLyVe.cshtml"
               Write(Html.Label("Tr???ng th??i"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <select class=\"form-control\" id=\"TrangThai\" name=\"TrangThai\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f90a27ff900955940186fb9672b31e7596479f16633", async() => {
                WriteLiteral("\r\n                            Ch???n tr???ng th??i\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f90a27ff900955940186fb9672b31e7596479f17886", async() => {
                WriteLiteral("\r\n                            0. M???i t???o\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f90a27ff900955940186fb9672b31e7596479f19134", async() => {
                WriteLiteral("\r\n                            1. ???? xu???t excel\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f90a27ff900955940186fb9672b31e7596479f20388", async() => {
                WriteLiteral("\r\n                            2. ???? b??n\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f90a27ff900955940186fb9672b31e7596479f21635", async() => {
                WriteLiteral("\r\n                            3. ???? h???t h???n\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </select>\r\n                </div>\r\n");
            WriteLiteral(@"                <div class=""form-group col-3"" style=""margin-top: 29px"">
                    <span style=""cursor:pointer;float:left"" onclick=""TimKiem()"" class=""btn btn-primary ml-2"">T??m ki???m</span>
                </div>
                <div class=""form-group col-6"" style=""margin-top: 29px"">
                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f90a27ff900955940186fb9672b31e7596479f23284", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8f90a27ff900955940186fb9672b31e7596479f23563", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
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
        <div class=""card-body"">
            <table id=""tbl"" width=""100%"" class=""table table-bordered display"">
                <thead>
                    <tr>
                        <th class=""bg-info"">STT</th>
                        <th class=""bg-info"">M?? v??</th>
                        <th class=""bg-info"">Lo???i v??</th>
                        <th class=""bg-info"">Ng??y t???o v??</th>
                        <th class=""bg-info"">Ng??y b??n v??</th>
                        <th class=""bg-info"">Tr???ng th??i</th>
                        <th class=""bg-info"">H??? t??n KH</th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>
</div>
<script>
    $(""#LoaiVe"").select2();
    $(""#TrangThai"").select2();
    var tbl = $(""#tbl"").DataTable({
        ordering: false,
        serverSide: true,
        processing: true,
        ajax: {
            url: ""?handler=DanhSachVe"",
            ");
            WriteLiteral(@"type: ""GET"",
            data: function(data) {
                data.MaVe = $(""#MaVe"").val(),
                    data.LoaiVeId = $(""#LoaiVe"").val(),
                    data.NgayTaoVe = $(""#NgayTaoVe"").val(),
                    data.NgayBanVe = $(""#NgayBanVe"").val(),
                    data.TrangThai = $(""#TrangThai"").val()
            },
        },
        searching: false,
        columns: [
            {
                data: ""ThongTinVeId"",
                className: ""text-center"",
                render: function(data, type, row, meta) {
                    var rowNum = meta.row + meta.settings._iDisplayStart + 1;
                    return rowNum;
                }
            },
            {
                data: ""MaVe"",
            },
            {
                data: ""TenVe"",
                className: ""text-center"",

            },
            {
                data: ""NgayTaoVe"",
                className: ""text-center"",

            },
            {
          ");
            WriteLiteral(@"      data: ""NgayBanVe"",
                className: ""text-center"",

            },
            {
                data: ""TrangThai"",
                className: ""text-center"",

            },
            {
                data: ""TenKhachHang"",

            }
        ]
    })


    function TimKiem() {
        tbl.ajax.reload();
    }
    $('#NgayTaoVe').daterangepicker({
        singleDatePicker: true,
        showDropdowns: true,
        autoUpdateInput: false,
        minYear: 1900,
        locale: vn_daterangepicker
    })
    $('input[name=""NgayTaoVe""]').on('apply.daterangepicker', function(ev, picker) {
        $(this).val(picker.endDate.format('DD/MM/YYYY'));
    });
    $('#NgayBanVe').daterangepicker({
        singleDatePicker: true,
        showDropdowns: true,
        autoUpdateInput: false,
        minYear: 1900,
        locale: vn_daterangepicker
    })
    $('input[name=""NgayBanVe""]').on('apply.daterangepicker', function(ev, picker) {
        $(this).val(picker");
            WriteLiteral(@".endDate.format('DD/MM/YYYY'));
    });
    $('#SoDienThoai').keyup(function(e) {
        if ((e.keyCode > 47 && e.keyCode < 58) || (e.keyCode < 106 && e.keyCode > 95)) {
            this.value = this.value.replace(/(\d{3})\?/g, '$1-');
            return true;
        }
        //remove all chars, except dash and digits
        this.value = this.value.replace(/[^\-0-9]/g, '');
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Manager.Areas.Manager.ThongKeVeModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Piranha.Manager.Areas.Manager.ThongKeVeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Piranha.Manager.Areas.Manager.ThongKeVeModel>)PageContext?.ViewData;
        public Piranha.Manager.Areas.Manager.ThongKeVeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
