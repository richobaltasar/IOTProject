#pragma checksum "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bac9473c09b1fea530ffd8ccf022637739d2f0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sewa_CariBuku), @"mvc.1.0.view", @"/Views/Sewa/CariBuku.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bac9473c09b1fea530ffd8ccf022637739d2f0f", @"/Views/Sewa/CariBuku.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9482a01595e1eed09bbb6581e85bd83ae9dc148", @"/Views/_ViewImports.cshtml")]
    public class Views_Sewa_CariBuku : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CariBukuModel>
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
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("app-search d-none d-md-block d-lg-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CariBuku_Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("CariBuku_Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:-20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku.cshtml"
  
    MasterFunction f = new MasterFunction();
    var formData = new FormMasterData();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku.cshtml"
  
    if (Model.Error == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8bac9473c09b1fea530ffd8ccf022637739d2f0f9543", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bac9473c09b1fea530ffd8ccf022637739d2f0f10749", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8bac9473c09b1fea530ffd8ccf022637739d2f0f11828", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bac9473c09b1fea530ffd8ccf022637739d2f0f12951", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8bac9473c09b1fea530ffd8ccf022637739d2f0f14030", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bac9473c09b1fea530ffd8ccf022637739d2f0f15153", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bac9473c09b1fea530ffd8ccf022637739d2f0f16232", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8bac9473c09b1fea530ffd8ccf022637739d2f0f17280", async() => {
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

            </div>
            <div class=""col-md-7 align-self-center text-right"">
                <div class=""d-flex justify-content-end align-items-center"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""javascript:void(0)"">Home</a></li>
                        <li class=""breadcrumb-item active"">Cari Buku</li>
                    </ol>
                </div>
            </div>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bac9473c09b1fea530ffd8ccf022637739d2f0f19011", async() => {
                WriteLiteral("\r\n            <input type=\"text\" class=\"form-control\" placeholder=\"Cari Buku\" style=\"border-color:gray;\" name=\"AllText\" id=\"AllText\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("        <div id=\"view-grid\">\r\n            ");
#nullable restore
#line 45 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku.cshtml"
       Write(await Html.PartialAsync("CariBuku_Grid", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <!--<div class=""row"">
            <div class=""col-12"">
                <div class=""card rounded"">
                    <div class=""card-header"">
                        <button type=""button"" class=""btn btn-info m-l-15""
                                style=""float:right""
                                onclick=""showInPopup('");
#nullable restore
#line 53 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku.cshtml"
                                                 Write(Url.Action("BukuData_Form","Master",new { id=0},Context.Request.Scheme));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"','Form Buku Data')"">
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
                                    <div class=""card-body"">-->
");
            WriteLiteral(@"        <!--<hr />
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>-->
");
            WriteLiteral(@"        <div class=""modal"" role=""dialog"" id=""form-modal"">
            <div class=""modal-dialog modal-lg"">
                <div class=""modal-content"">
                    <div class=""modal-header bg-dark"" style=""padding: 10px 10px 10px 10px;"">
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

            BukuData_Save = form => {
                try {
                    $("".preloader"").fadeIn();
                    var Data = new FormData(form);

                    if ($('#File_Img')[0].files.length > 0) {
                        Data.append('File_Img', $('#File_Img')[0].files[0]);
                    }

                    $.ajax({
     ");
            WriteLiteral(@"                   type: 'POST',
                        url: form.action,
                        data: Data,
                        contentType: false,
                        processData: false,
                        success: function (res) {
                            console.log(res);
                            if (res.isValid) {
                                $('#BukuData_Search').submit();
                                $('#form-modal .modal-body').html('');
                                $('#form-modal .modal-title').html('');
                                $('#form-modal').modal('hide');
                                $.notify('submited Successfully', { globalPosition: 'top center', className: 'success' })
                            }
                            else {
                                $(""#title-error"").text(res.title);
                                $(""#message_error"").text(res.message);
                                $(""#error-alert"").show();
          ");
            WriteLiteral(@"                      $(""#error-alert"").fadeTo(10000, 500).slideUp(500, function () {
                                    $(""#error-alert"").slideUp(500);
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
    ");
            WriteLiteral(@"            } catch (ex) {
                    console.log(ex)
                    $("".preloader"").fadeOut();
                    $(""#title-error"").text(""Sorry"");
                    $(""#message_error"").text(""ERROR !! "");
                    $(""#error-alert"").fadeTo(3000, 500).slideUp(500, function () {
                        $(""#error-alert"").slideUp(500);
                    });
                }
            }
            BukuData_Delete = form => {
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
                                    $('#BukuData_Search').submit();
    ");
            WriteLiteral(@"                                $.notify(""Data berhasil dihapus"", { globalPosition: 'top center', className: 'success' });
                                }
                                else {
                                    $.notify('Sorry ' + res.message, { globalPosition: 'top center', className: 'warning' })
                                }
                            },
                            error: function (err) {
                                $.notify('Sorry ' + err.responseText, { globalPosition: 'top center', className: 'warning' });
                            }
                        })
                    } catch (ex) {
                        $.notify('Sorry ' + ex.message, { globalPosition: 'top center', className: 'warning' });
                    }
                }

                //prevent default form submit event
                return false;
            }

            CariBuku_AddCart = form => {
                try {
                    $("".preloade");
            WriteLiteral(@"r"").fadeIn();
                    var Data = new FormData(form);
                    $.ajax({
                        type: 'POST',
                        url: form.action,
                        data: Data,
                        contentType: false,
                        processData: false,
                        success: function (res) {
                            console.log(res);
                            if (res.isValid) {
                                $('#BukuData_Search').submit();
                                $('#form-modal .modal-body').html('');
                                $('#form-modal .modal-title').html('');
                                $('#form-modal').modal('hide');
                                Swal.fire({
                                    title: '<strong>' + res.title + '</strong>',
                                    icon: 'info',
                                    html:
                                        '<p>' + res.message + '</p>',
     ");
            WriteLiteral(@"                               showCloseButton: true,
                                    showDenyButton: true,
                                    confirmButtonText: 'Checkout',
                                    denyButtonText: 'Cari Lagi',
                                }).then((result) => {
                                    if (result.isConfirmed) {
                                        location.href = '");
#nullable restore
#line 238 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku.cshtml"
                                                    Write(Url.Action("TransaksiPeminjaman", "Sewa"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
                                    }
                                })
                            }
                            else {
                                $(""#title-error"").text(res.title);
                                $(""#message_error"").text(res.message);
                                $(""#error-alert"").show();
                                $(""#error-alert"").fadeTo(10000, 500).slideUp(500, function () {
                                    $(""#error-alert"").slideUp(500);
                                });
                            }
                        },
                        error: function (xhr, status, error) {
                            var err = eval(""("" + xhr.responseText + "")"");
                            $(""#title-error"").text(""Sorry"");
                            $(""#message_error"").text(""ERROR !! "" + err.responseText);
                            $(""#error-alert"").fadeTo(3000, 500).slideUp(500, function () {
                                $(""#e");
            WriteLiteral(@"rror-alert"").slideUp(500);
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
                    $(""#message_error"").text(""ERROR !! "");
                    $(""#error-alert"").fadeTo(3000, 500).slideUp(500, function () {
                        $(""#error-alert"").slideUp(500);
                    });
                }
            }

            $(function () {
                $(""#CariBuku_Search"").submit(function (e) {
                    try {
                        e.preventDefault();
                        var Data = new FormData(document.querySelector('form'))
                        console.log(Data);
                        $.ajax({
               ");
            WriteLiteral(@"             type: 'POST',
                            url: document.querySelector('form').action,
                            data: Data,
                            contentType: false,
                            processData: false,
                            success: function (res) {
                                if (res.isValid) {
                                    $('#view-grid').html(res.html)
                                }
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
      ");
            WriteLiteral(@"              catch (ex) {
                        $(""#error-alert"").fadeTo(3000, 500).slideUp(500, function () {
                            $(""#error-alert"").slideUp(500);
                        });
                    }
                });
            });
        </script>
");
#nullable restore
#line 310 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 313 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku.cshtml"
   Write(await Html.PartialAsync("Error", Model.Error));

#line default
#line hidden
#nullable disable
#nullable restore
#line 313 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku.cshtml"
                                                      
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CariBukuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
