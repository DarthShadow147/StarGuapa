#pragma checksum "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ec75e8382141b7680c1fb5bb7ca2692947139e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Client/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\_ViewImports.cshtml"
using StarGuapa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\_ViewImports.cshtml"
using StarGuapa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec75e8382141b7680c1fb5bb7ca2692947139e9", @"/Areas/Client/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9291babf2c5166f0a7c68b956ad2369ba32844b5", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StarGuapa.Models.ViewModels.HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:2px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--SLIDER-->\r\n<header>\r\n    <div id=\"carouselExampleInidicate\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 10 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
               int cont = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
             foreach (var item in Model.Slider)
            {
                var itemDinamico = cont++ == 0 ? "item active" : "item";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 427, "\"", 462, 2);
            WriteAttributeValue("", 435, "carousel-item", 435, 13, true);
#nullable restore
#line 14 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 448, itemDinamico, 449, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 490, "\"", 524, 1);
#nullable restore
#line 15 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
WriteAttributeValue("", 496, Url.Content(item.UrlImagen), 496, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <h1 class=\"text-dark text-center\">");
#nullable restore
#line 16 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
                                                 Write(Html.Raw(item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n");
#nullable restore
#line 18 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</header>
<!--Cierre del Slider-->

<div class=""row fondoTitulo mt-5"">
    <div class=""col-sm-12 py-5"">
        <h1 class=""text-center text-dark"">Ultimos Productos</h1>
    </div>
</div>

<!--Articulos-->
");
#nullable restore
#line 39 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
 if (Model.ListaArticulos.Count()>0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 43 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
         foreach (var articulo in Model.ListaArticulos.OrderBy(o => o.Id))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4\">\r\n                <div class=\"card\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1655, "\"", 1680, 1);
#nullable restore
#line 47 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
WriteAttributeValue("", 1661, articulo.UrlImagen, 1661, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\" width=\"100%\" />\r\n                    <div class=\"card-body\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-6\">\r\n                                <h5 class=\"text-left\" style=\"font-size: 25px\">");
#nullable restore
#line 51 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
                                                                         Write(articulo.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                            <div class=\"col-6\">\r\n                                <p class=\"text-right\" style=\"font-size: 22px\"><b>$ </b> ");
#nullable restore
#line 54 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
                                                                                   Write(articulo.Precio.ToString("#,##0.00").Replace(",00", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                        <p class=\"text-left\">");
#nullable restore
#line 57 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
                                        Write(Html.Raw(articulo.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ec75e8382141b7680c1fb5bb7ca2692947139e910886", async() => {
                WriteLiteral("Ver producto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
                                                                                                   WriteLiteral(articulo.Id);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ec75e8382141b7680c1fb5bb7ca2692947139e913301", async() => {
                WriteLiteral("<i class=\"fa fa-shopping-cart\"></i> Agregar al carro");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-articuloId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
                                     WriteLiteral(articulo.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articuloId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-articuloId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articuloId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 67 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 69 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No existen articulos</p>\r\n");
#nullable restore
#line 73 "C:\Users\e_aam\source\repos\StarGuapa\StarGuapa\Areas\Client\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StarGuapa.Models.ViewModels.HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
