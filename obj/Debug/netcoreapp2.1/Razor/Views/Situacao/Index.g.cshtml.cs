#pragma checksum "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Situacao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f940b8aa62966af6c110af1684fbd6cbc0a951b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Situacao_Index), @"mvc.1.0.view", @"/Views/Situacao/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Situacao/Index.cshtml", typeof(AspNetCore.Views_Situacao_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\_ViewImports.cshtml"
using TrabalhoChamados;

#line default
#line hidden
#line 2 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\_ViewImports.cshtml"
using TrabalhoChamados.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f940b8aa62966af6c110af1684fbd6cbc0a951b3", @"/Views/Situacao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454b01561544319d91586a83dd1ec0cf539f838a", @"/Views/_ViewImports.cshtml")]
    public class Views_Situacao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 362, true);
            WriteLiteral(@"</br></br>
<a href=""Situacao/Create"" class=""btn btn-primary"">Nova Situação</a>
</br></br>

<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                
                <!-- <th>Numero Chamado</th> -->
                <th>Tipo Situacao</th>
            
            </tr>
            </tr>
        </thead>

");
            EndContext();
#line 17 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Situacao\Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(410, 41, true);
            WriteLiteral("            <tr>   \r\n                <td>");
            EndContext();
            BeginContext(452, 17, false);
#line 20 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Situacao\Index.cshtml"
               Write(item.tiposituacao);

#line default
#line hidden
            EndContext();
            BeginContext(469, 55, true);
            WriteLiteral("</td>\r\n\r\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 524, "\"", 553, 2);
            WriteAttributeValue("", 531, "Situacao/Edit/", 531, 14, true);
#line 22 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Situacao\Index.cshtml"
WriteAttributeValue("", 545, item.id, 545, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(554, 38, true);
            WriteLiteral(">Editar</a> </td>\r\n            </tr>\r\n");
            EndContext();
#line 24 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Situacao\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(603, 20, true);
            WriteLiteral("    </table>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
