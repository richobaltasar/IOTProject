#pragma checksum "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8f7c13da2cc038a5c33a7d5ccd28f3dd6f1d08a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Laporan_SummaryHarian_Table), @"mvc.1.0.view", @"/Views/Laporan/SummaryHarian_Table.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\_ViewImports.cshtml"
using WebIOT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\_ViewImports.cshtml"
using WebIOT.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\_ViewImports.cshtml"
using WebIOT.Function;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\_ViewImports.cshtml"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f7c13da2cc038a5c33a7d5ccd28f3dd6f1d08a", @"/Views/Laporan/SummaryHarian_Table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9482a01595e1eed09bbb6581e85bd83ae9dc148", @"/Views/_ViewImports.cshtml")]
    public class Views_Laporan_SummaryHarian_Table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SummaryHarianModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
  
    GlobalFunction f = new GlobalFunction();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
 if (Model.Error != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
Write(await Html.PartialAsync("Error", Model.Error));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
                                                  

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table id=""myTable""
       class=""display no-wrap table table-hover table-striped table-bordered compact""
       cellspacing=""0"">
    <thead class=""bg-dark text-light"" style=""font-family:Calibri;font-size:small;"">
        <tr>
            <th width=""30"">no</th>
            <th style=""text-align:center;"">Tanggal Transaksi</th>
            <th style=""text-align:center;"">Nama Penyewa</th>
            <th style=""text-align:center;"">Total Buku</th>
            <th style=""text-align:center;"">Total Sewa</th>
            <th style=""text-align:center;"">Nama Kasir</th>
            <th style=""text-align:center;"">Pembayaran</th>
            <th style=""text-align:center;"">Uang Kembalian</th>
        </tr>
    </thead>
    <tbody style=""font-size:small;font-family:Calibri;"">
");
#nullable restore
#line 29 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
          
            int a = 0;
            decimal GrandTotal = 0;
            foreach (var item in Model.Listdata)
            {
                a++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td nowrap align=\"center\">");
#nullable restore
#line 36 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
                                         Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td nowrap align=\"left\">");
#nullable restore
#line 37 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
                                       Write(item.TanggalTransaksi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td nowrap align=\"left\">");
#nullable restore
#line 38 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
                                       Write(item.NamaPenyewa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td nowrap align=\"left\">");
#nullable restore
#line 39 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
                                       Write(item.TotalBuku);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td nowrap align=\"right\">");
#nullable restore
#line 40 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
                                        Write(item.TotalSewa.toNumber().Replace(".", ","));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td nowrap align=\"left\">");
#nullable restore
#line 41 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
                                       Write(item.NamaKasir);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td nowrap align=\"right\">");
#nullable restore
#line 42 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
                                        Write(item.KasirTerimaUang.toNumber().Replace(".", ","));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td nowrap align=\"right\">");
#nullable restore
#line 43 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
                                        Write(item.UangKembalian.toNumber().Replace(".", ","));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 45 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"

                GrandTotal = GrandTotal + item.TotalSewa.toDecimal();
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot style=\"font-size:small;font-family:Calibri;\">\r\n        <tr>\r\n            <td align=\"center\" colspan=\"4\" style=\"font-weight:bold;\">Grand Total</td>\r\n            <td align=\"right\" style=\"font-weight:bold;\">");
#nullable restore
#line 53 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Laporan\SummaryHarian_Table.cshtml"
                                                   Write(GrandTotal.ToString().toNumber().Replace(".",","));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            <td align=""center"" colspan=""3"" style=""font-weight:bold;""></td>
        </tr>
    </tfoot>
</table>
<script type=""text/javascript"">
    $(function () {
        var collapsedGroups = {};
        var table = $('#myTable').DataTable({
            ""info"": false,
            ""scrollX"": false,
            ""autoWidth"": false,
            ""paging"": false,
            scrollY: ""50vh"",
            scrollX: !0,
            scrollCollapse: !0,
            iDisplayLength: 100,
            searching: false,
            dom: 'Bfrtip',
            buttons: [
                'excelHtml5',
                'pdfHtml5',
                'copyHtml5',
                'csvHtml5'
                
            ]
        });
    });
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SummaryHarianModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
