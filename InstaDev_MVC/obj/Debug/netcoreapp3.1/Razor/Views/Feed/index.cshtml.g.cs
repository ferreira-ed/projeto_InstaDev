#pragma checksum "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Feed\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39397119db1943502eaf8c5069488aafdfec736e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feed_Index), @"mvc.1.0.view", @"/Views/Feed/Index.cshtml")]
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
#line 1 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\_ViewImports.cshtml"
using InstaDev_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\_ViewImports.cshtml"
using InstaDev_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39397119db1943502eaf8c5069488aafdfec736e", @"/Views/Feed/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6846e00dccae461b63969ae214900fe939ced91", @"/Views/_ViewImports.cshtml")]
    public class Views_Feed_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("inputs-postar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Feed\Index.cshtml"
  
    ViewData["Title"] = "Feed"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>

    <!-- Início da seção de profiles-->

    <section class=""box-profiles"">


        <div class=""box-friends"">

            <div class=""container-friend"">
                <a href=""#""><img src=""img/vin-diesel 1.png"" alt=""imagem do vin diesel""></a>
                <p>vin_diesel</p>
            </div>

            <div class=""container-friend"">
                <a href=""#""><img src=""img/gabigordo 1.png"" alt=""imagem do gabigordo""></a>
                <p>gabigordo</p>
            </div>

            <div class=""container-friend"">
                <a href=""#""><img src=""img/will-baiano 1.png"" alt=""imagem do will baiano""></a>
                <p>will_baiano</p>
            </div>

            <div class=""container-friend"">
                <a href=""#""><img src=""img/tony_stark 1.png"" alt=""imagem do adriano stark""></a>
                <p>adriano_stark</p>
            </div>

            <div class=""container-friend"">
                <a href=""#""><img src=""img/pele 1.png"" alt=""imagem ");
            WriteLiteral(@"do king pelé""></a>
                <p>king_pele</p>
            </div>

            <div class=""container-friend"">
                <a href=""#""><img src=""img/samuel-rosa-bebê 1.png"" alt=""imagem do samuel rosa bebê""></a>
                <p>samuel_rosa</p>
            </div>

            <div class=""container-friend"">
                <a href=""#""><img src=""img/chaves_metal 1.png"" alt=""imagem do chaves metal""></a>
                <p>chaves_metal</p>
            </div>



        </div>


        <div class=""container-user"">

            <div class=""container-img"">
                <a href=""#""><img src=""img/thank-you 2.png"" alt=""imagem de perfil do marcos jeeves""></a>
            </div>

            <div class=""container-text"">
                <p>");
#nullable restore
#line 61 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Feed\Index.cshtml"
              Write(ViewBag.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 62 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Feed\Index.cshtml"
              Write(ViewBag.NomeCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>

        </div>


    </section>


    <!-- Final da seção de profiles-->





    <!-- Início da seção de postar-->


    <section class=""box-postar"">
        <div class=""titulo-postar"">
            <div class=""titulo-postar-img"">
                <a href=""#""><img src=""img/thank-you 3.png"" alt=""imagem do marcos jeeves""></a>
            </div>

            <div class=""titulo-postar-texto"">
                <p> Postar </p>
            </div>
        </div>

    
    
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39397119db1943502eaf8c5069488aafdfec736e7466", async() => {
                WriteLiteral(@"
            
            
    <input name=""Legenda"" type=""text"" class=""descricao-input-img"" placeholder=""Digite a descrição da imagem..."">

    <label for=""arquivo"">Escolha a Imagem</label>
    <input type=""file"" name=""Imagem"" class=""botao-img"" value=""Escolha a imagem"">

    <button type=""submit"" class=""btnpostar""> Postar </button>

        
");
#nullable restore
#line 104 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Feed\Index.cshtml"
         foreach (Publicacao p in ViewBag.POSTS)
        {


        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        \r\n    \r\n    \r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 93 "C:\Users\Felipe\OneDrive\Área de Trabalho\Projeto_InstaDev\InstaDev_MVC\Views\Feed\Index.cshtml"
AddHtmlAttributeValue("", 2515, Url.Action("Postar"), 2515, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    
    
    </section>

    <!-- Fim da seção postar-->

    <!-- Início da seção posts-->

    <section class=""box-post"">
        <div class=""header-post"">
            <a href=""#""><img src=""img/gabigordo 2.png"" alt=""imagem do gabigordo""></a>
            <div class=""header-texto"">
                <p> gabigordo </p>
                <p> Flamengo, RJ</p>
            </div>
        </div>

        <div class=""img-post"">
            <img src=""img/post-gabigordo 1.png"" alt=""imagem do time caricato do flamengo"">
        </div>

        <div class=""curtir-comentar"">
            <div class=""icones"">
                <a href=""#""><img src=""img/Vector-2.png"" alt=""imagem de um coração""></a>
                <a href=""#""><img src=""img/Vector-1.png"" alt=""imagem de um balão de conversa""></a>
            </div>

            <div class=""input-comentar"">
                <input type=""text"" class=""comentar-post"" value=""Comentar..."">
                <hr class=""linha"" size=""1"" width=""220"">
           ");
            WriteLiteral(@" </div>
        </div>

        <p class=""contador-curtidas"">2077 curtidas</p>

        <div class=""area-comentarios"">
            <div class=""conteudo-comentarios"">
                <div class=""nomes-usuarios"">
                    <p>gabigordo</p>
                    <p>yes_baby</p>
                    <p>king_pele</p>
                </div>

                <div class=""comentarios"">
                    <p> <a");
            BeginWriteAttribute("href", " href=\"", 4454, "\"", 4461, 0);
            EndWriteAttribute();
            WriteLiteral(@">#flamengo</a> , amo vocês mil milhões </p>
                    <p> thank you</p>
                    <p> Esses são bons de bola, entende?</p>
                </div>
            </div>
        </div>
    </section>
    <!--Fim da seção posts-->
</main>");
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
