#pragma checksum "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a56d1f6545d51a8cfb4edf7455b0797507e939e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TraineeApplication.Pages.Shared.Views_Shared_FooterPartial), @"mvc.1.0.view", @"/Views/Shared/FooterPartial.cshtml")]
namespace TraineeApplication.Pages.Shared
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
#line 1 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\_ViewImports.cshtml"
using TraineeApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\_ViewImports.cshtml"
using TraineeApplication.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\_ViewImports.cshtml"
using TraineeApplication.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\_ViewImports.cshtml"
using TraineeApplication.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\_ViewImports.cshtml"
using TraineeApplication.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\_ViewImports.cshtml"
using TraineeApplication.Model.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a56d1f6545d51a8cfb4edf7455b0797507e939e1", @"/Views/Shared/FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"664da66c5beb6e4a22ea9e921244608dd0e3804b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Footer -->\r\n<div id=\"footer-wrapper\">\r\n    <div id=\"copyright\" class=\"container\">\r\n        <ul class=\"menu\">\r\n            <li>&copy; ");
#nullable restore
#line 5 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\FooterPartial.cshtml"
                  Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(". All rights reserved.</li>\r\n        </ul>\r\n    </div>\r\n</div>");
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
