#pragma checksum "C:\Users\bhrug\Desktop\Udemy Course Code\Lecture Code\Lecture - BulkyBook\BulkyBook\BulkyBook\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7c0a12112ce02dcf46e6ec35596dfbe30384566"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\Users\bhrug\Desktop\Udemy Course Code\Lecture Code\Lecture - BulkyBook\BulkyBook\BulkyBook\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\bhrug\Desktop\Udemy Course Code\Lecture Code\Lecture - BulkyBook\BulkyBook\BulkyBook\Areas\Identity\Pages\_ViewImports.cshtml"
using BulkyBook.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\bhrug\Desktop\Udemy Course Code\Lecture Code\Lecture - BulkyBook\BulkyBook\BulkyBook\Areas\Identity\Pages\_ViewImports.cshtml"
using BulkyBook.Areas.Identity.Pages;

#line default
#line hidden
#line 1 "C:\Users\bhrug\Desktop\Udemy Course Code\Lecture Code\Lecture - BulkyBook\BulkyBook\BulkyBook\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using BulkyBook.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c0a12112ce02dcf46e6ec35596dfbe30384566", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6c8a2572553977e8abb79c619298378415c7785", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5f64dc1a1ba62d3d5456a8ba9413e25454feeed", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\bhrug\Desktop\Udemy Course Code\Lecture Code\Lecture - BulkyBook\BulkyBook\BulkyBook\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
            WriteLiteral("\r\n<h1>");
#line 7 "C:\Users\bhrug\Desktop\Udemy Course Code\Lecture Code\Lecture - BulkyBook\BulkyBook\BulkyBook\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            WriteLiteral("</h1>\r\n");
#line 8 "C:\Users\bhrug\Desktop\Udemy Course Code\Lecture Code\Lecture - BulkyBook\BulkyBook\BulkyBook\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
            WriteLiteral("<p>\r\n    This app does not currently have a real email sender registered, see <a href=\"https://aka.ms/aspaccountconf\">these docs</a> for how to configure a real email sender.\r\n    Normally this would be emailed: <a id=\"confirm-link\"");
            BeginWriteAttribute("href", " href=\"", 415, "\"", 449, 1);
#line 13 "C:\Users\bhrug\Desktop\Udemy Course Code\Lecture Code\Lecture - BulkyBook\BulkyBook\BulkyBook\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 422, Model.EmailConfirmationUrl, 422, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">Click here to confirm your account</a>\r\n</p>\r\n");
#line 15 "C:\Users\bhrug\Desktop\Udemy Course Code\Lecture Code\Lecture - BulkyBook\BulkyBook\BulkyBook\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
            WriteLiteral("<p>\r\n        Please check your email to confirm your account.\r\n</p>\r\n");
#line 21 "C:\Users\bhrug\Desktop\Udemy Course Code\Lecture Code\Lecture - BulkyBook\BulkyBook\BulkyBook\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
