#pragma checksum "C:\Users\Charlie\Desktop\Development Studies\ASP\ASP.NET Core Fundamentals\OdeToFood\OdeToFood\Pages\Restaurants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0200a9b772e0cda45cf112d60630296da6354c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Pages_Restaurants), @"mvc.1.0.razor-page", @"/Pages/Restaurants.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants.cshtml", typeof(OdeToFood.Pages.Pages_Restaurants), null)]
namespace OdeToFood.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Charlie\Desktop\Development Studies\ASP\ASP.NET Core Fundamentals\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0200a9b772e0cda45cf112d60630296da6354c0", @"/Pages/Restaurants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0820fb6dbe507f6ce740cdfd07cdc5236e4275df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Charlie\Desktop\Development Studies\ASP\ASP.NET Core Fundamentals\OdeToFood\OdeToFood\Pages\Restaurants.cshtml"
  
    ViewData["Title"] = "Restaurants";

#line default
#line hidden
            BeginContext(95, 29, true);
            WriteLiteral("\r\n<h2>Restaurants</h2>\r\n\r\n<p>");
            EndContext();
            BeginContext(125, 13, false);
#line 9 "C:\Users\Charlie\Desktop\Development Studies\ASP\ASP.NET Core Fundamentals\OdeToFood\OdeToFood\Pages\Restaurants.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(138, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(148, 14, false);
#line 10 "C:\Users\Charlie\Desktop\Development Studies\ASP\ASP.NET Core Fundamentals\OdeToFood\OdeToFood\Pages\Restaurants.cshtml"
Write(Model.Message2);

#line default
#line hidden
            EndContext();
            BeginContext(162, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
            BeginContext(170, 433, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "610c594645c4493991ad5f544fa1248f", async() => {
                BeginContext(189, 407, true);
                WriteLiteral(@"
    <div class=""form-group"">
        <div class=""input-group"">
            <input type=""search"" class=""form-control"" value=""""
                   name=""searchTerm""/>
            <span class=""input-group-btn"">
                <button class=""btn btn-default"">
                    <i class=""glyphicon glyphicon-search""></i>
                </button>
            </span>
        </div>

    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(603, 31, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<table class=\"table\">\r\n");
            EndContext();
#line 30 "C:\Users\Charlie\Desktop\Development Studies\ASP\ASP.NET Core Fundamentals\OdeToFood\OdeToFood\Pages\Restaurants.cshtml"
     foreach(var restaurant in Model.Restaurants)
    {

#line default
#line hidden
            BeginContext(692, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(723, 15, false);
#line 33 "C:\Users\Charlie\Desktop\Development Studies\ASP\ASP.NET Core Fundamentals\OdeToFood\OdeToFood\Pages\Restaurants.cshtml"
           Write(restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(738, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(762, 18, false);
#line 34 "C:\Users\Charlie\Desktop\Development Studies\ASP\ASP.NET Core Fundamentals\OdeToFood\OdeToFood\Pages\Restaurants.cshtml"
           Write(restaurant.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(780, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(804, 19, false);
#line 35 "C:\Users\Charlie\Desktop\Development Studies\ASP\ASP.NET Core Fundamentals\OdeToFood\OdeToFood\Pages\Restaurants.cshtml"
           Write(restaurant.Location);

#line default
#line hidden
            EndContext();
            BeginContext(823, 36, true);
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Charlie\Desktop\Development Studies\ASP\ASP.NET Core Fundamentals\OdeToFood\OdeToFood\Pages\Restaurants.cshtml"
     
    }

#line default
#line hidden
            BeginContext(873, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.RestaurantsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.RestaurantsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.RestaurantsModel>)PageContext?.ViewData;
        public OdeToFood.Pages.RestaurantsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
