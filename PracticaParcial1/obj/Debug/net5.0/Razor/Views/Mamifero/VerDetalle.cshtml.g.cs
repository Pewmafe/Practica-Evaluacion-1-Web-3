#pragma checksum "C:\Users\matias\source\repos\practicaEvaluacion1\PracticaParcial1\PracticaParcial1\Views\Mamifero\VerDetalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3189d3497ae8e30cf96ae59b1085ce827fef1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mamifero_VerDetalle), @"mvc.1.0.view", @"/Views/Mamifero/VerDetalle.cshtml")]
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
#line 1 "C:\Users\matias\source\repos\practicaEvaluacion1\PracticaParcial1\PracticaParcial1\Views\_ViewImports.cshtml"
using PracticaParcial1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matias\source\repos\practicaEvaluacion1\PracticaParcial1\PracticaParcial1\Views\_ViewImports.cshtml"
using PracticaParcial1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3189d3497ae8e30cf96ae59b1085ce827fef1a", @"/Views/Mamifero/VerDetalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7586b2796ddb4d0ef28941f1d4fc5327dd1d493", @"/Views/_ViewImports.cshtml")]
    public class Views_Mamifero_VerDetalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\matias\source\repos\practicaEvaluacion1\PracticaParcial1\PracticaParcial1\Views\Mamifero\VerDetalle.cshtml"
  
    Mamifero mamifero = (Mamifero)ViewData["mamifero"];
    string mensajeMamifero = (mamifero.mensajeMetodo) != null ? (mamifero.mensajeMetodo) : "No hago ninguna accion";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1>Mamifero</h1>\r\n    <p");
            BeginWriteAttribute("class", " class=\"", 220, "\"", 228, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "C:\Users\matias\source\repos\practicaEvaluacion1\PracticaParcial1\PracticaParcial1\Views\Mamifero\VerDetalle.cshtml"
           Write(mensajeMamifero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h4>Hacer accion:</h4>\r\n    <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 307, "\"", 367, 3);
            WriteAttributeValue("", 314, "/Mamifero/HacerAccion?Id=", 314, 25, true);
#nullable restore
#line 10 "C:\Users\matias\source\repos\practicaEvaluacion1\PracticaParcial1\PracticaParcial1\Views\Mamifero\VerDetalle.cshtml"
WriteAttributeValue("", 339, mamifero.Id, 339, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 351, "&Accion=respirar", 351, 16, true);
            EndWriteAttribute();
            WriteLiteral(">respirar</a>\r\n    <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 410, "\"", 469, 3);
            WriteAttributeValue("", 417, "/Mamifero/HacerAccion?Id=", 417, 25, true);
#nullable restore
#line 11 "C:\Users\matias\source\repos\practicaEvaluacion1\PracticaParcial1\PracticaParcial1\Views\Mamifero\VerDetalle.cshtml"
WriteAttributeValue("", 442, mamifero.Id, 442, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 454, "&Accion=caminar", 454, 15, true);
            EndWriteAttribute();
            WriteLiteral(">caminar</a>\r\n    <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 514, "\"", 572, 3);
            WriteAttributeValue("", 521, "/Mamifero/HacerAccion?Id=", 521, 25, true);
#nullable restore
#line 12 "C:\Users\matias\source\repos\practicaEvaluacion1\PracticaParcial1\PracticaParcial1\Views\Mamifero\VerDetalle.cshtml"
WriteAttributeValue("", 546, mamifero.Id, 546, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 558, "&Accion=pensar", 558, 14, true);
            EndWriteAttribute();
            WriteLiteral(">pensar</a>\r\n</div>\r\n");
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
