#pragma checksum "C:\Users\UlisesC\source\repos\AppPatrulla\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d866141707604b91ba0fde89edf0e9cca6303bf"
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
#line 1 "C:\Users\UlisesC\source\repos\AppPatrulla\Views\_ViewImports.cshtml"
using AppPatrulla;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UlisesC\source\repos\AppPatrulla\Views\_ViewImports.cshtml"
using AppPatrulla.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d866141707604b91ba0fde89edf0e9cca6303bf", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\UlisesC\source\repos\AppPatrulla\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d866141707604b91ba0fde89edf0e9cca6303bf4075", async() => {
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

                    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3762.448777735983!2d-99.15681848509325!3d19.436208586882266!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x85d1f8d24522071f%3A0x20");
                WriteLiteral("fdc6dd3dcc0c20!2sMonumento%20a%20la%20Revoluci%C3%B3n!5e0!3m2!1ses-419!2smx!4v1627772176540!5m2!1ses-419!2smx\" width=\"600\" height=\"450\" style=\"border:0;\"");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 2265, "\"", 2283, 0);
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
                    <h2>About this page</h2>
                    <p class=""lead"">This is a great place to talk about your webpage. This template is purposefully unstyled so you can use it as a boilerplate or starting point for you own landing page designs! This template features:</p>
                    <ul>
                        <li>Clickable nav links that smooth scroll to page sections</l");
                WriteLiteral(@"i>
                        <li>Responsive behavior when clicking nav links perfect for a one page website</li>
                        <li>Bootstrap's scrollspy feature which highlights which section of the page you're on in the navbar</li>
                        <li>Minimal custom CSS so you are free to explore your own unique design options</li>
                    </ul>
                </div>
            </div>
        </div>
    </section>
    <!-- Services section-->
    <section class=""bg-light"" id=""services"">
        <div class=""container px-4"">
            <div class=""row gx-4 justify-content-center"">
                <div class=""col-lg-8"">
                    <h2>Services we offer</h2>
                    <p class=""lead"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aut optio velit inventore, expedita quo laboriosam possimus ea consequatur vitae, doloribus consequuntur ex. Nemo assumenda laborum vel, labore ut velit dignissimos.</p>
                </div>
            </di");
                WriteLiteral(@"v>
        </div>
    </section>
    <!-- Contact section-->
    <section id=""contact"">
        <div class=""container px-4"">
            <div class=""row gx-4 justify-content-center"">
                <div class=""col-lg-8"">
                    <h2>Contact us</h2>
                    <p class=""lead"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Vero odio fugiat voluptatem dolor, provident officiis, id iusto! Obcaecati incidunt, qui nihil beatae magnam et repudiandae ipsa exercitationem, in, quo totam.</p>
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d866141707604b91ba0fde89edf0e9cca6303bf9984", async() => {
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
