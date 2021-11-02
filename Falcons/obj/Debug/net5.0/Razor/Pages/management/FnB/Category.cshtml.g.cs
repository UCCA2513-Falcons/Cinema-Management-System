#pragma checksum "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60cd9bbd6fd3d28ac40bace7be9a6f57f6a60d4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Falcons.Pages.management.FnB.Pages_management_FnB_Category), @"mvc.1.0.razor-page", @"/Pages/management/FnB/Category.cshtml")]
namespace Falcons.Pages.management.FnB
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60cd9bbd6fd3d28ac40bace7be9a6f57f6a60d4e", @"/Pages/management/FnB/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda54c565b70cf76a129e71347f29674895644bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_management_FnB_Category : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Category.cshtml"
  
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
                            <div class=""modal-body"">
                                <p class=""small"">Please fill in all the field.</p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60cd9bbd6fd3d28ac40bace7be9a6f57f6a60d4e6045", async() => {
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-sm-12"">
                                            <div class=""form-group form-group-default"">
                                                <label>Category Name</label>
                                                <input id=""addName"" type=""text"" class=""form-control"" placeholder=""Category Name"">
                                            </div>
                                        </div>
                                        <div class=""col-md-12"">
                                            <div class=""form-group form-group-default"">
                                                <label>Description</label>
                                                <textarea class=""form-control"" rows=""8"" placeholder=""Category description here ...""></textarea>
                                            </div>
                                        </div>
                             ");
                WriteLiteral("       </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""modal-footer no-bd"">
                                <button type=""button"" id=""addCategoryButton"" class=""btn btn-primary"">Add</button>
                                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                            </div>
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
                                <th>Description</th>
                                <th>Action</th>
                            </tr>
        ");
            WriteLiteral(@"                </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>Beverages</td>
                                <td>drink and alcohol</td>
                                <td>
                                    <div class=""form-button-action"">
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 4512, "\"", 4520, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit"">
                                            <i class=""fa fa-edit""></i>
                                        </button>
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 4797, "\"", 4805, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-danger"" data-original-title=""Remove"">
                                            <i class=""fa fa-times""></i>
                                        </button>
                                    </div>
                                </td>
                            </tr>

                            <tr>
                                <td>2</td>
                                <td>Side Dishes</td>
                                <td> a food served separately along with the main course.</td>
                                <td>
                                    <div class=""form-button-action"">
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 5533, "\"", 5541, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit"">
                                            <i class=""fa fa-edit""></i>
                                        </button>
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 5818, "\"", 5826, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-danger"" data-original-title=""Remove"">
                                            <i class=""fa fa-times""></i>
                                        </button>
                                    </div>
                                </td>
                            </tr>

                            <tr>
                                <td>3</td>
                                <td>Dessert</td>
                                <td> a usually sweet course or dish.</td>
                                <td>
                                    <div class=""form-button-action"">
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 6529, "\"", 6537, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit"">
                                            <i class=""fa fa-edit""></i>
                                        </button>
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 6814, "\"", 6822, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-danger"" data-original-title=""Remove"">
                                            <i class=""fa fa-times""></i>
                                        </button>
                                    </div>
                                </td>
                            </tr>

                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        // Add Category
        $('#category-row').DataTable({
            ""pageLength"": 5,
        });

        var action = '<td> <div class=""form-button-action""> <button type=""button"" data-toggle=""tooltip"" title="""" class=""btn btn-link btn-simple-primary btn-lg"" data-original-title=""Edit Task""> <i class=""fa fa-edit""></i> </button> <button type=""button"" data-toggle=""tooltip"" title="""" class=""btn btn-link btn-simple-danger"" data-original-title=""Remove""> <i class=""fa fa-times""></i> </button> </div> </td>';

        $('#addCategoryButton').click(function () {
            $('#category-row').dataTable().fnAddData([
                $(""#addName"").val(),
                $(""#addPosition"").val(),
                $(""#addOffice"").val(),
                action
            ]);
            $('#addCategoryModal').modal('hide');

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Falcons.Pages.management.FnB.CategoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.FnB.CategoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.FnB.CategoryModel>)PageContext?.ViewData;
        public Falcons.Pages.management.FnB.CategoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
