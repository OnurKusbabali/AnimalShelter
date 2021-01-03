#pragma checksum "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99ab80e87608db6ce4bf9f62074d864bfc16afd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shelters_Index), @"mvc.1.0.razor-page", @"/Pages/Shelters/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99ab80e87608db6ce4bf9f62074d864bfc16afd6", @"/Pages/Shelters/Index.cshtml")]
    public class Pages_Shelters_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/js/inspinia.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/js/plugins/pace/pace.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row wrapper border-bottom white-bg page-heading"">
    <div class=""col-lg-10"">
        <h2>Shelter Create Page</h2>
        <ol class=""breadcrumb"">
            <li>
                <a href=""index.html"">Home</a>
            </li>
            <li>
                <a>Shelters</a>
            </li>
            <li class=""active"">
                <strong>List</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>

<div class=""ibox-content m-b-sm border-bottom"">
    <div class=""row"">
        <div class=""col-sm-4"">
            <div class=""form-group"">
                <label class=""control-label"" for=""product_name"">Product Name</label>
                <input type=""text"" id=""product_name"" name=""product_name""");
            BeginWriteAttribute("value", " value=\"", 901, "\"", 909, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Product Name"" class=""form-control"">
            </div>
        </div>
        <div class=""col-sm-2"">
            <div class=""form-group"">
                <label class=""control-label"" for=""price"">Price</label>
                <input type=""text"" id=""price"" name=""price""");
            BeginWriteAttribute("value", " value=\"", 1197, "\"", 1205, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Price"" class=""form-control"">
            </div>
        </div>
        <div class=""col-sm-2"">
            <div class=""form-group"">
                <label class=""control-label"" for=""quantity"">Quantity</label>
                <input type=""text"" id=""quantity"" name=""quantity""");
            BeginWriteAttribute("value", " value=\"", 1498, "\"", 1506, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Quantity"" class=""form-control"">
            </div>
        </div>
        <div class=""col-sm-4"">
            <div class=""form-group"">
                <label class=""control-label"" for=""status"">Status</label>
                <select name=""status"" id=""status"" class=""form-control"">
                    <option value=""1"" selected>Enabled</option>
                    <option value=""0"">Disabled</option>
                </select>
            </div>
        </div>
    </div>

</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""ibox"">
            <div class=""ibox-content"">
                ");
#nullable restore
#line 64 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <table class=""footable table table-stripped toggle-arrow-tiny"" data-page-size=""15"">
                    <thead>
                        <tr>
                            <th data-toggle=""true"">ID</th>
                            <th data-toggle=""true"">Shelter Name</th>
                            <th data-hide=""phone"">Description</th>
                            <th data-hide=""all"">Image</th>
                            <th data-toggle=""true"">Create Date</th>
                            <th data-toggle=""true"">Status</th>
                            <th class=""text-right"" data-sort-ignore=""true"">Action</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 79 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
                         foreach (var item in Model._shelters)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 83 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 86 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 89 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 3440, "\"", 3460, 1);
#nullable restore
#line 92 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
WriteAttributeValue("", 3446, item.ImageUrl, 3446, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 95 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
                           Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 98 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
                                 if (item.Deleted != true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"label label-primary\">Enable</span>\r\n");
#nullable restore
#line 101 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"label label-danger\">Disabled</span>\r\n");
#nullable restore
#line 105 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n\r\n                            <td class=\"text-right\">\r\n                                <div class=\"btn-group\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4248, "\"", 4280, 2);
            WriteAttributeValue("", 4255, "/Shelters/Detail/", 4255, 17, true);
#nullable restore
#line 110 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
WriteAttributeValue("", 4272, item.Id, 4272, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-white btn btn-xs btn-primary\">Detail</a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4373, "\"", 4403, 2);
            WriteAttributeValue("", 4380, "/Shelters/Edit/", 4380, 15, true);
#nullable restore
#line 111 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
WriteAttributeValue("", 4395, item.Id, 4395, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-white btn btn-xs btn-warning\">Edit</a>\r\n                                    <button data-id=\"");
#nullable restore
#line 112 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
                                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn-white btn btn-xs btn-danger deleteShelter\">Delete</button>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 116 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                    <tfoot>
                        <tr>
                            <td colspan=""6"">
                                <ul class=""pagination pull-right""></ul>
                            </td>
                        </tr>
                    </tfoot>
                </table>

            </div>
        </div>
    </div>
</div>



");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <link href=""css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""font-awesome/css/font-awesome.css"" rel=""stylesheet"">

    <!-- FooTable -->
    <link href=""css/plugins/footable/footable.core.css"" rel=""stylesheet"">

    <link href=""css/animate.css"" rel=""stylesheet"">
    <link href=""css/style.css"" rel=""stylesheet"">
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <!-- Custom and plugin javascript -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ab80e87608db6ce4bf9f62074d864bfc16afd613839", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ab80e87608db6ce4bf9f62074d864bfc16afd614939", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <!-- Mainly scripts -->
  
    <!-- Custom and plugin javascript -->
    <script src=""js/inspinia.js""></script>
    <script src=""js/plugins/pace/pace.min.js""></script>

    <!-- FooTable -->
    <script src=""js/plugins/footable/footable.all.min.js""></script>

    <!-- Page-Level Scripts -->
    <script>
        $(document).ready(function () {

            $('.footable').footable();

        });

    </script>
    <script>
        $(document).ready(function () {
            var token = $(""[name=__RequestVerificationToken]"").val();
            
            $('.deleteShelter').on('click', function () {
                var id = $(this).attr(""data-id"");
                console.log(id);
                
                $.ajax({
                    method: 'POST',
                    url: window.location.href,
                    data: {
                        __RequestVerificationToken: token,
                        id: id
                    },
                    success");
                WriteLiteral(@": function () {
                        $(this).hide();
                        location.reload();
                    },
                    error: function () {
                        alert(""İşlem başarısız"");
                    }
                })
            })
        })

    </script>



");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimalShelterApp.Pages.Shelters.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AnimalShelterApp.Pages.Shelters.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AnimalShelterApp.Pages.Shelters.IndexModel>)PageContext?.ViewData;
        public AnimalShelterApp.Pages.Shelters.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
