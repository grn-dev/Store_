#pragma checksum "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Payment\PaymentCompelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a126d993c971f4f15d3b083e1c07098de7815f4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_PaymentCompelete), @"mvc.1.0.view", @"/Views/Payment/PaymentCompelete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a126d993c971f4f15d3b083e1c07098de7815f4c", @"/Views/Payment/PaymentCompelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"062286973dfc7c644e884ed73ff7051c8d0aaa02", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_PaymentCompelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Core.Domian.VerifyPayemtnResult>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Payment\PaymentCompelete.cshtml"
  
    ViewData["Title"] = "تایید پرداخت";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <h2>پرداخت شما با موفقیت انجام شد</h2>\r\n    <p>کد رهگیری  ");
#nullable restore
#line 7 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Payment\PaymentCompelete.cshtml"
             Write(Model.transId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Core.Domian.VerifyPayemtnResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
