#pragma checksum "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce770a5503eaa4d8c5b9ae1d8a65eb3cc7b11560"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserData_Table), @"mvc.1.0.view", @"/Views/User/UserData_Table.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce770a5503eaa4d8c5b9ae1d8a65eb3cc7b11560", @"/Views/User/UserData_Table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9482a01595e1eed09bbb6581e85bd83ae9dc148", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserData_Table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserData_Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return UserData_Delete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
 if (Model.Error != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
Write(await Html.PartialAsync("Error", Model.Error));

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
                                                  
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
 if(Model.ListData != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table id=""myTable""
       class=""table display no-wrap table table-hover table-striped table-bordered compact  table-responsive""
       cellspacing=""0"">
    <thead class=""bg-dark text-light"" style=""font-family:Calibri;font-size:small;"">
        <tr>
            <th width=""30"">no</th>
            <th style=""text-align:center;"">Username</th>
            <th style=""text-align:center;"">NamaLengkap</th>
            <th style=""text-align:center;"">Status</th>
            <th style=""text-align:center;"">Role</th>
            <th style=""text-align:center;"" width=""30"">Action</th>
        </tr>
    </thead>
    <tbody style=""font-size:small;font-family:Calibri;"">
");
#nullable restore
#line 24 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
          
            int a = 0;
            foreach (var item in Model.ListData)
            {
                a++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td nowrap align=\"center\">");
#nullable restore
#line 30 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
                                         Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td align=\"left\">\r\n");
            WriteLiteral("                        <a");
            BeginWriteAttribute("class", " class=\"", 1113, "\"", 1121, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"text-align:left;\"");
            BeginWriteAttribute("href", "\r\n                           href=\"", 1147, "\"", 1307, 6);
            WriteAttributeValue("", 1182, "javascript:showInPopup(\'", 1182, 24, true);
#nullable restore
#line 34 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
WriteAttributeValue("", 1206, Url.Action("UserData_Form","User",new { id=item.id},Context.Request.Scheme), 1206, 76, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1282, "\',\'Form", 1282, 7, true);
            WriteAttributeValue(" ", 1289, "Modif", 1290, 6, true);
            WriteAttributeValue(" ", 1295, "User", 1296, 5, true);
            WriteAttributeValue(" ", 1300, "Data\')", 1301, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce770a5503eaa4d8c5b9ae1d8a65eb3cc7b115609055", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1349, "~/", 1349, 2, true);
#nullable restore
#line 35 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
AddHtmlAttributeValue("", 1351, item.Photo, 1351, 11, false);

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
            WriteLiteral("\r\n                            ");
#nullable restore
#line 36 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
                       Write(item.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                    <td nowrap align=\"left\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
                   Write(item.NamaLengkap);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td nowrap align=\"center\" width=\"30\">\r\n");
#nullable restore
#line 43 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
                          
                            if (item.Status == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"badge badge-success\">Aktif</div>\r\n");
#nullable restore
#line 47 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"badge badge-danger\">Non Aktif</div>\r\n");
#nullable restore
#line 51 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td nowrap align=\"center\">");
#nullable restore
#line 54 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
                                         Write(item.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td nowrap align=\"center\" width=\"30\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce770a5503eaa4d8c5b9ae1d8a65eb3cc7b1156012912", async() => {
                WriteLiteral(@"
                            <button type=""submit""
                                    class=""m-portlet__nav-link btn m-btn m-btn--hover-warning m-btn--icon m-btn--icon-only m-btn--pill""
                                    title=""View"">
                                <i class=""fa fa-trash""></i>
                            </button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
                                                             WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 65 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            WriteLiteral(@"<script type=""text/javascript"">
    $(function () {
        var collapsedGroups = {};
        var table = $('#myTable').DataTable({
            ""info"": false,
            ""scrollX"": false,
            ""autoWidth"": true,
            ""paging"": false,
            searching: false,
            order: [[4, 'asc']],
            rowGroup: {
                // Uses the 'row group' plugin
                dataSrc: 4,
                startRender: function (rows, group) {
                    var collapsed = !!collapsedGroups[group];

                    rows.nodes().each(function (r) {
                        r.style.display = collapsed ? 'none' : '';
                    });

                    // Add category name to the <tr>. NOTE: Hardcoded colspan
                    return $('<tr/>')
                        .append('<td colspan=""6"">' + group + ' (' + rows.count() + ')</td>')
                        .attr('data-name', group)
                        .toggleClass('collapsed', collapsed);
     ");
            WriteLiteral(@"           }
            }
        });
        $('#myTable tbody').on('click', 'tr.group-start', function () {
            var name = $(this).data('name');
            console.log(name);
            collapsedGroups[name] = !collapsedGroups[name];
            table.draw(false);
        }); 
    });
</script>
");
#nullable restore
#line 106 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\User\UserData_Table.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591