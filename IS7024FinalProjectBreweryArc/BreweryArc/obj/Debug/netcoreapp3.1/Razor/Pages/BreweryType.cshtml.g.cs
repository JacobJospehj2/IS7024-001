#pragma checksum "C:\Users\jicks\OneDrive\Desktop\IS7024Final\IS7024-001\IS7024FinalProjectBreweryArc\BreweryArc\Pages\BreweryType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a65d95126a75deb959999e765b274c019735ae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BreweryArc.Pages.Pages_BreweryType), @"mvc.1.0.razor-page", @"/Pages/BreweryType.cshtml")]
namespace BreweryArc.Pages
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
#line 1 "C:\Users\jicks\OneDrive\Desktop\IS7024Final\IS7024-001\IS7024FinalProjectBreweryArc\BreweryArc\Pages\_ViewImports.cshtml"
using BreweryArc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a65d95126a75deb959999e765b274c019735ae0", @"/Pages/BreweryType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2bfcb3baa9d9b62da9bb8c54c2eac9ef25384e8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BreweryType : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "query", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row mb-3 ml-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\jicks\OneDrive\Desktop\IS7024Final\IS7024-001\IS7024FinalProjectBreweryArc\BreweryArc\Pages\BreweryType.cshtml"
  
    Breweries.BreweryCollection type = (Breweries.BreweryCollection)ViewData["Brewery_Type"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <br />\r\n    <h2>Types of Brewery</h2>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a65d95126a75deb959999e765b274c019735ae04944", async() => {
                WriteLiteral("\r\n            <div class=\"input-group row\">\r\n                <div class=\"col-sm-2 font-weight-bold\">Choose Type of Brewery</div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a65d95126a75deb959999e765b274c019735ae05354", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 15 "C:\Users\jicks\OneDrive\Desktop\IS7024Final\IS7024-001\IS7024FinalProjectBreweryArc\BreweryArc\Pages\BreweryType.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ViewData);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "C:\Users\jicks\OneDrive\Desktop\IS7024Final\IS7024-001\IS7024FinalProjectBreweryArc\BreweryArc\Pages\BreweryType.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Type;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"input-group-append\">\r\n                    <input type=\"submit\" value=\"Search\" class=\"btn btn-outline-secondary\" />\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
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
#nullable restore
#line 21 "C:\Users\jicks\OneDrive\Desktop\IS7024Final\IS7024-001\IS7024FinalProjectBreweryArc\BreweryArc\Pages\BreweryType.cshtml"
         if (string.IsNullOrWhiteSpace(Model.Type))
        {

        }
        else if (type == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-info\">Brewery Data for ");
#nullable restore
#line 27 "C:\Users\jicks\OneDrive\Desktop\IS7024Final\IS7024-001\IS7024FinalProjectBreweryArc\BreweryArc\Pages\BreweryType.cshtml"
                                                      Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" not found.</div>\r\n");
#nullable restore
#line 28 "C:\Users\jicks\OneDrive\Desktop\IS7024Final\IS7024-001\IS7024FinalProjectBreweryArc\BreweryArc\Pages\BreweryType.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""card card-body shadow border-0"" style=""background-color: orange"">
                        <div class=""subtitle lead"">
                            CUMULATIVE
                        </div>
                        <hr />
                        <dl class=""row"">
                            <dt class=""col-sm-6"">
                                Brewery Name
                            </dt>
                            <dd class=""col-sm-6"">
                                ");
#nullable restore
#line 43 "C:\Users\jicks\OneDrive\Desktop\IS7024Final\IS7024-001\IS7024FinalProjectBreweryArc\BreweryArc\Pages\BreweryType.cshtml"
                           Write(type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-6\">\r\n                                Type\r\n                            </dt>\r\n                            <dd class=\"col-sm-6\">\r\n                                ");
#nullable restore
#line 49 "C:\Users\jicks\OneDrive\Desktop\IS7024Final\IS7024-001\IS7024FinalProjectBreweryArc\BreweryArc\Pages\BreweryType.cshtml"
                           Write(type.BreweryType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-6\">\r\n                                City\r\n                            </dt>\r\n                            <dd class=\"col-sm-6\">\r\n                                ");
#nullable restore
#line 55 "C:\Users\jicks\OneDrive\Desktop\IS7024Final\IS7024-001\IS7024FinalProjectBreweryArc\BreweryArc\Pages\BreweryType.cshtml"
                           Write(type.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-6\">\r\n                                Country\r\n                            </dt>\r\n                            <dd class=\"col-sm-6\">\r\n                                ");
#nullable restore
#line 61 "C:\Users\jicks\OneDrive\Desktop\IS7024Final\IS7024-001\IS7024FinalProjectBreweryArc\BreweryArc\Pages\BreweryType.cshtml"
                           Write(type.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n\r\n                        </dl>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 68 "C:\Users\jicks\OneDrive\Desktop\IS7024Final\IS7024-001\IS7024FinalProjectBreweryArc\BreweryArc\Pages\BreweryType.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BreweryType.Pages.BreweriesType> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BreweryType.Pages.BreweriesType> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BreweryType.Pages.BreweriesType>)PageContext?.ViewData;
        public BreweryType.Pages.BreweriesType Model => ViewData.Model;
    }
}
#pragma warning restore 1591