#pragma checksum "C:\Users\mayhr\OneDrive\Documents\Projects\azure\InnovaHack\AppPatrulla\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "470f42feb273300d1f248ad7f51b8e3368d40d69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\mayhr\OneDrive\Documents\Projects\azure\InnovaHack\AppPatrulla\Views\_ViewImports.cshtml"
using AppPatrulla;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mayhr\OneDrive\Documents\Projects\azure\InnovaHack\AppPatrulla\Views\_ViewImports.cshtml"
using AppPatrulla.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"470f42feb273300d1f248ad7f51b8e3368d40d69", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"585a9b008c2e1245187acdc70b430a07e267cf47", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mayhr\OneDrive\Documents\Projects\azure\InnovaHack\AppPatrulla\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "470f42feb273300d1f248ad7f51b8e3368d40d694195", async() => {
                WriteLiteral(@"
    <!-- Navigation-->
    <nav class=""navbar navbar-expand-lg navbar-dark bg-dark fixed-top"" id=""mainNav"">
        <div class=""container px-4"">
            <a class=""navbar-brand"" href=""#page-top"">IA - Police</a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation""><span class=""navbar-toggler-icon""></span></button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav ms-auto"">
                    <li class=""nav-item""><a class=""nav-link"" href=""#about"">About</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""#services"">Services</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""#contact"">Contact</a></li>
                </ul>
            </div>
        </div>
    </nav>

    <!-- Header-->

    <header class=""bg-primary bg-gradient text-");
                WriteLiteral(@"white"">
        <div class=""container px-4 text-center"">
            <h1 class=""fw-bolder"">Bienvenid@s a IA -  Police""</h1>
            <p class=""lead"">Aplicación para poder ayudar a la pronta respuesta ante crimen</p>
            <a class=""btn btn-lg btn-light"" href=""#about"">Conocenos</a>
        </div>
    </header>
    <!-- Este es la parte de la app-->

    <section id=""about"">
        <div class=""container px-4"">
            <div class=""row gx-4 justify-content-center"">
                <div class=""col-lg-8"">
                    <b></b><br /><h1>¡Hola Operadora!</h1><b></b><br />
                    <h4>En este portal se podrá ver las Alertas vecinales/botón de panico</h4>
                    <b></b><br />
                    <h4> !Mira una alerta se activo! </h4>

                    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3762.448777735983!2d-99.15681848509325!3d19.436208586882266!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x85d1f8d24522071f%3A0x20fdc6");
                WriteLiteral("dd3dcc0c20!2sMonumento%20a%20la%20Revoluci%C3%B3n!5e0!3m2!1ses-419!2smx!4v1627772176540!5m2!1ses-419!2smx\" width=\"600\" height=\"450\" style=\"border:0;\"");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 2261, "\"", 2279, 0);
                EndWriteAttribute();
                WriteLiteral(@" loading=""lazy""></iframe>
                    <b></b>
                    <br />
                    <br />En esta parte se desplegará

                    <h3>Por favor en seguida introduce tu ubicación y enseguida te mandaremos a la patrulla más cercana a ti.</h3>
                    <br />
                    <br />
                    <br />

                </div>
            </div>
        </div>
    </section>
    <!-- About section-->
    <section id=""about"">
        <div class=""container px-4"">
            <div class=""row gx-4 justify-content-center"">
                <div class=""col-lg-8"">
                    <h2>¿Cómo le ayudará este sitio? </h2>
                    <p class=""lead"">
                        Nuestro sitio te ayudará a saber cuándo y dónde surge una emergencia. De esta forma,
                        logrará una mejor organización y sobre todo, podrá monitorear las patrullas para verificar que estén
                        cumpliendo con su trabajo.
             ");
                WriteLiteral(@"       </p>
                </div>
            </div>
        </div>
    </section>

    <!-- Contact section-->
    <section id=""contact"">
        <div class=""container px-4"">
            <div class=""row gx-4 justify-content-center"">
                <div class=""col-lg-8"">
                    <h2>Esta página fue desarrollada por:</h2>
                    <p class=""lead"">
                        José Armando Díaz<br> Julio Abraham Alonso <br> René Francisco Cruz<br>
                        Ulises Cortés <br> Valeria Vargas
                    </p>
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""currentColor"" class=""bi bi-github"" viewBox=""0 0 16 16"">
                        <path d=""M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59");
                WriteLiteral(@".82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27.68 0 1.36.09 2 .27 1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.012 8.012 0 0 0 16 8c0-4.42-3.58-8-8-8z"" />
                    </svg>
                    <a href=""https://rene-cruz.github.io/InnovaHack/"">Repositorio Genial</a>
                </div>
            </div>
        </div>
    </section>
    <!-- Footer-->
    <footer class=""py-5 bg-dark"">
        <div class=""container px-4""><p class=""m-0 text-center text-white"">Copyright &copy; Best team ever 2021</p></div>
    </footer>
    <!-- Bootstrap core JS-->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js""></script>
    <!-- Core theme JS-->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "470f42feb273300d1f248ad7f51b8e3368d40d699996", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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