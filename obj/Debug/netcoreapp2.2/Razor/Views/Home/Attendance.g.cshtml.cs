#pragma checksum "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Attendance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db50502c905e1d74ab315bb27b810f9f8d2a6d38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Attendance), @"mvc.1.0.view", @"/Views/Home/Attendance.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Attendance.cshtml", typeof(AspNetCore.Views_Home_Attendance))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db50502c905e1d74ab315bb27b810f9f8d2a6d38", @"/Views/Home/Attendance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbc5209012f6b1d87673187efe56ecf19c09acb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Attendance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Attendance.cshtml"
  
  var mem = (List<Myembro>)ViewData["mem"];


#line default
#line hidden
            BeginContext(54, 170, true);
            WriteLiteral("\r\n<h2>Attendance</h2>\r\n\r\n  <table class=\"table table-hover\" align=\"right\">\r\n      <thead>\r\n        <tr>\r\n          <th> </th>\r\n       </tr>\r\n     </thead>\r\n     <tbody>\r\n");
            EndContext();
#line 15 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Attendance.cshtml"
        foreach (var item in mem)
       {

#line default
#line hidden
            BeginContext(269, 103, true);
            WriteLiteral("         <tr>\r\n           <td><input type=\"checkbox\" onclick=\"myFunction()\" name=\"attendance\" id=\"att\">");
            EndContext();
            BeginContext(373, 7, false);
#line 18 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Attendance.cshtml"
                                                                                   Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(380, 22, true);
            WriteLiteral("</td>\r\n           <td>");
            EndContext();
            BeginContext(403, 10, false);
#line 19 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Attendance.cshtml"
          Write(item.fname);

#line default
#line hidden
            EndContext();
            BeginContext(413, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(415, 10, false);
#line 19 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Attendance.cshtml"
                      Write(item.lname);

#line default
#line hidden
            EndContext();
            BeginContext(425, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(427, 10, false);
#line 19 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Attendance.cshtml"
                                  Write(item.mname);

#line default
#line hidden
            EndContext();
            BeginContext(437, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(439, 11, false);
#line 19 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Attendance.cshtml"
                                              Write(item.suffix);

#line default
#line hidden
            EndContext();
            BeginContext(450, 23, true);
            WriteLiteral("</td>\r\n         </tr>\r\n");
            EndContext();
#line 21 "C:\Users\Glysdi Oandasan\Documents\MyProject\CUMCIS\Views\Home\Attendance.cshtml"
       }

#line default
#line hidden
            BeginContext(483, 144, true);
            WriteLiteral("     </tbody>\r\n  </table>\r\n\r\n  <script>\r\n      function myFunction(){\r\n          document.getElementById(\"att\").click();\r\n      }\r\n  </script>\r\n");
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
