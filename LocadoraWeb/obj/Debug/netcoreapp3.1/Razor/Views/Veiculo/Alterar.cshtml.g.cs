#pragma checksum "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\Veiculo\Alterar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ca93b670f534a8238c041675d548cb20faa052c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veiculo_Alterar), @"mvc.1.0.view", @"/Views/Veiculo/Alterar.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\_ViewImports.cshtml"
using LocadoraWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ca93b670f534a8238c041675d548cb20faa052c", @"/Views/Veiculo/Alterar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6ccd57c4af67623a1436849551f668433b638b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Veiculo_Alterar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Alterar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Veiculo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\Veiculo\Alterar.cshtml"
  
    Veiculo veiculo = ViewBag.Veiculo;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ca93b670f534a8238c041675d548cb20faa052c4477", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Alterar Veículo</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ca93b670f534a8238c041675d548cb20faa052c5546", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ca93b670f534a8238c041675d548cb20faa052c5808", async() => {
                    WriteLiteral("\r\n        <fieldset>\r\n            <legend>Alterar veículo</legend>\r\n            <label for=\"txtId\">Id:</label>\r\n            <input");
                    BeginWriteAttribute("value", " value=\"", 394, "\"", 413, 1);
#nullable restore
#line 16 "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\Veiculo\Alterar.cshtml"
WriteAttributeValue("", 402, veiculo.Id, 402, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"txtId\" readonly type=\"text\" placeholder=\"Id do Veículo\" /><br />\r\n\r\n            <label for=\"txtMarca\">Marca:</label>\r\n            <input");
                    BeginWriteAttribute("value", " value=\"", 557, "\"", 579, 1);
#nullable restore
#line 19 "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\Veiculo\Alterar.cshtml"
WriteAttributeValue("", 565, veiculo.Marca, 565, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"txtMarca\" type=\"text\" placeholder=\"Marca do Veículo\" /><br />\r\n            <label for=\"txtModelo\">Modelo:</label>\r\n            <input");
                    BeginWriteAttribute("value", " value=\"", 720, "\"", 743, 1);
#nullable restore
#line 21 "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\Veiculo\Alterar.cshtml"
WriteAttributeValue("", 728, veiculo.Modelo, 728, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"txtModelo\" type=\"text\" placeholder=\"Modelo do Veículo\" /><br />\r\n            <label for=\"txtPlaca\">Placa:</label>\r\n            <input");
                    BeginWriteAttribute("value", " value=\"", 884, "\"", 906, 1);
#nullable restore
#line 23 "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\Veiculo\Alterar.cshtml"
WriteAttributeValue("", 892, veiculo.Placa, 892, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"txtPlaca\" type=\"text\" placeholder=\"Placa do Veículo\" /><br />\r\n            <label for=\"txtRenavan\">Renavan:</label>\r\n            <input");
                    BeginWriteAttribute("value", " value=\"", 1049, "\"", 1073, 1);
#nullable restore
#line 25 "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\Veiculo\Alterar.cshtml"
WriteAttributeValue("", 1057, veiculo.Renavan, 1057, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"txtRenavan\" type=\"text\" placeholder=\"Renavan do Veículo\" /><br />\r\n            <label for=\"txtCor\">Cor:</label>\r\n            <input");
                    BeginWriteAttribute("value", " value=\"", 1212, "\"", 1232, 1);
#nullable restore
#line 27 "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\Veiculo\Alterar.cshtml"
WriteAttributeValue("", 1220, veiculo.Cor, 1220, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"txtCor\" type=\"text\" placeholder=\"Cor do Veículo\" /><br />\r\n            <label for=\"txtAno\">Ano:</label>\r\n            <input");
                    BeginWriteAttribute("value", " value=\"", 1363, "\"", 1383, 1);
#nullable restore
#line 29 "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\Veiculo\Alterar.cshtml"
WriteAttributeValue("", 1371, veiculo.Ano, 1371, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"txtAno\" type=\"text\" placeholder=\"Ano do Veículo\" /><br />\r\n            <label for=\"txtTipoCombustivel\">Tipo Combustivel:</label>\r\n            <input");
                    BeginWriteAttribute("value", " value=\"", 1539, "\"", 1571, 1);
#nullable restore
#line 31 "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\Veiculo\Alterar.cshtml"
WriteAttributeValue("", 1547, veiculo.TipoCombustivel, 1547, 24, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"txtTipoCombustivel\" type=\"text\" placeholder=\"Combustivel do Veículo\" /><br />\r\n            <label for=\"txtTipoCategoria\">Categoria Veiculo:</label>\r\n            <input");
                    BeginWriteAttribute("value", " value=\"", 1746, "\"", 1776, 1);
#nullable restore
#line 33 "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\Veiculo\Alterar.cshtml"
WriteAttributeValue("", 1754, veiculo.TipoCategoria, 1754, 22, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"txtTipoCategoria\" type=\"text\" placeholder=\"Categoria do Veículo\" /><br />\r\n            <label for=\"txtQntdPortas\">Quantidade Portas:</label>\r\n            <input");
                    BeginWriteAttribute("value", " value=\"", 1944, "\"", 1971, 1);
#nullable restore
#line 35 "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\Veiculo\Alterar.cshtml"
WriteAttributeValue("", 1952, veiculo.QntdPortas, 1952, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"txtQntdPortas\" type=\"text\" placeholder=\"Qntd. portas do Veículo\" /><br />\r\n            <label for=\"txtPotencia\">Potência:</label>\r\n            <input");
                    BeginWriteAttribute("value", " value=\"", 2128, "\"", 2153, 1);
#nullable restore
#line 37 "C:\Users\Michael\source\repos\LocadoraWeb\LocadoraWeb\Views\Veiculo\Alterar.cshtml"
WriteAttributeValue("", 2136, veiculo.Potencia, 2136, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"txtPotencia\" type=\"text\" placeholder=\"Potência do Veículo\" /><br />\r\n\r\n            <input type=\"submit\" value=\"Salvar\" />\r\n        </fieldset>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
