#pragma checksum "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Registros\ListaRegistros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "728d6d2ff1c55a5454975f3eb27bd5a7775b3010"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Mascotas.Registros.Pages_Mascotas_Registros_ListaRegistros), @"mvc.1.0.razor-page", @"/Pages/Mascotas/Registros/ListaRegistros.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Mascotas.Registros
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
#line 1 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"728d6d2ff1c55a5454975f3eb27bd5a7775b3010", @"/Pages/Mascotas/Registros/ListaRegistros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mascotas_Registros_ListaRegistros : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/properties.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../ListaMascota", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Registros\ListaRegistros.cshtml"
  
    ViewData["Title"] = "Constantes Vitales";
    int mascotaId= Model.Mascota.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "728d6d2ff1c55a5454975f3eb27bd5a7775b30105083", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>Formulario para la adición de propietarios</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "728d6d2ff1c55a5454975f3eb27bd5a7775b30105528", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""contenedor"">
    <header class=""header"">
        <h1 id=""title"" class=""text-center"">Constantes vitales de la mascota</h1>
        <p id=""description"" class=""description text-center"">Visualiza las constantes vitales de la mascota.</p>
    </header>

    <table id=""example"" class=""table table-striped"" style=""width:100%"">
        <thead>
            <tr>
                <th style=""text-align: center;"">MascotaId</th>
                <th style=""text-align: center;"">Fecha Visita</th>
                <th style=""text-align: center;"">Temperatura (°C)</th>
                <th style=""text-align: center;"">Peso (Kg)</th>
                <th style=""text-align: center;"">Frecuencia Respiratoria</th>
                <th style=""text-align: center;"">Frecuencia Cardiaca</th>
                <th style=""text-align: center;"">Estado Animo</th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 37 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Registros\ListaRegistros.cshtml"
             foreach(var registro in Model.Registros) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td style=\"text-align: center;\">");
#nullable restore
#line 39 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Registros\ListaRegistros.cshtml"
                                               Write(registro.MascotaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"text-align: center;\">");
#nullable restore
#line 40 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Registros\ListaRegistros.cshtml"
                                               Write(registro.FechaHora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"text-align: center;\">");
#nullable restore
#line 41 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Registros\ListaRegistros.cshtml"
                                               Write(registro.Temperatura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"text-align: center;\">");
#nullable restore
#line 42 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Registros\ListaRegistros.cshtml"
                                               Write(registro.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"text-align: center;\">");
#nullable restore
#line 43 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Registros\ListaRegistros.cshtml"
                                               Write(registro.FrecuenciaRespiratoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"text-align: center;\">");
#nullable restore
#line 44 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Registros\ListaRegistros.cshtml"
                                               Write(registro.FrecuenciaCardiaca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"text-align: center;\">");
#nullable restore
#line 45 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Registros\ListaRegistros.cshtml"
                                               Write(registro.EstadoAnimo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Registros\ListaRegistros.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "728d6d2ff1c55a5454975f3eb27bd5a7775b301011460", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mascotaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Registros\ListaRegistros.cshtml"
                                                                             WriteLiteral(mascotaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mascotaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mascotaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mascotaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.ListaRegistrosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListaRegistrosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListaRegistrosModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.ListaRegistrosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591