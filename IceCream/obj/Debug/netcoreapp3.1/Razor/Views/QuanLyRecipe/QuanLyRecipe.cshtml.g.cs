#pragma checksum "C:\Users\asus\OneDrive\Máy tính\Ice Cream\IceCream\Views\QuanLyRecipe\QuanLyRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f62f2ade1da6abc7c98865b60932b688a62375d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanLyRecipe_QuanLyRecipe), @"mvc.1.0.view", @"/Views/QuanLyRecipe/QuanLyRecipe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f62f2ade1da6abc7c98865b60932b688a62375d3", @"/Views/QuanLyRecipe/QuanLyRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Views_QuanLyRecipe_QuanLyRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Máy tính\Ice Cream\IceCream\Views\QuanLyRecipe\QuanLyRecipe.cshtml"
  
    ViewData["Title"] = "QuanLyRecipe";
    Layout = "~/Views/SharedAdmin/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""page-wrapper"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h1 class=""page-header"">Tables</h1>
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                         QuanLyRecipe

                    </div>
                    <!-- /.panel-heading -->
                    <div class=""panel-body"">
                        <div class=""table-responsive"">
                            <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                                <thead>
                                    <tr>
                                        <th>ForId</th>
                                        <th>ForCover</th>
                                        <th>ForName</th>
                      ");
            WriteLiteral(@"                  <th>ForDescription</th>
                                        <th>ForContributors</th>
                                        <th>ForCondition</th>
                                        <th>ForStatus</th>
                                        <th>ForCreated</th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 40 "C:\Users\asus\OneDrive\Máy tính\Ice Cream\IceCream\Views\QuanLyRecipe\QuanLyRecipe.cshtml"
                                     foreach (var fomula in ViewBag.fomula)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"odd gradeX\">\r\n                                            <td>");
#nullable restore
#line 43 "C:\Users\asus\OneDrive\Máy tính\Ice Cream\IceCream\Views\QuanLyRecipe\QuanLyRecipe.cshtml"
                                           Write(fomula.ForId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f62f2ade1da6abc7c98865b60932b688a62375d36431", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1909, "~/img/recipe/", 1909, 13, true);
#nullable restore
#line 45 "C:\Users\asus\OneDrive\Máy tính\Ice Cream\IceCream\Views\QuanLyRecipe\QuanLyRecipe.cshtml"
AddHtmlAttributeValue("", 1922, fomula.ForCover, 1922, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>");
#nullable restore
#line 47 "C:\Users\asus\OneDrive\Máy tính\Ice Cream\IceCream\Views\QuanLyRecipe\QuanLyRecipe.cshtml"
                                           Write(fomula.ForName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 48 "C:\Users\asus\OneDrive\Máy tính\Ice Cream\IceCream\Views\QuanLyRecipe\QuanLyRecipe.cshtml"
                                           Write(fomula.ForDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 49 "C:\Users\asus\OneDrive\Máy tính\Ice Cream\IceCream\Views\QuanLyRecipe\QuanLyRecipe.cshtml"
                                           Write(fomula.ForContributors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 50 "C:\Users\asus\OneDrive\Máy tính\Ice Cream\IceCream\Views\QuanLyRecipe\QuanLyRecipe.cshtml"
                                           Write(fomula.ForCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 51 "C:\Users\asus\OneDrive\Máy tính\Ice Cream\IceCream\Views\QuanLyRecipe\QuanLyRecipe.cshtml"
                                           Write(fomula.ForStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"center\">");
#nullable restore
#line 52 "C:\Users\asus\OneDrive\Máy tính\Ice Cream\IceCream\Views\QuanLyRecipe\QuanLyRecipe.cshtml"
                                                          Write(fomula.ForCreated.ToString(string.Format("dd/MM/yyyy")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\asus\OneDrive\Máy tính\Ice Cream\IceCream\Views\QuanLyRecipe\QuanLyRecipe.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                        <!-- /.table-responsive -->

                    </div>
                    <!-- /.panel-body -->
                </div>
                <!-- /.panel -->
            </div>
            <!-- /.col-lg-12 -->
        </div>

        </div>
    </div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
