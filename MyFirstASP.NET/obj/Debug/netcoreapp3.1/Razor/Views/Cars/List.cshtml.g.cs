#pragma checksum "D:\Досуг\Мои проекты\MyFirstASP.NET\MyFirstASP.NET\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c622c6376f9e59fa15abd5a136e048d31abad2a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
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
#line 1 "D:\Досуг\Мои проекты\MyFirstASP.NET\MyFirstASP.NET\Views\_ViewImports.cshtml"
using MyFirstASP.NET.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c622c6376f9e59fa15abd5a136e048d31abad2a5", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f32ecaf235754b94df24260250cac40dcf7a14a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Все автомобили</h2>\r\n<h3>");
#nullable restore
#line 3 "D:\Досуг\Мои проекты\MyFirstASP.NET\MyFirstASP.NET\Views\Cars\List.cshtml"
Write(Model.CurrCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 5 "D:\Досуг\Мои проекты\MyFirstASP.NET\MyFirstASP.NET\Views\Cars\List.cshtml"
      
        foreach (var car in Model.GetAllCars)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 230, "\"", 244, 1);
#nullable restore
#line 9 "D:\Досуг\Мои проекты\MyFirstASP.NET\MyFirstASP.NET\Views\Cars\List.cshtml"
WriteAttributeValue("", 236, car.Img, 236, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 245, "\"", 260, 1);
#nullable restore
#line 9 "D:\Досуг\Мои проекты\MyFirstASP.NET\MyFirstASP.NET\Views\Cars\List.cshtml"
WriteAttributeValue("", 251, car.Name, 251, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                <h2>Модель: ");
#nullable restore
#line 10 "D:\Досуг\Мои проекты\MyFirstASP.NET\MyFirstASP.NET\Views\Cars\List.cshtml"
                       Write(car.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <h3>");
#nullable restore
#line 11 "D:\Досуг\Мои проекты\MyFirstASP.NET\MyFirstASP.NET\Views\Cars\List.cshtml"
               Write(car.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p>Цена: ");
#nullable restore
#line 12 "D:\Досуг\Мои проекты\MyFirstASP.NET\MyFirstASP.NET\Views\Cars\List.cshtml"
                    Write(car.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><a class=\"btn btn warning\" href=\"#\">Подробно</a></p>\r\n            </div>\r\n");
#nullable restore
#line 15 "D:\Досуг\Мои проекты\MyFirstASP.NET\MyFirstASP.NET\Views\Cars\List.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
