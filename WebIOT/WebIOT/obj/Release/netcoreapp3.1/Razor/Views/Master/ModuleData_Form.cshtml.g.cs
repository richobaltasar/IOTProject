#pragma checksum "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\ModuleData_Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bd71e52719d075fda06a531f8831b09d24f770e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master_ModuleData_Form), @"mvc.1.0.view", @"/Views/Master/ModuleData_Form.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bd71e52719d075fda06a531f8831b09d24f770e", @"/Views/Master/ModuleData_Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9482a01595e1eed09bbb6581e85bd83ae9dc148", @"/Views/_ViewImports.cshtml")]
    public class Views_Master_ModuleData_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModuleData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ModuleData_Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return ModuleData_Save(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\ModuleData_Form.cshtml"
  
    Layout = "";
    MasterFunction f = new MasterFunction();
    var formData = new FormMasterData();

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\ModuleData_Form.cshtml"
  
    if (Model.Error == null)
    {

        try
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bd71e52719d075fda06a531f8831b09d24f770e5334", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 20 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\ModuleData_Form.cshtml"
          
            formData.Template = f.GetFormLayout("Form Master CRUD");
            formData.ColField = 3;
            if (Model != null)
            {
                formData.dbContext = Model;
            }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\ModuleData_Form.cshtml"
       Write(await Html.PartialAsync("_LayoutForm", formData));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""alert alert-danger"" id=""error-alert"">
                
                <strong id=""title-error""></strong>
                <br />
                <div id=""message_error"" style=""overflow-x:auto;""></div>
            </div>
            <hr />
");
#nullable restore
#line 35 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\ModuleData_Form.cshtml"

            if (Model.IdModul == 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button type=\"submit\" class=\"btn btn-outline-info\" style=\"float:right;\">\r\n                    <span class=\"fa fa-save\"></span> Create\r\n                </button>\r\n");
#nullable restore
#line 41 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\ModuleData_Form.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button type=\"submit\" class=\"btn btn-outline-info\" style=\"float:right;margin-left:10px;\">\r\n                    <span class=\"fa fa-save\"></span> Simpan\r\n                </button>\r\n");
#nullable restore
#line 47 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\ModuleData_Form.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
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
            WriteLiteral("\r\n            <script type=\"text/javascript\">\r\n                $(document).ready(function () {\r\n                    $(\"#error-alert\").hide();\r\n                });\r\n\r\n                \r\n            </script>\r\n");
#nullable restore
#line 57 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\ModuleData_Form.cshtml"
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
#line 64 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\ModuleData_Form.cshtml"
       Write(await Html.PartialAsync("Error", Error));

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\ModuleData_Form.cshtml"
                                                    
        }
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\ModuleData_Form.cshtml"
   Write(await Html.PartialAsync("Error", Model.Error));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Master\ModuleData_Form.cshtml"
                                                      
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModuleData> Html { get; private set; }
    }
}
#pragma warning restore 1591
