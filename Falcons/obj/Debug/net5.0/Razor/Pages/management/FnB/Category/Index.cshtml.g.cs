#pragma checksum "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfb8123aeeb16276370d62f943373b2ff145b9cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Falcons.Pages.management.FnB.Category.Pages_management_FnB_Category_Index), @"mvc.1.0.razor-page", @"/Pages/management/FnB/Category/Index.cshtml")]
namespace Falcons.Pages.management.FnB.Category
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfb8123aeeb16276370d62f943373b2ff145b9cc", @"/Pages/management/FnB/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda54c565b70cf76a129e71347f29674895644bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_management_FnB_Category_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Category Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Category\Index.cshtml"
  
    Layout = "_ManagementLayout";

    ViewData["Title"] = "Food and Beverages Category";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title"">Product Category</div>
            </div>
            <div class=""card-body"">
                <!-- Button -->
                <div class=""d-flex"">
                    <button class=""btn btn-primary btn-round ml-auto mb-3"" data-toggle=""modal"" data-target=""#addCategoryModal"">
                        <i class=""fa fa-plus""></i>
                        Add New Category
                    </button>
                </div>

                <!-- Modal -->
                <div class=""modal fade"" id=""addCategoryModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header no-bd"">
                                <h5 class=""modal-title"">
                   ");
            WriteLiteral(@"                 <span class=""fw-mediumbold"">
                                        New
                                    </span>
                                    <span class=""fw-light"">
                                        Category
                                    </span>
                                </h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfb8123aeeb16276370d62f943373b2ff145b9cc7380", async() => {
                WriteLiteral(@"
                                <div class=""modal-body"">
                                    <p class=""small"">Please fill in all the field.</p>
                                    <div class=""row"">
                                        <div class=""col-sm-12"">
                                            <div class=""form-group form-group-default"">
                                                <label>Category Name</label>
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bfb8123aeeb16276370d62f943373b2ff145b9cc8128", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 48 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Category\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewPC.CategoryName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""modal-footer no-bd"">
                                    <button type=""submit"" id=""addCategoryButton"" class=""btn btn-primary"">Add</button>
                                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>

                <!-- Table -->
                <div class=""table-responsive"">
                    <table id=""category-row"" class="" display table table-striped table-hover"" cellspacing=""0"" width=""100%"">
                        <thead>
                            <tr role=""row""></tr>

                            <tr role=""row"">
                                <th>ID</th>
                                <th>Name</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 75 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Category\Index.cshtml"
                             if (Model.category.Any())
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Category\Index.cshtml"
                                 foreach (var item in Model.category)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 80 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Category\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.CategoryID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 81 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Category\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <div class=\"form-button-action\">\r\n                                                <a data-toggle=\"tooltip\"");
            BeginWriteAttribute("href", " href=\"", 4284, "\"", 4370, 2);
            WriteAttributeValue("", 4291, "/management/FnB/Category/Edit?id=", 4291, 33, true);
#nullable restore
#line 84 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Category\Index.cshtml"
WriteAttributeValue("", 4324, Html.DisplayFor(modelItem => item.CategoryID), 4324, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4371, "\"", 4379, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit"">
                                                    <i class=""fa fa-edit""></i>
                                                </a>
                                                <a type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("href", " href=\"", 4670, "\"", 4758, 2);
            WriteAttributeValue("", 4677, "/management/FnB/Category/Delete?id=", 4677, 35, true);
#nullable restore
#line 87 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Category\Index.cshtml"
WriteAttributeValue("", 4712, Html.DisplayFor(modelItem => item.CategoryID), 4712, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4759, "\"", 4767, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-danger"" data-original-title=""Remove"">
                                                    <i class=""fa fa-times""></i>
                                                </a>
                                            </div>
                                        </td>
                                    </tr>
");
#nullable restore
#line 93 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Category\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Category\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        // Add Category
        $('#category-row').DataTable({
            ""pageLength"": 10
        });

        var action = '<td> <div class=""form-button-action""> <button type=""button"" data-toggle=""tooltip"" title="""" class=""btn btn-link btn-simple-primary btn-lg"" data-original-title=""Edit Task""> <i class=""fa fa-edit""></i> </button> <button type=""button"" data-toggle=""tooltip"" title="""" class=""btn btn-link btn-simple-danger"" data-original-title=""Remove""> <i class=""fa fa-times""></i> </button> </div> </td>';

        $('#addCategoryButton').click(function () {
            /*$('#category-row').dataTable().fnAddData([
                $(""#CategoryName"").val(),
                $(""#CategoryDescription"").val(),
                action
            ]);*/
            //$('#addCategoryModal').modal('hide');
        });

        $(""div.form-button-action > button"").click(function () {
            let clickId = $(this).data(""edit-id"");
            let clickDelId = $(this).data(""delete-id"");
");
                WriteLiteral(@"            console.log(""Clicked : "" + clickId + "" "" + clickDelId);
            $(""table"").find('td:contains(""' + clickId + '"")').click(function () {
                let idValue = $(this).val();
                let CategoryName;
            });
        });
    </script>
");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Falcons.Pages.management.FnB.Category.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.FnB.Category.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.FnB.Category.IndexModel>)PageContext?.ViewData;
        public Falcons.Pages.management.FnB.Category.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591