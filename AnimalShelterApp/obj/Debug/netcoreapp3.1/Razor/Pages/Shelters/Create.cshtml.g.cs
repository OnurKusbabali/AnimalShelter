#pragma checksum "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8a43274505bfce542a3d330b437424370cf63d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shelters_Create), @"mvc.1.0.razor-page", @"/Pages/Shelters/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8a43274505bfce542a3d330b437424370cf63d2", @"/Pages/Shelters/Create.cshtml")]
    public class Pages_Shelters_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\javid\OneDrive\Desktop\New folder\AnimalShelter\AnimalShelter\AnimalShelterApp\Pages\Shelters\Create.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row wrapper border-bottom white-bg page-heading"">
    <div class=""col-lg-10"">
        <h2>Basic Form</h2>
        <ol class=""breadcrumb"">
            <li>
                <a href=""index.html"">Home</a>
            </li>
            <li>
                <a>Forms</a>
            </li>
            <li class=""active"">
                <strong>Shelter Create</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-7"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-content"">
                    <form asp-action=""Creata"" asp-controller=""Shelter"" method=""post"">
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label"">Adı</label>
                            <div class=""col-sm-10""><input type=""text"" name=""Name"" class=""form-control""></div>
     ");
            WriteLiteral(@"                   </div>
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label"">Açıklama</label>
                            <div class=""col-sm-10""><input type=""text"" name=""Description"" class=""form-control""></div>
                        </div>
                    </form>
                </div>
            </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimalShelterApp.Pages.Shelters.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AnimalShelterApp.Pages.Shelters.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AnimalShelterApp.Pages.Shelters.CreateModel>)PageContext?.ViewData;
        public AnimalShelterApp.Pages.Shelters.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591