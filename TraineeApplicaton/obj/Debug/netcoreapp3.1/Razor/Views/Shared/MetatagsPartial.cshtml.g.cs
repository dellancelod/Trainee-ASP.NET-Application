#pragma checksum "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\MetatagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "633024611d3dc4698e6a57fc3f605331cce4636d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TraineeApplication.Pages.Shared.Views_Shared_MetatagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartial.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\MetatagsPartial.cshtml"
using TraineeApplication.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"633024611d3dc4698e6a57fc3f605331cce4636d", @"/Views/Shared/MetatagsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"664da66c5beb6e4a22ea9e921244608dd0e3804b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetatagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n");
#nullable restore
#line 4 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 6 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\MetatagsPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 7 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\MetatagsPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 10 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\MetatagsPartial.cshtml"
      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 11 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 339, "\"", 369, 1);
#nullable restore
#line 14 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 349, ViewBag.Description, 349, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 15 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\MetatagsPartial.cshtml"
 if(ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 437, "\"", 464, 1);
#nullable restore
#line 18 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 447, ViewBag.Keywords, 447, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 19 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
