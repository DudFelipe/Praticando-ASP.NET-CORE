#pragma checksum "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73b6bea8d7d15c7e5c8d7cf1802375e92199a0e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes__delete_details), @"mvc.1.0.view", @"/Views/Clientes/_delete_details.cshtml")]
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
#line 1 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\_ViewImports.cshtml"
using GestaoClientes.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\_ViewImports.cshtml"
using GestaoClientes.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73b6bea8d7d15c7e5c8d7cf1802375e92199a0e3", @"/Views/Clientes/_delete_details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12fe91e45cd54569c1745bfe4c8effca3270e20c", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes__delete_details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestaoClientes.Domain.Models.Cliente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"container-fluid\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 6 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 9 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 12 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 15 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 18 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoDeCliente.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 21 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayFor(model => model.TipoDeCliente.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 24 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 27 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 30 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 33 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayFor(model => model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 36 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayNameFor(model => model.Idade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 39 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayFor(model => model.Idade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 42 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 45 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 48 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 51 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 54 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 57 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayFor(model => model.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 60 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 63 "D:\Projetos\Testes\src\GestaoClientes.MVC\Views\Clientes\_delete_details.cshtml"
           Write(Html.DisplayFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestaoClientes.Domain.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
