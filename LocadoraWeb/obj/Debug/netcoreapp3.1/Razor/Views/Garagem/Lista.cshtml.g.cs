#pragma checksum "C:\Users\Weslley War\Desktop\Nova pasta (2)\LocadoraWeb\LocadoraWeb\Views\Garagem\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2dd76a08572c086b62bde2a40d3416189b7cddd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Garagem_Lista), @"mvc.1.0.view", @"/Views/Garagem/Lista.cshtml")]
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
#line 2 "C:\Users\Weslley War\Desktop\Nova pasta (2)\LocadoraWeb\LocadoraWeb\Views\_ViewImports.cshtml"
using LocadoraWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2dd76a08572c086b62bde2a40d3416189b7cddd", @"/Views/Garagem/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6ccd57c4af67623a1436849551f668433b638b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Garagem_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LocadoraWeb.Models.Garagem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Weslley War\Desktop\Nova pasta (2)\LocadoraWeb\LocadoraWeb\Views\Garagem\Lista.cshtml"
  
    ViewData["Title"] = "Lista de Garagens";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Lista de Garagens</h1>

<table class=""table table-hover "">
    <thead>
        <tr>
            <th>#</th>
            <th>Nome</th>
            <th>Cep</th>
            <th>Rua</th>
            <th>Bairro</th>
            <th>Cidade</th>
            <th>Numero</th>
            <th></th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\Weslley War\Desktop\Nova pasta (2)\LocadoraWeb\LocadoraWeb\Views\Garagem\Lista.cshtml"
         foreach (Garagem garagemCadastrada in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Weslley War\Desktop\Nova pasta (2)\LocadoraWeb\LocadoraWeb\Views\Garagem\Lista.cshtml"
               Write(garagemCadastrada.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Weslley War\Desktop\Nova pasta (2)\LocadoraWeb\LocadoraWeb\Views\Garagem\Lista.cshtml"
               Write(garagemCadastrada.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Weslley War\Desktop\Nova pasta (2)\LocadoraWeb\LocadoraWeb\Views\Garagem\Lista.cshtml"
               Write(garagemCadastrada.Cep);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Weslley War\Desktop\Nova pasta (2)\LocadoraWeb\LocadoraWeb\Views\Garagem\Lista.cshtml"
               Write(garagemCadastrada.Logradouro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Weslley War\Desktop\Nova pasta (2)\LocadoraWeb\LocadoraWeb\Views\Garagem\Lista.cshtml"
               Write(garagemCadastrada.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Weslley War\Desktop\Nova pasta (2)\LocadoraWeb\LocadoraWeb\Views\Garagem\Lista.cshtml"
               Write(garagemCadastrada.Localidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Weslley War\Desktop\Nova pasta (2)\LocadoraWeb\LocadoraWeb\Views\Garagem\Lista.cshtml"
               Write(garagemCadastrada.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Weslley War\Desktop\Nova pasta (2)\LocadoraWeb\LocadoraWeb\Views\Garagem\Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LocadoraWeb.Models.Garagem>> Html { get; private set; }
    }
}
#pragma warning restore 1591