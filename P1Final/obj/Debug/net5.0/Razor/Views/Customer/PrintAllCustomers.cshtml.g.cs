#pragma checksum "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5148f9326122f7992753f4b228802faf7561812e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_PrintAllCustomers), @"mvc.1.0.view", @"/Views/Customer/PrintAllCustomers.cshtml")]
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
#line 1 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\_ViewImports.cshtml"
using P1Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\_ViewImports.cshtml"
using P1Final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5148f9326122f7992753f4b228802faf7561812e", @"/Views/Customer/PrintAllCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acdf2a15a351fff2771ada2d51a4657a73007f01", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_PrintAllCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<P1FinalDbContext.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml"
  
    ViewData["Title"] = "PrintAllCustomers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.Fname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.Lname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Lname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\Christian\Desktop\AllBatchFiles\ChristianRomeroP1\ChristianRomeroP1\P1Final\Views\Customer\PrintAllCustomers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<P1FinalDbContext.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
