#pragma checksum "C:\Users\Miskimovski\OneDrive\Desktop\MVC Homeworks\SEDC.PizzaApp\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee0e12347d5ebcd40e28fc0225b829e73c1f98c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
#line 1 "C:\Users\Miskimovski\OneDrive\Desktop\MVC Homeworks\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Miskimovski\OneDrive\Desktop\MVC Homeworks\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Miskimovski\OneDrive\Desktop\MVC Homeworks\SEDC.PizzaApp\Views\Order\Details.cshtml"
using SEDC.PizzaApp.Models.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Miskimovski\OneDrive\Desktop\MVC Homeworks\SEDC.PizzaApp\Views\Order\Details.cshtml"
using SEDC.PizzaApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee0e12347d5ebcd40e28fc0225b829e73c1f98c4", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9da3483405b0ddc092d1e77dd5d8a02d663a044", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Order details:</h2>\r\n<h4>");
#nullable restore
#line 6 "C:\Users\Miskimovski\OneDrive\Desktop\MVC Homeworks\SEDC.PizzaApp\Views\Order\Details.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n<p>Pizza name: ");
#nullable restore
#line 8 "C:\Users\Miskimovski\OneDrive\Desktop\MVC Homeworks\SEDC.PizzaApp\Views\Order\Details.cshtml"
          Write(Model.PizzaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>User: ");
#nullable restore
#line 9 "C:\Users\Miskimovski\OneDrive\Desktop\MVC Homeworks\SEDC.PizzaApp\Views\Order\Details.cshtml"
    Write(Model.UserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Payment method: ");
#nullable restore
#line 10 "C:\Users\Miskimovski\OneDrive\Desktop\MVC Homeworks\SEDC.PizzaApp\Views\Order\Details.cshtml"
              Write(Model.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Order price: ");
#nullable restore
#line 11 "C:\Users\Miskimovski\OneDrive\Desktop\MVC Homeworks\SEDC.PizzaApp\Views\Order\Details.cshtml"
           Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" DEN </p>\r\n\r\n<h4>The first user in our app is: ");
#nullable restore
#line 13 "C:\Users\Miskimovski\OneDrive\Desktop\MVC Homeworks\SEDC.PizzaApp\Views\Order\Details.cshtml"
                             Write(ViewBag.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591