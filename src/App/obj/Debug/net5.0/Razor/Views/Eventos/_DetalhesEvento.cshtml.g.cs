#pragma checksum "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a3c063d2d1b38f638670d1e0d8d3cc64ed64107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos__DetalhesEvento), @"mvc.1.0.view", @"/Views/Eventos/_DetalhesEvento.cshtml")]
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
#line 1 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\_ViewImports.cshtml"
using App.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3c063d2d1b38f638670d1e0d8d3cc64ed64107", @"/Views/Eventos/_DetalhesEvento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b393c8fbdb87dd5d22ad154fbdbc81a7a1bf676", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos__DetalhesEvento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.ViewModels.EventoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<dl class=\"row\">\r\n\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 7 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Html.DisplayNameFor(model => model.ClienteId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 195, "\"", 236, 2);
            WriteAttributeValue("", 202, "/Clientes/Details/", 202, 18, true);
#nullable restore
#line 10 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
WriteAttributeValue("", 220, Model.ClienteId, 220, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
                                                Write(Model.Cliente.NomeCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </dd>\r\n\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 14 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 17 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 21 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 24 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 27 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Html.DisplayNameFor(model => model.Convidados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 30 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Model.Convidados);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Convidados\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        Endereço\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 36 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Model.Endereco.Logradouro);

#line default
#line hidden
#nullable disable
            WriteLiteral(", nº ");
#nullable restore
#line 36 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
                                  Write(Model.Endereco.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("  |  CEP ");
#nullable restore
#line 36 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
                                                                 Write(Model.Endereco.Cep);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -  ");
#nullable restore
#line 36 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
                                                                                        Write(Model.Endereco.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 36 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
                                                                                                                 Write(Model.Endereco.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 36 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
                                                                                                                                        Write(Model.Endereco.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("  - ");
#nullable restore
#line 36 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
                                                                                                                                                                  Write(Model.Endereco.Complemento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 39 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Html.DisplayNameFor(model => model.DataEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 42 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Html.DisplayFor(model => model.DataEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 46 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 49 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Html.DisplayFor(model => model.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n\r\n    <dt class=\"col-sm-2\">\r\n        Contato Cliente\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 56 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Html.DisplayFor(model => model.Cliente.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        Valor\r\n    </dt>\r\n    <dd class=\"col-sm-10\" style=\"color: green\">\r\n        ");
#nullable restore
#line 62 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Eventos\_DetalhesEvento.cshtml"
   Write(Convert.ToDecimal(Model.Valor).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n\r\n</dl>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.ViewModels.EventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
