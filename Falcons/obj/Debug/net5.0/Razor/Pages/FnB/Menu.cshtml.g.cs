#pragma checksum "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee1a524477a4c28512c09d314f41743c6eb71a65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Falcons.Pages.FnB.Pages_FnB_Menu), @"mvc.1.0.razor-page", @"/Pages/FnB/Menu.cshtml")]
namespace Falcons.Pages.FnB
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
#line 1 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\_ViewImports.cshtml"
using Falcons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\_ViewImports.cshtml"
using Falcons.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee1a524477a4c28512c09d314f41743c6eb71a65", @"/Pages/FnB/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda54c565b70cf76a129e71347f29674895644bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FnB_Menu : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/FnBMenu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
  
    ViewData["Title"] = "Food and Beverages";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee1a524477a4c28512c09d314f41743c6eb71a654336", async() => {
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
            WriteLiteral("\r\n<div class=\"row grid\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
     if (Model.Menus.Count != 0)
    {
        foreach (var item in Model.Menus)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"box\">\r\n                    <div>\r\n                        <div class=\"img-box\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 477, "\"", 613, 1);
#nullable restore
#line 21 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
WriteAttributeValue("", 483, String.IsNullOrWhiteSpace(item.ImageURL) ? "/assets/img/No-Image.png" : "/assets/img/menus/" + item.ImageURL.Split(",").First(), 483, 130, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                        </div>\r\n                        <div class=\"detail-box\">\r\n                            <h5 style=\"color:#cbcbcb;\">");
#nullable restore
#line 25 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
                                                  Write(item.PackageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 26 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
                             if (!String.IsNullOrWhiteSpace(@item.Description))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p style=\"color:#cbcbcb;\">");
#nullable restore
#line 28 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
                                                     Write(Html.Raw(@item.Description.Length > 40 ? @item.Description.Substring(0, 40) + "..." : @item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 29 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p style=\"color:#cbcbcb;\"></p>\r\n");
#nullable restore
#line 33 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"options\">\r\n                                <h6 style=\"color:#cbcbcb;\"></h6>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1407, "\"", 1447, 2);
            WriteAttributeValue("", 1414, "./ViewMenuDetails?id=", 1414, 21, true);
#nullable restore
#line 37 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
WriteAttributeValue("", 1435, item.MenuID, 1435, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <i class=""fas fa-chevron-circle-right""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 45 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
     if (Model.Products.Count != 0)
    {
        foreach (var item in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"box\">\r\n                    <div>\r\n                        <div class=\"img-box\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2008, "\"", 2147, 1);
#nullable restore
#line 56 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
WriteAttributeValue("", 2014, String.IsNullOrWhiteSpace(item.ImageURL) ? "/assets/img/No-Image.png" : "/assets/img/products/" + item.ImageURL.Split(",").First(), 2014, 133, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"detail-box\">\r\n                            <h5 style=\"color:#cbcbcb;\">");
#nullable restore
#line 59 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
                                                  Write(item.ProductTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 60 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
                             if (!String.IsNullOrWhiteSpace(@item.ProductDescription))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p style=\"color:#cbcbcb;\">");
#nullable restore
#line 62 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
                                                     Write(Html.Raw(@item.ProductDescription.Length > 40 ? @item.ProductDescription.Substring(0, 40) + "..." : @item.ProductDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 63 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p style=\"color:#cbcbcb;\"></p>\r\n");
#nullable restore
#line 67 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"options\">\r\n                                <h6 style=\"color:#cbcbcb;\"></h6>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2970, "\"", 3009, 2);
            WriteAttributeValue("", 2977, "./ViewDetails?id=", 2977, 17, true);
#nullable restore
#line 72 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
WriteAttributeValue("", 2994, item.ProductID, 2994, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <i class=""fas fa-chevron-circle-right""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 80 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\FnB\Menu.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Falcons.Pages.FnB.MenuModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.FnB.MenuModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.FnB.MenuModel>)PageContext?.ViewData;
        public Falcons.Pages.FnB.MenuModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
