#pragma checksum "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60f3c327dfa98e09519d5fbb7ec29c7d7976a8a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master_RoleGroupAkses_ListMenu), @"mvc.1.0.view", @"/Views/Master/RoleGroupAkses_ListMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60f3c327dfa98e09519d5fbb7ec29c7d7976a8a7", @"/Views/Master/RoleGroupAkses_ListMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9482a01595e1eed09bbb6581e85bd83ae9dc148", @"/Views/_ViewImports.cshtml")]
    public class Views_Master_RoleGroupAkses_ListMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleGroupAkses_ListMenu_Model>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleMenuData_ListMenu_Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return RoleMenuData_ListMenu_Delete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
  
    Layout = "";
    MasterFunction f = new MasterFunction();
    var formData = new FormMasterData();

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
  
    if (Model.Error == null)
    {

        try
        {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"view-all-2\">\r\n\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <fieldset disabled>\r\n");
#nullable restore
#line 22 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
                      
                        formData.Template = f.GetFormLayout("Form RoleGroupAkses");
                        formData.ColField = 2;
                        if (Model.Data != null)
                        {
                            formData.dbContext = Model.Data;
                        }
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
                   Write(await Html.PartialAsync("_LayoutForm", formData));

#line default
#line hidden
#nullable disable
            WriteLiteral("                </fieldset>\r\n\r\n            </div>\r\n        </div>\r\n        <p style=\"font-style:italic;\">*List Menu yang dapat diakses group ");
#nullable restore
#line 35 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
                                                                     Write(Model.Data.NamaGroup);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <table id=""myTable2""
               class=""display no-wrap table table-hover table-striped table-bordered compact""
               cellspacing=""0"">
            <thead class=""bg-dark text-light"" style=""font-family:Calibri;font-size:small;"">
                <tr>
                    <th width=""30"">no</th>
                    <th style=""text-align:center;"">NamaMenu</th>
                    <th style=""text-align:center;"" width=""30"">
                        <a");
            BeginWriteAttribute("class", " class=\"", 1539, "\"", 1547, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"text-align:center;\"");
            BeginWriteAttribute("href", "\r\n                           href=\"", 1575, "\"", 1758, 4);
            WriteAttributeValue("", 1610, "javascript:showInPopup_AddMenu(\'", 1610, 32, true);
#nullable restore
#line 45 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
WriteAttributeValue("", 1642, Url.Action("RoleGroupAkses_ListMenuData","Master",new { id=Model.Data.IdRole},Context.Request.Scheme), 1642, 102, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1744, "\',\'List", 1744, 7, true);
            WriteAttributeValue(" ", 1751, "Menu\')", 1752, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fa fa-plus\"></i> Add\r\n                        </a>\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody style=\"font-size:small;font-family:Calibri;\">\r\n");
#nullable restore
#line 53 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
                  
                    
                    foreach (var item in Model.ListMenu)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td nowrap align=\"center\">");
#nullable restore
#line 58 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
                                                 Write(item.idMenu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td nowrap align=\"left\">\r\n                                ");
#nullable restore
#line 60 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
                           Write(item.NamaMenu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td align=\"center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60f3c327dfa98e09519d5fbb7ec29c7d7976a8a79700", async() => {
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id_role", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
                                                                                       WriteLiteral(Model.Data.IdRole);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id_role"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id_role", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id_role"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
                                                                                                                              WriteLiteral(item.idMenu);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id_menu"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id_menu", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id_menu"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 72 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
        <script type=""text/javascript"">
            $(function () {
                var collapsedGroups = {};
                var table = $('#myTable2').DataTable({
                    ""info"": false,
                    ""scrollX"": true,
                    ""autoWidth"": false,
                    ""paging"": true,
                    scrollY: ""50vh"",
                    scrollX: !0,
                    scrollCollapse: !0,
                    iDisplayLength: 100,
                    searching: true,
                });
            });
        </script>

    </div>
");
#nullable restore
#line 94 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
            

            
        }
        catch (Exception ex)
        {
            var Error = new ErrorViewModel();
            Error.MessageContent = ex.ToString();
            Error.MessageTitle = "Error ";
            Error.RequestId = Activity.Current?.Id ?? "0";
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
       Write(await Html.PartialAsync("Error", Error));

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
                                                    
        }
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
   Write(await Html.PartialAsync("Error", Model.Error));

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleGroupAkses_ListMenu.cshtml"
                                                      
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleGroupAkses_ListMenu_Model> Html { get; private set; }
    }
}
#pragma warning restore 1591