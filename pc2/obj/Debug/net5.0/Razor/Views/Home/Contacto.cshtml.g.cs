#pragma checksum "C:\Users\limps\Desktop\Progra 1 dayane\PCs\pc2\Views\Home\Contacto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "456fbf11252ee9e0232dd22e54a01511f7bfbcc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacto), @"mvc.1.0.view", @"/Views/Home/Contacto.cshtml")]
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
#line 1 "C:\Users\limps\Desktop\Progra 1 dayane\PCs\pc2\Views\_ViewImports.cshtml"
using pc2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\limps\Desktop\Progra 1 dayane\PCs\pc2\Views\_ViewImports.cshtml"
using pc2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"456fbf11252ee9e0232dd22e54a01511f7bfbcc1", @"/Views/Home/Contacto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d2263d35973fa27b223c8405b50b8ff267c28bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\limps\Desktop\Progra 1 dayane\PCs\pc2\Views\Home\Contacto.cshtml"
  
    ViewData["Title"] = "Plantilla1";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Formulario de Adopcion</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456fbf11252ee9e0232dd22e54a01511f7bfbcc14723", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 147, "\"", 153, 0);
                EndWriteAttribute();
                WriteLiteral(">Nombre </label>\r\n        <input type=\"text\" name=\"Nombre\"");
                BeginWriteAttribute("id", " id=\"", 212, "\"", 217, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\r\n           <label");
                BeginWriteAttribute("for", " for=\"", 259, "\"", 265, 0);
                EndWriteAttribute();
                WriteLiteral(">Apellido Paterno:</label>\r\n        <input type=\"text\" name=\"Apellidop\"");
                BeginWriteAttribute("id", " id=\"", 337, "\"", 342, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\r\n           <label");
                BeginWriteAttribute("for", " for=\"", 384, "\"", 390, 0);
                EndWriteAttribute();
                WriteLiteral(">Apellido Materno:</label>\r\n        <input type=\"text\" name=\"Apellidom\"");
                BeginWriteAttribute("id", " id=\"", 462, "\"", 467, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\r\n           <label");
                BeginWriteAttribute("for", " for=\"", 509, "\"", 515, 0);
                EndWriteAttribute();
                WriteLiteral(">Mascota:</label>\r\n        <input type=\"text\" name=\"Mascota\"");
                BeginWriteAttribute("id", " id=\"", 576, "\"", 581, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\r\n         <div class=\"form-group\">\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 655, "\"", 661, 0);
                EndWriteAttribute();
                WriteLiteral(">Descripcion:</label>\r\n        <textarea name=\"Descripcion\"");
                BeginWriteAttribute("id", " id=\"", 721, "\"", 726, 0);
                EndWriteAttribute();
                WriteLiteral(" cols=\"20\" rows=\"10\" class=\"form-control\"></textarea>\r\n    </div>\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 808, "\"", 814, 0);
                EndWriteAttribute();
                WriteLiteral(">Telefono:</label>\r\n        <input type=\"text\" name=\"Telefono\"");
                BeginWriteAttribute("id", " id=\"", 877, "\"", 882, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\r\n          <select class=\"form-select form-select-lg mb-3\" aria-label=\".form-select-lg example\">\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456fbf11252ee9e0232dd22e54a01511f7bfbcc17648", async() => {
                    WriteLiteral("Distrito");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456fbf11252ee9e0232dd22e54a01511f7bfbcc18989", async() => {
                    WriteLiteral("A");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456fbf11252ee9e0232dd22e54a01511f7bfbcc110209", async() => {
                    WriteLiteral("B");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456fbf11252ee9e0232dd22e54a01511f7bfbcc111430", async() => {
                    WriteLiteral("C");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</select>\r\n<br>\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 1169, "\"", 1175, 0);
                EndWriteAttribute();
                WriteLiteral(">Dirrecion:</label>\r\n        <input type=\"text\" name=\"Dirrecion\"");
                BeginWriteAttribute("id", " id=\"", 1240, "\"", 1245, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 1326, "\"", 1332, 0);
                EndWriteAttribute();
                WriteLiteral(">Mensaje:</label>\r\n        <textarea name=\"Mensaje\"");
                BeginWriteAttribute("id", " id=\"", 1384, "\"", 1389, 0);
                EndWriteAttribute();
                WriteLiteral(" cols=\"30\" rows=\"10\" class=\"form-control\"></textarea>\r\n    </div>\r\n    <button class=\"btn btn-primary\">Enviar mensaje</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
