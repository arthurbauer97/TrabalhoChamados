#pragma checksum "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Chamado\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "172192cb176dc50d6320a320dec15a1cf7f304d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chamado_Create), @"mvc.1.0.view", @"/Views/Chamado/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chamado/Create.cshtml", typeof(AspNetCore.Views_Chamado_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"172192cb176dc50d6320a320dec15a1cf7f304d5", @"/Views/Chamado/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454b01561544319d91586a83dd1ec0cf539f838a", @"/Views/_ViewImports.cshtml")]
    public class Views_Chamado_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<div class=\"form-horizontal\">\r\n    ");
            EndContext();
            BeginContext(35, 1478, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a75ba068825a4e3289c4458135b6e2f7", async() => {
                BeginContext(71, 144, true);
                WriteLiteral("\r\n\r\n        \r\n        <div class=\"form-group\">\r\n            <label>Cliente</label>\r\n          <select class=\"form-control\" name =\"cliente.id\">\r\n");
                EndContext();
#line 8 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Chamado\Create.cshtml"
             foreach(var cliente in @ViewBag.clientes)
            {

#line default
#line hidden
                BeginContext(286, 14, true);
                WriteLiteral("              ");
                EndContext();
                BeginContext(300, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f63e59f61d245fbb0737bc60fefc2fb", async() => {
                    BeginContext(327, 19, false);
#line 10 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Chamado\Create.cshtml"
                                   Write(cliente.nomecliente);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 10 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Chamado\Create.cshtml"
                WriteLiteral(cliente.id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(355, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 11 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Chamado\Create.cshtml"
            }

#line default
#line hidden
                BeginContext(372, 192, true);
                WriteLiteral("          </select>\r\n                    \r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Situação</label>\r\n          <select class=\"form-control\" name=\"situacao.id\">\r\n");
                EndContext();
#line 19 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Chamado\Create.cshtml"
             foreach(var situacao in @ViewBag.situacoes)
            {

#line default
#line hidden
                BeginContext(637, 14, true);
                WriteLiteral("              ");
                EndContext();
                BeginContext(651, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c735e6e7dd64c5b80d525b469f44361", async() => {
                    BeginContext(679, 21, false);
#line 21 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Chamado\Create.cshtml"
                                    Write(situacao.tiposituacao);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 21 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Chamado\Create.cshtml"
                WriteLiteral(situacao.id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(709, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 22 "C:\Users\Arthur\Desktop\TrabalhoChamados\Views\Chamado\Create.cshtml"
            }

#line default
#line hidden
                BeginContext(726, 780, true);
                WriteLiteral(@"          </select>
                    
        </div>

        <div class=""form-group"">
            <label>Data</label>
            <input  class=""form-control""
                    type=""date"" name=""data""/>
        </div>

        
          <div class=""form-group"">
            <label>Descrição do Problema</label>
            <input  class=""form-control""
                    type=""text"" 
                    name=""descricao""/>
        </div>

          <div class=""form-group"">
            <label>Hora Inicio</label>
            <input  class=""form-control""
                    type=""time"" 
                    name=""horainicio""/>
        </div>
        
        <input  class=""btn btn-primary"" 
                type=""submit"" value=""Salvar""/>

    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1513, 8, true);
            WriteLiteral("\r\n</div>");
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
