#pragma checksum "C:\Users\gabri\OneDrive\Documentos\GitHub\Last_Project_M03_BackEnd\CarStore\Views\TesteDrive\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a74b2a5dcbc9ca077df8ba3319c95701c0685342"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TesteDrive_Read), @"mvc.1.0.view", @"/Views/TesteDrive/Read.cshtml")]
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
#line 1 "C:\Users\gabri\OneDrive\Documentos\GitHub\Last_Project_M03_BackEnd\CarStore\Views\_ViewImports.cshtml"
using CarStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabri\OneDrive\Documentos\GitHub\Last_Project_M03_BackEnd\CarStore\Views\_ViewImports.cshtml"
using CarStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a74b2a5dcbc9ca077df8ba3319c95701c0685342", @"/Views/TesteDrive/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"725beeeed864e424913aa610ea4dec60ab577d87", @"/Views/_ViewImports.cshtml")]
    public class Views_TesteDrive_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TesteDrive>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"card text-center\">\r\n    <div class=\"card-header\">\r\n        Usu??rio\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 8 "C:\Users\gabri\OneDrive\Documentos\GitHub\Last_Project_M03_BackEnd\CarStore\Views\TesteDrive\Read.cshtml"
                          Write(Html.DisplayFor(Model => Model.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\"><b>Telefone: </b>");
#nullable restore
#line 9 "C:\Users\gabri\OneDrive\Documentos\GitHub\Last_Project_M03_BackEnd\CarStore\Views\TesteDrive\Read.cshtml"
                                         Write(Html.DisplayFor(Model => Model.celular));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | <b>Tipo de negocia????o: </b>");
#nullable restore
#line 9 "C:\Users\gabri\OneDrive\Documentos\GitHub\Last_Project_M03_BackEnd\CarStore\Views\TesteDrive\Read.cshtml"
                                                                                                               Write(Html.DisplayFor(Model => Model.tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a74b2a5dcbc9ca077df8ba3319c95701c06853425697", async() => {
                WriteLiteral("Atualizar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\gabri\OneDrive\Documentos\GitHub\Last_Project_M03_BackEnd\CarStore\Views\TesteDrive\Read.cshtml"
                                                              WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a74b2a5dcbc9ca077df8ba3319c95701c06853428072", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div id=\"carouselExampleControls\" class=\"carousel slide\" data-bs-ride=\"carousel\">\r\n    <div class=\"bg-dark carousel-inner\">\r\n        <div class=\"carousel-item active\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 782, "\"", 831, 1);
#nullable restore
#line 18 "C:\Users\gabri\OneDrive\Documentos\GitHub\Last_Project_M03_BackEnd\CarStore\Views\TesteDrive\Read.cshtml"
WriteAttributeValue("", 788, Html.DisplayFor(Model => Model.carro.url1), 788, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded mx-auto d-block w-25\" alt=\"...\">\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"card text-center\">\r\n    <div class=\"card-header\">\r\n        R$ ");
#nullable restore
#line 25 "C:\Users\gabri\OneDrive\Documentos\GitHub\Last_Project_M03_BackEnd\CarStore\Views\TesteDrive\Read.cshtml"
      Write(Html.DisplayFor(Model => Model.carro.preco));

#line default
#line hidden
#nullable disable
            WriteLiteral(",00\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 28 "C:\Users\gabri\OneDrive\Documentos\GitHub\Last_Project_M03_BackEnd\CarStore\Views\TesteDrive\Read.cshtml"
                          Write(Html.DisplayFor(Model => Model.carro.marca));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 28 "C:\Users\gabri\OneDrive\Documentos\GitHub\Last_Project_M03_BackEnd\CarStore\Views\TesteDrive\Read.cshtml"
                                                                         Write(Html.DisplayFor(Model => Model.carro.modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 29 "C:\Users\gabri\OneDrive\Documentos\GitHub\Last_Project_M03_BackEnd\CarStore\Views\TesteDrive\Read.cshtml"
                        Write(Html.DisplayFor(Model => Model.carro.descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n    </div>\r\n    <div class=\"card-footer text-muted\">\r\n        ");
#nullable restore
#line 32 "C:\Users\gabri\OneDrive\Documentos\GitHub\Last_Project_M03_BackEnd\CarStore\Views\TesteDrive\Read.cshtml"
   Write(Html.DisplayFor(Model => Model.carro.ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TesteDrive> Html { get; private set; }
    }
}
#pragma warning restore 1591
