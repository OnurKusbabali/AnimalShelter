#pragma checksum "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Animals\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed5c5cd575751fdfca84ab45de095d721023e2b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Animals_Edit), @"mvc.1.0.razor-page", @"/Pages/Animals/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed5c5cd575751fdfca84ab45de095d721023e2b1", @"/Pages/Animals/Edit.cshtml")]
    public class Pages_Animals_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Animals\Edit.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"}



<div class=""row wrapper border-bottom white-bg page-heading"">
    <div class=""col-lg-10"">
        <h2>Animal Create Page</h2>
        <ol class=""breadcrumb"">
            <li>
                <a href=""index.html"">Home</a>
            </li>
            <li>
                <a>Animals</a>
            </li>
            <li class=""active"">
                <strong>Create</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>


<div class=""row white-bg"">
    <div class=""col-lg-12"">
        <div class=""ibox float-e-margins"">
            <div class=""ibox-title"">


            </div>
            <div class=""ibox-content"">
                <div class=""row"">
                    <div class=""col-sm-6 b-r"">
                        <h3 class=""m-t-none m-b"">Create Animal</h3>

                        <form method=""post"" enctype=""multipart/form-data"">
                            ");
#nullable restore
#line 44 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Animals\Edit.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\" readonly");
            BeginWriteAttribute("value", " value=\"", 1159, "\"", 1183, 1);
#nullable restore
#line 45 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Animals\Edit.cshtml"
WriteAttributeValue("", 1167, Model.Animal.Id, 1167, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                            <div class=\"form-group\">\r\n                                <label>Name</label> <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1321, "\"", 1347, 1);
#nullable restore
#line 47 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Animals\Edit.cshtml"
WriteAttributeValue("", 1329, Model.Animal.Name, 1329, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Name\">\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Description</label> <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1539, "\"", 1572, 1);
#nullable restore
#line 50 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Animals\Edit.cshtml"
WriteAttributeValue("", 1547, Model.Animal.Description, 1547, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Description\">\r\n                            </div>\r\n                            <select class=\"form-control\" name=\"ShelterId\">\r\n                                <option");
            BeginWriteAttribute("value", " value=\"", 1746, "\"", 1754, 0);
            EndWriteAttribute();
            WriteLiteral(">Seçilmedi</option>\r\n");
#nullable restore
#line 54 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Animals\Edit.cshtml"
                                 foreach (var item in Model.Shelters)
                                {
                                    if (item.Id == Model.Animal.SheltedId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option");
            BeginWriteAttribute("value", " value=\"", 2044, "\"", 2060, 1);
#nullable restore
#line 58 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Animals\Edit.cshtml"
WriteAttributeValue("", 2052, item.Id, 2052, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 58 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Animals\Edit.cshtml"
                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 59 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Animals\Edit.cshtml"
                                    }

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </select>
                            <div class=""fallback"">
                                <label>File</label><input class=""form-control"" type=""file"" name=""Image"" multiple />
                            </div>

                            <div>
                                <button class=""btn btn-sm btn-primary pull-right m-t-n-xs"" type=""submit""><strong>Create</strong></button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimalShelterApp.Pages.Animals.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AnimalShelterApp.Pages.Animals.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AnimalShelterApp.Pages.Animals.EditModel>)PageContext?.ViewData;
        public AnimalShelterApp.Pages.Animals.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591