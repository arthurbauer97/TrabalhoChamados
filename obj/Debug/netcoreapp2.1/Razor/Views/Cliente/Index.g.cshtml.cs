#pragma checksum "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "976079c6b10e1a6d3f6cc357684a6addfc8e10f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Index.cshtml", typeof(AspNetCore.Views_Cliente_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"976079c6b10e1a6d3f6cc357684a6addfc8e10f4", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454b01561544319d91586a83dd1ec0cf539f838a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 412, true);
            WriteLiteral(@"</br></br>
<a href=""Cliente/Create"" class=""btn btn-primary"">Novo Cliente</a>
</br></br>

<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                
                <!-- <th>Numero Chamado</th> -->
                <th>Nome Cliente</th>
                <th>Email</th>
                <th>Telefone</th>
            </tr>
            </tr>
        </thead>

");
            EndContext();
#line 18 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Cliente\Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(460, 41, true);
            WriteLiteral("            <tr>   \r\n                <td>");
            EndContext();
            BeginContext(502, 16, false);
#line 21 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Cliente\Index.cshtml"
               Write(item.nomecliente);

#line default
#line hidden
            EndContext();
            BeginContext(518, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(546, 10, false);
#line 22 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Cliente\Index.cshtml"
               Write(item.email);

#line default
#line hidden
            EndContext();
            BeginContext(556, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(584, 13, false);
#line 23 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Cliente\Index.cshtml"
               Write(item.telefone);

#line default
#line hidden
            EndContext();
            BeginContext(597, 54, true);
            WriteLiteral("</td>\r\n\r\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 651, "\"", 681, 2);
            WriteAttributeValue("", 658, "Cliente/Delete/", 658, 15, true);
#line 25 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 673, item.id, 673, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(682, 65, true);
            WriteLiteral(">Delete</a> </td>\r\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 747, "\"", 775, 2);
            WriteAttributeValue("", 754, "Cliente/Edit/", 754, 13, true);
#line 26 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 767, item.id, 767, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(776, 38, true);
            WriteLiteral(">Editar</a> </td>\r\n            </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Cliente\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(825, 20, true);
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
