#pragma checksum "D:\Mini Project\Cinema-Management-System-main\Falcons\Pages\management\HRM\Attendance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f48d5e0c96f7e2dd0d79624ee9edcb48fcb6958c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Falcons.Pages.management.HRM.Pages_management_HRM_Attendance), @"mvc.1.0.razor-page", @"/Pages/management/HRM/Attendance.cshtml")]
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
#line 1 "D:\Mini Project\Cinema-Management-System-main\Falcons\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Mini Project\Cinema-Management-System-main\Falcons\Pages\_ViewImports.cshtml"
using Falcons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Mini Project\Cinema-Management-System-main\Falcons\Pages\_ViewImports.cshtml"
using Falcons.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f48d5e0c96f7e2dd0d79624ee9edcb48fcb6958c", @"/Pages/management/HRM/Attendance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f80116445c458057e7411bcb18d4ca4fd31b0ce", @"/Pages/_ViewImports.cshtml")]
    public class Pages_management_HRM_Attendance : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "D:\Mini Project\Cinema-Management-System-main\Falcons\Pages\management\HRM\Attendance.cshtml"
  

    Layout = "_ManagementLayout";

    ViewData["Title"] = "Attendance";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title"">Attendance</div>
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
                                    <s");
            WriteLiteral(@"pan class=""fw-mediumbold"">
                                        New
                                    </span>
                                    <span class=""fw-light"">
                                        New Employee
                                    </span>
                                </h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                            <div class=""modal-body"">
                                <p class=""small"">Please fill in all the field.</p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f48d5e0c96f7e2dd0d79624ee9edcb48fcb6958c5977", async() => {
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-sm-12"">
                                            <div class=""form-group form-group-default"">
                                                <label>Last Name</label>
                                                <textarea class=""form-control"" rows=""8"" placeholder=""Last Name""></textarea>
                                            </div>
                                        </div>
                                        <div class=""col-sm-12"">
                                            <div class=""form-group form-group-default"">
                                                <label>First Name</label>
                                                <input id=""addFirstName"" type=""text"" class=""form-control"" placeholder=""First Name"">
                                            </div>
                                        </div>
                                        <div class=""");
                WriteLiteral(@"col-sm-12"">
                                            <div class=""form-group form-group-default"">
                                                <label>Last Name</label>
                                                <textarea class=""form-control"" rows=""8"" placeholder=""Last Name""></textarea>
                                            </div>
                                        </div>
                                        <div class=""col-sm-12"">
                                            <div class=""form-group form-group-default"">
                                                <label>Last Name</label>
                                                <textarea class=""form-control"" rows=""8"" placeholder=""Last Name""></textarea>
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
                                <button type=""button"" id=""addFirstName"" class=""btn btn-primary"">Add</button>
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
            WriteLiteral(@" <th>Action</th>
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
            BeginWriteAttribute("title", " title=\"", 5466, "\"", 5474, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit"">
                                            <i class=""fa fa-edit""></i>
                                        </button>
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 5751, "\"", 5759, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-danger"" data-original-title=""View"">
                                            <i class=""fa fa-info""></i>
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
            BeginWriteAttribute("title", " title=\"", 6480, "\"", 6488, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit"">
                                            <i class=""fa fa-edit""></i>
                                        </button>
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 6765, "\"", 6773, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-danger"" data-original-title=""View"">
                                            <i class=""fa fa-info""></i>
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
            BeginWriteAttribute("title", " title=\"", 7509, "\"", 7517, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit"">
                                            <i class=""fa fa-edit""></i>
                                        </button>
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 7794, "\"", 7802, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-danger"" data-original-title=""View"">
                                            <i class=""fa fa-info""></i>
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

        var action = '<td> <div class=""form-button-action""> <button type=""button"" data-toggle=""tooltip"" title="""" class=""btn btn-link btn-simple-primary btn-lg"" data-original-title=""Edit Task""> <i class=""fa fa-edit""></i> </button> <button type=""button"" data-toggle=""tooltip"" title="""" class=""btn btn-link btn-simple-danger"" data-original-title=""Remove""> <i class=""fa fa-times""></i> </button> </div> </td>';

        $('#addFirstName').click(function () {
            $('#employee-row').dataTable().fnAddData([
                $(""#addFirstName"").val(),
                $(""#addPosition"").val(),
                $(""#addOffice"").val(),
                action
            ]);
            $('#addCategoryModal').modal('hide');

        });</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Falcons.Pages.management.HRM.AttendanceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.HRM.AttendanceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.HRM.AttendanceModel>)PageContext?.ViewData;
        public Falcons.Pages.management.HRM.AttendanceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591