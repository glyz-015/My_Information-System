#pragma checksum "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad64b3d3949ef995c258d42a71d3f0c2ef7627de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Modify), @"mvc.1.0.view", @"/Views/Home/Modify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Modify.cshtml", typeof(AspNetCore.Views_Home_Modify))]
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
#line 1 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\_ViewImports.cshtml"
using CUMCIS;

#line default
#line hidden
#line 2 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\_ViewImports.cshtml"
using CUMCIS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad64b3d3949ef995c258d42a71d3f0c2ef7627de", @"/Views/Home/Modify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbc5209012f6b1d87673187efe56ecf19c09acb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Modify : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchstyle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
  
  var mem = (List<Myembro>)ViewData["mem"];

  List<Myembro> myembros = (List<Myembro>) ViewData["Myembro"];

#line default
#line hidden
            BeginContext(119, 209, true);
            WriteLiteral("\r\n<h2>Modify</h2>\r\n<ul class=\"breadcrumb\">\r\n  <li><a href=\"\\Home\\Members\">Add Member</a></li>\r\n  <li><a href=\"\\Home\\Modify\">Modify</a></li>\r\n  <li><a href=\"\\Home\\UserAccounts\">User Accounts</a></li>\r\n</ul>\r\n\r\n");
            EndContext();
            BeginContext(328, 324, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad64b3d3949ef995c258d42a71d3f0c2ef7627de5136", async() => {
                BeginContext(391, 254, true);
                WriteLiteral("\r\n      \r\n      <input type=\"text\" name=\"searchpamore\" class=\"form-control\" placeholder=\"Search Name....\">\r\n      <button type = \"submit\" class=\"btn btn-primary\">Search</button>\r\n      <!--<input type=\"submit\" class=\"btn btn-primary\" value=\"Search\">-->\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(652, 304, true);
            WriteLiteral(@"



  <table class=""table table-hover"" id=""TableKo"" style=""overflow-x:auto;"">
        <tr class=""header""> 
          <th> </th>
          <th onclick=""SortName(0)"">Name</th>
          <th>Group</th>
          <th>Address</th>
          <th>Contact</th>
          <th>Email</th>
       </tr>
");
            EndContext();
#line 32 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
        foreach (var item in mem)
       {

#line default
#line hidden
            BeginContext(1001, 30, true);
            WriteLiteral("         <tr>\r\n           <td>");
            EndContext();
            BeginContext(1032, 7, false);
#line 35 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
          Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(1039, 22, true);
            WriteLiteral("</td>\r\n           <td>");
            EndContext();
            BeginContext(1062, 10, false);
#line 36 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
          Write(item.fname);

#line default
#line hidden
            EndContext();
            BeginContext(1072, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1074, 10, false);
#line 36 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
                      Write(item.lname);

#line default
#line hidden
            EndContext();
            BeginContext(1084, 24, true);
            WriteLiteral(" </td> \r\n           <td>");
            EndContext();
            BeginContext(1109, 8, false);
#line 37 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
          Write(item.grp);

#line default
#line hidden
            EndContext();
            BeginContext(1117, 22, true);
            WriteLiteral("</td>\r\n           <td>");
            EndContext();
            BeginContext(1140, 12, false);
#line 38 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
          Write(item.address);

#line default
#line hidden
            EndContext();
            BeginContext(1152, 22, true);
            WriteLiteral("</td>\r\n           <td>");
            EndContext();
            BeginContext(1175, 12, false);
#line 39 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
          Write(item.contact);

#line default
#line hidden
            EndContext();
            BeginContext(1187, 22, true);
            WriteLiteral("</td>\r\n           <td>");
            EndContext();
            BeginContext(1210, 10, false);
#line 40 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
          Write(item.email);

#line default
#line hidden
            EndContext();
            BeginContext(1220, 24, true);
            WriteLiteral("</td>\r\n           <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1244, "\"", 1273, 2);
            WriteAttributeValue("", 1251, "/home/edit?id=", 1251, 14, true);
#line 41 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
WriteAttributeValue("", 1265, item.id, 1265, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1274, 53, true);
            WriteLiteral(" class=\"btn btn-primary\">Edit</a></td>\r\n\r\n           ");
            EndContext();
            BeginContext(1327, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad64b3d3949ef995c258d42a71d3f0c2ef7627de10775", async() => {
                BeginContext(1369, 49, true);
                WriteLiteral("\r\n           <td><input type=\"hidden\" name = \"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1418, "\"", 1434, 1);
#line 44 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
WriteAttributeValue("", 1426, item.id, 1426, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1435, 100, true);
                WriteLiteral("></td>\r\n           <td><input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\"></td>\r\n           ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1542, 95, true);
            WriteLiteral("\r\n\r\n        \r\n        <!--<div class = \"container\">\r\n            <td><input name = \"id\" value=\"");
            EndContext();
            BeginContext(1638, 7, false);
#line 50 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
                                     Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(1645, 822, true);
            WriteLiteral(@"""></td>
            <td><button type=""button"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#myModal"">Delete</button></td>
           <div class=""modal fade"" id=""myModal"" role=""dialog"">
                  <div class=""modal-dialog modal-sm"">
                    <div class=""modal-content"">
                      <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                        <h4 class=""modal-title"">STOP!!</h4>
                      </div>
                      <div class=""modal-body"">
                        <p>Are you sure you want to DELETE this record?</p>
                        
                        <form action=""/home/delete"" method=""post"">
                        <input type=""text"" name=""id"" value=""");
            EndContext();
            BeginContext(2468, 7, false);
#line 63 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
                                                       Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(2475, 499, true);
            WriteLiteral(@""">
                        <input type=""submit"" class=""btn btn-default"" value=""Yes"">
                        </form>
                        
                        <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">No</button>
                      </div>
                      
                    </div>
                  </div>  
           </div>
        </div>-->

            <td><button type=""button"" class=""btn btn-info"">Archive</button></td>
          </tr>
");
            EndContext();
#line 77 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Modify.cshtml"
        }

#line default
#line hidden
            BeginContext(2985, 1266, true);
            WriteLiteral(@"    </table>


  <script>
    function SortName(n){
      var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
      table = document.getElementById(""TableKo"");
      switching = true;

      dir = ""asc"";

      while (switching){
        switching = false;
        rows = table.rows;

        for (i = 1; i < (rows.length - 1); i++) {
          shouldSwitch = false;
          x = rows[i].getElementsByTagName(""TD"")[n];
          y = rows[i + 1].getElementsByTagName(""TD"")[n];

            if (dir == ""asc""){
              if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()){
                shouldSwitch = true;
                break;
              }
            } else if (dir == ""desc""){
              if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()){
                shouldSwitch = true;
                break;
              }
            }
        }
        if (shouldSwitch) {
          rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
    ");
            WriteLiteral("      switching = true;\r\n          switchcount ++;\r\n        } else {\r\n            if (switchcount == 0 && dir == \"asc\") {\r\n            dir = \"desc\";\r\n            switching = true;\r\n        }\r\n        \r\n        }\r\n\r\n      }\r\n    }\r\n  </script>");
            EndContext();
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
