#pragma checksum "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05078c6403e4b458ec6b168a3a3fd04acb88a1cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetBook), @"mvc.1.0.view", @"/Views/Book/GetBook.cshtml")]
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
#line 1 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/_ViewImports.cshtml"
using Webgentle.BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05078c6403e4b458ec6b168a3a3fd04acb88a1cc", @"/Views/Book/GetBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b25ceacd2a64fc4bb70010f5bc3619280a68329", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Book_GetBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
  
    ViewData["Title"] = "Book detail " + Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""container"">
        <h3 class=""display-4"">Book details</h3>
        <div class=""row"">
            <div class=""col-md-6"">
                <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                    <ol class=""carousel-indicators"">

");
#nullable restore
#line 14 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
                         for (int i = 0; i < Model.Gallery.Count(); i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 16 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 571, "\"", 603, 2);
#nullable restore
#line 16 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
WriteAttributeValue("", 579, i==0 ? "active" : "", 579, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 602, "", 603, 1, true);
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 17 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ol>\r\n                    <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 20 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
                         for (int i = 0; i < Model.Gallery.Count(); i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 849, "\"", 908, 2);
#nullable restore
#line 22 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
WriteAttributeValue("", 857, i==0 ? "carousel-item active" : "carousel-item", 857, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 907, "", 908, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 970, "\"", 997, 1);
#nullable restore
#line 23 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
WriteAttributeValue("", 976, Model.Gallery[i].URL, 976, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 998, "\"", 1026, 1);
#nullable restore
#line 23 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
WriteAttributeValue("", 1004, Model.Gallery[i].Name, 1004, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n");
#nullable restore
#line 25 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <h1>");
#nullable restore
#line 41 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-md-12 text-primary"">
                        <span class=""label label-primary"">By: </span>
                        <span class=""monospaced"">");
#nullable restore
#line 48 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
                                            Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n                        <p class=\"description\">\r\n                            ");
#nullable restore
#line 55 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-md-4"">
                        <a class=""btn btn-outline-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
                            Read now
                        </a>
                    </div>
                </div>

                <hr />

                <ul class=""list-group"">
                    <li class=""list-group-item""><span class=""font-weight-bold"">Category - </span> ");
#nullable restore
#line 71 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
                                                                                             Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\"><span class=\"font-weight-bold\">Total pages - </span> ");
#nullable restore
#line 72 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
                                                                                                Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\"><span class=\"font-weight-bold\">Language - </span> ");
#nullable restore
#line 73 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
                                                                                             Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                </ul>
            </div>
        </div>

        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog modal-lg"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
");
            WriteLiteral("                        <iframe");
            BeginWriteAttribute("src", " src=\"", 4018, "\"", 4041, 1);
#nullable restore
#line 88 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
WriteAttributeValue("", 4024, Model.BookPdfUrl, 4024, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""w-100""></iframe>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
        </div>

        <hr />

        <div class=""py-5 bg-light"" id=""similarBooks"">
            <h3 class=""h3"">Similar books</h3>
            <div class=""row"">
");
#nullable restore
#line 102 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
                 for (int i = 0; i < 5; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-4"">
                        <div class=""card mb-4 shadow-sm"">
                            <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img"" aria-label=""Placeholder: Thumbnail""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""></rect><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
                            <div class=""card-body"">
                                <h3 class=""card-title"">book.Title</h3>
                                <p class=""card-text"">book.Description</p>
                                <div class=""d-flex justify-content-between align-items-center"">
                                    <div class=""btn-group"">
                                        <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View details</a>
                                    </div>
                    ");
            WriteLiteral("                <small class=\"text-muted\">book.Author</small>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 119 "/home/phong/Desktop/aspnet-core-mvc-master/Webgentle.BookStore/Webgentle.BookStore/Views/Book/GetBook.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
