#pragma checksum "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d676d022ca4e901245f52931bd6a0edb0565e7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Upload_List), @"mvc.1.0.view", @"/Views/Upload/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Upload/List.cshtml", typeof(AspNetCore.Views_Upload_List))]
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
#line 1 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\_ViewImports.cshtml"
using DogKennel.Web;

#line default
#line hidden
#line 2 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\_ViewImports.cshtml"
using DogKennel.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d676d022ca4e901245f52931bd6a0edb0565e7e", @"/Views/Upload/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5072a9633240ad9423f90f388d2af2928bae570", @"/Views/_ViewImports.cshtml")]
    public class Views_Upload_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<DogKennel.Web.Models.DataAccessPostgreSqlProvider.DbKennelOfDog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
  
    ViewBag.Title = "Питомники ";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(172, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(179, 13, false);
#line 7 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(192, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
 foreach (var kennel in Model)
{

#line default
#line hidden
            BeginContext(236, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(256, 11, false);
#line 12 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
   Write(kennel.Name);

#line default
#line hidden
            EndContext();
            BeginContext(267, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(278, 14, false);
#line 13 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
   Write(kennel.Address);

#line default
#line hidden
            EndContext();
            BeginContext(292, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(303, 9, false);
#line 14 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
   Write(kennel.Id);

#line default
#line hidden
            EndContext();
            BeginContext(312, 14, true);
            WriteLiteral("\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 326, "\"", 351, 2);
            WriteAttributeValue("", 332, "Image?id=", 332, 9, true);
#line 15 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
WriteAttributeValue("", 341, kennel.Id, 341, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(352, 356, true);
            WriteLiteral(@" />
        <table class=""table table-bordered table-responsive table-hover"">
            <thead>
                <tr>
                    <td>Id</td>
                    <td>Порода</td>
                    <td>Пол</td>
                    <td>Дата рождения</td>
                    <td>Стоимость</td>
                </tr>
            </thead>
");
            EndContext();
#line 26 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
             if (kennel.Dog != null)
            {
                foreach (var dog in kennel.Dog)
                {

#line default
#line hidden
            BeginContext(829, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(884, 6, false);
#line 31 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
                       Write(dog.Id);

#line default
#line hidden
            EndContext();
            BeginContext(890, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(926, 9, false);
#line 32 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
                       Write(dog.Breed);

#line default
#line hidden
            EndContext();
            BeginContext(935, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(971, 10, false);
#line 33 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
                       Write(dog.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(981, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1017, 15, false);
#line 34 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
                       Write(dog.DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(1032, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1068, 16, false);
#line 35 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
                       Write(dog.CostInRubles);

#line default
#line hidden
            EndContext();
            BeginContext(1084, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 37 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(1152, 30, true);
            WriteLiteral("        </table>\r\n    </div>\r\n");
            EndContext();
#line 41 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\List.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<DogKennel.Web.Models.DataAccessPostgreSqlProvider.DbKennelOfDog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
