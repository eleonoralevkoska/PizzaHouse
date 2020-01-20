#pragma checksum "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "561fcd02352347aaf773e8af7cdaed0399c73efa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Details), @"mvc.1.0.view", @"/Views/Pizza/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizza/Details.cshtml", typeof(AspNetCore.Views_Pizza_Details))]
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
#line 1 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"561fcd02352347aaf773e8af7cdaed0399c73efa", @"/Views/Pizza/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7dbc7aa5438d375889a2f7bc1a200d6530a77b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.PizzaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(101, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(107, 10, false);
#line 7 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(117, 10, true);
            WriteLiteral("</h2>\n<h4>");
            EndContext();
            BeginContext(128, 17, false);
#line 8 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(145, 35, true);
            WriteLiteral("</h4>\n<hr/>\n<h3>Ingredients: </h3>\n");
            EndContext();
#line 11 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
 foreach (var ingredient in Model.Ingredients)
{

#line default
#line hidden
            BeginContext(229, 17, true);
            WriteLiteral("    <li>\n        ");
            EndContext();
            BeginContext(247, 15, false);
#line 14 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
   Write(ingredient.Name);

#line default
#line hidden
            EndContext();
            BeginContext(262, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
         if (ingredient.Allergens.Any())
        {

#line default
#line hidden
            BeginContext(314, 38, true);
            WriteLiteral("            <span>[Allergens: </span>\n");
            EndContext();
#line 18 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
            foreach (var allergen in ingredient.Allergens)
            {
                

#line default
#line hidden
            BeginContext(442, 8, false);
#line 20 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
           Write(allergen);

#line default
#line hidden
            EndContext();
            BeginContext(451, 31, true);
            WriteLiteral("                <span>|</span>\n");
            EndContext();
#line 22 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(496, 27, true);
            WriteLiteral("            <span>]</span>\n");
            EndContext();
#line 24 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(533, 10, true);
            WriteLiteral("    </li>\n");
            EndContext();
#line 26 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"

}

#line default
#line hidden
            BeginContext(546, 71, true);
            WriteLiteral("<hr/>\n<h3>Prices: </h3>\n<table class=\"table\">\n    <thead>\n        <tr>\n");
            EndContext();
#line 33 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
              
                foreach (var size in Enum.GetValues(typeof(ViewModels.SizeEnum)).Cast<ViewModels.SizeEnum>().ToList())
                {

#line default
#line hidden
            BeginContext(769, 24, true);
            WriteLiteral("                    <th>");
            EndContext();
            BeginContext(794, 15, false);
#line 36 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
                   Write(size.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(809, 6, true);
            WriteLiteral("</th>\n");
            EndContext();
#line 37 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
                }
            

#line default
#line hidden
            BeginContext(847, 68, true);
            WriteLiteral("        </tr>\n    </thead>\n    <tbody>\n        <tr>\n            <td>");
            EndContext();
            BeginContext(916, 79, false);
#line 43 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
           Write(Model.Prices[ViewModels.SizeEnum.Small].ToString("C", new CultureInfo("mk-Mk")));

#line default
#line hidden
            EndContext();
            BeginContext(995, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1018, 80, false);
#line 44 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
           Write(Model.Prices[ViewModels.SizeEnum.Medium].ToString("C", new CultureInfo("mk-Mk")));

#line default
#line hidden
            EndContext();
            BeginContext(1098, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1121, 79, false);
#line 45 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Pizza\Details.cshtml"
           Write(Model.Prices[ViewModels.SizeEnum.Large].ToString("C", new CultureInfo("mk-Mk")));

#line default
#line hidden
            EndContext();
            BeginContext(1200, 43, true);
            WriteLiteral("</td>\n        </tr>\n    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.PizzaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
