#pragma checksum "C:\Users\asus\OneDrive\Máy tính\IceCream\IceCream\Views\Book\AllBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed69d127a98267d983508438e7990f56cf9cac12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_AllBook), @"mvc.1.0.view", @"/Views/Book/AllBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed69d127a98267d983508438e7990f56cf9cac12", @"/Views/Book/AllBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Views_Book_AllBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IceCream.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("360"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "bookdetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-btn btn-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Máy tính\IceCream\IceCream\Views\Book\AllBook.cshtml"
  
    ViewData["Title"] = "AllBook";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""banner_area"">
    <div class=""container"">
        <div class=""banner_text"">
            <br />
            <br />
            <h3>Our Book</h3>
            <ul>
                <li><a href=""index.html"">Home</a></li>
                <li><a href=""cakes.html"">Order book</a></li>
            </ul>
        </div>
    </div>
</section>
<!--================End Main Header Area =================-->
<!--================Blog Main Area =================-->
<section class=""our_cakes_area p_100"">
    <div class=""container"">
        <div class=""main_title"">
            <h2>Our Book</h2>
            <h5>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</h5>
        </div>
        <div class=""cake_feature_row row"">
");
#nullable restore
#line 29 "C:\Users\asus\OneDrive\Máy tính\IceCream\IceCream\Views\Book\AllBook.cshtml"
             foreach (var book in ViewBag.books)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-md-4 col-6\">\r\n                    <div class=\"cake_feature_item\">\r\n                        <div class=\"cake_img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ed69d127a98267d983508438e7990f56cf9cac126479", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1293, "~/img/books/", 1293, 12, true);
#nullable restore
#line 34 "C:\Users\asus\OneDrive\Máy tính\IceCream\IceCream\Views\Book\AllBook.cshtml"
AddHtmlAttributeValue("", 1305, book.BookPhoto, 1305, 15, false);

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
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"cake_text\">\r\n                            <br />\r\n                            <p style=\"color: #f52c2c; font-family: Impact, fantasy; font-size: 40px \">$");
#nullable restore
#line 38 "C:\Users\asus\OneDrive\Máy tính\IceCream\IceCream\Views\Book\AllBook.cshtml"
                                                                                                  Write(book.BookPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <h3>");
#nullable restore
#line 39 "C:\Users\asus\OneDrive\Máy tính\IceCream\IceCream\Views\Book\AllBook.cshtml"
                           Write(book.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed69d127a98267d983508438e7990f56cf9cac129067", async() => {
                WriteLiteral("Add cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 44 "C:\Users\asus\OneDrive\Máy tính\IceCream\IceCream\Views\Book\AllBook.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          


        </div>
    </div>
</section>
<!--================End Blog Main Area =================-->
<!--================Special Recipe Area =================-->
<section class=""special_recipe_area"">
    <div class=""container"">
        <div class=""special_recipe_slider owl-carousel"">
            <div class=""item"">
                <div class=""media"">
                    <div class=""d-flex"">
                        <img src=""img/recipe/recipe-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 2340, "\"", 2346, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""media-body"">
                        <h4>Special Recipe</h4>
                        <p>Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi equatur uis autem vel eum.</p>
                        <a class=""w_view_btn"" href=""#"">View Details</a>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""media"">
                    <div class=""d-flex"">
                        <img src=""img/recipe/recipe-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 2966, "\"", 2972, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""media-body"">
                        <h4>Special Recipe</h4>
                        <p>Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi equatur uis autem vel eum.</p>
                        <a class=""w_view_btn"" href=""#"">View Details</a>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""media"">
                    <div class=""d-flex"">
                        <img src=""img/recipe/recipe-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 3592, "\"", 3598, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""media-body"">
                        <h4>Special Recipe</h4>
                        <p>Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi equatur uis autem vel eum.</p>
                        <a class=""w_view_btn"" href=""#"">View Details</a>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""media"">
                    <div class=""d-flex"">
                        <img src=""img/recipe/recipe-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 4218, "\"", 4224, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""media-body"">
                        <h4>Special Recipe</h4>
                        <p>Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi equatur uis autem vel eum.</p>
                        <a class=""w_view_btn"" href=""#"">View Details</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--================End Special Recipe Area =================-->
<!--================Newsletter Area =================-->
<section class=""newsletter_area"">
    <div class=""container"">
        <div class=""row newsletter_inner"">
            <div class=""col-lg-6"">
                <div class=""news_left_text"">
                    <h4>Join our Newsletter list to get all the latest offers, discounts and other benefits</h4>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class");
            WriteLiteral(@"=""newsletter_form"">
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Enter your email address"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-outline-secondary"" type=""button"">Subscribe Now</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--================End Newsletter Area =================-->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IceCream.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
