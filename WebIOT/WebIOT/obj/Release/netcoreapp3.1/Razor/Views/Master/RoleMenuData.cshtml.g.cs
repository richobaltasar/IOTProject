#pragma checksum "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "301c3e7c3631a0cc5956cb466d5bc31a4a04f4be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master_RoleMenuData), @"mvc.1.0.view", @"/Views/Master/RoleMenuData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"301c3e7c3631a0cc5956cb466d5bc31a4a04f4be", @"/Views/Master/RoleMenuData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9482a01595e1eed09bbb6581e85bd83ae9dc148", @"/Views/_ViewImports.cshtml")]
    public class Views_Master_RoleMenuData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleMenuDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/datatables/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/datatables/responsive.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/datatables/dataTables.responsive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/datatables/rowGroup.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/datatables/dataTables.rowGroup.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/dropify/dropify.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/dropify/dropify.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleMenuData_Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("RoleMenuData_Search_Id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData.cshtml"
  
    MasterFunction f = new MasterFunction();
    var formData = new FormMasterData();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData.cshtml"
  
    if (Model.Error == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "301c3e7c3631a0cc5956cb466d5bc31a4a04f4be8862", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "301c3e7c3631a0cc5956cb466d5bc31a4a04f4be10068", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "301c3e7c3631a0cc5956cb466d5bc31a4a04f4be11147", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "301c3e7c3631a0cc5956cb466d5bc31a4a04f4be12270", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "301c3e7c3631a0cc5956cb466d5bc31a4a04f4be13349", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "301c3e7c3631a0cc5956cb466d5bc31a4a04f4be14472", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "301c3e7c3631a0cc5956cb466d5bc31a4a04f4be15551", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "301c3e7c3631a0cc5956cb466d5bc31a4a04f4be16599", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"        <div class=""row page-titles"">
            <div class=""col-md-5 align-self-center"">
                <h4 class=""text-themecolor"">Role Menu Data</h4>
            </div>
            <div class=""col-md-7 align-self-center text-right"">
                <div class=""d-flex justify-content-end align-items-center"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""javascript:void(0)"">Master</a></li>
                        <li class=""breadcrumb-item active"">Role Menu Data</li>
                    </ol>
                </div>
            </div>
        </div>
");
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-12"">
                <div class=""card rounded"">
                    <div class=""card-header"">
                        <button type=""button"" class=""btn btn-info m-l-15""
                                style=""float:right""");
            BeginWriteAttribute("onclick", "\r\n                                onclick=\"", 1877, "\"", 2033, 6);
            WriteAttributeValue("", 1920, "showInPopup(\'", 1920, 13, true);
#nullable restore
#line 45 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData.cshtml"
WriteAttributeValue("", 1933, Url.Action("RoleMenuData_Form","Master",new { id=0},Context.Request.Scheme), 1933, 76, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2009, "\',\'Form", 2009, 7, true);
            WriteAttributeValue(" ", 2016, "Role", 2017, 5, true);
            WriteAttributeValue(" ", 2021, "Menu", 2022, 5, true);
            WriteAttributeValue(" ", 2026, "Data\')", 2027, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fa fa-plus-circle""></i> Create New
                        </button>

                        <button type=""button"" class=""btn btn-outline-info m-l-15""
                                style=""float:right""
                                data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                            <i class=""fa fa-filter""></i> Set Filter
                        </button>
                    </div>
                    <div class=""card-body"">
                        <div class=""accordion"" id=""accordionExample"" style=""margin-top:0px;"">
                            <div class=""card"">
                                <div id=""collapseOne"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "301c3e7c3631a0cc5956cb466d5bc31a4a04f4be20526", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData.cshtml"
                                              
                                                formData.Template = f.GetFormLayoutForFilter("Form RoleMenuData");
                                                formData.ColField = 3;
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData.cshtml"
                                           Write(await Html.PartialAsync("_LayoutFormFilter", formData));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <button type=""submit"" class=""btn waves-effect waves-light btn-rounded btn-outline-primary"">
                                                    <span class=""fa fa-search""></span> Search
                                                </button>
");
                WriteLiteral("                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <hr />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div style=""margin-top:-30px;"">
                            <div id=""view-all"">
                                ");
#nullable restore
#line 77 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData.cshtml"
                           Write(await Html.PartialAsync("RoleMenuData_Table", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral(@"        <div class=""modal"" role=""dialog"" id=""form-modal"">
            <div class=""modal-dialog modal-lg"">
                <div class=""modal-content"">
                    <div class=""modal-header bg-info"" style=""padding: 10px 10px 10px 10px;"">
                        <p class=""modal-title text-white"">Modal title</p>
                        <button type=""button"" class=""close text-white"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                    </div>
                </div>
            </div>
        </div>
");
            WriteLiteral(@"        <script type=""text/javascript"">
            //---- Action RoleMenuData
            showInPopup = (url, title) => {
                $.ajax({
                    type: 'GET',
                    url: url,
                    success: function (res) {
                        console.log(res);
                        $('#form-modal .modal-body').html(res);
                        $('#form-modal .modal-title').html(title);
                        $('#form-modal').modal('show');
                    },
                    error: function (request, status, error) {
                        $("".preloader"").fadeOut();
                    }
                });

            }
            RoleMenuData_Save = form => {
                try {
                    $("".preloader"").fadeIn();
                    var Data = new FormData(form);
                    $.ajax({
                        type: 'POST',
                        url: form.action,
                        data: Data,
            ");
            WriteLiteral(@"            contentType: false,
                        processData: false,
                        success: function (res) {
                            console.log(res);
                            if (res.isValid) {
                                $('#RoleMenuData_Search_Id').submit();
                                $('#form-modal .modal-body').html('');
                                $('#form-modal .modal-title').html('');
                                $('#form-modal').modal('hide');
                                $.notify('submited Successfully', { globalPosition: 'top center', className: 'success' })
                            }
                            else {
                                $(""#title-error"").text(res.title);
                                $(""#message_error"").text(res.message);
                                $(""#error-alert"").show();
                                $(""#error-alert"").fadeTo(10000, 500).slideUp(500, function () {
                                ");
            WriteLiteral(@"    $(""#error-alert"").slideUp(500);
                                });
                            }
                        },
                        error: function (xhr, status, error) {
                            var err = eval(""("" + xhr.responseText + "")"");
                            alert(err.Message);
                            console.log(err);
                            $(""#title-error"").text(""Sorry"");
                            $(""#message_error"").text(""ERROR !! "" + err.responseText);
                            $(""#error-alert"").fadeTo(3000, 500).slideUp(500, function () {
                                $(""#error-alert"").slideUp(500);
                            });
                        }
                    })
                    //to prevent default form submit event
                    $("".preloader"").fadeOut();
                    return false;
                } catch (ex) {
                    console.log(ex)
                    $("".preloader"").fadeOut();
      ");
            WriteLiteral(@"              $(""#title-error"").text(""Sorry"");
                    $(""#message_error"").text(""ERROR !! "");
                    $(""#error-alert"").fadeTo(3000, 500).slideUp(500, function () {
                        $(""#error-alert"").slideUp(500);
                    });
                }
            }
            RoleMenuData_Delete = form => {
                if (confirm('Are you sure to delete this record ?')) {
                    try {
                        $.ajax({
                            type: 'POST',
                            url: form.action,
                            data: new FormData(form),
                            contentType: false,
                            processData: false,
                            success: function (res) {
                                if (res.isValid) {
                                    $('#RoleMenuData_Search_Id').submit();
                                    $.notify(""Data berhasil dihapus"", { globalPosition: 'top center', className:");
            WriteLiteral(@" 'success' });
                                }
                                else {
                                    $.notify('Sorry ' + res.message, { globalPosition: 'top center', className: 'warning' });
                                }
                            },
                            error: function (err) {
                                $.notify('Sorry ' + err.responseText, { globalPosition: 'top center', className: 'warning' });
                            }
                        })
                    } catch (ex) {
                        $.notify('Sorry ' + ex.message, { globalPosition: 'top center', className: 'warning' });

                    }
                    $("".preloader"").fadeOut();
                }

                //prevent default form submit event
                return false;
            }

            function GetMenu(Id) {
                    $('#Filter_IdMenu').find('option:not(:first)').remove();
                    $.ajax({
          ");
            WriteLiteral("              type: \'GET\',\r\n                        url: \'");
#nullable restore
#line 207 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData.cshtml"
                         Write(Url.Action("RoleMenuData_GetMenu", "Master"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?Id=' + Id,
                        success: function (res) {
                            if (res.isValid) {
                                $.each(res.model, function (idx, obj) {
                                    var optionText = """";
                                    var optionValue = 0;
                                    $.each(obj, function (key, value) {
                                        if (key == ""idMenu"") {
                                            optionValue = value;
                                        }
                                        else if (key == ""namaMenu"") {
                                            optionText = value;
                                        }
                                    });
                                    $('#Filter_IdMenu').append(new Option(optionText, optionValue));
                                });
                            }
                            else {
                                $.notify('Sorr");
            WriteLiteral(@"y ' + re.message, { globalPosition: 'top center', className: 'warning' })
                            }
                            $("".preloader"").fadeOut();
                        },
                        error: function (request, status, error) {
                            console.log(error.responseText);
                            $.notify('Sorry ' + error.responseText, { globalPosition: 'top center', className: 'warning' })
                            $("".preloader"").fadeOut();
                        }
                    });
                }
            //-------------------------------
            // External
            MenuData_Save = form => {
                try {
                    $("".preloader"").fadeIn();
                    var Data = new FormData(form);
                    $.ajax({
                        type: 'POST',
                        url: form.action,
                        data: Data,
                        contentType: false,
                        p");
            WriteLiteral(@"rocessData: false,
                        success: function (res) {
                            console.log(res);
                            if (res.isValid) {
                                $('#RoleMenuData_Search_Id').submit();
                                $('#form-modal .modal-body').html('');
                                $('#form-modal .modal-title').html('');
                                $('#form-modal').modal('hide');
                                $.notify('submited Successfully', { globalPosition: 'top center', className: 'success' })
                            }
                            else {
                                $(""#title-error"").text(res.title);
                                $(""#message_error"").text(res.message);
                                $(""#error-alert"").show();
                                $(""#error-alert"").fadeTo(10000, 500).slideUp(500, function () {
                                    $(""#error-alert"").slideUp(500);
                     ");
            WriteLiteral(@"           });
                            }
                        },
                        error: function (xhr, status, error) {
                            var err = eval(""("" + xhr.responseText + "")"");
                            alert(err.Message);
                            console.log(err);
                            $(""#title-error"").text(""Sorry"");
                            $(""#message_error"").text(""ERROR !! "" + err.responseText);
                            $(""#error-alert"").fadeTo(3000, 500).slideUp(500, function () {
                                $(""#error-alert"").slideUp(500);
                            });
                        }
                    })
                    //to prevent default form submit event
                    $("".preloader"").fadeOut();
                    return false;
                } catch (ex) {
                    console.log(ex)
                    $("".preloader"").fadeOut();
                    $(""#title-error"").text(""Sorry"");
          ");
            WriteLiteral(@"          $(""#message_error"").text(""ERROR !! "");
                    $(""#error-alert"").fadeTo(3000, 500).slideUp(500, function () {
                        $(""#error-alert"").slideUp(500);
                    });
                }
            }
            //-------------------------------
            $(function () {
                $(""#RoleMenuData_Search_Id"").submit(function (e){
                    try {
                        e.preventDefault();
                        var Data = new FormData(document.querySelector('form'))
                        $.ajax({
                            type: 'POST',
                            url: document.querySelector('form').action,
                            data: Data,
                            contentType: false,
                            processData: false,
                            success: function (res) {
                                if (res.isValid) {
                                    $('#view-all').html(res.html)
               ");
            WriteLiteral(@"                 }
                                else {
                                    alert(res.title + ""/n"" + res.message);
                                }
                            },
                            error: function (xhr, status, error) {
                                var err = eval(""("" + xhr.responseText + "")"");
                                alert(err.Message);
                            }
                        })
                        //to prevent default form submit event
                        return false;
                    }
                    catch (ex) {
                        $(""#error-alert"").fadeTo(3000, 500).slideUp(500, function () {
                            $(""#error-alert"").slideUp(500);
                        });
                    }
                });

                $('#Filter_IdModule').on('change', function (e) {
                    var optionSelected = $(""option:selected"", this);
                    var valueSelected = t");
            WriteLiteral("his.value;\r\n                    GetMenu(valueSelected);\r\n                });\r\n            });\r\n\r\n        </script>\r\n");
#nullable restore
#line 333 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 336 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData.cshtml"
   Write(await Html.PartialAsync("Error", Model.Error));

#line default
#line hidden
#nullable disable
#nullable restore
#line 336 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData.cshtml"
                                                      
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleMenuDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591