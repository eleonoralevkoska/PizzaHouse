#pragma checksum "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Ingredient\ListAllIngredients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba52099e65139e648d42cdb108fff2c31bcebbea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredient_ListAllIngredients), @"mvc.1.0.view", @"/Views/Ingredient/ListAllIngredients.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ingredient/ListAllIngredients.cshtml", typeof(AspNetCore.Views_Ingredient_ListAllIngredients))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba52099e65139e648d42cdb108fff2c31bcebbea", @"/Views/Ingredient/ListAllIngredients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7dbc7aa5438d375889a2f7bc1a200d6530a77b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ingredient_ListAllIngredients : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ViewModels.IngredientViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Ingredient\ListAllIngredients.cshtml"
  
    ViewData["Title"] = "All Ingredients";

#line default
#line hidden
            BeginContext(92, 36, true);
            WriteLiteral("\n<h2>ListAllIngredients</h2>\n\n<ul>\n\n");
            EndContext();
#line 10 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Ingredient\ListAllIngredients.cshtml"
     foreach (var ingredient in Model)
    {

#line default
#line hidden
            BeginContext(173, 25, true);
            WriteLiteral("        <li>\n            ");
            EndContext();
            BeginContext(199, 15, false);
#line 13 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Ingredient\ListAllIngredients.cshtml"
       Write(ingredient.Name);

#line default
#line hidden
            EndContext();
            BeginContext(214, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 14 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Ingredient\ListAllIngredients.cshtml"
             if (ingredient.Allergens.Any())
            {

#line default
#line hidden
            BeginContext(274, 42, true);
            WriteLiteral("                <span>[Allergens: </span>\n");
            EndContext();
#line 17 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Ingredient\ListAllIngredients.cshtml"
                foreach (var allergen in ingredient.Allergens)
                {
                    

#line default
#line hidden
            BeginContext(418, 8, false);
#line 19 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Ingredient\ListAllIngredients.cshtml"
               Write(allergen);

#line default
#line hidden
            EndContext();
#line 19 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Ingredient\ListAllIngredients.cshtml"
                             
                }

#line default
#line hidden
            BeginContext(445, 31, true);
            WriteLiteral("                <span>]</span>\n");
            EndContext();
#line 22 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Ingredient\ListAllIngredients.cshtml"
            }

#line default
#line hidden
            BeginContext(490, 14, true);
            WriteLiteral("        </li>\n");
            EndContext();
#line 24 "C:\Users\ELEONORA\Desktop\PizzaHouse\PizzaHouse\Views\Ingredient\ListAllIngredients.cshtml"

    }

#line default
#line hidden
            BeginContext(511, 9, true);
            WriteLiteral("\n\n</ul>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ViewModels.IngredientViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591