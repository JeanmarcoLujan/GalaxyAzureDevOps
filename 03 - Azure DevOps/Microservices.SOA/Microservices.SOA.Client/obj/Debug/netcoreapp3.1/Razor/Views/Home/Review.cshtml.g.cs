#pragma checksum "D:\OneDrive\Galaxy\Microservices\01 - Microservices\Microservices.SOA\Microservices.SOA.Client\Views\Home\Review.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b53d8266a42d165f32d1e5f9046db1aac6ab32f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Review), @"mvc.1.0.view", @"/Views/Home/Review.cshtml")]
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
#line 1 "D:\OneDrive\Galaxy\Microservices\01 - Microservices\Microservices.SOA\Microservices.SOA.Client\Views\_ViewImports.cshtml"
using Microservices.SOA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive\Galaxy\Microservices\01 - Microservices\Microservices.SOA\Microservices.SOA.Client\Views\_ViewImports.cshtml"
using Microservices.SOA.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b53d8266a42d165f32d1e5f9046db1aac6ab32f", @"/Views/Home/Review.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccdc25446d5b2257a7cdaf05929526dd2d20f63d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Review : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Microservices.SOA.Client.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Please review your order</h2>\r\n");
#nullable restore
#line 4 "D:\OneDrive\Galaxy\Microservices\01 - Microservices\Microservices.SOA\Microservices.SOA.Client\Views\Home\Review.cshtml"
Write(Html.DisplayForModel());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>\r\n    ");
#nullable restore
#line 6 "D:\OneDrive\Galaxy\Microservices\01 - Microservices\Microservices.SOA\Microservices.SOA.Client\Views\Home\Review.cshtml"
Write(Html.LabelFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 7 "D:\OneDrive\Galaxy\Microservices\01 - Microservices\Microservices.SOA\Microservices.SOA.Client\Views\Home\Review.cshtml"
Write(Html.DisplayFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h3>\r\n<input type=\"button\" value=\"Confirm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 227, "\"", 290, 3);
            WriteAttributeValue("", 237, "location.href=\'", 237, 15, true);
#nullable restore
#line 9 "D:\OneDrive\Galaxy\Microservices\01 - Microservices\Microservices.SOA\Microservices.SOA.Client\Views\Home\Review.cshtml"
WriteAttributeValue("", 252, Url.Action("Confirm", "Home", Model), 252, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 289, "\'", 289, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Microservices.SOA.Client.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591