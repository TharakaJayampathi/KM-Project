#pragma checksum "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ada49a6ef1cd1116ccfc03a60c450b807f6b0df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\_ViewImports.cshtml"
using InAndOut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\_ViewImports.cshtml"
using InAndOut.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ada49a6ef1cd1116ccfc03a60c450b807f6b0df", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68bf42a2f6da1b0bba0ff4b16a23c8e4ecef32e", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InAndOut.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row pt-4\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-primary\">Employee List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ada49a6ef1cd1116ccfc03a60c450b807f6b0df5997", async() => {
                WriteLiteral("Create new Employee");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
 if (Model.Count() > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
             using (Html.BeginForm("Index", "Employee", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""form-horizontal"">

                    <div class=""form-group"">

                        <label class=""col-md-2 control-label"">Search</label>

                        <div class=""col-md-12 justify-content-xl-center"">
                            <input type=""text"" name=""searchTxt"" class=""form-control"" placeholder=""Search your text here"" style=""max-width: 100%"" />
                        </div>

                        <div class=""col-md-2 justify-content-center"">
                            <button class=""btn btn-primary"" type=""submit""><span class=""glyphicon glyphicon-search""></span>Search</button>
                        </div>

");
            WriteLiteral("\r\n                    </div>\r\n\r\n\r\n                </div>\r\n");
#nullable restore
#line 51 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

        <div class=""row"">
            <div class=""col-md-12"">
                <table class=""table table-sm"">
                    <thead>
                        <tr>
                            <th>
                                Id
                            </th>
                            <th style=""text-align:center"">
                                Name
");
            WriteLiteral("                            </th>\r\n                            <th style=\"text-align:center\">\r\n                                Email\r\n");
            WriteLiteral("                            </th>\r\n                            <th style=\"text-align:center\">\r\n                                Gender\r\n");
            WriteLiteral("                            </th>\r\n                            <th style=\"text-align:center\">\r\n                                Designation\r\n");
            WriteLiteral("                            </th>\r\n                            <th style=\"text-align:center\">\r\n                                Phone No\r\n");
            WriteLiteral("                            </th>\r\n                            <th style=\"text-align:center\">\r\n                                Address\r\n");
            WriteLiteral(@"                            </th>
                            <th style=""text-align:center"">
                                Actions
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 94 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                         foreach (var employee in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td width=\"5%\">");
#nullable restore
#line 97 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                                          Write(employee.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"text-align:center\" width=\"10%\">");
#nullable restore
#line 98 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                                                                     Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"text-align:center\" width=\"10%\">");
#nullable restore
#line 99 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                                                                     Write(employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"text-align:center\" width=\"10%\">");
#nullable restore
#line 100 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                                                                     Write(employee.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"text-align:center\" width=\"10%\">");
#nullable restore
#line 101 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                                                                     Write(employee.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"text-align:center\" width=\"10%\">");
#nullable restore
#line 102 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                                                                     Write(employee.PhoneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"text-align:center\" width=\"20%\">");
#nullable restore
#line 103 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                                                                     Write(employee.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"text-align:center\" width=\"10%\">\r\n                                    <div class=\"w-100 btn-group\" role=\"group\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ada49a6ef1cd1116ccfc03a60c450b807f6b0df14117", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                                                                                          WriteLiteral(employee.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ada49a6ef1cd1116ccfc03a60c450b807f6b0df16686", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                                                                                          WriteLiteral(employee.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 111 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n\r\n");
#nullable restore
#line 116 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                  

                    double totalPages = ViewBag.TotalPages;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 121 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                         if (ViewBag.PageNumber == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                ");
#nullable restore
#line 124 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                           Write(Html.ActionLink("Previous", "Index", new { SortOrder = ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder, SortBy = ViewBag.SortBy == null ? "Name" : ViewBag.SortBy, PageNumber = ViewBag.PageNumber }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 126 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"

                        }
                        else
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                ");
#nullable restore
#line 132 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                           Write(Html.ActionLink("Previous", "Index", new { SortOrder = ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder, SortBy = ViewBag.SortBy == null ? "Name" : ViewBag.SortBy, PageNumber = ViewBag.PageNumber - 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 134 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 138 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                         for (int i = 1; i <= totalPages; i++)
                        {

                            if (i == ViewBag.PageNumber)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"active\">\r\n                                    ");
#nullable restore
#line 145 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                               Write(Html.ActionLink(i.ToString(), "Index", new { SortOrder = ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder, SortBy = ViewBag.SortBy == null ? "Name" : ViewBag.SortBy, PageNumber = i }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 147 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"

                            }

                            else
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    ");
#nullable restore
#line 154 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                               Write(Html.ActionLink(i.ToString(), "Index", new { SortOrder = ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder, SortBy = ViewBag.SortBy == null ? "Name" : ViewBag.SortBy, PageNumber = i }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 156 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"

                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 161 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                         if (ViewBag.PageNumber == totalPages)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                ");
#nullable restore
#line 165 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                           Write(Html.ActionLink("Next", "Index", new { SortOrder = ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder, SortBy = ViewBag.SortBy == null ? "Name" : ViewBag.SortBy, PageNumber = ViewBag.PageNumber }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 167 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                        }

                        else
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                ");
#nullable restore
#line 173 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
                           Write(Html.ActionLink("Next", "Index", new { SortOrder = ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder, SortBy = ViewBag.SortBy == null ? "Name" : ViewBag.SortBy, PageNumber = ViewBag.PageNumber + 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 175 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n");
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 187 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No such Employee record created yet</p>\r\n");
#nullable restore
#line 192 "C:\Users\Tharaka Jayampathi\Desktop\Git Implementation 5\KM-Project\InAndOut\InAndOut\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InAndOut.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
