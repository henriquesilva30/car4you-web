#pragma checksum "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2078e232200fe6096101f6a856a559bbc5632756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\_ViewImports.cshtml"
using car4you;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\_ViewImports.cshtml"
using car4you.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2078e232200fe6096101f6a856a559bbc5632756", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c065fa01d2bee8047d66c6a01296f622848f2e9c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<car4you.Models.Anuncio>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Listar an??ncios";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>An??ncios</h1>

<table class=""highlight responsive-table"">
    <thead>
        <tr>
            <th>
                Titulo
            </th>
            <th>
                Data de cria????o
            </th>
            <th>
                URL
            </th>
            <th>
                Descri????o
            </th>
            <th>
                Renegociar
            </th>
           
            <th>
                Valor do veiculo
            </th>
            <th>
                Cor
            </th>
            <th>
                N??. portas
            </th>
            <th>
                Caixa
            </th>
            <th>
                Matricula
            </th>
            <th>
                Lota????o
            </th>
            <th>
                Ano do veiculo
            </th>
            <th>
                Cilindrada
            </th>
            <th>
                Pot??ncia
            </th>
            <th>
    ");
            WriteLiteral(@"            Quilometros
            </th>
            <th>
                Combustivel
            </th>
            <th>
                Modelo
            </th>
            <th>
                Desgaste
            </th>
            <th>
                Segmento
            </th>
            <th>
                Tipo de veiculo
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 78 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 81 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.designacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 84 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.datacriado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 87 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 90 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 92 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
     if (item.renegociar.Equals("false"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>\r\n            N??o\r\n        </td>\r\n");
#nullable restore
#line 97 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>\r\n            Sim\r\n        </td> \r\n");
#nullable restore
#line 103 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.valor));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ???\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nporta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.caixa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 118 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.matricula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 121 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.lotacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cilindrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.potencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 133 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.kms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem =>  item.Combustivel.designacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n            <td>\r\n                ");
#nullable restore
#line 140 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Modelo.designacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 143 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Desgaste.designacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 146 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Segmento.designacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 149 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TipoVeiculo.designacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2078e232200fe6096101f6a856a559bbc563275612216", async() => {
                WriteLiteral("Detalhes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 153 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
                                          WriteLiteral(item.IDANUNCIO);

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
            WriteLiteral(" \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 156 "C:\Users\utilizador\RiderProjects\car4you\car4you\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<car4you.Models.Anuncio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
