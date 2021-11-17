#pragma checksum "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "243f15af730a037f22e60c7443c00be9109b517b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Falcons.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
namespace Falcons.Pages
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
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\Cart.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243f15af730a037f22e60c7443c00be9109b517b", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda54c565b70cf76a129e71347f29674895644bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\Cart.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8"">
        <div id=""cart"">
            <!-- Product Menu -->
        </div>
    </div>
    <div class=""col=md-4"">
        <div class=""row"">
            <div class=""col-md-12""><h3>Summary</h3></div>
        </div>
        <div class=""row mt-3"">
            <div class=""col-md-6"">
                <h5>Total Price</h5>
            </div>
            <div class=""col-md-6"">
                <h5 id=""TotalPrice""></h5>
            </div>
        </div>
        <div class=""row mt-5"">
            <div class=""col-md-12"">
                <button class=""btn btn-primary"">Checkout & Pay</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n    $(function () {\r\n");
#nullable restore
#line 38 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\Cart.cshtml"
          
            string ProductDetailjson = JsonConvert.SerializeObject(Model.ProductDetails);
            string Productjson = JsonConvert.SerializeObject(Model.Products);
            string Menujson = JsonConvert.SerializeObject(Model.Menus);
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        var Product = ");
#nullable restore
#line 43 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\Cart.cshtml"
                 Write(Html.Raw(Productjson));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        var ProductDetail = ");
#nullable restore
#line 44 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\Cart.cshtml"
                       Write(Html.Raw(ProductDetailjson));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        var Menu = ");
#nullable restore
#line 45 "C:\Users\User\Documents\GitHub\Cinema-Management-System\Falcons\Pages\Cart.cshtml"
              Write(Html.Raw(Menujson));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        function AppendToCart(title, description, price, imgUrl, id) {
            $(""div#cart"").append(""<div class='row mt-5'>"" +
                ""<div class='col-md-3'>"" +
                ""<img style='max-width:100%;' src='/assets/img/menus/"" + imgUrl + ""' />"" +
                ""</div>"" +
                ""<div class='col-md-9'>"" +
                ""<div style=''font-size:20px;'>"" + title + ""</div>"" +
                ""<div>"" +
                ""<p>"" + description + ""</p>"" +
                ""</div>"" +
                ""<div>RM "" + price + ""</div>"" +
                ""<div>"" +
                ""<button class='btn btn-primary' id='removeMenu' data-MenuId='"" + id + ""'>"" +
                ""<i class='fas fa-trash-alt'></i> Remove"" +
                ""</button>"" +
                ""</div>"" +
                ""</div>"" +
                ""</div>"");
        }

        function AppendToAlarcarteCart(title, description, price, imgUrl,id) {
            $(""div#cart"").append(""<div class='row mt-5'>"" +
   ");
                WriteLiteral(@"             ""<div class='col-md-3'>"" +
                ""<img style='max-width:100%;' src='/assets/img/products/"" + imgUrl + ""' />"" +
                ""</div>"" +
                ""<div class='col-md-9'>"" +
                ""<div style=''font-size:20px;'>"" + title + ""</div>"" +
                ""<div>"" +
                ""<p>"" + description + ""</p>"" +
                ""</div>"" +
                ""<div>RM "" + price + ""</div>"" +
                ""<div>"" +
                ""<button class='btn btn-primary' id='removeAlaCarte'data-productId='"" + id + ""'>"" +
                ""<i class='fas fa-trash-alt'></i> Remove"" +
                ""</button>"" +
                ""</div>"" +
                ""</div>"" +
                ""</div>"");
        }

        let TotalSummaryPrice = 0;

        if (typeof (Storage) !== ""undefined"") {
            let cartMenuArray = [];
            if (!(localStorage.getItem(""FnBMenuCart"") == null || localStorage.getItem(""FnBMenuCart"") == """")) {
                cartMenuArray = JSON.par");
                WriteLiteral(@"se(localStorage.getItem(""FnBMenuCart""));
            }

            if (cartMenuArray.length > 0) {
                for (let i = 0; i < cartMenuArray.length; i++) {
                    //product name
                    let title = """";
                    let IMGLink = """";
                    let id = 0;
                    for (let k = 0; k < Menu.length; k++) {
                        if (cartMenuArray[i].MenuID == Menu[k].MenuID) {
                            title = Menu[k].PackageName;
                            IMGLink = Menu[k].ImageURL.split("","", 1);
                            id = cartMenuArray[i].MenuID;
                        }
                    }

                    let ProductDescription = """";
                    let TotalPrice = 0;
                    //console.log(cartMenuArray[i].ProductDetail);

                    //process ProductDetail in the cart one by one
                    for (let y = 0; y < cartMenuArray[i].ProductDetail.length; y++) {
                  ");
                WriteLiteral(@"      //find product detail size first
                        for (let j = 0; j < ProductDetail.length; j++) {
                            if (cartMenuArray[i].ProductDetail[y].ProductDetailID == ProductDetail[j].ProductDetailID) {
                                //find product name
                                for (let u = 0; u < Product.length; u++) {
                                    //console.log(""Product : "" + Product[u].ProductID);
                                    //console.log(""Product ID: "" + ProductDetail[j].ProductID);
                                    if (Product[u].ProductID == ProductDetail[j].ProductID) {
                                        console.log(""Found"");
                                        if (y == 0) {
                                            ProductDescription = Product[u].ProductTitle + "" ("" + ProductDetail[j].Size +"")"";
                                            TotalPrice = ProductDetail[j].ProductPrice;
                                        } el");
                WriteLiteral(@"se {
                                            ProductDescription = ProductDescription + ""<br/>"" + Product[u].ProductTitle + "" ("" + ProductDetail[j].Size + "")"";
                                            TotalPrice += ProductDetail[j].ProductPrice;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    TotalSummaryPrice += TotalPrice;
                    //console.log(""\nTitle"" + title + ""\n Description "" + ProductDescription + ""\nPrice "" + TotalPrice + ""\nImg "" + IMGLink);
                    AppendToCart(title, ProductDescription, TotalPrice, IMGLink, id);
                }
            }

            //A la carte Product
            let cartArray = [];
            if (!(localStorage.getItem(""FnBProductCart"") == null || localStorage.getItem(""FnBProductCart"") == """")) {
                cartArray = JSON.parse(localStorage.getItem(""FnBPr");
                WriteLiteral(@"oductCart""));
            }

            if (cartArray.length > 0) {
                for (let i = 0; i < cartArray.length; i++) {
                    //product name
                    let title = """";
                    let IMGLink = """";
                    let ProductDescription = """";
                    let TotalPrice = 0;
                    let id = 0;
                    for (let k = 0; k < ProductDetail.length; k++) {
                        if (cartArray[i].ProductDetailID == ProductDetail[k].ProductDetailID) {
                            ProductDescription = ProductDetail[k].Size + "" x "" + cartArray[i].quantity;
                            TotalPrice = ProductDetail[k].ProductPrice * cartArray[i].quantity;
                            id = cartArray[i].ProductDetailID;

                            for (let o = 0; o < Product.length; o++) {
                                if (Product[o].ProductID == ProductDetail[k].ProductID) {
                                    title = Product[o].");
                WriteLiteral(@"ProductTitle;
                                    IMGLink = Product[o].ImageURL.split("","", 1);
                                }
                            }
                        }

                    }

                    //console.log(""\nTitle"" + title + ""\n Description "" + ProductDescription + ""\nPrice "" + TotalPrice + ""\nImg "" + IMGLink);
                    TotalSummaryPrice += TotalPrice;
                    AppendToAlarcarteCart(title, ProductDescription, TotalPrice, IMGLink, id);
                }
            }
        }

        $(""h5#TotalPrice"").text(""RM "" + TotalSummaryPrice);

        $(""button#removeMenu"").click(function () {
            let targetID = $(this).data(""menuid"");
            if (typeof (Storage) !== ""undefined"") {
                let cartMenuArray = [];
                if (!(localStorage.getItem(""FnBMenuCart"") == null || localStorage.getItem(""FnBMenuCart"") == """")) {
                    cartMenuArray = JSON.parse(localStorage.getItem(""FnBMenuCart""));
    ");
                WriteLiteral(@"            }
                if (cartMenuArray.length > 0) {
                    for (let i = 0; i<cartMenuArray.length; i++) {
                        if (cartMenuArray[i].MenuID == targetID) {
                            delete cartMenuArray[i];

                            let filtered = []; //declare array list var

                            //recreate array list wiithout null element
                            filtered = cartMenuArray.filter(function (el) {
                                return el != null;
                            });

                            //remove whole localSotrage item if no item in the array list
                            if (filtered.length == 0) {
                                localStorage.removeItem(""FnBMenuCart"");
                            } else {
                                localStorage.setItem(""FnBMenuCart"", JSON.stringify(filtered));
                            }

                            location.reload(); //relaod if item is d");
                WriteLiteral(@"eleted
                        }
                    }
                }
            }

        });

        $(""button#removeAlaCarte"").click(function () {
            let targetID = $(this).data(""productid"");
            if (typeof (Storage) !== ""undefined"") {
                let cartProductArray = [];
                if (!(localStorage.getItem(""FnBProductCart"") == null || localStorage.getItem(""FnBProductCart"") == """")) {
                    cartProductArray = JSON.parse(localStorage.getItem(""FnBProductCart""));
                }
                if (cartProductArray.length > 0) {
                    for (let i = 0; i < cartProductArray.length; i++) {
                        if (cartProductArray[i].ProductDetailID == targetID) {
                            delete cartProductArray[i];

                            let filtered = []; //declare array list var

                            //recreate array list wiithout null element
                            filtered = cartProductArray.filter");
                WriteLiteral(@"(function (el) {
                                return el != null;
                            });

                            //remove whole localSotrage item if no item in the array list
                            if (filtered.length == 0) {
                                localStorage.removeItem(""FnBProductCart"");
                            } else {
                                localStorage.setItem(""FnBProductCart"", JSON.stringify(filtered));
                            }

                            location.reload(); //relaod if item is deleted
                        }
                    }
                }
            }

        });
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Falcons.Pages.CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Falcons.Pages.CartModel>)PageContext?.ViewData;
        public Falcons.Pages.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
