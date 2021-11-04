#pragma checksum "C:\Users\imshe\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cea7775371e6d851b88422cf718d2496f629ee30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Falcons.Pages.management.FnB.Pages_management_FnB_Report), @"mvc.1.0.razor-page", @"/Pages/management/FnB/Report.cshtml")]
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
#line 1 "C:\Users\imshe\Documents\GitHub\Cinema-Management-System\Falcons\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\imshe\Documents\GitHub\Cinema-Management-System\Falcons\Pages\_ViewImports.cshtml"
using Falcons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\imshe\Documents\GitHub\Cinema-Management-System\Falcons\Pages\_ViewImports.cshtml"
using Falcons.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea7775371e6d851b88422cf718d2496f629ee30", @"/Pages/management/FnB/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda54c565b70cf76a129e71347f29674895644bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_management_FnB_Report : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\imshe\Documents\GitHub\Cinema-Management-System\Falcons\Pages\management\FnB\Report.cshtml"
  
    Layout = "_ManagementLayout";
    ViewData["Title"] = "Report";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Inventory Value Report-->
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title"">Product Inventory Value</div>
            </div>
            <div class=""card-body"">
                <div id=""chart-container"">
                    <canvas id=""LineChart"" height=""400px""></canvas>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End Inventory Value Report -->
<!-- Annual Expense Report-->
<div class=""row mt-3"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title"">Annual Expenses</div>
            </div>
            <div class=""card-body"">
                <div id=""chart-container"">
                    <canvas id=""barChart"" height=""450px""></canvas>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- End Annual Expense Report-->
<!-- Earning Repo");
            WriteLiteral(@"rt-->
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title"">Earning</div>
            </div>
            <div class=""card-body"">
                <div id=""chart-container"">
                    <canvas id=""EarningLineChart"" height=""400px""></canvas>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End Inventory Value Report -->


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        // Line Chart Inventory Value

        var lineChart = document.getElementById('LineChart').getContext('2d');

        var myLineChart = new Chart(lineChart, {
            type: 'line',
            data: {
                labels: [""Jan"", ""Feb"", ""Mar"", ""Apr"", ""May"", ""Jun"", ""Jul"", ""Aug"", ""Sep"", ""Oct"", ""Nov"", ""Dec""],
                datasets: [{
                    label: ""Inventory Value(MYR)"",
                    borderColor: ""#1d7af3"",
                    pointBorderColor: ""#FFF"",
                    pointBackgroundColor: ""#1d7af3"",
                    pointBorderWidth: 2,
                    pointHoverRadius: 4,
                    pointHoverBorderWidth: 1,
                    pointRadius: 4,
                    backgroundColor: 'transparent',
                    fill: true,
                    borderWidth: 2,
                    data: [542, 480, 430, 550, 530, 453, 380, 434, 568, 610, 700, 900]
                }]
            },
            options: {
       ");
                WriteLiteral(@"         responsive: true,
                maintainAspectRatio: false,
                legend: {
                    position: 'bottom',
                    labels: {
                        padding: 10,
                        fontColor: '#1d7af3',
                    }
                },
                tooltips: {
                    bodySpacing: 4,
                    mode: ""nearest"",
                    intersect: 0,
                    position: ""nearest"",
                    xPadding: 10,
                    yPadding: 10,
                    caretPadding: 10
                },
                layout: {
                    padding: { left: 15, right: 15, top: 15, bottom: 15 }
                }
            }
        });

        //End Line Chart Invetory Value


        //Start Bar Chart Annual Expense

        var barChart = document.getElementById('barChart').getContext('2d');

        var myBarChart = new Chart(barChart, {
            type: 'bar',
            data: {
");
                WriteLiteral(@"                labels: [""Jan"", ""Feb"", ""Mar"", ""Apr"", ""May"", ""Jun"", ""Jul"", ""Aug"", ""Sep"", ""Oct"", ""Nov"", ""Dec""],
                datasets: [{
                    label: ""Expenses (MYR)"",
                    backgroundColor: 'rgb(23, 125, 255)',
                    borderColor: 'rgb(23, 125, 255)',
                    data: [3667, 2375, 9423, 5355, 4454, 5646, 8654, 7566, 9787, 6588, 5417, 8883],
                }],
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                scales: {
                    yAxes: [{
                        ticks: {
                            beginAtZero: true
                        }
                    }]
                },
            }
        });

        //End Bar Chart Annual Expense


        // Earning Line Chart

        var lineChart = document.getElementById('EarningLineChart').getContext('2d');

        var myLineChart = new Chart(lineChart, {
            type: 'line',");
                WriteLiteral(@"
            data: {
                labels: [""Jan"", ""Feb"", ""Mar"", ""Apr"", ""May"", ""Jun"", ""Jul"", ""Aug"", ""Sep"", ""Oct"", ""Nov"", ""Dec""],
                datasets: [{
                    label: ""Earning (MYR)"",
                    borderColor: ""#1d7af3"",
                    pointBorderColor: ""#FFF"",
                    pointBackgroundColor: ""#1d7af3"",
                    pointBorderWidth: 2,
                    pointHoverRadius: 4,
                    pointHoverBorderWidth: 1,
                    pointRadius: 4,
                    backgroundColor: 'transparent',
                    fill: true,
                    borderWidth: 2,
                    data: [2133, 4344, 3545, 2845, 4324, 2133, 3200, 2933, 3600, 2400, 2666, 4600]
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                legend: {
                    position: 'bottom',
                    labels: {
                        padding: 10,
 ");
                WriteLiteral(@"                       fontColor: '#1d7af3',
                    }
                },
                tooltips: {
                    bodySpacing: 4,
                    mode: ""nearest"",
                    intersect: 0,
                    position: ""nearest"",
                    xPadding: 10,
                    yPadding: 10,
                    caretPadding: 10
                },
                layout: {
                    padding: { left: 15, right: 15, top: 15, bottom: 15 }
                }
            }
        });

            //End Earning Line Chart
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Falcons.Pages.management.FnB.ReportModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.FnB.ReportModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.FnB.ReportModel>)PageContext?.ViewData;
        public Falcons.Pages.management.FnB.ReportModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
