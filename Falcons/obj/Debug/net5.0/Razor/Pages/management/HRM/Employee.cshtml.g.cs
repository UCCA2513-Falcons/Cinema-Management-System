#pragma checksum "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\HRM\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4b50855ebc87e0d1d40d2254253fd0c6ac8bd76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Falcons.Pages.management.HRM.Pages_management_HRM_Employee), @"mvc.1.0.razor-page", @"/Pages/management/HRM/Employee.cshtml")]
namespace Falcons.Pages.management.HRM
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4b50855ebc87e0d1d40d2254253fd0c6ac8bd76", @"/Pages/management/HRM/Employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda54c565b70cf76a129e71347f29674895644bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_management_HRM_Employee : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\HRM\Employee.cshtml"
  

    Layout = "_ManagementLayout";

    ViewData["Title"] = "Employee";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title"">Employee</div>
            </div>
            <div class=""card-body"">
                <!-- Button -->
                <div class=""d-flex"">
                    <button class=""btn btn-primary btn-round ml-auto mb-3"" data-toggle=""modal"" data-target=""#addEmployee"">
                        <i class=""fa fa-plus""></i>
                        Add New Staff
                    </button>
                </div>

                <!-- Modal -->
                <div class=""modal fade"" id=""addEmployee"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header no-bd"">
                                <h5 class=""modal-title"">
                                    <spa");
            WriteLiteral(@"n class=""fw-mediumbold"">
                                        New
                                    </span>
                                    <span class=""fw-light"">
                                        Employee
                                    </span>
                                </h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                            <div class=""modal-body"">
                                <p class=""small"">Please fill in all the field.</p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4b50855ebc87e0d1d40d2254253fd0c6ac8bd766007", async() => {
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-sm-12"">
                                            <div class=""form-group form-group-default"">
                                                <label>Employee ID</label>
                                                <input id=""addEmpID"" type=""text"" class=""form-control"" placeholder=""Employee ID"">
                                            </div>
                                        </div>
                                        <div class=""col-sm-12"">
                                            <div class=""form-group form-group-default"">
                                                <label>First Name</label>
                                                <input id=""addFirstName"" type=""text"" class=""form-control"" placeholder=""First Name"">
                                            </div>
                                        </div>
                                        <div ");
                WriteLiteral(@"class=""col-sm-12"">
                                            <div class=""form-group form-group-default"">
                                                <label>Last Name</label>
                                                <input id=""addLastName"" type=""text"" class=""form-control"" placeholder=""Last Name"">
                                            </div>
                                        </div>
                                        <div class=""col-sm-12"">
                                            <div class=""form-group form-group-default"">
                                                <label>Department</label>
                                                <input id=""addDepartment"" type=""text"" class=""form-control"" placeholder=""Department"">
                                            </div>
                                        </div>
                                    </div>
                                ");
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
                                <button type=""button"" id=""addDetailButton"" class=""btn btn-primary"">Add</button>
                                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Table -->
                <div class=""table-responsive"">
                    <table id=""employee-row"" class="" display table table-striped table-hover"" cellspacing=""0"" width=""100%"">
                        <thead>
                            <tr role=""row""></tr>

                            <tr role=""row"">
                                <th>Employee ID</th>
                                <th>First Name</th>
                                <th>Last Name</th>
                                <th>Department</th>
                            ");
            WriteLiteral(@"    <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>00001</td>
                                <td>Andy</td>
                                <td>Tan</td>
                                <td>Purchasing</td>
                                <td>
                                    <div class=""form-button-action"">
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 5492, "\"", 5500, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit"">
                                            <i class=""fa fa-edit""></i>
                                        </button>
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 5777, "\"", 5785, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-link btn-danger\" data-original-title=\"View\">\r\n                                            <i class=\"fa fa-info\"></i>\r\n                                        </button>\r\n                                        <button");
            BeginWriteAttribute("title", " title=\"", 6018, "\"", 6026, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""badge badge-success"">
                                            Active
                                        </button>
                                    </div>
                                </td>
                            </tr>

                            <tr>
                                <td>00001</td>
                                <td>Calvin</td>
                                <td>Chin</td>
                                <td>R&D</td>
                                <td>
                                    <div class=""form-button-action"">
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 6696, "\"", 6704, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit"">
                                            <i class=""fa fa-edit""></i>
                                        </button>
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 6981, "\"", 6989, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-link btn-danger\" data-original-title=\"View\">\r\n                                            <i class=\"fa fa-info\"></i>\r\n                                        </button>\r\n                                        <button");
            BeginWriteAttribute("title", " title=\"", 7222, "\"", 7230, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""badge badge-danger"">
                                            Deactive
                                        </button>
                                    </div>
                                </td>
                            </tr>

                            <tr>
                                <td>00001</td>
                                <td>Alex</td>
                                <td>Ng</td>
                                <td>Accounting and Finance</td>
                                <td>
                                    <div class=""form-button-action"">
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 7916, "\"", 7924, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit"">
                                            <i class=""fa fa-edit""></i>
                                        </button>
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 8201, "\"", 8209, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-link btn-danger\" data-original-title=\"View\">\r\n                                            <i class=\"fa fa-info\"></i>\r\n                                        </button>\r\n                                        <button");
            BeginWriteAttribute("title", " title=\"", 8442, "\"", 8450, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""badge badge-success"">
                                            Active
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
    <script>// Add Category
        $('#employee-row').DataTable({
            ""pageLength"": 5,
        });

        var action = '<td> <button type=""button"" data-toggle=""tooltip"" title="""" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit""> <i class=""fa fa-edit""></i> </button> <button type=""button"" data-toggle=""tooltip"" title="""" class=""btn btn-link btn-danger"" data-original-title=""View""> <i class=""fa fa-info""></i> </button> </td >';

        $('#addDetailButton').click(function () {
            $('#employee-row').dataTable().fnAddData([

                $(""#addEmpID"").val(),
                $(""#addFirstName"").val(),
                $(""#addLastName"").val(),
                $(""#addDepartment"").val(),
                action
            ]);
            $('#addEmployeeModal').modal('hide');

        });</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Falcons.Pages.management.Staff_Management.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.Staff_Management.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.Staff_Management.IndexModel>)PageContext?.ViewData;
        public Falcons.Pages.management.Staff_Management.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
