#pragma checksum "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b7fdb18c3aebf15c44b27c5ed941a7c9cf3059"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes__DetalhesCliente), @"mvc.1.0.view", @"/Views/Clientes/_DetalhesCliente.cshtml")]
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
#nullable restore
#line 2 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
using Business.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
using App.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b7fdb18c3aebf15c44b27c5ed941a7c9cf3059", @"/Views/Clientes/_DetalhesCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b393c8fbdb87dd5d22ad154fbdbc81a7a1bf676", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes__DetalhesCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.ViewModels.ClienteViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<dl class=\"row\">\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 8 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayNameFor(model => model.NomeCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 11 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayFor(model => model.NomeCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 14 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 17 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(EnumExtensions.GetDisplayName((ETipo)Model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 20 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayNameFor(model => model.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 23 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayFor(model => model.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 26 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayNameFor(model => model.Genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 29 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Enum.GetName(typeof(EGeneros), Model.Genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 32 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 35 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayFor(model => model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 38 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 41 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayFor(model => model.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 44 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 47 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        Endereço\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 53 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Model.Endereco.Logradouro);

#line default
#line hidden
#nullable disable
            WriteLiteral(", nº ");
#nullable restore
#line 53 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
                                  Write(Model.Endereco.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("  |  CEP ");
#nullable restore
#line 53 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
                                                                 Write(Model.Endereco.Cep);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -  ");
#nullable restore
#line 53 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
                                                                                        Write(Model.Endereco.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 53 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
                                                                                                                 Write(Model.Endereco.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 53 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
                                                                                                                                        Write(Model.Endereco.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("  - ");
#nullable restore
#line 53 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
                                                                                                                                                                  Write(Model.Endereco.Complemento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 56 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayNameFor(model => model.Eventos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 59 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Model.Eventos.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Eventos\r\n    </dd>\r\n\r\n\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 64 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
   Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 67 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
         if (Model.Ativo == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"color: green\">Sim</p>\r\n");
#nullable restore
#line 70 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"color: red\">Não</p>\r\n");
#nullable restore
#line 74 "C:\Users\VAGNER ARAÚJO\Desktop\Programação\PROJETOS GITHUB\EventsProject\EventsProject\src\App\Views\Clientes\_DetalhesCliente.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dd>\r\n\r\n\r\n</dl>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.ViewModels.ClienteViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
