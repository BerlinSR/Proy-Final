#pragma checksum "C:\Users\frand\Desktop\Proyecto Final\Proy-Final-fontend\Views\Productos\UpdateProducto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a61ba699b3ca6ae08db39f79a8e785b80f272b76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_UpdateProducto), @"mvc.1.0.view", @"/Views/Productos/UpdateProducto.cshtml")]
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
#line 1 "C:\Users\frand\Desktop\Proyecto Final\Proy-Final-fontend\Views\_ViewImports.cshtml"
using Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\frand\Desktop\Proyecto Final\Proy-Final-fontend\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a61ba699b3ca6ae08db39f79a8e785b80f272b76", @"/Views/Productos/UpdateProducto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c9b339c01262d1b4d24c24ea891f87f3870c14", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_UpdateProducto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("waves-effect waves-light btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Productos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductoAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col s6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\r\n<div class=\"row\">\r\n    <h3 class=\"mt-5\"><strong>Actualizar Producto</strong></h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a61ba699b3ca6ae08db39f79a8e785b80f272b765530", async() => {
                WriteLiteral("\r\n        <div class=\"row card-panel\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\frand\Desktop\Proyecto Final\Proy-Final-fontend\Views\Productos\UpdateProducto.cshtml"
              
            Database conexion = Database.getInstancia();

            var codigo = ViewBag.Codigo_Producto;

            string Query = "SELECT * FROM Productos WHERE CodArticulo= '" +ViewBag.Codigo_Producto+"';";

            Microsoft.Data.Sqlite.SqliteDataReader lista = conexion.GetData(Query);

            while(lista.Read()){


#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"input-field col s12\">\r\n                <input disabled id=\"Codigo_Producto\" type=\"text\" class=\"validate\" name=\"Codigo_Producto\"");
                BeginWriteAttribute("value", " value=\"", 736, "\"", 763, 1);
#nullable restore
#line 22 "C:\Users\frand\Desktop\Proyecto Final\Proy-Final-fontend\Views\Productos\UpdateProducto.cshtml"
WriteAttributeValue("", 744, lista.GetString(0), 744, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label for=\"Codigo_Producto\">Codigo Producto</label>\r\n            </div>\r\n");
                WriteLiteral("            <div class=\"input-field col s12\">\r\n                <input id=\"Nombre_Producto\" type=\"text\" class=\"validate\" name=\"Nombre_Producto\"");
                BeginWriteAttribute("value", " value=\"", 1001, "\"", 1028, 1);
#nullable restore
#line 27 "C:\Users\frand\Desktop\Proyecto Final\Proy-Final-fontend\Views\Productos\UpdateProducto.cshtml"
WriteAttributeValue("", 1009, lista.GetString(1), 1009, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label for=\"Nombre_Producto\">Nombre</label>\r\n            </div>\r\n");
                WriteLiteral("            <div class=\"input-field col s12\">\r\n                <input id=\"Precio_Producto\" type=\"text\" class=\"validate\" name=\"Precio_Producto\"");
                BeginWriteAttribute("value", " value=\"", 1257, "\"", 1284, 1);
#nullable restore
#line 32 "C:\Users\frand\Desktop\Proyecto Final\Proy-Final-fontend\Views\Productos\UpdateProducto.cshtml"
WriteAttributeValue("", 1265, lista.GetString(2), 1265, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label for=\"Precio_Producto\">Precio</label>\r\n            </div>\r\n");
                WriteLiteral("            <div class=\"input-field col s12\">\r\n                <input id=\"Existencia_Producto\" type=\"text\" class=\"validate\" name=\"Existencia_Producto\"");
                BeginWriteAttribute("value", " value=\"", 1521, "\"", 1548, 1);
#nullable restore
#line 37 "C:\Users\frand\Desktop\Proyecto Final\Proy-Final-fontend\Views\Productos\UpdateProducto.cshtml"
WriteAttributeValue("", 1529, lista.GetString(3), 1529, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label for=\"Existencia_Producto\">Existencia</label>\r\n            </div>\r\n");
                WriteLiteral("            <div class=\"input-field col s12\">\r\n                <input id=\"Categoria_Producto\" type=\"text\" class=\"validate\" name=\"Categoria_Producto\"");
                BeginWriteAttribute("value", " value=\"", 1791, "\"", 1818, 1);
#nullable restore
#line 42 "C:\Users\frand\Desktop\Proyecto Final\Proy-Final-fontend\Views\Productos\UpdateProducto.cshtml"
WriteAttributeValue("", 1799, lista.GetString(4), 1799, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label for=\"Categoria_Producto\">Categoria</label>\r\n            </div>\r\n");
                WriteLiteral(@"            <div class=""file-field input-field col s12"">
                <div class=""btn"">
                    <span>Imagen</span>
                    <input type=""file"" name=""file"" id=""Archivo"">
                </div>
                <div class=""file-path-wrapper"">
                    <input class=""file-path validate"" type=""text"">
                </div>
            </div>
");
#nullable restore
#line 55 "C:\Users\frand\Desktop\Proyecto Final\Proy-Final-fontend\Views\Productos\UpdateProducto.cshtml"
                }
            
            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <button class=\"waves-effect waves-light btn\" type=\"submit\"><i class=\"material-icons right\">update</i>Actualizar</button>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a61ba699b3ca6ae08db39f79a8e785b80f272b7610675", async() => {
                    WriteLiteral("<i class=\"material-icons right\">arrow_back_ios</i>Volver");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n</div>");
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
