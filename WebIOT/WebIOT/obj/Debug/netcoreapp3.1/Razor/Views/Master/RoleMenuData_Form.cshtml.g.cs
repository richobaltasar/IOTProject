#pragma checksum "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e71b58bb430eeb70dc0b2efe014fec0e1f13087b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master_RoleMenuData_Form), @"mvc.1.0.view", @"/Views/Master/RoleMenuData_Form.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e71b58bb430eeb70dc0b2efe014fec0e1f13087b", @"/Views/Master/RoleMenuData_Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9482a01595e1eed09bbb6581e85bd83ae9dc148", @"/Views/_ViewImports.cshtml")]
    public class Views_Master_RoleMenuData_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleMenuData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleMenuData_Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return RoleMenuData_Save(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"
  
    Layout = "";
    MasterFunction f = new MasterFunction();
    var formData = new FormMasterData();

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"
  
    if (Model.Error == null)
    {

        try
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e71b58bb430eeb70dc0b2efe014fec0e1f13087b5442", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 20 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"
                  
                    formData.Template = f.GetFormLayout("Form RoleMenuData");
                    formData.ColField = 2;
                    if (Model != null)
                    {
                        formData.dbContext = Model;
                    }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"
               Write(await Html.PartialAsync("_LayoutForm", formData));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <script type=""text/javascript"">
                $(document).ready(function () {

                    $('#Posisi').on('change', function (e) {
                        var optionSelected = $(""option:selected"", this);
                        var IdPosisi = this.value;
                        if (IdPosisi > 1) {
                            var IdModule = $('#IdModule option:selected').val();
                            var IdMenu = $('#IdMenu option:selected').val();
                            GetParent(IdModule, IdMenu, IdPosisi);
                        }
                        else {
                            $('#IdParent').empty();
                        }
                    });


                    var IdModule = $('#IdModule option:selected').val();
                    var IdMenu = $('#IdMenu option:selected').val();
                    var IdPosisi = $('#Posisi option:selected').val();

                    GetParent(IdModule, IdMenu, IdPosisi);

               ");
                WriteLiteral("     function GetParent(IdModule,IdMenu,IdPosisi) {\r\n                        $(\'#IdParent\').empty();\r\n                        $.ajax({\r\n                            type: \'GET\',\r\n                            url: \'");
#nullable restore
#line 56 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"
                             Write(Url.Action("RoleMenuData_GetParent", "Master"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + '?IdModule=' + IdModule + '&IdMenu=' + IdMenu + '&IdPosisi=' + IdPosisi,
                            success: function (res) {
                                if (res.isValid) {
                                    $.each(res.model, function (idx, obj) {
                                        console.log(obj);
                                        var optionText = """";
                                        var optionValue = 0;
                                        $.each(obj, function (key, value) {
                                            if (key == ""value"") {
                                                optionValue = value;
                                            }
                                            else if (key == ""text"") {
                                                optionText = value;
                                            }
                                        });
                                        $('#IdParent').append(new Option(optionText, o");
                WriteLiteral("ptionValue));\r\n                                    });\r\n                                    $(\"#IdParent option[value=\'");
#nullable restore
#line 73 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"
                                                          Write(Model.IdParent);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"']"").prop('selected', true);
                                }
                                else {
                                    $.notify('Sorry ' + res.message, { globalPosition: 'top center', className: 'warning' })
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


                });
                </script>
                    <div class=""alert alert-danger"" id=""error-alert"">

                        <strong id=""title-error""></strong>
                        <br />
                        <div id=""messag");
                WriteLiteral("e_error\" style=\"overflow-x:auto;\"></div>\r\n                    </div>\r\n                    <hr />\r\n");
#nullable restore
#line 98 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"

                    if (Model.IdRole == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-outline-info\" style=\"float:right;\">\r\n                            <span class=\"fa fa-save\"></span> Create\r\n                        </button>\r\n");
#nullable restore
#line 104 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-outline-info\" style=\"float:right;margin-left:10px;\">\r\n                            <span class=\"fa fa-save\"></span> Simpan\r\n                        </button>\r\n");
#nullable restore
#line 110 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <script type=\"text/javascript\">\r\n                $(document).ready(function () {\r\n                    $(\"#error-alert\").hide();\r\n\r\n                });\r\n                \r\n            </script>\r\n");
#nullable restore
#line 120 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"
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
#line 127 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"
       Write(await Html.PartialAsync("Error", Error));

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"
                                                    
        }
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"
   Write(await Html.PartialAsync("Error", Model.Error));

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "D:\Tentakel\UII\Project\OEE Dashboard\IOTProject\WebIOT\WebIOT\Views\Master\RoleMenuData_Form.cshtml"
                                                      
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleMenuData> Html { get; private set; }
    }
}
#pragma warning restore 1591
