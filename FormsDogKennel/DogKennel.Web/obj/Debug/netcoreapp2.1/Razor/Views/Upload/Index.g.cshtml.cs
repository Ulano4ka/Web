#pragma checksum "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c45cd10ef1ee34d6901ad36f0ca8f977344a3baa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Upload_Index), @"mvc.1.0.view", @"/Views/Upload/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Upload/Index.cshtml", typeof(AspNetCore.Views_Upload_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c45cd10ef1ee34d6901ad36f0ca8f977344a3baa", @"/Views/Upload/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5072a9633240ad9423f90f388d2af2928bae570", @"/Views/_ViewImports.cshtml")]
    public class Views_Upload_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\Index.cshtml"
  
    ViewBag.Title = "Загрузка питомника";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(77, 33, true);
            WriteLiteral("<h2>Загрузите файл .dogs</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\Index.cshtml"
 using (Html.BeginForm("DoUpload",
   "Upload",
   FormMethod.Post,
   new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
            BeginContext(230, 165, true);
            WriteLiteral("    <label for=\"file\">Загрузить файл:</label>\r\n    <input type=\"file\" name=\"file\" id=\"file\" /><br><br>\r\n    <input type=\"submit\" value=\"Отправить\" />\r\n    <br><br>\r\n");
            EndContext();
            BeginContext(400, 15, false);
#line 17 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\Index.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
#line 17 "C:\Users\Юлия\Desktop\Web\FormsDogKennel\DogKennel.Web\Views\Upload\Index.cshtml"
                    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
