#pragma checksum "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\HRM\Salary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d66330cea66607017dbcab615268ef9ac003af51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Falcons.Pages.management.HRM.Pages_management_HRM_Salary), @"mvc.1.0.razor-page", @"/Pages/management/HRM/Salary.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d66330cea66607017dbcab615268ef9ac003af51", @"/Pages/management/HRM/Salary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda54c565b70cf76a129e71347f29674895644bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_management_HRM_Salary : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\HRM\Salary.cshtml"
  

    Layout = "_ManagementLayout";

    ViewData["Title"] = "Salary";



#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title"">Salary</div>
            </div>
            <div class=""card-body"">
                <!-- Button -->
                <div class=""d-flex""></div>

                <!-- Modal -->
                <div class=""modal fade"" id=""addEmployee"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">

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
                     ");
            WriteLiteral(@"           <th>Salary</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>00001</td>
                                <td>Andy</td>
                                <td>Tan</td>
                                <td>RM2000</td>
                                <td>
                                    <div class=""form-button-action"">
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 1759, "\"", 1767, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit"">
                                            <i class=""fa fa-edit""></i>
                                        </button>
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 2044, "\"", 2052, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-danger"" data-original-title=""View"">
                                            <i class=""fa fa-info""></i>
                                        </button>
                                    </div>
                                </td>
                            </tr>

                            <tr>
                                <td>00002</td>
                                <td>Calvin</td>
                                <td>Chin</td>
                                <td>RM2500</td>
                                <td>
                                    <div class=""form-button-action"">
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 2776, "\"", 2784, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit"">
                                            <i class=""fa fa-edit""></i>
                                        </button>
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 3061, "\"", 3069, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-danger"" data-original-title=""View"">
                                            <i class=""fa fa-info""></i>
                                        </button>
                                    </div>
                                </td>
                            </tr>

                            <tr>
                                <td>00003</td>
                                <td>Alex</td>
                                <td>Ng</td>
                                <td>RM3000</td>
                                <td>
                                    <div class=""form-button-action"">
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 3789, "\"", 3797, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link btn-primary btn-lg"" data-original-title=""Edit"">
                                            <i class=""fa fa-edit""></i>
                                        </button>
                                        <button type=""button"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 4074, "\"", 4082, 0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Falcons.Pages.management.HRM.SalaryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.HRM.SalaryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.HRM.SalaryModel>)PageContext?.ViewData;
        public Falcons.Pages.management.HRM.SalaryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
