#pragma checksum "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10136554615bcec6dd2d3439aed8ef91df816b6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\_ViewImports.cshtml"
using EndPoints.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\_ViewImports.cshtml"
using EndPoints.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\_ViewImports.cshtml"
using EndPoints.WebUI.Models.Producte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\_ViewImports.cshtml"
using EndPoints.WebUI.Models.Categories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10136554615bcec6dd2d3439aed8ef91df816b6c", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"062286973dfc7c644e884ed73ff7051c8d0aaa02", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<!-- Basic -->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10136554615bcec6dd2d3439aed8ef91df816b6c4425", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">

    <!-- Mobile Metas -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <!-- Site Metas -->
    <title>ThewayShop - Ecommerce Bootstrap 4 HTML Template</title>
    <meta name=""keywords""");
                BeginWriteAttribute("content", " content=\"", 372, "\"", 382, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 414, "\"", 424, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 451, "\"", 461, 0);
                EndWriteAttribute();
                WriteLiteral(@">

    <!-- Site Icons -->
    <link rel=""shortcut icon"" href=""images/favicon.ico"" type=""image/x-icon"">
    <link rel=""apple-touch-icon"" href=""images/apple-touch-icon.png"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""css/bootstrap.min.css"">
    <!-- Site CSS -->
    <link rel=""stylesheet"" href=""css/style.css"">
    <!-- Responsive CSS -->
    <link rel=""stylesheet"" href=""css/responsive.css"">
    <!-- Custom CSS -->
    <link rel=""stylesheet"" href=""css/custom.css"">

    <!--[if lt IE 9]>
      <script src=""https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>
      <script src=""https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js""></script>
    <![endif]-->

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10136554615bcec6dd2d3439aed8ef91df816b6c7004", async() => {
                WriteLiteral(@"

    <!-- Start Main Top -->
    <!-- End Main Top -->
    <!-- Start Main Top -->
    <header class=""main-header"">
        <!-- Start Navigation -->
        <nav class=""navbar navbar-expand-lg navbar-light bg-light navbar-default bootsnav"">
            <div class=""container"">
                <!-- Start Header Navigation -->
                <div class=""navbar-header"">
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbar-menu"" aria-controls=""navbars-rs-food"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <i class=""fa fa-bars""></i>
                    </button>
                    <a class=""navbar-brand"" href=""index.html""><img src=""images/logo.png"" class=""logo""");
                BeginWriteAttribute("alt", " alt=\"", 1971, "\"", 1977, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                </div>
                <!-- End Header Navigation -->
                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class=""collapse navbar-collapse"" id=""navbar-menu"">
                    <ul class=""nav navbar-nav ml-auto"" data-in=""fadeInDown"" data-out=""fadeOutUp"">
                        <li class=""nav-item active""><a class=""nav-link"" href=""index.html"">Home</a></li>
                        <li class=""nav-item""><a class=""nav-link"" href=""about.html"">About Us</a></li>

");
                WriteLiteral("\r\n                        ");
#nullable restore
#line 63 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Shared\_Layout.cshtml"
                   Write(await Component.InvokeAsync("NavigationMenu"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"



                        <li class=""dropdown"">
                            <a href=""#"" class=""nav-link dropdown-toggle arrow"" data-toggle=""dropdown"">SHOP</a>
                            <ul class=""dropdown-menu"">
                                <li><a href=""cart.html"">Cart</a></li>
                                <li><a href=""checkout.html"">Checkout</a></li>
                                <li><a href=""my-account.html"">My Account</a></li>
                                <li><a href=""wishlist.html"">Wishlist</a></li>
                                <li><a href=""shop-detail.html"">Shop Detail</a></li>
                            </ul>
                        </li>
                        <li class=""nav-item""><a class=""nav-link"" href=""service.html"">Our Service</a></li>
                        <li class=""nav-item""><a class=""nav-link"" href=""contact-us.html"">Contact Us</a></li>
                    </ul>
                </div>
                <!-- /.navbar-collapse -->
                <!-- Start ");
                WriteLiteral(@"Atribute Navigation -->
                <div class=""attr-nav"">
                    <ul>
                        <li class=""search""><a href=""#""><i class=""fa fa-search""></i></a></li>
                        <li class=""side-menu"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10136554615bcec6dd2d3439aed8ef91df816b6c10477", async() => {
                    WriteLiteral("\r\n                                <i class=\"fa fa-shopping-bag\"></i>\r\n");
                    WriteLiteral("                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </li>
                    </ul>
                </div>
                <!-- End Atribute Navigation -->
            </div>
            <!-- Start Side Menu -->
            <div class=""side"">
                <a href=""#"" class=""close-side""><i class=""fa fa-times""></i></a>
                <li class=""cart-box"">
                    <ul class=""cart-list"">
                        <li>
                            <a href=""#"" class=""photo""><img src=""images/img-pro-01.jpg"" class=""cart-thumb""");
                BeginWriteAttribute("alt", " alt=\"", 4656, "\"", 4662, 0);
                EndWriteAttribute();
                WriteLiteral(@" /></a>
                            <h6><a href=""#"">Delica omtantur </a></h6>
                            <p>1x - <span class=""price"">$80.00</span></p>
                        </li>
                        <li>
                            <a href=""#"" class=""photo""><img src=""images/img-pro-02.jpg"" class=""cart-thumb""");
                BeginWriteAttribute("alt", " alt=\"", 4984, "\"", 4990, 0);
                EndWriteAttribute();
                WriteLiteral(@" /></a>
                            <h6><a href=""#"">Omnes ocurreret</a></h6>
                            <p>1x - <span class=""price"">$60.00</span></p>
                        </li>
                        <li>
                            <a href=""#"" class=""photo""><img src=""images/img-pro-03.jpg"" class=""cart-thumb""");
                BeginWriteAttribute("alt", " alt=\"", 5311, "\"", 5317, 0);
                EndWriteAttribute();
                WriteLiteral(@" /></a>
                            <h6><a href=""#"">Agam facilisis</a></h6>
                            <p>1x - <span class=""price"">$40.00</span></p>
                        </li>
                        <li class=""total"">
                            <a href=""#"" class=""btn btn-default hvr-hover btn-cart"">VIEW CART</a>
                            <span class=""float-right""><strong>Total</strong>: $180.00</span>
                        </li>
                    </ul>
                </li>
            </div>
            <!-- End Side Menu -->
        </nav>
        <!-- End Navigation -->
    </header>
    <!-- End Main Top -->
    <!-- Start Top Search -->
    <div class=""top-search"">
        <div class=""container"">
            <div class=""input-group"">
                <span class=""input-group-addon""><i class=""fa fa-search""></i></span>
                <input type=""text"" class=""form-control"" placeholder=""Search"">
                <span class=""input-group-addon close-search""><i class=""fa fa-ti");
                WriteLiteral(@"mes""></i></span>
            </div>
        </div>
    </div>
    <!-- End Top Search -->
    <!-- Start Slider -->
    <div id=""slides-shop"" class=""cover-slides"">
        <ul class=""slides-container"">
            <li class=""text-left"">
                <img src=""images/download_.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 6635, "\"", 6641, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n\r\n                    </div>\r\n                </div>\r\n            </li>\r\n            <li class=\"text-center\">\r\n                <img src=\"images/download2.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 6883, "\"", 6889, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n\r\n                    </div>\r\n                </div>\r\n            </li>\r\n            <li class=\"text-right\">\r\n                <img src=\"images/download _g.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 7132, "\"", 7138, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <div class=""container"">
                    <div class=""row"">

                    </div>
                </div>
            </li>
        </ul>
        <div class=""slides-navigation"">
            <a href=""#"" class=""next""><i class=""fa fa-angle-right"" aria-hidden=""true""></i></a>
            <a href=""#"" class=""prev""><i class=""fa fa-angle-left"" aria-hidden=""true""></i></a>
        </div>
    </div>
    <!-- End Slider -->
    <!-- Start Categories  -->

    <div class=""categories-shop"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                    <div class=""shop-cat-box"">
                        <img class=""img-fluid"" src=""images/t-shirts-img.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 7919, "\"", 7925, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <a class=\"btn hvr-hover\" href=\"#\">T-shirts</a>\r\n                    </div>\r\n                    <div class=\"shop-cat-box\">\r\n                        <img class=\"img-fluid\" src=\"images/shirt-img.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 8152, "\"", 8158, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        <a class=""btn hvr-hover"" href=""#"">Shirt</a>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                    <div class=""shop-cat-box"">
                        <img class=""img-fluid"" src=""images/wallet-img.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 8476, "\"", 8482, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <a class=\"btn hvr-hover\" href=\"#\">Wallet</a>\r\n                    </div>\r\n                    <div class=\"shop-cat-box\">\r\n                        <img class=\"img-fluid\" src=\"images/women-bag-img.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 8711, "\"", 8717, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        <a class=""btn hvr-hover"" href=""#"">Bags</a>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                    <div class=""shop-cat-box"">
                        <img class=""img-fluid"" src=""images/shoes-img.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 9033, "\"", 9039, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <a class=\"btn hvr-hover\" href=\"#\">Shoes</a>\r\n                    </div>\r\n                    <div class=\"shop-cat-box\">\r\n                        <img class=\"img-fluid\" src=\"images/women-shoes-img.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 9269, "\"", 9275, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <a class=\"btn hvr-hover\" href=\"#\">Women Shoes</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- End Categories -->\r\n    <!-- Start Products  -->\r\n    ");
#nullable restore
#line 213 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- End Products  -->
    <!-- Start Blog  -->
    <div class=""latest-blog"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""title-all text-center"">
                        <h1>latest blog</h1>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet lacus enim.</p>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6 col-lg-4 col-xl-4"">
                    <div class=""blog-box"">
                        <div class=""blog-img"">
                            <img class=""img-fluid"" src=""images/blog-img.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 10270, "\"", 10276, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                        <div class=""blog-content"">
                            <div class=""title-blog"">
                                <h3>Fusce in augue non nisi fringilla</h3>
                                <p>Nulla ut urna egestas, porta libero id, suscipit orci. Quisque in lectus sit amet urna dignissim feugiat. Mauris molestie egestas pharetra. Ut finibus cursus nunc sed mollis. Praesent laoreet lacinia elit id lobortis.</p>
                            </div>
                            <ul class=""option-blog"">
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Likes""><i class=""far fa-heart""></i></a></li>
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Views""><i class=""fas fa-eye""></i></a></li>
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Comments""><i class=""far fa-comments""></i></a></li>
               ");
                WriteLiteral(@"             </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-4 col-xl-4"">
                    <div class=""blog-box"">
                        <div class=""blog-img"">
                            <img class=""img-fluid"" src=""images/blog-img-01.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 11634, "\"", 11640, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                        <div class=""blog-content"">
                            <div class=""title-blog"">
                                <h3>Fusce in augue non nisi fringilla</h3>
                                <p>Nulla ut urna egestas, porta libero id, suscipit orci. Quisque in lectus sit amet urna dignissim feugiat. Mauris molestie egestas pharetra. Ut finibus cursus nunc sed mollis. Praesent laoreet lacinia elit id lobortis.</p>
                            </div>
                            <ul class=""option-blog"">
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Likes""><i class=""far fa-heart""></i></a></li>
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Views""><i class=""fas fa-eye""></i></a></li>
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Comments""><i class=""far fa-comments""></i></a></li>
               ");
                WriteLiteral(@"             </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-4 col-xl-4"">
                    <div class=""blog-box"">
                        <div class=""blog-img"">
                            <img class=""img-fluid"" src=""images/blog-img-02.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 12998, "\"", 13004, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                        <div class=""blog-content"">
                            <div class=""title-blog"">
                                <h3>Fusce in augue non nisi fringilla</h3>
                                <p>Nulla ut urna egestas, porta libero id, suscipit orci. Quisque in lectus sit amet urna dignissim feugiat. Mauris molestie egestas pharetra. Ut finibus cursus nunc sed mollis. Praesent laoreet lacinia elit id lobortis.</p>
                            </div>
                            <ul class=""option-blog"">
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Likes""><i class=""far fa-heart""></i></a></li>
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Views""><i class=""fas fa-eye""></i></a></li>
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Comments""><i class=""far fa-comments""></i></a></li>
               ");
                WriteLiteral(@"             </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- End Blog  -->
    <!-- Start Instagram Feed  -->
    <!-- End Instagram Feed  -->
    <!-- Start Footer  -->
    <footer>
        <div class=""footer-main"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-4 col-md-12 col-sm-12"">
                        <div class=""footer-widget"">
                            <h4>About ThewayShop</h4>
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                            </p>
                            <ul>
                                <li><a href=""#""><i class=""fab fa-facebook"" aria-hidden=""tru");
                WriteLiteral(@"e""></i></a></li>
                                <li><a href=""#""><i class=""fab fa-twitter"" aria-hidden=""true""></i></a></li>
                                <li><a href=""#""><i class=""fab fa-linkedin"" aria-hidden=""true""></i></a></li>
                                <li><a href=""#""><i class=""fab fa-google-plus"" aria-hidden=""true""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-rss"" aria-hidden=""true""></i></a></li>
                                <li><a href=""#""><i class=""fab fa-pinterest-p"" aria-hidden=""true""></i></a></li>
                                <li><a href=""#""><i class=""fab fa-whatsapp"" aria-hidden=""true""></i></a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-12 col-sm-12"">
                        <div class=""footer-link"">
                            <h4>Information</h4>
                            <ul>
                                <li><a href=""#"">About Us</a");
                WriteLiteral(@"></li>
                                <li><a href=""#"">Customer Service</a></li>
                                <li><a href=""#"">Our Sitemap</a></li>
                                <li><a href=""#"">Terms &amp; Conditions</a></li>
                                <li><a href=""#"">Privacy Policy</a></li>
                                <li><a href=""#"">Delivery Information</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-12 col-sm-12"">
                        <div class=""footer-link-contact"">
                            <h4>Contact Us</h4>
                            <ul>
                                <li>
                                    <p><i class=""fas fa-map-marker-alt""></i>Address: Michael I. Days 3756 <br>Preston Street Wichita,<br> KS 67213 </p>
                                </li>
                                <li>
                                    <p><i class=""fas fa-phone-square""");
                WriteLiteral(@"></i>Phone: <a href=""tel:+1-888705770"">+1-888 705 770</a></p>
                                </li>
                                <li>
                                    <p><i class=""fas fa-envelope""></i>Email: <a href=""mailto:contactinfo@gmail.com"">contactinfo@gmail.com</a></p>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!-- End Footer  -->
    <!-- Start copyright  -->
    <div class=""footer-copyright"">
        <p class=""footer-company"">
            All Rights Reserved. &copy; 2018 <a href=""#"">ThewayShop</a> Design By :
            <a href=""https://html.design/"">html design</a>
        </p>
    </div>
    <!-- End copyright  -->

    <a href=""#"" id=""back-to-top"" title=""Back to top"" style=""display: none;"">&uarr;</a>

    <!-- ALL JS FILES -->
    <script src=""js/jquery-3.2.1.min.js""></script>
    <script src=""js/popper.m");
                WriteLiteral(@"in.js""></script>
    <script src=""js/bootstrap.min.js""></script>
    <!-- ALL PLUGINS -->
    <script src=""js/jquery.superslides.min.js""></script>
    <script src=""js/bootstrap-select.js""></script>
    <script src=""js/inewsticker.js""></script>
    <script src=""js/bootsnav.js.""></script>
    <script src=""js/images-loded.min.js""></script>
    <script src=""js/isotope.min.js""></script>
    <script src=""js/owl.carousel.min.js""></script>
    <script src=""js/baguetteBox.min.js""></script>
    <script src=""js/form-validator.min.js""></script>
    <script src=""js/contact-form-script.js""></script>
    <script src=""js/custom.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
