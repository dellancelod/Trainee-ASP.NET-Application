#pragma checksum "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "296dcae96869d0724ebd4e4b5d986607ca70aa9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TraineeApplication.Pages.Shared.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"296dcae96869d0724ebd4e4b5d986607ca70aa9e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"664da66c5beb6e4a22ea9e921244608dd0e3804b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("left-sidebar is-preload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE HTML>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296dcae96869d0724ebd4e4b5d986607ca70aa9e4548", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 5 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("MetatagsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 6 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("CssPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296dcae96869d0724ebd4e4b5d986607ca70aa9e6043", async() => {
                WriteLiteral("\r\n\r\n    <div id=\"page-wrapper\">\r\n\r\n        ");
#nullable restore
#line 12 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("HeaderPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n        <div class=\"wrapper\">\r\n            <div class=\"container\" id=\"main\">\r\n                <div class=\"row gtr-150\">\r\n\r\n                    <div class=\"col-8 col-12-narrower imp-narrower\">\r\n                        ");
#nullable restore
#line 20 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-4 col-12-narrower\">\r\n\r\n                        ");
#nullable restore
#line 24 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\_Layout.cshtml"
                   Write(await Html.PartialAsync("SidebarPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n");
                WriteLiteral("            </div>\r\n        </div>\r\n\r\n        ");
#nullable restore
#line 80 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("FooterPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 84 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("ChatPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    \r\n    ");
#nullable restore
#line 86 "C:\Users\Admin\source\repos\TraineeApplicaton\TraineeApplicaton\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("ScriptsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
