#pragma checksum "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Shared\_LayoutFormFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3021e6a309b1069d7ec357b813f635e1acb3363a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutFormFilter), @"mvc.1.0.view", @"/Views/Shared/_LayoutFormFilter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3021e6a309b1069d7ec357b813f635e1acb3363a", @"/Views/Shared/_LayoutFormFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9482a01595e1eed09bbb6581e85bd83ae9dc148", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutFormFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FormMasterData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 3 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Shared\_LayoutFormFilter.cshtml"
      
        GlobalFunction GF = new GlobalFunction();
        
        int a = 12 / Model.ColField;
        foreach (var d in Model.Template)
        {
            if (Model.dbContext != null)
            {
                d.ValueInput = GF.GetPropValue(Model.dbContext, d.Id.Trim());
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 372, "\"", 389, 2);
            WriteAttributeValue("", 380, "col-md-", 380, 7, true);
#nullable restore
#line 14 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Shared\_LayoutFormFilter.cshtml"
WriteAttributeValue("", 387, a, 387, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Shared\_LayoutFormFilter.cshtml"
                                     if (d.ShowHide != "Show") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" hidden=\"hidden\" ");
#nullable restore
#line 14 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Shared\_LayoutFormFilter.cshtml"
                                                                                                 } 

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">\r\n                        ");
#nullable restore
#line 17 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Shared\_LayoutFormFilter.cshtml"
                   Write(d.TextLabel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </label>\r\n                    ");
#nullable restore
#line 19 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Shared\_LayoutFormFilter.cshtml"
               Write(await Html.PartialAsync("_LayoutTypeInputFilter", d));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 22 "C:\Users\richo\source\repos\IOTProject\WebIOT\WebIOT\Views\Shared\_LayoutFormFilter.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FormMasterData> Html { get; private set; }
    }
}
#pragma warning restore 1591
