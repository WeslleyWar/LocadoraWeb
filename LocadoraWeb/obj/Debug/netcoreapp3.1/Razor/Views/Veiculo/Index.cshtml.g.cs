#pragma checksum "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0270ec56411ded5c169de9c1ce6430d23ce059f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veiculo_Index), @"mvc.1.0.view", @"/Views/Veiculo/Index.cshtml")]
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
#line 2 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\_ViewImports.cshtml"
using LocadoraWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0270ec56411ded5c169de9c1ce6430d23ce059f7", @"/Views/Veiculo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6ccd57c4af67623a1436849551f668433b638b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Veiculo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Veiculo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
   
    List<Veiculo> veiculos = ViewBag.Veiculos;
    int quantidade = ViewBag.Quantidade;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0270ec56411ded5c169de9c1ce6430d23ce059f74405", async() => {
                WriteLiteral("\r\n    <title>Gerenciamento de Veículos</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0270ec56411ded5c169de9c1ce6430d23ce059f75419", async() => {
                WriteLiteral("\r\n    <h2>GERENCIAR VEÍCULO:</h2>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0270ec56411ded5c169de9c1ce6430d23ce059f75716", async() => {
                    WriteLiteral("CADASTRAR VEÍCULO");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <table>
        <thead>
            <tr>
                <th>#</th>
                <th>Marca</th>
                <th>Modelo</th>
                <th>Categoria veículo</th>
                <th>Combustível</th>
                <th>Cor</th>
                <th>Número de portas</th>
                <th>Ano</th>
                <th>Potência</th>
                <th>Placa</th>
                <th>Criado Em</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 34 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
             foreach (Veiculo veiculoCadastrado in veiculos) 
            { 

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
               Write(veiculoCadastrado.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
               Write(veiculoCadastrado.Marca);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
               Write(veiculoCadastrado.Modelo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
               Write(veiculoCadastrado.TipoCategoria);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
               Write(veiculoCadastrado.TipoCombustivel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
               Write(veiculoCadastrado.Cor);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
               Write(veiculoCadastrado.QntdPortas);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
               Write(veiculoCadastrado.Ano);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
               Write(veiculoCadastrado.Potencia);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
               Write(veiculoCadastrado.Placa);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
               Write(veiculoCadastrado.CriadoEm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0270ec56411ded5c169de9c1ce6430d23ce059f711168", async() => {
                    WriteLiteral("\r\n                        Remover\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
                         WriteLiteral(veiculoCadastrado.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <p><b>Quantidade de registros: </b>");
#nullable restore
#line 59 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
                                  Write(quantidade);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p><b>Atualizado em: </b>");
#nullable restore
#line 60 "C:\Users\Weslley War\Desktop\Nova pasta\LocadoraWeb\LocadoraWeb\Views\Veiculo\Index.cshtml"
                        Write(DateTime.Now);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
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
