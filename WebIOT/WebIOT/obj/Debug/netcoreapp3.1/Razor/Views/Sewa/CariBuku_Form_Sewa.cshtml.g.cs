#pragma checksum "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27496978e95c2f044dcdafc494bf531b849e00da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sewa_CariBuku_Form_Sewa), @"mvc.1.0.view", @"/Views/Sewa/CariBuku_Form_Sewa.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27496978e95c2f044dcdafc494bf531b849e00da", @"/Views/Sewa/CariBuku_Form_Sewa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9482a01595e1eed09bbb6581e85bd83ae9dc148", @"/Views/_ViewImports.cshtml")]
    public class Views_Sewa_CariBuku_Form_Sewa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FormPeminjamanBuku>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;border-radius:10px 10px;max-height:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("shadow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CariBuku_AddCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return CariBuku_AddCart(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
  
    Layout = "";
    MasterFunction f = new MasterFunction();
    var formData = new FormMasterData();

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
  
    if (Model.Error == null)
    {

        try
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27496978e95c2f044dcdafc494bf531b849e00da6247", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("            <div class=\"container\">\r\n                <div class=\"row\">\r\n                            <div class=\"col-sm-6\">\r\n                                <div class=\"card-body slides\" style=\"height:450px;\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "27496978e95c2f044dcdafc494bf531b849e00da6808", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 724, "~/", 724, 2, true);
#nullable restore
#line 25 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
AddHtmlAttributeValue("", 726, Model.Img, 726, 10, false);

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
                WriteLiteral("\r\n                                    <h4 style=\"margin-bottom:0px;margin-top:20px;\">");
#nullable restore
#line 26 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
                                                                              Write(Model.JudulBuku);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                    <p style=\"font-style:italic;margin:0px 0px 0px 0px;color:dimgray;font-size:small;\">Author by ");
#nullable restore
#line 27 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
                                                                                                                            Write(Model.Pengarang);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <br />\r\n                                    <strong>Kategory buku ");
#nullable restore
#line 29 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
                                                     Write(Model.JenisBuku);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </strong>\r\n                                    <br />\r\n                                    <strong>Sewa Rp ");
#nullable restore
#line 31 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
                                               Write(Model.HargaSewaPerHari.toNumber());

#line default
#line hidden
#nullable disable
                WriteLiteral("/Hari </strong>\r\n                                </div>\r\n                            </div>\r\n                    <div class=\"col-sm-6\">\r\n");
#nullable restore
#line 35 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
                          
                            formData.Template = f.GetFormLayout("Form FormPeminjamanBuku");
                            formData.ColField = 1;
                            if (Model != null)
                            {
                                formData.dbContext = Model;
                            }
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
                       Write(await Html.PartialAsync("_LayoutForm", formData));

#line default
#line hidden
#nullable disable
                WriteLiteral("                        \r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
                WriteLiteral("            <div class=\"alert alert-danger\" id=\"error-alert\">\r\n\r\n                <strong id=\"title-error\"></strong>\r\n                <br />\r\n                <div id=\"message_error\" style=\"overflow-x:auto;\"></div>\r\n            </div>\r\n            <hr />\r\n");
                WriteLiteral("            <button type=\"submit\" class=\"btn btn-outline-info\" style=\"float:right;margin-left:10px;\">\r\n                <span class=\"fa fa-save\"></span> Add List\r\n            </button>\r\n");
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script type=""text/javascript"">
        var dari = $(""#SewaDari"");
        var sampai = $(""#Sewasampai"");
        

        $(document).ready(function () {
            $(""#error-alert"").hide();

            var dateToday = new Date(); 
            $('#Sewasampai').datepicker('setStartDate', new Date());

            $(""#SewaDari"").on('changeDate', function (selected) {
                var startDate = new Date(selected.date.valueOf());
                $(""#Sewasampai"").datepicker('setStartDate', startDate);
                if ($(""#SewaDari"").val() > $(""#Sewasampai"").val()) {
                    $(""#Sewasampai"").val($(""#SewaDari"").val());
                }
                SetTotaSewa(dari.val(), sampai.val(),");
#nullable restore
#line 79 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
                                                Write(Model.HargaSewaPerHari.toDecimal());

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            });\r\n            $(\"#Sewasampai\").on(\'changeDate\', function (selected) {\r\n                SetTotaSewa(dari.val(), sampai.val(),");
#nullable restore
#line 82 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
                                                Write(Model.HargaSewaPerHari.toDecimal());

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            });\r\n        });\r\n        function SetTotaSewa(dari, sampai, harga) {\r\n            $(\".preloader\").fadeIn();\r\n            $.ajax({\r\n                type: \'GET\',\r\n                url: \'");
#nullable restore
#line 89 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
                 Write(Url.Action("CariBuku_GetTotalSewa", "Sewa"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?Dari=' + dari + '&Sampai=' + sampai + '&Harga=' + harga,
                success: function (res) {
                    //console.log(res);
                    $("".preloader"").fadeOut();
                    if (res.isValid) {
                        $(""#TotalSewa"").val(res.totalSewa);
                    }
                    else {
                        Swal.fire(
                            'Upss, Sorry !',
                            'Tidak dapat terhubung ke Web Services Silahkan check Internet Anda ',
                            //+ res.message,
                            'warning'
                        )
                        //$.notify('Sorry ' + res.message, { globalPosition: 'top center', className: 'warning' })
                    }
                    $("".preloader"").fadeOut();
                },
                error: function (request, status, error) {
                    console.log(error.responseText);
                    $.notify('Sorry ' + error.responseText, {");
            WriteLiteral(" globalPosition: \'top center\', className: \'warning\' })\r\n                    $(\".preloader\").fadeOut();\r\n                }\r\n            });\r\n        }\r\n\r\n    </script>\r\n");
#nullable restore
#line 116 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
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
#line 123 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
       Write(await Html.PartialAsync("Error", Error));

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
                                                    
        }
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
   Write(await Html.PartialAsync("Error", Model.Error));

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Sewa\CariBuku_Form_Sewa.cshtml"
                                                      
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FormPeminjamanBuku> Html { get; private set; }
    }
}
#pragma warning restore 1591
