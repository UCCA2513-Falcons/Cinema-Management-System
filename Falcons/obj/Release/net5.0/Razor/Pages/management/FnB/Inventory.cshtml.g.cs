#pragma checksum "C:\Users\User\OneDrive - 1utarmy.onmicrosoft.com\Oct 2021\UCCA2513 MINI PROJECT\Cinema Management System\Falcons\Falcons\Pages\management\FnB\Inventory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0de2c7bc03f1c3419124dc5d604f139690dd44be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Falcons.Pages.management.FnB.Pages_management_FnB_Inventory), @"mvc.1.0.razor-page", @"/Pages/management/FnB/Inventory.cshtml")]
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
#line 1 "C:\Users\User\OneDrive - 1utarmy.onmicrosoft.com\Oct 2021\UCCA2513 MINI PROJECT\Cinema Management System\Falcons\Falcons\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive - 1utarmy.onmicrosoft.com\Oct 2021\UCCA2513 MINI PROJECT\Cinema Management System\Falcons\Falcons\Pages\_ViewImports.cshtml"
using Falcons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\OneDrive - 1utarmy.onmicrosoft.com\Oct 2021\UCCA2513 MINI PROJECT\Cinema Management System\Falcons\Falcons\Pages\_ViewImports.cshtml"
using Falcons.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de2c7bc03f1c3419124dc5d604f139690dd44be", @"/Pages/management/FnB/Inventory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda54c565b70cf76a129e71347f29674895644bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_management_FnB_Inventory : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\OneDrive - 1utarmy.onmicrosoft.com\Oct 2021\UCCA2513 MINI PROJECT\Cinema Management System\Falcons\Falcons\Pages\management\FnB\Inventory.cshtml"
  
    Layout = "_ManagementLayout";

    ViewData["Title"] = "Food and Beverages Inventory";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title"">Inventory</div>
            </div>
            <div class=""card-body"">
                
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Falcons.Pages.management.FnB.InventoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.FnB.InventoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.management.FnB.InventoryModel>)PageContext?.ViewData;
        public Falcons.Pages.management.FnB.InventoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
