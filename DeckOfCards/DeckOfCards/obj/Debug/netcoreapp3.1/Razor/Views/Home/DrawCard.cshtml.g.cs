#pragma checksum "C:\Users\ngusain\source\repos\DeckOfCards\DeckOfCards\Views\Home\DrawCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ca77e94cdb32a8c3f6fe06572900088f5ea61fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DrawCard), @"mvc.1.0.view", @"/Views/Home/DrawCard.cshtml")]
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
#line 1 "C:\Users\ngusain\source\repos\DeckOfCards\DeckOfCards\Views\_ViewImports.cshtml"
using DeckOfCards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ngusain\source\repos\DeckOfCards\DeckOfCards\Views\_ViewImports.cshtml"
using DeckOfCards.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ca77e94cdb32a8c3f6fe06572900088f5ea61fe", @"/Views/Home/DrawCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55cabaf756ea0be82cbdde0c677683c926f49d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DrawCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DrawCardResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ngusain\source\repos\DeckOfCards\DeckOfCards\Views\Home\DrawCard.cshtml"
  
    ViewData["Title"] = "DrawCard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DrawCard </h1>\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-title\">Deck ");
#nullable restore
#line 9 "C:\Users\ngusain\source\repos\DeckOfCards\DeckOfCards\Views\Home\DrawCard.cshtml"
                            Write(Model.Deck_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 11 "C:\Users\ngusain\source\repos\DeckOfCards\DeckOfCards\Views\Home\DrawCard.cshtml"
         foreach (var item in Model.Cards)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                ");
#nullable restore
#line 14 "C:\Users\ngusain\source\repos\DeckOfCards\DeckOfCards\Views\Home\DrawCard.cshtml"
           Write(item.Suit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "C:\Users\ngusain\source\repos\DeckOfCards\DeckOfCards\Views\Home\DrawCard.cshtml"
           Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 366, "\"", 383, 1);
#nullable restore
#line 18 "C:\Users\ngusain\source\repos\DeckOfCards\DeckOfCards\Views\Home\DrawCard.cshtml"
WriteAttributeValue("", 372, item.Image, 372, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 19 "C:\Users\ngusain\source\repos\DeckOfCards\DeckOfCards\Views\Home\DrawCard.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DrawCardResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
