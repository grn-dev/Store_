#pragma checksum "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Prouduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1c635e55d0c0287f798200a18f7562f19e3b73f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prouduct_Index), @"mvc.1.0.view", @"/Views/Prouduct/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1c635e55d0c0287f798200a18f7562f19e3b73f", @"/Views/Prouduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55cf01ace999318ace9b2285b942adf0cd439e47", @"/Views/_ViewImports.cshtml")]
    public class Views_Prouduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Prouduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"products-box\">\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row special-list\">\r\n\r\n");
#nullable restore
#line 8 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Prouduct\Index.cshtml"
             foreach (var item in Model.Products)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-3 col-md-6 special-grid best-seller"">
                    <div class=""products-single fix"">
                        <div class=""box-img-hover"">
                            <div class=""type-lb"">
                                <p class=""sale"">Sale</p>
                            </div>
                            <img");
            BeginWriteAttribute("src", " src=", 560, "", 576, 1);
#nullable restore
#line 17 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Prouduct\Index.cshtml"
WriteAttributeValue("", 565, item.Image, 565, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"" alt=""Image"">
                            <div class=""mask-icon"">
                                <ul>
                                    <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""View""><i class=""fas fa-eye""></i></a></li>
                                    <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Compare""><i class=""fas fa-sync-alt""></i></a></li>
                                    <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Add to Wishlist""><i class=""far fa-heart""></i></a></li>
                                </ul>
                                <a class=""cart"" href=""#"">Add to Cart</a>
                            </div>
                        </div>
                        <div class=""why-text"">
                            <h4>");
#nullable restore
#line 28 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Prouduct\Index.cshtml"
                           Write(item.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <h4>");
#nullable restore
#line 29 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Prouduct\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <h5>");
#nullable restore
#line 30 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Prouduct\Index.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ریال</h5>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 34 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Prouduct\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n        <div>\r\n");
#nullable restore
#line 52 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Prouduct\Index.cshtml"
             for (int gopagei = 1; gopagei <= Model.PagingInfo.TotalPages; gopagei++)
            {
                var classname = gopagei == Model.PagingInfo.CurrentPage ? "btn-primary" : "btn-secondary";

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1c635e55d0c0287f798200a18f7562f19e3b73f7546", async() => {
                WriteLiteral(" ");
#nullable restore
#line 55 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Prouduct\Index.cshtml"
                                                                                                           Write(gopagei);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pn", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Prouduct\Index.cshtml"
                                                                  WriteLiteral(gopagei);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pn"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pn", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pn"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2317, "btn", 2317, 3, true);
#nullable restore
#line 55 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Prouduct\Index.cshtml"
AddHtmlAttributeValue(" ", 2320, classname, 2321, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 56 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Prouduct\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n");
            WriteLiteral("\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
