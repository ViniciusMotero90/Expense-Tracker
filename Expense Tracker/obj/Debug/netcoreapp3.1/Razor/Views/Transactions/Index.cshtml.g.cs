#pragma checksum "C:\Users\W11\source\repos\Expense Tracker\Expense Tracker\Views\Transactions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ad68b0df059e6420957f9dd51a9dade606f441e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transactions_Index), @"mvc.1.0.view", @"/Views/Transactions/Index.cshtml")]
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
#line 1 "C:\Users\W11\source\repos\Expense Tracker\Expense Tracker\Views\_ViewImports.cshtml"
using Expense_Tracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\W11\source\repos\Expense Tracker\Expense Tracker\Views\_ViewImports.cshtml"
using Expense_Tracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad68b0df059e6420957f9dd51a9dade606f441e", @"/Views/Transactions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c19290a4c295dcd947e2031843f6dd5893b53d77", @"/Views/_ViewImports.cshtml")]
    public class Views_Transactions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Expense_Tracker.Models.Transaction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "CategoryTitleWithIcon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "Date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "Date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "110px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("format", "MMM-dd-yy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "Amount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "FormattedAmount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "Actions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("template", "#actionColumnTemplate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "transactions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.EJ2.Grids.Grid __Syncfusion_EJ2_Grids_Grid;
        private global::Syncfusion.EJ2.Grids.GridPageSettings __Syncfusion_EJ2_Grids_GridPageSettings;
        private global::Syncfusion.EJ2.Grids.GridColumns __Syncfusion_EJ2_Grids_GridColumns;
        private global::Syncfusion.EJ2.Grids.GridColumn __Syncfusion_EJ2_Grids_GridColumn;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\W11\source\repos\Expense Tracker\Expense Tracker\Views\Transactions\Index.cshtml"
  
    ViewData["PageTitle"] = "Transactions";
    ViewData["PageActionText"] = "+ New Transaction";
    ViewData["PageActionUrl"] = "/Transaction/AddOrEdit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-7\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ejs-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ad68b0df059e6420957f9dd51a9dade606f441e7746", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-pagesettings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ad68b0df059e6420957f9dd51a9dade606f441e8020", async() => {
                }
                );
                __Syncfusion_EJ2_Grids_GridPageSettings = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridPageSettings>();
                __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridPageSettings);
#nullable restore
#line 13 "C:\Users\W11\source\repos\Expense Tracker\Expense Tracker\Views\Transactions\Index.cshtml"
__Syncfusion_EJ2_Grids_GridPageSettings.PageSize = 10;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("pageSize", __Syncfusion_EJ2_Grids_GridPageSettings.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ad68b0df059e6420957f9dd51a9dade606f441e9413", async() => {
                    WriteLiteral("\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ad68b0df059e6420957f9dd51a9dade606f441e9705", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ad68b0df059e6420957f9dd51a9dade606f441e11088", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Syncfusion_EJ2_Grids_GridColumn.Width = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Syncfusion_EJ2_Grids_GridColumn.Type = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __Syncfusion_EJ2_Grids_GridColumn.Format = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 17 "C:\Users\W11\source\repos\Expense Tracker\Expense Tracker\Views\Transactions\Index.cshtml"
__Syncfusion_EJ2_Grids_GridColumn.TextAlign = global::Syncfusion.EJ2.Grids.TextAlign.Left;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("textAlign", __Syncfusion_EJ2_Grids_GridColumn.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ad68b0df059e6420957f9dd51a9dade606f441e13540", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_8.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 18 "C:\Users\W11\source\repos\Expense Tracker\Expense Tracker\Views\Transactions\Index.cshtml"
__Syncfusion_EJ2_Grids_GridColumn.TextAlign = global::Syncfusion.EJ2.Grids.TextAlign.Right;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("textAlign", __Syncfusion_EJ2_Grids_GridColumn.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Syncfusion_EJ2_Grids_GridColumn.Width = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ad68b0df059e6420957f9dd51a9dade606f441e15599", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_9.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                    __Syncfusion_EJ2_Grids_GridColumn.Template = (string)__tagHelperAttribute_10.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                    __Syncfusion_EJ2_Grids_GridColumn.Width = (string)__tagHelperAttribute_11.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n            ");
                }
                );
                __Syncfusion_EJ2_Grids_GridColumns = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumns>();
                __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumns);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Syncfusion_EJ2_Grids_Grid = CreateTagHelper<global::Syncfusion.EJ2.Grids.Grid>();
            __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_Grid);
            __Syncfusion_EJ2_Grids_Grid.Id = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
#nullable restore
#line 11 "C:\Users\W11\source\repos\Expense Tracker\Expense Tracker\Views\Transactions\Index.cshtml"
__Syncfusion_EJ2_Grids_Grid.DataSource = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("dataSource", __Syncfusion_EJ2_Grids_Grid.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "C:\Users\W11\source\repos\Expense Tracker\Expense Tracker\Views\Transactions\Index.cshtml"
__Syncfusion_EJ2_Grids_Grid.GridLines = global::Syncfusion.EJ2.Grids.GridLine.None;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("gridLines", __Syncfusion_EJ2_Grids_Grid.GridLines, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "C:\Users\W11\source\repos\Expense Tracker\Expense Tracker\Views\Transactions\Index.cshtml"
__Syncfusion_EJ2_Grids_Grid.AllowSorting = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("allowSorting", __Syncfusion_EJ2_Grids_Grid.AllowSorting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "C:\Users\W11\source\repos\Expense Tracker\Expense Tracker\Views\Transactions\Index.cshtml"
__Syncfusion_EJ2_Grids_Grid.AllowPaging = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("allowPaging", __Syncfusion_EJ2_Grids_Grid.AllowPaging, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-md-5"">
        <div class=""widget h-100 d-flex justify-content-center align-items-center"">
            <i class=""fa-solid fa-money-bill-transfer fa-2xl""></i>
        </div>
    </div>
</div>

<script id=""actionColumnTemplate"" type=""text/x-template"">
    <div class=""d-flex flex-row justify-content-start"">
        <a class=""btn btn-sm no-a-decoration"" href=""/Transaction/AddOrEdit/${TransactionId}"">
            <i class=""fa-solid fa-pen fa-lg""></i>
        </a>
        <form action=""/Transaction/Delete/${TransactionId}"" method=""post"">
            ");
#nullable restore
#line 36 "C:\Users\W11\source\repos\Expense Tracker\Expense Tracker\Views\Transactions\Index.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <button type=""submit"" class=""btn btn-sm btn-link no-a-decoration""
                    onclick=""return confirm(&quot;Are sure to delete this record?&quot;)"">
                <i class=""fa-solid fa-trash-can fa-lg text-danger""></i>
            </button>
        </form>
    </div>
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Expense_Tracker.Models.Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
