#pragma checksum "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\TaoMaGiamGia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c88f84faed67add18af7476606937497467ca0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Pages_TaoMaGiamGia), @"mvc.1.0.razor-page", @"/Areas/Manager/Pages/TaoMaGiamGia.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/tao-ma-giam-gia/")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c88f84faed67add18af7476606937497467ca0c", @"/Areas/Manager/Pages/TaoMaGiamGia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"178bd1e3bb561a59d5c2cdea0385fcdd05ea76ac", @"/Areas/Manager/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manager_Pages_TaoMaGiamGia : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"formview\">\r\n    <div class=\"card m-3\">\r\n        <h4>T???o m?? gi???m gi??</h4>\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-4\">\r\n                ");
#nullable restore
#line 10 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\TaoMaGiamGia.cshtml"
           Write(Html.Label("T??n m?? gi???m gi??"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"text-danger\"> (*)</span>\r\n                ");
#nullable restore
#line 11 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\TaoMaGiamGia.cshtml"
           Write(Html.TextBox("MaGiamGia", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group col-4\">\r\n                ");
#nullable restore
#line 14 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\TaoMaGiamGia.cshtml"
           Write(Html.Label("T??? l??? gi???m (%)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"text-danger\"> (*)</span>\r\n                ");
#nullable restore
#line 15 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\TaoMaGiamGia.cshtml"
           Write(Html.TextBox("TyLe", null, new { @class = "form-control",onkeyup="this.value = minmax(this.value,null, 50)"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group col-4\">\r\n                ");
#nullable restore
#line 18 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\TaoMaGiamGia.cshtml"
           Write(Html.Label("S??? ti???n gi???m (??)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"text-danger\"> (*)</span>\r\n                ");
#nullable restore
#line 19 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\TaoMaGiamGia.cshtml"
           Write(Html.TextBox("SoTien", null, new { @class = "form-control",onkeyup="this.value = minmax(this.value,null, 100000)"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group col-4\">\r\n                ");
#nullable restore
#line 22 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\TaoMaGiamGia.cshtml"
           Write(Html.Label("S??? l?????t s??? d???ng"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"text-danger\"> (*)</span>\r\n                ");
#nullable restore
#line 23 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\TaoMaGiamGia.cshtml"
           Write(Html.TextBox("SoLuongSuDung", null, new { @class = "form-control",onkeyup="this.value = minmax(this.value,null, 10000)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group col-md-4\">\r\n                ");
#nullable restore
#line 26 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\TaoMaGiamGia.cshtml"
           Write(Html.Label("Ng??y b???t ?????u"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"text-danger\"> (*)</span>\r\n                <div>\r\n                    <div class=\"input-group-prepend\">\r\n                        <span class=\"input-group-text\"><i class=\"far fa-calendar-alt\"></i></span>\r\n                        ");
#nullable restore
#line 30 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\TaoMaGiamGia.cshtml"
                   Write(Html.TextBox("NgayBatDau", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group col-md-4\">\r\n                ");
#nullable restore
#line 35 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\TaoMaGiamGia.cshtml"
           Write(Html.Label("Ng??y k???t th??c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"text-danger\"> (*)</span>\r\n                <div>\r\n                    <div class=\"input-group-prepend\">\r\n                        <span class=\"input-group-text\"><i class=\"far fa-calendar-alt\"></i></span>\r\n                        ");
#nullable restore
#line 39 "D:\Cong\Repo2\package\Piranha.Manager\Areas\Manager\Pages\TaoMaGiamGia.cshtml"
                   Write(Html.TextBox("NgayKetThuc", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""form-group col-12"">
                <span style=""cursor:pointer;float:right"" onclick=""TaoMaGiamGia()"" class=""btn btn-primary ml-2"">T???o m?? gi???m gi??</span>
            </div>
            <div class=""form-group col-12"">
                <span class=""text-danger"">Ghi ch??: </span> <br />
                <p class=""m-2"">S??? l?????t s??? d???ng t???i ??a l?? 10.000 l?????t</p>
                <p class=""m-2"">T??? l??? gi???m gi?? t???i ??a l?? 50%</p>
                <p class=""m-2"">Ch??? nh???p t??? l??? gi???m ho???c s??? ti???n gi???m</p>
                <p class=""m-2"">S??? ti???n gi???m gi?? t???i ??a l?? 100.000??</p>
            </div>
        </div>
    </div>
</div>
<script>
    $('#SoTien').keyup(function() {
        $('#TyLe').val("""");
    });
    $('#TyLe').keyup(function() {
        $('#SoTien').val("""");
    });
    $('#MaGiamGia').keyup(function() {
        this.value = this.value.toUpperCase();
    });
    $('#SoTien').keyup(function(e) {
  ");
            WriteLiteral(@"      if ((e.keyCode > 47 && e.keyCode < 58) || (e.keyCode < 106 && e.keyCode > 95)) {
            this.value = this.value.replace(/(\d{3})\?/g, '$1-');
            return true;
        }
        //remove all chars, except dash and digits
        this.value = this.value.replace(/[^\-0-9]/g, '');
    });
    $('#TyLe').keyup(function(e) {
        if ((e.keyCode > 47 && e.keyCode < 58) || (e.keyCode < 106 && e.keyCode > 95)) {
            this.value = this.value.replace(/(\d{3})\?/g, '$1-');
            return true;
        }
        //remove all chars, except dash and digits
        this.value = this.value.replace(/[^\-0-9]/g, '');
    });
    $('#SoLuongSuDung').keyup(function(e) {
        if ((e.keyCode > 47 && e.keyCode < 58) || (e.keyCode < 106 && e.keyCode > 95)) {
            this.value = this.value.replace(/(\d{3})\?/g, '$1-');
            return true;
        }
        //remove all chars, except dash and digits
        this.value = this.value.replace(/[^\-0-9]/g, '');
    });
   ");
            WriteLiteral(@" $('#NgayBatDau').daterangepicker({
        singleDatePicker: true,
        showDropdowns: true,
        autoUpdateInput: false,
        minYear: 1900,
        locale: vn_daterangepicker
    })
    $('input[name=""NgayBatDau""]').on('apply.daterangepicker', function(ev, picker) {
        $(this).val(picker.endDate.format('DD/MM/YYYY'));
    });
    $('#NgayKetThuc').daterangepicker({
        singleDatePicker: true,
        showDropdowns: true,
        autoUpdateInput: false,
        minYear: 1900,
        locale: vn_daterangepicker
    })
    $('input[name=""NgayKetThuc""]').on('apply.daterangepicker', function(ev, picker) {
        $(this).val(picker.endDate.format('DD/MM/YYYY'));
    });
    function TaoMaGiamGia() {

        if ($(""#NgayBatDau"").val() !== """" && $(""#NgayKetThuc"").val() !== """" && $(""#MaGiamGia"").val() !== """" && $(""#SoLuongSuDung"").val() !== """"
            && ($(""#TyLe"").val() !== """" || $(""#SoTien"").val() !== """")
        ) {
            var st1 = $(""#NgayBatDau"").val();
");
            WriteLiteral(@"            var pattern1 = /(\d{2})\.(\d{2})\.(\d{4})/;
            var dt1 = new Date(st1.replace(pattern1, '$3-$2-$1'));

            var st2 = $(""#NgayBatDau"").val();
            var pattern2 = /(\d{2})\.(\d{2})\.(\d{4})/;
            var dt2 = new Date(st2.replace(pattern2, '$3-$2-$1'));
            if (dt2 >= dt1) {
                console.log(1);
            }
            else {
                toastr.error(""Ng??y k???t th??c ph???i l???n h??n ho???c b???ng ng??y b???t ?????u!"");
            }
            console.log(dt2)
            console.log(dt1)
        }
        else {
              toastr.error(""Vui l??ng nh???p ?????y ????? th??ng tin"");
        }
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Manager.Areas.Manager.Pages.MaGiamGiaModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Piranha.Manager.Areas.Manager.Pages.MaGiamGiaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Piranha.Manager.Areas.Manager.Pages.MaGiamGiaModel>)PageContext?.ViewData;
        public Piranha.Manager.Areas.Manager.Pages.MaGiamGiaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
