#pragma checksum "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Shared\Components\NavigationMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cdb8c223a137d01c36e0d094d8ab924dd3c7287"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NavigationMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NavigationMenu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cdb8c223a137d01c36e0d094d8ab924dd3c7287", @"/Views/Shared/Components/NavigationMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"062286973dfc7c644e884ed73ff7051c8d0aaa02", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NavigationMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NavigationMenuViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Prouduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-pageNumber", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item className"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<li class=\"dropdown megamenu-fw\">\r\n        <a href=\"#\" class=\"nav-link dropdown-toggle arrow\" data-toggle=\"dropdown\">Product</a>\r\n        <ul class=\"dropdown-menu megamenu-content\" role=\"menu\">\r\n            <li>\r\n                <div class=\"row\">\r\n\r\n");
#nullable restore
#line 9 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Shared\Components\NavigationMenu\Default.cshtml"
                     foreach (var item in Model.Categories)
                    {
                        var className = item.CategoryName == Model.CurentCategory ? "text-danger" : "";


#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdb8c223a137d01c36e0d094d8ab924dd3c72875615", async() => {
#nullable restore
#line 14 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                                                 Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" sub");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                                                WriteLiteral(item.CategoryName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                        <div class=\"col-menu col-md-3\">\r\n");
            WriteLiteral("                            <div class=\"content\">\r\n                                <ul class=\"menu-col\">\r\n                                    <li><a href=\"shop.html\">");
#nullable restore
#line 20 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                    <li><a href=\"shop.html\">");
#nullable restore
#line 21 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                    <li><a href=\"shop.html\">");
#nullable restore
#line 22 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 27 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Shared\Components\NavigationMenu\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    <!-- end col-3 -->\r\n                    <!-- end col-3 -->\r\n                    <!-- end col-3 -->\r\n                </div>\r\n                <!-- end row -->\r\n            </li>\r\n        </ul>\r\n    </li>\r\n\r\n\r\n     ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NavigationMenuViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
