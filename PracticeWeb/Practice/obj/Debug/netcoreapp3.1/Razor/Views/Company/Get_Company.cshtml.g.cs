#pragma checksum "C:\Git_Repo\DotNet\Practice\Practice\Views\Company\Get_Company.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e91ccc3da732b9f24254ad00d66991fd6f1ce394"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Get_Company), @"mvc.1.0.view", @"/Views/Company/Get_Company.cshtml")]
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
#line 1 "C:\Git_Repo\DotNet\Practice\Practice\Views\_ViewImports.cshtml"
using Practice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git_Repo\DotNet\Practice\Practice\Views\_ViewImports.cshtml"
using Practice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e91ccc3da732b9f24254ad00d66991fd6f1ce394", @"/Views/Company/Get_Company.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd757ed8785d7859154d904007503f4f18d9d71", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Company_Get_Company : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CompanyModel>>
    #nullable disable
    {
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
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e91ccc3da732b9f24254ad00d66991fd6f1ce3943296", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <style>
        table {
            border-collapse: collapse;
            border-spacing: 0;
            width: 100%;
            border: 1px solid #ddd;
        }

        th, td {
            text-align: left;
            padding: 8px;
        }

        tr:nth-child(even) {
            background-color: #f2f2f2
        }
    </style>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e91ccc3da732b9f24254ad00d66991fd6f1ce3944700", async() => {
                WriteLiteral("\r\n    <h1>Number of Records Found : ");
#nullable restore
#line 27 "C:\Git_Repo\DotNet\Practice\Practice\Views\Company\Get_Company.cshtml"
                             Write(Model.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("; </h1>\r\n\r\n    <div style=\"overflow-x:auto;\">\r\n        <table>\r\n            <tr>\r\n\r\n                <th>company_id</th>\r\n                <th>comapny_name</th>\r\n                <th>company_founded_on</th>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Git_Repo\DotNet\Practice\Practice\Views\Company\Get_Company.cshtml"
             foreach (var cmp in @Model.ToList())
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n\r\n                    <th>");
#nullable restore
#line 42 "C:\Git_Repo\DotNet\Practice\Practice\Views\Company\Get_Company.cshtml"
                   Write(cmp.comapny_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 43 "C:\Git_Repo\DotNet\Practice\Practice\Views\Company\Get_Company.cshtml"
                   Write(cmp.comapny_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 44 "C:\Git_Repo\DotNet\Practice\Practice\Views\Company\Get_Company.cshtml"
                   Write(cmp.company_founded_on);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    \r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Git_Repo\DotNet\Practice\Practice\Views\Company\Get_Company.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CompanyModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
