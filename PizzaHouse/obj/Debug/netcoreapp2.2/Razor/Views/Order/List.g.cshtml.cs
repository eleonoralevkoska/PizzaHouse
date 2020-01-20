#pragma checksum "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Order\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8f3b68478f9c848eb2b3f80bca7af98c1f8e093"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_List), @"mvc.1.0.view", @"/Views/Order/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/List.cshtml", typeof(AspNetCore.Views_Order_List))]
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
#line 1 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\_ViewImports.cshtml"
using PizzaHouse;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8f3b68478f9c848eb2b3f80bca7af98c1f8e093", @"/Views/Order/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7dbc7aa5438d375889a2f7bc1a200d6530a77b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ViewModels.OrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Order\List.cshtml"
  
    ViewData["Title"] = "All Orders";

#line default
#line hidden
            BeginContext(82, 214, true);
            WriteLiteral("\n<h2>All orders</h2>\n\n<table class=\"table table-striped\">\n    <thead>\n        <tr>\n            <th>Order No.</th>\n            <th>User</th>\n            <th>Order Details</th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 17 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Order\List.cshtml"
         foreach (var order in Model)
        {

#line default
#line hidden
            BeginContext(344, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(382, 8, false);
#line 20 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Order\List.cshtml"
               Write(order.Id);

#line default
#line hidden
            EndContext();
            BeginContext(390, 47, true);
            WriteLiteral("</td>\n                <td>\n                    ");
            EndContext();
            BeginContext(438, 11, false);
#line 22 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Order\List.cshtml"
               Write(order.Email);

#line default
#line hidden
            EndContext();
            BeginContext(449, 44, true);
            WriteLiteral(" - <i class=\"glyphicon glyphicon-home\"></i> ");
            EndContext();
            BeginContext(494, 13, false);
#line 22 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Order\List.cshtml"
                                                                       Write(order.Address);

#line default
#line hidden
            EndContext();
            BeginContext(507, 46, true);
            WriteLiteral(" <i class=\"glyphicon glyphicon-earphone\"></i> ");
            EndContext();
            BeginContext(554, 11, false);
#line 22 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Order\List.cshtml"
                                                                                                                                   Write(order.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(565, 69, true);
            WriteLiteral("\n                </td>\n                <td>\n                    <ol>\n");
            EndContext();
#line 26 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Order\List.cshtml"
                         foreach (var item in order.OrderItems)
                        {

#line default
#line hidden
            BeginContext(724, 32, true);
            WriteLiteral("                            <li>");
            EndContext();
            BeginContext(757, 15, false);
#line 28 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Order\List.cshtml"
                           Write(item.Pizza.Name);

#line default
#line hidden
            EndContext();
            BeginContext(772, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(775, 20, false);
#line 28 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Order\List.cshtml"
                                             Write(item.Size.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(795, 4, true);
            WriteLiteral(") X ");
            EndContext();
            BeginContext(800, 13, false);
#line 28 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Order\List.cshtml"
                                                                      Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(813, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 29 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Order\List.cshtml"
                        }

#line default
#line hidden
            BeginContext(845, 66, true);
            WriteLiteral("                    </ol>\n                </td>\n            </tr>\n");
            EndContext();
#line 33 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Order\List.cshtml"
        }

#line default
#line hidden
            BeginContext(921, 23, true);
            WriteLiteral("    </tbody>\n</table>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ViewModels.OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591