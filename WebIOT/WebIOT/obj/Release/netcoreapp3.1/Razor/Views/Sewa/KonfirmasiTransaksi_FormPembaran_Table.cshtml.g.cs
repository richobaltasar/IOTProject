#pragma checksum "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "271b956d3f88e489962f4fe8bf5f287416f7b95a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sewa_KonfirmasiTransaksi_FormPembaran_Table), @"mvc.1.0.view", @"/Views/Sewa/KonfirmasiTransaksi_FormPembaran_Table.cshtml")]
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
#line 1 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\_ViewImports.cshtml"
using WebIOT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\_ViewImports.cshtml"
using WebIOT.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\_ViewImports.cshtml"
using WebIOT.Function;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\_ViewImports.cshtml"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"271b956d3f88e489962f4fe8bf5f287416f7b95a", @"/Views/Sewa/KonfirmasiTransaksi_FormPembaran_Table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9482a01595e1eed09bbb6581e85bd83ae9dc148", @"/Views/_ViewImports.cshtml")]
    public class Views_Sewa_KonfirmasiTransaksi_FormPembaran_Table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TransaksiTransaksiPeminjamanBukuModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:32px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onerror", new global::Microsoft.AspNetCore.Html.HtmlString("this.onerror=null; this.src=\'../../images/error/defaultImg.png\'"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
  
    GlobalFunction f = new GlobalFunction();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
 if (Model.Error != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
Write(await Html.PartialAsync("Error", Model.Error));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
                                                  

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<p> List Item </p>
<table id=""myTableDetail""
       class=""display no-wrap table table-hover table-striped table-bordered compact""
       cellspacing=""0"">
    <thead class=""bg-dark text-light"" style=""font-family:Calibri;font-size:small;"">
        <tr>
            <th width=""30"">no</th>
            <th style=""text-align:center;"">Judul Buku</th>
            <th style=""text-align:center;"">Tanggal</th>
            <th style=""text-align:center;"">Harga /Hari</th>
            <th style=""text-align:center;"">Total Hari</th>
            <th style=""text-align:center;"">Total Sewa</th>
        </tr>
    </thead>
    <tbody style=""font-size:small;font-family:Calibri;"">
");
#nullable restore
#line 27 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
          
            int a = 0;
            decimal GrandTotal = 0;
            foreach (var item in Model.ListData)
            {
                a++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td nowrap align=\"center\" style=\"width:20px;\">");
#nullable restore
#line 34 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
                                                             Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td wrap align=\"left\"> \r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "271b956d3f88e489962f4fe8bf5f287416f7b95a7484", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1205, "~/", 1205, 2, true);
#nullable restore
#line 36 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
AddHtmlAttributeValue("", 1207, item.Img, 1207, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
#nullable restore
#line 40 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
                   Write(item.JudulBuku);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td nowrap align=\"left\">");
#nullable restore
#line 42 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
                                       Write(item.SewaDari);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 42 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
                                                        Write(item.Sewasampai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td nowrap align=\"right\">");
#nullable restore
#line 43 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
                                        Write(item.HargaSewaPerHari.toNumber());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td nowrap align=\"center\">\r\n");
#nullable restore
#line 45 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
                          
                            string d = f.GetDiffDays(item.SewaDari, item.Sewasampai).ToString();
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
                             Write(d);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td nowrap align=\"right\">");
#nullable restore
#line 50 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
                                        Write(item.TotalSewa.toNumber());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"

                GrandTotal = GrandTotal + item.TotalSewa.toDecimal();
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot style=\"font-size:small;font-family:Calibri;\">\r\n        <tr>\r\n            <td align=\"center\" colspan=\"5\">Grand Total</td>\r\n            <td align=\"right\">");
#nullable restore
#line 60 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\KonfirmasiTransaksi_FormPembaran_Table.cshtml"
                         Write(GrandTotal.ToString().toNumber());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        </tr>
    </tfoot>
</table>

<script type=""text/javascript"">
    $(function () {
        var collapsedGroups = {};
        var table = $('#myTableDetail').DataTable({
            ""info"": false,
            ""scrollX"": false,
            ""autoWidth"": false,
            ""paging"": false,
            scrollY: ""50vh"",
            scrollX: !0,
            scrollCollapse: !0,
            iDisplayLength: 100,
            searching: false
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TransaksiTransaksiPeminjamanBukuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591