#pragma checksum "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\MembersDapper\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34816d399c9a40849dcf4047cb82ed9972e39c9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MembersDapper_Index), @"mvc.1.0.view", @"/Views/MembersDapper/Index.cshtml")]
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
#line 1 "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\_ViewImports.cshtml"
using MemberManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\_ViewImports.cshtml"
using MemberManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34816d399c9a40849dcf4047cb82ed9972e39c9d", @"/Views/MembersDapper/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c33d7de82963eebda0d0e94c44d853239754f44c", @"/Views/_ViewImports.cshtml")]
    public class Views_MembersDapper_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MM_Entities.Entities.Member>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\MembersDapper\Index.cshtml"
  
    ViewData["Title"] = "Member List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<a href=""/MembersDapper/Add"" class=""btn btn-primary"">Add</a>
<br />
<table id=""_DataTable"" class=""table compact table-striped table-bordered nowrap dataTable"" aria-describedby=""_DataTable_info"">
    <thead>
        <tr role=""row"">
            <th class=""sorting_asc"" role=""columnheader"" tabindex=""0"" aria-controls=""_DataTable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Image: activate to sort column descending"" style=""width: 127px;"">Image</th>
            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""_DataTable"" rowspan=""1"" colspan=""1"" aria-label=""Title: activate to sort column ascending"" style=""width: 209px;"">Title</th>
            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""_DataTable"" rowspan=""1"" colspan=""1"" aria-label=""City: activate to sort column ascending"" style=""width: 116px;"">City</th>
            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""_DataTable"" rowspan=""1"" colspan=""1"" aria-label=""Vacancy: activate to so");
            WriteLiteral(@"rt column ascending"" style=""width: 127px;"">Vacancy</th>
            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""_DataTable"" rowspan=""1"" colspan=""1"" aria-label=""Created Date: activate to sort column ascending"" style=""width: 190px;"">Created Date</th>
            <th style=""width: 38px;"" class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""_DataTable"" rowspan=""1"" colspan=""1"" aria-label="" Action : activate to sort column ascending""> Action </th>
        </tr>
    </thead>
    <tbody role=""alert"" aria-live=""polite"" aria-relevant=""all"">
");
#nullable restore
#line 19 "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\MembersDapper\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"even\">\r\n            <td style=\"text-align:left\"><img");
            BeginWriteAttribute("src", " src=\"", 1811, "\"", 1834, 1);
#nullable restore
#line 22 "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\MembersDapper\Index.cshtml"
WriteAttributeValue("", 1817, item.MemberImage, 1817, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" width=\"50\" height=\"50\"></td>\r\n            <td style=\"text-align:left\">");
#nullable restore
#line 23 "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\MembersDapper\Index.cshtml"
                                   Write(item.MemberTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align:left\">");
#nullable restore
#line 24 "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\MembersDapper\Index.cshtml"
                                   Write(item.MemberFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align:left\">");
#nullable restore
#line 25 "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\MembersDapper\Index.cshtml"
                                   Write(item.MemberLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align:left\">");
#nullable restore
#line 26 "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\MembersDapper\Index.cshtml"
                                    Write(item.IsActive == true ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align:right\">");
#nullable restore
#line 27 "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\MembersDapper\Index.cshtml"
                                    Write(item.CreatedDateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center \">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2289, "\"", 2339, 2);
            WriteAttributeValue("", 2296, "/MembersDapper/Edit?MemberID=", 2296, 29, true);
#nullable restore
#line 29 "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\MembersDapper\Index.cshtml"
WriteAttributeValue("", 2325, item.MemberID, 2325, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit\">Edit  <i class=\"fa fa-edit\"></i></a><a");
            BeginWriteAttribute("href", " href=\"", 2392, "\"", 2445, 2);
            WriteAttributeValue("", 2399, "/MembersDapper/Delete?&MemberID=", 2399, 32, true);
#nullable restore
#line 29 "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\MembersDapper\Index.cshtml"
WriteAttributeValue("", 2431, item.MemberID, 2431, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2446, "\"", 2454, 0);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\" Are you sure you want to delete this job?\");\" title=\"Delete\">Delete     <i class=\"fa fa-times\"></i></a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\hnicaragua\Desktop\Respaldo Tarjeta 1\Hang\MemberManagement\MemberManagement\MemberManagement\Views\MembersDapper\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MM_Entities.Entities.Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591
